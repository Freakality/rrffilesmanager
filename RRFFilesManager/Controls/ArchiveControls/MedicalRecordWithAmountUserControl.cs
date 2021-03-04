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
            AdditionalInfo.ResetText();
            TypeOfAssessment.ResetText();
            TreatmentAmount.ResetText();
        }

        public override void SetArchive(Archive archive)
        {
            archive.FacilityName = FacilityName.Text;
            archive.HealthcarePractitioner = HealthcarePractitioner.Text;
            archive.AdditionalInfo = AdditionalInfo.Text;
            archive.TypeOfAssessment = TypeOfAssessment.Text;
            archive.TreatmentAmount = TreatmentAmount.Text;
        }

        public override string GetFileName(DocumentType documentType, DateTime documentDate)
        {
            var filename = $"{documentDate:yyyy-MM-dd} - {documentType.Description}";
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
    }
}
