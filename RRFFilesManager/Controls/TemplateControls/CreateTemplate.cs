using Microsoft.WindowsAPICodePack.Dialogs;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.Logic;
using RRFFilesManager.TemplateControls;
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

        public Template Template { get; set; }
        private string TemplateFilePath { 
            get {
                if (string.IsNullOrWhiteSpace(FolderTextBox.Text))
                    return null;
                var extension = Path.GetExtension(CopyFromTextBox.Text);
                if (string.IsNullOrWhiteSpace(extension))
                    extension = ".doc";
                return Path.Combine(FolderTextBox.Text, $"{TemplateNameTextBox.Text}{extension}");
            } 
        }
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
            EditButton.Visible = false;
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
            if (!Validate())
                return;
            CopyOrMoveTemplateAndSave();
            EditTemplate();
            Hide();
            Home.Instance.Show();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;
            CopyOrMoveTemplateAndSave();
            Hide();
            Home.Instance.Show();
        }

        private void EditTemplate()
        {
            var filePath = GetTemplateFilePath(TemplateFilePath);

            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var document = wordApp?.Documents.Open(filePath);
            wordApp.Visible = true;
        }

        private string GetTemplateFilePath(string filePath)
        {
            string wordTemplatesPathSetting = ConfigurationManager.AppSettings["WordTemplatesPath"];

            if (!string.IsNullOrWhiteSpace(wordTemplatesPathSetting))
                filePath = filePath.Replace(@"\\FS\FOISY\!", wordTemplatesPathSetting);
            return filePath;
        }

        public new bool Validate()
        {
            if (string.IsNullOrEmpty(this.MatterTypeComboBox.Text))
            {
                MessageBox.Show("Please enter Matter Type");
                return false;
            }

            if (string.IsNullOrEmpty(this.CategoryCombobox.Text))
            {
                MessageBox.Show("Please enter Category");
                return false;
            }

            if (string.IsNullOrEmpty(this.TypeOfTemplateComboBox.Text))
            {
                MessageBox.Show("Please enter Type Of Template");
                return false;
            }

            if (string.IsNullOrEmpty(this.FolderTextBox.Text))
            {
                MessageBox.Show("Please enter Folder");
                return false;
            }
            if(Template == null)
            {
                if (string.IsNullOrEmpty(this.CopyFromTextBox.Text))
                {
                    MessageBox.Show("Please enter Copy From");
                    return false;
                }
            }


            return true;
        }
        private void CopyOrMoveTemplateAndSave()
        {
            var success = false;
            if (Template == null)
                success = CopyTemplate();
            else
                success = MoveTemplate();
            if(success)
                UpsertTemplate();
        }

        private bool CopyTemplate()
        {
            try
            {
                var copyFromFilePath = CopyFromTextBox.Text;
                var copyToFilePath = TemplateFilePath;
                System.IO.File.Copy(copyFromFilePath, copyToFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        private bool MoveTemplate()
        {
            try
            {
                var currentTemplatePath = GetTemplateFilePath(Template.TemplatePath);
                var newTemplatePath = GetTemplateFilePath(TemplateFilePath);
                if (currentTemplatePath != newTemplatePath)
                    System.IO.File.Move(currentTemplatePath, newTemplatePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditTemplate();
        }

        private void FindTemplateButton_Click(object sender, EventArgs e)
        {
            FindTemplate.Instance.Show();
            FindTemplate.Instance.FormClosing += new FormClosingEventHandler(this.FindTemplate_FormClosing);
        }
        private void FindTemplate_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findForm = sender as FindTemplate;
            Template = findForm.SelectedTemplate;
            FillForm(Template);
            EditButton.Visible = true;
        }

        public void FillForm(Template template)
        {
            if (template == null)
                return;
            MatterTypeComboBox.SelectedItem = template.MatterType;
            CategoryCombobox.SelectedItem = template.Category;
            TypeOfTemplateComboBox.SelectedItem = template.TypeOfTemplate;
            TemplateNameTextBox.Text = Path.GetFileNameWithoutExtension(template.TemplatePath);
            FolderTextBox.Text = Path.GetDirectoryName(template.TemplatePath);
        }
        public void FillTemplate(Template template)
        {
            template.MatterType = (MatterType)MatterTypeComboBox.SelectedItem;
            template.Category = (string)CategoryCombobox.SelectedItem;
            template.TypeOfTemplate = (string)TypeOfTemplateComboBox.SelectedItem;
            template.TemplateName = TemplateNameTextBox.Text;
            template.TemplatePath = TemplateFilePath;
        }

        private void TemplateNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void UpsertTemplate()
        {
            if (Template == null)
                Template = new Template();
            FillTemplate(Template);
            if (Template.ID == default)
                _templateRepository.Insert(Template);
            else
                _templateRepository.Update(Template);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
            Home.Instance.Show();
        }
    }
}
