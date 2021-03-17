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
    public partial class AdditionalInformationUserControl : DocumentFormUserControl
    {
        public AdditionalInformationUserControl() : base()
        {
            InitializeComponent();
        }

        public override void ClearForm()
        {
            AdditionalInfo.ResetText();
        }

        public override void SetArchive(Archive archive)
        {
            archive.AdditionalInfo = AdditionalInfo.Text;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdditionalInfo_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public override string GetFileName(DocumentType documentType, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null)
        {
            var filename = $"{base.GetFileName(documentType, documentDate, documentDateFrom, documentDateTo)}";
            if (!string.IsNullOrWhiteSpace(AdditionalInfo.Text))
                filename += $" - {AdditionalInfo.Text}";
            return filename;
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
