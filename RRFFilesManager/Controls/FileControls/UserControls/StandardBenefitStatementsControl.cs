using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Office.Interop.Excel;
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
    public partial class StandardBenefitStatementsControl : UserControl
    {
        string DOCUMENT_TEMPLATE_PATH;
        private File File { get; set; }
        private bool Benefit { get; set; }
        private List<ArchiveBinder> ArchivesBinder { get; set; }
        private List<ArchiveBinder> ArchivesBinderFiltered
        {
            get
            {
                var archives = ArchivesBinder
                    .Where(s => s.Name.ToLower().Contains(SearchBox.Text.ToLower()) || s.Type.Description.ToLower().Contains(SearchBox.Text.ToLower()))
                    .ToList();
                return archives;
            }
        }
        private List<string> IndexCategories => ArchivesBinder.Select(s => s.Type.IndexCategory).Distinct().ToList();
        private List<ArchiveBinder> ArchivesBinderToExport => (DataGridView.DataSource as SortableBindingList<ArchiveBinder>)?.Where(s => s.Check).ToList();
        private readonly IFileRepository _fileRepository;
        private readonly IArchiveRepository _archiveRepository;

        public StandardBenefitStatementsControl(bool benefit = false)
        {
            Benefit = benefit;
            if (Benefit)
                DOCUMENT_TEMPLATE_PATH = $"{AppDomain.CurrentDomain.BaseDirectory}\\DocumentTemplate\\QuickABPaidToDate.xlsm";
            else
                DOCUMENT_TEMPLATE_PATH = $"{AppDomain.CurrentDomain.BaseDirectory}\\DocumentTemplate\\StandardBenefitStatements.xlsm";
            _fileRepository = Program.GetService<IFileRepository>();
            _archiveRepository = Program.GetService<IArchiveRepository>();
            InitializeComponent();
        }
        public void SetFile(File file)
        {
            File = file;
            if (file == null)
                return;
            if (Benefit)
            {
                ArchivesBinder = file.Archives.Where(s => s.DocumentType?.ID == 42).Select(s => new ArchiveBinder(s)).ToList();
            }
            else
            {
                ArchivesBinder = file.Archives.Where(s => s.DocumentType?.ID == 41 && s.StandardBenefitRows?.Count > 0).Select(s => new ArchiveBinder(s)).ToList();
            }
            FillDataGridView();
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
            if (Benefit)
                DataGridView.Columns["Check"].Visible = false;

            if (DataGridView.Columns.Count == 0)
                return;
            DataGridView.Columns["ID"].Visible = false;

        }
        public void ExportReport(string extension)
        {
            if ((ArchivesBinderToExport == null || ArchivesBinderToExport.Count() != 1) && !Benefit)
            {
                MessageBox.Show("You must select an archive");
                return;
            }
            List<ArchiveBinder> archiveContainer;
            if (Benefit)
            {
                archiveContainer = (DataGridView.DataSource as SortableBindingList<ArchiveBinder>).ToList();
            }
            else
            {
                archiveContainer = ArchivesBinderToExport;
            }
            var archives = archiveContainer.Select(s => s.GetArchive());
            saveFileDialog1.DefaultExt = extension;
            if (Benefit)
                saveFileDialog1.FileName = $"{DateTime.Now.ToString("MM-dd-yyyy")}_Quick AB Paid to Date";
            else
                saveFileDialog1.FileName = $"{System.IO.Path.GetFileNameWithoutExtension(archives.First().Name)}";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = saveFileDialog1.FileNames?.FirstOrDefault();
                    var excelApp = new Microsoft.Office.Interop.Excel.Application();
                    excelApp.DisplayAlerts = false;
                    if (!System.IO.File.Exists(DOCUMENT_TEMPLATE_PATH))
                        throw new Exception($"{DOCUMENT_TEMPLATE_PATH} not found.");
                    var workbook = excelApp?.Workbooks?.Open(Filename: DOCUMENT_TEMPLATE_PATH);
                    var worksheet = (Worksheet)workbook.Sheets[1];
                    try
                    {
                        //excelApp.Visible = false;
                        Excel.FillWorkSheet(worksheet, File, archives);
                        workbook.SaveAs(filePath);
                        MessageBox.Show($"File exported succesfully in directory: {filePath}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        workbook.Close(SaveChanges: false);
                        excelApp.Quit();
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
            if (File == null)
                return;
            DataGridView.DataSource = new SortableBindingList<ArchiveBinder>(ArchivesBinderFiltered);
        }

        private void ExportExcelButton_Click(object sender, EventArgs e)
        {
            ExportReport(".xlsm");
        }

        private void DataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == DataGridView.Columns["Check"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);

                // TODO: The radio button flickers on mouse over.
                // I tried setting DoubleBuffered on the parent panel, but the flickering persists.
                // If someone figures out how to resolve this, please leave a comment.

                System.Drawing.Rectangle rectRadioButton = new System.Drawing.Rectangle();
                // TODO: Would be nice to not use magic numbers here.
                rectRadioButton.Width = 14;
                rectRadioButton.Height = 14;
                rectRadioButton.X = e.CellBounds.X + (e.CellBounds.Width - rectRadioButton.Width) / 2;
                rectRadioButton.Y = e.CellBounds.Y + (e.CellBounds.Height - rectRadioButton.Height) / 2;

                ButtonState buttonState;
                if (e.Value == DBNull.Value || (bool)(e.Value) == false)
                {
                    buttonState = ButtonState.Normal;
                }
                else
                {
                    buttonState = ButtonState.Checked;
                }
                ControlPaint.DrawRadioButton(e.Graphics, rectRadioButton, buttonState);

                e.Paint(e.ClipBounds, DataGridViewPaintParts.Focus);

                e.Handled = true;
            }
        }

        private void DataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            radioButtonChanged();
        }
        private void radioButtonChanged()
        {
            if (DataGridView.CurrentCell.ColumnIndex == DataGridView.Columns["Check"].Index)
            {
                foreach (DataGridViewRow row in DataGridView.Rows)
                {
                    // Make sure not to uncheck the radio button the user just clicked.
                    if (row.Index != DataGridView.CurrentCell.RowIndex)
                    {
                        row.Cells[DataGridView.Columns["Check"].Index].Value = false;
                    }
                }
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataGridView.Columns["Check"].Index)
            {
                DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)DataGridView.Rows[e.RowIndex].Cells[DataGridView.Columns["Check"].Index];
                cell.Value = true;
                radioButtonChanged();
            }
        }
    }
}
