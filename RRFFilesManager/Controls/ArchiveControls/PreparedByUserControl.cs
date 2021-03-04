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

        public override void SetArchive(Archive archive)
        {
            archive.PreparedBy = PreparedBy.Text;
        }

        public override string GetFileName(DocumentType documentType, DateTime documentDate)
        {
            return $"{documentDate:yyyy-MM-dd} - {documentType.Description}";
        }

        private void PreparedBy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
