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
    public partial class MedicalRecordWithAmountUserControl : DocumentFormUserControl
    {
        public MedicalRecordWithAmountUserControl()
        {
            InitializeComponent();
        }

        public override void ClearForm()
        {
            FacilityName.ResetText();
            HealthcarePractitioner.ResetText();
            TypeOfAssessment.ResetText();
            TreatmentAmount.ResetText();
        }

        public override void SetArchive(Archive archive)
        {
            archive.FacilityName = FacilityName.Text;
            archive.HealthcarePractitioner = HealthcarePractitioner.Text;
            archive.TypeOfAssessment = TypeOfAssessment.Text;
            archive.TreatmentAmount = TreatmentAmount.Text;
        }

        public override string GetFileName(DocumentType documentType, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null)
        {
            var filename = $"{base.GetFileName(documentType, documentDate, documentDateFrom, documentDateTo)}";
            if (!string.IsNullOrEmpty(FacilityName.Text))
                filename += $" - {FacilityName.Text}";
            else
                filename += $" - {HealthcarePractitioner.Text}";
            return $"{filename} - {TypeOfAssessment.Text} - {TreatmentAmount.Text}";
        }


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

        private void TypeOfAssessment_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void TreatmentAmount_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
