using RRFFilesManager.FileControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.CommonControls
{
    public partial class FindFilePanelUserControl : UserControl
    {
        public Abstractions.File File { get; set; }
        public FindFilePanelUserControl()
        {
            InitializeComponent();
        }

        private void FindFileButton_Click(object sender, EventArgs e)
        {
            FindFile.Instance.Show();
            FindFile.Instance.FormClosing += new FormClosingEventHandler(FindFile_FormClosing);
        }
        private void FindFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findFileForm = sender as FindFile;
            SetForm(findFileForm.SelectedFile);
        }

        private void SetForm(Abstractions.File file)
        {
            if (file == null)
                return;
            File = file;
            MatterTypeTextBox.Text = File.MatterType?.ToString();
            FileNumberTextBox.Text = File.FileNumber.ToString();
        }
    }
}
