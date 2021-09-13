using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.MedicalSummariesControls
{
    public partial class MedicalSummariesForm : Form
    {
        public File File => findFileAndArchivePanelUserControl1.File;
        public Archive Archive => findFileAndArchivePanelUserControl1.Archive;
        public DocumentGroup DocumentGroup => DocumentGroupCB.SelectedItem as DocumentGroup;
        public DocumentCategory DocumentCategory => DocumentCategoryCB.SelectedItem as DocumentCategory;
        public DocumentType DocumentType => DocumentTypeCB.SelectedItem as DocumentType;

        private readonly IDocumentGroupRepository _documentGroupRepository;
        private readonly IDocumentCategoryRepository _documentCategoryRepository;
        private readonly IDocumentTypeRepository _documentTypeRepository;
        private readonly IMedicalSummaryRepository _medicalSummaryRepository;
        //public double? Distance { get; set; }

        BindingList<ArchiveControls.Models.Archive<MedicalSummary>> Archives = new BindingList<ArchiveControls.Models.Archive<MedicalSummary>>();
        public MedicalSummariesForm()
        {
            _documentGroupRepository = Program.GetService<IDocumentGroupRepository>();
            _documentCategoryRepository = Program.GetService<IDocumentCategoryRepository>();
            _documentTypeRepository = Program.GetService<IDocumentTypeRepository>();
            _medicalSummaryRepository = Program.GetService<IMedicalSummaryRepository>();
            InitializeComponent();

            Utils.Utils.SetComboBoxDataSource(DocumentGroupCB, _documentGroupRepository.List());

            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView.MultiSelect = false;
            DataGridView.ReadOnly = true;
            Utils.Utils.AddButtonToGridView(DataGridView, "Undo");
            DataGridView.DataSource = Archives;

        }
        private void SetForm()
        {
            SetForm(File);
            SetForm(Archive);
            //Distance = GetDistance();
        }

        private void SetForm(Archive archive)
        {
            DocumentGroupCB.Text = archive?.DocumentGroup?.Description;
            DocumentCategoryCB.Text = archive?.DocumentCategory?.Description;
            DocumentTypeCB.Text = archive?.DocumentType?.Description;
        }
        private void SetForm(File file)
        {
            ClientPostalCodeTB.Text = file?.Client?.PostalCode;
        }

        private void findFilePanelUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;
            var value = InsertEntity();
            Archives.Add(new ArchiveControls.Models.Archive<MedicalSummary>(value, value.Archive));
            Archive.Open();
            ResetForm();
        }
        public MedicalSummary InsertEntity()
        {
            var value = new MedicalSummary();
            FillEntity(value);
            _medicalSummaryRepository.Insert(value);
            return value;
        }
        public void FillEntity(MedicalSummary medicalSummary)
        {
            medicalSummary.File = File;
            medicalSummary.Archive = Archive;
            medicalSummary.DocumentGroup = DocumentGroup;
            medicalSummary.DocumentCategory = DocumentCategory;
            medicalSummary.DocumentType = DocumentType;
            medicalSummary.DocumentDate = DocumentDateDTP.Value;
            medicalSummary.DistanceKilometres = GetDistance();
            medicalSummary.DocumentSummary = DocumentSummaryTB.Text;
            medicalSummary.ClientPostalCode = ClientPostalCodeTB.Text;
            medicalSummary.TreatmentCentrePostalCode = TreatmentCentrePostalCodeTB.Text;
        }
        public new bool Validate()
        {
            if (File == null)
            {
                MessageBox.Show("Please select File");
                return false;
            }
            else if (Archive == null)
            {
                MessageBox.Show("Please select Archive");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(DocumentDateDTP.Text))
            {
                MessageBox.Show("Please enter a valid Document Date");
                return false;
            }
            else if (DocumentGroup == null)
            {
                MessageBox.Show("Please select Document Group");
                return false;
            }
            else if (string.IsNullOrWhiteSpace(DocumentSummaryTB.Text))
            {
                MessageBox.Show("Document Summary is required");
                return false;
            }
            return true;
        }
        private void ClearForm()
        {
            findFileAndArchivePanelUserControl1.ClearForm();
            DocumentDateDTP.ResetText();
            DocumentGroupCB.ResetText();
            DocumentCategoryCB.ResetText();
            DocumentTypeCB.ResetText();
            ClientPostalCodeCKB.ResetText();
            ClientPostalCodeTB.ResetText();
            TreatmentCentrePostalCodeCKB.ResetText();
            TreatmentCentrePostalCodeTB.ResetText();
            DocumentSummaryTB.ResetText();
        }

        private void PrescriptionSummariesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.Utils.CloseForm(this, Home.Instance);
        }

        private void PharmaciesCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void findFileAndArchivePanelUserControl1_Load(object sender, EventArgs e)
        {
            var archiveCB = findFileAndArchivePanelUserControl1.ArchivesComboBox;
            archiveCB.SelectedIndexChanged += ArchivesCB_SelectedIndexChanged;
        }

        private double? GetDistance()
        {
            var clientPostalCode = File?.Client?.PostalCode;
            var treatmentCentrePostalCode = TreatmentCentrePostalCodeTB.Text;
            return GetDistance(clientPostalCode, treatmentCentrePostalCode);
        }
        private double? GetDistance(string fromPostalCode, string toPostalCode)
        {
            if (fromPostalCode == null || toPostalCode == null)
                return null;
            var distance = Utils.Distance.BetweenTwoPostCodes(fromPostalCode, toPostalCode);
            return distance;
        }

        private void ArchivesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var archive = findFileAndArchivePanelUserControl1.Archive;
            if (archive == null)
                return;
            previewArchiveUserControl1.Preview(archive.Path);
            SetForm();
        }


        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView?.SelectedRows?.Count == 0)
                return;
            var selected = DataGridView.SelectedRows[0].DataBoundItem as ArchiveControls.Models.Archive<MedicalSummary>;
            if (selected == null)
                return;
            if (e.ColumnIndex == DataGridView.Columns["Undo"].Index)
            {
                UndoProcessedArchive(selected);
                return;
            }
            previewArchiveUserControl1.Preview(selected.Path);
        }
        private void UndoProcessedArchive(ArchiveControls.Models.Archive<MedicalSummary> archive)
        {
            var originalEntity = archive.GetOriginalEntity();
            _medicalSummaryRepository.Delete(originalEntity);
            Archives.Remove(archive);
        }
        private void ResetForm()
        {
            if (!DocumentGroupCKB.Checked)
                DocumentGroupCB.ResetText();
            if (!DocumentCategoryCKB.Checked)
                DocumentCategoryCB.ResetText();
            if (!DocumentTypeCKB.Checked)
                DocumentTypeCB.ResetText();
            if (!DocumentDateDTP.Checked)
                DocumentDateDTP.Value = DateTime.Now;
            if (!ClientPostalCodeCKB.Checked)
                ClientPostalCodeTB.ResetText();
            if (!TreatmentCentrePostalCodeCKB.Checked)
                TreatmentCentrePostalCodeTB.ResetText();
            DocumentSummaryTB.ResetText();
        }

        private void previewArchiveUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void DocumentGroupCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DocumentGroup == null)
                return;
            Utils.Utils.SetComboBoxDataSource(DocumentTypeCB, new List<DocumentType>());
            Utils.Utils.SetComboBoxDataSource(DocumentCategoryCB, _documentCategoryRepository.List().Where(s => s.DocumentGroup.ID == DocumentGroup.ID).ToList());
        }

        private void DocumentTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DocumentCategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DocumentCategory == null)
                return;
            Utils.Utils.SetComboBoxDataSource(DocumentTypeCB, _documentTypeRepository.List().Where(s => s.DocumentCategory.ID == DocumentCategory.ID).ToList());
        }

        private void findFileAndArchivePanelUserControl1_Load_1(object sender, EventArgs e)
        {
            var archiveCB = findFileAndArchivePanelUserControl1.ArchivesComboBox;
            archiveCB.SelectedIndexChanged += ArchivesCB_SelectedIndexChanged;
        }
    }
}
