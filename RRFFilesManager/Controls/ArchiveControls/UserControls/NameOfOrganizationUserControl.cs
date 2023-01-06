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
    public partial class NameOfOrganizationUserControl : DocumentFormUserControl
    {
        public NameOfOrganizationUserControl()
        {
            InitializeComponent();
        }

        public override void ClearForm()
        {
            NameOfOrganization.ResetText();
        }

        public override void FillArchiveInfo(Archive archive)
        {
            archive.NameOfOrganization = NameOfOrganization.Text;
        }

        //public override string GetFileName(string text, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, DocumentNameTypeEnum documentNameType = default)
        //{
        //    //[Document Type] -of[Name of Party] - [Document Date]
        //    var datePart = GetFileNameDatePart(documentDate, documentDateFrom, documentDateTo);
        //    return $"{text} - of {NameOfOrganization.Text} - {datePart}";
        //}

        private void NameOfOrganization_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
