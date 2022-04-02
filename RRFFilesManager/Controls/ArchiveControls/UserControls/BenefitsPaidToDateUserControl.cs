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

        public override void FillArchiveInfo(Archive archive)
        {
            archive.MRACPaidToDate = MRACPaidToDate.DollarValue.ToString();
            archive.ACPaidToDate = ACPaidToDate.DollarValue.ToString();
            archive.MRPaidToDate = MRPaidToDate.DollarValue.ToString();
            archive.HHPaidToDate = HHPaidToDate.DollarValue.ToString();
            archive.IEAssessPdToDate = IEAssessPdToDate.DollarValue.ToString();
            archive.IRBPaidToDate = IRBPaidToDate.DollarValue.ToString();
            archive.NonEarnerPdToDate = NonEarnerPdToDate.DollarValue.ToString();
            archive.CGPaidToDate = CGPaidToDate.DollarValue.ToString();
        }
        public override void ClearForm()
        {
            MRACPaidToDate.ResetText();
            ACPaidToDate.ResetText();
            MRPaidToDate.ResetText();
            IEAssessPdToDate.ResetText();
            HHPaidToDate.ResetText();
            IRBPaidToDate.ResetText();
            NonEarnerPdToDate.ResetText();
            CGPaidToDate.ResetText();
        }
        public override string GetFileName(string text, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, DocumentNameTypeEnum documentNameType = default)
        {
            return $"{base.GetFileName(text, documentDate, documentDateFrom, documentDateTo, documentNameType)}";
        }

        private void IEAssessPdToDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
