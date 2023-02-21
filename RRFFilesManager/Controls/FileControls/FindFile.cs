using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.FileControls
{
    public partial class FindFile : Form
    {
        private readonly IFileRepository _fileRepository;
        private readonly IFileStatusRepository _fileStatusRepository;
        public FindFile()
        {
            _fileRepository = Program.GetService<IFileRepository>();
            _fileStatusRepository = Program.GetService<IFileStatusRepository>();
            InitializeComponent();
            Utils.Utils.SetComboBoxDataSource(FileStatusComboBox, _fileStatusRepository.List());
            //FileStatusComboBox.SelectedIndex = 1;
        }

        private static FindFile instance;
        public static FindFile Instance => instance == null || instance.IsDisposed ? (instance = new FindFile()) : instance;
        public Abstractions.File SelectedFile { get; set; }
        public Abstractions.FileStatus SelectedFileStatus { get; set; }
        private bool? OnlyHoldIntakes { get; set; }
        private void SearchBox_Enter(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshIntakeGridViewDataSource();
        }

        private void RefreshIntakeGridViewDataSource()
        {
            GridView.DataSource = _fileRepository.Search(SearchTextBox.Text, SelectedFileStatus, OnlyHoldIntakes, 20);
        }

        public void SetOnlyHoldIntakes(bool value)
        {
            OnlyHoldIntakes = value;
            RefreshIntakeGridViewDataSource();
        }

        private void IntakesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FindFile_Load(object sender, EventArgs e)
        {
            GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView.MultiSelect = false;
            GridView.ReadOnly = true;
            RefreshIntakeGridViewDataSource();
            GridView.Columns["ID"].Visible = false;
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRows = GridView?.SelectedRows;
            if (selectedRows?.Count > 0)
            {
                var fileId = int.Parse(GridView?.SelectedRows?[0]?.Cells?["ID"]?.Value.ToString());
                var file = _fileRepository.GetById(fileId);
                SelectedFile = file;
            }
            Close();
        }

        private void SearchBox_Enter_1(object sender, EventArgs e)
        {

        }

        private void FileStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedFileStatus = (Abstractions.FileStatus)FileStatusComboBox.SelectedItem;
            RefreshIntakeGridViewDataSource();
        }
    }
}
