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

namespace RRFFilesManager.Controls.ArchiveControls
{
    public partial class UploadArchivesForm : Form
    {
        private Abstractions.File CurrentFile { get; set; }
        BindingList<FileInfo> UploadedFiles = new BindingList<FileInfo>();
        BindingList<Archive> Archives = new BindingList<Archive>();
        private readonly IDocumentGroupRepository _documentGroupRepository;
        private readonly IDocumentCategoryRepository _documentCategoryRepository;
        private readonly IDocumentTypeRepository _documentTypeRepository;
        private readonly IArchiveRepository _archiveRepository;

        private DocumentFormUserControl DocumentForm => DocumentFormContent.Controls.Count > 0 ? DocumentFormContent.Controls[0] as DocumentFormUserControl : null;
        StandardBenefitsStatementUserControl StandardBenefitsStatementUserControl;
        AdditionalInformationUserControl AdditionalInformationUserControl;
        SenderRecipientUserControl SenderRecipientUserControl;
        BenefitTypeUserControl BenefitTypeUserControl;
        PreparedByUserControl PreparedByUserControl;
        MedicalRecordUserControl MedicalRecordUserControl;
        MedicalRecordWithAmountUserControl MedicalRecordWithAmountUserControl;
        BenefitsPaidToDateUserControl BenefitsPaidToDateUserControl;

        public FileInfo SelectedFile => FilesGridView.SelectedRows.Count > 0 ? FilesGridView.SelectedRows?[0]?.DataBoundItem as FileInfo : null;

        public UploadArchivesForm()
        {
            _documentGroupRepository = Program.GetService<IDocumentGroupRepository>();
            _documentCategoryRepository = Program.GetService<IDocumentCategoryRepository>();
            _documentTypeRepository = Program.GetService<IDocumentTypeRepository>();
            _archiveRepository = Program.GetService<IArchiveRepository>();
            InitializeComponent();

            Utils.SetComboBoxDataSource(DocumentGroup, _documentGroupRepository.List());
            StandardBenefitsStatementUserControl = new StandardBenefitsStatementUserControl();
            AdditionalInformationUserControl = new AdditionalInformationUserControl();
            SenderRecipientUserControl = new SenderRecipientUserControl();
            BenefitTypeUserControl = new BenefitTypeUserControl();
            PreparedByUserControl = new PreparedByUserControl();
            MedicalRecordUserControl = new MedicalRecordUserControl();
            MedicalRecordWithAmountUserControl = new MedicalRecordWithAmountUserControl();
            BenefitsPaidToDateUserControl = new BenefitsPaidToDateUserControl();

            axAcroPDF.setShowToolbar(false);
            axAcroPDF.setShowScrollbars(true);

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
            ArchivesGridView.DataSource = Archives;

            //this.printPreviewControl.Document = new System.Drawing.Printing.PrintDocument();
            //this.printPreviewControl.Document.DocumentName = "C:\\Users\\felix\\Downloads\\327485 (1).pdf";

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
                    var filesPath = Directory.GetFiles(path);
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

            FilePreview(path);

        }
        private void FilePreview(string path)
        {
            previewHandlerHost1.Hide();
            axAcroPDF.Hide();
            pictureBox.Hide();
            richTextBox.Hide();

            var ext = Path.GetExtension(path);
            var perceivedType = Convert.ToString(Registry.ClassesRoot.OpenSubKey(ext).GetValue("PerceivedType"));
            if (ext == ".pdf")
            {
                //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadArchivesForm));
                //axAcroPDF = new AxAcroPDF();
                //((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
                //this.axAcroPDF.Dock = System.Windows.Forms.DockStyle.Fill;
                //this.axAcroPDF.Enabled = true;
                //this.axAcroPDF.Location = new System.Drawing.Point(0, 0);
                //this.axAcroPDF.Name = "axAcroPDF";
                //this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
                //this.axAcroPDF.Size = new System.Drawing.Size(465, 665);
                //this.axAcroPDF.TabIndex = 0;
                //this.axAcroPDF.Visible = false;
                //((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
                axAcroPDF.LoadFile(path);
                axAcroPDF.src = path;
                axAcroPDF.setShowToolbar(false);
                //axAcroPDF.setLayoutMode("SinglePage");
                //axAcroPDF.setPageMode("PDUseNone");
                axAcroPDF.Show();
            }
            else if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || perceivedType == "image")
            {
                var imagenOriginal = new Bitmap(path);
                Bitmap resized = imagenOriginal;
                var maxWidth = PreviewPanel.Width;
                var maxHeight = PreviewPanel.Height;
                if (imagenOriginal.Width > maxWidth)
                {
                    var ratio = (double)imagenOriginal.Width / (double)maxWidth;
                    var height = Convert.ToInt32(Math.Round((double)imagenOriginal.Height / ratio));
                    resized = new Bitmap(imagenOriginal, new Size(maxWidth, height));
                }
                else if (imagenOriginal.Height > Height)
                {
                    var ratio = (double)imagenOriginal.Height / (double)Height;
                    var newWidth = Convert.ToInt32(Math.Round((double)imagenOriginal.Width / ratio));
                    resized = new Bitmap(imagenOriginal, new Size(newWidth, maxHeight));
                }
                var width =

                pictureBox.Image = resized;
                pictureBox.Show();
            }
            else if (ext == ".txt" || perceivedType == "text")
            {
                richTextBox.Text = System.IO.File.ReadAllText(path);
                richTextBox.Show();
            }
            else
            {
                //if (ext == ".doc" || ext == ".docx" || ext == ".xls" || ext == ".xlsx")
                //{
                previewHandlerHost1.Open(path);
                previewHandlerHost1.Show();
                //}
            }
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

        private void SetForm(Abstractions.File file)
        {
            if (file == null)
                return;
            CurrentFile = file;
            MatterTypeTextBox.Text = CurrentFile.MatterType.ToString();
            FileNumberTextBox.Text = CurrentFile.FileNumber.ToString();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            
            var selected = SelectedFile;
            if (selected == null)
                return;
            var archive = GetArchive();
            _archiveRepository.Insert(CurrentFile, archive);

            Archives.Add(archive);
            UploadedFiles.Remove(selected);
            ClearForm();
        }

        public Archive GetArchive()
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));

            var selected = FilesGridView.SelectedRows[0].DataBoundItem as FileInfo;
            var path = selected.FullName;
            var extension = Path.GetExtension(path);
            var newDirectory = Path.Combine(ConfigurationManager.AppSettings["FilesPath"], $"{CurrentFile.FileNumber}");
            if (!string.IsNullOrWhiteSpace(DocumentGroup.Text))
                newDirectory = Path.Combine(newDirectory, r.Replace(DocumentGroup.Text, ""));
            if (!string.IsNullOrWhiteSpace(DocumentCategory.Text))
                newDirectory = Path.Combine(newDirectory, r.Replace(DocumentCategory.Text, ""));
            

            if (!Directory.Exists(newDirectory))
                Directory.CreateDirectory(newDirectory);
            var newFileName = $"{r.Replace(DocumentName.Text, "")}{extension}";
            var newPath = Path.Combine(newDirectory, newFileName);
            System.IO.File.Copy(path, newPath, true);
            var archive = new Archive();
            archive.File = CurrentFile;
            archive.Path = newPath;
            archive.Name = newFileName;
            archive.DocumentFolder = DocumentGroup.Text;
            archive.DocumentCategory = DocumentCategory.Text;
            archive.DocumentDate = DocumentDate.Value;
            archive.DateRangeFrom = DateRangeFrom.Value;
            archive.DateRangeTo = DateRangeTo.Value;
            DocumentForm.SetArchive(archive);
            return archive;
        }

        private void ClearForm()
        {
            DocumentGroup.ResetText();
            DocumentCategory.ResetText();
            DocumentDate.ResetText();
            DateRangeFrom.ResetText();
            DateRangeTo.ResetText();
            DocumentForm.ClearForm();
            
        }

        private void DocumentFolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            var documentFolder = DocumentGroup.SelectedItem as DocumentGroup;
            if (documentFolder == null)
                return;
            Utils.SetComboBoxDataSource(DocumentCategory, _documentCategoryRepository.List().Where(s => s.DocumentGroup.ID == documentFolder.ID).ToList());
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
            var selected = ArchivesGridView.SelectedRows[0].DataBoundItem as Archive;
            if (selected == null)
                return;
            FilePreview(selected.Path);
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
            Utils.SetComboBoxDataSource(DocumentType, _documentTypeRepository.List().Where(s => s.DocumentCategory.ID == documentCategory.ID).ToList());
        }

        private void DocumentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var documentType = DocumentType.SelectedItem as DocumentType;
            if (documentType == null)
            {
                Utils.SetContent(DocumentFormContent, null);
                return;
            }
            

            if (documentType.DocumentForm == DocumentFormEnum.AdditionalInformation)
            {
                Utils.SetContent(DocumentFormContent, AdditionalInformationUserControl);
            }
            else if (documentType.DocumentForm == DocumentFormEnum.StandardBenefitsStatement)
            {
                Utils.SetContent(DocumentFormContent, StandardBenefitsStatementUserControl);
            }
            else if (documentType.DocumentForm == DocumentFormEnum.SenderRecipient)
            {
                Utils.SetContent(DocumentFormContent, SenderRecipientUserControl);
            }
            else if (documentType.DocumentForm == DocumentFormEnum.BenefitType)
            {
                Utils.SetContent(DocumentFormContent, BenefitTypeUserControl);
            }
            else if (documentType.DocumentForm == DocumentFormEnum.PreparedBy)
            {
                Utils.SetContent(DocumentFormContent, PreparedByUserControl);
            }
            else if (documentType.DocumentForm == DocumentFormEnum.MedicalRecord)
            {
                Utils.SetContent(DocumentFormContent, MedicalRecordUserControl);
            }
            else if (documentType.DocumentForm == DocumentFormEnum.MedicalRecordWithAmount)
            {
                Utils.SetContent(DocumentFormContent, MedicalRecordWithAmountUserControl);
            }
            else if (documentType.DocumentForm == DocumentFormEnum.BenefitsPaidToDate)
            {
                Utils.SetContent(DocumentFormContent, BenefitsPaidToDateUserControl);
            }

            if (DocumentForm == null || SelectedFile == null)
                return;
            DocumentForm?.SetDocumentType(documentType);
            DocumentForm?.SetDocumentDate(DocumentDate.Value);
            //DocumentForm?.SetDocumentExtension(SelectedFile?.Extension);
            DocumentForm?.SetFileNameControl(DocumentName);
            DocumentForm.OnChange();

        }
    }
}
