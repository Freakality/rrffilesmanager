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
        public ABOverview FileABOverview { get; set; }
        public PolicyParticulars FilePolicyParticulars { get; set; }
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
        private readonly IABOverviewRepository _abOverviewRepository;
        private readonly ILawyerRepository _lawyerRepository;        
        private readonly IDenialRepository _DenialRepository;
        private readonly IDenialBenefitRepository denialBenefitRepository;
        private readonly IDenialStatusRepository denialStatusRepository;
        private readonly IDisabilityInsuranceCompanyRepository _disabilityInsuranceCompanyRepository;
        private readonly IPolicyParticularsRepository _policyParticularsRepository;
        private Logic.FileManager _fileManager;
        private FileStatusManager _fileStatusManager;
        private readonly IClientNoteRepository _clientNoteRepository;
        public SemiAnnualFileReviewControl SemiAnnualFileReviewControlAction;
        public SemiAnnualFileReviewControl SemiAnnualFileReviewControlAccidentBenefits;
        public TabPage SemiAnnualFileReviewTabAction = new TabPage("Semi-Annual File Review");
        public TabPage SemiAnnualFileReviewTabAccidentBenefits = new TabPage("Semi-Annual File Review");
        public IEnumerable<ClientNote> clientNotes;
        public IEnumerable<FileTask> fileTasks;
        private DataTable Notes = new DataTable();
        private DataView FilteredNotes = new DataView();
        TaskActions  Task_Actions = new TaskActions(true);
        ContextMenuStrip Ctms_TaskActions;
        private Lawyer User;
        private readonly IPermissionRepository _permissionRepository;
        private int clearance;
        List<Lawyer> LawyerList = new List<Lawyer>();
        private bool isSettingForm;
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
            _permissionRepository = Program.GetService<IPermissionRepository>();
            _abOverviewRepository = Program.GetService<IABOverviewRepository>();
            _lawyerRepository = Program.GetService<ILawyerRepository>();
            _DenialRepository = Program.GetService<IDenialRepository>();
            denialBenefitRepository = Program.GetService<IDenialBenefitRepository>();
            denialStatusRepository = Program.GetService<IDenialStatusRepository>();
            _disabilityInsuranceCompanyRepository = Program.GetService<IDisabilityInsuranceCompanyRepository>();
            _policyParticularsRepository = Program.GetService<IPolicyParticularsRepository>();
            User = Program.GetUser();
            InitializeComponent();
            _fileManager = new Logic.FileManager();
            _fileStatusManager = new FileStatusManager();            
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

            Notes.Columns.Add("Origin", typeof(string));
            Notes.Columns.Add("Date", typeof(DateTime));
            Notes.Columns.Add("Lawyer", typeof(string));
            Notes.Columns.Add("Description", typeof(string));
            Notes.TableName = "ClientNotesDataTable";
            FillDenialData();
            FilteredNotes.Table = Notes;
            Ctms_TaskActions = Task_Actions.Ctms_TaskActions;
            Home.Instance.AddPermissionStrip(TimelineSaveBtn);
            ShowClearanceLocked();
            
        }

        private void FillDenialData()
        {
            DenialBenefitCheck("IRB - Pre-104");
            DenialBenefitCheck("IRB - Post 104");
            DenialBenefitCheck("Non-Earner");
            DenialBenefitCheck("Care Giver");
            DenialBenefitCheck("Med/Rehab");
            DenialBenefitCheck("AC");
            DenialBenefitCheck("HH");
            DenialBenefitCheck("MIG");
            DenialBenefitCheck("CAT");

            DenialStatusCheck("Pending");
            DenialStatusCheck("Withdrawn");
            DenialStatusCheck("Filed for LAT");
            DenialStatusCheck("Claiming in Tort");
            DenialStatusCheck("Settled");
            DenialStatusCheck("Not Pursuing");
        }

        private void DenialBenefitCheck(string description)
        {
            if (denialBenefitRepository.GetByDescription(description) is null)
            {
                DenialBenefit benefit = new DenialBenefit();
                benefit.Description = description;
                denialBenefitRepository.Insert(benefit);
            }
        }
       
        private void DenialStatusCheck(string description)
        {
            if (denialStatusRepository.GetByDescription(description) is null)
            {
                DenialStatus status = new DenialStatus();
                status.Description = description;
                denialStatusRepository.Insert(status);
            }
        }

        private void ShowClearanceLocked()
        {
            clearance = Home.Instance.GetClearance(TimelineSaveBtn);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
            {
                TBoxLiabilityMeetingDate.Visible = true;
                TBoxPrePleadingsMeetingDate.Visible = true;
                TBoxActualDateSOCIssued.Visible = true;
                TBoxPreDiscoveryMeetingDate.Visible = true;
                TBoxDateOfPlaintiffDiscovery.Visible = true;
                TBoxTimelineMediationResolutionDate.Visible = true;
                TBoxTimelinePrePreTrialMeetingDate.Visible = true;
                TBoxPreTrialResolutionDate.Visible = true;
                TBoxTrialDate.Visible = true;
            }
            else
            {
                TBoxLiabilityMeetingDate.Visible = false;
                TBoxPrePleadingsMeetingDate.Visible = false;
                TBoxActualDateSOCIssued.Visible = false;
                TBoxPreDiscoveryMeetingDate.Visible = false;
                TBoxDateOfPlaintiffDiscovery.Visible = false;
                TBoxTimelineMediationResolutionDate.Visible = false;
                TBoxTimelinePrePreTrialMeetingDate.Visible = false;
                TBoxPreTrialResolutionDate.Visible = false;
                TBoxTrialDate.Visible = false;
            }
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
            if (file == null)
                return;
            isSettingForm = true;
            PeopleControl.SetFile(file);
            ABBinderControl.SetFile(file);
            StandardBenefitStatementsControl.SetFile(file);
            MedicalBinderIndexControl.SetFile(file);
            PrescriptionSummariesControl.SetFile(file);
            QuickABPaidToDateControl.SetFile(file);

            ClientNameTextBox.Text = file.Client.ToString();
            MatterTypeTextBox.Text = file.MatterType.ToString();
            MatterSubTypeTextBox.Text = file?.MatterSubType?.ToString();
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

            FastEnabler(TimelineLayoutPanel);
            FastEnabler(ABOMainLayoutPanel);
            FastEnabler(PolicyParticularsMainLayoutPanel);
            /*foreach(Control c in TimelineLayoutPanel.Controls)
            {
                if (c is Button || c is ColorDateTimePicker || c is DateTimePicker)
                {
                    c.Enabled = true;
                }
            }*/

            /*TBoxLiabilityMeetingDate.Enabled = true;
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
            TimelineSaveBtn.Enabled = true;*/

            if (File.Timeline != null)
            {
                FillTimelineFields();   
            }
            LoadABOverview();
            var insurerList = _disabilityInsuranceCompanyRepository.List();
            Utils.Utils.SetComboBoxDataSource(PPHomeInsurerComboBox, insurerList);
            LoadPolicyParticulars();
            if (File.Tasks.ToList().Count > 0)
            {
                RefreshActionLogDataGridViewDataSource();
                SetStatesLawyersAndBusinessProcessDataInTaslgsFiltersComboBoxes();
            }
            CurrentFileStatusComboBox.Enabled = true;
            Btn_SearchNotes.Enabled = true;
            var statusList = _fileStatusManager.GetValidFileStatus(file);
            Utils.Utils.SetComboBoxDataSource(CurrentFileStatusComboBox, statusList);
            CurrentFileStatusComboBox.SelectedItem = file.CurrentStatus;
            isSettingForm = false;
        }

        private void LoadPolicyParticulars()
        {
            PPInsurerNameTextBox.Text = File.Intake.AccBenInsuranceCompany;
            PPDateOfLossTextBox.Text = File.DateOFLoss.ToString("MMMM dd, yyyy");

            FilePolicyParticulars = File.PolicyParticulars;
            if (FilePolicyParticulars != null)
            {
                if (FilePolicyParticulars.TermOfPolicyFrom != default)
                    PPTermsOfPolicyFrom.Value = FilePolicyParticulars.TermOfPolicyFrom;
                if (FilePolicyParticulars.TermOfPolicyTo != default)
                    PPTermsOfPolicyTo.Value = FilePolicyParticulars.TermOfPolicyTo;

                PPOPCF44RComboBox.SelectedItem = FilePolicyParticulars.OPCF44R ?? null;
                if (FilePolicyParticulars.OPCF44RLiabilityLimits != 0)
                    PPOPCF44RLiabilityLimitsTextBox.DollarValue = FilePolicyParticulars.OPCF44RLiabilityLimits;

                PPUmbrellaViaAutoComboBox.SelectedItem = FilePolicyParticulars.UmbrellaViaAuto ?? null;
                if (FilePolicyParticulars.UmbrellaViaAutoLiabilityLimits != 0)
                    PPUmbrellaLiabilityLimitsTextBox.DollarValue = FilePolicyParticulars.UmbrellaViaAutoLiabilityLimits;

                PPOptionalBenefitsPurchasedComboBox.SelectedItem = FilePolicyParticulars.OptionalBenefitsPurchased ?? null;
                PPOptionalBenefitsPurchasedDetailsTextBox.Text = FilePolicyParticulars.OptionalBenefitsPurchasedDetails;

                if (FilePolicyParticulars.ExcessHomeInsurer != null)
                {
                    PPHomeInsurerComboBox.SelectedItem = FilePolicyParticulars.ExcessHomeInsurer;
                }
                PPUmbrellaCoverageComboBox.SelectedItem = FilePolicyParticulars.ExcessUmbrellaCoverage ?? null;
                PPCopyOfPolicyInFileComboBox.SelectedItem = FilePolicyParticulars.ExcessCopyOfPolicyInFile ?? null;
                if (FilePolicyParticulars.ExcessCoverageAmount != 0)
                    PPCoverageAmountTextBox.DollarValue = FilePolicyParticulars.ExcessCoverageAmount;
            }
            else
            {
                PPTermsOfPolicyFromTextBox.Text = "";
                PPTermsOfPolicyToTextBox.Text = "";

                PPOPCF44RComboBox.SelectedItem = null;
                PPOPCF44RLiabilityLimitsTextBox.Text = "";

                PPUmbrellaViaAutoComboBox.SelectedItem = null;
                PPUmbrellaLiabilityLimitsTextBox.Text = "";

                PPOptionalBenefitsPurchasedComboBox.SelectedItem = null;
                PPOptionalBenefitsPurchasedDetailsTextBox.Text = "";

                PPHomeInsurerComboBox.SelectedItem = null;
                PPUmbrellaCoverageComboBox.SelectedItem = null;
                PPCopyOfPolicyInFileComboBox.SelectedItem = null;
                PPCoverageAmountTextBox.Text = "";
            }
        }
        private void LoadABOverview()
        {
            ABODateOfLossTextBox.Text = File.DateOFLoss.ToString("MMMM dd, yyyy");
            ABOInsurerNameTextBox.Text = File.Intake.AccBenInsuranceCompany;
            ABOAdjusterNameTextBox.Text = File.Intake.AccBenAdjuster;

            FileABOverview = File.ABOverview;
            if (FileABOverview != null)
            {
                ABOPreJune1st2016ComboBox.SelectedItem = FileABOverview.PolicyPreJune1st2016 ?? null;
                ABOOptionalBenefitsComboBox.SelectedItem = FileABOverview.PolicyOptionalBenefits ?? null;
                ABOABCounselTextBox.Text = FileABOverview.PolicyABCounsel ?? "";

                ABOIncomeBenefitsAppliedComboBox.SelectedItem = FileABOverview.IncomeBenefitsApplied ?? null;
                ABOIncomeBenefitsTypeComboBox.SelectedItem = FileABOverview.IncomeBenefitsType ?? null;
                if (FileABOverview.IncomeBenefitsLatestOCF3 != default)
                    ABOIncomeBenefitsLatestOFC3.Value = FileABOverview.IncomeBenefitsLatestOCF3;
                if (FileABOverview.IncomeBenefitsWeeklyAmount != 0)
                    ABOIncomeBenefitsWeeklyAmountTextBox.DollarValue = FileABOverview.IncomeBenefitsWeeklyAmount;
                ABOIncomeBenefitsDeniedComboBox.SelectedItem = FileABOverview.IncomeBenefitsDenied ?? null;
                ABOIncomeBenefitsFileForLATComboBox.SelectedItem = FileABOverview.IncomeBenefitsFiledForLAT ?? null;

                ABOInitiallyApprovedComboBox.SelectedItem = FileABOverview.AttendantCareBenefitsInitiallyApproved ?? null;
                if (FileABOverview.AttendantCareBenefitsInitialAmount != 0)
                    ABOInitialAmountTextBox.DollarValue = FileABOverview.AttendantCareBenefitsInitialAmount;
                ABOACBeingIncurredComboBox.SelectedItem = FileABOverview.AttendantCareBenefitsACBeingIncurred ?? null;
                ABOWhosFundingComboBox.SelectedItem = FileABOverview.AttendantCareBenefitsWhosFunding ?? null;
                if (FileABOverview.AttendantCareBenefitsLatestForm1 != default)
                    ABOLatestForm1Date.Value = FileABOverview.AttendantCareBenefitsLatestForm1;
                if (FileABOverview.AttendantCareBenefitsAmountPaidToDate != 0)
                    ABOACBAmountPaidToDateTextBox.DollarValue = FileABOverview.AttendantCareBenefitsAmountPaidToDate;

                ABOCurrentBenefitsLevelComboBox.SelectedItem = FileABOverview.MedicalRehabBenefitsCurrentLevel ?? null;
                if (FileABOverview.MedicalRehabBenefitsEnd != default)
                    ABOBenefitsEndDate.Value = FileABOverview.MedicalRehabBenefitsEnd;
                if (FileABOverview.MedicalRehabBenefitsAmountPaidToDate != 0)
                    ABOMRBAmountPaidToDateTextBox.DollarValue = FileABOverview.MedicalRehabBenefitsAmountPaidToDate;

                ABOAvailableCollateralInsuredComboBox.SelectedItem = FileABOverview.CollateralsInsured ?? null;
                ABOAvailableCollateralFamilyComboBox.SelectedItem = FileABOverview.CollateralsFamily ?? null;

                if (FileABOverview.StatementBenefitsStatementDate != default)
                    ABOStatementDate.Value = FileABOverview.StatementBenefitsStatementDate;

                ABOGovtOntarioComboBox.SelectedItem = FileABOverview.PotentialOffSetsGovtOntario ?? null;
                ABOGovtFederalComboBox.SelectedItem = FileABOverview.PotentialOffSetsGovtFederal ?? null;
                ABOGroupPrivateComboBox.SelectedItem = FileABOverview.PotentialOffSetsGroupPrivate ?? null;

                ABOCATAppliedComboBox.SelectedItem = FileABOverview.PotentialCATApplied ?? null;
                ABOCATCriteriaComboBox.SelectedItem = FileABOverview.PotentialCATCriteria ?? null;
                ABOIEsScheduledComboBox.SelectedItem = FileABOverview.PotentialCATIEsScheduled ?? null;
                ABOCATResultComboBox.SelectedItem = FileABOverview.PotentialCATResult ?? null;
                ABOCATLATFiledComboBox.SelectedItem = FileABOverview.PotentialCATLATFiled ?? null;

                if (FileABOverview.LastUpdatedDate != default)
                    ABOLastUpdateTextBox.Text= FileABOverview.LastUpdatedDate.ToString("MMMM dd, yyyy");
                else
                {
                    ABOLastUpdateTextBox.Text = "-";
                }

            }
            else
            {
                ABOPreJune1st2016ComboBox.SelectedItem = null;
                ABOOptionalBenefitsComboBox.SelectedItem = null;
                ABOABCounselTextBox.Text = "";

                ABOIncomeBenefitsAppliedComboBox.SelectedItem = null;
                ABOIncomeBenefitsTypeComboBox.SelectedItem = null;
                ABOIncomeBenefitsLatestOFC3TextBox.Text = "";
                ABOIncomeBenefitsWeeklyAmountTextBox.Text = "";
                ABOIncomeBenefitsDeniedComboBox.SelectedItem = null;
                ABOIncomeBenefitsFileForLATComboBox.SelectedItem = null;

                ABOInitiallyApprovedComboBox.SelectedItem = null;
                ABOInitialAmountTextBox.Text = "";
                ABOACBeingIncurredComboBox.SelectedItem =  null;
                ABOWhosFundingComboBox.SelectedItem = null;
                ABOLatestForm1DateTextBox.Text = "";
                ABOACBAmountPaidToDateTextBox.Text = "";

                ABOCurrentBenefitsLevelComboBox.SelectedItem =  null;
                ABOBenefitsEndDateTextBox.Text = "";
                ABOMRBAmountPaidToDateTextBox.Text =  "";

                ABOAvailableCollateralInsuredComboBox.SelectedItem = null;
                ABOAvailableCollateralFamilyComboBox.SelectedItem =  null;

                ABOStatementDateTextBox.Text = "";

                ABOGovtOntarioComboBox.SelectedItem = null;
                ABOGovtFederalComboBox.SelectedItem = null;
                ABOGroupPrivateComboBox.SelectedItem =  null;

                ABOCATAppliedComboBox.SelectedItem = null;
                ABOCATCriteriaComboBox.SelectedItem = null;
                ABOIEsScheduledComboBox.SelectedItem = null;
                ABOCATResultComboBox.SelectedItem = null;
                ABOCATLATFiledComboBox.SelectedItem = null;

                ABOLastUpdateTextBox.Text = "-";
            }

        }
        private void FastEnabler(Control parent)
        {
            if (parent.Controls.Count > 0)
            {
                foreach (Control c in parent.Controls)
                {
                    if (c is Button || c is ColorDateTimePicker || c is DateTimePicker || c is ComboBox || c is TextBox || c is CurrencyTextBox)
                    {
                        c.Enabled = true;
                    }
                    if (c is GroupBox || c is TableLayoutPanel)
                    {
                        FastEnabler(c);
                    }
                }
            }
        }
        private void SetStatesLawyersAndBusinessProcessDataInTaslgsFiltersComboBoxes()
        {
            Cbb_TaskLogStateFilter.Items.Clear();
            Cbb_TaskLogFilterLawyers.Items.Clear();
            Cbb_TaskLogBusinessProcessFilter.Items.Clear();

            Cbb_TaskLogStateFilter.Items.Add("All");
            Cbb_TaskLogFilterLawyers.Items.Add("All");
            Cbb_TaskLogBusinessProcessFilter.Items.Add("All");

            foreach (var item in _taskStateRepository.List())
            {
                Cbb_TaskLogStateFilter.Items.Add(item.Description);
            }
            string[] LawyersDescriptions = fileTasks.Select(x => x?.Task?.Lawyer?.Description?? "N/A").Distinct().ToArray();
            foreach (string item in LawyersDescriptions)
            {
                Cbb_TaskLogFilterLawyers.Items.Add(item);
            }

            string[] BusinessProcessDescriptions = fileTasks.Select(x => x?.Task?.TaskCategory?.Description??"N/A").Distinct().ToArray();
            foreach (string item in BusinessProcessDescriptions)
            {
                Cbb_TaskLogBusinessProcessFilter.Items.Add(item);
            }
            //Cbb_TaskLogStateFilter.SelectedIndex = 0;
            //Cbb_TaskLogFilterLawyers.SelectedIndex = 0;
            //Cbb_TaskLogBusinessProcessFilter.SelectedIndex = 0;
        }

        public void FillTimelineFields()
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
            if (FileTimeline.ProposedDateToServeSOC != default(DateTime))
                TBoxProposedDateToServeSOC.Value = FileTimeline.ProposedDateToServeSOC;
            if (FileTimeline.ActualDateSOCServed != default(DateTime))
                TBoxActualDateSOCServed.Value = FileTimeline.ActualDateSOCServed;
            if (FileTimeline.PlaintiffAODSent != default(DateTime))
                TBoxPlaintiffAODSent.Value = FileTimeline.PlaintiffAODSent;
            if (FileTimeline.MedicalSummariesPreDiscDueDate != default(DateTime))
                TBoxMedicalSummariesPreDiscDueDate.Value = FileTimeline.MedicalSummariesPreDiscDueDate;
            if (FileTimeline.PreDiscoveryMeetingDate != default(DateTime))
                TBoxPreDiscoveryMeetingDate.Value = FileTimeline.PreDiscoveryMeetingDate;
            if (FileTimeline.DefendantAODRequest != default(DateTime))
                TBoxDefendantAODRequest.Value = FileTimeline.DefendantAODRequest;
            if (FileTimeline.DateOfPlaintiffDiscovery != default(DateTime))
                TBoxDateOfPlaintiffDiscovery.Value = FileTimeline.DateOfPlaintiffDiscovery;
            if (FileTimeline.DateOfDefendantDiscovery != default(DateTime))
                TBoxDateOfDefendantDiscovery.Value = FileTimeline.DateOfDefendantDiscovery;
            if (FileTimeline.DatePlaintiffUndertakingComplete != default(DateTime))
                TBoxDatePlaintiffUndertakingComplete.Value = FileTimeline.DatePlaintiffUndertakingComplete;
            if (FileTimeline.AllDefendantUndertakingRecd != default(DateTime))
                TBoxAllDefendantUndertakingRecd.Value = FileTimeline.AllDefendantUndertakingRecd;
            if (FileTimeline.PreMedSttleMeetingDate != default(DateTime))
            {
                TBoxTimelinePreMedSttleMeetingDate.Value = FileTimeline.PreMedSttleMeetingDate;
                TBoxPreMedSttleMeetingDateTextBox.Text = FileTimeline.PreMedSttleMeetingDate.ToString("dd-MM-yyyy");
            }
            if (FileTimeline.MemoToBeServedDate != default(DateTime))
                TBoxTimelineMemoToBeServedDate.Value = FileTimeline.MemoToBeServedDate;
            if (FileTimeline.MediationResolutionDate != default(DateTime))
            {
                TBoxTimelineMediationResolutionDate.Value = FileTimeline.MediationResolutionDate;
                TBoxResolutionDateSettTextBox.Text = FileTimeline.MediationResolutionDate.ToString("dd-MM-yyyy");
            }
            if (FileTimeline.DateToFileTrialRecordBy != default(DateTime))
                TBoxDateToFileTrialRecordBy.Value = FileTimeline.DateToFileTrialRecordBy;
            if (FileTimeline.DateTrialRecordFiled != default(DateTime))
                TBoxDateTrialRecordFiled.Value = FileTimeline.DateTrialRecordFiled;
            if (FileTimeline.PrePreTrialMeetingDate!= default(DateTime))
                TBoxTimelinePrePreTrialMeetingDate.Value = FileTimeline.PrePreTrialMeetingDate;
            if (FileTimeline.PreTrialToBeServedDate != default(DateTime))
                TBoxPreTrialToBeServedDate.Value = FileTimeline.PreTrialToBeServedDate;
            if (FileTimeline.PreTrialResolutionDate != default(DateTime))
                TBoxPreTrialResolutionDate.Value = FileTimeline.PreTrialResolutionDate;
            if (FileTimeline.TrialDate != default(DateTime))
                TBoxTrialDate.Value = FileTimeline.TrialDate;

        }

        private bool firstActionLogDataLoad = true;
        public void RefreshActionLogDataGridViewDataSource()
        {
            /*int taskCategoryID = -1;
            if (!(CBoxTaskCategory.SelectedValue is null))
            {
                if (!Int32.TryParse(CBoxTaskCategory.SelectedValue.ToString(), out taskCategoryID))
                {
                    taskCategoryID = -1;
                }
            }*/
            
            fileTasks = _fileTaskRepository.Search(File, _taskStateRepository.GetByDescription(Cbb_TaskLogStateFilter.Text),
                null, _lawyerRepository.GetByDescription(Cbb_TaskLogFilterLawyers.Text),
                _taskCategoryRepository.GetByDescription(Cbb_TaskLogBusinessProcessFilter.Text));
            var filetasks = fileTasks.Select( x => new
            {
                ID = x?.ID,
                FileID = x?.FileId,
                StatusId = x?.State?.ID,
                StatusDescription = x?.State?.Description,
                TaskID = x?.TaskId,
                TaskIDNumber = x?.Task?.TaskIDNumber ?? "N/A",
                TaskDescription = x?.Task?.Description,
                BusinessProcess = x?.Task?.TaskCategory?.Description ?? "N/A",
                ResponsibleLawyer = x.Task?.Lawyer?.Description,
                DueDate = x?.DueDate.ToString("dd-MM-yyyy"),
                DeferUntilDate = x?.DeferUntilDate.ToString("dd-MM-yyyy") ?? "",
                TaskStartedDate = x?.TaskStartedDate,
                WorkedOnDate1 = x?.WorkedOnDate1,
                WorkedOnDate2 = x?.WorkedOnDate2,
                WorkedOnDate3 = x?.WorkedOnDate3,
                NotifiedRRFDate = x?.NotifiedRRFDate,                
                CompletedDate = x?.CompletedDate,
                Notes = x?.Notes
            });

            //ActionLogDataGridView.DataSource = _fileTaskRepository.Search(File, _taskStateRepository.GetByDescription(ComboBox2.Text));
            ActionLogDataGridView.DataSource = filetasks.ToList();
            bool setup = false;
            if (ActionLogDataGridView.DataSource != null)
            {
                setup = true;                
            }

            if (setup && firstActionLogDataLoad)
            {
                ActionLogDataGridView.Columns["ID"].Visible = false;
                //ActionLogDataGridView.Columns["File"].Visible = false;
                ActionLogDataGridView.Columns["FileId"].Visible = false;
                ActionLogDataGridView.Columns["TaskId"].Visible = false;
                ActionLogDataGridView.Columns["StatusId"].Visible = false;
                ActionLogDataGridView.Columns["TaskIDNumber"].HeaderText = "Task ID";
                ActionLogDataGridView.Columns["BusinessProcess"].HeaderText = "Business Process";
                ActionLogDataGridView.Columns["TaskDescription"].HeaderText = "Description";
                ActionLogDataGridView.Columns["ResponsibleLawyer"].HeaderText = "Lawyer";
                ActionLogDataGridView.Columns["DueDate"].HeaderText = "Due Date";
                ActionLogDataGridView.Columns["DeferUntilDate"].HeaderText = "Defer Until Date";
                ActionLogDataGridView.Columns["TaskStartedDate"].HeaderText = "Started Date";
                ActionLogDataGridView.Columns["WorkedOnDate1"].HeaderText = "Worked On Date 1";
                ActionLogDataGridView.Columns["WorkedOnDate2"].HeaderText = "Worked On Date 2";
                ActionLogDataGridView.Columns["WorkedOnDate3"].HeaderText = "Worked On Date 3";
                ActionLogDataGridView.Columns["NotifiedRRFDate"].HeaderText = "Notified RRF Date";
                ActionLogDataGridView.Columns["StatusDescription"].HeaderText = "Status";
                ActionLogDataGridView.Columns["CompletedDate"].HeaderText = "Completed Date";

                //ActionLogDataGridView.RowTemplate.ContextMenuStrip = Ctms_TaskActions;
                ActionLogDataGridView.ContextMenuStrip = Ctms_TaskActions;
                firstActionLogDataLoad = false;
                //ActionLogDataGridView.Columns["BusinessProcess"].ContextMenuStrip = Ctms_TaskActions;

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
            if (AccidentBenefitsTab.TabPages.Contains(SemiAnnualFileReviewTabAccidentBenefits))
            {
                AccidentBenefitsTab.TabPages.Remove(SemiAnnualFileReviewTabAccidentBenefits);
            }

            if (file.MatterType != null && file.SubTypeCategory != null)
            {
                if (file.MatterType.Description == "Motor Vehicle Accident" && file.SubTypeCategory.Description.ToUpper().Contains("AB") && !file.SubTypeCategory.Description.ToUpper().Contains("TORT"))
                {
                    SemiAnnualFileReviewControlAccidentBenefits.File = file;
                    AccidentBenefitsTab.TabPages.Add(SemiAnnualFileReviewTabAccidentBenefits);
                }
                else if (file.MatterType.Description == "Motor Vehicle Accident" && !file.SubTypeCategory.Description.ToUpper().Contains("AB") && file.SubTypeCategory.Description.ToUpper().Contains("TORT"))
                {
                    SemiAnnualFileReviewControlAction.File = file;
                    TabControl2.TabPages.Insert(6, SemiAnnualFileReviewTabAction);
                }
                else
                {
                    SemiAnnualFileReviewControlAccidentBenefits.File = SemiAnnualFileReviewControlAction.File = file;
                    AccidentBenefitsTab.TabPages.Add(SemiAnnualFileReviewTabAccidentBenefits);
                    TabControl2.TabPages.Insert(6, SemiAnnualFileReviewTabAction);
                }

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

        private void LatFiledDtp_ValueChanged(object sender, EventArgs e)
        {
            DtpChange(sender);
        }

        /*private void DTPTimeline_ValueChanged(object sender, EventArgs e)
        {
            var dtp = sender as ColorDateTimePicker;
            if (dtp.Value != default(DateTime))
                ((this.Timeline.Controls["TimelineLayoutPanel"] as TableLayoutPanel).Controls[dtp.Name + "TextBox"] as TextBox).Text = dtp.Value.ToString("MMMM dd, yyyy");
            else
                ((this.Timeline.Controls["TimelineLayoutPanel"] as TableLayoutPanel).Controls[dtp.Name + "TextBox"] as TextBox).Text = "";
        }*/

        private void DTP_ValueChanged(object sender, EventArgs e)
        {
            var dtp = sender as DateTimePicker;
            DTPChanger(dtp, dtp.Parent.Controls[dtp.Name + "TextBox"] as TextBox);
        }

        private void DTPChanger(DateTimePicker dtp, TextBox textBox)
        {
            if (dtp.Value != default(DateTime))
                textBox.Text = dtp.Value.ToString("MMMM dd, yyyy");
            else
                textBox.Text = "";
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
            FillTimelineFields();
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

            if (!String.IsNullOrEmpty(TBoxProposedDateToServeSOCTextBox.Text))
                timeline.ProposedDateToServeSOC = TBoxProposedDateToServeSOC.Value;

            if (!String.IsNullOrEmpty(TBoxActualDateSOCServedTextBox.Text))
                timeline.ActualDateSOCServed = TBoxActualDateSOCServed.Value;
            
            if (!String.IsNullOrEmpty(TBoxPlaintiffAODSentTextBox.Text))
                timeline.PlaintiffAODSent = TBoxPlaintiffAODSent.Value;

            if (!String.IsNullOrEmpty(TBoxMedicalSummariesPreDiscDueDateTextBox.Text))
                timeline.MedicalSummariesPreDiscDueDate = TBoxMedicalSummariesPreDiscDueDate.Value;

            if (!String.IsNullOrEmpty(TBoxPreDiscoveryMeetingDateTextBox.Text))
                timeline.PreDiscoveryMeetingDate = TBoxPreDiscoveryMeetingDate.Value;

            if (!String.IsNullOrEmpty(TBoxDefendantAODRequestTextBox.Text))
                timeline.DefendantAODRequest = TBoxDefendantAODRequest.Value;

            if (!String.IsNullOrEmpty(TBoxDateOfPlaintiffDiscoveryTextBox.Text))
                timeline.DateOfPlaintiffDiscovery = TBoxDateOfPlaintiffDiscovery.Value;

            if (!String.IsNullOrEmpty(TBoxDateOfDefendantDiscoveryTextBox.Text))
                timeline.DateOfDefendantDiscovery = TBoxDateOfDefendantDiscovery.Value;

            if (!String.IsNullOrEmpty(TBoxDatePlaintiffUndertakingCompleteTextBox.Text))
                timeline.DatePlaintiffUndertakingComplete = TBoxDatePlaintiffUndertakingComplete.Value;

            if (!String.IsNullOrEmpty(TBoxAllDefendantUndertakingRecdTextBox.Text))
                timeline.AllDefendantUndertakingRecd = TBoxAllDefendantUndertakingRecd.Value;

            if (!String.IsNullOrEmpty(TBoxTimelinePreMedSttleMeetingDateTextBox.Text))
                timeline.PreMedSttleMeetingDate = TBoxTimelinePreMedSttleMeetingDate.Value;

            if (!String.IsNullOrEmpty(TBoxTimelineMemoToBeServedDateTextBox.Text))
                timeline.MemoToBeServedDate = TBoxTimelineMemoToBeServedDate.Value;

            if (!String.IsNullOrEmpty(TBoxTimelineMediationResolutionDateTextBox.Text))
                timeline.MediationResolutionDate = TBoxTimelineMediationResolutionDate.Value;

            if (!String.IsNullOrEmpty(TBoxDateToFileTrialRecordByTextBox.Text))
                timeline.DateToFileTrialRecordBy = TBoxDateToFileTrialRecordBy.Value;

            if (!String.IsNullOrEmpty(TBoxDateTrialRecordFiledTextBox.Text))
                timeline.DateTrialRecordFiled = TBoxDateTrialRecordFiled.Value;

            if (!String.IsNullOrEmpty(TBoxTimelinePrePreTrialMeetingDateTextBox.Text))
                timeline.PrePreTrialMeetingDate = TBoxTimelinePrePreTrialMeetingDate.Value;

            if (!String.IsNullOrEmpty(TBoxPreTrialToBeServedDateTextBox.Text))
                timeline.PreTrialToBeServedDate = TBoxPreTrialToBeServedDate.Value;

            if (!String.IsNullOrEmpty(TBoxPreTrialResolutionDateTextBox.Text))
                timeline.PreTrialResolutionDate = TBoxPreTrialResolutionDate.Value;

            if (!String.IsNullOrEmpty(TBoxTrialDateTextBox.Text))
                timeline.TrialDate = TBoxTrialDate.Value;
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
            if (!String.IsNullOrEmpty(TBoxTimelinePreMedSttleMeetingDateTextBox.Text) && (timeline.PreMedSttleMeetingDate != TBoxTimelinePreMedSttleMeetingDate.MinDate && timeline.PreMedSttleMeetingDate != default(DateTime) && timeline.PreMedSttleMeetingDate != null))
            {
                AddFileTasks("Pre-Med.Settle", taskState);
            }
            if (!String.IsNullOrEmpty(TBoxTimelineMediationResolutionDateTextBox.Text) && (timeline.MediationResolutionDate != TBoxTimelineMediationResolutionDate.MinDate && timeline.MediationResolutionDate != default(DateTime) && timeline.MediationResolutionDate != null))
            {
                AddFileTasks("Med.Settle", taskState);
            }
            if (!String.IsNullOrEmpty(TBoxTimelinePrePreTrialMeetingDateTextBox.Text) && (timeline.PrePreTrialMeetingDate != TBoxTimelinePrePreTrialMeetingDate.MinDate && timeline.PrePreTrialMeetingDate != default(DateTime) && timeline.PrePreTrialMeetingDate != null))
            {
                AddFileTasks("Pre-Pre-Trial", taskState);
            }
            if (!String.IsNullOrEmpty(TBoxPreTrialResolutionDateTextBox.Text) && (timeline.PreTrialResolutionDate != TBoxPreTrialResolutionDate.MinDate && timeline.PreTrialResolutionDate != default(DateTime) && timeline.PreTrialResolutionDate != null))
            {
                AddFileTasks("Pre-Trial", taskState);
            }
            if (!String.IsNullOrEmpty(TBoxTrialDateTextBox.Text) && (timeline.TrialDate != TBoxTrialDate.MinDate && timeline.TrialDate != default(DateTime) && timeline.TrialDate != null))
            {
                AddFileTasks("Trial", taskState);
            }
            RefreshActionLogDataGridViewDataSource();
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
                    _fileTaskRepository.AddAllCategoryTasks(File, tasks, taskState);
                }
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ABBinderTab_Click(object sender, EventArgs e)
        {

        }
               

        private void AddNotesRowButton_Click(object sender, EventArgs e)
        {
            if (File is null)
            {
                MessageBox.Show($"You have to select a file!","Wait",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
           

            if (ClientNotesDataGridView.Rows.Count > 0)
            {
                if (ClientNotesDataGridView.Rows[ClientNotesDataGridView.Rows.Count - 1].Cells[0].Value == null || 
                    ClientNotesDataGridView.Rows[ClientNotesDataGridView.Rows.Count - 1].Cells[0].Value.ToString() == "")
                {
                    MessageBox.Show("You must save the last added note to create a new record.","Wait",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                    return;
                }
            }

            ClientNotesDataGridView.Rows.Add(null,null,null,null);
            ClientNotesDataGridView.CurrentCell = ClientNotesDataGridView.Rows[ClientNotesDataGridView.Rows.Count - 1].Cells[DgColumn_Description.Index];
            ClientNotesDataGridView.Rows[ClientNotesDataGridView.CurrentCell.RowIndex].Cells[ClientNotesDataGridView.CurrentCell.ColumnIndex].ReadOnly = false;
            //ClientNotesDataGridView.CurrentCell.ReadOnly = false;
            ClientNotesDataGridView.BeginEdit(false);
        }

        private void SaveNoteButton_Click(object sender, EventArgs e)
        {
            if (File is null)
            {
                MessageBox.Show($"You have to select a file!","Wait",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (ClientNotesDataGridView.Rows[ClientNotesDataGridView.Rows.Count - 1]?.Cells[DgColumn_DateTime.Index].Value == null && 
                ClientNotesDataGridView.Rows[ClientNotesDataGridView.Rows.Count - 1]?.Cells[DgColumn_Description.Index].Value != null &&
                !string.IsNullOrEmpty(ClientNotesDataGridView.Rows[ClientNotesDataGridView.Rows.Count - 1]?.Cells[DgColumn_Description.Index].Value.ToString()))
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
            if (File is null)
            {
                MessageBox.Show($"You hace to select a file!", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                    "Intake Dam Notes",
                   File.DateOfCall,
                   intake.File.FileLawyer.Description,
                   intake.DamNotes
                   );
            }

            if (!string.IsNullOrEmpty(intake.EILNotes))
            {
                Notes.Rows.Add(
                    "Intake EIL Notes",
                   File.DateOfCall,
                   intake.File.FileLawyer.Description,
                   intake.EILNotes
                   );
            }

            if (!string.IsNullOrEmpty(intake.LiaNotes))
            {
                Notes.Rows.Add(
                    "Intake LIA Notes",
                   File.DateOfCall,
                   intake.File.FileLawyer.Description,
                   intake.LiaNotes
                   );
            }

            if (!string.IsNullOrEmpty(intake.AccBenNotes))
            {
                Notes.Rows.Add(
                    "Intake AccBen Notes",
                   File.DateOfCall,
                   intake.File.FileLawyer.Description,
                   intake.AccBenNotes
                   );
            }

            if (!string.IsNullOrEmpty(intake.PolOtherNotes))
            {
                Notes.Rows.Add(
                    "Intake Pol Other Notes",
                   File.DateOfCall,
                   intake.File.FileLawyer.Description,
                   intake.PolOtherNotes
                   );
            }

            if (!string.IsNullOrEmpty(intake.Notes))
            {
                Notes.Rows.Add(
                    "Intake Notes",
                   File.DateOfCall,
                   intake.File.FileLawyer.Description,
                   intake.Notes
                   );
            }

            foreach (var item in clientNotes)
            {
                Notes.Rows.Add(
                    "Client Notes",
                    item.Date,
                    item.Lawyer,
                    item.Description
                    ) ;
            }

            foreach (DataRow item in Notes.Rows)
            {
                ClientNotesDataGridView.Rows.Add(
                    item["Origin"].ToString(),
                    Convert.ToDateTime(item["Date"]),
                    item["Lawyer"].ToString(),
                    item["Description"].ToString()
                    );
            }

            Cbb_Staff.Items.Clear();
            Cbb_Staff.Items.Add("All");
            var lawyers = Notes.AsEnumerable().Select(x => x.Field<string>("Lawyer")).Distinct();
            foreach (var item in lawyers)
            {
                Cbb_Staff.Items.Add(item);
            }
            ExportToExcelButton.Enabled = true;
        }

        private void Cbb_Staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbb_Staff.Text.Trim() == "All")
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
                        item["Origin"].ToString(),
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
            if (isSettingForm) return;
            var newStatus = (FileStatus)CurrentFileStatusComboBox.SelectedValue;
            if (newStatus != null && File.CurrentStatus != newStatus)
            {
                File.CurrentStatus = newStatus;
                _fileManager.Update(File);
            }
        }

        private void TabControl5_Click(object sender, EventArgs e)
        {
            if (AccidentBenefitsTab.SelectedTab == ABLAT)
            {
                Busqueda();
            }
            else if (AccidentBenefitsTab.SelectedTab == Denials)
            {
                BusquedaDenials();
            }
        }

        private void BusquedaDenials()
        {
            if (File != null)
            {
                //ABDenialsDataGridView.DataSource = null;
                ABDenialsDataGridView.DataSource = _DenialRepository.Search(Home.FileManager.File);
                ABDenialsDataGridView.Columns["ID"].Visible = false;
                ABDenialsDataGridView.Columns["File"].Visible = false;
                ABDenialsDataGridView.Columns["FileId"].Visible = false;
            }
            else
            {
                AccidentBenefitsTab.SelectedTab = ABBinderTab;
                TabControl1.SelectedIndex = 0;
                MessageBox.Show($"You have to search a file", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
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
                        //if (DtpEmpty())
                        //{
                        //    MessageBox.Show("Complete the data of lat 1");
                        //}
                        //else
                        //{
                        //    SaveLat(1);
                        //}
                        SaveLat(1);
                        break;

                    case "BtnLat2":
                        //if (DtpEmpty())
                        //{
                        //    MessageBox.Show("Complete the data of lat 2");
                        //}
                        //else
                        //{
                        //    SaveLat(2);
                        //}
                        SaveLat(2);
                        break;
                    case "BtnLat3":
                        //if (DtpEmpty())
                        //{
                        //    MessageBox.Show("Complete the data of lat 3");
                        //}
                        //else
                        //{
                        //    SaveLat(3);
                        //}
                        SaveLat(3);
                        break;

                    case "BtnLat4":
                        //if (DtpEmpty())
                        //{
                        //    MessageBox.Show("Complete the data of lat 4");
                        //}
                        //else
                        //{
                        //    SaveLat(4);
                        //}
                        SaveLat(4);
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
                        //if (DtpEmpty())
                        //{
                        //    MessageBox.Show("Complete the data of lat 1");

                        //}
                        //else
                        //{
                        //    UpdateLat(1);
                        //}

                        UpdateLat(1);
                        break;

                    case "BtnLat2":
                        //if (DtpEmpty())
                        //{
                        //    MessageBox.Show("Complete the data of lat 2");
                        //}
                        //else
                        //{
                        //    UpdateLat(2);
                        //}
                        UpdateLat(2);
                        break;
                    case "BtnLat3":
                        //if (DtpEmpty())
                        //{
                        //    MessageBox.Show("Complete the data of lat 3");
                        //}
                        //else
                        //{
                        //    UpdateLat(3);
                        //}
                        UpdateLat(3);
                        break;

                    case "BtnLat4":
                        //if (DtpEmpty())
                        //{
                        //    MessageBox.Show("Complete the data of lat 4");
                        //}
                        //else
                        //{
                        //    UpdateLat(4);
                        //}
                        UpdateLat(4);
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
                    _LatData.LATActualDateFiled = string.IsNullOrEmpty(ActualDateLatFiledTxt.Text) ? default(DateTime) : ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberTxt.Text;
                    _LatData.LATCaseConfDate = string.IsNullOrEmpty(LatCaseConfDateTxt.Text) ? default(DateTime) : LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorTxt.Text;
                    _LatData.LATAdjuster = AdjusterTxt.Text;
                    _LatData.LATInsurer = InsurerTxt.Text;
                    _LatData.LATInsurerCounsel = InsurerCounselTxt.Text;
                    _LatData.LATInsurerFirm = InsurerFirmTxt.Text;
                    _LatData.LATHearingType = HearingTypeTxt.Text;
                    _LatData.LATHearingDate = string.IsNullOrEmpty(HearingStarDateTxt.Text)?default(DateTime):HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorTxt.Text;
                    _LatData.LATDateSettled = string.IsNullOrEmpty(DateLatSettledClosedtTxt.Text) ? default(DateTime) : DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = string.IsNullOrEmpty(AmountSettledTxt.Text) ? 0.00 : Convert.ToDouble(AmountSettledTxt.Text);
                    _LatData.LATIssue1 = TxtIssues1.Text;
                    _LatData.LATIssue2 = TxtIssues2.Text;
                    _LatData.LATIssue3 = TxtIssues3.Text;
                    _LatData.LATIssue4 = TxtIssues4.Text;
                    _LatData.LATIssue5 = TxtIssues5.Text;
                    _LatData.LATIssue6 = TxtIssues6.Text;
                    _LatData.LATIssue7 = TxtIssues7.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = string.IsNullOrEmpty(DueDateToDiscussPotenctialLatApplTxt.Text) ? default(DateTime) : DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = string.IsNullOrEmpty(DateMetWithLawyerReDenialTxt.Text) ? default(DateTime) : DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = string.IsNullOrEmpty(ProposedDateToFileLatTxt.Text) ? default(DateTime):ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = string.IsNullOrEmpty(ActualDateLatServedOnInsurerTxt.Text)?default(DateTime):ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = string.IsNullOrEmpty(InsuresResponseReceivedTxt.Text)?default(DateTime):InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = string.IsNullOrEmpty(DeadLineToServeFileCaseConfSummaryTxt.Text)? default (DateTime): DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = string.IsNullOrEmpty(DeadLineToDeliverProductionsToABCounselTxt.Text)? default(DateTime):DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions =string.IsNullOrEmpty(DeadLineToReceiveABProductionsTxt.Text)? default(DateTime): DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc = string.IsNullOrEmpty(DeadLineToFileAffidavitReportsTxt.Text)?default(DateTime):DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = string.IsNullOrEmpty(DeadLineToReceiveAffidavitReportsTxt.Text)?default(DateTime):DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = string.IsNullOrEmpty(DeadLineToFileHearingSubmissionsTxt.Text)?default(DateTime):DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = string.IsNullOrEmpty(DeadlineToReceiveInsurerTxt.Text)? default(DateTime):DeadlineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = string.IsNullOrEmpty(DeadLineForReplaySubmissionsTxt.Text)? default(DateTime): DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Insert(_LatData, 1, Home.FileManager.File);
                }
                else if (latNumber == 2)
                {
                    _LatData.FileId = Home.FileManager.File.ID;
                    _LatData.LATNumber = 2;
                    _LatData.LATActualDateFiled =string.IsNullOrEmpty(Lat2ActualDateLatFiledTxt.Text)? default(DateTime):Lat2ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberLat2.Text;
                    _LatData.LATCaseConfDate = string.IsNullOrEmpty(Lat2LatCaseConfDateTxt.Text)? default(DateTime):Lat2LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorLat2.Text;
                    _LatData.LATAdjuster = AdjusterLat2.Text;
                    _LatData.LATInsurer = InsurerLat2.Text;
                    _LatData.LATInsurerCounsel = InsurerCounselLat2.Text;
                    _LatData.LATInsurerFirm = InsureFirmLat2.Text;
                    _LatData.LATHearingType = HearingTypeLat2.Text;
                    _LatData.LATHearingDate = string.IsNullOrEmpty(Lat2HearingStarDateTxt.Text)? default(DateTime):Lat2HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorLat2.Text;
                    _LatData.LATDateSettled = string.IsNullOrEmpty(Lat2DateLatSettledClosedTxt.Text)? default(DateTime):Lat2DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = string.IsNullOrEmpty(AmountSettledLat2.Text) ? 0.00 : Convert.ToDouble(AmountSettledLat2.Text);
                    _LatData.LATIssue1 = IssuesLat2.Text;
                    _LatData.LATIssue2 = Issues2Lat2.Text;
                    _LatData.LATIssue3 = Issues3Lat2.Text;
                    _LatData.LATIssue4 = Issues4Lat2.Text;
                    _LatData.LATIssue5 = Issues5Lat2.Text;
                    _LatData.LATIssue6 = Issues6Lat2.Text;
                    _LatData.LATIssue7 = Issues7Lat2.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = string.IsNullOrEmpty(Lat2DueDateToDiscussPotenctialLatApplTxt.Text)? default(DateTime):Lat2DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = string.IsNullOrEmpty(Lat2DateMetWithLawyerReDenialTxt.Text)? default(DateTime):Lat2DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = string.IsNullOrEmpty(Lat2ProposedDateToFileLatTxt.Text)? default(DateTime): Lat2ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = string.IsNullOrEmpty(Lat2ActualDateLatServedOnInsurerTxt.Text)? default(DateTime):Lat2ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = string.IsNullOrEmpty(Lat2InsuresResponseReceivedTxt.Text)? default(DateTime):Lat2InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = string.IsNullOrEmpty(Lat2DeadLineToServeFileCaseConfSummaryTxt.Text)? default(DateTime): Lat2DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = string.IsNullOrEmpty(Lat2DeadLineToDeliverProductionsToABCounselTxt.Text)? default(DateTime): Lat2DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions = string.IsNullOrEmpty(Lat2DeadLineToReceiveABProductionsTxt.Text)? default(DateTime): Lat2DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc =string.IsNullOrEmpty(Lat2DeadLineToReceiveAffidavitReportsTxt.Text)? default(DateTime): Lat2DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = string.IsNullOrEmpty(Lat2DeadLineToReceiveAffidavitReportsTxt.Text)?default(DateTime): Lat2DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = string.IsNullOrEmpty(Lat2DeadLineToFileHearingSubmissionsTxt.Text)?default(DateTime):Lat2DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = string.IsNullOrEmpty(Lat2DeadLineToReceiveInsurerTxt.Text)? default(DateTime):Lat2DeadLineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = string.IsNullOrEmpty(Lat2DeadLineForReplaySubmissionsTxt.Text)?default:Lat2DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Insert(_LatData, 2, Home.FileManager.File);
                }
                else if (latNumber == 3)
                {
                    _LatData.FileId = Home.FileManager.File.ID;
                    _LatData.LATNumber = 3;
                    _LatData.LATActualDateFiled = string.IsNullOrEmpty(Lat3ActualDateLatFiledTxt.Text)? default(DateTime):Lat3ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberLat3.Text;
                    _LatData.LATCaseConfDate =string.IsNullOrEmpty(Lat3LatCaseConfDateTxt.Text)?default(DateTime):Lat3LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorLat3.Text;
                    _LatData.LATAdjuster = AdjusterLat3.Text;
                    _LatData.LATInsurer = InsurerLat3.Text;
                    _LatData.LATInsurerCounsel = InsureCounselLat3.Text;
                    _LatData.LATInsurerFirm = InsurerFirmLat3.Text;
                    _LatData.LATHearingType = HearingTypeLat3.Text;
                    _LatData.LATHearingDate = string.IsNullOrEmpty(Lat3HearingStarDateTxt.Text)?default(DateTime):Lat3HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorLat3.Text;
                    _LatData.LATDateSettled = string.IsNullOrEmpty(Lat3DateLatSettledClosedTxt.Text)?default(DateTime):Lat3DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = string.IsNullOrEmpty(AmountSettledLat3.Text) ? 0.00 : Convert.ToDouble(AmountSettledLat3.Text);
                    _LatData.LATIssue1 = IssuesLat3.Text;
                    _LatData.LATIssue2 = Issues2Lat3.Text;
                    _LatData.LATIssue3 = Issues3Lat3.Text;
                    _LatData.LATIssue4 = Issues4Lat3.Text;
                    _LatData.LATIssue5 = Issues5Lat3.Text;
                    _LatData.LATIssue6 = Issues6Lat3.Text;
                    _LatData.LATIssue7 = Issues7Lat3.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = string.IsNullOrEmpty(Lat3DueDateToDiscussPotenctialLatApplTxt.Text)?default(DateTime): Lat3DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = string.IsNullOrEmpty(Lat3DateMetWithLawyerReDenialTxt.Text)?default(DateTime):Lat3DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = string.IsNullOrEmpty(Lat3ProposedDateToFileLatTxt.Text)? default(DateTime):Lat3ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = string.IsNullOrEmpty(Lat3ActualDateLatServedOnInsurerTxt.Text)?default(DateTime):Lat3ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = string.IsNullOrEmpty(Lat3InsuresResponseReceivedTxt.Text)?default(DateTime):Lat3InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = string.IsNullOrEmpty(Lat3DeadLineToServeFileCaseConfSummaryTxt.Text) ? default(DateTime): Lat3DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = string.IsNullOrEmpty(Lat3DeadLineToDeliverProductionsToABCounselTxt.Text)? default(DateTime):Lat3DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions = string.IsNullOrEmpty(Lat3DeadLineToReceiveABProductionsTxt.Text)? default(DateTime): Lat3DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc = string.IsNullOrEmpty(Lat3DeadLineToFileAffidavitReportsTxt.Text)?default(DateTime): Lat3DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = string.IsNullOrEmpty(Lat3DeadLineToReceiveAffidavitReportsTxt.Text)? default(DateTime): Lat3DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = string.IsNullOrEmpty(Lat3DeadLineToFileHearingSubmissionsTxt.Text)? default(DateTime): Lat3DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = string.IsNullOrEmpty(Lat3DeadLineToReceiveInsurerTxt.Text)? default(DateTime): Lat3DeadLineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = string.IsNullOrEmpty(Lat3DeadLineForReplaySubmissionsTxt.Text) ? default(DateTime): Lat3DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Insert(_LatData, 3, Home.FileManager.File);
                }
                else if (latNumber == 4)
                {
                    _LatData.FileId = Home.FileManager.File.ID;
                    _LatData.LATNumber = 4;
                    _LatData.LATActualDateFiled = string.IsNullOrEmpty(Lat4ActualDateLatFiledTxt.Text)? default(DateTime):Lat4ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberLat4.Text;
                    _LatData.LATCaseConfDate = string.IsNullOrEmpty(Lat4LatCaseConfDateTxt.Text)? default(DateTime):Lat4LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorLat4.Text;
                    _LatData.LATAdjuster = AdjusterLat4.Text;
                    _LatData.LATInsurer = InsurerLat4.Text;
                    _LatData.LATInsurerCounsel = InsurerCounselLat4.Text;
                    _LatData.LATInsurerFirm = InsurerFirmLat4.Text;
                    _LatData.LATHearingType = HearingTypeLat4.Text;
                    _LatData.LATHearingDate = string.IsNullOrEmpty(Lat4HearingStarDateTxt.Text)? default(DateTime):Lat4HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorLat4.Text;
                    _LatData.LATDateSettled =string.IsNullOrEmpty(Lat4DateLatSettledClosedTxt.Text)? default(DateTime): Lat4DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = string.IsNullOrEmpty(AmountSettledLat4.Text) ? 0.00 : Convert.ToDouble(AmountSettledLat4.Text);
                    _LatData.LATIssue1 = IssuesLat4.Text;
                    _LatData.LATIssue2 = Issues2Lat4.Text;
                    _LatData.LATIssue3 = Issues3Lat4.Text;
                    _LatData.LATIssue4 = Issues4Lat4.Text;
                    _LatData.LATIssue5 = Issues5Lat4.Text;
                    _LatData.LATIssue6 = Issues6Lat4.Text;
                    _LatData.LATIssue7 = Issues7Lat4.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = string.IsNullOrEmpty(Lat4DueDateToDiscussPotenctialLatApplTxt.Text)? default(DateTime):Lat4DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = string.IsNullOrEmpty(Lat4DateMetWithLawyerReDenialTxt.Text)? default(DateTime):Lat4DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = string.IsNullOrEmpty(Lat4ProposedDateToFileLatTxt.Text)? default(DateTime):Lat4ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = string.IsNullOrEmpty(Lat4ActualDateLatServedOnInsurerTxt.Text)? default(DateTime):Lat4ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = string.IsNullOrEmpty(Lat4InsuresResponseReceivedTxt.Text)? default(DateTime): Lat4InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = string.IsNullOrEmpty(Lat4DeadLineToServeFileCaseConfSummaryTxt.Text)? default(DateTime): Lat4DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = string.IsNullOrEmpty(Lat4DeadLineToDeliverProductionsToABCounselTxt.Text)? default(DateTime): Lat4DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions = string.IsNullOrEmpty(Lat4DeadLineToReceiveABProductionsTxt.Text)? default(DateTime):Lat4DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc = string.IsNullOrEmpty(Lat4DeadLineToFileAffidavitReportsTxt.Text)? default(DateTime): Lat4DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = string.IsNullOrEmpty(Lat4DeadLineToReceiveAffidavitReportsTxt.Text)? default(DateTime): Lat4DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = string.IsNullOrEmpty(Lat4DeadLineToFileHearingSubmissionsTxt.Text)? default(DateTime): Lat4DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = string.IsNullOrEmpty(Lat4DeadLineToReceiveInsurerTxt.Text)? default(DateTime): Lat4DeadLineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = string.IsNullOrEmpty(Lat4DeadLineForReplaySubmissionsTxt.Text)? default(DateTime): Lat4DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Insert(_LatData, 4, Home.FileManager.File);
                }

                MessageBox.Show("Data saved successfully!");
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
                    _LatData.ID = Home.FileManager.File.LATData.ToList().Find(T => T.LATNumber == 1).ID;
                    _LatData.FileId = Home.FileManager.File.ID;
                    _LatData.LATNumber = 1;
                    _LatData.LATActualDateFiled = string.IsNullOrEmpty(ActualDateLatFiledTxt.Text) ? default(DateTime) : ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberTxt.Text;
                    _LatData.LATCaseConfDate = string.IsNullOrEmpty(LatCaseConfDateTxt.Text) ? default(DateTime) : LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorTxt.Text;
                    _LatData.LATAdjuster = AdjusterTxt.Text;
                    _LatData.LATInsurer = InsurerTxt.Text;
                    _LatData.LATInsurerCounsel = InsurerCounselTxt.Text;
                    _LatData.LATInsurerFirm = InsurerFirmTxt.Text;
                    _LatData.LATHearingType = HearingTypeTxt.Text;
                    _LatData.LATHearingDate = string.IsNullOrEmpty(HearingStarDateTxt.Text)? default(DateTime): HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorTxt.Text;
                    _LatData.LATDateSettled = string.IsNullOrEmpty(DateLatSettledClosedtTxt.Text) ? default(DateTime) : DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = string.IsNullOrEmpty(AmountSettledTxt.Text) ? 0.00 : Convert.ToDouble(AmountSettledTxt.Text);
                    _LatData.LATIssue1 = TxtIssues1.Text;
                    _LatData.LATIssue2 = TxtIssues2.Text;
                    _LatData.LATIssue3 = TxtIssues3.Text;
                    _LatData.LATIssue4 = TxtIssues4.Text;
                    _LatData.LATIssue5 = TxtIssues5.Text;
                    _LatData.LATIssue6 = TxtIssues6.Text;
                    _LatData.LATIssue7 = TxtIssues7.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = string.IsNullOrEmpty(DueDateToDiscussPotenctialLatApplTxt.Text) ? default(DateTime) : DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = string.IsNullOrEmpty(DateMetWithLawyerReDenialTxt.Text) ? default(DateTime) : DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = string.IsNullOrEmpty(ProposedDateToFileLatTxt.Text) ? default(DateTime) : ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = string.IsNullOrEmpty(ActualDateLatServedOnInsurerTxt.Text) ? default(DateTime) : ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = string.IsNullOrEmpty(InsuresResponseReceivedTxt.Text) ? default(DateTime) : InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = string.IsNullOrEmpty(DeadLineToServeFileCaseConfSummaryTxt.Text) ? default(DateTime) : DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = string.IsNullOrEmpty(DeadLineToDeliverProductionsToABCounselTxt.Text) ? default(DateTime) : DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions = string.IsNullOrEmpty(DeadLineToReceiveABProductionsTxt.Text) ? default(DateTime) : DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc = string.IsNullOrEmpty(DeadLineToFileAffidavitReportsTxt.Text) ? default(DateTime) : DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = string.IsNullOrEmpty(DeadLineToReceiveAffidavitReportsTxt.Text) ? default(DateTime) : DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = string.IsNullOrEmpty(DeadLineToFileHearingSubmissionsTxt.Text) ? default(DateTime) : DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = string.IsNullOrEmpty(DeadlineToReceiveInsurerTxt.Text) ? default(DateTime) : DeadlineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = string.IsNullOrEmpty(DeadLineForReplaySubmissionsTxt.Text) ? default(DateTime) : DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Update(_LatData);
                }
                else if (latNumber == 2)
                {
                    _LatData.ID = Home.FileManager.File.LATData.ToList().Single(T => T.LATNumber == 2).ID;
                    _LatData.FileId = Home.FileManager.File.ID;
                    _LatData.LATNumber = 2;
                    _LatData.LATActualDateFiled = string.IsNullOrEmpty(Lat2ActualDateLatFiledTxt.Text) ? default(DateTime) : Lat2ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberLat2.Text;
                    _LatData.LATCaseConfDate = string.IsNullOrEmpty(Lat2LatCaseConfDateTxt.Text) ? default(DateTime) : Lat2LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorLat2.Text;
                    _LatData.LATAdjuster = AdjusterLat2.Text;
                    _LatData.LATInsurer = InsurerLat2.Text;
                    _LatData.LATInsurerCounsel = InsurerCounselLat2.Text;
                    _LatData.LATInsurerFirm = InsureFirmLat2.Text;
                    _LatData.LATHearingType = HearingTypeLat2.Text;
                    _LatData.LATHearingDate = string.IsNullOrEmpty(Lat2HearingStarDateTxt.Text) ? default(DateTime) : Lat2HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorLat2.Text;
                    _LatData.LATDateSettled = string.IsNullOrEmpty(Lat2DateLatSettledClosedTxt.Text) ? default(DateTime) : Lat2DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = string.IsNullOrEmpty(AmountSettledLat2.Text) ? 0.00 : Convert.ToDouble(AmountSettledLat2.Text);
                    _LatData.LATIssue1 = IssuesLat2.Text;
                    _LatData.LATIssue2 = Issues2Lat2.Text;
                    _LatData.LATIssue3 = Issues3Lat2.Text;
                    _LatData.LATIssue4 = Issues4Lat2.Text;
                    _LatData.LATIssue5 = Issues5Lat2.Text;
                    _LatData.LATIssue6 = Issues6Lat2.Text;
                    _LatData.LATIssue7 = Issues7Lat2.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = string.IsNullOrEmpty(Lat2DueDateToDiscussPotenctialLatApplTxt.Text) ? default(DateTime) : Lat2DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = string.IsNullOrEmpty(Lat2DateMetWithLawyerReDenialTxt.Text) ? default(DateTime) : Lat2DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = string.IsNullOrEmpty(Lat2ProposedDateToFileLatTxt.Text) ? default(DateTime) : Lat2ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = string.IsNullOrEmpty(Lat2ActualDateLatServedOnInsurerTxt.Text) ? default(DateTime) : Lat2ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = string.IsNullOrEmpty(Lat2InsuresResponseReceivedTxt.Text) ? default(DateTime) : Lat2InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = string.IsNullOrEmpty(Lat2DeadLineToServeFileCaseConfSummaryTxt.Text) ? default(DateTime) : Lat2DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = string.IsNullOrEmpty(Lat2DeadLineToDeliverProductionsToABCounselTxt.Text) ? default(DateTime) : Lat2DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions = string.IsNullOrEmpty(Lat2DeadLineToReceiveABProductionsTxt.Text) ? default(DateTime) : Lat2DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc = string.IsNullOrEmpty(Lat2DeadLineToReceiveAffidavitReportsTxt.Text) ? default(DateTime) : Lat2DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = string.IsNullOrEmpty(Lat2DeadLineToReceiveAffidavitReportsTxt.Text) ? default(DateTime) : Lat2DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = string.IsNullOrEmpty(Lat2DeadLineToFileHearingSubmissionsTxt.Text) ? default(DateTime) : Lat2DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = string.IsNullOrEmpty(Lat2DeadLineToReceiveInsurerTxt.Text) ? default(DateTime) : Lat2DeadLineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = string.IsNullOrEmpty(Lat2DeadLineForReplaySubmissionsTxt.Text) ? default : Lat2DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Update(_LatData);
                }
                else if (latNumber == 3)
                {
                    _LatData.ID = Home.FileManager.File.LATData.ToList().Single(T => T.LATNumber == 3).ID;
                    _LatData.FileId = Home.FileManager.File.ID;
                    _LatData.LATNumber = 3;
                    _LatData.LATActualDateFiled = string.IsNullOrEmpty(Lat3ActualDateLatFiledTxt.Text) ? default(DateTime) : Lat3ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberLat3.Text;
                    _LatData.LATCaseConfDate = string.IsNullOrEmpty(Lat3LatCaseConfDateTxt.Text) ? default(DateTime) : Lat3LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorLat3.Text;
                    _LatData.LATAdjuster = AdjusterLat3.Text;
                    _LatData.LATInsurer = InsurerLat3.Text;
                    _LatData.LATInsurerCounsel = InsureCounselLat3.Text;
                    _LatData.LATInsurerFirm = InsurerFirmLat3.Text;
                    _LatData.LATHearingType = HearingTypeLat3.Text;
                    _LatData.LATHearingDate = string.IsNullOrEmpty(Lat3HearingStarDateTxt.Text) ? default(DateTime) : Lat3HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorLat3.Text;
                    _LatData.LATDateSettled = string.IsNullOrEmpty(Lat3DateLatSettledClosedTxt.Text) ? default(DateTime) : Lat3DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = string.IsNullOrEmpty(AmountSettledLat3.Text) ? 0.00 : Convert.ToDouble(AmountSettledLat3.Text);
                    _LatData.LATIssue1 = IssuesLat3.Text;
                    _LatData.LATIssue2 = Issues2Lat3.Text;
                    _LatData.LATIssue3 = Issues3Lat3.Text;
                    _LatData.LATIssue4 = Issues4Lat3.Text;
                    _LatData.LATIssue5 = Issues5Lat3.Text;
                    _LatData.LATIssue6 = Issues6Lat3.Text;
                    _LatData.LATIssue7 = Issues7Lat3.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = string.IsNullOrEmpty(Lat3DueDateToDiscussPotenctialLatApplTxt.Text) ? default(DateTime) : Lat3DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = string.IsNullOrEmpty(Lat3DateMetWithLawyerReDenialTxt.Text) ? default(DateTime) : Lat3DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = string.IsNullOrEmpty(Lat3ProposedDateToFileLatTxt.Text) ? default(DateTime) : Lat3ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = string.IsNullOrEmpty(Lat3ActualDateLatServedOnInsurerTxt.Text) ? default(DateTime) : Lat3ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = string.IsNullOrEmpty(Lat3InsuresResponseReceivedTxt.Text) ? default(DateTime) : Lat3InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = string.IsNullOrEmpty(Lat3DeadLineToServeFileCaseConfSummaryTxt.Text) ? default(DateTime) : Lat3DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = string.IsNullOrEmpty(Lat3DeadLineToDeliverProductionsToABCounselTxt.Text) ? default(DateTime) : Lat3DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions = string.IsNullOrEmpty(Lat3DeadLineToReceiveABProductionsTxt.Text) ? default(DateTime) : Lat3DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc = string.IsNullOrEmpty(Lat3DeadLineToFileAffidavitReportsTxt.Text) ? default(DateTime) : Lat3DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = string.IsNullOrEmpty(Lat3DeadLineToFileAffidavitReportsTxt.Text) ? default(DateTime) : Lat3DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = string.IsNullOrEmpty(Lat3DeadLineToFileHearingSubmissionsTxt.Text) ? default(DateTime) : Lat3DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = string.IsNullOrEmpty(Lat3DeadLineToReceiveInsurerTxt.Text) ? default(DateTime) : Lat3DeadLineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = string.IsNullOrEmpty(Lat3DeadLineForReplaySubmissionsTxt.Text) ? default(DateTime) : Lat3DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Update(_LatData);
                }
                else if (latNumber == 4)
                {
                    _LatData.ID = Home.FileManager.File.LATData.ToList().Single(T => T.LATNumber == 4).ID;
                    _LatData.FileId = Home.FileManager.File.ID;
                    _LatData.LATNumber = 4;
                    _LatData.LATActualDateFiled = string.IsNullOrEmpty(Lat4ActualDateLatFiledTxt.Text) ? default(DateTime) : Lat4ActualDateLatFiledDtp.Value;
                    _LatData.LATTribunalNumber = TribunalNumberLat4.Text;
                    _LatData.LATCaseConfDate = string.IsNullOrEmpty(Lat4LatCaseConfDateTxt.Text) ? default(DateTime) : Lat4LatCaseConfDateDtp.Value;
                    _LatData.LATCaseAdjudicator = CaseAdjudicatorLat4.Text;
                    _LatData.LATAdjuster = AdjusterLat4.Text;
                    _LatData.LATInsurer = InsurerLat4.Text;
                    _LatData.LATInsurerCounsel = InsurerCounselLat4.Text;
                    _LatData.LATInsurerFirm = InsurerFirmLat4.Text;
                    _LatData.LATHearingType = HearingTypeLat4.Text;
                    _LatData.LATHearingDate = string.IsNullOrEmpty(Lat4HearingStarDateTxt.Text) ? default(DateTime) : Lat4HearingStarDateDtp.Value;
                    _LatData.LATHearingAdjudicator = HearingAdjudicatorLat4.Text;
                    _LatData.LATDateSettled = string.IsNullOrEmpty(Lat4DateLatSettledClosedTxt.Text) ? default(DateTime) : Lat4DateLatSettledClosedDtp.Value;
                    _LatData.LATAmountSettled = string.IsNullOrEmpty(AmountSettledLat4.Text) ? 0.00 : Convert.ToDouble(AmountSettledLat4.Text);
                    _LatData.LATIssue1 = IssuesLat4.Text;
                    _LatData.LATIssue2 = Issues2Lat4.Text;
                    _LatData.LATIssue3 = Issues3Lat4.Text;
                    _LatData.LATIssue4 = Issues4Lat4.Text;
                    _LatData.LATIssue5 = Issues5Lat4.Text;
                    _LatData.LATIssue6 = Issues6Lat4.Text;
                    _LatData.LATIssue7 = Issues7Lat4.Text;
                    _LatData.LATDueDateToDiscussPotentialLAT = string.IsNullOrEmpty(Lat4DueDateToDiscussPotenctialLatApplTxt.Text) ? default(DateTime) : Lat4DueDateToDiscussPotenctialLatApplDtp.Value;
                    _LatData.LATDateMetWithLawyerReDenial = string.IsNullOrEmpty(Lat4DateMetWithLawyerReDenialTxt.Text) ? default(DateTime) : Lat4DateMetWithLawyerReDenialDtp.Value;
                    _LatData.LATProposedDateToFileLAT = string.IsNullOrEmpty(Lat4ProposedDateToFileLatTxt.Text) ? default(DateTime) : Lat4ProposedDateToFileLatDtp.Value;
                    _LatData.LATActualDateLATServedOnInsurer = string.IsNullOrEmpty(Lat4ActualDateLatServedOnInsurerTxt.Text) ? default(DateTime) : Lat4ActualDateLatServedOnInsurerDtp.Value;
                    _LatData.LATInsurersResponseReceived = string.IsNullOrEmpty(Lat4InsuresResponseReceivedTxt.Text) ? default(DateTime) : Lat4InsuresResponseReceivedDtp.Value;
                    _LatData.LATDeadlineToServeFileCaseConfSummary = string.IsNullOrEmpty(Lat4DeadLineToServeFileCaseConfSummaryTxt.Text) ? default(DateTime) : Lat4DeadLineToServeFileCaseConfSummaryDtp.Value;
                    _LatData.LATDeadlineToDeliverProductionstoABCounsel = string.IsNullOrEmpty(Lat4DeadLineToDeliverProductionsToABCounselTxt.Text) ? default(DateTime) : Lat4DeadLineToDeliverProductionsToABCounselDtp.Value;
                    _LatData.LATDeadlineToReceiveABProductions = string.IsNullOrEmpty(Lat4DeadLineToReceiveABProductionsTxt.Text) ? default(DateTime) : Lat4DeadLineToReceiveABProductionsDtp.Value;
                    _LatData.LATDeadlineToFileAffidavitReportsEtc = string.IsNullOrEmpty(Lat4DeadLineToFileAffidavitReportsTxt.Text) ? default(DateTime) : Lat4DeadLineToFileAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToReceiveAffidavitReportsEtc = string.IsNullOrEmpty(Lat4DeadLineToReceiveAffidavitReportsTxt.Text) ? default(DateTime) : Lat4DeadLineToReceiveAffidavitReportsDtp.Value;
                    _LatData.LATDeadlineToFileHearingSubmissionsAndOrBriefs = string.IsNullOrEmpty(Lat4DeadLineToFileHearingSubmissionsTxt.Text) ? default(DateTime) : Lat4DeadLineToFileHearingSubmissionsDtp.Value;
                    _LatData.LATDeadlineToReceiveInsurerSubmissions = string.IsNullOrEmpty(Lat4DeadLineToReceiveInsurerTxt.Text) ? default(DateTime) : Lat4DeadLineToReceiveInsurerDtp.Value;
                    _LatData.LATDeadlineForReplySubmissionsOfTheApplicant = string.IsNullOrEmpty(Lat4DeadLineForReplaySubmissionsTxt.Text) ? default(DateTime) : Lat4DeadLineForReplaySubmissionsDtp.Value;
                    _latDataRepository.Update(_LatData);
                }
                MessageBox.Show("Data Updated successfully!");
                Busqueda();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void _ClearDataLat()
        {
            foreach (TabPage Page in TabControl4.TabPages)
            {
                if (Page.Name == "LAT1")
                {
                    foreach (Control C in Page.Controls)
                    {
                        if (C is TextBox)
                        {
                            TextBox tx = new TextBox();
                            tx = (TextBox)C;
                            tx.Clear();
                        }
                    }

                    foreach (Control itemSummary in TableLayoutPanel2.Controls)
                    {
                        if (itemSummary is TextBox)
                        {
                            TextBox Txt = new TextBox();
                            Txt = (TextBox)itemSummary;
                            Txt.Clear();
                        }
                    }

                    foreach (Control itemSummary in TableLayoutPanel3.Controls)
                    {
                        if (itemSummary is TextBox)
                        {
                            TextBox Txt = new TextBox();
                            Txt = (TextBox)itemSummary;
                            Txt.Clear();
                        }
                    }
                }
                else if (Page.Name == "LAT2")
                {
                    foreach (Control C in Page.Controls)
                    {
                        if (C is TextBox)
                        {
                            TextBox tx = new TextBox();
                            tx = (TextBox)C;
                            tx.Clear();
                        }
                    }
                    foreach (Control itemSummary in TableLayoutPanel9.Controls)
                    {
                        if (itemSummary is TextBox)
                        {
                            TextBox Txt = new TextBox();
                            Txt = (TextBox)itemSummary;
                            Txt.Clear();
                        }
                    }
                    foreach (Control itemSummary in TableLayoutPanel8.Controls)
                    {
                        if (itemSummary is TextBox)
                        {
                            TextBox Txt = new TextBox();
                            Txt = (TextBox)itemSummary;
                            Txt.Clear();
                        }
                    }
                }
                else if (Page.Name == "LAT3")
                {
                    foreach (Control C in Page.Controls)
                    {
                        if (C is TextBox)
                        {
                            TextBox tx = new TextBox();
                            tx = (TextBox)C;
                            tx.Clear();
                        }
                    }

                    foreach (Control itemSummary in TableLayoutPanel13.Controls)
                    {
                        if (itemSummary is TextBox)
                        {
                            TextBox Txt = new TextBox();
                            Txt = (TextBox)itemSummary;
                            Txt.Clear();
                        }
                    }

                    foreach (Control itemSummary in TableLayoutPanel12.Controls)
                    {
                        if (itemSummary is TextBox)
                        {
                            TextBox Txt = new TextBox();
                            Txt = (TextBox)itemSummary;
                            Txt.Clear();
                        }
                    }
                }
                else if (Page.Name == "LAT4")
                {
                    foreach (Control C in Page.Controls)
                    {
                        if (C is TextBox)
                        {
                            TextBox tx = new TextBox();
                            tx = (TextBox)C;
                            tx.Clear();
                        }
                    }

                    foreach (Control itemSummary in TableLayoutPanel17.Controls)
                    {
                        if (itemSummary is TextBox)
                        {
                            TextBox Txt = new TextBox();
                            Txt = (TextBox)itemSummary;
                            Txt.Clear();
                        }
                    }

                    foreach (Control itemSummary in TableLayoutPanel16.Controls)
                    {
                        if (itemSummary is TextBox)
                        {
                            TextBox Txt = new TextBox();
                            Txt = (TextBox)itemSummary;
                            Txt.Clear();
                        }
                    }
                }
            }
        }
        private void Busqueda()
        {
            EventArgs evento = new EventArgs();
            if (Home.FileManager.File == null)
            {
                TabControl4.Enabled = false;
                TabControl1.SelectedIndex = 0;
                AccidentBenefitsTab.SelectedTab = ABBinderTab;
                MessageBox.Show("You have to select a file!");
                return;
            }
            else
            {
                TabControl4.Enabled = true;
            }

            if (User.ClearanceLevel != 0)
            {
                GroupBoxLat1.Visible = false;
                GroupBoxLat2.Visible = false;
                GroupBoxLat3.Visible = false;
                GroupBoxLat4.Visible = false;
            }
            else
            {
                GroupBoxLat1.Visible = true;
                GroupBoxLat2.Visible = true;
                GroupBoxLat3.Visible = true;
                GroupBoxLat4.Visible = true;
            }

            txtLimitationDate.Text = File.LimitationPeriod;
            if (_latDataRepository.List().Where(t => t.FileId == File.ID).ToList().Count == 0)
            {
                _ClearDataLat();
                MessageBox.Show("No lats available!");
            }
            if (_latDataRepository.Search(Home.FileManager.File, 1).ToList().Count > 0)
            {
                var latRepo = _latDataRepository.List().Single(t => t.FileId == File.ID && t.LATNumber == 1);
                ActualDateLatFiledTxt.Text = latRepo.LATActualDateFiled == default(DateTime)?"": latRepo.LATActualDateFiled.ToShortDateString();
                FiledDateTxt.Text = ActualDateLatFiledTxt.Text;
                
                LatCaseConfDateTxt.Text = latRepo.LATCaseConfDate == default(DateTime)?"":latRepo.LATCaseConfDate.ToShortDateString();
                CaseConfTxt.Text = LatCaseConfDateTxt.Text;

                HearingStarDateTxt.Text = latRepo.LATHearingDate == default(DateTime) ? "" : latRepo.LATHearingDate.ToShortDateString();
                HearingDateTxt.Text = HearingStarDateTxt.Text;

                DateLatSettledClosedtTxt.Text = latRepo.LATDateSettled == default(DateTime) ? "" : latRepo.LATDateSettled.ToShortDateString();
                DateSettledTxt.Text = DateLatSettledClosedtTxt.Text;

                if (latRepo.LATDueDateToDiscussPotentialLAT != default(DateTime))
                {
                    DueDateToDiscussPotenctialLatApplDtp.Value = latRepo.LATDueDateToDiscussPotentialLAT;
                    LatFiledDtp_ValueChanged(DueDateToDiscussPotenctialLatApplDtp,evento);
                }
                else
                {
                    DueDateToDiscussPotenctialLatApplTxt.Text = "";
                }

                if (latRepo.LATDateMetWithLawyerReDenial != default(DateTime))
                {
                    DateMetWithLawyerReDenialDtp.Value = latRepo.LATDateMetWithLawyerReDenial;
                    LatFiledDtp_ValueChanged(DateMetWithLawyerReDenialDtp, evento);
                }
                else
                {
                    DateMetWithLawyerReDenialTxt.Text = "";
                }

                if (latRepo.LATProposedDateToFileLAT != default(DateTime))
                {
                    ProposedDateToFileLatDtp.Value = latRepo.LATProposedDateToFileLAT;
                    LatFiledDtp_ValueChanged(ProposedDateToFileLatDtp, evento);
                }
                else
                {
                    ProposedDateToFileLatTxt.Text = "";
                }
                if (latRepo.LATActualDateLATServedOnInsurer != default(DateTime))
                {
                    ActualDateLatServedOnInsurerDtp.Value = latRepo.LATActualDateLATServedOnInsurer;
                    LatFiledDtp_ValueChanged(ActualDateLatServedOnInsurerDtp, evento);
                }
                else
                {
                    ActualDateLatServedOnInsurerTxt.Text = "";
                }
                if (latRepo.LATInsurersResponseReceived != default(DateTime))
                {
                    InsuresResponseReceivedDtp.Value = latRepo.LATInsurersResponseReceived;
                    LatFiledDtp_ValueChanged(InsuresResponseReceivedDtp, evento);
                }
                else
                {
                    InsuresResponseReceivedTxt.Text = "";
                }
                if (latRepo.LATDeadlineToServeFileCaseConfSummary != default(DateTime))
                {
                    DeadLineToServeFileCaseConfSummaryDtp.Value = latRepo.LATDeadlineToServeFileCaseConfSummary;
                    LatFiledDtp_ValueChanged(DeadLineToServeFileCaseConfSummaryDtp, evento);
                }
                else
                {
                    DeadLineToServeFileCaseConfSummaryTxt.Text = "";
                }
                if (latRepo.LATDeadlineToDeliverProductionstoABCounsel != default(DateTime))
                {
                    DeadLineToDeliverProductionsToABCounselDtp.Value = latRepo.LATDeadlineToDeliverProductionstoABCounsel;
                    LatFiledDtp_ValueChanged(DeadLineToDeliverProductionsToABCounselDtp, evento);
                }
                else
                {
                    Lat2DeadLineToDeliverProductionsToABCounselTxt.Text = "";
                }

                if (latRepo.LATDeadlineToReceiveABProductions != default(DateTime))
                {
                    DeadLineToReceiveABProductionsDtp.Value = latRepo.LATDeadlineToReceiveABProductions;
                    LatFiledDtp_ValueChanged(DeadLineToReceiveABProductionsDtp, evento);
                }
                else
                {
                    Lat2DeadLineToReceiveABProductionsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToFileAffidavitReportsEtc!= default(DateTime))
                {
                    DeadLineToFileAffidavitReportsDtp.Value = latRepo.LATDeadlineToFileAffidavitReportsEtc;
                    LatFiledDtp_ValueChanged(DeadLineToFileAffidavitReportsDtp, evento);
                }
                else
                {
                    DeadLineToFileAffidavitReportsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToReceiveAffidavitReportsEtc != default(DateTime))
                {
                    DeadLineToReceiveAffidavitReportsDtp.Value = latRepo.LATDeadlineToReceiveAffidavitReportsEtc;
                    LatFiledDtp_ValueChanged(DeadLineToReceiveAffidavitReportsDtp, evento);
                }
                else
                {
                    DeadLineToReceiveAffidavitReportsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToFileHearingSubmissionsAndOrBriefs != default(DateTime))
                {
                    DeadLineToFileHearingSubmissionsDtp.Value = latRepo.LATDeadlineToFileHearingSubmissionsAndOrBriefs;
                    LatFiledDtp_ValueChanged(DeadLineToFileHearingSubmissionsDtp, evento);
                }
                else
                {
                    DeadLineToFileHearingSubmissionsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToReceiveInsurerSubmissions != default(DateTime))
                {
                    DeadlineToReceiveInsurerDtp.Value = latRepo.LATDeadlineToReceiveInsurerSubmissions;
                    LatFiledDtp_ValueChanged(DeadlineToReceiveInsurerDtp, evento);
                }
                else
                {
                    DeadlineToReceiveInsurerTxt.Text = "";
                }
                if (latRepo.LATDeadlineForReplySubmissionsOfTheApplicant != default(DateTime))
                {
                    DeadLineForReplaySubmissionsDtp.Value = latRepo.LATDeadlineForReplySubmissionsOfTheApplicant;
                    LatFiledDtp_ValueChanged(DeadLineForReplaySubmissionsDtp, evento);
                }
                else
                {
                    DeadLineForReplaySubmissionsTxt.Text = "";
                }

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

            if (_latDataRepository.Search(File, 2).ToList().Count > 0)
            {
                var latRepo = _latDataRepository.List().Single(t => t.FileId == File.ID && t.LATNumber == 2);
                Lat2ActualDateLatFiledTxt.Text = latRepo.LATActualDateFiled == default(DateTime)? "" : latRepo.LATActualDateFiled.ToShortDateString();
                FiledDateLat2.Text = Lat2ActualDateLatFiledTxt.Text;

                Lat2LatCaseConfDateTxt.Text = latRepo.LATCaseConfDate == default(DateTime) ? "":latRepo.LATCaseConfDate.ToShortDateString();
                CaseConfLat2.Text = Lat2LatCaseConfDateTxt.Text;

                Lat2HearingStarDateTxt.Text = latRepo.LATHearingDate==default(DateTime)?"": latRepo.LATHearingDate.ToShortDateString();
                HearingDateTxt.Text = Lat2HearingStarDateTxt.Text;

                Lat2DateLatSettledClosedTxt.Text = latRepo.LATDateSettled == default(DateTime) ? "" : latRepo.LATDateSettled.ToShortDateString();
                DateSettledLat2.Text = Lat2DateLatSettledClosedTxt.Text;


                if (latRepo.LATDueDateToDiscussPotentialLAT != default(DateTime))
                {
                    Lat2DueDateToDiscussPotenctialLatApplDtp.Value = latRepo.LATDueDateToDiscussPotentialLAT;
                    LatFiledDtp_ValueChanged(Lat2DueDateToDiscussPotenctialLatApplDtp, evento);
                }
                else
                {
                    Lat2DueDateToDiscussPotenctialLatApplTxt.Text = "";
                }
                if (latRepo.LATDateMetWithLawyerReDenial != default(DateTime))
                {
                    Lat2DateMetWithLawyerReDenialDtp.Value = latRepo.LATDateMetWithLawyerReDenial;
                    LatFiledDtp_ValueChanged(Lat2DateMetWithLawyerReDenialDtp, evento);
                }
                else
                {
                    Lat2DateMetWithLawyerReDenialTxt.Text = "";
                }
                if (latRepo.LATProposedDateToFileLAT != default(DateTime))
                {
                    Lat2ProposedDateToFileLatDtp.Value = latRepo.LATProposedDateToFileLAT;
                    LatFiledDtp_ValueChanged(Lat2ProposedDateToFileLatDtp, evento);
                }
                else
                {
                    Lat2ProposedDateToFileLatTxt.Text = "";
                }
                if (latRepo.LATActualDateLATServedOnInsurer != default(DateTime))
                {
                    Lat2ActualDateLatServedOnInsurerDtp.Value = latRepo.LATActualDateLATServedOnInsurer;
                    LatFiledDtp_ValueChanged(Lat2ActualDateLatServedOnInsurerDtp, evento);
                }
                else
                {
                    Lat2ActualDateLatServedOnInsurerDtp.Text = "";
                }
                if (latRepo.LATInsurersResponseReceived != default(DateTime))
                {
                    Lat2InsuresResponseReceivedDtp.Value = latRepo.LATInsurersResponseReceived;
                    LatFiledDtp_ValueChanged(Lat2InsuresResponseReceivedDtp, evento);
                }
                else
                {
                    Lat2InsuresResponseReceivedTxt.Text = "";
                }
                if (latRepo.LATDeadlineToServeFileCaseConfSummary != default(DateTime))
                {
                    Lat2DeadLineToServeFileCaseConfSummaryDtp.Value = latRepo.LATDeadlineToServeFileCaseConfSummary;
                    LatFiledDtp_ValueChanged(Lat2DeadLineToServeFileCaseConfSummaryDtp, evento);
                }
                else
                {
                    Lat2DeadLineToServeFileCaseConfSummaryTxt.Text = "";
                }
                if (latRepo.LATDeadlineToDeliverProductionstoABCounsel != default(DateTime))
                {
                    Lat2DeadLineToDeliverProductionsToABCounselDtp.Value = latRepo.LATDeadlineToDeliverProductionstoABCounsel;
                    LatFiledDtp_ValueChanged(Lat2DeadLineToDeliverProductionsToABCounselDtp, evento);
                }
                else
                {
                    Lat2DeadLineToDeliverProductionsToABCounselDtp.Text = "";
                }
                if (latRepo.LATDeadlineToReceiveABProductions != default(DateTime))
                {
                    Lat2DeadLineToReceiveABProductionsDtp.Value = latRepo.LATDeadlineToReceiveABProductions;
                    LatFiledDtp_ValueChanged(Lat2DeadLineToReceiveABProductionsDtp, evento);
                }
                else
                {
                    Lat2DeadLineToReceiveABProductionsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToFileAffidavitReportsEtc != default(DateTime))
                {
                    Lat2DeadLineToFileAffidavitReportsDtp.Value = latRepo.LATDeadlineToFileAffidavitReportsEtc;
                    LatFiledDtp_ValueChanged(Lat2DeadLineToFileAffidavitReportsDtp, evento);
                }
                else
                {
                    Lat2DeadLineToFileAffidavitReportsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToFileAffidavitReportsEtc != default(DateTime))
                {
                    Lat2DeadLineToReceiveAffidavitReportsDtp.Value = latRepo.LATDeadlineToReceiveAffidavitReportsEtc;
                    LatFiledDtp_ValueChanged(Lat2DeadLineToReceiveAffidavitReportsDtp, evento);
                }
                else
                {
                    Lat2DeadLineToReceiveAffidavitReportsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToFileHearingSubmissionsAndOrBriefs != default(DateTime))
                {
                    Lat2DeadLineToFileHearingSubmissionsDtp.Value = latRepo.LATDeadlineToFileHearingSubmissionsAndOrBriefs;
                    LatFiledDtp_ValueChanged(Lat2DeadLineToFileHearingSubmissionsDtp, evento);
                }
                else
                {
                    Lat2DeadLineToFileHearingSubmissionsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToReceiveInsurerSubmissions != default(DateTime))
                {
                    Lat2DeadLineToReceiveInsurerDtp.Value = latRepo.LATDeadlineToReceiveInsurerSubmissions;
                    LatFiledDtp_ValueChanged(Lat2DeadLineToReceiveInsurerDtp, evento);
                }
                else
                {
                    Lat2DeadLineToReceiveInsurerTxt.Text = "";
                }
                if (latRepo.LATDeadlineForReplySubmissionsOfTheApplicant != default(DateTime))
                {
                    Lat2DeadLineForReplaySubmissionsDtp.Value = latRepo.LATDeadlineForReplySubmissionsOfTheApplicant;
                    LatFiledDtp_ValueChanged(Lat2DeadLineForReplaySubmissionsDtp, evento);
                }
                else
                {
                    Lat2DeadLineForReplaySubmissionsTxt.Text = "";
                }

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

            if (_latDataRepository.Search(File, 3).ToList().Count > 0)
            {
                var latRepo = _latDataRepository.List().Single(t => t.FileId == File.ID && t.LATNumber == 3);

                Lat3ActualDateLatFiledTxt.Text = latRepo.LATActualDateFiled == default(DateTime) ? "":latRepo.LATActualDateFiled.ToShortDateString();
                FiledDateLat3.Text = Lat3ActualDateLatFiledTxt.Text;

                Lat3LatCaseConfDateTxt.Text = latRepo.LATCaseConfDate == default(DateTime) ? "" : latRepo.LATCaseConfDate.ToShortDateString();
                CaseConfLat3.Text = Lat3LatCaseConfDateTxt.Text;

                Lat3HearingStarDateTxt.Text = latRepo.LATHearingDate == default(DateTime) ? "" : latRepo.LATHearingDate.ToShortDateString();
                HearingDateLat3.Text = Lat3HearingStarDateTxt.Text;

                Lat3DateLatSettledClosedTxt.Text = latRepo.LATDateSettled == default(DateTime) ? "" : latRepo.LATDateSettled.ToShortDateString();
                DateSettledLat3.Text = Lat3DateLatSettledClosedTxt.Text;

                if (latRepo.LATDueDateToDiscussPotentialLAT != default(DateTime))
                {
                    Lat3DueDateToDiscussPotenctialLatApplDtp.Value = latRepo.LATDueDateToDiscussPotentialLAT;
                    LatFiledDtp_ValueChanged(Lat3DueDateToDiscussPotenctialLatApplDtp, evento);
                }
                else
                {
                    Lat3DueDateToDiscussPotenctialLatApplTxt.Text = "";
                }
                if (latRepo.LATDateMetWithLawyerReDenial != default(DateTime))
                {
                    Lat3DateMetWithLawyerReDenialDtp.Value = latRepo.LATDateMetWithLawyerReDenial;
                    LatFiledDtp_ValueChanged(Lat3DateMetWithLawyerReDenialDtp, evento);
                }
                else
                {
                    Lat3DateMetWithLawyerReDenialTxt.Text = "";
                }
                if (latRepo.LATProposedDateToFileLAT != default(DateTime))
                {
                    Lat3ProposedDateToFileLatDtp.Value = latRepo.LATProposedDateToFileLAT;
                    LatFiledDtp_ValueChanged(Lat3ProposedDateToFileLatDtp, evento);
                }
                else
                {
                    Lat3ProposedDateToFileLatTxt.Text = "";
                }
                if (latRepo.LATActualDateLATServedOnInsurer != default(DateTime))
                {
                    Lat3ActualDateLatServedOnInsurerDtp.Value = latRepo.LATActualDateLATServedOnInsurer;
                    LatFiledDtp_ValueChanged(Lat3ActualDateLatServedOnInsurerDtp, evento);
                }
                else
                {
                    Lat3ActualDateLatServedOnInsurerTxt.Text = "";
                }
                if (latRepo.LATInsurersResponseReceived != default(DateTime))
                {
                    Lat3InsuresResponseReceivedDtp.Value = latRepo.LATInsurersResponseReceived;
                    LatFiledDtp_ValueChanged(Lat3InsuresResponseReceivedDtp, evento);
                }
                else
                {
                    Lat3InsuresResponseReceivedTxt.Text = "";
                }
                if (latRepo.LATDeadlineToServeFileCaseConfSummary != default(DateTime))
                {
                    Lat3DeadLineToServeFileCaseConfSummaryDtp.Value = latRepo.LATDeadlineToServeFileCaseConfSummary;
                    LatFiledDtp_ValueChanged(Lat3DeadLineToServeFileCaseConfSummaryDtp, evento);
                }
                else
                {
                    Lat3DeadLineToServeFileCaseConfSummaryTxt.Text = "";
                }
                if (latRepo.LATDeadlineToDeliverProductionstoABCounsel != default(DateTime))
                {
                    Lat3DeadLineToDeliverProductionsToABCounselDtp.Value = latRepo.LATDeadlineToDeliverProductionstoABCounsel;
                    LatFiledDtp_ValueChanged(Lat3DeadLineToDeliverProductionsToABCounselDtp, evento);
                }
                else
                {
                    Lat3DeadLineToDeliverProductionsToABCounselTxt.Text = "";
                }
                if (latRepo.LATDeadlineToReceiveABProductions != default(DateTime))
                {
                    Lat3DeadLineToReceiveABProductionsDtp.Value = latRepo.LATDeadlineToReceiveABProductions;
                    LatFiledDtp_ValueChanged(Lat3DeadLineToReceiveABProductionsDtp, evento);
                }
                else
                {
                    Lat3DeadLineToReceiveABProductionsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToFileAffidavitReportsEtc != default(DateTime))
                {
                    Lat3DeadLineToFileAffidavitReportsDtp.Value = latRepo.LATDeadlineToFileAffidavitReportsEtc;
                    LatFiledDtp_ValueChanged(Lat3DeadLineToFileAffidavitReportsDtp, evento);
                }
                else
                {
                    Lat3DeadLineToFileAffidavitReportsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToReceiveAffidavitReportsEtc != default(DateTime))
                {
                    Lat3DeadLineToReceiveAffidavitReportsDtp.Value = latRepo.LATDeadlineToReceiveAffidavitReportsEtc;
                    LatFiledDtp_ValueChanged(Lat3DeadLineToReceiveAffidavitReportsDtp, evento);
                }
                else
                {
                    Lat3DeadLineToReceiveAffidavitReportsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToFileHearingSubmissionsAndOrBriefs != default(DateTime))
                {
                    Lat3DeadLineToFileHearingSubmissionsDtp.Value = latRepo.LATDeadlineToFileHearingSubmissionsAndOrBriefs;
                    LatFiledDtp_ValueChanged(Lat3DeadLineToFileHearingSubmissionsDtp, evento);
                }
                else
                {
                    Lat3DeadLineToFileHearingSubmissionsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToReceiveInsurerSubmissions != default(DateTime))
                {
                    Lat3DeadLineToReceiveInsurerDtp.Value = latRepo.LATDeadlineToReceiveInsurerSubmissions;
                    LatFiledDtp_ValueChanged(Lat3DeadLineToReceiveInsurerDtp, evento);
                }
                else
                {
                    Lat3DeadLineToReceiveInsurerTxt.Text = "";
                }
                if (latRepo.LATDeadlineForReplySubmissionsOfTheApplicant != default(DateTime))
                {
                    Lat3DeadLineForReplaySubmissionsDtp.Value = latRepo.LATDeadlineForReplySubmissionsOfTheApplicant;
                    LatFiledDtp_ValueChanged(Lat3DeadLineForReplaySubmissionsDtp, evento);
                }
                else
                {
                    Lat3DeadLineForReplaySubmissionsTxt.Text = "";
                }

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

            if (_latDataRepository.Search(File, 4).ToList().Count > 0)
            {
                var latRepo = _latDataRepository.List().Single(t => t.FileId == File.ID && t.LATNumber == 4);
                Lat4ActualDateLatFiledTxt.Text = latRepo.LATActualDateFiled == default(DateTime) ? "" : latRepo.LATActualDateFiled.ToShortDateString();
                FiledDateLat4.Text = Lat4ActualDateLatFiledTxt.Text;

                Lat4LatCaseConfDateTxt.Text = latRepo.LATCaseConfDate == default(DateTime) ? "" : latRepo.LATCaseConfDate.ToShortDateString();
                CaseConfLat4.Text = Lat4LatCaseConfDateTxt.Text;

                Lat4HearingStarDateTxt.Text = latRepo.LATHearingDate == default(DateTime) ? "" : latRepo.LATHearingDate.ToShortDateString();
                HearingDateLat4.Text = Lat4HearingStarDateTxt.Text;

                Lat4DateLatSettledClosedTxt.Text = latRepo.LATDateSettled == default(DateTime) ? "" : latRepo.LATDateSettled.ToShortDateString();
                HearingDateLat4.Text = Lat4DateLatSettledClosedTxt.Text;

                if (latRepo.LATDueDateToDiscussPotentialLAT != default(DateTime))
                {
                    Lat4DueDateToDiscussPotenctialLatApplDtp.Value = latRepo.LATDueDateToDiscussPotentialLAT;
                    LatFiledDtp_ValueChanged(Lat4DueDateToDiscussPotenctialLatApplDtp, evento);
                }
                else
                {
                    Lat4DueDateToDiscussPotenctialLatApplTxt.Text = "";
                }
                if (latRepo.LATDateMetWithLawyerReDenial != default(DateTime))
                {
                    Lat4DateMetWithLawyerReDenialDtp.Value = latRepo.LATDateMetWithLawyerReDenial;
                    LatFiledDtp_ValueChanged(Lat4DateMetWithLawyerReDenialDtp, evento);
                }
                else
                {
                    Lat4DateMetWithLawyerReDenialTxt.Text = "";
                }
                if (latRepo.LATProposedDateToFileLAT != default(DateTime))
                {
                    Lat4ProposedDateToFileLatDtp.Value = latRepo.LATProposedDateToFileLAT;
                    LatFiledDtp_ValueChanged(Lat4ProposedDateToFileLatDtp, evento);
                }
                else
                {
                    Lat4ProposedDateToFileLatTxt.Text = "";
                }
                if (latRepo.LATActualDateLATServedOnInsurer != default(DateTime))
                {
                    Lat4ActualDateLatServedOnInsurerDtp.Value = latRepo.LATActualDateLATServedOnInsurer;
                    LatFiledDtp_ValueChanged(Lat4ActualDateLatServedOnInsurerDtp, evento);
                }
                else
                {
                    Lat4ActualDateLatServedOnInsurerTxt.Text = "";
                }
                if (latRepo.LATInsurersResponseReceived != default(DateTime))
                {
                    Lat4InsuresResponseReceivedDtp.Value = latRepo.LATInsurersResponseReceived;
                    LatFiledDtp_ValueChanged(Lat4InsuresResponseReceivedDtp, evento);
                }
                else
                {
                    Lat4InsuresResponseReceivedTxt.Text = "";
                }
                if (latRepo.LATDeadlineToServeFileCaseConfSummary != default(DateTime))
                {
                    Lat4DeadLineToServeFileCaseConfSummaryDtp.Value = latRepo.LATDeadlineToServeFileCaseConfSummary;
                    LatFiledDtp_ValueChanged(Lat4DeadLineToServeFileCaseConfSummaryDtp, evento);
                }
                else
                {
                    Lat4DeadLineToServeFileCaseConfSummaryTxt.Text = "";
                }
                if (latRepo.LATDeadlineToDeliverProductionstoABCounsel != default(DateTime))
                {
                    Lat4DeadLineToDeliverProductionsToABCounselDtp.Value = latRepo.LATDeadlineToDeliverProductionstoABCounsel;
                    LatFiledDtp_ValueChanged(Lat4DeadLineToDeliverProductionsToABCounselDtp, evento);
                }
                else
                {
                    Lat4DeadLineToDeliverProductionsToABCounselTxt.Text = "";
                }
                if (latRepo.LATDeadlineToReceiveABProductions != default(DateTime))
                {
                    Lat4DeadLineToReceiveABProductionsDtp.Value = latRepo.LATDeadlineToReceiveABProductions;
                    LatFiledDtp_ValueChanged(Lat4DeadLineToReceiveABProductionsDtp, evento);
                }
                else
                {
                    Lat4DeadLineToReceiveABProductionsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToFileAffidavitReportsEtc != default(DateTime))
                {
                    Lat4DeadLineToFileAffidavitReportsDtp.Value = latRepo.LATDeadlineToFileAffidavitReportsEtc;
                    LatFiledDtp_ValueChanged(Lat4DeadLineToFileAffidavitReportsDtp, evento);
                }
                else
                {
                    Lat4DeadLineToFileAffidavitReportsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToReceiveAffidavitReportsEtc != default(DateTime))
                {
                    Lat4DeadLineToReceiveAffidavitReportsDtp.Value = latRepo.LATDeadlineToReceiveAffidavitReportsEtc;
                    LatFiledDtp_ValueChanged(Lat4DeadLineToReceiveAffidavitReportsDtp, evento);
                }
                else
                {
                    Lat4DeadLineToReceiveAffidavitReportsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToFileHearingSubmissionsAndOrBriefs != default(DateTime))
                {
                    Lat4DeadLineToFileHearingSubmissionsDtp.Value = latRepo.LATDeadlineToFileHearingSubmissionsAndOrBriefs;
                    LatFiledDtp_ValueChanged(Lat4DeadLineToFileHearingSubmissionsDtp, evento);
                }
                else
                {
                    Lat4DeadLineToFileHearingSubmissionsTxt.Text = "";
                }
                if (latRepo.LATDeadlineToReceiveInsurerSubmissions != default(DateTime))
                {
                    Lat4DeadLineToReceiveInsurerDtp.Value = latRepo.LATDeadlineToReceiveInsurerSubmissions;
                    LatFiledDtp_ValueChanged(Lat4DeadLineToReceiveInsurerDtp, evento);
                }
                else
                {
                    Lat4DeadLineToReceiveInsurerTxt.Text = "";
                }
                if (latRepo.LATDeadlineForReplySubmissionsOfTheApplicant != default(DateTime))
                {
                    Lat4DeadLineForReplaySubmissionsDtp.Value = latRepo.LATDeadlineForReplySubmissionsOfTheApplicant;
                    LatFiledDtp_ValueChanged(Lat4DeadLineForReplaySubmissionsDtp, evento);
                }
                else
                {
                    Lat4DeadLineForReplaySubmissionsTxt.Text = "";
                }

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
        public void DtpChange(object sender)
        {
            if (sender is DateTimePicker)
            {
                DateTimePicker dtp = new DateTimePicker();
                dtp = (DateTimePicker)sender;
                switch (dtp.Name)
                {
                    // Campos Primarios LAT1
                    case "ActualDateLatFiledDtp":
                        ActualDateLatFiledTxt.Text = ActualDateLatFiledDtp.Value.ToShortDateString();
                        FiledDateTxt.Text = ActualDateLatFiledDtp.Value.ToShortDateString();
                        break;
                    case "LatCaseConfDateDtp":
                        LatCaseConfDateTxt.Text = LatCaseConfDateDtp.Value.ToShortDateString();
                        CaseConfTxt.Text = LatCaseConfDateDtp.Value.ToShortDateString();
                        break;
                    case "HearingStarDateDtp":
                        HearingStarDateTxt.Text = HearingStarDateDtp.Value.ToShortDateString();
                        HearingDateTxt.Text = HearingStarDateDtp.Value.ToShortDateString();
                        break;
                    case "DateLatSettledClosedDtp":
                        DateLatSettledClosedtTxt.Text = DateLatSettledClosedDtp.Value.ToShortDateString();
                        DateSettledTxt.Text = DateLatSettledClosedDtp.Value.ToShortDateString();
                        break;

                    // Campos Primarios LAT2
                    case "Lat2ActualDateLatFiledDtp":
                        Lat2ActualDateLatFiledTxt.Text = Lat2ActualDateLatFiledDtp.Value.ToShortDateString();
                        FiledDateLat2.Text = Lat2ActualDateLatFiledDtp.Value.ToShortDateString();
                        break;
                    case "Lat2LatCaseConfDateDtp":
                        Lat2LatCaseConfDateTxt.Text = Lat2LatCaseConfDateDtp.Value.ToShortDateString();
                        CaseConfLat2.Text = Lat2LatCaseConfDateDtp.Value.ToShortDateString();
                        break;
                    case "Lat2HearingStarDateDtp":
                        Lat2HearingStarDateTxt.Text = Lat2HearingStarDateDtp.Value.ToShortDateString();
                        HearingDateLat2.Text = Lat2HearingStarDateDtp.Value.ToShortDateString();
                        break;
                    case "Lat2DateLatSettledClosedDtp":
                        Lat2DateLatSettledClosedTxt.Text = Lat2DateLatSettledClosedDtp.Value.ToShortDateString();
                        DateSettledLat2.Text = Lat2DateLatSettledClosedDtp.Value.ToShortDateString();
                        break;

                    // Campos Primarios LAT3
                    case "Lat3ActualDateLatFiledDtp":
                        Lat3ActualDateLatFiledTxt.Text = Lat3ActualDateLatFiledDtp.Value.ToShortDateString();
                        FiledDateLat3.Text = Lat3ActualDateLatFiledDtp.Value.ToShortDateString();
                        break;
                    case "Lat3LatCaseConfDateDtp":
                        Lat3LatCaseConfDateTxt.Text = Lat3LatCaseConfDateDtp.Value.ToShortDateString();
                        CaseConfLat3.Text = Lat3LatCaseConfDateDtp.Value.ToShortDateString();
                        break;
                    case "Lat3HearingStarDateDtp":
                        Lat3HearingStarDateTxt.Text = Lat3HearingStarDateDtp.Value.ToShortDateString();
                        HearingDateLat3.Text = Lat3HearingStarDateDtp.Value.ToShortDateString();
                        break;
                    case "Lat3DateLatSettledClosedDtp":
                        Lat3DateLatSettledClosedTxt.Text = Lat3DateLatSettledClosedDtp.Value.ToShortDateString();
                        DateSettledLat3.Text = Lat3DateLatSettledClosedDtp.Value.ToShortDateString();
                        break;

                    // Campos Primarios LAT4

                    case "Lat4ActualDateLatFiledDtp":
                        Lat4ActualDateLatFiledTxt.Text = Lat4ActualDateLatFiledDtp.Value.ToShortDateString();
                        FiledDateLat4.Text = Lat4ActualDateLatFiledDtp.Value.ToShortDateString();
                        break;
                    case "Lat4LatCaseConfDateDtp":
                        Lat4LatCaseConfDateTxt.Text = Lat4LatCaseConfDateDtp.Value.ToShortDateString();
                        CaseConfLat4.Text = Lat4LatCaseConfDateDtp.Value.ToShortDateString();
                        break;
                    case "Lat4HearingStarDateDtp":
                        Lat4HearingStarDateTxt.Text = Lat4HearingStarDateDtp.Value.ToShortDateString();
                        HearingDateLat4.Text = Lat4HearingStarDateDtp.Value.ToShortDateString();
                        break;
                    case "Lat4DateLatSettledClosedDtp":
                        Lat4DateLatSettledClosedTxt.Text = Lat4DateLatSettledClosedDtp.Value.ToShortDateString();
                        DateSettledLat4.Text = Lat4DateLatSettledClosedDtp.Value.ToShortDateString();
                        break;

                    // Campos secundarios LAT1
                    case "DateMetWithLawyerReDenialDtp":
                        DateMetWithLawyerReDenialTxt.Text = DateMetWithLawyerReDenialDtp.Value.ToShortDateString();
                        break;
                    case "InsuresResponseReceivedDtp":
                        InsuresResponseReceivedTxt.Text = InsuresResponseReceivedDtp.Value.ToShortDateString();
                        break;
                    case "DeadLineToReceiveABProductionsDtp":
                        DeadLineToReceiveABProductionsTxt.Text = DeadLineToReceiveABProductionsDtp.Value.ToShortDateString();
                        break;
                    case "DeadLineToReceiveAffidavitReportsDtp":
                        DeadLineToReceiveAffidavitReportsTxt.Text = DeadLineToReceiveAffidavitReportsDtp.Value.ToShortDateString();
                        break;
                    case "DeadlineToReceiveInsurerDtp":
                        DeadlineToReceiveInsurerTxt.Text = DeadlineToReceiveInsurerDtp.Value.ToShortDateString();
                        break;
                    case "DueDateToDiscussPotenctialLatApplDtp":
                        DueDateToDiscussPotenctialLatApplTxt.Text = DueDateToDiscussPotenctialLatApplDtp.Value.ToShortDateString();
                        break;
                    case "ProposedDateToFileLatDtp":
                        ProposedDateToFileLatTxt.Text = ProposedDateToFileLatDtp.Value.ToShortDateString();
                        break;
                    case "ActualDateLatServedOnInsurerDtp":
                        ActualDateLatServedOnInsurerTxt.Text = ActualDateLatServedOnInsurerDtp.Value.ToShortDateString();
                        break;
                    case "DeadLineToServeFileCaseConfSummaryDtp":
                        DeadLineToServeFileCaseConfSummaryTxt.Text = DeadLineToServeFileCaseConfSummaryDtp.Value.ToShortDateString();
                        break;
                    case "DeadLineToDeliverProductionsToABCounselDtp":
                        DeadLineToDeliverProductionsToABCounselTxt.Text = DeadLineToDeliverProductionsToABCounselDtp.Value.ToShortDateString();
                        break;
                    case "DeadLineToFileAffidavitReportsDtp":
                        DeadLineToFileAffidavitReportsTxt.Text = DeadLineToFileAffidavitReportsDtp.Value.ToShortDateString();
                        break;
                    case "DeadLineToFileHearingSubmissionsDtp":
                        DeadLineToFileHearingSubmissionsTxt.Text = DeadLineToFileHearingSubmissionsDtp.Value.ToShortDateString();
                        break;
                    case "DeadLineForReplaySubmissionsDtp":
                        DeadLineForReplaySubmissionsTxt.Text = DeadLineForReplaySubmissionsDtp.Value.ToShortDateString();
                        break;

                    // Campos secundarios LAT2
                    case "Lat2DateMetWithLawyerReDenialDtp":
                        Lat2DateMetWithLawyerReDenialTxt.Text = Lat2DateMetWithLawyerReDenialDtp.Value.ToShortDateString();
                        break;
                    case "Lat2InsuresResponseReceivedDtp":
                        Lat2InsuresResponseReceivedTxt.Text = Lat2InsuresResponseReceivedDtp.Value.ToShortDateString();
                        break;
                    case "Lat2DeadLineToReceiveABProductionsDtp":
                        Lat2DeadLineToReceiveABProductionsTxt.Text = Lat2DeadLineToReceiveABProductionsDtp.Value.ToShortDateString();
                        break;
                    case "Lat2DeadLineToReceiveAffidavitReportsDtp":
                        Lat2DeadLineToReceiveAffidavitReportsTxt.Text = Lat2DeadLineToReceiveAffidavitReportsDtp.Value.ToShortDateString();
                        break;
                    case "Lat2DeadLineToReceiveInsurerDtp":
                        Lat2DeadLineToReceiveInsurerTxt.Text = Lat2DeadLineToReceiveInsurerDtp.Value.ToShortDateString();
                        break;
                    case "Lat2DueDateToDiscussPotenctialLatApplDtp":
                        Lat2DueDateToDiscussPotenctialLatApplTxt.Text = Lat2DueDateToDiscussPotenctialLatApplDtp.Value.ToShortDateString();
                        break;
                    case "Lat2ProposedDateToFileLatDtp":
                        Lat2ProposedDateToFileLatTxt.Text = Lat2ProposedDateToFileLatDtp.Value.ToShortDateString();
                        break;
                    case "Lat2ActualDateLatServedOnInsurerDtp":
                        Lat2ActualDateLatServedOnInsurerTxt.Text = Lat2ActualDateLatServedOnInsurerDtp.Value.ToShortDateString();
                        break;
                    case "Lat2DeadLineToServeFileCaseConfSummaryDtp":
                        Lat2DeadLineToServeFileCaseConfSummaryTxt.Text = Lat2DeadLineToServeFileCaseConfSummaryDtp.Value.ToShortDateString();
                        break;
                    case "Lat2DeadLineToDeliverProductionsToABCounselDtp":
                        Lat2DeadLineToDeliverProductionsToABCounselTxt.Text = Lat2DeadLineToDeliverProductionsToABCounselDtp.Value.ToShortDateString();
                        break;
                    case "Lat2DeadLineToFileAffidavitReportsDtp":
                        Lat2DeadLineToFileAffidavitReportsTxt.Text = Lat2DeadLineToFileAffidavitReportsDtp.Value.ToShortDateString();
                        break;
                    case "Lat2DeadLineToFileHearingSubmissionsDtp":
                        Lat2DeadLineToFileHearingSubmissionsTxt.Text = Lat2DeadLineToFileHearingSubmissionsDtp.Value.ToShortDateString();
                        break;
                    case "Lat2DeadLineForReplaySubmissionsDtp":
                        Lat2DeadLineForReplaySubmissionsTxt.Text = Lat2DeadLineForReplaySubmissionsDtp.Value.ToShortDateString();
                        break;

                    // Campos secundarios LAT3

                    case "Lat3DateMetWithLawyerReDenialDtp":
                        Lat3DateMetWithLawyerReDenialTxt.Text = Lat3DateMetWithLawyerReDenialDtp.Value.ToShortDateString();
                        break;
                    case "Lat3InsuresResponseReceivedDtp":
                        Lat3InsuresResponseReceivedTxt.Text = Lat3InsuresResponseReceivedDtp.Value.ToShortDateString();
                        break;
                    case "Lat3DeadLineToReceiveABProductionsDtp":
                        Lat3DeadLineToReceiveABProductionsTxt.Text = Lat3DeadLineToReceiveABProductionsDtp.Value.ToShortDateString();
                        break;
                    case "Lat3DeadLineToReceiveAffidavitReportsDtp":
                        Lat3DeadLineToReceiveAffidavitReportsTxt.Text = Lat3DeadLineToReceiveAffidavitReportsDtp.Value.ToShortDateString();
                        break;
                    case "Lat3DeadLineToReceiveInsurerDtp":
                        Lat3DeadLineToReceiveInsurerTxt.Text = Lat3DeadLineToReceiveInsurerDtp.Value.ToShortDateString();
                        break;
                    case "Lat3DueDateToDiscussPotenctialLatApplDtp":
                        Lat3DueDateToDiscussPotenctialLatApplTxt.Text = Lat3DueDateToDiscussPotenctialLatApplDtp.Value.ToShortDateString();
                        break;
                    case "Lat3ProposedDateToFileLatDtp":
                        Lat3ProposedDateToFileLatTxt.Text = Lat3ProposedDateToFileLatDtp.Value.ToShortDateString();
                        break;
                    case "Lat3ActualDateLatServedOnInsurerDtp":
                        Lat3ActualDateLatServedOnInsurerTxt.Text = Lat3ActualDateLatServedOnInsurerDtp.Value.ToShortDateString();
                        break;
                    case "Lat3DeadLineToServeFileCaseConfSummaryDtp":
                        Lat3DeadLineToServeFileCaseConfSummaryTxt.Text = Lat3DeadLineToServeFileCaseConfSummaryDtp.Value.ToShortDateString();
                        break;
                    case "Lat3DeadLineToDeliverProductionsToABCounselDtp":
                        Lat3DeadLineToDeliverProductionsToABCounselTxt.Text = Lat3DeadLineToDeliverProductionsToABCounselDtp.Value.ToShortDateString();
                        break;
                    case "Lat3DeadLineToFileAffidavitReportsDtp":
                        Lat3DeadLineToFileAffidavitReportsTxt.Text = Lat3DeadLineToFileAffidavitReportsDtp.Value.ToShortDateString();
                        break;
                    case "Lat3DeadLineToFileHearingSubmissionsDtp":
                        Lat3DeadLineToFileHearingSubmissionsTxt.Text = Lat3DeadLineToFileHearingSubmissionsDtp.Value.ToShortDateString();
                        break;
                    case "Lat3DeadLineForReplaySubmissionsDtp":
                        Lat3DeadLineForReplaySubmissionsTxt.Text = Lat3DeadLineForReplaySubmissionsDtp.Value.ToShortDateString();
                        break;

                    // Campos secundarios LAT4

                    case "Lat4DateMetWithLawyerReDenialDtp":
                        Lat4DateMetWithLawyerReDenialTxt.Text = Lat4DateMetWithLawyerReDenialDtp.Value.ToShortDateString();
                        break;
                    case "Lat4InsuresResponseReceivedDtp":
                        Lat4InsuresResponseReceivedTxt.Text = Lat4InsuresResponseReceivedDtp.Value.ToShortDateString();
                        break;
                    case "Lat4DeadLineToReceiveABProductionsDtp":
                        Lat4DeadLineToReceiveABProductionsTxt.Text = Lat4DeadLineToReceiveABProductionsDtp.Value.ToShortDateString();
                        break;
                    case "Lat4DeadLineToReceiveAffidavitReportsDtp":
                        Lat4DeadLineToReceiveAffidavitReportsTxt.Text = Lat4DeadLineToReceiveAffidavitReportsDtp.Value.ToShortDateString();
                        break;
                    case "Lat4DeadLineToReceiveInsurerDtp":
                        Lat4DeadLineToReceiveInsurerTxt.Text = Lat4DeadLineToReceiveInsurerDtp.Value.ToShortDateString();
                        break;
                    case "Lat4DueDateToDiscussPotenctialLatApplDtp":
                        Lat4DueDateToDiscussPotenctialLatApplTxt.Text = Lat4DueDateToDiscussPotenctialLatApplDtp.Value.ToShortDateString();
                        break;
                    case "Lat4ProposedDateToFileLatDtp":
                        Lat4ProposedDateToFileLatTxt.Text = Lat4ProposedDateToFileLatDtp.Value.ToShortDateString();
                        break;
                    case "Lat4ActualDateLatServedOnInsurerDtp":
                        Lat4ActualDateLatServedOnInsurerTxt.Text = Lat4ActualDateLatServedOnInsurerDtp.Value.ToShortDateString();
                        break;
                    case "Lat4DeadLineToServeFileCaseConfSummaryDtp":
                        Lat4DeadLineToServeFileCaseConfSummaryTxt.Text = Lat4DeadLineToServeFileCaseConfSummaryDtp.Value.ToShortDateString();
                        break;
                    case "Lat4DeadLineToDeliverProductionsToABCounselDtp":
                        Lat4DeadLineToDeliverProductionsToABCounselTxt.Text = Lat4DeadLineToDeliverProductionsToABCounselDtp.Value.ToShortDateString();
                        break;
                    case "Lat4DeadLineToFileAffidavitReportsDtp":
                        Lat4DeadLineToFileAffidavitReportsTxt.Text = Lat4DeadLineToFileAffidavitReportsDtp.Value.ToShortDateString();
                        break;
                    case "Lat4DeadLineToFileHearingSubmissionsDtp":
                        Lat4DeadLineToFileHearingSubmissionsTxt.Text = Lat4DeadLineToFileHearingSubmissionsDtp.Value.ToShortDateString();
                        break;
                    case "Lat4DeadLineForReplaySubmissionsDtp":
                        Lat4DeadLineForReplaySubmissionsTxt.Text = Lat4DeadLineForReplaySubmissionsDtp.Value.ToShortDateString();
                        break;

                    default:
                        break;
                }
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
            using (TaskManager taskManager = new TaskManager(File))
            {
                if (taskManager.ShowDialog() == DialogResult.OK)
                {
                    RefreshActionLogDataGridViewDataSource();
                    SetStatesLawyersAndBusinessProcessDataInTaslgsFiltersComboBoxes();
                }
            }
        }
  
        private void ActionLogDataGridView_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                ActionLogDataGridView.CurrentCell = ActionLogDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Task_Actions.fileTask = _fileTaskRepository.GetById(Convert.ToInt32(ActionLogDataGridView.Rows[e.RowIndex].Cells[0].Value));
            }
        }

        private void ABOSaveButton_Click(object sender, EventArgs e)
        {
            var abOverview = FileABOverview;
            if (abOverview == null)
                abOverview = new ABOverview();
            if (FillABOverview(abOverview))
            {
                if (abOverview.ID == default)
                    _abOverviewRepository.Insert(abOverview, abOverview.File);
                else
                    _abOverviewRepository.Update(abOverview);
                LoadABOverview();
                MessageBox.Show("AB Overview has been saved.");
            }
            else
            {
                MessageBox.Show("No changes detected.");
            }


        }

        private bool FillABOverview(ABOverview abOverview)
        {
            bool update = false;
            abOverview.File = File;

            if (ABOPreJune1st2016ComboBox.SelectedItem != null)
            {
                abOverview.PolicyPreJune1st2016 = ABOPreJune1st2016ComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOOptionalBenefitsComboBox.SelectedItem != null)
            {
                abOverview.PolicyOptionalBenefits = ABOOptionalBenefitsComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOABCounselTextBox.Text != "")
            {
                abOverview.PolicyABCounsel = ABOABCounselTextBox.Text;
                update = true;
            }

            if (ABOIncomeBenefitsAppliedComboBox.SelectedItem != null)
            {
                abOverview.IncomeBenefitsApplied = ABOIncomeBenefitsAppliedComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOIncomeBenefitsTypeComboBox.SelectedItem != null)
            {
                abOverview.IncomeBenefitsType = ABOIncomeBenefitsTypeComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOIncomeBenefitsLatestOFC3TextBox.Text != "")
            {
                abOverview.IncomeBenefitsLatestOCF3 = ABOIncomeBenefitsLatestOFC3.Value;
                update = true;
            }
            if (ABOIncomeBenefitsWeeklyAmountTextBox.DollarValue != 0)
            {
                abOverview.IncomeBenefitsWeeklyAmount = ABOIncomeBenefitsWeeklyAmountTextBox.DollarValue;
                update = true;
            }
            if (ABOIncomeBenefitsDeniedComboBox.SelectedItem != null)
            {
                abOverview.IncomeBenefitsDenied = ABOIncomeBenefitsDeniedComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOIncomeBenefitsFileForLATComboBox.SelectedItem != null)
            {
                abOverview.IncomeBenefitsFiledForLAT = ABOIncomeBenefitsFileForLATComboBox.SelectedItem.ToString();
                update = true;
            }

            if (ABOInitiallyApprovedComboBox.SelectedItem != null)
            {
                abOverview.AttendantCareBenefitsInitiallyApproved = ABOInitiallyApprovedComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOIncomeBenefitsWeeklyAmountTextBox.DollarValue != 0)
            {
                abOverview.AttendantCareBenefitsInitialAmount = ABOIncomeBenefitsWeeklyAmountTextBox.DollarValue;
                update = true;
            }
            if (ABOACBeingIncurredComboBox.SelectedItem != null)
            {
                abOverview.AttendantCareBenefitsACBeingIncurred = ABOACBeingIncurredComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOWhosFundingComboBox.SelectedItem != null)
            {
                abOverview.AttendantCareBenefitsWhosFunding = ABOWhosFundingComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOLatestForm1DateTextBox.Text != "")
            {
                abOverview.AttendantCareBenefitsLatestForm1 = ABOLatestForm1Date.Value;
                update = true;
            }
            if (ABOACBAmountPaidToDateTextBox.DollarValue != 0)
            {
                abOverview.AttendantCareBenefitsAmountPaidToDate = ABOACBAmountPaidToDateTextBox.DollarValue;
                update = true;
            }

            if (ABOCurrentBenefitsLevelComboBox.SelectedItem != null)
            {
                abOverview.MedicalRehabBenefitsCurrentLevel = ABOCurrentBenefitsLevelComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOBenefitsEndDateTextBox.Text != "")
            {
                abOverview.MedicalRehabBenefitsEnd = ABOBenefitsEndDate.Value;
                update = true;
            }
            if (ABOMRBAmountPaidToDateTextBox.DollarValue != 0)
            {
                abOverview.MedicalRehabBenefitsAmountPaidToDate = ABOMRBAmountPaidToDateTextBox.DollarValue;
                update = true;
            }

            if (ABOAvailableCollateralInsuredComboBox.SelectedItem != null)
            {
                abOverview.CollateralsInsured = ABOAvailableCollateralInsuredComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOAvailableCollateralFamilyComboBox.SelectedItem != null)
            {
                abOverview.CollateralsFamily = ABOAvailableCollateralFamilyComboBox.SelectedItem.ToString();
                update = true;
            }

            if (ABOStatementDateTextBox.Text != "")
            {
                abOverview.StatementBenefitsStatementDate = ABOStatementDate.Value;
                update = true;
            }

            if (ABOGovtOntarioComboBox.SelectedItem != null)
            {
                abOverview.PotentialOffSetsGovtOntario = ABOGovtOntarioComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOGovtFederalComboBox.SelectedItem != null)
            {
                abOverview.PotentialOffSetsGovtFederal = ABOGovtFederalComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOGroupPrivateComboBox.SelectedItem != null)
            {
                abOverview.PotentialOffSetsGroupPrivate = ABOGroupPrivateComboBox.SelectedItem.ToString();
                update = true;
            }

            if (ABOCATAppliedComboBox.SelectedItem != null)
            {
                abOverview.PotentialCATApplied = ABOCATAppliedComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOCATCriteriaComboBox.SelectedItem != null)
            {
                abOverview.PotentialCATCriteria = ABOCATCriteriaComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOIEsScheduledComboBox.SelectedItem != null)
            {
                abOverview.PotentialCATIEsScheduled = ABOIEsScheduledComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOCATResultComboBox.SelectedItem != null)
            {
                abOverview.PotentialCATResult = ABOCATResultComboBox.SelectedItem.ToString();
                update = true;
            }
            if (ABOCATLATFiledComboBox.SelectedItem != null)
            {
                abOverview.PotentialCATLATFiled = ABOCATLATFiledComboBox.SelectedItem.ToString();
                update = true;
            }

            if (update)
            {
                abOverview.LastUpdatedDate = DateTime.Now;
            }
            return update;
        }

        private void TaskLogFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File != null)
            {
                RefreshActionLogDataGridViewDataSource();
                //SetStatesLawyersAndBusinessProcessDataInTaslgsFiltersComboBoxes();
            }

        }

        private void btnNewDenials_Click(object sender, EventArgs e)
        {
            if (Home.FileManager.File == null)
            {
                MessageBox.Show($"You have to select a file", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            using (DenialsForm _Denials = new DenialsForm())
            {
                if (_Denials.ShowDialog() == DialogResult.OK)
                {
                    BusquedaDenials();
                }
               
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CboxBenefitDenialsFilemanager.Text = "";
            CboxStatusDenialsFilemanager.Text = "";
            BusquedaDenials();
        }

        private void CboxsDenials_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                ComboBox cb = new ComboBox();
                cb = sender as ComboBox;
                if (!string.IsNullOrEmpty(cb.Text) && File != null)
                {
                    //ABDenialsDataGridView.DataSource = null;
                    ABDenialsDataGridView.DataSource = _DenialRepository.Search(Home.FileManager.File, denialBenefitRepository.GetByDescription(CboxBenefitDenialsFilemanager.Text), denialStatusRepository.GetByDescription(CboxStatusDenialsFilemanager.Text));
                    
                }
            }
        }

        private void PolicyParticularsSaveButton_Click(object sender, EventArgs e)
        {
            var policyParticulars = FilePolicyParticulars;
            if (policyParticulars == null)
                policyParticulars = new PolicyParticulars();
            if (FillPolicyParticulars(policyParticulars))
            {
                if (policyParticulars.ID == default)
                    _policyParticularsRepository.Insert(policyParticulars, policyParticulars.File);
                else
                    _policyParticularsRepository.Update(policyParticulars);
                LoadPolicyParticulars();
                MessageBox.Show("Policy Particulars have been saved.");
            }
            else
            {
                MessageBox.Show("No changes detected.");
            }
        }

        private bool FillPolicyParticulars(PolicyParticulars policyParticulars)
        {
            bool update = false;
            policyParticulars.File = File;

            if (PPTermsOfPolicyFromTextBox.Text != "")
            {
                policyParticulars.TermOfPolicyFrom= PPTermsOfPolicyFrom.Value;
                update = true;
            }
            if (PPTermsOfPolicyToTextBox.Text != "")
            {
                policyParticulars.TermOfPolicyTo = PPTermsOfPolicyTo.Value;
                update = true;
            }


            if (PPOPCF44RComboBox.SelectedItem != null)
            {
                policyParticulars.OPCF44R = PPOPCF44RComboBox.SelectedItem.ToString();
                update = true;
            }
            if (PPOPCF44RLiabilityLimitsTextBox.DollarValue != 0)
            {
                policyParticulars.OPCF44RLiabilityLimits = PPOPCF44RLiabilityLimitsTextBox.DollarValue;
                update = true;
            }

            if (PPUmbrellaViaAutoComboBox.SelectedItem != null)
            {
                policyParticulars.UmbrellaViaAuto = PPUmbrellaViaAutoComboBox.SelectedItem.ToString();
                update = true;
            }
            if (PPUmbrellaLiabilityLimitsTextBox.DollarValue != 0)
            {
                policyParticulars.UmbrellaViaAutoLiabilityLimits = PPUmbrellaLiabilityLimitsTextBox.DollarValue;
                update = true;
            }

            if (PPOptionalBenefitsPurchasedComboBox.SelectedItem != null)
            {
                policyParticulars.OptionalBenefitsPurchased = PPOptionalBenefitsPurchasedComboBox.SelectedItem.ToString();
                update = true;
            }
            if (PPOptionalBenefitsPurchasedDetailsTextBox.Text != "")
            {
                policyParticulars.OptionalBenefitsPurchasedDetails = PPOptionalBenefitsPurchasedDetailsTextBox.Text;
                update = true;
            }

            if (PPHomeInsurerComboBox.SelectedItem != null)
            {
                policyParticulars.ExcessHomeInsurer = PPHomeInsurerComboBox.SelectedItem as DisabilityInsuranceCompany;
                update = true;
            }
            if (PPUmbrellaCoverageComboBox.SelectedItem != null)
            {
                policyParticulars.ExcessUmbrellaCoverage = PPUmbrellaCoverageComboBox.SelectedItem.ToString();
                update = true;
            }
            if (PPCopyOfPolicyInFileComboBox.SelectedItem != null)
            {
                policyParticulars.ExcessCopyOfPolicyInFile = PPCopyOfPolicyInFileComboBox.SelectedItem.ToString();
                update = true;
            }
            if (PPCoverageAmountTextBox.DollarValue != 0)
            {
                policyParticulars.ExcessCoverageAmount = PPCoverageAmountTextBox.DollarValue;
                update = true;
            }
            return update;
        }

        private void PPOptionalBenefitsPurchasedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PPOptionalBenefitsPurchasedComboBox.SelectedItem != null)
            {
                if (PPOptionalBenefitsPurchasedComboBox.SelectedItem.ToString() == "Yes")
                {
                    PPOptionalBenefitsPurchasedDetailsGroupBox.Visible = true;
                    return;
                }
            }
            PPOptionalBenefitsPurchasedDetailsGroupBox.Visible = false;
            return;
        }

        private void Dtp_CloseUp(object sender, EventArgs e)
        {
            DtpChange(sender);
        }
    }
}
