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

namespace RRFFilesManager.Controls.FileControls.UserControls
{
    public partial class PrescriptionSummariesControl : UserControl
    {
        string DOCUMENT_TEMPLATE_PATH = $"{AppDomain.CurrentDomain.BaseDirectory}\\DocumentTemplate\\Prescription Summaries.docx";
        private File File { get; set; }
        private List<Prescription> Prescriptions { get; set; }
        private List<Prescription> PrescriptionsFiltered
        {
            get
            {
                var items = Prescriptions
                    .Where(s => s.HealthPractitionerClinic.Name.ToLower().Contains(SearchBox.Text.ToLower()))
                    .Where(s => string.IsNullOrWhiteSpace(PharmaciesBox.Text) || PharmaciesBox.Text == s.HealthPractitionerClinic?.Name)
                    .ToList();
                return items;
            }
        }

        private List<string> Pharmacies
        {
            get
            {
                var items = new List<string>();
                items.Add("");
                items.AddRange(Prescriptions.Select(s => s.HealthPractitionerClinic.Name).Distinct().ToList());
                return items;
            }
        }

        private List<Prescription> PrescriptionsToExport => (DataGridView.DataSource as SortableBindingList<Prescription>)?.Where(s => s.Check).ToList();

        private readonly IFileRepository _fileRepository;
        private readonly IOutOfPocketHealthCareExpRepository _outOfPocketHealthCareExpRepository;
        public PrescriptionSummariesControl()
        {
            _fileRepository = Program.GetService<IFileRepository>();
            _outOfPocketHealthCareExpRepository = Program.GetService<IOutOfPocketHealthCareExpRepository>();
            InitializeComponent();
        }
        public void SetFile(File file)
        {
            File = file;
            if (file == null)
                return;
            Prescriptions = file.Prescriptions.Select(s => new Prescription(s)).ToList();
            Utils.Utils.InitializeDataGridViewWithCheck(DataGridView, Prescriptions);
            PharmaciesBox.DataSource = Pharmacies;
        }
        private void ExportWordButton_Click(object sender, EventArgs e)
        {
            ExportReport(".docx");
        }

        private void ExportPDFButton_Click(object sender, EventArgs e)
        {
            ExportReport(".pdf");
        }

        public void ExportReport(string extension)
        {
            if (PrescriptionsToExport == null || PrescriptionsToExport.Count() == 0)
            {
                MessageBox.Show("You must select at least one archive");
                return;
            }
            saveFileDialog1.DefaultExt = extension;
            saveFileDialog1.FileName = $"{DateTime.Now:yyyyyMMdd}_Prescription Summaries";
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
                        Word.FillDocumentPrescriptionsReport(document, File, PrescriptionsToExport.Select(s => s.GetEntity()));
                        if (extension == ".docx")
                            document.SaveAs(filePath);
                        else if (extension == ".pdf")
                        {
                            document.SaveAs2(FileName: filePath, FileFormat: WdSaveFormat.wdFormatPDF);
                        }
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show($"Error trying to generate report. ${e.Message}");
                    }
                    finally
                    {
                        document.Close(SaveChanges: false);
                        wordApp.Quit();
                    }
                    Word.Open(filePath);
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

        private void PharmaciesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        public void OnChange()
        {
            DataGridView.DataSource = new SortableBindingList<Prescription>(PrescriptionsFiltered);
        }
    }
}
