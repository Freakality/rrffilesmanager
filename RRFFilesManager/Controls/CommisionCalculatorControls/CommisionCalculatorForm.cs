using RRFFilesManager.Abstractions;
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

namespace RRFFilesManager.Controls.CommisionCalculatorControls
{
    public partial class CommissionCalculatorForm : Form
    {
        //public Contact Client { get; set; }
        public File File { get; set; }
        public ComissionCalculator ComissionCalculator { get; set; }
        private readonly IComissionCalculatorRepository _comissionCalculatorRepository;
        private readonly ILawyerRepository _lawyerRepository;
        public CommissionCalculatorForm()
        {
            _comissionCalculatorRepository = Program.GetService<IComissionCalculatorRepository>();
            _lawyerRepository = Program.GetService<ILawyerRepository>();
            InitializeComponent();
            Utils.Utils.SetComboBoxDataSource(ResponsibleParalegalCB, _lawyerRepository.List(true));
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
            FileOpenDateTB.Text = File.DateOfCall.ToString("MMM-dd-yyyy");

            FileLawyerCommissionTB.Text = File.FileLawyer.ToString();
            ResponsibleLawyerCommissionTB.Text = File.ResponsibleLawyer.ToString();
            FillLawyerContractTermTB();
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
            
            if (findFileForm.SelectedFile == null)
                return;
            File = findFileForm.SelectedFile;
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
                ComissionSubTypeCB.DataSource = items.ToList();
            }
            else
            {
                ComissionSubTypeCB.DataSource = null;
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
            FillLawyerContractTermTB();
        }
        public void FillLawyerContractTermTB()
        {
            if (IsPostContract())
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
            if (string.IsNullOrWhiteSpace(FeeAmountBeforeTaxTB.Text))
                return false;
            var feeAmount = Double.Parse(FeeAmountBeforeTaxTB.Text);
            var deductibleAmount = GetDeductibleAmount();
            return deductibleAmount < feeAmount;
        }

        private void Calculate()
        {
            var comissionSubType = ComissionSubTypeCB.Text;
            var contractTerm = LawyerContractTermTB.Text;
            var isDeductibleAchieved = IsDeductibleAchieved();
            ComissionCalculator = _comissionCalculatorRepository.Get(File, comissionSubType, contractTerm, isDeductibleAchieved);
            FillDeductibleAmount();

            if (ComissionCalculator == null)
                return;

            FillFLBaseCommissionTB();
            FillFLTotalCommissionTB();

            FillRLBaseCommissionTB();
            FillRL15xDeductibleAchievedTB();
            FillRL2xDeductibleAchievedTB();
            FillRLMatterProceededToTrialTB();
            FillRLMatterProceededToHearingTB();
            FillRLTotalCommissionTB();

            FillRPBaseCommissionTB();
            FillRP15xDeductibleAchievedTB();
            FillRP2xDeductibleAchievedTB();
            FillRPMatterProceededToHearingTB();
            FillRPTotalCommissionTB();
        }

        private void FeeAmountBeforeTaxTB_TextChanged(object sender, EventArgs e)
        {

        }
        private void FillRPTotalCommissionTB()
        {
            RPTotalCommissionTB.Text = $"{GetRPTotalCommission()}";
        }

        private double? GetRPTotalCommission()
        {
            var baseComission = GetRPBaseComission() ?? 0;
            var deductibleAchievedx15Comission = GetRP15xDeductibleAchieved() ?? 0;
            var deductibleAchievedx2Comission = GetRP2xDeductibleAchieved() ?? 0;
            var toHearingComission = GetRPMatterProceededToHearing() ?? 0;
            var total = baseComission + deductibleAchievedx15Comission + deductibleAchievedx2Comission + toHearingComission;
            if (total == 0)
                return null;
            return total;
        }
        private void FillRPMatterProceededToHearingTB()
        {
            RPMatterProceededToHearingTB.Text = $"{GetRPMatterProceededToHearing()}";
        }
        private double? GetRPMatterProceededToHearing()
        {
            if (DidMatterProceedToHearingCB.Text != "Yes")
                return null;
            var multiplier = ComissionCalculator.RPMatterProceededToABHearingMultiplier;
            if (multiplier != null)
                return GetComission(multiplier);
            return null;
        }
        private void FillRP2xDeductibleAchievedTB()
        {
            RP2xDeductibleAchievedTB.Text = $"{GetRP2xDeductibleAchieved()}";
        }
        private double? GetRP2xDeductibleAchieved()
        {
            var multiplier = ComissionCalculator.RLDeductibleAchievedx2Multiplier;
            if (Is2xDeductibleAchieved && multiplier != null)
                return GetComission(multiplier);
            return null;
        }

        private void FillRP15xDeductibleAchievedTB()
        {
            RP15xDeductibleAchievedTB.Text = $"{GetRP15xDeductibleAchieved()}";
        }
        private double? GetRP15xDeductibleAchieved()
        {
            var multiplier = ComissionCalculator.RLDeductibleAchievedx1d5Multiplier;
            if (Is15xDeductibleAchieved && multiplier != null)
                return GetComission(multiplier);
            return null;
        }
        private void FillRPBaseCommissionTB()
        {
            RPBaseCommissionTB.Text = $"{GetRPBaseComission()}";
        }
        private double? GetRPBaseComission()
        {
            var multiplier = ComissionCalculator.RPBaseComissionMultiplier;
            return GetComission(multiplier);
        }

        public bool Is15xDeductibleAchieved { 
            get {
                var feeAmt = Double.Parse(FeeAmountBeforeTaxTB.Text);
                var ded = Double.Parse(DeductibleAmountTB.Text);
                var amount = feeAmt / ded;
                return amount >= 1.5 && amount < 2;
            } 
        }

        public bool Is2xDeductibleAchieved
        {
            get
            {
                var feeAmt = Double.Parse(FeeAmountBeforeTaxTB.Text);
                var ded = Double.Parse(DeductibleAmountTB.Text);
                var amount = feeAmt / ded;
                return amount >= 2;
            }
        }

        private void FillRLTotalCommissionTB()
        {
            RLTotalCommissionTB.Text = $"{GetRLTotalCommission()}";
        }
        private double? GetRLTotalCommission()
        {
            var baseComission = GetRLBaseComission() ?? 0;
            var deductibleAchievedx15Comission = GetRL15xDeductibleAchieved() ?? 0;
            var deductibleAchievedx2Comission = GetRL2xDeductibleAchieved() ?? 0;
            var toTrialComission = GetRLMatterProceededToTrial() ?? 0;
            var toHearingComission = GetRLMatterProceededToHearing() ?? 0;
            var total = baseComission + deductibleAchievedx15Comission + deductibleAchievedx2Comission + toTrialComission + toHearingComission;
            if (total == 0)
                return null;
            return total;
        }

        private void FillRLMatterProceededToHearingTB()
        {
            RLMatterProceededToHearingTB.Text = $"{GetRLMatterProceededToHearing()}";
        }
        private double? GetRLMatterProceededToHearing()
        {
            if (DidMatterProceedToHearingCB.Text != "Yes")
                return null;
            var multiplier = ComissionCalculator.RLMatterProceededToABHearingMultiplier;
            if (multiplier != null)
                return GetComission(multiplier);
            return null;
        }

        private void FillRLMatterProceededToTrialTB()
        {
            RLMatterProceededToTrialTB.Text = $"{GetRLMatterProceededToTrial()}";
        }
        private double? GetRLMatterProceededToTrial()
        {
            if (DidMatterProceedToTrialCB.Text != "Yes")
                return null;
            var multiplier = ComissionCalculator.MatterProceededToTrialMultiplier;
            if (multiplier != null)
                return GetComission(multiplier);
            return null;
        }

        private void FillRL2xDeductibleAchievedTB()
        {
            RL2xDeductibleAchievedTB.Text = $"{GetRL2xDeductibleAchieved()}";
        }
        private double? GetRL2xDeductibleAchieved()
        {
            var multiplier = ComissionCalculator.RLDeductibleAchievedx2Multiplier;
            if (Is2xDeductibleAchieved && multiplier != null)
                return GetComission(multiplier);
            return null;
        }

        private void FillRL15xDeductibleAchievedTB()
        {
            RL15xDeductibleAchievedTB.Text = $"{GetRL15xDeductibleAchieved()}";
        }
        private double? GetRL15xDeductibleAchieved()
        {
            var multiplier = ComissionCalculator.RLDeductibleAchievedx1d5Multiplier;
            if(Is15xDeductibleAchieved && multiplier != null)
                return GetComission(multiplier);
            return null;
        }

        private void FillRLBaseCommissionTB()
        {
            RLBaseCommissionTB.Text = $"{GetRLBaseComission()}";
        }

        private double? GetRLBaseComission()
        {
            var multiplier = ComissionCalculator.RLBaseComissionMultiplier;
            return GetComission(multiplier);
        }

        private double? GetComission(double? multiplier)
        {
            var commonComission = GetComissionWithoutMultiplier();
            if (multiplier != null)
                return commonComission * multiplier;
            return null;
        }

        private double? GetComissionWithoutMultiplier()
        {
            var feeAmt = Double.Parse(FeeAmountBeforeTaxTB.Text);
            var ded = Double.Parse(DeductibleAmountTB.Text);
            return (feeAmt - 0.5 * ded);
        }

        private void FillFLTotalCommissionTB()
        {
            FLTotalCommissionTB.Text = $"{GetFileLawyerBaseComission()}";
        }
        private void FillFLBaseCommissionTB()
        {
            FLBaseCommissionTB.Text = $"{GetFileLawyerBaseComission()}";
        }

        private double? GetFileLawyerBaseComission()
        {
            //if ((bool)File.FileLawyer.EarnBaseCommissionAsFileLawyer)
            //    return Double.Parse(FeeAmountBeforeTaxTB.Text) * 0.1;
            //else
            //    return 0;
            if (ComissionCalculator.FLBaseComissionMultiplier != null)
                return Double.Parse(FeeAmountBeforeTaxTB.Text) * ComissionCalculator.FLBaseComissionMultiplier.Value;
            return null;
        }

        private void FillDeductibleAmount()
        {
            DeductibleAmountTB.Text = $"{GetDeductibleAmount()}";
        }

        private double GetDeductibleAmount()
        {
            var endDate = SettlementDateDTP.Value.AddDays(30);
            if (endDate > InvoiceDateDTP.Value)
                endDate = InvoiceDateDTP.Value;
            double days = (endDate - File.DateOfCall).TotalDays;
            var months = Math.Ceiling(days / 30);
            var amount = months * 1000;
            if (File.DateOfCall.Day >= 16)
                amount -= 500;
            if(endDate.Day < 16)
                amount -= 500;
            return amount;
        }

        private double GetResponsibleLawyerBaseComission()
        {
            var feeAmount = Double.Parse(FeeAmountBeforeTaxTB.Text);
            var deductibleAmount = GetDeductibleAmount();
            var isDeductibleAchieved = IsDeductibleAchieved();
            var isPostContract = IsPostContract();
            var multiplier = 0.1;
            if(ComissionSubTypeCB.Text == "MVA Tort Only")
            {
                multiplier /= 2;
            }
            if (!isDeductibleAchieved)
            {
                multiplier /= 2;
            }
            if (!isPostContract)
            {
                multiplier /= 2;
            }
            return feeAmount - 0.5 * deductibleAmount * multiplier;
        }

        private void SettlementDateDTP_ValueChanged(object sender, EventArgs e)
        {
            FillDeductibleAmount();
        }

        private void InvoiceDateDTP_ValueChanged(object sender, EventArgs e)
        {
            FillDeductibleAmount();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Close();
            Home.Instance.Show();
        }

        private void ResponsibleParalegalCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResponsibleParalegalCommissionTB.Text = ResponsibleParalegalCB.Text;
        }

        private void ComissionSubTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
