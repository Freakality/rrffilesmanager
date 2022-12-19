using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using RRFFilesManager.Abstractions;
using RRFFilesManager.Logic;
using RRFFilesManager.DataAccess.Abstractions;
using Template = RRFFilesManager.Abstractions.Template;
using RRFFilesManager.Controls.FileControls;

namespace RRFFilesManager.IntakeForm
{
    public partial class NextSteps : UserControl
    {
        public bool RefillCYADocument { get; set; }
        private readonly ITemplateRepository _templateRepository;
        private readonly ArchiveManager _archiveManager;
        private Archive Document { get; set; }
        private Archive Workbook { get; set; }
        public NextSteps()
        {
            _templateRepository = Program.GetService<ITemplateRepository>();
            _archiveManager = new ArchiveManager();
            InitializeComponent();
            var typesOfTemplates = _templateRepository.List(Home.IntakeForm.Intake.File.MatterType.ID, "CYA")?.Select(s => s.TypeOfTemplate).Distinct().ToArray();
            TypeTemplate.Items.AddRange(typesOfTemplates);
            DocumentPreview.Visible = false;
        }
        private void InvokeCYP_CheckedChanged(object sender, EventArgs e)
        {
            DocumentPreview.Visible = TemplateName.SelectedItem != null;
            Home.IntakeForm.NextButton.Visible = false;
            MVATemplatesGroupBox.Visible = this.InvokeCYP.Checked;
            Submit.Visible = this.InvokeCYP.Checked;
            Submit.Text = "Submit";
        }

        private void PAHProcess_CheckedChanged(object sender, EventArgs e)
        {
            DocumentPreview.Visible = false;
            Home.IntakeForm.NextButton.Visible = false;
            MVATemplatesGroupBox.Visible = this.InvokeCYP.Checked;
            Submit.Visible = this.PAHProcess.Checked;
            Submit.Text = "Hold and Follow-Up Process ";
        }

        private void TypeTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            TemplateName.DataSource = _templateRepository.List(Home.IntakeForm.Intake.File.MatterType.ID, "CYA", TypeTemplate.Text);
            TemplateName.DisplayMember = nameof(Template.TemplateName);
        }

        private void NextSteps_Load(object sender, EventArgs e)
        {
                
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Home.IntakeForm.Hide();
            Submitting.Instance.Show();
            try
            {
                if (InvokeCIP.Checked)
                {
                    // CreateSendItem("rojascarlos82@hotmail.com",attachmentPath)
                    Outlook.NewEmail("DManzano@InjuryLawyerCanada.com", "CIP Process Testing", "CIP Process Testing");
                    Outlook.NewEmail("RFoisy@InjuryLawyerCanada.com", "CIP Process Testing", "CIP Process Testing");
                    IntakeManager.SetHoldIntake(Home.IntakeForm.Intake, false);
                }
                else if (InvokeCYP.Checked)
                {
                    CreateSendItemCYA();
                    IntakeManager.SetHoldIntake(Home.IntakeForm.Intake, false);
                }
                else if (PAHProcess.Checked)
                {
                    using (DaysCount Count = new DaysCount())
                    {
                        if (Count.ShowDialog() == DialogResult.OK)
                        {
                            IntakeManager.SetHoldIntake(Home.IntakeForm.Intake, true);
                            PrintAndHold();
                        }
                    }
                }
                Submitting.Instance.Hide();
                Home.IntakeForm.Close();
                Home.Instance.Show();
            }
            catch(System.Exception exception)
            {
                MessageBox.Show(exception.Message);
                Submitting.Instance.Hide();
                Home.IntakeForm.Show();
            }
        }
        

        public void PrintAndHold()
        {
            CreateSendItemPAH();

        }
        
        public void CreateSendItemPAH()
        {
            CreateOrUpdateDocument();
            var attachmentPath = Document.Path;
            string clientFullName = $"{Home.IntakeForm.Intake.File.Client?.LastName}, {Home.IntakeForm.Intake.File.Client?.FirstName}";
            string[] to = new string[] { "DManzano@InjuryLawyerCanada.com", "RFoisy@InjuryLawyerCanada.com" };
            var subject = $"Print and Hold Process - {clientFullName}";
            var body = "";
            Outlook.NewEmail(to, subject, body, new[] { attachmentPath });
        }
        public void CreateSendItemCYA()
        {
            CreateOrUpdateDocument();
            var attachmentPath = Document.Path;
            RefillCYADocument = false;
            CreateOrUpdateWorkbook();
            var attachmentPath2 = Workbook.Path;
            string nameStr = $"{Home.IntakeForm.Intake.File.Client?.LastName}, {Home.IntakeForm.Intake.File.Client?.FirstName}";
            string signat = Home.IntakeForm.Intake.File.StaffInterviewer.Description;
            string[] to = new string[] { "DManzano@InjuryLawyerCanada.com", "RFoisy@InjuryLawyerCanada.com" };

            var subject = $"New CYA Process Invoked - {nameStr}";
            var body = $@"<p>Hi,</p><br><br>

                        <p>Please be advised that the following initial intake has been
                        completed. We will not be taking on this client at this time. Please arrange to
                        complete the CYA process as indicated by the attached draft CYA correspondence.</p><br><br>

                        <p>If you have any questions, please see me.</p><br>

                        <p>Regards,</p><br>

                        <p>{signat}</p>";
            Outlook.NewEmail(to, subject, body, new[] { attachmentPath, attachmentPath2 });

        }

        private void TemplateName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocumentPreview.Visible = TemplateName.SelectedItem != null;
            RefillCYADocument = true;
        }

        private void GroupBox32_Enter(object sender, EventArgs e)
        {

        }

        private void DocumentPreview_Click(object sender, EventArgs e)
        {
            PleaseWait.Instance.Show();
            CreateOrUpdateDocument();
            var filePath = Document.Path;
            RefillCYADocument = false;
            PleaseWait.Instance.Hide();
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var document = wordApp?.Documents.Open(filePath);
            wordApp.Visible = true;
        }

        private void CreateOrUpdateDocument()
        {
            var template = ((Abstractions.Template)TemplateName.SelectedItem);
            if (Document == null)
                Document = _archiveManager.CreateAndAddArchiveFromTemplate(Home.IntakeForm.Intake.File, template);
            else if(RefillCYADocument)
                _archiveManager.UpdateArchiveFromTemplate(Document);
        }

        private void CreateOrUpdateWorkbook()
        {
            if (Workbook == null)
                Workbook = _archiveManager.CreateAndAddArchiveFromTemplate(Home.IntakeForm.Intake.File);
            else
                _archiveManager.UpdateArchiveFromTemplate(Workbook);
        }



        private void MVATemplatesGroupBox_Enter(object sender, EventArgs e)
        {

        }
        public void OnNext()
        {

        }

        private void InvokeCIP_CheckedChanged(object sender, EventArgs e)
        {
            DocumentPreview.Visible = false;
            Home.IntakeForm.NextButton.Visible = true;
        }
    }
}
