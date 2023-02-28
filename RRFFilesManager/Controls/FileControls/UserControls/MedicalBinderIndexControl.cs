using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Office.Interop.Word;
using RRFFilesManager.Abstractions;
using RRFFilesManager.Controls.FileControls.Models;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRFFilesManager.Utils;

namespace RRFFilesManager.Controls.FileControls
{
    public partial class MedicalBinderIndexControl : UserControl
    {
        string DOCUMENT_TEMPLATE_PATH = $"{AppDomain.CurrentDomain.BaseDirectory}\\DocumentTemplate\\Medical Brief Index.docx";
        private File File { get; set; }
        private List<ArchiveBinderIndex> ArchivesBinderIndex { get; set; }
        private List<ArchiveBinderIndex> ArchivesBinderIndexFiltered { 
            get 
            {
                var archives = ArchivesBinderIndex
                    .Where(s => s.Name.ToLower().Contains(SearchBox.Text.ToLower()) || s.Type.Description.ToLower().Contains(SearchBox.Text.ToLower()))
                    .Where(s => string.IsNullOrWhiteSpace(DocumentTypesBox.Text) || DocumentTypesBox.Text == s.Type?.Description)
                    .ToList();
                return archives;
            } 
        }

        private List<string> DocumentTypes
        {
            get
            {
                var items = new List<string>();
                items.Add("");
                items.AddRange(ArchivesBinderIndex.Select(s => s.Type.Description).Distinct().ToList());
                return items;
            }
        }
        

        private List<string> IndexCategories => ArchivesBinderIndex.Select(s => s.Type.IndexCategory).Distinct().ToList();

        private List<ArchiveBinderIndex> ArchivesBinderIndexToExport => (DataGridView.DataSource as SortableBindingList<ArchiveBinderIndex>)?.Where(s => s.Check).ToList();

        private readonly IFileRepository _fileRepository;
        private readonly IArchiveRepository _archiveRepository;
        public MedicalBinderIndexControl()
        {
            _fileRepository = Program.GetService<IFileRepository>();
            _archiveRepository = Program.GetService<IArchiveRepository>();
            InitializeComponent();
        }

        public void SetFile(File file)
        {
            File = file;
            if (file == null)
                return;
            ArchivesBinderIndex = file.Archives.Where(s => s.DocumentGroup?.ID == 3).Select(s => new ArchiveBinderIndex(s)).ToList();
            Utils.Utils.InitializeDataGridViewWithCheck(DataGridView, ArchivesBinderIndex);
            DocumentTypesBox.DataSource = DocumentTypes;
        }

        private Archive GetDataGridViewArchive()
        {
            var id = Utils.Utils.GetDataGridViewId(DataGridView);
            if (id == null)
                return null;
            return _archiveRepository.GetById(id.Value);
        }

        private void MedicalBinderIndexControl_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ExportReport(string extension)
        {
            if (ArchivesBinderIndexToExport == null || ArchivesBinderIndexToExport.Count() == 0)
            {
                MessageBox.Show("You must select at least one archive");
                return;
            }
            saveFileDialog1.DefaultExt = extension;
            saveFileDialog1.FileName = $"{DateTime.Now:yyyyyMMdd}_Medical Brief Index";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = saveFileDialog1.FileNames?.FirstOrDefault();
                    var wordApp = new Microsoft.Office.Interop.Word.Application();
                    wordApp.DisplayAlerts = WdAlertLevel.wdAlertsNone;
                    if (!System.IO.File.Exists(DOCUMENT_TEMPLATE_PATH))
                        throw new Exception($"{DOCUMENT_TEMPLATE_PATH} not found.");
                    var document = wordApp?.Documents.Open(FileName: DOCUMENT_TEMPLATE_PATH);
                    try
                    {
                        wordApp.Visible = false;
                        Word.FillDocumentMBIReport(document, File, ArchivesBinderIndexToExport.Select(s => s.GetArchive()));
                        if (extension == ".docx")
                            document.SaveAs(filePath);
                        else if (extension == ".pdf")
                        {
                            document.SaveAs2(FileName: filePath, FileFormat: WdSaveFormat.wdFormatPDF);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"Error.\n\nError message: {ex.Message}\n\n" +
                        $"Details:\n\n{ex.StackTrace}");
                    }
                    finally
                    {
                        document.Close(SaveChanges: false);
                        wordApp.Quit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void ExportWordButton_Click(object sender, EventArgs e)
        {
            ExportReport(".docx");
        }

        private void ExportPDFButton_Click(object sender, EventArgs e)
        {
            ExportReport(".pdf");
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        public void OnChange()
        {
            DataGridView.DataSource = new SortableBindingList<ArchiveBinderIndex>(ArchivesBinderIndexFiltered);
        }

        private void DocumentTypesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void IndexCategoriesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
