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
    public partial class StandardBenefitsStatementUserControl : DocumentFormUserControl
    {
        public StandardBenefitsStatementUserControl()
        {
            InitializeComponent();
        }

        public override void SetArchive(Archive archive)
        {
            archive.PolicyClaimLimit = PolicyClaimLimit.Text;
            archive.StatementPeriodFrom = StatementPeriodFrom.Value;
            archive.StatementPeriodTo = StatementPeriodTo.Value;
            archive.MRACPaidToDate = MRACPaidToDate.Text;
            archive.MRACRemaining = MRACRemaining.Text;
            archive.ACPaidToDate = ACPaidToDate.Text;
            archive.ACRemaining = ACRemaining.Text;
            archive.MRPaidToDate = MRPaidToDate.Text;
            archive.MRRemaining = MRRemaining.Text;
            archive.HHPaidToDate = HHPaidToDate.Text;
            archive.IEAssessPdToDate = IEAssessPdToDate.Text;
        }
        public override void ClearForm()
        {
            PolicyClaimLimit.ResetText();
            StatementPeriodFrom.ResetText();
            StatementPeriodTo.ResetText();
            MRACPaidToDate.ResetText();
            MRACRemaining.ResetText();
            ACPaidToDate.ResetText();
            ACRemaining.ResetText();
            MRPaidToDate.ResetText();
            MRRemaining.ResetText();
            IEAssessPdToDate.ResetText();
            HHPaidToDate.ResetText();
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HHPaidToDate_TextChanged(object sender, EventArgs e)
        {

        }

        public override string GetFileName(DocumentType documentType, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null)
        {
            return $"{base.GetFileName(documentType, documentDate, documentDateFrom, documentDateTo)}";
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void IEAssessPdToDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
