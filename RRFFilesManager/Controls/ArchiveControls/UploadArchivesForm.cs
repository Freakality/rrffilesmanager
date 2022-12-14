using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxAcroPDFLib;
using Microsoft.Web.WebView2.Core;
using Microsoft.Win32;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.FileControls;
using RRFFilesManager.Logic;
using RRFFilesManager.Utils;

namespace RRFFilesManager.Controls.ArchiveControls
{
    public partial class UploadArchivesForm : Form
    {
        private Abstractions.File CurrentFile => findFilePanelUserControl1.File;
        BindingList<FileInfo> UploadedFiles = new BindingList<FileInfo>();
        BindingList<Models.Archive> Archives = new BindingList<Models.Archive>();
        private readonly IDocumentGroupRepository _documentGroupRepository;
        private readonly IDocumentCategoryRepository _documentCategoryRepository;
        private readonly IDocumentTypeRepository _documentTypeRepository;
        private readonly ArchiveManager _archiveManager;
        private readonly IArchiveRepository _archiveRepository;
        private readonly IUploadArchivesSettingsRepository _uploadArchivesSettingsRepository;
        private UploadArchivesSettings UploadArchivesSettings { get; set; }

        private DocumentFormUserControl DocumentForm => DocumentFormContent.Controls.Count > 0 ? DocumentFormContent.Controls[0] as DocumentFormUserControl : null;
        StandardBenefitsStatementUserControl StandardBenefitsStatementUserControl;
        AdditionalInformationUserControl AdditionalInformationUserControl;
        SenderRecipientUserControl SenderRecipientUserControl;
        BenefitTypeUserControl BenefitTypeUserControl;
        PreparedByUserControl PreparedByUserControl;
        MedicalRecordUserControl MedicalRecordUserControl;
        MedicalRecordWithAmountUserControl MedicalRecordWithAmountUserControl;
        BenefitsPaidToDateUserControl BenefitsPaidToDateUserControl;
        NameOfPartyUserControl NameOfPartyUserControl;
        NameUserControl NameUserControl;
        NameAndTypeOfPartyUserControl NameAndTypeOfPartyUserControl;
        NameAndTypeOfPartyAndTypeOfMotionUserControl NameAndTypeOfPartyAndTypeOfMotionUserControl;
        NameOfOrganizationUserControl NameOfOrganizationUserControl;
        EmptyUserControl EmptyUserControl;

        public FileInfo SelectedFile => FilesGridView.SelectedRows.Count > 0 ? FilesGridView.SelectedRows?[0]?.DataBoundItem as FileInfo : null;

        public UploadArchivesForm()
        {
            _documentGroupRepository = Program.GetService<IDocumentGroupRepository>();
            _documentCategoryRepository = Program.GetService<IDocumentCategoryRepository>();
            _documentTypeRepository = Program.GetService<IDocumentTypeRepository>();
            _archiveManager = new ArchiveManager();
            _archiveRepository = Program.GetService<IArchiveRepository>();
            _uploadArchivesSettingsRepository = Program.GetService<IUploadArchivesSettingsRepository>();
            InitializeComponent();

            Utils.Utils.SetComboBoxDataSource(DocumentGroup, _documentGroupRepository.List());
            StandardBenefitsStatementUserControl = new StandardBenefitsStatementUserControl();
            AdditionalInformationUserControl = new AdditionalInformationUserControl();
            SenderRecipientUserControl = new SenderRecipientUserControl();
            BenefitTypeUserControl = new BenefitTypeUserControl();
            PreparedByUserControl = new PreparedByUserControl();
            MedicalRecordUserControl = new MedicalRecordUserControl();
            MedicalRecordWithAmountUserControl = new MedicalRecordWithAmountUserControl();
            BenefitsPaidToDateUserControl = new BenefitsPaidToDateUserControl();
            NameOfPartyUserControl = new NameOfPartyUserControl();
            NameUserControl = new NameUserControl();
            NameAndTypeOfPartyUserControl = new NameAndTypeOfPartyUserControl();
            NameAndTypeOfPartyAndTypeOfMotionUserControl = new NameAndTypeOfPartyAndTypeOfMotionUserControl();
            NameOfOrganizationUserControl = new NameOfOrganizationUserControl();
            EmptyUserControl = new EmptyUserControl();


            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(UploadArchivesForm_DragEnter);
            this.DragDrop += new DragEventHandler(UploadArchivesForm_DragDrop);

            FilesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FilesGridView.MultiSelect = false;
            FilesGridView.ReadOnly = true;
            FilesGridView.DragEnter += new DragEventHandler(UploadArchivesForm_DragEnter);
            FilesGridView.DragDrop += new DragEventHandler(UploadArchivesForm_DragDrop);
            FilesGridView.DataSource = UploadedFiles;

            ArchivesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ArchivesGridView.MultiSelect = false;
            ArchivesGridView.ReadOnly = true;
            Utils.Utils.AddButtonToGridView(ArchivesGridView, "Undo");
            ArchivesGridView.DataSource = Archives;

            //this.printPreviewControl.Document = new System.Drawing.Printing.PrintDocument();
            //this.printPreviewControl.Document.DocumentName = "C:\\Users\\felix\\Downloads\\327485 (1).pdf";

            DateRangeFrom_ValueChanged(null, null);
            InitializeSettings();
        }

        private void AddButtonToGridView(DataGridView GridView, string name, string text = null)
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = name;
            editButtonColumn.Text = text ?? name;
            editButtonColumn.UseColumnTextForButtonValue = true;
            int columnIndex = 0;
            if (GridView.Columns[name] == null)
            {
                GridView.Columns.Insert(columnIndex, editButtonColumn);
            }
        }
        private void InitializeSettings()
        {
            UploadedFiles.Clear();
            UploadArchivesSettings = _uploadArchivesSettingsRepository.Get();
            if (UploadArchivesSettings?.InputFolders != null)
                AddFiles(UploadArchivesSettings?.InputFolders?.Select(s => s.Path).ToArray());
        }

        void UploadArchivesForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void UploadArchivesForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            AddFiles(paths);
        }

        private void AddFiles(string[] paths)
        {
            foreach (string path in paths)
            {
                //if (UploadedFiles.Any(s => s.FullName == path))
                //    continue;
                if (System.IO.File.Exists(path))
                {
                    var fileInfo = new FileInfo(path);
                    UploadedFiles.Add(fileInfo);
                }
                else if (Directory.Exists(path))
                {
                    
                    var filesPath = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                    foreach (string filePath in filesPath)
                    {
                        //if (UploadedFiles.Any(s => s.FullName == filePath))
                        //    continue;
                        UploadedFiles.Add(new FileInfo(filePath));
                    }

                }
                else
                {
                    // path doesn't exist.
                }
            }
            FilesGridView_CellClick(null, null);
        }


        private void UploadArchivesForm_Load(object sender, EventArgs e)
        {

        }

        private void FilesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UploadArchivesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }

        private void FilesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearForm();
            if (FilesGridView?.SelectedRows?.Count == 0)
                return;
            var path = FilesGridView?.SelectedRows?[0]?.Cells?["FullName"]?.Value.ToString();
            //this.printPreviewControl.Document = new System.Drawing.Printing.PrintDocument();
            //this.printPreviewControl.Document.DocumentName = path;
            //if (WebView != null && WebView.CoreWebView2 != null)
            //{
            //    WebView.CoreWebView2.Navigate(path);
            //}
            //webView.NavigateToString("<h1>Hola Mundo!</h1>");//.Navigate(path);
            //PreviewHandlerHost = new PreviewHandlerHost();
            //Utils.SetContent(PreviewPanel, PreviewHandlerHost);
            try
            {
                previewArchiveUserControl.Preview(path);
            }
            catch { }

        }
        
        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void PreviewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PreviewHandlerControl_Load(object sender, EventArgs e)
        {

        }

        private void PreviewHandlerHost_Click(object sender, EventArgs e)
        {

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (CurrentFile == null)
            {
                MessageBox.Show("File can not be null");
                return;
            }
            var selected = SelectedFile;
            if (selected == null)
                return;
            ProcessFile(selected);
            ClearForm();
            FilesGridView_CellClick(null, null);
        }

        private void ProcessFile(FileInfo selected)
        {
            var archive = GetArchive();
            var extension = Path.GetExtension(archive.Path);
            var newFileName = $"{DocumentName.Text}{extension}".EscapeText();
            _archiveManager.Insert(CurrentFile, archive, newFileName);
            Archives.Add(new Models.Archive(archive));
            MoveArchiveToOutputFolder(archive);
            UploadedFiles.Remove(selected);
            DocumentForm.FillAdditionalArchiveInfo(_archiveRepository.GetById(archive.ID));
        }

        private void MoveArchiveToOutputFolder(Archive archive)
        {
            if (string.IsNullOrWhiteSpace(UploadArchivesSettings.OutputFolder))
                return;
            var selected = FilesGridView.SelectedRows[0].DataBoundItem as FileInfo;
            var path = selected.FullName;
            var archiveFileName = Path.GetFileName(path);
            var destFileName = Path.Combine(UploadArchivesSettings.OutputFolder, archiveFileName);
            try
            {
                System.IO.File.Move(path, destFileName);
            }
            catch { }
            
        }

        public Archive GetArchive()
        {
            var selected = FilesGridView.SelectedRows[0].DataBoundItem as FileInfo;
            var path = selected.FullName;
            var fileName = System.IO.Path.GetFileName(selected.FullName);
            var archive = new Archive();
            archive.File = CurrentFile;
            archive.OriginalPath = path;
            archive.Path = path;
            archive.Name = fileName;
            archive.DocumentGroup = (DocumentGroup)DocumentGroup.SelectedItem;
            archive.DocumentCategory = (DocumentCategory)DocumentCategory.SelectedItem;
            archive.DocumentType = (DocumentType)DocumentType.SelectedItem;
            archive.DocumentDate = DocumentDate.Value;
            archive.DateRangeFrom = DateRangeFrom.Value;
            archive.DateRangeTo = DateRangeTo.Value;
            DocumentForm.FillArchiveInfo(archive);
            return archive;
        }

        private void ClearForm()
        {
            DocumentGroup.ResetText();
            DocumentGroup.SelectedItem = null;
            DocumentCategory.ResetText();
            DocumentCategory.SelectedItem = null;
            
            DocumentDate.ResetText();
            DocumentDate.Value = DateTime.Now;
            DocumentDate.Checked = false;

            DateRangeFrom.ResetText();
            DateRangeFrom.Value = DateTime.Now;
            DateRangeFrom.Checked = false;

            DateRangeTo.ResetText();
            DateRangeTo.Value = DateTime.Now;
            DateRangeTo.Checked = false;

            DocumentName.ResetText();
            DocumentType.ResetText();
            DocumentType.SelectedItem = null;
            DocumentForm?.ClearForm();
            
        }

        private void DocumentFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            var documentFolder = DocumentGroup.SelectedItem as DocumentGroup;
            if (documentFolder == null)
                return;
            Utils.Utils.SetComboBoxDataSource(DocumentType, new List<DocumentType>());
            Utils.Utils.SetComboBoxDataSource(DocumentCategory, _documentCategoryRepository.List().Where(s => s.DocumentGroup.ID == documentFolder.ID).ToList());
            if (documentFolder.DocumentForm != null)
                SetContent(documentFolder.DocumentForm.Value);
        }

        private void ArchivesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectFiles_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    AddFiles(openFileDialog1.FileNames);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void ArchivesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ArchivesGridView?.SelectedRows?.Count == 0)
                return;
            var selected = ArchivesGridView.SelectedRows[0].DataBoundItem as Models.Archive;
            if (selected == null)
                return;
            if (e.ColumnIndex == ArchivesGridView.Columns["Undo"].Index)
            {
                UndoProcessedArchive(selected);
                return;
            }
            previewArchiveUserControl.Preview(selected.Path);
        }

        private void UndoProcessedArchive(Models.Archive archive)
        {
            var originalArchive = archive.GetArchive();
            //var filename = Path.GetFileName(originalArchive.OriginalPath);
            //var sourceFileName = Path.Combine(UploadArchivesSettings.OutputFolder, filename);
            var sourceFileName = originalArchive.Path;
            System.IO.File.Move(sourceFileName, originalArchive.OriginalPath);
            _archiveManager.Delete(originalArchive);
            InitializeSettings();
            Archives.Remove(archive);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DocumentCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var documentCategory = DocumentCategory.SelectedItem as DocumentCategory;
            if (documentCategory == null)
                return;
            Utils.Utils.SetComboBoxDataSource(DocumentType, _documentTypeRepository.List().Where(s => s.DocumentCategory.ID == documentCategory.ID).ToList());
            if (documentCategory.DocumentForm != null)
                SetContent(documentCategory.DocumentForm.Value);
        }

        private void DocumentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DocumentForm?.ClearForm();
            var documentType = DocumentType.SelectedItem as DocumentType;
            if (documentType == null)
            {
                Utils.Utils.SetContent(DocumentFormContent, null);
                return;
            }
            SetContent(documentType.DocumentForm);
            OnChange();
        }

        private void SetContent(DocumentFormEnum documentForm) {
            

            if (documentForm == DocumentFormEnum.AdditionalInformation)
            {
                Utils.Utils.SetContent(DocumentFormContent, AdditionalInformationUserControl);
            }
            else if (documentForm == DocumentFormEnum.StandardBenefitsStatement)
            {
                Utils.Utils.SetContent(DocumentFormContent, StandardBenefitsStatementUserControl);
            }
            else if (documentForm == DocumentFormEnum.SenderRecipient)
            {
                Utils.Utils.SetContent(DocumentFormContent, SenderRecipientUserControl);
            }
            else if (documentForm == DocumentFormEnum.BenefitType)
            {
                Utils.Utils.SetContent(DocumentFormContent, BenefitTypeUserControl);
            }
            else if (documentForm == DocumentFormEnum.PreparedBy)
            {
                Utils.Utils.SetContent(DocumentFormContent, PreparedByUserControl);
            }
            else if (documentForm == DocumentFormEnum.MedicalRecord)
            {
                Utils.Utils.SetContent(DocumentFormContent, MedicalRecordUserControl);
            }
            else if (documentForm == DocumentFormEnum.MedicalRecordWithAmount)
            {
                Utils.Utils.SetContent(DocumentFormContent, MedicalRecordWithAmountUserControl);
            }
            else if (documentForm == DocumentFormEnum.BenefitsPaidToDate)
            {
                Utils.Utils.SetContent(DocumentFormContent, BenefitsPaidToDateUserControl);
            }
            else if (documentForm == DocumentFormEnum.NameOfParty)
            {
                Utils.Utils.SetContent(DocumentFormContent, NameOfPartyUserControl);
            }
            else if (documentForm == DocumentFormEnum.Name)
            {
                Utils.Utils.SetContent(DocumentFormContent, NameUserControl);
            }
            else if (documentForm == DocumentFormEnum.NameAndTypeOfParty)
            {
                Utils.Utils.SetContent(DocumentFormContent, NameAndTypeOfPartyUserControl);
            }
            else if (documentForm  == DocumentFormEnum.NameAndTypeOfPartyAndTypeOfMotion)
            {
                Utils.Utils.SetContent(DocumentFormContent, NameAndTypeOfPartyAndTypeOfMotionUserControl);
            }
            else if (documentForm == DocumentFormEnum.NameOfOrganization)
            {
                Utils.Utils.SetContent(DocumentFormContent, NameOfOrganizationUserControl);
            }
            else if (documentForm == DocumentFormEnum.Empty)
            {
                Utils.Utils.SetContent(DocumentFormContent, EmptyUserControl);
            }
        }

        private void DocumentDate_ValueChanged(object sender, EventArgs e)
        {
            DocumentDate.CustomFormat = (DocumentDate.Checked && DocumentDate.Value != DocumentDate.MinDate) ? "MM/dd/yyyy" : " ";
            OnChange();
        }

        private void DateRangeFrom_ValueChanged(object sender, EventArgs e)
        {
            DateRangeTo.Checked = DateRangeFrom.Checked;
            DateRangeFrom.CustomFormat = (DateRangeFrom.Checked && DateRangeFrom.Value != DateRangeFrom.MinDate) ? "MM/dd/yyyy" : " ";
            DateRangeTo.CustomFormat = (DateRangeTo.Checked && DateRangeTo.Value != DateRangeTo.MinDate) ? "MM/dd/yyyy" : " ";
            OnChange();
        }

        private void DateRangeTo_ValueChanged(object sender, EventArgs e)
        {
            DateRangeFrom.Checked = DateRangeTo.Checked;
            DateRangeFrom.CustomFormat = (DateRangeFrom.Checked && DateRangeFrom.Value != DateRangeFrom.MinDate) ? "MM/dd/yyyy" : " ";
            DateRangeTo.CustomFormat = (DateRangeTo.Checked && DateRangeTo.Value != DateRangeTo.MinDate) ? "MM/dd/yyyy" : " ";
            OnChange();
        }

        private void OnChange()
        {
            var documentGroup = DocumentGroup.SelectedItem as DocumentGroup;
            var documentCategory = DocumentCategory.SelectedItem as DocumentCategory;
            var documentType = DocumentType.SelectedItem as DocumentType;
            if (DocumentForm == null || SelectedFile == null || documentGroup == null)
                return;
            var documentNameType = documentGroup?.DocumentNameType ?? documentCategory?.DocumentNameType ?? documentType?.DocumentNameType ?? default;
            var text = documentType?.Description ?? documentCategory?.Description ?? documentGroup.Description;
            DocumentForm?.SetDocumentParameters(text, DocumentDate.ToNullableValue(), DateRangeFrom.ToNullableValue(), DateRangeTo.ToNullableValue(), documentNameType);
            //DocumentForm?.SetDocumentExtension(SelectedFile?.Extension);
            DocumentForm?.SetFileNameControl(DocumentName);
            DocumentForm?.OnChange();
        }

        private void SelectFolders_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    AddFiles(new string[] { folderBrowserDialog1.SelectedPath });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void DocumentName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
