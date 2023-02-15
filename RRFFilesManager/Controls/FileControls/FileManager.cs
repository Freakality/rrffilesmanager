﻿using ClosedXML.Excel;
using RRFFilesManager.Abstractions;
using RRFFilesManager.Controls.Components;
using RRFFilesManager.Controls.FileControls;
using RRFFilesManager.Controls.FileControls.UserControls;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.FileControls;
using RRFFilesManager.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager
{
    public partial class FileManager : Form
    {
        public File File { get; set; }
        public Timeline FileTimeline { get; set; }
        public bool SettingFile = false;
        public readonly PeopleControl PeopleControl;
        public readonly MedicalBinderIndexControl MedicalBinderIndexControl;
        public readonly PrescriptionSummariesControl PrescriptionSummariesControl;
        public readonly ABBinderControl ABBinderControl;
        public readonly StandardBenefitStatementsControl StandardBenefitStatementsControl;
        public readonly StandardBenefitStatementsControl QuickABPaidToDateControl;
        private readonly IFileRepository _fileRepository;
        private readonly ITimelineRepository _timelineRepository;
        private readonly ITaskCategoryRepository _taskCategoryRepository;
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskStateRepository _taskStateRepository;
        private readonly IFileTaskRepository _fileTaskRepository;
        private readonly IClientNoteRepository _clientNoteRepository;
        public SemiAnnualFileReviewControl SemiAnnualFileReviewControlAction;
        public SemiAnnualFileReviewControl SemiAnnualFileReviewControlAccidentBenefits;
        public TabPage SemiAnnualFileReviewTabAction = new TabPage("Semi-Annual File Review");
        public TabPage SemiAnnualFileReviewTabAccidentBenefits = new TabPage("Semi-Annual File Review");
        public IEnumerable<ClientNote> clientNotes;
        private DataTable Notes = new DataTable();
        private DataView FilteredNotes = new DataView();
        public FileManager()
        {
            _fileRepository = Program.GetService<IFileRepository>();
            _timelineRepository = Program.GetService<ITimelineRepository>();
            _taskCategoryRepository = Program.GetService<ITaskCategoryRepository>();
            _taskRepository = Program.GetService<ITaskRepository>();
            _taskStateRepository = Program.GetService<ITaskStateRepository>();
            _fileTaskRepository = Program.GetService<IFileTaskRepository>();
            _clientNoteRepository = Program.GetService<IClientNoteRepository>();
            InitializeComponent();
            ComboBox2.SelectedIndex = 0;
            PeopleControl = new PeopleControl();
            Utils.Utils.SetContent(PeopleTab, PeopleControl);

            MedicalBinderIndexControl = new MedicalBinderIndexControl();
            Utils.Utils.SetContent(MedicalBinderIndexTab, MedicalBinderIndexControl);

            PrescriptionSummariesControl = new PrescriptionSummariesControl();
            Utils.Utils.SetContent(PrescriptionSummariesTab, PrescriptionSummariesControl);

            ABBinderControl = new ABBinderControl();
            Utils.Utils.SetContent(ABBinderTab, ABBinderControl);

            StandardBenefitStatementsControl = new StandardBenefitStatementsControl();
            Utils.Utils.SetContent(BenefitStatements, StandardBenefitStatementsControl);

            QuickABPaidToDateControl = new StandardBenefitStatementsControl(true);
            Utils.Utils.SetContent(QuickABPaidToDate, QuickABPaidToDateControl);

            SemiAnnualFileReviewControlAction = new SemiAnnualFileReviewControl(0);
            Utils.Utils.SetContent(SemiAnnualFileReviewTabAction, SemiAnnualFileReviewControlAction);
            SemiAnnualFileReviewControlAction.ReviewDoneSaveButton.Click += ReviewDoneSaveButton_Click2;

            SemiAnnualFileReviewControlAccidentBenefits = new SemiAnnualFileReviewControl(1);
            Utils.Utils.SetContent(SemiAnnualFileReviewTabAccidentBenefits, SemiAnnualFileReviewControlAccidentBenefits);
            SemiAnnualFileReviewControlAccidentBenefits.ReviewDoneSaveButton.Click += ReviewDoneSaveButton_Click2;

            Notes.Columns.Add("Date",typeof(DateTime));
            Notes.Columns.Add("Lawyer",typeof(string));
            Notes.Columns.Add("Description",typeof(string));
            Notes.TableName = "ClientNotesDataTable";
            FilteredNotes.Table = Notes;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Close();
            Home.Instance.Show();
        }

        private void FindFileButton_Click(object sender, EventArgs e)
        {
            SettingFile = true;
            FindFile.Instance.Show();
            FindFile.Instance.FormClosing += new FormClosingEventHandler(FindFile_FormClosing);
        }

        private void FindFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findFileForm = sender as FindFile;
            File = findFileForm.SelectedFile;
            if (File == null)
                return;
            SetForm(File);
        }

        private void SetForm(File file)
        {
            if(file == null)
                return;
            PeopleControl.SetFile(file);
            ABBinderControl.SetFile(file);
            StandardBenefitStatementsControl.SetFile(file);
            MedicalBinderIndexControl.SetFile(file);
            PrescriptionSummariesControl.SetFile(file);
            QuickABPaidToDateControl.SetFile(file);

            ClientNameTextBox.Text = file.Client.ToString();
            MatterTypeTextBox.Text = file.MatterType.ToString();
            MatterSubTypeTextBox.Text = file.MatterSubType.ToString();
            FileNumberTextBox.Text = file.FileNumber.ToString();
            DateOfLossTextBox.Text = file.DateOFLoss.ToString("MMM-dd-yyyy");
            LimDateTextBox.Text = file.LimitationPeriod;
            FileOpenDateTextBox.Text = file.DateOfCall.ToString("MMM-dd-yyyy");
            /*DateTime nextReview = file.DateOfCall.AddMonths(6);
            while (nextReview.Date < DateTime.Now.Date)
            {
                nextReview = nextReview.AddMonths(6);
            }
            NextTextBox.Text = nextReview.ToString("MMM-dd-yyyy");
            NextReviewDateTextBox.Text = nextReview.ToString("MMM-dd-yyyy");*/

            if(file.MatterType.Description == "Disability")
            {
                DateOfLossLabel.Text = "Date Of Denial";
                NextLabel.Text = "Next Disability Review Date";
                ProjectedSettlementDateLabel.Text = "Projected Disability Settlement Date";
                ProjectedSettlementValueLabel.Text = "Projected Disability Settlement Value";
                NextReviewDateLabel.Hide();
                NextReviewDateTextBox.Hide();
                ProjectedABSettlementDateLabel.Hide();
                ProjectedABSettlementDateTextBox.Hide();
                ProjectedABSettlementValueLabel.Hide();
                ProjectedABSettlementValueTextBox.Hide();
            }
            else
            {
                DateOfLossLabel.Text = "Date Of Loss";
                NextLabel.Text = "Next Tort/Contract Review Date";
                ProjectedSettlementDateLabel.Text = "Projected Tort/Contract Settlement Date";
                ProjectedSettlementValueLabel.Text = "Projected Tort/Contract Settlement Value";
                NextReviewDateLabel.Show();
                NextReviewDateTextBox.Show();
                ProjectedABSettlementDateLabel.Show();
                ProjectedABSettlementDateTextBox.Show();
                ProjectedABSettlementValueLabel.Show();
                ProjectedABSettlementValueTextBox.Show();
            }
            SubTypeCategoryComboBox.Enabled = true;
            SubTypeCategoryComboBox.MatterType = File.MatterType;
            SubTypeCategoryComboBox.SelectedIndex = -1;
            SettingFile = false;
            if (File.SubTypeCategory != null)
            {
                SubTypeCategoryComboBox.SelectedItem = File.SubTypeCategory;
                SetSemiAnnualFileReviewTab(File);
                SetProjections();
            }
            TBoxLiabilityMeetingDate.Enabled = true;
            TBoxProposedDateIssueSOC.Enabled = true;
            TBoxPrePleadingsMeetingDate.Enabled = true;
            TBoxActualDateSOCIssued.Enabled = true;
            TBoxMedicalSummariesPreDiscDueDate.Enabled = true;
            TBoxProposedDateToServeSOC.Enabled = true;
            TBoxActualDateSOCServed.Enabled = true;
            TBoxDateToFileTrialRecordBy.Enabled = true;
            TBoxPreDiscoveryMeetingDate.Enabled = true;
            TBoxDefendantAODRequest.Enabled = true;
            TBoxDateOfPlaintiffDiscovery.Enabled = true; ;
            TBoxPlaintiffAODSent.Enabled = true;
            TBoxDateOfDefendantDiscovery.Enabled = true;
            TBoxDateTrialRecordFiled.Enabled = true;
            TBoxDatePlaintiffUndertakingComplete.Enabled = true;
            TBoxAllDefendantUndertakingRecd.Enabled = true;
            TimelineSaveBtn.Enabled = true;
            if (File.Timeline != null)
            {
                FileTimeline = File.Timeline;
                if (FileTimeline.LiabilityMeetingDate != default(DateTime))
                    TBoxLiabilityMeetingDate.Value = FileTimeline.LiabilityMeetingDate;
                if (FileTimeline.ProposedDateIssueSOC != default(DateTime))
                    TBoxProposedDateIssueSOC.Value = FileTimeline.ProposedDateIssueSOC;
                if (FileTimeline.PrePleadingsMeetingDate != default(DateTime))
                    TBoxPrePleadingsMeetingDate.Value = FileTimeline.PrePleadingsMeetingDate;
                if (FileTimeline.ActualDateSOCIssued != default(DateTime))
                    TBoxActualDateSOCIssued.Value = FileTimeline.ActualDateSOCIssued;
                if (FileTimeline.MedicalSummariesPreDiscDueDate != default(DateTime))
                    TBoxMedicalSummariesPreDiscDueDate.Value = FileTimeline.MedicalSummariesPreDiscDueDate;
                if (FileTimeline.ProposedDateToServeSOC != default(DateTime))
                    TBoxProposedDateToServeSOC.Value = FileTimeline.ProposedDateToServeSOC;
                if (FileTimeline.ActualDateSOCServed != default(DateTime))
                    TBoxActualDateSOCServed.Value = FileTimeline.ActualDateSOCServed;
                if (FileTimeline.DateToFileTrialRecordBy != default(DateTime))
                    TBoxDateToFileTrialRecordBy.Value = FileTimeline.DateToFileTrialRecordBy;
                if (FileTimeline.PreDiscoveryMeetingDate != default(DateTime))
                    TBoxPreDiscoveryMeetingDate.Value = FileTimeline.PreDiscoveryMeetingDate;
                if (FileTimeline.DefendantAODRequest != default(DateTime))
                    TBoxDefendantAODRequest.Value = FileTimeline.DefendantAODRequest;
                if (FileTimeline.DateOfPlaintiffDiscovery != default(DateTime))
                    TBoxDateOfPlaintiffDiscovery.Value = FileTimeline.DateOfPlaintiffDiscovery;
                if (FileTimeline.PlaintiffAODSent != default(DateTime))
                    TBoxPlaintiffAODSent.Value = FileTimeline.PlaintiffAODSent;
                if (FileTimeline.DateOfDefendantDiscovery != default(DateTime))
                    TBoxDateOfDefendantDiscovery.Value = FileTimeline.DateOfDefendantDiscovery;
                if (FileTimeline.DateTrialRecordFiled != default(DateTime))
                    TBoxDateTrialRecordFiled.Value = FileTimeline.DateTrialRecordFiled;
                if (FileTimeline.DatePlaintiffUndertakingComplete != default(DateTime))
                    TBoxDatePlaintiffUndertakingComplete.Value = FileTimeline.DatePlaintiffUndertakingComplete;
                if (FileTimeline.AllDefendantUndertakingRecd != default(DateTime))
                    TBoxAllDefendantUndertakingRecd.Value = FileTimeline.AllDefendantUndertakingRecd;
            }
            if (File.Tasks.ToList().Count > 0)
            {
                RefreshActionLogDataGridViewDataSource();
            }

            Btn_SearchNotes.Enabled = true;
            AddNotesRowButton.Enabled = true;
            SaveNoteButton.Enabled = true;
        }

        private void RefreshActionLogDataGridViewDataSource()
        {
            /*int taskCategoryID = -1;
            if (!(CBoxTaskCategory.SelectedValue is null))
            {
                if (!Int32.TryParse(CBoxTaskCategory.SelectedValue.ToString(), out taskCategoryID))
                {
                    taskCategoryID = -1;
                }
            }*/
            bool setup = true;
            if (ActionLogDataGridView.DataSource != null)
                setup = false;
            ActionLogDataGridView.DataSource = _fileTaskRepository.Search(File, _taskStateRepository.GetByDescription(ComboBox2.Text));
            if (setup)
            {
                ActionLogDataGridView.Columns["ID"].Visible = false;
                ActionLogDataGridView.Columns["File"].Visible = false;
                ActionLogDataGridView.Columns["FileId"].Visible = false;
                ActionLogDataGridView.Columns["TaskId"].Visible = false;
                ActionLogDataGridView.Columns["DueDate"].HeaderText = "Due Date";
                ActionLogDataGridView.Columns["DeferUntilDate"].HeaderText = "Defer Until Date";
                ActionLogDataGridView.Columns["TaskStartedDate"].HeaderText = "Started Date";
                ActionLogDataGridView.Columns["WorkedOnDate1"].HeaderText = "Worked On Date 1";
                ActionLogDataGridView.Columns["WorkedOnDate2"].HeaderText = "Worked On Date 2";
                ActionLogDataGridView.Columns["WorkedOnDate3"].HeaderText = "Worked On Date 3";
                ActionLogDataGridView.Columns["NotifiedRRFDate"].HeaderText = "Notified RRF Date";
                ActionLogDataGridView.Columns["CompletedDate"].HeaderText = "Completed Date";

            }
        }

        private void TextBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void FileManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home.Instance.Show();
        }

        private void PrescriptionSummariesTab_Click(object sender, EventArgs e)
        {

        }

        public List<string> GetDateMatterSub()
        {
            List<string> DateMatterSub = new List<string>();
            DateMatterSub.Add(FileOpenDateTextBox.Text);
            DateMatterSub.Add(MatterTypeTextBox.Text);
            DateMatterSub.Add(MatterSubTypeTextBox.Text);
            return DateMatterSub;
        }

        private void SetSemiAnnualFileReviewTab(File file)
        {
            /*
            */
            if (TabControl2.TabPages.Contains(SemiAnnualFileReviewTabAction))
            {
                TabControl2.TabPages.Remove(SemiAnnualFileReviewTabAction);
            }
            if (TabControl5.TabPages.Contains(SemiAnnualFileReviewTabAccidentBenefits))
            {
                TabControl5.TabPages.Remove(SemiAnnualFileReviewTabAccidentBenefits);
            }

            if (file.MatterType.Description == "Motor Vehicle Accident" && file.SubTypeCategory.Description.ToUpper().Contains("AB") && !file.SubTypeCategory.Description.ToUpper().Contains("TORT"))
            {
                SemiAnnualFileReviewControlAccidentBenefits.File = file;
                TabControl5.TabPages.Add(SemiAnnualFileReviewTabAccidentBenefits);
            }
            else if (file.MatterType.Description == "Motor Vehicle Accident" && !file.SubTypeCategory.Description.ToUpper().Contains("AB") && file.SubTypeCategory.Description.ToUpper().Contains("TORT"))
            {
                SemiAnnualFileReviewControlAction.File = file;
                TabControl2.TabPages.Insert(6, SemiAnnualFileReviewTabAction);
            }
            else
            {
                SemiAnnualFileReviewControlAccidentBenefits.File = SemiAnnualFileReviewControlAction.File = file;
                TabControl5.TabPages.Add(SemiAnnualFileReviewTabAccidentBenefits);
                TabControl2.TabPages.Insert(6, SemiAnnualFileReviewTabAction);
            }
            
        }

        private void SubTypeCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!SettingFile && (File.SubTypeCategory != (ComissionSubType)SubTypeCategoryComboBox.SelectedItem))
            {
                File.SubTypeCategory = (ComissionSubType)SubTypeCategoryComboBox.SelectedItem;
                _fileRepository.Update(File);
                SetSemiAnnualFileReviewTab(File);
            }
        }

        private void SetProjections()
        {
            DateTime TDate = File.DateOfCall;
            DateTime TProjectedSettlementDate = Convert.ToDateTime("01/01/0001");
            string TProjectedSettlementValue = "";
            DateTime ABDate = File.DateOfCall;
            DateTime ABProjectedSettlementDate = Convert.ToDateTime("01/01/0001");
            string ABProjectedSettlementValue = "";
            bool HasT = false;
            bool HasAB = false;
            foreach (FileReview NextReview in File.Reviews)
            {
                if (NextReview.FRActionABenefitsStatus == 0)
                {
                    if (HasT == false)
                        HasT = true;
                    if (NextReview.FRDate >= TDate)
                    {
                        TDate = NextReview.FRDate;
                        TProjectedSettlementDate = NextReview.FRProjectedSettlementDate;
                        TProjectedSettlementValue = NextReview.FRProjectedSettlementValue;
                    }
                }
                else if (NextReview.FRActionABenefitsStatus == 1)
                {
                    if (HasAB == false)
                        HasAB = true;
                    if (NextReview.FRDate >= ABDate)
                    {
                        ABDate = NextReview.FRDate;
                        ABProjectedSettlementDate = NextReview.FRProjectedSettlementDate;
                        ABProjectedSettlementValue = NextReview.FRProjectedSettlementValue;
                    }
                }
            }
            SetProjectionPerType(HasT, NextTextBox, TDate, ProjectedSettlementDateTextBox, TProjectedSettlementDate, ProjectedSettlementValueTextBox, TProjectedSettlementValue);
            SetProjectionPerType(HasAB, NextReviewDateTextBox, ABDate, ProjectedABSettlementDateTextBox, ABProjectedSettlementDate, ProjectedABSettlementValueTextBox, ABProjectedSettlementValue);
        }

        private void SetProjectionPerType (bool Has, TextBox NextDateBox, DateTime NextDate, TextBox SettleDateBox, DateTime SettleDate, TextBox SettleValueBox, string SettleValue)
        {
            if (Has)
            {
                DateTime OriginalDate = Convert.ToDateTime("01/01/0001");
                bool success = false;
                if (!String.IsNullOrEmpty(NextDateBox.Text))
                {
                    success = DateTime.TryParse(NextDateBox.Text, out OriginalDate);
                }
                if (!success)
                {
                    OriginalDate = Convert.ToDateTime("01/01/0001");
                }
                if (NextDate.AddMonths(6) > OriginalDate)
                {
                    NextDateBox.Text = NextDate.AddMonths(6).ToString("MMM-dd-yyyy");
                    SettleDateBox.Text = SettleDate.ToString("MMM-dd-yyyy");
                    SettleValueBox.Text = SettleValue;
                }
            }
        }

        private void ReviewDoneSaveButton_Click2(object sender, EventArgs e)
        {
            SetProjections();   
        }

        private void DTP_ValueChanged(object sender, EventArgs e)
        {
            var dtp = sender as ColorDateTimePicker;
            if (dtp.Value != default(DateTime))
                (this.Timeline.Controls[dtp.Name + "TextBox"] as TextBox).Text = dtp.Value.ToString("MMMM dd, yyyy");
            else
                (this.Timeline.Controls[dtp.Name + "TextBox"] as TextBox).Text = "";
        }

        private void TimelineSaveBtn_Click(object sender, EventArgs e)
        {
            var timeline = FileTimeline;
            if (timeline == null)
                timeline = new Timeline();
            FillTimeline(timeline);
            TaskTimelineCheck(timeline);
            if (timeline.ID == default)
                _timelineRepository.Insert(timeline, timeline.File);
            else
                _timelineRepository.Update(timeline);
            MessageBox.Show("Timeline has been saved.");
        }

        private void FillTimeline(Timeline timeline)
        {
            timeline.File = File;
            if (!String.IsNullOrEmpty(TBoxLiabilityMeetingDateTextBox.Text))
                timeline.LiabilityMeetingDate = TBoxLiabilityMeetingDate.Value;

            if (!String.IsNullOrEmpty(TBoxProposedDateIssueSOCTextBox.Text))
                timeline.ProposedDateIssueSOC = TBoxProposedDateIssueSOC.Value;

            if (!String.IsNullOrEmpty(TBoxPrePleadingsMeetingDateTextBox.Text))
                timeline.PrePleadingsMeetingDate = TBoxPrePleadingsMeetingDate.Value;

            if (!String.IsNullOrEmpty(TBoxActualDateSOCIssuedTextBox.Text))
                timeline.ActualDateSOCIssued = TBoxActualDateSOCIssued.Value;

            if (!String.IsNullOrEmpty(TBoxMedicalSummariesPreDiscDueDateTextBox.Text))
                timeline.MedicalSummariesPreDiscDueDate = TBoxMedicalSummariesPreDiscDueDate.Value;

            if (!String.IsNullOrEmpty(TBoxProposedDateToServeSOCTextBox.Text))
                timeline.ProposedDateToServeSOC = TBoxProposedDateToServeSOC.Value;

            if (!String.IsNullOrEmpty(TBoxActualDateSOCServedTextBox.Text))
                timeline.ActualDateSOCServed = TBoxActualDateSOCServed.Value;

            if (!String.IsNullOrEmpty(TBoxDateToFileTrialRecordByTextBox.Text))
                timeline.DateToFileTrialRecordBy = TBoxDateToFileTrialRecordBy.Value;

            if (!String.IsNullOrEmpty(TBoxPreDiscoveryMeetingDateTextBox.Text))
                timeline.PreDiscoveryMeetingDate = TBoxPreDiscoveryMeetingDate.Value;

            if (!String.IsNullOrEmpty(TBoxDefendantAODRequestTextBox.Text))
                timeline.DefendantAODRequest = TBoxDefendantAODRequest.Value;

            if (!String.IsNullOrEmpty(TBoxDateOfPlaintiffDiscoveryTextBox.Text))
                timeline.DateOfPlaintiffDiscovery = TBoxDateOfPlaintiffDiscovery.Value;

            if (!String.IsNullOrEmpty(TBoxPlaintiffAODSentTextBox.Text))
                timeline.PlaintiffAODSent = TBoxPlaintiffAODSent.Value;

            if (!String.IsNullOrEmpty(TBoxDateOfDefendantDiscoveryTextBox.Text))
                timeline.DateOfDefendantDiscovery = TBoxDateOfDefendantDiscovery.Value;

            if (!String.IsNullOrEmpty(TBoxDateTrialRecordFiledTextBox.Text))
                timeline.DateTrialRecordFiled = TBoxDateTrialRecordFiled.Value;

            if (!String.IsNullOrEmpty(TBoxDatePlaintiffUndertakingCompleteTextBox.Text))
                timeline.DatePlaintiffUndertakingComplete = TBoxDatePlaintiffUndertakingComplete.Value;

            if (!String.IsNullOrEmpty(TBoxAllDefendantUndertakingRecdTextBox.Text))
                timeline.AllDefendantUndertakingRecd = TBoxAllDefendantUndertakingRecd.Value;
        }

        private void TaskTimelineCheck(Timeline timeline)
        {
            TaskState taskState = _taskStateRepository.GetByDescription("To Do");
            if (!String.IsNullOrEmpty(TBoxLiabilityMeetingDateTextBox.Text) && (timeline.LiabilityMeetingDate != TBoxLiabilityMeetingDate.MinDate && timeline.LiabilityMeetingDate != default(DateTime) && timeline.LiabilityMeetingDate != null))
            {
                AddFileTasks("Liability", taskState);
            }
            if (!String.IsNullOrEmpty(TBoxPrePleadingsMeetingDateTextBox.Text) && (timeline.PrePleadingsMeetingDate != TBoxPrePleadingsMeetingDate.MinDate && timeline.PrePleadingsMeetingDate != default(DateTime) && timeline.PrePleadingsMeetingDate != null))
            {
                AddFileTasks("Pre-Pleadings", taskState);
            }
            if (!String.IsNullOrEmpty(TBoxActualDateSOCIssuedTextBox.Text) && (timeline.ActualDateSOCIssued != TBoxActualDateSOCIssued.MinDate && timeline.ActualDateSOCIssued != default(DateTime) && timeline.ActualDateSOCIssued != null))
            {
                AddFileTasks("Pleadings", taskState);
            }
            if (!String.IsNullOrEmpty(TBoxPreDiscoveryMeetingDateTextBox.Text) && (timeline.PreDiscoveryMeetingDate != TBoxPreDiscoveryMeetingDate.MinDate && timeline.PreDiscoveryMeetingDate != default(DateTime) && timeline.PreDiscoveryMeetingDate != null))
            {
                AddFileTasks("Pre-Discovery", taskState);
            }
            if (!String.IsNullOrEmpty(TBoxDateOfPlaintiffDiscoveryTextBox.Text) && (timeline.DateOfPlaintiffDiscovery != TBoxDateOfPlaintiffDiscovery.MinDate && timeline.DateOfPlaintiffDiscovery != default(DateTime) && timeline.DateOfPlaintiffDiscovery != null))
            {
                AddFileTasks("Discovery", taskState);
            }
        }
        private void AddFileTasks(string category, TaskState taskState)
        {
            var cat = _taskCategoryRepository.Search(category).FirstOrDefault();
            if (cat != null)
            {
                var taskCategoryID = cat.ID;
                var tasks = _taskRepository.Search("", taskCategoryID);
                if (tasks.Count() > 0)
                {
                    _fileRepository.AddAllCategoryTasks(File, tasks, taskState);
                }
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File != null)
                RefreshActionLogDataGridViewDataSource();
        }

        private void ABBinderTab_Click(object sender, EventArgs e)
        {

        }
               

        private void AddNotesRowButton_Click(object sender, EventArgs e)
        {
            if (File == null) return;
           

            if (ClientNotesDataGridView.Rows.Count > 0)
            {
                if (ClientNotesDataGridView.Rows[ClientNotesDataGridView.Rows.Count - 1].Cells[0].Value == null || 
                    ClientNotesDataGridView.Rows[ClientNotesDataGridView.Rows.Count - 1].Cells[0].Value.ToString() == "")
                {
                    MessageBox.Show("You must save the last added note to create a new record.","Wait",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    return;
                }
            }

            ClientNotesDataGridView.Rows.Add(null,null,null);
            ClientNotesDataGridView.CurrentCell = ClientNotesDataGridView.Rows[ClientNotesDataGridView.Rows.Count - 1].Cells[DgColumn_Description.Index];
            ClientNotesDataGridView.Rows[ClientNotesDataGridView.CurrentCell.RowIndex].Cells[ClientNotesDataGridView.CurrentCell.ColumnIndex].ReadOnly = false;
            //ClientNotesDataGridView.CurrentCell.ReadOnly = false;
            ClientNotesDataGridView.BeginEdit(false);
        }

        private void SaveNoteButton_Click(object sender, EventArgs e)
        {
            if (ClientNotesDataGridView.Rows[ClientNotesDataGridView.Rows.Count - 1].Cells[DgColumn_DateTime.Index].Value == null && 
                ClientNotesDataGridView.Rows[ClientNotesDataGridView.Rows.Count - 1].Cells[DgColumn_Description.Index].Value != null &&
                !string.IsNullOrEmpty(ClientNotesDataGridView.Rows[ClientNotesDataGridView.Rows.Count - 1].Cells[DgColumn_Description.Index].Value.ToString()))
            {
                if (MessageBox.Show("Are you sure you want to save a note?", "Wait", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question) != DialogResult.Yes) return;

                string description = ClientNotesDataGridView.Rows[ClientNotesDataGridView.Rows.Count - 1].Cells[DgColumn_Description.Index].Value.ToString();

                ClientNote clientNote = new ClientNote();
                clientNote.File = File;
                clientNote.Date = DateTime.Now;
                clientNote.Lawyer = Program.GetUser();
                clientNote.Description = description;

                _clientNoteRepository.Insert(clientNote,File);
                MessageBox.Show("note successfully saved!","Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (Cbb_Staff.Items.Count > 0)
                {
                    Cbb_Staff.SelectedIndex = 0;
                }
                Btn_SearchNotes.PerformClick();
            }
            else
            {
                MessageBox.Show("¡There is no information to save!", "No info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_SearchNotes_Click(object sender, EventArgs e)
        {
            clientNotes =  _clientNoteRepository.Search(File,Dtp_From.Value,Dtp_To.Value);
            UpdateClienteNotesGrid();
            
        }

        private void UpdateClienteNotesGrid()
        {
            
            ClientNotesDataGridView.Rows.Clear();
            Notes.Rows.Clear();
            FilteredNotes.RowFilter = null;
            Intake intake = File.Intake;
            
            //Validando notas del intake
            if (!string.IsNullOrEmpty(intake.DamNotes))
            {
                Notes.Rows.Add(
                   File.DateOfCall,
                   intake.File.FileLawyer.Description,
                   intake.DamNotes
                   );
            }

            if (!string.IsNullOrEmpty(intake.EILNotes))
            {
                Notes.Rows.Add(
                   File.DateOfCall,
                   intake.File.FileLawyer.Description,
                   intake.EILNotes
                   );
            }

            if (!string.IsNullOrEmpty(intake.LiaNotes))
            {
                Notes.Rows.Add(
                   File.DateOfCall,
                   intake.File.FileLawyer.Description,
                   intake.LiaNotes
                   );
            }

            if (!string.IsNullOrEmpty(intake.AccBenNotes))
            {
                Notes.Rows.Add(
                   File.DateOfCall,
                   intake.File.FileLawyer.Description,
                   intake.AccBenNotes
                   );
            }

            if (!string.IsNullOrEmpty(intake.PolOtherNotes))
            {
                Notes.Rows.Add(
                   File.DateOfCall,
                   intake.File.FileLawyer.Description,
                   intake.PolOtherNotes
                   );
            }

            if (!string.IsNullOrEmpty(intake.Notes))
            {
                Notes.Rows.Add(
                   File.DateOfCall,
                   intake.File.FileLawyer.Description,
                   intake.Notes
                   );
            }

            foreach (var item in clientNotes)
            {
                Notes.Rows.Add(
                    item.Date,
                    item.Lawyer,
                    item.Description
                    ) ;
            }

            foreach (DataRow item in Notes.Rows)
            {
                ClientNotesDataGridView.Rows.Add(
                    Convert.ToDateTime(item["Date"]),
                    item["Lawyer"].ToString(),
                    item["Description"].ToString()
                    );
            }

            Cbb_Staff.Items.Clear();
            Cbb_Staff.Items.Add("");
            var lawyers = Notes.AsEnumerable().Select(x => x.Field<string>("Lawyer")).Distinct();
            foreach (var item in lawyers)
            {
                Cbb_Staff.Items.Add(item);
            }
            ExportToExcelButton.Enabled = true;
        }

        private void Cbb_Staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbb_Staff.Text.Trim() == "")
            {
                UpdateClienteNotesGrid();
            }
            else
            {
                FilteredNotes.RowFilter = $"Lawyer = '{Cbb_Staff.Text.Trim()}'";
                ClientNotesDataGridView.Rows.Clear();               
                foreach (DataRowView item in FilteredNotes)
                {
                    ClientNotesDataGridView.Rows.Add(
                    Convert.ToDateTime(item["Date"]),
                    item["Lawyer"].ToString(),
                    item["Description"].ToString()
                    );
                }
            }
        }

        private void ExportToExcelButton_Click(object sender, EventArgs e)
        {
            if (ClientNotesDataGridView.Rows.Count == 0)
            {
                MessageBox.Show("¡There is no information to export!","No info",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            var wb = new ClosedXML.Excel.XLWorkbook();
            if (Notes.Rows.Count == ClientNotesDataGridView.Rows.Count)
            {
                wb.Worksheets.Add(Notes, "ClientNotes");
            }
            else
            {
                wb.Worksheets.Add(FilteredNotes.ToTable(), "ClientNotes");
            }            
            
            foreach (IXLWorksheet sheet in wb.Worksheets)
            {
                sheet.Columns().AdjustToContents();
            }
            
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "";
                saveFileDialog.Filter = "Excel Files | *.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("¡successful export!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Utils.Utils.OpenMicrosoftExcel(saveFileDialog.FileName);
                }
            }

        }

        private void Btn_AddTask_Click(object sender, EventArgs e)
        {
            if (File == null) 
            {
                MessageBox.Show($"You have to search a file to add a task","Wait",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }

            using (TaskManager taskManager = new TaskManager())
            {
                taskManager.ShowDialog();
            }

        }
    }
}
