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
    public partial class NameUserControl : DocumentFormUserControl
    {
        public NameUserControl()
        {
            InitializeComponent();
        }

        public override void ClearForm()
        {
            Name.ResetText();
        }

        public override void FillArchiveInfo(Archive archive)
        {
            archive.DocumentName = Name.Text;
        }

        public override string GetFileName(DocumentType documentType, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, DocumentNameTypeEnum documentNameType = default)
        {
            //[Document Type] -of[Name of Party] - [Document Date]
            var datePart = GetFileNameDatePart(documentDate, documentDateFrom, documentDateTo);
            return $"{documentType.Description} - of {Name.Text} - {datePart}";
        }


        private void Name_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }
    }
}
