using RRFFilesManager.Abstractions;
using RRFFilesManager.Controls.PharmacyControls;
using RRFFilesManager.DataAccess;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.FileControls;
using RRFFilesManager.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Web;

namespace RRFFilesManager.Controls.PrescriptionSummariesControls
{
    public partial class PrescriptionSummariesForm : Form
    {
        public File File => findFileAndArchivePanelUserControl1.File;
        public Archive Archive => findFileAndArchivePanelUserControl1.Archive;
        public Pharmacy Pharmacy => pharmacyComboBox1.Pharmacy;
        public Drug Drug => drugComboBox1.Drug;
        private IPharmacyRepository _pharmacyRepository { get; set; }
        private IOutOfPocketHealthCareExpRepository _outOfPocketHealthCareExpRepository { get; set; }
        //public double? Distance { get; set; }

        BindingList<ArchiveControls.Models.Archive> Archives = new BindingList<ArchiveControls.Models.Archive>();
        public PrescriptionSummariesForm()
        {
            _pharmacyRepository = Program.GetService<IPharmacyRepository>();
            _outOfPocketHealthCareExpRepository = Program.GetService<IOutOfPocketHealthCareExpRepository>();
            InitializeComponent();

            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView.MultiSelect = false;
            DataGridView.ReadOnly = true;
            Utils.Utils.AddButtonToGridView(DataGridView, "Undo");
            DataGridView.DataSource = Archives;

        }
        private void SetForm()
        {
            SetForm(File);
            SetForm(Drug);
            SetForm(Pharmacy);
            //Distance = GetDistance();
        }
        private void SetForm(Drug drug)
        {
            ProductNameTB.Text = drug?.Name;
            StrengthTB.Text = drug?.Strength;
            NarcoticTB.Text = HasNarcotic(drug);
        }

        private void SetForm(Pharmacy pharmacy)
        {
            PharmacyPostalCodeTB.Text = pharmacy?.PostalCode;
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
            Archives.Add(new ArchiveControls.Models.Archive(value));
            ResetForm();
        }
        public OutOfPocketHealthCareExp InsertEntity()
        {
            var value = new OutOfPocketHealthCareExp();
            FillEntity(value);
            _outOfPocketHealthCareExpRepository.Insert(value);
            return value;
        }
        public void FillEntity(OutOfPocketHealthCareExp outOfPocketHealthCareExp)
        {
            outOfPocketHealthCareExp.File = File;
            outOfPocketHealthCareExp.Archive = Archive;
            outOfPocketHealthCareExp.Pharmacy = Pharmacy;
            outOfPocketHealthCareExp.RxFillDate = RxFillDateTB.Value;
            outOfPocketHealthCareExp.DispenseQuantity = Convert.ToInt32(DispenseQuantityNUD.Value);
            outOfPocketHealthCareExp.Drug = Drug;
            outOfPocketHealthCareExp.ReturnKilometresTraveled = GetDistance();
            outOfPocketHealthCareExp.TravelExpenses = outOfPocketHealthCareExp.ReturnKilometresTraveled * 0.5;
        }
        public new bool Validate()
        {
            if (File == null)
            {
                MessageBox.Show("Please select File");
                return false;
            }
            else if(Archive == null)
            {
                MessageBox.Show("Please select Archive");
                return false;
            }
            else if (Pharmacy == null)
            {
                MessageBox.Show("Please select Pharmacy");
                return false;
            }
            else if (Drug == null)
            {
                MessageBox.Show("Please select Drug");
                return false;
            }
            return true;
        }
        //private void ClearForm()
        //{
        //    findFileAndArchivePanelUserControl1.ClearForm();
        //    pharmacyComboBox1.Reset();
        //    RxFillDateTB.Value = DateTime.Now;
        //    DispenseQuantityNUD.ResetText();
        //    drugComboBox1.Reset();
        //    ProductNameTB.ResetText();
        //    StrengthTB.ResetText();
        //    NarcoticTB.ResetText();
        //}

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
            var clientPostalCode = Pharmacy?.PostalCode;
            var pharmacyPostalCode = File?.Client?.PostalCode;
            return GetDistance(clientPostalCode, pharmacyPostalCode);
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
        }

        private void drugComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetForm();
        }

        

        private string HasNarcotic(Drug drug)
        {
            if (drug == null)
                return null;
            var narcotics = new string[] { "CDSA I", "CDSA II", "CDSA III", "CDSA IIII" };
            var hasNarcotic = narcotics.Any(s => drug.Schedule.Contains(s));
            return hasNarcotic ? "Yes" : "";
        }

        private void previewArchiveUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void pharmacyComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetForm();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView?.SelectedRows?.Count == 0)
                return;
            var selected = DataGridView.SelectedRows[0].DataBoundItem as ArchiveControls.Models.Archive;
            if (selected == null)
                return;
            if (e.ColumnIndex == DataGridView.Columns["Undo"].Index)
            {
                UndoProcessedArchive(selected);
                return;
            }
            previewArchiveUserControl1.Preview(selected.Path);
        }
        private void UndoProcessedArchive(ArchiveControls.Models.Archive archive)
        {
            var originalEntity = archive.GetOutOfPocketHealthCareExp();
            _outOfPocketHealthCareExpRepository.Delete(originalEntity);
            Archives.Remove(archive);
        }
        private void ResetForm()
        {
            if (!KeepRxFillDate.Checked)
                RxFillDateTB.Value = DateTime.Now;

            pharmacyComboBox1.Reset();
            PharmacyPostalCodeTB.ResetText();
            ClientPostalCodeTB.ResetText();

            DispenseQuantityNUD.Value = 0;

            drugComboBox1.Reset();
            ProductNameTB.ResetText();
            StrengthTB.ResetText();
            NarcoticTB.ResetText();
        }

        private void CreatePharmacyButton_Click(object sender, EventArgs e)
        {
            var form = new CreatePharmacyForm();
            form.Show();
        }

        private void DrugCreateButton_Click(object sender, EventArgs e)
        {
            var form = new CreateDrugForm();
            form.Show();
        }
    }
}
