using Microsoft.Office.Interop.Outlook;
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

namespace RRFFilesManager.IntakeForm
{
    public partial class IntakeForm : Form
    {
        public IntakeForm()
        {
            InitializeComponent();
        }

        private static IntakeForm instance;
        public static IntakeForm Instance => instance ?? (instance = new IntakeForm());

        private static Intake intake;
        public static Intake Intake => intake ?? (intake = new Intake());

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
    }
}
