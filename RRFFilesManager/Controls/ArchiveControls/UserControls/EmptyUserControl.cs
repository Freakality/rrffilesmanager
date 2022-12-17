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
    public partial class EmptyUserControl : DocumentFormUserControl
    {
        public EmptyUserControl()
        {
            InitializeComponent();
        }
        public override void ClearForm()
        {

        }

        public override void FillArchiveInfo(Archive archive)
        {

        }

        //public override string GetFileName(string text, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, DocumentNameTypeEnum documentNameType = default)
        //{
        //    return $"{text}";
        //}
        private void EmptyUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
