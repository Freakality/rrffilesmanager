using Microsoft.WindowsAPICodePack.Dialogs;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager
{
    public partial class CreateTemplate : Form
    {
        private readonly IMatterTypeRepository _matterTypeRepository;
        private readonly ITemplateRepository _templateRepository;

        private string TemplateFilePath => Path.Combine(FolderTextBox.Text, $"{TemplateNameTextBox.Text}{Path.GetExtension(CopyFromTextBox.Text)}");
        public CreateTemplate()
        {
            _matterTypeRepository = Program.GetService<IMatterTypeRepository>();
            _templateRepository = Program.GetService<ITemplateRepository>();

            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            Utils.SetComboBoxDataSource(MatterTypeComboBox, _matterTypeRepository.List());
            Utils.SetComboBoxDataSource(CategoryCombobox, _templateRepository.GetCategories());
            Utils.SetComboBoxDataSource(TypeOfTemplateComboBox, _templateRepository.GetTypesOfTemplate());
        }

        private void CreateTemplate_Load(object sender, EventArgs e)
        {

        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            var documentTemplatesPath = ConfigurationManager.AppSettings["DocumentTemplatesPath"];
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = documentTemplatesPath;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                FolderTextBox.Text = dialog.FileName;
            }
        }

        private void CreateTemplate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Home.Instance.Show();
        }

        private void SelectTemplateButton_Click(object sender, EventArgs e)
        {
            var documentTemplatesPath = ConfigurationManager.AppSettings["DocumentTemplatesPath"];
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = documentTemplatesPath;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                CopyFromTextBox.Text = dialog.FileName;
            }
        }

        private void SaveAndEdit_Click(object sender, EventArgs e)
        {
            CopyTemplateAndSave();
            EditTemplate();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            CopyTemplateAndSave();
        }

        private void EditTemplate()
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var document = wordApp?.Documents.Open(TemplateFilePath);
            wordApp.Visible = true;
        }

        private void CopyTemplateAndSave()
        {
            CopyTemplate();
            SaveTemplate();
        }

        private void CopyTemplate()
        {
            var copyFromFilePath = CopyFromTextBox.Text;
            var copyToFilePath = TemplateFilePath;
            System.IO.File.Copy(copyFromFilePath, copyToFilePath);
        }

        private void SaveTemplate() {
            var template = new Template
            {
                TemplateName = TemplateNameTextBox.Text,
                MatterType = (MatterType)MatterTypeComboBox.SelectedItem,
                Category = (string)CategoryCombobox.SelectedItem,
                TypeOfTemplate = (string)TypeOfTemplateComboBox.SelectedItem,
                TemplatePath = TemplateFilePath
            };
            _templateRepository.Insert(template);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditTemplate();
        }
    }
}
