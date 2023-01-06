using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.ArchiveControls
{
    public partial class MedicalRecordUserControl : DocumentFormUserControl
    {
        public MedicalRecordUserControl()
        {
            InitializeComponent();
        }

        public override void ClearForm()
        {
            FacilityName.ResetText();
            HealthcarePractitioner.ResetText();
        }

        public override void FillArchiveInfo(Archive archive)
        {
            archive.FacilityName = FacilityName.Text;
            archive.HealthcarePractitioner = HealthcarePractitioner.Text;
        }
        //public override string GetFileName(string text, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, DocumentNameTypeEnum documentNameType = default)
        //{
        //    var filename = $"{base.GetFileName(text, documentDate, documentDateFrom, documentDateTo, documentNameType)}";
        //    if (!string.IsNullOrEmpty(FacilityName.Text))
        //        filename += $" - {FacilityName.Text}";
        //    else
        //        filename += $" - {HealthcarePractitioner.Text}";
        //    return filename;
        //}


        private void AdditionalInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FacilityName_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void HealthcarePractitioner_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
