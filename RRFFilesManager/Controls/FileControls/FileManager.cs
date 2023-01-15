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
        public SemiAnnualFileReviewControl SemiAnnualFileReviewControlAction;
        public SemiAnnualFileReviewControl SemiAnnualFileReviewControlAccidentBenefits;
        public TabPage SemiAnnualFileReviewTabAction = new TabPage("Semi-Annual File Review");
        public TabPage SemiAnnualFileReviewTabAccidentBenefits = new TabPage("Semi-Annual File Review");
        public FileManager()
        {
            _fileRepository = Program.GetService<IFileRepository>();
            _timelineRepository = Program.GetService<ITimelineRepository>();
            _taskCategoryRepository = Program.GetService<ITaskCategoryRepository>();
            _taskRepository = Program.GetService<ITaskRepository>();
            _taskStateRepository = Program.GetService<ITaskStateRepository>();
            _fileTaskRepository = Program.GetService<IFileTaskRepository>();
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
    }
}
