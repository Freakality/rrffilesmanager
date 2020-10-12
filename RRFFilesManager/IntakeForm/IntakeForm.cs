using Microsoft.Office.Interop.Outlook;
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

        public string IntakeId { get; set; }

        public void CreateSendItem(string receip, string attachmentPath)
        {
            MailItem OutlookMessage;
            var AppOutlook = new Microsoft.Office.Interop.Outlook.Application();
            try
            {
                OutlookMessage = (MailItem)AppOutlook.CreateItem(OlItemType.olMailItem);
                var Recipents = OutlookMessage.Recipients;
                Recipents.Add(receip);
                OutlookMessage.Subject = "CIP Process Testing";
                OutlookMessage.Body = "CIP Process Testing";
                OutlookMessage.BodyFormat = OlBodyFormat.olFormatHTML;
                if (!string.IsNullOrEmpty(attachmentPath))
                {
                    OutlookMessage.Attachments.Add(attachmentPath);
                }

                OutlookMessage.Display();
            }
            catch
            {
                MessageBox.Show("Mail could not be sent");
            }
            finally
            {
                OutlookMessage = null;
                AppOutlook = null;
            }
        }

        public void CreateSendItemCYA(string signat, string nameStrg, string receip, string attachmentPath, string attachmentPath2)
        {
            MailItem OutlookMessage;
            var AppOutlook = new Microsoft.Office.Interop.Outlook.Application();
            // Try
            OutlookMessage = (MailItem)AppOutlook.CreateItem(OlItemType.olMailItem);
            var Recipents = OutlookMessage.Recipients;
            Recipents.Add(receip);
            OutlookMessage.Subject = "New CYA Process Invoked - " + nameStrg;
            OutlookMessage.HTMLBody = @"<p>Hi,</p><br><br>

                                        <p>Please be advised that the following initial intake has been
                                        completed. We will not be taking on this client at this time. Please arrange to
                                        complete the CYA process as indicated by the attached draft CYA correspondence.</p><br><br>

                                        <p>If you have any questions, please see me.</p><br>

                                        <p>Regards,</p><br>

                                        <p>" + signat + "</p>";
            OutlookMessage.BodyFormat = OlBodyFormat.olFormatHTML;
            if (!string.IsNullOrEmpty(attachmentPath))
            {
                OutlookMessage.Attachments.Add(attachmentPath);
            }

            if (!string.IsNullOrEmpty(attachmentPath2))
            {
                OutlookMessage.Attachments.Add(attachmentPath2);
            }

            OutlookMessage.Display();
            // Catch ex As Exception
            // MessageBox.Show("Mail could not be sent")
            // Finally
            OutlookMessage = null;
            AppOutlook = null;
            // End Try
        }

        private void Intake_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ActionLogDBDataSet.CYATemplates' table. You can move, or remove it, as needed.
            if (this.ActionLogDBDataSet is null)
            {
                return;
            }

            this.DisabilityInsuranceCompaniesTableAdapter.Fill(this.ActionLogDBDataSet.DisabilityInsuranceCompanies);
            this.InsuranceCompaniesTableAdapter.Fill(this.ActionLogDBDataSet.InsuranceCompanies);
            this.IntakesTableAdapter.Fill(this.ActionLogDBDataSet.Intakes);
            // IntakesBindingSource.AddNew()

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

        private void NextButton_Click_1(object sender, EventArgs e)
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
                IntakeSheets.Instance.bringMattertypeForm();
                SetContent(IntakeSheets.Instance);
                PotentialClientInfo.Instance.OnNext();
            }
            else if (contentType == typeof(IntakeSheets) && IntakeSheets.Instance.Validate())
            {
                NextButton.Visible = false;
                SetContent(NextSteps.Instance);
            }
        }
    }
}
