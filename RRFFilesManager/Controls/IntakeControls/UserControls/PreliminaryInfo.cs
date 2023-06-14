using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.Abstractions;
using RRFFilesManager.Logic;
using RRFFilesManager.Controls.IntakeControls;
using RRFFilesManager.Controls.FileControls.UserControls;

namespace RRFFilesManager.IntakeForm
{
    public partial class PreliminaryInfo : UserControl
    {
        private readonly IMatterTypeRepository _matterTypeRepository;
        private readonly IMatterSubTypeRepository _matterSubTypeRepository;
        private readonly IHearAboutUsRepository _hearAboutUsRepository;
        private readonly ILawyerRepository _lawyerRepository;
        private readonly IFileRepository _fileRepository;
        private readonly IContactRepository _contactRepository;
        private readonly Logic.FileManager _fileManager;
        private readonly IFileStatusRepository _fileStatusRepository;
        private readonly QuestionnaireManager _questionnaireManager;
        TaskActions Task_Actions = new TaskActions(true);
        ContextMenuStrip Ctms_TaskActions;
        private Lawyer User;
        private readonly IPermissionRepository _permissionRepository;
        private int clearance;
        public PreliminaryInfo()
        {
            _matterTypeRepository = Program.GetService<IMatterTypeRepository>();
            _matterSubTypeRepository = Program.GetService<IMatterSubTypeRepository>();
            _hearAboutUsRepository = Program.GetService<IHearAboutUsRepository>();
            _lawyerRepository = Program.GetService<ILawyerRepository>();
            _fileRepository = Program.GetService<IFileRepository>();
            _fileStatusRepository = Program.GetService<IFileStatusRepository>();
            _fileManager = new Logic.FileManager();
            _questionnaireManager = new QuestionnaireManager();
            _permissionRepository = Program.GetService<IPermissionRepository>();
            _contactRepository = Program.GetService<IContactRepository>();
            User = Program.GetUser();
            InitializeComponent();
            Initialize();
            Ctms_TaskActions = Task_Actions.Ctms_TaskActions;
            Home.Instance.AddPermissionStrip(FileNumberLabel);
            SetStatusClearancePermissions();
        }

        private void SetStatusClearancePermissions()
        {
            clearance = Home.Instance.GetClearance(FileNumberLabel);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
            {
                FileNumberUpDown.Enabled = true;
            }
            else
            {
                FileNumberUpDown.Enabled = false;
            }
        }

        public new bool Validate()
        {
            if (string.IsNullOrEmpty(MatterTypeComboBox.Text) | string.IsNullOrEmpty(StaffInterviewerComboBox.Text) | string.IsNullOrEmpty(HowHearComboBox.Text) | string.IsNullOrEmpty(ResponsibleLawyerComboBox.Text) | string.IsNullOrEmpty(LawyerComboBox.Text) | DateOfLossDateTimePicker.CustomFormat == " ")
            {
                if (string.IsNullOrEmpty(MatterTypeComboBox.Text))
                {
                    MessageBox.Show("Please select: Matter Type");
                    return false;
                }

                if (string.IsNullOrEmpty(StaffInterviewerComboBox.Text))
                {
                    MessageBox.Show("Please select: Staff Interviewer");
                    return false;
                }

                if (string.IsNullOrEmpty(HowHearComboBox.Text))
                {
                    MessageBox.Show("Please select: How did you hear about us?");
                    return false;
                }

                /*if (string.IsNullOrEmpty(ResponsibleLawyerComboBox.Text))
                {
                    MessageBox.Show("Please select: Responsible Lawyer");
                    return false;
                }*/

                if (string.IsNullOrEmpty(LawyerComboBox.Text))
                {
                    MessageBox.Show("Please select: File Lawyer");
                    return false;
                }

                if (DateOfLossDateTimePicker.CustomFormat == " ")
                {
                    MessageBox.Show("Please select: Date of Loss");
                    return false;
                }
            }
            else if (MatterSubTypeComboBox.Items.Count > 0 & string.IsNullOrEmpty(MatterSubTypeComboBox.Text))
            {
                MessageBox.Show("Please select: Matter Sub Type");
                return false;
            }
            /*if (FileNumberTextBox.Text == "999999999" || FileNumberTextBox.Text == "0")
            {
                MessageBox.Show("Invalid File Number, please select File Lawyer again.");
                return false;
            }*/
            if (FileNumberUpDown.Value == 999999999 || FileNumberUpDown.Value == 0)
            {
                MessageBox.Show("Invalid File Number, please select File Lawyer again.");
                return false;
            }

            return true;
        }

        

        private void MatterSubTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var matterSubType = (MatterSubType)MatterSubTypeComboBox.SelectedItem;
            SetStatutoryNoticeBox(matterSubType);
        }

        private void DateOfLossDateTimePicker_ValueChanged(object Sender, EventArgs e)
        {
            DateOfLossDateTimePicker.CustomFormat = "MMM-dd-yyyy";
            var matterSubType = (MatterSubType)MatterSubTypeComboBox.SelectedItem;
            SetStatutoryNoticeBox(matterSubType);

            if (DateOfLossDateTimePicker.CustomFormat == "MMM-dd-yyyy")
            {
                LimitationPeriodTextBox.Text = DateOfLossDateTimePicker.Value.AddYears(2).ToString("MMM-dd-yyyy");
            }
        }
        public void SetStatutoryNoticeBox(MatterSubType matterSubType)
        {
            if (matterSubType == null)
                return;

            if (matterSubType?.DaysFromDateOfLoss != null)
            {
                StatutoryNoticeBox.Text = DateOfLossDateTimePicker.Value.AddDays((double)matterSubType?.DaysFromDateOfLoss).ToString("MMM-dd-yyyy");
                StatutoryNoticeLabel.Show();
                StatutoryNoticeLabel.Show();
                StatutoryNoticeBox.Enabled = true;
            }
            else if(matterSubType.StatutoryNotice != null)
            {
                StatutoryNoticeBox.Text = matterSubType.StatutoryNotice;
                StatutoryNoticeLabel.Hide();
                StatutoryNoticeBox.Show();
                StatutoryNoticeBox.Enabled = false;
            }

        }

        private void LawyerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lawyer = (Lawyer)LawyerComboBox.SelectedItem;
            var fileNumber = IntakeManager.GetNewFileNumber(lawyer);
            FileNumberUpDown.Value = fileNumber;
            //FileNumberTextBox.Text = fileNumber.ToString();
        }

        private void PreliminaryInfo_Load(object sender, EventArgs e)
        {
            
        }

        

        private void Initialize()
        {
            Utils.Utils.SetComboBoxDataSource(MatterTypeComboBox, _matterTypeRepository.List(), nameof(MatterType.Description));
            Utils.Utils.SetComboBoxDataSource(HowHearComboBox, _hearAboutUsRepository.List(), nameof(HearAboutUs.Description));
            Utils.Utils.SetComboBoxDataSource(StaffInterviewerComboBox, _lawyerRepository.List(), nameof(Lawyer.Description));
            Utils.Utils.SetComboBoxDataSource(ResponsibleLawyerComboBox, _lawyerRepository.List()?.Where(s => s.ResponsibleLawyer == true).ToList(), nameof(Lawyer.Description));
            Utils.Utils.SetComboBoxDataSource(LawyerComboBox, _lawyerRepository.List()?.Where(s => s.Number != null && s.FileLawyer == true).ToList(), nameof(Lawyer.Description));
            DateOfLossDateTimePicker.Format = DateTimePickerFormat.Custom;
            DateOfLossDateTimePicker.CustomFormat = " ";
        }

        public void FillFile(Abstractions.File file)
        {
            /*if (!string.IsNullOrEmpty(FirstNameTBox.Text) || !string.IsNullOrEmpty(LastNameTBox.Text))
            {
                FillPrelimClient(file);
            }*/
            file.MatterType = (MatterType)MatterTypeComboBox.SelectedItem;
            file.DateOfCall = DateOFCallDateTimePicker.Value;
            file.StaffInterviewer = (Lawyer)StaffInterviewerComboBox.SelectedItem;
            file.HowHear = (HearAboutUs)HowHearComboBox.SelectedItem;
            file.FileLawyer = (Lawyer)LawyerComboBox.SelectedItem;
            if (ResponsibleLawyerComboBox.SelectedItem != null)
                file.ResponsibleLawyer = (Lawyer)ResponsibleLawyerComboBox.SelectedItem;
            file.DateOFLoss = DateOfLossDateTimePicker.Value;
            file.LimitationPeriod = LimitationPeriodTextBox.Text;
            file.MatterSubType = (MatterSubType)MatterSubTypeComboBox.SelectedItem;
            //file.FileNumber = int.Parse(FileNumberTextBox.Text);
            file.FileNumber = Convert.ToInt32(FileNumberUpDown.Value);
            file.StatutoryNotice = StatutoryNoticeBox.Text;
            file.AdditionalNotes = AdditionalNotesTextBox.Text;
            file.CurrentStatus = _fileStatusRepository.GetById((int)FileStatusEnum.PotentialFile);
        }

        public void FillPrelimClient(Abstractions.File file)
        {

            /*if (Home.IntakeForm.Intake.File.Client == null)
                Home.IntakeForm.Intake.File.Client = new Contact();
            var client = Home.IntakeForm.Intake.File.Client;
            client.FirstName = FirstNameTBox.Text;
            client.LastName = LastNameTBox.Text;
            if (client.ID == default)
                _contactRepository.Insert(client);
            else
                _contactRepository.Update(client);*/
        }

        public void FillForm(Abstractions.File file)
        {
            if (file.Client != null)
            {
                FirstNameTBox.Text = file.Client.FirstName;
                LastNameTBox.Text = file.Client.LastName;
            }
            MatterTypeComboBox.SelectedItem = file.MatterType;
            DateOFCallDateTimePicker.Value= file.DateOfCall;
            StaffInterviewerComboBox.SelectedItem = file.StaffInterviewer;
            HowHearComboBox.SelectedItem = file.HowHear;
            LawyerComboBox.SelectedItem = file.FileLawyer;
            if (file.ResponsibleLawyer != null)
                ResponsibleLawyerComboBox.SelectedItem = file.ResponsibleLawyer;
            DateOfLossDateTimePicker.Value = file.DateOFLoss;
            LimitationPeriodTextBox.Text = file.LimitationPeriod;
            MatterSubTypeComboBox.SelectedItem = file.MatterSubType;
            FileNumberUpDown.Value = file.FileNumber;
            //FileNumberTextBox.Text = file.FileNumber.ToString();
            StatutoryNoticeBox.Text = file.StatutoryNotice;
            AdditionalNotesTextBox.Text = file.AdditionalNotes;
        }

        public void OnNext()
        {
            UpserFile();
        }

        public void UpserFile()
        {
            if (Home.IntakeForm.Intake.File == null)
                Home.IntakeForm.Intake.File = new Abstractions.File();
            FillFile(Home.IntakeForm.Intake.File);
            if (Home.IntakeForm.Intake.File.ID == default)
                _fileManager.Insert(Home.IntakeForm.Intake.File);
            else
                _fileManager.Update(Home.IntakeForm.Intake.File);
            Home.IntakeForm.Intake.Hold = true;
        }

        private void MatterTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var matterType = (MatterType)MatterTypeComboBox.SelectedValue;
            if (matterType == null)
            {
                Utils.Utils.SetComboBoxDataSource(MatterSubTypeComboBox, null);
                return;
            }
            Utils.Utils.SetComboBoxDataSource(MatterSubTypeComboBox, _matterSubTypeRepository.List().Where(s => s.MatterType.ID == matterType.ID).ToList());
            if (matterType.Description == "Disability")
            {
                DateOfLossLabel.Text = "Date of Denial:";
                StatutoryNoticeBox.Hide();
                StatutoryNoticeLabel.Hide();
            }
            else
            {
                DateOfLossLabel.Text = "Date Of Loss:";
                StatutoryNoticeBox.Clear();
                StatutoryNoticeBox.Show();
                StatutoryNoticeLabel.Show();
                StatutoryNoticeBox.Enabled = true;
            }
        }

        private void FindIntakeButton_Click(object sender, EventArgs e)
        {
            FindIntake.Instance.SetOnlyHoldIntakes(true);
            FindIntake.Instance.Show();
            FindIntake.Instance.FormClosing += new FormClosingEventHandler(FindIntake_FormClosing);
        }

        private void FindIntake_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findIntakeForm = sender as FindIntake;
            Home.IntakeForm.SetIntake(findIntakeForm.SelectedIntake);
            if (findIntakeForm.SelectedIntake != null)
                PrelimInfoQuestionnaireButton.Visible = true;
            else
                PrelimInfoQuestionnaireButton.Visible = false;

        }

        private void PrelimInfoQuestionnaireButton_Click(object sender, EventArgs e)
        {
            var intake = Home.IntakeForm.Intake;
            if (intake.File == null)
            {
                MessageBox.Show("Please select an file first.");
                return;
            }
            var fields = _questionnaireManager.ImportQuestionnaire(intake);
            if(fields != null)
            {
                var form = Utils.Utils.OpenForm<ImportQuestionnaireFields>();
                form.FormClosing += ImportQuestionnaireFieldsForm_FormClosing;
                form.SetFields(fields);
            }
        }
        private void ImportQuestionnaireFieldsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home.IntakeForm.SetIntake(Home.IntakeForm.Intake);
        }
    }
}
