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
        private readonly ArchiveManager _archiveManager;
        private File File { get; set; }

        private Template Template => (Template)TemplateName.SelectedItem;
        public CreateDocument()
        {
            _templateRepository = (ITemplateRepository)Program.ServiceProvider.GetService(typeof(ITemplateRepository));
            _archiveManager = new ArchiveManager();
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
            SaveButton.Visible = isItemSelected;
        }

        private void DocumentPreview_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {

        }

        public void SendDocument(Archive archive)
        {
            var attachmentPath = archive.Path;
            string nameStr = $"{File.Client?.LastName}, {File.Client?.FirstName}";
            string signat = File.StaffInterviewer.Description;
            string[] to = new string[] { "DManzano@InjuryLawyerCanada.com", "RFoisy@InjuryLawyerCanada.com" };

            var subject = $"New Process Invoked - {nameStr}";
            var body = $@"<p>Hi,</p><br><br>

                        <p>...</p><br><br>

                        <p>If you have any questions, please see me.</p><br>

                        <p>Regards,</p><br>

                        <p>{signat}</p>";
            Outlook.NewEmail(to, subject, body, new[] { attachmentPath });

        }

        private void CreateDocument_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Home.Instance.Show();
        }

        private void SaveAndSend_Click(object sender, EventArgs e)
        {
            Submitting.Instance.Show();
            var archive = _archiveManager.CreateAndAddArchive(File, Template);
            SendDocument(archive);
            Submitting.Instance.Hide();
            Hide();
            Home.Instance.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Submitting.Instance.Show();
            _archiveManager.CreateAndAddArchive(File, Template);
            Submitting.Instance.Hide();
            Close();
            Home.Instance.Show();
        }
    }
}
