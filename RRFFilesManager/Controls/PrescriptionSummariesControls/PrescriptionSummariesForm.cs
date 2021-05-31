using RRFFilesManager.Abstractions;
using RRFFilesManager.Controls.PharmacyControls;
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
        public Pharmacy Pharmacy { get; set; }
        public PrescriptionSummariesForm()
        {
            InitializeComponent();
        }

        private void findFilePanelUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            
        }

        private void FindPharmacyButton_Click(object sender, EventArgs e)
        {
            FindPharmacy.Instance.Show();
            FindPharmacy.Instance.FormClosing += new FormClosingEventHandler(FindPharmacy_FormClosing);
        }

        private void FindPharmacy_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findPharmacyForm = sender as FindPharmacy;
            Pharmacy = findPharmacyForm.Selected;
        }
    }
}
