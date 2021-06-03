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
    public partial class NameAndTypeOfPartyAndTypeOfMotionUserControl : DocumentFormUserControl
    {
        public NameAndTypeOfPartyAndTypeOfMotionUserControl()
        {
            InitializeComponent();
        }

        public override void ClearForm()
        {
            NameOfParty.ResetText();
            TypeOfParty.ResetText();
            TypeOfMotion.ResetText();
        }

        public override void FillArchiveInfo(Archive archive)
        {
            archive.NameOfParty = NameOfParty.Text;
            archive.TypeOfParty = TypeOfParty.Text;
            archive.TypeOfMotion = TypeOfMotion.Text;
        }

        public override string GetFileName(string text, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, DocumentNameTypeEnum documentNameType = default)
        {
            //[Document Type] -of[Name of Party] - [Type of Party] - [Type of Motion] - [Document Date]
            var datePart = GetFileNameDatePart(documentDate, documentDateFrom, documentDateTo);
            return $"{text} - of {NameOfParty.Text} - {TypeOfParty.Text} - {TypeOfMotion.Text} - {datePart}";
        }

        private void NameOfParty_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            OnChange();
        }

        private void TypeOfMotion_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TypeOfParty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
