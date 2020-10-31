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
        private PreliminaryInfo preliminaryInfo;
        public PreliminaryInfo PreliminaryInfo => preliminaryInfo ?? (preliminaryInfo = new PreliminaryInfo());

        private PotentialClientInfo potentialClientInfo;
        public PotentialClientInfo PotentialClientInfo => potentialClientInfo ?? (potentialClientInfo = new PotentialClientInfo());

        private IntakeSheets intakeSheets;
        public IntakeSheets IntakeSheets => intakeSheets ?? (intakeSheets = new IntakeSheets());

        private NextSteps nextSteps;
        public NextSteps NextSteps => nextSteps ?? (nextSteps = new NextSteps());

        private ClientIntakeProcess clientIntakeProcess;
        public ClientIntakeProcess ClientIntakeProcess => clientIntakeProcess ?? (clientIntakeProcess = new ClientIntakeProcess());
        public IntakeForm()
        {
            InitializeComponent();
        }

        private Intake intake;
        public Intake Intake => intake ?? (intake = new Intake());
        public void SetIntake(Intake intake)
        {
            Home.IntakeForm.intake = intake;
            PreliminaryInfo.FillForm(intake);
            PotentialClientInfo.FillForm(intake);
            IntakeSheets.FillForm(intake);
        }
        private void Intake_Load(object sender, EventArgs e)
        {
            this.SetContent(PreliminaryInfo);
            this.BackButton.Visible = false;
        }

        private void SetContent(Control control)
        {
            this.Content.Controls.Clear();
            this.Content.Controls.Add(control);
            Content.Controls[0].Dock = DockStyle.Fill;
        }

        private void Intake_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }


        private void NextButton_Click(object sender, EventArgs e)
        {
            var contentType = Content.Controls[0].GetType();

            if (contentType == typeof(PreliminaryInfo) && PreliminaryInfo.Validate())
            {
                BackButton.Visible = true;
                SetContent(PotentialClientInfo);
                PreliminaryInfo.OnNext();
            }
            else if (contentType == typeof(PotentialClientInfo) && PotentialClientInfo.Validate())
            {
                IntakeSheets.BringMattertypeForm();
                SetContent(IntakeSheets);
                PotentialClientInfo.OnNext();
            }
            else if (contentType == typeof(IntakeSheets) && IntakeSheets.Validate())
            {
                NextButton.Visible = false;
                SetContent(NextSteps);
                IntakeSheets.OnNext();
            }
            else if (contentType == typeof(NextSteps) && NextSteps.Validate())
            {
                NextButton.Visible = false;
                SetContent(ClientIntakeProcess);
                NextSteps.OnNext();
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var contentType = Content.Controls[0].GetType();

            if (contentType == typeof(PotentialClientInfo))
            {
                BackButton.Visible = false;
                SetContent(PreliminaryInfo);
            }
            else if (contentType == typeof(IntakeSheets))
            {
                SetContent(PotentialClientInfo);
            }
            else if (contentType == typeof(NextSteps))
            {
                NextButton.Visible = true;
                SetContent(IntakeSheets);
            }
            else if (contentType == typeof(ClientIntakeProcess))
            {
                NextButton.Visible = true;
                SetContent(NextSteps);
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

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
