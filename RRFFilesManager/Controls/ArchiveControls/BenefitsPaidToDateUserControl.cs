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
    public partial class BenefitsPaidToDateUserControl : DocumentFormUserControl
    {
        public BenefitsPaidToDateUserControl()
        {
            InitializeComponent();
        }

        public override void SetArchive(Archive archive)
        {
            archive.MRACPaidToDate = MRACPaidToDate.Text;
            archive.ACPaidToDate = ACPaidToDate.Text;
            archive.MRPaidToDate = MRPaidToDate.Text;
            archive.HHPaidToDate = HHPaidToDate.Text;
            archive.IEAssessPdToDate = IEAssessPdToDate.Text;
        }
        public override void ClearForm()
        {
            MRACPaidToDate.ResetText();
            ACPaidToDate.ResetText();
            MRPaidToDate.ResetText();
            IEAssessPdToDate.ResetText();
            HHPaidToDate.ResetText();
        }
        public override string GetFileName(DocumentType documentType, DateTime documentDate)
        {
            return $"{documentDate:yyyy-MM-dd} - {documentType.Description}";
        }

        private void IEAssessPdToDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
