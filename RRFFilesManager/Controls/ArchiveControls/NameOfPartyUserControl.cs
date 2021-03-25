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
    public partial class NameOfPartyUserControl : DocumentFormUserControl
    {
        public NameOfPartyUserControl()
        {
            InitializeComponent();
        }

        public override void ClearForm()
        {
            NameOfParty.ResetText();
        }

        public override void FillArchiveInfo(Archive archive)
        {
            archive.NameOfParty = NameOfParty.Text;
        }

        public override string GetFileName(DocumentType documentType, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, DocumentNameTypeEnum documentNameType = default)
        {
            //[Document Type] -of[Name of Party] - [Document Date]
            var datePart = GetFileNameDatePart(documentDate, documentDateFrom, documentDateTo);
            return $"{documentType.Description} - of {NameOfParty.Text} - {datePart}";
        }

        private void NameOfParty_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
