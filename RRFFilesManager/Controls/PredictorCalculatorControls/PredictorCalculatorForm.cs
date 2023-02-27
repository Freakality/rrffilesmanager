using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.PredictorCalculatorControls
{
    public partial class PredictorCalculatorForm : Form
    {
        public double ProjectedSettlementDays => matterTypeComboBox1.MatterType.ProjectedSettlementDays
                                                    ?? comissionSubTypeComboBox1.ComissionSubType.ProjectedSettlementDays;
        public bool semiannual = false;
        public bool Transferring = false;
        public SemiAnnualData SemiAnnualData = new SemiAnnualData();
        public DateTime ProjectedSettlementDate
        {
            get
            {
                if (SettlementDateTB.Text == "TO BE DETERMINED") {
                    var days = ((((ProjectedSettlementAmount - ProjectedDisbursementsAmount) * ContigencyFee) - (DeductibleAmount * (ProjectedProfit + 1))) / 1000) * 30;
                    //var result 
                    return FileOpenDateDTP.Value.AddDays(ProjectedSettlementDays + days);
                }
                return FileOpenDateDTP.Value.AddDays(ProjectedSettlementDays);
            }
        }

        public double DeductibleAmount => ProjectedSettlementDays / 30 * 1000;
        public double DefaultContigencyFee => matterTypeComboBox1.MatterType.ContigencyFee
                                                    ?? comissionSubTypeComboBox1.ComissionSubType.ContigencyFee;
        public double ChooseContigencyFee => double.TryParse(ContingencyFeeCB.Text.Replace("%", ""), out double value) ? value / 100 : 0;
        public double ContigencyFee => ContingencyFeeTypeCB.Text == "Choose CF%" ? ChooseContigencyFee : DefaultContigencyFee;
        public double ProjectedSettlementAmount {
            get
            {
                if (SettlementAmountTB.Text.Contains("TO BE DETERMINED"))
                    return (DeductibleAmount * (ProjectedProfit + 1) / ContigencyFee) + ProjectedDisbursementsAmount;
                return double.TryParse(SettlementAmountTB.DollarValue.ToString(), out double value) ? value : 0;
            }
        }
        public double ProjectedDisbursementsAmount => matterTypeComboBox1.MatterType.ProjectedDisbursementsAmount
                                                   ?? comissionSubTypeComboBox1.ComissionSubType.ProjectedDisbursementsAmount;
        public double ProjectedFees => (ProjectedSettlementAmount - ProjectedDisbursementsAmount) * ContigencyFee;
        public double ProjectedProfit
        {
            get
            {
                if (ProfitPredictorCB.Text.Contains("TO BE DETERMINED"))
                    return (ProjectedSettlementAmount - ProjectedDisbursementsAmount) * ContigencyFee / DeductibleAmount - 1;
                return double.TryParse(ProfitPredictorCB.Text.Replace("%", ""), out double value) ? value / 100 : 0;
            }
        }

        public PredictorCalculatorForm()
        {
            InitializeComponent();
            ContingencyFeeTypeCB_SelectedIndexChanged(null, null);
            if (semiannual)
                TransferButton.Visible = true;
            else
                TransferButton.Visible = false;
        }

        public PredictorCalculatorForm(File file, bool state)
        {
            InitializeComponent();
            ContingencyFeeTypeCB_SelectedIndexChanged(null, null);
            matterTypeComboBox1.SelectedItem = file.MatterType;
            comissionSubTypeComboBox1.SelectedItem = file.SubTypeCategory;
            matterTypeComboBox1.Enabled = false;
            FileOpenDateDTP.Value = file.DateOfCall;
            FileOpenDateDTP.Enabled = false;
            semiannual = state;
        }

        private void matterTypeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comissionSubTypeComboBox1.MatterType = matterTypeComboBox1.MatterType;
        }

        private void ContingencyFeeTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ContingencyFeeCB.Visible = ContingencyFeeTypeCB.Text == "Choose CF%";
            tableLayoutPanel2.SetColumnSpan(ContingencyFeeTypeCB, ContingencyFeeCB.Visible ? 1: 2);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var control = GetCalculateWhatControl();
            UndoToBeDetermined(ProfitPredictorCB);
            UndoToBeDetermined(SettlementAmountTB);
            UndoToBeDetermined(SettlementDateTB);
            SettlementDateTB.Enabled = false;
            SetToBeDetermined(control);
            //ProfitPredictorCB.Enabled = false;
            //if (CalculateWhatCB.Text == "Settlement Amount")
            //    ProfitPredictorCB.Enabled = true;
        }
        private Control GetCalculateWhatControl()
        {
            switch (CalculateWhatCB.Text)
            {
                case "Profit Predictor":
                    return ProfitPredictorCB;
                case "Settlement Amount":
                    return SettlementAmountTB;
                case "Settlement Date":
                    return SettlementDateTB;
                default:
                    return null;
            };
        }
        private void SetToBeDetermined(Control control)
        {
            control.Text = "TO BE DETERMINED";
            control.Enabled = false;
        }
        private void UndoToBeDetermined(Control control)
        {
            control.ResetText();
            control.Enabled = true;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            FileOpenDateTB.Text = FileOpenDateDTP.Value.ToString("MMM-dd-yyyy");
            ProjectedSettlementDateTB.Text = ProjectedSettlementDate.ToString("MMM-dd-yyyy");
            DeductibleAmountTB.Text = $"$ {DeductibleAmount:0.00}";
            ContingencyFeeTB.Text = $"{ContigencyFee * 100:0.00}%";
            ProjectedSettlementAmountTB.Text = $"$ {ProjectedSettlementAmount:0.00}";
            ProjectedDisbursementsTB.Text = $"$ {ProjectedDisbursementsAmount:0.00}";
            ProjectedFeesTB.Text = $"$ {ProjectedFees:0.00}";
            ProjectedProfitTB.Text = $"{ProjectedProfit * 100:0.00}%";

            if (ProjectedProfit >= 0.4)
                ProjectedProfitTB.BackColor = Color.FromArgb(146, 208, 80);
            else if (ProjectedProfit >= 0.2 && ProjectedProfit < 0.4)
                ProjectedProfitTB.BackColor = Color.FromArgb(198,224,180);
            else if (ProjectedProfit >= 0 && ProjectedProfit < 0.2)
                ProjectedProfitTB.BackColor = Color.Yellow;
            else if (ProjectedProfit < 0)
                ProjectedProfitTB.BackColor = Color.FromArgb(255, 80, 80);
        }

        private void PredictorCalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (semiannual)
            {
                SemiAnnualData.ProjectedSettlementAmount = ProjectedSettlementAmountTB.Text;
                SemiAnnualData.ProjectedDisbursements = ProjectedDisbursementsTB.Text;
                SemiAnnualData.ProjectedFees = ProjectedFeesTB.Text;
                SemiAnnualData.ProjectedProfit = ProjectedProfitTB.Text;
                if (!String.IsNullOrEmpty(ProjectedSettlementDateTB.Text))
                    SemiAnnualData.ProjectedSettlementDate = Convert.ToDateTime(ProjectedSettlementDateTB.Text);
                semiannual = false;
            }
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
            Transferring = true;
            Close();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Close();
            Home.Instance.Show();
        }
    }

    public class SemiAnnualData
    {
        public string ProjectedSettlementAmount { get; set; }
        public string ProjectedDisbursements { get; set; }
        public string ProjectedFees { get; set; }
        public string ProjectedProfit { get; set; }
        public DateTime ProjectedSettlementDate { get; set; }
    }
}
