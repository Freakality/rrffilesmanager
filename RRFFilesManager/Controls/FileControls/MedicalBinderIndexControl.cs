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
    public partial class MedicalBinderIndexControl : UserControl
    {
        string DOCUMENT_TEMPLATE_PATH = $"{AppDomain.CurrentDomain.BaseDirectory}\\DocumentTemplate\\Medical Brief Index.docx";
        private File File { get; set; }
        private List<ArchiveBinderIndex> ArchivesBinderIndex { get; set; }
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
            ArchivesBinderIndex = file.Archives.Where(s => s.DocumentGroup?.ID == 3).Select(s => new ArchiveBinderIndex(s)).ToList();
            FillDataGridView();
        }


        private void FillDataGridView()
        {
            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.MultiSelect = false;
            DataGridView.DataSource = new SortableBindingList<ArchiveBinderIndex>(ArchivesBinderIndex);
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

        private Archive GetDataGridViewArchive()
        {
            var id = GetDataGridViewId();
            if (id == null)
                return null;
            return _archiveRepository.GetById(id.Value);
        }

        private int? GetDataGridViewId()
        {
            if (DataGridView?.SelectedRows.Count == 0)
                return null;
            var id = DataGridView?.SelectedRows?[0]?.Cells?["ID"]?.Value.ToString();
            if (id == null)
                return null;
            return int.Parse(id);
        }

        private void MedicalBinderIndexControl_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ExportReport(string extension)
        {
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
                    var document = wordApp?.Documents.Open(FileName: DOCUMENT_TEMPLATE_PATH, ReadOnly: true);
                    try
                    {
                        wordApp.Visible = false;
                        Word.FillDocument(document, File);
                        if (extension == "docx")
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

        private void ExportWordButton_Click(object sender, EventArgs e)
        {
            ExportReport(".docx");
        }

        private void ExportPDFButton_Click(object sender, EventArgs e)
        {
            ExportReport(".pdf");
        }
    }
}
