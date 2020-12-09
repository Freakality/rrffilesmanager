using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.FileControls;
using RRFFilesManager.IntakeForm;
using RRFFilesManager.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace RRFFilesManager
{
    public partial class CreateDocument : Form
    {
        private readonly ITemplateRepository _templateRepository;
        private File File { get; set; }
        public CreateDocument()
        {
            _templateRepository = (ITemplateRepository)Program.ServiceProvider.GetService(typeof(ITemplateRepository));
            InitializeComponent();
        }
        private void FindFileButton_Click(object sender, EventArgs e)
        {
            FindFile.Instance.Show();
            FindFile.Instance.FormClosing += new FormClosingEventHandler(FindFile_FormClosing);
        }

        private void FindFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findFileForm = sender as FindFile;
            SetForm(findFileForm.SelectedFile);
        }

        private void SetForm(File file)
        {
            File = file;
            if (file == null)
                return;
            MatterTypeTextBox.Text = File.MatterType.ToString();
            FileNumberTextBox.Text = File.FileNumber.ToString();

            var typesOfTemplates = _templateRepository.List(File.MatterType.ID)?.Select(s => s.TypeOfTemplate).Distinct().ToArray();
            TypeTemplate.Items.AddRange(typesOfTemplates);

            TemplatesGroupBox.Visible = true;
        }

        private void TypeTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            TemplateName.DataSource = _templateRepository.List(File.MatterType.ID, null, TypeTemplate.Text);
            TemplateName.DisplayMember = nameof(Template.TemplateName);
        }

        private void TemplateName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var isItemSelected = TemplateName.SelectedItem != null;
            Submit.Visible = isItemSelected;
        }

        private void DocumentPreview_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Hide();
            Submitting.Instance.Show();
            try
            {

                CreateAndSendDocument();
                Submitting.Instance.Hide();
                Close();
                Home.Instance.Show();
            }
            catch (System.Exception exception)
            {
                MessageBox.Show(exception.Message);
                Submitting.Instance.Hide();
                Home.IntakeForm.Show();
            }
        }

        public void CreateAndSendDocument()
        {
            //var template = (Template)TemplateName.SelectedItem;
            //var attachmentPath = IntakeManager.CreateCYADocument(template.TemplatePath, Intake);
            //var attachmentPath2 = IntakeManager.CreateIntakeWorkbook(Intake);
            //string nameStr = $"{Intake.File.Client?.LastName}, {Intake.File.Client?.FirstName}";
            //string signat = Intake.File.StaffInterviewer.Description;
            //string[] to = new string[] { "DManzano@InjuryLawyerCanada.com", "RFoisy@InjuryLawyerCanada.com" };

            //var subject = $"New Process Invoked - {nameStr}";
            //var body = $@"<p>Hi,</p><br><br>

            //            <p>...</p><br><br>

            //            <p>If you have any questions, please see me.</p><br>

            //            <p>Regards,</p><br>

            //            <p>{signat}</p>";
            //Outlook.NewEmail(to, subject, body, new[] { attachmentPath, attachmentPath2 });

        }

        private void CreateDocument_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }

    }
}
