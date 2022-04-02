using RRFFilesManager.Abstractions;
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
        public bool SettingFile = false;
        public readonly PeopleControl PeopleControl;
        public readonly MedicalBinderIndexControl MedicalBinderIndexControl;
        public readonly PrescriptionSummariesControl PrescriptionSummariesControl;
        public readonly ABBinderControl ABBinderControl;
        public readonly StandardBenefitStatementsControl StandardBenefitStatementsControl;
        public readonly StandardBenefitStatementsControl QuickABPaidToDateControl;
        private readonly IFileRepository _fileRepository;
        public SemiAnnualFileReviewControl SemiAnnualFileReviewControlAction;
        public SemiAnnualFileReviewControl SemiAnnualFileReviewControlAccidentBenefits;
        public TabPage SemiAnnualFileReviewTabAction = new TabPage("Semi-Annual File Review");
        public TabPage SemiAnnualFileReviewTabAccidentBenefits = new TabPage("Semi-Annual File Review");
        public FileManager()
        {
            _fileRepository = Program.GetService<IFileRepository>();
            InitializeComponent();
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
    }
}
