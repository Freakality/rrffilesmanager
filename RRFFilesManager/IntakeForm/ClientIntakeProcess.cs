using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRFFilesManager.Logic;
using Westwind.RazorHosting;

namespace RRFFilesManager.IntakeForm
{
    public partial class ClientIntakeProcess : UserControl
    {
        public ClientIntakeProcess()
        {
            InitializeComponent();
        }

        public new bool Validate()
        {
            if (string.IsNullOrEmpty(this.NeedOnlineQues.Text))
            {
                MessageBox.Show("Please enter Need Online Ques before booking?");
                return false;
            }

            if (string.IsNullOrEmpty(this.DateApptScheduled.Text))
            {
                MessageBox.Show("Please enter Date Appt Scheduled");
                return false;
            }

            if (string.IsNullOrEmpty(this.TimeOfAppt.Text))
            {
                MessageBox.Show("Please enter Time of Appt");
                return false;
            }
            if (NeedOnlineQues.Text == "No")
            {
                if (string.IsNullOrEmpty(this.ApptType.Text))
                {
                    MessageBox.Show("Please enter Appt Type");
                    return false;
                }
                if (ApptType.Text == "In Office" && string.IsNullOrEmpty(this.TimeOfAppt.Text))
                {
                    MessageBox.Show("Please enter Time Frame");
                    return false;
                }
            }
            return true;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;
            Home.IntakeForm.Hide();
            Submitting.Instance.Show();
            try
            {
                SendCIPEmail();
                SendTemplateEmail();
                IntakeManager.SetHoldIntake(Home.IntakeForm.Intake, false);
                Submitting.Instance.Hide();
                Home.IntakeForm.Close();
                Home.Instance.Show();
            }
            catch (System.Exception exception)
            {
                MessageBox.Show(exception.Message);
                Submitting.Instance.Hide();
                Home.IntakeForm.Show();
            }
        }

        private void SendCIPEmail()
        {
            var attachmentPath = IntakeManager.CreateOrUpdateIntakeWorkBook(Home.IntakeForm.Intake);
            string clientFullName = $"{Home.IntakeForm.Intake.Client?.LastName}, {Home.IntakeForm.Intake.Client?.FirstName}";
            string[] to = new string[] { "DManzano@InjuryLawyerCanada.com"};
            var subject = $"Client Intake Process Invoked - {clientFullName}";
            var body = "";
            Outlook.NewEmail(to, subject, body, new[] { attachmentPath });
        }

        private void SendTemplateEmail()
        {
            var subject = "Meeting with Roger R Foisy & Associates";
            string template = "";
            if (NeedOnlineQues.Text == "Yes")
            {
                //Template 6
                subject = "Pre-Interview Questionnaire – Roger R Foisy & Associates";
                template = "Template 6 - Must Complete Questionnaire Before Booking Appointment.html";
            }
            else if (ApptType.Text == "In Office")
            {
                if (TimeFrame.Text == "During Business Hours")
                {
                    //Template 1
                    template = "Template 1 - In Office Meeting During Business Hours.html";
                }
                else if (TimeFrame.Text == "During Off Hours")
                {
                    //Template 2
                    template = "Template 2 - In Office Meeting During Off Hours.html";

                }
                else if (TimeFrame.Text == "Weekend")
                {
                    //Template 3
                    template = "Template 3 - In Office Meeting - Weekend.html";
                }
            }
            else if (ApptType.Text == "Virtual")
            {
                //Template 4
                template = "Template 4 - Virtual Meeting.html";
            }
            else if (ApptType.Text == "Out of Office")
            {
                //Template 5
                template = "Template 5 - Out of Office Meeting.html";
            }
            RazorFolderHostContainer host = new RazorFolderHostContainer();
            //host.ReferencedAssemblies.Add("NotificationsManagement.dll");
            host.TemplatePath = $"{AppDomain.CurrentDomain.BaseDirectory}\\Templates";
            host.Start();
            var body = host.RenderTemplate(template, new {
                Intake = Home.IntakeForm.Intake,
                DateApptScheduled = DateApptScheduled.Value,
                DateApptScheduledNextBusinessDay = DateApptScheduled.Value.AddDays(-1),
                TimeOfAppt = TimeOfAppt.Value,
            });
            string receip = "rojascarlos82@hotmail.com";
            Outlook.NewEmail(receip, subject, body);
        }

        private void NeedOnlineQues_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ApptType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeFrame.Enabled = ApptType.Text == "In Office";
        }
    }
}
