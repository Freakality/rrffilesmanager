using RRFFilesManager.Abstractions;
using RRFFilesManager.Controls.PredictorCalculatorControls;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.FileControls.UserControls
{
    public partial class FileReviewTabControl : UserControl
    {
        private File File;
        private DateTime ReviewDate;
        private Byte Status;
        private FileReview TabReview;
        private readonly IFileReviewRepository _fileReviewRepository;
        private bool projectedatechanged = false;
        public FileReviewTabControl(File file, DateTime reviewDate, Byte status)
        {
            _fileReviewRepository = Program.GetService<IFileReviewRepository>();
            InitializeComponent();
            File = file;
            ReviewDate = reviewDate;
            Status = status;
            FillFields();
        }

        private void FillFields()
        {
            if (File == null)
                return;
            var results = _fileReviewRepository.Search(File, ReviewDate, Status, 1);
            if (results.Count() > 0)
                TabReview = results.FirstOrDefault();
            if (TabReview == null)
            {
                TabReview = new FileReview();
                TabReview.File = File;
                TabReview.FRDate = ReviewDate;
                TabReview.FRActionABenefitsStatus = Status;
                return;
            }
            TBoxLiabilityIssuesTextBox.Text = TabReview.FRLiabilityIssues;
            TBoxCausationIssuesTextBox.Text = TabReview.FRCausationIssues;
            TBoxDamageIssuesTextBox.Text = TabReview.FRDamagesIssues;
            TBoxFileProgressionConsiderationsTextBox.Text = TabReview.FRFileProgressionConsiderations;
            DPickProjectedSettlementDateDateTimePicker.Value = TabReview.FRProjectedSettlementDate;
            TBoxProjectedSettlementValueTextBox.Text = TabReview.FRProjectedSettlementValue;
            TBoxProjectedDisbursementsTextBox.Text = TabReview.FRProjectedDisbursements;
            TBoxCurrentDisbursementsTextBox.Text = TabReview.FRCurrentDisbursements;
            TBoxProjectedFeesTextBox.Text = TabReview.FRProjectedFees;
            TBoxProjectedProfitMarginTextBox.Text = TabReview.FRProjectedProfitMargin;
            TBoxOtherNotesTextBox.Text = TabReview.FROtherNotes;
        }

        public void FillOrCreateFileReview()
        {
            bool filled = FillReview(TabReview);
            if (TabReview.ID == default)
            {
                if (filled)
                    _fileReviewRepository.Insert(TabReview, TabReview.File);
            }
            else
                _fileReviewRepository.Update(TabReview);
        }

        private bool FillReview(FileReview fileReview)
        {
            bool filled = false;
            if (!String.IsNullOrEmpty(TBoxLiabilityIssuesTextBox.Text))
            {
                fileReview.FRLiabilityIssues = TBoxLiabilityIssuesTextBox.Text;
                filled = true;
            }
            if (!String.IsNullOrEmpty(TBoxCausationIssuesTextBox.Text))
            {
                fileReview.FRCausationIssues = TBoxCausationIssuesTextBox.Text;
                filled = true;
            }
            if (!String.IsNullOrEmpty(TBoxDamageIssuesTextBox.Text))
            {
                fileReview.FRDamagesIssues = TBoxDamageIssuesTextBox.Text;
                filled = true;
            }
            if (!String.IsNullOrEmpty(TBoxFileProgressionConsiderationsTextBox.Text))
            {
                fileReview.FRFileProgressionConsiderations = TBoxFileProgressionConsiderationsTextBox.Text;
                filled = true;
            }

                fileReview.FRProjectedSettlementDate = DPickProjectedSettlementDateDateTimePicker.Value;
                //filled = true;
            if (!String.IsNullOrEmpty(TBoxProjectedSettlementValueTextBox.Text))
            {
                fileReview.FRProjectedSettlementValue = TBoxProjectedSettlementValueTextBox.Text;
                filled = true;
            }
            if (!String.IsNullOrEmpty(TBoxProjectedDisbursementsTextBox.Text))
            {
                fileReview.FRProjectedDisbursements = TBoxProjectedDisbursementsTextBox.Text;
                filled = true;
            }
            if (!String.IsNullOrEmpty(TBoxCurrentDisbursementsTextBox.Text))
            {
                fileReview.FRCurrentDisbursements = TBoxCurrentDisbursementsTextBox.Text;
                filled = true;
            }
            if (!String.IsNullOrEmpty(TBoxProjectedFeesTextBox.Text))
            {
                fileReview.FRProjectedFees = TBoxProjectedFeesTextBox.Text;
                filled = true;
            }
            if (!String.IsNullOrEmpty(TBoxProjectedProfitMarginTextBox.Text))
            {
                fileReview.FRProjectedProfitMargin = TBoxProjectedProfitMarginTextBox.Text;
                filled = true;
            }
            if (!String.IsNullOrEmpty(TBoxOtherNotesTextBox.Text))
            {
                fileReview.FROtherNotes = TBoxOtherNotesTextBox.Text;
                filled = true;
            }
            return filled;
        }
        private void CalculatorFileReviewButton_Click(object sender, EventArgs e)
        {
            /*DateTime fileopendate = File.DateOfCall;
            string mattertype = File.MatterType.ToString();*/
            PredictorCalculatorControls.PredictorCalculatorForm pcf = new PredictorCalculatorControls.PredictorCalculatorForm(File, true);
            pcf.FormClosing += PredictorCalculatorForm_FormClosing2;
            pcf.ShowDialog();
        }

        private void PredictorCalculatorForm_FormClosing2(object sender, FormClosingEventArgs e)
        {
            var form = (PredictorCalculatorForm)sender;
            if (form.Transferring)
            {
                TBoxProjectedSettlementValueTextBox.Text = form.SemiAnnualData.ProjectedSettlementAmount;
                TBoxProjectedDisbursementsTextBox.Text = form.SemiAnnualData.ProjectedDisbursements;
                TBoxProjectedFeesTextBox.Text = form.SemiAnnualData.ProjectedFees;
                TBoxProjectedProfitMarginTextBox.Text = form.SemiAnnualData.ProjectedProfit;
                if (form.SemiAnnualData.ProjectedSettlementDate != default(DateTime))
                    DPickProjectedSettlementDateDateTimePicker.Value = form.SemiAnnualData.ProjectedSettlementDate;
            }
        }
    }
}
