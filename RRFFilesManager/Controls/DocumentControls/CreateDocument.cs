using Microsoft.Office.Interop.Word;
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
using System.IO;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace RRFFilesManager
{
    public partial class CreateDocument : Form
    {
        private readonly ITemplateRepository _templateRepository;
        private readonly ArchiveManager _archiveManager;
        private Abstractions.File File { get; set; }

        private Archive Archive { get; set; }

        private Abstractions.Template Template => (Abstractions.Template)TemplateName.SelectedItem;
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
            Archive = null;
        }

        private void SetForm(Abstractions.File file)
        {
            if (file == null)
                return;
            File = file;
            MatterTypeTextBox.Text = File.MatterType.ToString();
            FileNumberTextBox.Text = File.FileNumber.ToString();

            FillTypeOfTemplatesComboBox();

            FillCategoryComboBox();

            TemplatesGroupBox.Visible = true;
        }
        private void FillTypeOfTemplatesComboBox()
        {
            var typesOfTemplates = _templateRepository.List(File.MatterType.ID)?.Select(s => s.TypeOfTemplate).Distinct().ToArray();
            TypeTemplate.Items.Clear();
            TypeTemplate.Items.AddRange(typesOfTemplates);
        }

        private void FillCategoryComboBox()
        {
            TemplateName.ResetText();
            Category.ResetText();
            var categories = _templateRepository.List(File.MatterType.ID, null, TypeTemplate.Text)?.Select(s => s.Category).Distinct().ToArray();
            Category.Items.Clear();
            Category.Items.AddRange(categories);
        }

        private void FillTemplateNameComboBox()
        {
            TemplateName.DataSource = _templateRepository.List(File.MatterType.ID, Category.Text, TypeTemplate.Text);
            TemplateName.DisplayMember = nameof(Template.TemplateName);
        }

        private void TypeTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCategoryComboBox();
        }

        private void TemplateName_SelectedIndexChanged(object sender, EventArgs e)
        {
            var isItemSelected = TemplateName.SelectedItem != null && Archive == null;
            CreateAndEditButton.Visible = isItemSelected;
        }


        public void SendDocument(string filePath)
        {
            var attachmentPath = filePath;
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

        private void CreateDocument_Load(object sender, EventArgs e)
        {

        }

        private void Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTemplateNameComboBox();
        }

        private void Label74_Click(object sender, EventArgs e)
        {

        }


        private void CreateAndEditButton_Click(object sender, EventArgs e)
        {
            SaveArchiveDocument();
            EditArchiveDocument();
        }

        public void SaveArchiveDocument()
        {
            Submitting.Instance.Show();
            try
            {
                Archive = _archiveManager.CreateAndAddArchiveFromTemplate(File, Template);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            Submitting.Instance.Hide();
        }

        private void EditArchiveDocument()
        {
            if (Archive == null)
                return;
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            var document = wordApp?.Documents.Open(FileName: Archive.Path);
            wordApp.Visible = true;
            wordApp.DocumentBeforeClose += WordApp_DocumentBeforeClose;
        }

        private void WordApp_DocumentBeforeClose(Document Doc, ref bool Cancel)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                SendWordButton.Show();
                SendPDFButton.Show();
                EditButton.Show();
                SaveAndCloseButton.Show();
                CreateAndEditButton.Hide();
                Doc.Save();
                var filename = $"{Path.GetFileNameWithoutExtension(Doc.Name)}.pdf";
                var filepath = Path.Combine(Doc.Path, filename);
                Doc.SaveAs2(FileName: filepath, FileFormat: WdSaveFormat.wdFormatPDF);
                Doc.Application.Quit();
            }));
        }

        private void SendPDFButton_Click(object sender, EventArgs e)
        {
            var filename = $"{Path.GetFileNameWithoutExtension(Archive.Path)}.pdf";
            var filepath = Path.Combine(Path.GetDirectoryName(Archive.Path), filename);
            SendDocument(filepath);
            Submitting.Instance.Hide();
            Close();
            Home.Instance.Show();
        }

        private void SendWordButton_Click(object sender, EventArgs e)
        {
            SendDocument(Archive.Path);
            Submitting.Instance.Hide();
            Close();
            Home.Instance.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
            Home.Instance.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditArchiveDocument();
        }

        private void SaveAndCloseButton_Click(object sender, EventArgs e)
        {
            SaveArchiveDocument();
            Close();
        }
    }
}
