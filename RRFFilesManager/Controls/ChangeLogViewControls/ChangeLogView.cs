using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
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
using Task = RRFFilesManager.Abstractions.Task;

namespace RRFFilesManager.Controls.FileControls
{
    public partial class ChangeLogView : Form
    {
        public bool SettingFile = false;
        private readonly ILogItemRepository _logItemRepository;
        private Abstractions.Task TaskToAdd;
        public File File { get; set; }
        public ChangeLogView()
        {
            _logItemRepository = Program.GetService<ILogItemRepository>();
            InitializeComponent();
            LogGridView.DataSource = _logItemRepository.List();
            LogGridView.Columns["ID"].Width = 20;
            LogGridView.Columns["ID"].DisplayIndex = 0;
            LogGridView.Columns["ID"].HeaderText = "";
            LogGridView.Columns["Date"].DisplayIndex = 1;
            LogGridView.Columns["Lawyer"].DisplayIndex = 2;
            LogGridView.Columns["Lawyer"].HeaderText = "User";
            LogGridView.Columns["Description"].DisplayIndex = 3;
            LogGridView.Columns["Description"].HeaderText = "Log";
        }

        private static ChangeLogView instance;
        public static ChangeLogView Instance => instance == null || instance.IsDisposed ? (instance = new ChangeLogView()) : instance;

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Close();
            Home.Instance.Show();
        }

    }
}
