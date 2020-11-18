using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRFFilesManager.DataAccess;
using RRFFilesManager.Abstractions.DataAccess;
using RRFFilesManager.Abstractions;
using RRFFilesManager.Logic;

namespace RRFFilesManager.IntakeForm
{
    public partial class PreliminaryInfo : UserControl
    {
        private readonly IMatterTypeRepository _matterTypeRepository;
        private readonly IMatterSubTypeRepository _matterSubTypeRepository;
        private readonly IHearAboutUsRepository _hearAboutUsRepository;
        private readonly ILawyerRepository _lawyerRepository;
        public PreliminaryInfo()
        {
            _matterTypeRepository = (IMatterTypeRepository)Program.ServiceProvider.GetService(typeof(IMatterTypeRepository));
            _matterSubTypeRepository = (IMatterSubTypeRepository)Program.ServiceProvider.GetService(typeof(IMatterSubTypeRepository));
            _hearAboutUsRepository = (IHearAboutUsRepository)Program.ServiceProvider.GetService(typeof(IHearAboutUsRepository));
            _lawyerRepository = (ILawyerRepository)Program.ServiceProvider.GetService(typeof(ILawyerRepository));
            InitializeComponent();
            Initialize();
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

                if (string.IsNullOrEmpty(ResponsibleLawyerComboBox.Text))
                {
                    MessageBox.Show("Please select: Responsible Lawyer");
                    return false;
                }

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

            return true;
        }

        

        private void MatterSubTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var matterSubType = (MatterSubType)MatterSubTypeComboBox.SelectedItem;
            if (matterSubType?.StatutoryNotice != null)
            {
                StatutoryNoticeBox.Text = DateOfLossDateTimePicker.Value.AddDays(10).ToString("MMM-dd-yyyy");
            }
            else
            {
                StatutoryNoticeBox.Text = "";
            }
        }

        private void DateOfLossDateTimePicker_ValueChanged(object Sender, EventArgs e)
        {
            DateOfLossDateTimePicker.CustomFormat = "MMM-dd-yyyy";
            var matterSubType = (MatterSubType)MatterSubTypeComboBox.SelectedItem;
            if (matterSubType?.StatutoryNotice != null)
            {
                StatutoryNoticeBox.Text = DateOfLossDateTimePicker.Value.AddDays(10).ToString("MMM-dd-yyyy");
            }
            else
            {
                StatutoryNoticeBox.Text = "";
            }

            if (DateOfLossDateTimePicker.CustomFormat == "MMM-dd-yyyy")
            {
                LimitationPeriodTextBox.Text = DateOfLossDateTimePicker.Value.AddYears(2).ToString("MMM-dd-yyyy");
            }
        }

        private void LawyerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lawyer = (Lawyer)LawyerComboBox.SelectedItem;
            var fileNumber = IntakeManager.GetNewFileNumber(lawyer);
            FileNumberTextBox.Text = fileNumber.ToString();
        }

        private void PreliminaryInfo_Load(object sender, EventArgs e)
        {
            
        }

        

        private void Initialize()
        {
            Utils.SetComboBoxDataSource(MatterTypeComboBox, _matterTypeRepository.ListAsync()?.Result, nameof(MatterType.Description));
            Utils.SetComboBoxDataSource(HowHearComboBox, _hearAboutUsRepository.ListAsync()?.Result, nameof(HearAboutUs.Description));
            Utils.SetComboBoxDataSource(StaffInterviewerComboBox, _lawyerRepository.ListAsync()?.Result, nameof(Lawyer.Description));
            Utils.SetComboBoxDataSource(ResponsibleLawyerComboBox, _lawyerRepository.ListAsync()?.Result, nameof(Lawyer.Description));
            Utils.SetComboBoxDataSource(LawyerComboBox, _lawyerRepository.ListAsync()?.Result?.Where(s => s.NumberID != null).ToList(), nameof(Lawyer.Description));
            DateOfLossDateTimePicker.Format = DateTimePickerFormat.Custom;
            DateOfLossDateTimePicker.CustomFormat = " ";
        }

        public void FillIntakeFromForm(Intake intake)
        {
            intake.MatterType = (MatterType)MatterTypeComboBox.SelectedItem;
            intake.DateOfCall = DateOFCallDateTimePicker.Value;
            intake.StaffInterviewer = (Lawyer)StaffInterviewerComboBox.SelectedItem;
            intake.HowHear = (HearAboutUs)HowHearComboBox.SelectedItem;
            intake.FileLawyer = (Lawyer)LawyerComboBox.SelectedItem;
            intake.ResponsibleLawyer = (Lawyer)ResponsibleLawyerComboBox.SelectedItem;
            intake.DateOFLoss = DateOfLossDateTimePicker.Value;
            intake.LimitationPeriod = LimitationPeriodTextBox.Text;
            intake.MatterSubType = (MatterSubType)MatterSubTypeComboBox.SelectedItem;
            intake.FileNumber = int.Parse(FileNumberTextBox.Text);
            intake.StatutoryNotice = StatutoryNoticeBox.Text;
            intake.AdditionalNotes = AdditionalNotesTextBox.Text;
        }

        public void FillForm(Intake intake)
        {
            MatterTypeComboBox.SelectedItem = intake.MatterType;
            DateOFCallDateTimePicker.Value= intake.DateOfCall;
            StaffInterviewerComboBox.SelectedItem = intake.StaffInterviewer;
            HowHearComboBox.SelectedItem = intake.HowHear;
            LawyerComboBox.SelectedItem = intake.FileLawyer;
            ResponsibleLawyerComboBox.SelectedItem = intake.ResponsibleLawyer;
            DateOfLossDateTimePicker.Value = intake.DateOFLoss;
            LimitationPeriodTextBox.Text = intake.LimitationPeriod;
            MatterSubTypeComboBox.SelectedItem = intake.MatterSubType;
            FileNumberTextBox.Text = intake.FileNumber.ToString();
            StatutoryNoticeBox.Text = intake.StatutoryNotice;
            AdditionalNotesTextBox.Text = intake.AdditionalNotes;
        }

        public void OnNext()
        {
            FillIntakeFromForm(Home.IntakeForm.Intake);
        }

        private void MatterTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var matterType = (MatterType)MatterTypeComboBox.SelectedValue;
            if (matterType == null)
            {
                Utils.SetComboBoxDataSource(MatterSubTypeComboBox, null);
                return;
            }
            Utils.SetComboBoxDataSource(MatterSubTypeComboBox, _matterSubTypeRepository.ListAsync()?.Result.Where(s => s.MatterType.ID == matterType.ID).ToList());
        }

        private void FindIntakeButton_Click(object sender, EventArgs e)
        {
            FindIntake.Instance.Show();
        }
    }
}
