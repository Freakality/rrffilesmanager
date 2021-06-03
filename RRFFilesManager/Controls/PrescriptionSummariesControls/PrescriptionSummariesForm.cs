using RRFFilesManager.Abstractions;
using RRFFilesManager.Controls.PharmacyControls;
using RRFFilesManager.DataAccess;
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

namespace RRFFilesManager.Controls.PrescriptionSummariesControls
{
    public partial class PrescriptionSummariesForm : Form
    {
        public File File => findFileAndArchivePanelUserControl1.File;
        public Archive Archive => findFileAndArchivePanelUserControl1.Archive;
        public Pharmacy Pharmacy => pharmacyComboBox1.Pharmacy;
        public Drug Drug => drugComboBox1.Drug;
        private IPharmacyRepository _pharmacyRepository { get; set; }
        public PrescriptionSummariesForm()
        {
            _pharmacyRepository = Program.GetService<IPharmacyRepository>();
            InitializeComponent();
        }

        private void findFilePanelUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (File == null)
            {
                MessageBox.Show("File can not be null");
                return;
            }
            ProcessArchive(Archive);
            ClearForm();
            FilesGridView_CellClick(null, null);
        }

        private void ProcessArchive(Archive archive)
        {
            
            UploadedFiles.Remove(selected);
        }

        private void PrescriptionSummariesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Utils.CloseForm(this, Home.Instance);
        }

        private void PharmaciesCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void findFileAndArchivePanelUserControl1_Load(object sender, EventArgs e)
        {
            var archiveCB = findFileAndArchivePanelUserControl1.ArchivesComboBox;
            archiveCB.SelectedIndexChanged += ArchivesCB_SelectedIndexChanged;
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
            ProductNameTB.Text = Drug?.Name;
            StrengthTB.Text = Drug?.Strength;
            NarcoticTB.Text = Drug?.Schedule;
        }

        private void previewArchiveUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void pharmacyComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PharmacyPostalCodeTB.Text = Pharmacy?.PostalCode;
            ClientPostalCodeTB.Text = File?.Client?.PostalCode;
        }
    }
}
