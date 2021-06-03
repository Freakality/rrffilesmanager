using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.FileControls;
using RRFFilesManager.Logic;
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
    public partial class FindFileAndArchivePanelUserControl : UserControl
    {
        public File File { get; set; }
        public Archive Archive { get; set; }
        private IArchiveRepository _archiveRepository;
        public ComboBox ArchivesComboBox => ArchivesCB;
        public FindFileAndArchivePanelUserControl()
        {
            _archiveRepository = Program.GetService<IArchiveRepository>();
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

        private void SetForm(File file)
        {
            if (file == null)
                return;
            File = file;
            Utils.SetComboBoxDataSource(ArchivesCB, _archiveRepository.List(File));
            FileNumberTextBox.Text = File.FileNumber.ToString();
        }

        private void ArchivesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Archive = ArchivesCB.SelectedItem as Archive;
        }
    }
}
