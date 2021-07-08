using RRFFilesManager.Abstractions;
using RRFFilesManager.Controls.FileControls;
using RRFFilesManager.Controls.FileControls.UserControls;
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
        public readonly PeopleControl PeopleControl;
        public readonly MedicalBinderIndexControl MedicalBinderIndexControl;
        public readonly PrescriptionSummariesControl PrescriptionSummariesControl;
        public readonly ABBinderControl ABBinderControl;
        public FileManager()
        {
            InitializeComponent();
            PeopleControl = new PeopleControl();
            Utils.Utils.SetContent(PeopleTab, PeopleControl);

            MedicalBinderIndexControl = new MedicalBinderIndexControl();
            Utils.Utils.SetContent(MedicalBinderIndexTab, MedicalBinderIndexControl);

            PrescriptionSummariesControl = new PrescriptionSummariesControl();
            Utils.Utils.SetContent(PrescriptionSummariesTab, PrescriptionSummariesControl);

            ABBinderControl = new ABBinderControl();
            Utils.Utils.SetContent(ABBinderTab, ABBinderControl);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Close();
            Home.Instance.Show();
        }

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
            SetForm(File);
        }

        private void SetForm(File file)
        {
            if(file == null)
                return;
            PeopleControl.SetFile(file);
            ABBinderControl.SetFile(file);

            MedicalBinderIndexControl.SetFile(file);
            PrescriptionSummariesControl.SetFile(file);

            ClientNameTextBox.Text = file.Client.ToString();
            MatterTypeTextBox.Text = file.MatterType.ToString();
            FileNumberTextBox.Text = file.FileNumber.ToString();
            DateOfLossTextBox.Text = file.DateOFLoss.ToString("d");
            LimDateTextBox.Text = file.LimitationPeriod;
            FileOpenDateTextBox.Text = file.DateOfCall.ToString("d");

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
    }
}
