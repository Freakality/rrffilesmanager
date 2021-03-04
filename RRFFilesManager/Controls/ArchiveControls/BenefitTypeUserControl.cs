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

        public override void SetArchive(Archive archive)
        {
            archive.BenefitType = BenefitType.Text;
        }

        public override string GetFileName(DocumentType documentType, DateTime documentDate)
        {
            return $"{documentDate:yyyy-MM-dd} - {documentType.Description} - {BenefitType.Text}";
        }

        private void BenefitType_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnChange();
        }
    }
}
