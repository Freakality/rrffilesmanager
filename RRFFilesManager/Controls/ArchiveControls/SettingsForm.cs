using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.ArchiveControls
{
    public partial class SettingsForm : Form
    {
        private static SettingsForm instance;
        public static SettingsForm Instance => instance == null || instance.IsDisposed ? (instance = new SettingsForm()) : instance;
        private readonly IUploadArchivesSettingsRepository _uploadArchivesSettingsRepository;
        private UploadArchivesSettings UploadArchivesSettings { get; set; }
        public SettingsForm()
        {
            _uploadArchivesSettingsRepository = Program.GetService<IUploadArchivesSettingsRepository>();
            
            InitializeComponent();
            InitializeSettings();
        }

        private void InitializeSettings()
        {
            UploadArchivesSettings = _uploadArchivesSettingsRepository.Get() ?? new UploadArchivesSettings();
            if (UploadArchivesSettings?.InputFolders != null)
                InputFolders.Items.AddRange(UploadArchivesSettings?.InputFolders?.Select(s => s.Path).ToArray());
        }

        private void Add_Click(object sender, EventArgs e)
        {
            var folder = Utils.Utils.GetFolderPathFromFindFileDialog();
            if (!Directory.Exists(folder))
            {
                MessageBox.Show("The folder could not be found");
                return;
            }
            if (InputFolders.Items.Contains(folder))
            {
                return;
            }

            InputFolders.Items.Add(folder);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
           var index = InputFolders.SelectedIndex;
            InputFolders.Items.RemoveAt(index);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var inputFolders = InputFolders.Items.Cast<string>().ToList();
            UploadArchivesSettings.InputFolders = inputFolders.Select(s => new FilePath { Path = s }).ToList();
            _uploadArchivesSettingsRepository.Set(UploadArchivesSettings);
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
