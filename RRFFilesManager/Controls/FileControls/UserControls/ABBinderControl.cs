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

namespace RRFFilesManager.Controls.FileControls
{
    public partial class ABBinderControl : UserControl
    {
        string DOCUMENT_TEMPLATE_PATH = $"{AppDomain.CurrentDomain.BaseDirectory}\\DocumentTemplate\\AB Index.doc";
        private File File { get; set; }
        private List<ArchiveBinder> ArchivesBinder { get; set; }
        private List<ArchiveBinder> ArchivesBinderFiltered
        {
            get
            {
                var archives = ArchivesBinder
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
                items.AddRange(ArchivesBinder.Select(s => s.Type.Description).Distinct().ToList());
                return items;
            }
        }


        private List<string> IndexCategories => ArchivesBinder.Select(s => s.Type.IndexCategory).Distinct().ToList();

        private List<ArchiveBinder> ArchivesBinderToExport => (DataGridView.DataSource as SortableBindingList<ArchiveBinder>)?.Where(s => s.Check).ToList();

        private readonly IFileRepository _fileRepository;
        private readonly IArchiveRepository _archiveRepository;
        public ABBinderControl()
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
            ArchivesBinder = file.Archives.Where(s => s.DocumentGroup?.ID == 1).Select(s => new ArchiveBinder(s)).ToList();
            FillDataGridView();
            DocumentTypesBox.DataSource = DocumentTypes;
        }


        private void FillDataGridView()
        {
            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.MultiSelect = false;
            DataGridView.DataSource = new SortableBindingList<ArchiveBinder>(ArchivesBinder);
            DataGridView.ReadOnly = false;
            foreach (DataGridViewColumn column in DataGridView.Columns)
            {
                column.ReadOnly = true;
            }
            DataGridView.Columns["Check"].ReadOnly = false;
            DataGridView.Columns["Check"].HeaderText = "";


            if (DataGridView.Columns.Count == 0)
                return;
            DataGridView.Columns["ID"].Visible = false;

        }

        private void ExportWordButton_Click(object sender, EventArgs e)
        {
            ExportReport(".doc");
        }

        private void ExportPDFButton_Click(object sender, EventArgs e)
        {
            ExportReport(".pdf");
        }

        public void ExportReport(string extension)
        {
            if(ArchivesBinderToExport == null || ArchivesBinderToExport.Count() == 0)
            {
                MessageBox.Show("You must select at least one archive");
                return;
            }
                
            saveFileDialog1.DefaultExt = extension;
            saveFileDialog1.FileName = $"{DateTime.Now:yyyyyMMdd}_AB Index";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = saveFileDialog1.FileNames?.FirstOrDefault();
                    var wordApp = new Microsoft.Office.Interop.Word.Application();
                    wordApp.DisplayAlerts = WdAlertLevel.wdAlertsNone;
                    if (!System.IO.File.Exists(DOCUMENT_TEMPLATE_PATH))
                        throw new Exception($"{DOCUMENT_TEMPLATE_PATH} not found.");
                    var document = wordApp?.Documents.Open(FileName: DOCUMENT_TEMPLATE_PATH, ReadOnly: true);
                    try
                    {
                        wordApp.Visible = false;
                        Word.FillDocumentABBReport(document, File, ArchivesBinderToExport.Select(s => s.GetArchive()));
                        if (extension == ".doc")
                            document.SaveAs(filePath);
                        else if (extension == ".pdf")
                        {
                            document.SaveAs2(FileName: filePath, FileFormat: WdSaveFormat.wdFormatPDF);
                        }
                    }
                    catch
                    {

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

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void DocumentTypesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void OnChange()
        {
            DataGridView.DataSource = new SortableBindingList<ArchiveBinder>(ArchivesBinderFiltered);
        }
    }
}
