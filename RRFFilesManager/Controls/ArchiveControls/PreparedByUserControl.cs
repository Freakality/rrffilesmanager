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
    public partial class PreparedByUserControl : DocumentFormUserControl
    {
        public PreparedByUserControl()
        {
            InitializeComponent();
        }

        public override void ClearForm()
        {
            PreparedBy.ResetText();
        }

        public override void FillArchiveInfo(Archive archive)
        {
            archive.PreparedBy = PreparedBy.Text;
        }

        public override string GetFileName(DocumentType documentType, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, DocumentNameTypeEnum documentNameType = default)
        {
            return $"{base.GetFileName(documentType, documentDate, documentDateFrom, documentDateTo, documentNameType)}";
        }

        private void PreparedBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
