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

        private void DidMatterProceedToHearingChB_CheckedChanged(object sender, EventArgs e)
        {
            if (DidMatterProceedToHearingChB.Checked)
            {
                HowManyHearingsLabel.Show();
                HowManyHearingsTB.Show();
            }
            else
            {
                HowManyHearingsLabel.Hide();
                HowManyHearingsTB.Hide();
            }
        }
    }
}
