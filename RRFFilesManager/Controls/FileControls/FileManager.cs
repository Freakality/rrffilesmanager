using ClosedXML.Excel;
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
        private readonly ILATDataRepository _latDataRepository;
        private Logic.FileManager _fileManager;
        private FileStatusManager _fileStatusManager;
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
            _latDataRepository = Program.GetService<ILATDataRepository>();
            InitializeComponent();
            _fileManager = new Logic.FileManager();
            _fileStatusManager = new FileStatusManager();
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
            CurrentFileStatusComboBox.Enabled = true;
            var statusList = _fileStatusManager.GetValidFileStatus(file);
            Utils.Utils.SetComboBoxDataSource(CurrentFileStatusComboBox, statusList);
            CurrentFileStatusComboBox.SelectedItem = statusList.FirstOrDefault(x => x.ID == file.CurrentStatus.ID);

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
                _fileManager.Update(File);
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

        private void SubTypeCategoryComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void CurrentFileStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newStatus = (FileStatus)CurrentFileStatusComboBox.SelectedValue;
            if (newStatus != null && File.CurrentStatus != newStatus)
            {
                File.CurrentStatus = newStatus;
                _fileManager.Update(File);
            }
        }

        private void TabControl5_Click(object sender, EventArgs e)
        {
            if (TabControl5.SelectedTab == ABLAT)
            {
                Busqueda();
            }
        }

        private void BtnSaveLatData_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button boton = new Button();
                boton = (Button)sender;

                switch (boton.Name)
                {
                    case "BtnLat1":
                        if (DtpEmpty())
                        {
                            MessageBox.Show("Complete the data of lat 1");
                        }
                        else
                        {
                            SaveLat(1);
                        }
                        break;

                    case "BtnLat2":
                        if (DtpEmpty())
                        {
                            MessageBox.Show("Complete the data of lat 2");
                        }
                        else
                        {
                            SaveLat(2);
                        }
                        break;
                    case "BtnLat3":
                        if (DtpEmpty())
                        {
                            MessageBox.Show("Complete the data of lat 3");
                        }
                        else
                        {
                            SaveLat(3);
                        }
                        break;

                    case "BtnLat4":
                        if (DtpEmpty())
                        {
                            MessageBox.Show("Complete the data of lat 4");
                        }
                        else
                        {
                            SaveLat(4);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        private void BtnUpdateLatData_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button boton = new Button();
                boton = (Button)sender;

                switch (boton.Name)
                {
                    case "BtnLat1":
                        if (DtpEmpty())
                        {
                            MessageBox.Show("Complete the data of lat 1");

                        }
                        else
                        {
                            UpdateLat(1);
                        }
                        break;

                    case "BtnLat2":
                        if (DtpEmpty())
                        {
                            MessageBox.Show("Complete the data of lat 2");
                        }
                        else
                        {
                            UpdateLat(2);
                        }
                        break;
                    case "BtnLat3":
                        if (DtpEmpty())
                        {
                            MessageBox.Show("Complete the data of lat 3");
                        }
                        else
                        {
                            UpdateLat(3);
                        }
                        break;

                    case "BtnLat4":
                        if (DtpEmpty())
                        {
                            MessageBox.Show("Complete the data of lat 4");
                        }
                        else
                        {
                            UpdateLat(4);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        private bool DtpEmpty()
        {
            foreach (Control item in TabControl4.SelectedTab.Controls)
            {
                if (item is TextBox)
                {
                    TextBox Txt = new TextBox();
                    Txt = (TextBox)item;
                    if (String.IsNullOrEmpty(Txt.Text))
                    {
                        return true;
                    }
                }
            }

            if (TabControl4.SelectedTab == LAT1)
            {
                foreach (Control itemSummary in TableLayoutPanel2.Controls)
                {
                    if (itemSummary is TextBox)
                    {
                        TextBox Txt = new TextBox();
                        Txt = (TextBox)itemSummary;
                        if (String.IsNullOrEmpty(Txt.Text))
                        {
                            return true;
                        }
                    }
                }

                foreach (Control itemSummary in TableLayoutPanel3.Controls)
                {
                    if (itemSummary is TextBox)
                    {
                        TextBox Txt = new TextBox();
                        Txt = (TextBox)itemSummary;
                        if (String.IsNullOrEmpty(Txt.Text))
                        {
                            return true;
                        }
                    }
                }

            }
            if (TabControl4.SelectedTab == LAT2)
            {
                foreach (Control itemSummary in TableLayoutPanel9.Controls)
                {
                    if (itemSummary is TextBox)
                    {
                        TextBox Txt = new TextBox();
                        Txt = (TextBox)itemSummary;

                        if (String.IsNullOrEmpty(Txt.Text))
                        {
                            return true;
                        }
                    }
                }

                foreach (Control itemSummary in TableLayoutPanel8.Controls)
                {
                    if (itemSummary is TextBox)
                    {
                        TextBox Txt = new TextBox();
                        Txt = (TextBox)itemSummary;
                        if (String.IsNullOrEmpty(Txt.Text))
                        {
                            return true;
                        }
                    }
                }
            }
            if (TabControl4.SelectedTab == LAT3)
            {
                foreach (Control itemSummary in TableLayoutPanel13.Controls)
                {
                    if (itemSummary is TextBox)
                    {
                        TextBox Txt = new TextBox();
                        Txt = (TextBox)itemSummary;
                        if (String.IsNullOrEmpty(Txt.Text))
                        {
                            return true;
                        }
                    }
                }

                foreach (Control itemSummary in TableLayoutPanel12.Controls)
                {
                    if (itemSummary is TextBox)
                    {
                        TextBox Txt = new TextBox();
                        Txt = (TextBox)itemSummary;
                        if (String.IsNullOrEmpty(Txt.Text))
                        {
                            return true;
                        }
                    }
                }

            }
            if (TabControl4.SelectedTab == LAT4)
            {
                foreach (Control itemSummary in TableLayoutPanel17.Controls)
                {
                    if (itemSummary is TextBox)
                    {
                        TextBox Txt = new TextBox();
                        Txt = (TextBox)itemSummary;

                        if (String.IsNullOrEmpty(Txt.Text))
                        {
                            return true;
                        }
                    }
                }

                foreach (Control itemSummary in TableLayoutPanel16.Controls)
                {
                    if (itemSummary is TextBox)
                    {
                        TextBox Txt = new TextBox();
                        Txt = (TextBox)itemSummary;
                        if (String.IsNullOrEmpty(Txt.Text))
                        {
                            return true;
                        }
                    }
                }

            }

            return false;
        }
        private void SaveLat(int latNumber)
        {
            try
            {
                LATData _LatData = new LATData();
                if (latNumber == 1)
                {
                    _LatData.FileId = Home.FileManager.File.ID;
                    _LatData.LATNumber = 1;
                    _LatData.LATActualDateFiled = ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberTxt.Text;
                    _LatData.LATCaseConfDate = LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorTxt.Text;
                    _LatData.LATAdjuster = AdjusterTxt.Text;
                    _LatData.LATInsurer = InsurerTxt.Text;
                    _LatData.LATInsurerCounsel = InsurerCounselTxt.Text;
                    _LatData.LATInsurerFirm = InsurerFirmTxt.Text;
                    _LatData.LATHearingType = HearingTypeTxt.Text;
                    _LatData.LATHearingDate = HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorTxt.Text;
                    _LatData.LATDateSettled = DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = string.IsNullOrEmpty(AmountSettledTxt.Text) ? 0.00 : Convert.ToDouble(AmountSettledTxt.Text);
                    _LatData.LATIssue1 = TxtIssues1.Text;
                    _LatData.LATIssue2 = TxtIssues2.Text;
                    _LatData.LATIssue3 = TxtIssues3.Text;
                    _LatData.LATIssue4 = TxtIssues4.Text;
                    _LatData.LATIssue5 = TxtIssues5.Text;
                    _LatData.LATIssue6 = TxtIssues6.Text;
                    _LatData.LATIssue7 = TxtIssues7.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions = DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc = DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = DeadlineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Insert(_LatData, 1, Home.FileManager.File);
                }
                else if (latNumber == 2)
                {
                    _LatData.FileId = Home.FileManager.File.ID;
                    _LatData.LATNumber = 2;
                    _LatData.LATActualDateFiled = Lat2ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberLat2.Text;
                    _LatData.LATCaseConfDate = Lat2LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorLat2.Text;
                    _LatData.LATAdjuster = AdjusterLat2.Text;
                    _LatData.LATInsurer = InsurerLat2.Text;
                    _LatData.LATInsurerCounsel = InsurerCounselLat2.Text;
                    _LatData.LATInsurerFirm = InsureFirmLat2.Text;
                    _LatData.LATHearingType = HearingTypeLat2.Text;
                    _LatData.LATHearingDate = Lat2HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorLat2.Text;
                    _LatData.LATDateSettled = Lat2DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = string.IsNullOrEmpty(AmountSettledLat2.Text) ? 0.00 : Convert.ToDouble(AmountSettledLat2.Text);

                    _LatData.LATIssue1 = IssuesLat2.Text;
                    _LatData.LATIssue2 = Issues2Lat2.Text;
                    _LatData.LATIssue3 = Issues3Lat2.Text;
                    _LatData.LATIssue4 = Issues4Lat2.Text;
                    _LatData.LATIssue5 = Issues5Lat2.Text;
                    _LatData.LATIssue6 = Issues6Lat2.Text;
                    _LatData.LATIssue7 = Issues7Lat2.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = Lat2DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = Lat2DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = Lat2ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = Lat2ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = Lat2InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = Lat2DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = Lat2DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions = Lat2DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc = Lat2DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = Lat2DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = Lat2DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = Lat2DeadLineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = Lat2DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Insert(_LatData, 2, Home.FileManager.File);
                }
                else if (latNumber == 3)
                {
                    _LatData.FileId = Home.FileManager.File.ID;
                    _LatData.LATNumber = 3;
                    _LatData.LATActualDateFiled = Lat3ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberLat3.Text;
                    _LatData.LATCaseConfDate = Lat3LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorLat3.Text;
                    _LatData.LATAdjuster = AdjusterLat3.Text;
                    _LatData.LATInsurer = InsurerLat3.Text;
                    _LatData.LATInsurerCounsel = InsureCounselLat3.Text;
                    _LatData.LATInsurerFirm = InsurerFirmLat3.Text;
                    _LatData.LATHearingType = HearingTypeLat3.Text;
                    _LatData.LATHearingDate = Lat3HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorLat3.Text;
                    _LatData.LATDateSettled = Lat3DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = string.IsNullOrEmpty(AmountSettledLat3.Text) ? 0.00 : Convert.ToDouble(AmountSettledLat3.Text);
                    _LatData.LATIssue1 = IssuesLat3.Text;
                    _LatData.LATIssue2 = Issues2Lat3.Text;
                    _LatData.LATIssue3 = Issues3Lat3.Text;
                    _LatData.LATIssue4 = Issues4Lat3.Text;
                    _LatData.LATIssue5 = Issues5Lat3.Text;
                    _LatData.LATIssue6 = Issues6Lat3.Text;
                    _LatData.LATIssue7 = Issues7Lat3.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = Lat3DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = Lat3DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = Lat3ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = Lat3ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = Lat3InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = Lat3DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = Lat3DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions = Lat3DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc = Lat3DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = Lat3DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = Lat3DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = Lat3DeadLineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = Lat3DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Insert(_LatData, 3, Home.FileManager.File);
                }
                else if (latNumber == 4)
                {
                    _LatData.FileId = Home.FileManager.File.ID;
                    _LatData.LATNumber = 4;
                    _LatData.LATActualDateFiled = Lat4ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberLat4.Text;
                    _LatData.LATCaseConfDate = Lat4LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorLat4.Text;
                    _LatData.LATAdjuster = AdjusterLat4.Text;
                    _LatData.LATInsurer = InsurerLat4.Text;
                    _LatData.LATInsurerCounsel = InsurerCounselLat4.Text;
                    _LatData.LATInsurerFirm = InsurerFirmLat4.Text;
                    _LatData.LATHearingType = HearingTypeLat4.Text;
                    _LatData.LATHearingDate = Lat4HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorLat4.Text;
                    _LatData.LATDateSettled = Lat4DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = string.IsNullOrEmpty(AmountSettledLat4.Text) ? 0.00 : Convert.ToDouble(AmountSettledLat4.Text);
                    _LatData.LATIssue1 = IssuesLat4.Text;
                    _LatData.LATIssue2 = Issues2Lat4.Text;
                    _LatData.LATIssue3 = Issues3Lat4.Text;
                    _LatData.LATIssue4 = Issues4Lat4.Text;
                    _LatData.LATIssue5 = Issues5Lat4.Text;
                    _LatData.LATIssue6 = Issues6Lat4.Text;
                    _LatData.LATIssue7 = Issues7Lat4.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = Lat4DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = Lat4DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = Lat4ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = Lat4ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = Lat4InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = Lat4DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = Lat4DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions = Lat4DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc = Lat4DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = Lat4DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = Lat4DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = Lat4DeadLineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = Lat4DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Insert(_LatData, 4, Home.FileManager.File);
                }

                MessageBox.Show("Data saved successfully!");
                ClearDataLat();
                Busqueda();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

        }
        private void UpdateLat(int latNumber)
        {
            try
            {
                LATData _LatData = new LATData();
                if (latNumber == 1)
                {
                    _LatData.ID = Home.FileManager.File.LATData.ToList().Single(T => T.LATNumber == 1).ID;
                    _LatData.FileId = Home.FileManager.File.ID;
                    _LatData.LATNumber = 1;
                    _LatData.LATActualDateFiled = ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberTxt.Text;
                    _LatData.LATCaseConfDate = LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorTxt.Text;
                    _LatData.LATAdjuster = AdjusterTxt.Text;
                    _LatData.LATInsurer = InsurerTxt.Text;
                    _LatData.LATInsurerCounsel = InsurerCounselTxt.Text;
                    _LatData.LATInsurerFirm = InsurerFirmTxt.Text;
                    _LatData.LATHearingType = HearingTypeTxt.Text;
                    _LatData.LATHearingDate = HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorTxt.Text;
                    _LatData.LATDateSettled = DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = Convert.ToDouble(AmountSettledTxt.Text);
                    _LatData.LATIssue1 = TxtIssues1.Text;
                    _LatData.LATIssue2 = TxtIssues2.Text;
                    _LatData.LATIssue3 = TxtIssues3.Text;
                    _LatData.LATIssue4 = TxtIssues4.Text;
                    _LatData.LATIssue5 = TxtIssues5.Text;
                    _LatData.LATIssue6 = TxtIssues6.Text;
                    _LatData.LATIssue7 = TxtIssues7.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions = DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc = DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = DeadlineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Update(_LatData);
                }
                else if (latNumber == 2)
                {
                    _LatData.ID = Home.FileManager.File.LATData.ToList().Single(T => T.LATNumber == 2).ID;
                    _LatData.FileId = Home.FileManager.File.ID;
                    _LatData.LATNumber = 2;
                    _LatData.LATActualDateFiled = Lat2ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberLat2.Text;
                    _LatData.LATCaseConfDate = Lat2LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorLat2.Text;
                    _LatData.LATAdjuster = AdjusterLat2.Text;
                    _LatData.LATInsurer = InsurerLat2.Text;
                    _LatData.LATInsurerCounsel = InsurerCounselLat2.Text;
                    _LatData.LATInsurerFirm = InsureFirmLat2.Text;
                    _LatData.LATHearingType = HearingTypeLat2.Text;
                    _LatData.LATHearingDate = Lat2HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorLat2.Text;
                    _LatData.LATDateSettled = Lat2DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = Convert.ToDouble(AmountSettledLat2.Text);
                    _LatData.LATIssue1 = IssuesLat2.Text;
                    _LatData.LATIssue2 = Issues2Lat2.Text;
                    _LatData.LATIssue3 = Issues3Lat2.Text;
                    _LatData.LATIssue4 = Issues4Lat2.Text;
                    _LatData.LATIssue5 = Issues5Lat2.Text;
                    _LatData.LATIssue6 = Issues6Lat2.Text;
                    _LatData.LATIssue7 = Issues7Lat2.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = Lat2DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = Lat2DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = Lat2ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = Lat2ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = Lat2InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = Lat2DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = Lat2DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions = Lat2DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc = Lat2DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = Lat2DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = Lat2DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = Lat2DeadLineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = Lat2DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Update(_LatData);
                }
                else if (latNumber == 3)
                {
                    _LatData.ID = Home.FileManager.File.LATData.ToList().Single(T => T.LATNumber == 3).ID;
                    _LatData.FileId = Home.FileManager.File.ID;
                    _LatData.LATNumber = 3;
                    _LatData.LATActualDateFiled = Lat3ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberLat3.Text;
                    _LatData.LATCaseConfDate = Lat3LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorLat3.Text;
                    _LatData.LATAdjuster = AdjusterLat3.Text;
                    _LatData.LATInsurer = InsurerLat3.Text;
                    _LatData.LATInsurerCounsel = InsureCounselLat3.Text;
                    _LatData.LATInsurerFirm = InsurerFirmLat3.Text;
                    _LatData.LATHearingType = HearingTypeLat3.Text;
                    _LatData.LATHearingDate = Lat3HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorLat3.Text;
                    _LatData.LATDateSettled = Lat3DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = Convert.ToDouble(AmountSettledLat3.Text);
                    _LatData.LATIssue1 = IssuesLat3.Text;
                    _LatData.LATIssue2 = Issues2Lat3.Text;
                    _LatData.LATIssue3 = Issues3Lat3.Text;
                    _LatData.LATIssue4 = Issues4Lat3.Text;
                    _LatData.LATIssue5 = Issues5Lat3.Text;
                    _LatData.LATIssue6 = Issues6Lat3.Text;
                    _LatData.LATIssue7 = Issues7Lat3.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = Lat3DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = Lat3DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = Lat3ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = Lat3ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = Lat3InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = Lat3DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = Lat3DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions = Lat3DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc = Lat3DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = Lat3DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = Lat3DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = Lat3DeadLineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = Lat3DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Update(_LatData);
                }
                else if (latNumber == 4)
                {
                    _LatData.ID = Home.FileManager.File.LATData.ToList().Single(T => T.LATNumber == 4).ID;
                    _LatData.FileId = Home.FileManager.File.ID;
                    _LatData.LATNumber = 4;
                    _LatData.LATActualDateFiled = Lat4ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberLat4.Text;
                    _LatData.LATCaseConfDate = Lat4LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorLat4.Text;
                    _LatData.LATAdjuster = AdjusterLat4.Text;
                    _LatData.LATInsurer = InsurerLat4.Text;
                    _LatData.LATInsurerCounsel = InsurerCounselLat4.Text;
                    _LatData.LATInsurerFirm = InsurerFirmLat4.Text;
                    _LatData.LATHearingType = HearingTypeLat4.Text;
                    _LatData.LATHearingDate = Lat4HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorLat4.Text;
                    _LatData.LATDateSettled = Lat4DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = Convert.ToDouble(AmountSettledLat4.Text);
                    _LatData.LATIssue1 = IssuesLat4.Text;
                    _LatData.LATIssue2 = Issues2Lat4.Text;
                    _LatData.LATIssue3 = Issues3Lat4.Text;
                    _LatData.LATIssue4 = Issues4Lat4.Text;
                    _LatData.LATIssue5 = Issues5Lat4.Text;
                    _LatData.LATIssue6 = Issues6Lat4.Text;
                    _LatData.LATIssue7 = Issues7Lat4.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = Lat4DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = Lat4DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = Lat4ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = Lat4ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = Lat4InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = Lat4DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = Lat4DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions = Lat4DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc = Lat4DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = Lat4DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = Lat4DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = Lat4DeadLineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = Lat4DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Update(_LatData);
                }
                MessageBox.Show("Data Updated successfully!");
                ClearDataLat();
                Busqueda();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void ClearDataLat()
        {
            foreach (Control item in TabControl4.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tx = new TextBox();
                    tx = (TextBox)item;
                    tx.Clear();
                }
            }
        }
        private void Busqueda()
        {
            if (Home.FileManager.File == null)
            {
                TabControl4.Enabled = false;
                MessageBox.Show("You have to select a file!");
                return;
            }
            else
            {
                TabControl4.Enabled = true;
            }
            txtLimitationDate.Text = Home.FileManager.File.LimitationPeriod;
            if (_latDataRepository.List().Where(t => t.FileId == Home.FileManager.File.ID).ToList().Count == 0)
            {
                ClearDataLat();
                MessageBox.Show("No lats available!");
            }
            if (_latDataRepository.Search(Home.FileManager.File, 1).ToList().Count > 0)
            {
                var latRepo = _latDataRepository.List().Single(t => t.FileId == Home.FileManager.File.ID && t.LATNumber == 1);
                ActualDateLatFiledDtp.Value = latRepo.LATActualDateFiled;
                LatCaseConfDateDtp.Value = latRepo.LATCaseConfDate;
                HearingStarDateDtp.Value = latRepo.LATHearingDate;
                DateLatSettledClosedDtp.Value = latRepo.LATDateSettled;

                DueDateToDiscussPotenctialLatApplDtp.Value = latRepo.LATDueDateToDiscussPotentialLAT;
                DateMetWithLawyerReDenialDtp.Value = latRepo.LATDateMetWithLawyerReDenial;
                ProposedDateToFileLatDtp.Value = latRepo.LATProposedDateToFileLAT;
                ActualDateLatServedOnInsurerDtp.Value = latRepo.LATActualDateLATServedOnInsurer;
                InsuresResponseReceivedDtp.Value = latRepo.LATInsurersResponseReceived;
                DeadLineToServeFileCaseConfSummaryDtp.Value = latRepo.LATDeadlineToServeFileCaseConfSummary;
                DeadLineToDeliverProductionsToABCounselDtp.Value = latRepo.LATDeadlineToDeliverProductionstoABCounsel;
                DeadLineToReceiveABProductionsDtp.Value = latRepo.LATDeadlineToReceiveABProductions;
                DeadLineToFileAffidavitReportsDtp.Value = latRepo.LATDeadlineToFileAffidavitReportsEtc;
                DeadLineToReceiveAffidavitReportsDtp.Value = latRepo.LATDeadlineToReceiveAffidavitReportsEtc;
                DeadLineToFileHearingSubmissionsDtp.Value = latRepo.LATDeadlineToFileHearingSubmissionsAndOrBriefs;
                DeadlineToReceiveInsurerDtp.Value = latRepo.LATDeadlineToReceiveInsurerSubmissions;
                DeadLineForReplaySubmissionsDtp.Value = latRepo.LATDeadlineForReplySubmissionsOfTheApplicant;

                TribunalNumberTxt.Text = latRepo.LATTribunalNumber;
                CaseAdjudicatorTxt.Text = latRepo.LATCaseAdjudicator;
                AdjusterTxt.Text = latRepo.LATAdjuster;
                InsurerTxt.Text = latRepo.LATInsurer;
                InsurerCounselTxt.Text = latRepo.LATInsurerCounsel;
                InsurerFirmTxt.Text = latRepo.LATInsurerFirm;
                HearingTypeTxt.Text = latRepo.LATHearingType;
                HearingAdjudicatorTxt.Text = latRepo.LATHearingAdjudicator;
                AmountSettledTxt.Text = latRepo.LATAmountSettled.ToString();
                TxtIssues1.Text = latRepo.LATIssue1;
                TxtIssues2.Text = latRepo.LATIssue2;
                TxtIssues3.Text = latRepo.LATIssue3;
                TxtIssues4.Text = latRepo.LATIssue4;
                TxtIssues5.Text = latRepo.LATIssue5;
                TxtIssues6.Text = latRepo.LATIssue6;
                TxtIssues7.Text = latRepo.LATIssue7;

                BtnLat1.Text = "Update";
                BtnLat1.Click -= BtnSaveLatData_Click;
                BtnLat1.Click -= BtnUpdateLatData_Click;
                BtnLat1.Click += BtnUpdateLatData_Click;
            }
            else
            {
                BtnLat1.Text = "Save";
                BtnLat1.Click -= BtnUpdateLatData_Click;
                BtnLat1.Click -= BtnSaveLatData_Click; ;
                BtnLat1.Click += BtnSaveLatData_Click;
            }

            if (_latDataRepository.Search(Home.FileManager.File, 2).ToList().Count > 0)
            {
                var latRepo = _latDataRepository.List().Single(t => t.FileId == Home.FileManager.File.ID && t.LATNumber == 2);
                Lat2ActualDateLatFiledDtp.Value = latRepo.LATActualDateFiled;
                Lat2LatCaseConfDateDtp.Value = latRepo.LATCaseConfDate;
                Lat2HearingStarDateDtp.Value = latRepo.LATHearingDate;
                Lat2DateLatSettledClosedDtp.Value = latRepo.LATDateSettled;

                Lat2DueDateToDiscussPotenctialLatApplDtp.Value = latRepo.LATDueDateToDiscussPotentialLAT;
                Lat2DateMetWithLawyerReDenialDtp.Value = latRepo.LATDateMetWithLawyerReDenial;
                Lat2ProposedDateToFileLatDtp.Value = latRepo.LATProposedDateToFileLAT;
                Lat2ActualDateLatServedOnInsurerDtp.Value = latRepo.LATActualDateLATServedOnInsurer;
                Lat2InsuresResponseReceivedDtp.Value = latRepo.LATInsurersResponseReceived;
                Lat2DeadLineToServeFileCaseConfSummaryDtp.Value = latRepo.LATDeadlineToServeFileCaseConfSummary;
                Lat2DeadLineToDeliverProductionsToABCounselDtp.Value = latRepo.LATDeadlineToDeliverProductionstoABCounsel;
                Lat2DeadLineToReceiveABProductionsDtp.Value = latRepo.LATDeadlineToReceiveABProductions;
                Lat2DeadLineToFileAffidavitReportsDtp.Value = latRepo.LATDeadlineToFileAffidavitReportsEtc;
                Lat2DeadLineToReceiveAffidavitReportsDtp.Value = latRepo.LATDeadlineToReceiveAffidavitReportsEtc;
                Lat2DeadLineToFileHearingSubmissionsDtp.Value = latRepo.LATDeadlineToFileHearingSubmissionsAndOrBriefs;
                Lat2DeadLineToReceiveInsurerDtp.Value = latRepo.LATDeadlineToReceiveInsurerSubmissions;
                Lat2DeadLineForReplaySubmissionsDtp.Value = latRepo.LATDeadlineForReplySubmissionsOfTheApplicant;

                TribunalNumberLat2.Text = latRepo.LATTribunalNumber;
                CaseAdjudicatorLat2.Text = latRepo.LATCaseAdjudicator;
                AdjusterLat2.Text = latRepo.LATAdjuster;
                InsurerLat2.Text = latRepo.LATInsurer;
                InsurerCounselLat2.Text = latRepo.LATInsurerCounsel;
                InsureFirmLat2.Text = latRepo.LATInsurerFirm;
                HearingTypeLat2.Text = latRepo.LATHearingType;
                HearingAdjudicatorLat2.Text = latRepo.LATHearingAdjudicator;
                AmountSettledLat2.Text = latRepo.LATAmountSettled.ToString();
                IssuesLat2.Text = latRepo.LATIssue1;
                Issues2Lat2.Text = latRepo.LATIssue2;
                Issues3Lat2.Text = latRepo.LATIssue3;
                Issues4Lat2.Text = latRepo.LATIssue4;
                Issues5Lat2.Text = latRepo.LATIssue5;
                Issues6Lat2.Text = latRepo.LATIssue6;
                Issues7Lat2.Text = latRepo.LATIssue7;

                BtnLat2.Text = "Update";
                BtnLat2.Click -= BtnSaveLatData_Click;
                BtnLat2.Click -= BtnUpdateLatData_Click;
                BtnLat2.Click += BtnUpdateLatData_Click;
            }
            else
            {
                BtnLat2.Text = "Save";
                BtnLat2.Click -= BtnUpdateLatData_Click;
                BtnLat2.Click -= BtnSaveLatData_Click; ;
                BtnLat2.Click += BtnSaveLatData_Click;
            }

            if (_latDataRepository.Search(Home.FileManager.File, 3).ToList().Count > 0)
            {
                var latRepo = _latDataRepository.List().Single(t => t.FileId == Home.FileManager.File.ID && t.LATNumber == 3);
                Lat3ActualDateLatFiledDtp.Value = latRepo.LATActualDateFiled;
                Lat3LatCaseConfDateDtp.Value = latRepo.LATCaseConfDate;
                Lat3HearingStarDateDtp.Value = latRepo.LATHearingDate;
                Lat3DateLatSettledClosedDtp.Value = latRepo.LATDateSettled;

                Lat3DueDateToDiscussPotenctialLatApplDtp.Value = latRepo.LATDueDateToDiscussPotentialLAT;
                Lat3DateMetWithLawyerReDenialDtp.Value = latRepo.LATDateMetWithLawyerReDenial;
                Lat3ProposedDateToFileLatDtp.Value = latRepo.LATProposedDateToFileLAT;
                Lat3ActualDateLatServedOnInsurerDtp.Value = latRepo.LATActualDateLATServedOnInsurer;
                Lat3InsuresResponseReceivedDtp.Value = latRepo.LATInsurersResponseReceived;
                Lat3DeadLineToServeFileCaseConfSummaryDtp.Value = latRepo.LATDeadlineToServeFileCaseConfSummary;
                Lat3DeadLineToDeliverProductionsToABCounselDtp.Value = latRepo.LATDeadlineToDeliverProductionstoABCounsel;
                Lat3DeadLineToReceiveABProductionsDtp.Value = latRepo.LATDeadlineToReceiveABProductions;
                Lat3DeadLineToFileAffidavitReportsDtp.Value = latRepo.LATDeadlineToFileAffidavitReportsEtc;
                Lat3DeadLineToReceiveAffidavitReportsDtp.Value = latRepo.LATDeadlineToReceiveAffidavitReportsEtc;
                Lat3DeadLineToFileHearingSubmissionsDtp.Value = latRepo.LATDeadlineToFileHearingSubmissionsAndOrBriefs;
                Lat3DeadLineToReceiveInsurerDtp.Value = latRepo.LATDeadlineToReceiveInsurerSubmissions;
                Lat3DeadLineForReplaySubmissionsDtp.Value = latRepo.LATDeadlineForReplySubmissionsOfTheApplicant;

                TribunalNumberLat3.Text = latRepo.LATTribunalNumber;
                CaseAdjudicatorLat3.Text = latRepo.LATCaseAdjudicator;
                AdjusterLat3.Text = latRepo.LATAdjuster;
                InsurerLat3.Text = latRepo.LATInsurer;
                InsureCounselLat3.Text = latRepo.LATInsurerCounsel;
                InsurerFirmLat3.Text = latRepo.LATInsurerFirm;
                HearingTypeLat3.Text = latRepo.LATHearingType;
                HearingAdjudicatorLat3.Text = latRepo.LATHearingAdjudicator;
                AmountSettledLat3.Text = latRepo.LATAmountSettled.ToString();
                IssuesLat3.Text = latRepo.LATIssue1;
                Issues2Lat3.Text = latRepo.LATIssue2;
                Issues3Lat3.Text = latRepo.LATIssue3;
                Issues4Lat3.Text = latRepo.LATIssue4;
                Issues5Lat3.Text = latRepo.LATIssue5;
                Issues6Lat3.Text = latRepo.LATIssue6;
                Issues7Lat3.Text = latRepo.LATIssue7;

                BtnLat3.Text = "Update";
                BtnLat3.Click -= BtnSaveLatData_Click;
                BtnLat3.Click -= BtnUpdateLatData_Click;
                BtnLat3.Click += BtnUpdateLatData_Click;
            }
            else
            {
                BtnLat3.Text = "Save";
                BtnLat3.Click -= BtnUpdateLatData_Click;
                BtnLat3.Click -= BtnSaveLatData_Click; ;
                BtnLat3.Click += BtnSaveLatData_Click;
            }

            if (_latDataRepository.Search(Home.FileManager.File, 4).ToList().Count > 0)
            {
                //var latRepo = _latDataRepository.Search(Home.FileManager.File, 3).ToList().Find(t => t.LATNumber == 3);
                var latRepo = _latDataRepository.List().Single(t => t.FileId == Home.FileManager.File.ID && t.LATNumber == 4);
                Lat4ActualDateLatFiledDtp.Value = latRepo.LATActualDateFiled;
                Lat4LatCaseConfDateDtp.Value = latRepo.LATCaseConfDate;
                Lat4HearingStarDateDtp.Value = latRepo.LATHearingDate;
                Lat4DateLatSettledClosedDtp.Value = latRepo.LATDateSettled;

                Lat4DueDateToDiscussPotenctialLatApplDtp.Value = latRepo.LATDueDateToDiscussPotentialLAT;
                Lat4DateMetWithLawyerReDenialDtp.Value = latRepo.LATDateMetWithLawyerReDenial;
                Lat4ProposedDateToFileLatDtp.Value = latRepo.LATProposedDateToFileLAT;
                Lat4ActualDateLatServedOnInsurerDtp.Value = latRepo.LATActualDateLATServedOnInsurer;
                Lat4InsuresResponseReceivedDtp.Value = latRepo.LATInsurersResponseReceived;
                Lat4DeadLineToServeFileCaseConfSummaryDtp.Value = latRepo.LATDeadlineToServeFileCaseConfSummary;
                Lat4DeadLineToDeliverProductionsToABCounselDtp.Value = latRepo.LATDeadlineToDeliverProductionstoABCounsel;
                Lat4DeadLineToReceiveABProductionsDtp.Value = latRepo.LATDeadlineToReceiveABProductions;
                Lat4DeadLineToFileAffidavitReportsDtp.Value = latRepo.LATDeadlineToFileAffidavitReportsEtc;
                Lat4DeadLineToReceiveAffidavitReportsDtp.Value = latRepo.LATDeadlineToReceiveAffidavitReportsEtc;
                Lat4DeadLineToFileHearingSubmissionsDtp.Value = latRepo.LATDeadlineToFileHearingSubmissionsAndOrBriefs;
                Lat4DeadLineToReceiveInsurerDtp.Value = latRepo.LATDeadlineToReceiveInsurerSubmissions;
                Lat4DeadLineForReplaySubmissionsDtp.Value = latRepo.LATDeadlineForReplySubmissionsOfTheApplicant;

                TribunalNumberLat4.Text = latRepo.LATTribunalNumber;
                CaseAdjudicatorLat4.Text = latRepo.LATCaseAdjudicator;
                AdjusterLat4.Text = latRepo.LATAdjuster;
                InsurerLat4.Text = latRepo.LATInsurer;
                InsurerCounselLat4.Text = latRepo.LATInsurerCounsel;
                InsurerFirmLat4.Text = latRepo.LATInsurerFirm;
                HearingTypeLat4.Text = latRepo.LATHearingType;
                HearingAdjudicatorLat4.Text = latRepo.LATHearingAdjudicator;
                AmountSettledLat4.Text = latRepo.LATAmountSettled.ToString();

                IssuesLat4.Text = latRepo.LATIssue1;
                Issues2Lat4.Text = latRepo.LATIssue2;
                Issues3Lat4.Text = latRepo.LATIssue3;
                Issues4Lat4.Text = latRepo.LATIssue4;
                Issues5Lat4.Text = latRepo.LATIssue5;
                Issues6Lat4.Text = latRepo.LATIssue6;
                Issues7Lat4.Text = latRepo.LATIssue7;

                BtnLat4.Text = "Update";
                BtnLat4.Click -= BtnSaveLatData_Click;
                BtnLat4.Click -= BtnUpdateLatData_Click;
                BtnLat4.Click += BtnUpdateLatData_Click;
            }
            else
            {
                BtnLat4.Text = "Save";
                BtnLat4.Click -= BtnUpdateLatData_Click;
                BtnLat4.Click -= BtnSaveLatData_Click; ;
                BtnLat4.Click += BtnSaveLatData_Click;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
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
