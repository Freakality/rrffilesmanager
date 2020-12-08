﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRFFilesManager.DataAccess;
using RRFFilesManager.DataAccess.Abstractions;
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
        private readonly IFileRepository _fileRepository;
        public PreliminaryInfo()
        {
            _matterTypeRepository = Program.GetService<IMatterTypeRepository>();
            _matterSubTypeRepository = Program.GetService<IMatterSubTypeRepository>();
            _hearAboutUsRepository = Program.GetService<IHearAboutUsRepository>();
            _lawyerRepository = Program.GetService<ILawyerRepository>();
            _fileRepository = Program.GetService<IFileRepository>();
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

        public void FillFile(File file)
        {
            file.MatterType = (MatterType)MatterTypeComboBox.SelectedItem;
            file.DateOfCall = DateOFCallDateTimePicker.Value;
            file.StaffInterviewer = (Lawyer)StaffInterviewerComboBox.SelectedItem;
            file.HowHear = (HearAboutUs)HowHearComboBox.SelectedItem;
            file.FileLawyer = (Lawyer)LawyerComboBox.SelectedItem;
            file.ResponsibleLawyer = (Lawyer)ResponsibleLawyerComboBox.SelectedItem;
            file.DateOFLoss = DateOfLossDateTimePicker.Value;
            file.LimitationPeriod = LimitationPeriodTextBox.Text;
            file.MatterSubType = (MatterSubType)MatterSubTypeComboBox.SelectedItem;
            file.FileNumber = int.Parse(FileNumberTextBox.Text);
            file.StatutoryNotice = StatutoryNoticeBox.Text;
            file.AdditionalNotes = AdditionalNotesTextBox.Text;
        }

        public void FillForm(File file)
        {
            MatterTypeComboBox.SelectedItem = file.MatterType;
            DateOFCallDateTimePicker.Value= file.DateOfCall;
            StaffInterviewerComboBox.SelectedItem = file.StaffInterviewer;
            HowHearComboBox.SelectedItem = file.HowHear;
            LawyerComboBox.SelectedItem = file.FileLawyer;
            ResponsibleLawyerComboBox.SelectedItem = file.ResponsibleLawyer;
            DateOfLossDateTimePicker.Value = file.DateOFLoss;
            LimitationPeriodTextBox.Text = file.LimitationPeriod;
            MatterSubTypeComboBox.SelectedItem = file.MatterSubType;
            FileNumberTextBox.Text = file.FileNumber.ToString();
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
                Home.IntakeForm.Intake.File = new File();
            FillFile(Home.IntakeForm.Intake.File);
            if (Home.IntakeForm.Intake.File.ID == default)
                _fileRepository.InsertAsync(Home.IntakeForm.Intake.File);
            else
                _fileRepository.UpdateAsync(Home.IntakeForm.Intake.File);
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
            FindIntake.Instance.SetOnlyHoldIntakes(true);
            FindIntake.Instance.Show();
            FindIntake.Instance.FormClosing += new FormClosingEventHandler(FindIntake_FormClosing);
        }

        private void FindIntake_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findIntakeForm = sender as FindIntake;
            Home.IntakeForm.SetIntake(findIntakeForm.SelectedIntake);
        }
    }
}
