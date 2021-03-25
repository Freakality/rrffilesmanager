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
    public partial class BenefitTypeUserControl : DocumentFormUserControl
    {
        public BenefitTypeUserControl()
        {
            InitializeComponent();
        }

        public override void ClearForm()
        {
            BenefitType.ResetText();
        }

        public override void FillArchiveInfo(Archive archive)
        {
            archive.BenefitType = BenefitType.Text;
        }

        public override string GetFileName(string text, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, DocumentNameTypeEnum documentNameType = default)
        {
            return $"{base.GetFileName(text, documentDate, documentDateFrom, documentDateTo, documentNameType)} - {BenefitType.Text}";
        }

        private void BenefitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
