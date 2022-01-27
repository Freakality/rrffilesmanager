using RRFFilesManager.Abstractions;
using RRFFilesManager.Controls.PredictorCalculatorControls;
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
    public partial class SemiAnnualFileReviewControl : UserControl
    {
        public File File 
        { 
            get => file; 
            set {
                file = value;
                InitTabs();
            } 
        }

        private File file;
        private Byte Status;
        public SemiAnnualFileReviewControl(Byte status)
        {
            InitializeComponent();
            Status = status;
        }

        public void InitTabs()
        {
            foreach (TabPage oldpage in TabControlFR.TabPages)
            {
                TabControlFR.TabPages.Remove(oldpage);
            }
            DateTime initiald = File.DateOfCall;
            /*foreach (TabPage tab in TabControlFR.TabPages)
            {
                if (tab.Name != "FileOpeningReview")
                {*/
            int reviewCount = 10;
            for (int i = 0; i <= reviewCount; i++)
            {
                string tabName = initiald.ToString("MM/dd/yy") + " Review";
                if (i == 0)
                {
                    tabName = "File Opening Review";
                }
                TabPage FileReviewTab = new TabPage(tabName);
                TabControlFR.TabPages.Add(FileReviewTab);
                //tab.Text = initiald.ToString("MM/dd/yy") + " Review";
                FileReviewTabControl FileReviewTabControl = new FileReviewTabControl(File, initiald, Status);
                Utils.Utils.SetContent(FileReviewTab, FileReviewTabControl);
                initiald = initiald.AddMonths(6);
            }      
                /*}
            }*/
        }

        private void CalculatorFileReviewButton_Click(object sender, EventArgs e)
        {

        }

        private void ReviewDoneSaveButton_Click(object sender, EventArgs e)
        {
            foreach (TabPage reviewTab in TabControlFR.TabPages)
            {
                (reviewTab.Controls[0] as FileReviewTabControl).FillOrCreateFileReview();
            }
            MessageBox.Show("Reviews updated.");
        }

        /*private void CalculatorFileReviewButton_Click(object sender, EventArgs e)
        {
            DateTime fileopendate = File.DateOfCall;
            string mattertype = File.MatterType.ToString();
            PredictorCalculatorControls.PredictorCalculatorForm pcf = new PredictorCalculatorControls.PredictorCalculatorForm(fileopendate, mattertype, true);
            pcf.FormClosing += PredictorCalculatorForm_FormClosing2;
            pcf.ShowDialog();
        }

        private void PredictorCalculatorForm_FormClosing2(object sender, FormClosingEventArgs e)
        {
            var form = (PredictorCalculatorForm)sender;
            TBoxProjectedSettlementValueTextBox.Text = form.SemiAnnualData.ProjectedSettlementAmount;
            TBoxProjectedDisbursementsTextBox.Text = form.SemiAnnualData.ProjectedDisbursements;
            TBoxProjectedFeesTextBox.Text = form.SemiAnnualData.ProjectedFees;
            TBoxProjectedProfitMarginTextBox.Text = form.SemiAnnualData.ProjectedProfit;
            DPickProjectedSettlementDateDateTimePicker.Value = form.SemiAnnualData.ProjectedSettlementDate;
        }*/


    }
}
