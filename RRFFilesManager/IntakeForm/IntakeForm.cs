using Microsoft.Office.Interop.Outlook;
using RRFFilesManager.Abstractions;
using RRFFilesManager.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.IntakeForm
{
    public partial class IntakeForm : Form
    {
        public IntakeForm()
        {
            InitializeComponent();
        }

        private static IntakeForm instance;
        public static IntakeForm Instance => instance == null || instance.IsDisposed ? (instance = new IntakeForm()) : instance ;

        private static Intake intake;
        public static Intake Intake => intake ?? (intake = new Intake());
        public void SetIntake(Intake intake)
        {
            IntakeForm.intake = intake;
            PreliminaryInfo.Instance.FillForm(intake);
            PotentialClientInfo.Instance.FillForm(intake);
            IntakeSheets.Instance.FillForm(intake);
        }
        private void Intake_Load(object sender, EventArgs e)
        {
            this.SetContent(PreliminaryInfo.Instance);
            this.BackButton.Visible = false;
        }

        private void SetContent(Control control)
        {
            this.Content.Controls.Clear();
            this.Content.Controls.Add(control);
        }

        private void Intake_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }


        private void NextButton_Click(object sender, EventArgs e)
        {
            var contentType = Content.Controls[0].GetType();

            if (contentType == typeof(PreliminaryInfo) && PreliminaryInfo.Instance.Validate())
            {
                BackButton.Visible = true;
                SetContent(PotentialClientInfo.Instance);
                PreliminaryInfo.Instance.OnNext();
            }
            else if (contentType == typeof(PotentialClientInfo) && PotentialClientInfo.Instance.Validate())
            {
                IntakeSheets.Instance.BringMattertypeForm();
                SetContent(IntakeSheets.Instance);
                PotentialClientInfo.Instance.OnNext();
            }
            else if (contentType == typeof(IntakeSheets) && IntakeSheets.Instance.Validate())
            {
                NextButton.Visible = false;
                SetContent(NextSteps.Instance);
                IntakeSheets.Instance.OnNext();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var contentType = Content.Controls[0].GetType();

            if (contentType == typeof(PotentialClientInfo))
            {
                BackButton.Visible = false;
                SetContent(PreliminaryInfo.Instance);
            }
            else if (contentType == typeof(IntakeSheets))
            {
                SetContent(PotentialClientInfo.Instance);
            }
            else if (contentType == typeof(NextSteps))
            {
                NextButton.Visible = true;
                SetContent(IntakeSheets.Instance);
            }
        }

        private void ConflictChecksButton_Click(object sender, EventArgs e)
        {
            CNSignOn.StartProcess();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Close();
            Home.Instance.Show();
        }
    }
}
