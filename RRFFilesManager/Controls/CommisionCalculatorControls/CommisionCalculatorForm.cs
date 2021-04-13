using RRFFilesManager.Abstractions;
using RRFFilesManager.FileControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.CommisionCalculatorControls
{
    public partial class CommissionCalculatorForm : Form
    {
        //public Contact Client { get; set; }
        public File File { get; set; }
        public CommissionCalculatorForm()
        {
            InitializeComponent();
        }

        public void FillForm(Contact Client)
        {
            ClientBox.Text = Client.ToString();
        }
        public void FillForm(Intake intake)
        {
            
        }

        public void FillForm(File File)
        {
            FileBox.Text = File.ToString();
            MatterTypeBox.Text = File.MatterType.ToString();
            FileLawyerTB.Text = File.FileLawyer.ToString();
            ResponsibleLawyerTB.Text = File.ResponsibleLawyer.ToString();
            FileOpenDateTB.Text = File.DateOfCall.ToString();

            FileLawyerCommissionTB.Text = File.FileLawyer.ToString();
            ResponsibleLawyerCommissionTB.Text = File.ResponsibleLawyer.ToString();
            FillForm(File.Client);
            FillForm(File.Intake);
        }

        //private void FindClientButton_Click(object sender, EventArgs e)
        //{
        //    FindClient.Instance.Show();
        //    FindClient.Instance.FormClosing += new FormClosingEventHandler(FindClient_FormClosing);
        //}

        //private void FindClient_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    var findClientForm = sender as FindClient;
        //    Client = findClientForm.SelectedClient;
        //    FillForm(Client);
        //}

        private void FindFileButton_Click(object sender, EventArgs e)
        {
            FindFile.Instance.Show();
            FindFile.Instance.FormClosing += new FormClosingEventHandler(FindFile_FormClosing);
        }

        private void FindFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findFileForm = sender as FindFile;
            File = findFileForm.SelectedFile;
            if (File == null)
                return;
            FillForm(File);
        }

        private void CommissionCalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Home.Instance.Show();
        }

        private void MatterTypeBox_TextChanged(object sender, EventArgs e)
        {
            if(MatterTypeBox.Text == "Motor Vehicle Accident")
            {
                var items = new string[] {
                    "MVA Tort Only",
                    "MVA Tort",
                    "MVA AB",
                    "AB Only"
                };
                CommissionSubTypeCB.DataSource = items.ToList();
            }
            else
            {
                CommissionSubTypeCB.DataSource = null;
            }
        }

        private void DidMatterProceedToHearingCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DidMatterProceedToHearingCB.Text == "Yes")
            {
                HowManyHearingsLabel.Show();
                HowManyHearingsCB.Show();
            }
            else
            {
                HowManyHearingsLabel.Hide();
                HowManyHearingsCB.Hide();
            }
        }

        private void FileLawyerTB_TextChanged(object sender, EventArgs e)
        {
            if(IsPostContract())
            {
                LawyerContractTermTB.Text = "Post Contract";
            }
            else
            {
                LawyerContractTermTB.Text = "Pre-Contract";
            }
        }

        private bool IsPostContract()
        {
            return File.FileLawyer.ContractDate == null || File.DateOfCall >= File.FileLawyer.ContractDate;
        }
        private bool IsDeductibleAchieved()
        {
            var feeAmount = Double.Parse(FeeAmountBeforeTaxTB.Text);
            var deductibleAmount = GetDeductibleAmount();
            return deductibleAmount < feeAmount;
        }

        private void Calculate()
        {
            FillFLBaseCommissionTB();
            FillDeductibleAmount();

        }

        private void FeeAmountBeforeTaxTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FillFLBaseCommissionTB()
        {
            FLBaseCommissionTB.Text = $"{GetFileLawyerBaseComission()}";
        }

        private double GetFileLawyerBaseComission()
        {
            if ((bool)File.FileLawyer.EarnBaseCommissionAsFileLawyer)
                return Double.Parse(FeeAmountBeforeTaxTB.Text) * 0.1;
            else
                return 0;
        }

        private void FillDeductibleAmount()
        {
            DeductibleAmountTB.Text = $"{GetDeductibleAmount()}";
        }

        private double GetDeductibleAmount()
        {
            var minDate = SettlementDateDTP.Value.AddDays(30);
            if (minDate > InvoiceDateDTP.Value)
                minDate = InvoiceDateDTP.Value;
            double days = (minDate - File.DateOfCall).TotalDays;
            var months = Math.Ceiling(days / 30);
            var amount = months * 1000;
            if (File.DateOfCall.Day > 16)
                amount -= 500;
            if(minDate.Day < 16)
                amount -= 500;
            return amount;
        }

        private double GetResponsibleLawyerBaseComission()
        {
            var feeAmount = Double.Parse(FeeAmountBeforeTaxTB.Text);
            var deductibleAmount = GetDeductibleAmount();
            var isDeductibleAchieved = IsDeductibleAchieved();
            var isPostContract = IsPostContract();
            var multiplier = 0.5;
            if (!isDeductibleAchieved)
            {
                multiplier /= 2;
            }
            return feeAmount - 0.5 * deductibleAmount * multiplier;
        }

        private void SettlementDateDTP_ValueChanged(object sender, EventArgs e)
        {
            //FillDeductibleAmount();
        }

        private void InvoiceDateDTP_ValueChanged(object sender, EventArgs e)
        {
            //FillDeductibleAmount();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
