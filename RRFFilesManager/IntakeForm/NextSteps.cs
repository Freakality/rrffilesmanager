using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using RRFFilesManager.DataAccess;
using System.Configuration;
using System.IO;
using Microsoft.Office.Interop.Outlook;
using RRFFilesManager.Abstractions;
using RRFFilesManager.Logic;

namespace RRFFilesManager.IntakeForm
{
    public partial class NextSteps : UserControl
    {
        public NextSteps()
        {
            InitializeComponent();
            var typesOfTemplates = Program.DBContext.CYATemplates.Where(s => s.MatterType.ID == IntakeForm.Intake.MatterType.ID)?.Select(s => s.TypeOfTemplate).Distinct().ToArray();
            TypeTemplate.Items.AddRange(typesOfTemplates);
            DocumentPreview.Visible = false;
        }
        private void InvokeCYP_CheckedChanged(object sender, EventArgs e)
        {
            MVATemplatesGroupBox.Visible = this.InvokeCYP.Checked;
            Submit.Visible = this.InvokeCYP.Checked;
            Submit.Text = "Submit";
        }

        private void PAHProcess_CheckedChanged(object sender, EventArgs e)
        {
            MVATemplatesGroupBox.Visible = this.InvokeCYP.Checked;
            Submit.Visible = this.PAHProcess.Checked;
            Submit.Text = "Print and Hold";
        }

        private void TypeTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            TemplateName.DataSource = Program.DBContext.CYATemplates.Where(s => s.MatterType.ID == IntakeForm.Intake.MatterType.ID && s.TypeOfTemplate == TypeTemplate.Text)?.ToList();
            TemplateName.DisplayMember = nameof(CYATemplate.TemplateName);
        }

        private void NextSteps_Load(object sender, EventArgs e)
        {
                
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Home.IntakeForm.Hide();
            Submitting.Instance.Show();
            if (InvokeCIP.Checked)
            {
                SetHoldIntake(false);
                // CreateSendItem("rojascarlos82@hotmail.com",attachmentPath)
                Outlook.NewEmail("DManzano@InjuryLawyerCanada.com", "CIP Process Testing", "CIP Process Testing");
                Outlook.NewEmail("RFoisy@InjuryLawyerCanada.com", "CIP Process Testing", "CIP Process Testing");
            }
            else if (InvokeCYP.Checked)
            {
                SetHoldIntake(false);
                CreateSendItemCYA();
            }
            else if (PAHProcess.Checked)
            {
                
                PrintAndHold();
            }
            Submitting.Instance.Hide();
            Home.IntakeForm.Close();
            Home.Instance.Show();
        }
        

        public void PrintAndHold()
        {
            SetHoldIntake(true);
            CreateSendItemPAH();

        }
        public void SetHoldIntake(bool hold)
        {
            var intake = Program.DBContext.Intakes.FirstOrDefault(s => s.ID == IntakeForm.Intake.ID);
            intake.Hold = hold;
            Program.DBContext.SaveChanges();
        }
        public void CreateSendItemPAH()
        {
            var attachmentPath = IntakeManager.CreateIntakeWorkbook(IntakeForm.Intake);
            string clientFullName = $"{IntakeForm.Intake.Client?.LastName}, {IntakeForm.Intake.Client?.FirstName}";
            string receip = "rojascarlos82@hotmail.com";
            var subject = $"Print and Hold Process - {clientFullName}";
            var body = "";
            Outlook.NewEmail(receip, subject, body, new[] { attachmentPath });
        }
        public void CreateSendItemCYA()
        {
            var attachmentPath = IntakeManager.CreateOrUpdateIntakeDocument(IntakeForm.Intake, (CYATemplate)TemplateName.SelectedItem);
            var attachmentPath2 = IntakeManager.CreateIntakeWorkbook(IntakeForm.Intake);
            string nameStr = $"{IntakeForm.Intake.Client?.LastName}, {IntakeForm.Intake.Client?.FirstName}";
            string signat = IntakeForm.Intake.StaffInterviewer.Description;
            string receip = "rojascarlos82@hotmail.com";

            var subject = $"New CYA Process Invoked - {nameStr}";
            var body = $@"<p>Hi,</p><br><br>

                        <p>Please be advised that the following initial intake has been
                        completed. We will not be taking on this client at this time. Please arrange to
                        complete the CYA process as indicated by the attached draft CYA correspondence.</p><br><br>

                        <p>If you have any questions, please see me.</p><br>

                        <p>Regards,</p><br>

                        <p>{signat}</p>";
            Outlook.NewEmail(new[] { receip }, subject, body, new[] { attachmentPath, attachmentPath2 });

        }



        private Document OpenDocument(string path)
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var document = wordApp?.Documents.Open(path);
            wordApp.Quit();
            return document;
        }

        private Workbook OpenWorkbook(string path)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excelApp?.Workbooks?.Open(path);
            excelApp.Quit();
            return workbook;
        }

        private void TemplateName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocumentPreview.Visible = TemplateName.SelectedItem != null;
        }

        private void GroupBox32_Enter(object sender, EventArgs e)
        {

        }

        private void DocumentPreview_Click(object sender, EventArgs e)
        {
            PleaseWait.Instance.Show();
            var filePath = IntakeManager.CreateOrUpdateIntakeDocument(IntakeForm.Intake, (CYATemplate)TemplateName.SelectedItem);
            PleaseWait.Instance.Hide();
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var document = wordApp?.Documents.Open(filePath);
            wordApp.Visible = true;
        }

        

        private void MVATemplatesGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
