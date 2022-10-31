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
    public partial class AddTaskManager : Form
    {
        public bool SettingFile = false;
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskCategoryRepository _taskCategoryRepository;
        private readonly IFileRepository _fileRepository;
        private readonly ITaskStateRepository _taskStateRepository;
        private Abstractions.Task TaskToAdd;
        public File File { get; set; }
        public FileTask SelectedFileTask { get; set; }
        public AddTaskManager()
        {
            _fileRepository = Program.GetService<IFileRepository>();
            _taskRepository = Program.GetService<ITaskRepository>();
            _taskCategoryRepository = Program.GetService<ITaskCategoryRepository>();
            _taskStateRepository = Program.GetService<ITaskStateRepository>();
            InitializeComponent();
            RefreshTaskCategoryCBoxDataSource();
        }

        private static AddTaskManager instance;
        public static AddTaskManager Instance => instance == null || instance.IsDisposed ? (instance = new AddTaskManager()) : instance;
        public Abstractions.Task SelectedTask { get; set; }
        private bool? OnlyHoldIntakes { get; set; }
        /*private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshTaskGridViewDataSource();
        }*/
        private void RefreshTaskCategoryCBoxDataSource()
        {
            CBoxTaskCategory.DataSource = _taskCategoryRepository.List();
            CBoxTaskCategory.ValueMember = "ID";
            CBoxTaskCategory.DisplayMember = "Description";
        }
        private void RefreshTaskGridViewDataSource()
        {
            /*int taskCategoryID = -1;
            if (!(CBoxTaskCategory.SelectedValue is null))
            {
                if (!Int32.TryParse(CBoxTaskCategory.SelectedValue.ToString(), out taskCategoryID))
                {
                    taskCategoryID = -1;
                }
            }*/
            TaskGridView.DataSource = File.Tasks.ToList();
            TaskGridView.Columns["ID"].Visible = false;
            TaskGridView.Columns["File"].Visible = false;
            TaskGridView.Columns["FileId"].Visible = false;
            TaskGridView.Columns["TaskId"].Visible = false;
            TaskGridView.Columns["DueDate"].HeaderText = "Due Date";
            TaskGridView.Columns["DeferUntilDate"].HeaderText = "Defer Until Date";
            TaskGridView.Columns["TaskStartedDate"].HeaderText = "Started Date";
            TaskGridView.Columns["WorkedOnDate1"].HeaderText = "Worked On Date 1";
            TaskGridView.Columns["WorkedOnDate2"].HeaderText = "Worked On Date 2";
            TaskGridView.Columns["WorkedOnDate3"].HeaderText = "Worked On Date 3";
            TaskGridView.Columns["NotifiedRRFDate"].HeaderText = "Notified RRF Date";
            TaskGridView.Columns["CompletedDate"].HeaderText = "Completed Date";
            if (File.Tasks.ToList().Count == 0)
                BtnEditSelectedTextButton.Enabled = false;
            //_taskRepository.Search("", taskCategoryID, OnlyHoldIntakes, 20);
        }
        /*public void SetOnlyHoldIntakes(bool value)
        {
            OnlyHoldIntakes = value;
            //RefreshTaskGridViewDataSource();
        }*/
        private void MasterTaskManager_Load(object sender, EventArgs e)
        {
            TaskGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TaskGridView.MultiSelect = false;
            TaskGridView.ReadOnly = true;
            //RefreshTaskGridViewDataSource();
            //TaskGridView.Columns["ID"].Visible = false;
        }

        private void AddCategoryTasksButton_Click(object sender, EventArgs e)
        {
            int taskCategoryID = -1;
            if (!(CBoxTaskCategory.SelectedValue is null))
            {
                if (!Int32.TryParse(CBoxTaskCategory.SelectedValue.ToString(), out taskCategoryID))
                {
                    taskCategoryID = -1;
                }
                TaskCategory tc = _taskCategoryRepository.GetById(taskCategoryID);
                DialogResult dialogResult = MessageBox.Show($"Are you sure you want you add the tasks belonging to the category '{tc.Description}' to File '{File}'?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                var tasksToAdd = _taskRepository.Search("", taskCategoryID, OnlyHoldIntakes, 20);
                //FIRST TIME DELETE AFTERWARDS
                /*TaskState ts = new TaskState();
                ts.Description = "To Do";
                _taskStateRepository.Insert(ts);*/
                TaskState ts = _taskStateRepository.GetByDescription("To Do");
                foreach (Task t in tasksToAdd)
                {
                    _fileRepository.AddTask(File, t, ts);
                }
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Close();
            Home.Instance.Show();
        }

        private void FindFileButton_Click(object sender, EventArgs e)
        {
            SettingFile = true;
            FindFile.Instance.Show();
            FindFile.Instance.FormClosing += new FormClosingEventHandler(FindFile_FormClosing);
            
        }

        private void FindFile_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findFileForm = sender as FindFile;
            File = findFileForm.SelectedFile;
            if (File == null)
                return;
            AddCategoryTasksButton.Enabled = true;
            RefreshTaskGridViewDataSource();
        }

        private void TaskGridView_SelectionChanged(object sender, EventArgs e)
        {
            SelectedFileTask = TaskGridView.SelectedRows[0].DataBoundItem as FileTask;
            BtnEditSelectedTextButton.Enabled = true;
        }

        private void BtnEditSelectedTextButton_Click(object sender, EventArgs e)
        {
            if (SelectedFileTask != null)
            {
                CreateEditFileTask createEditFileTask = new CreateEditFileTask(); //_fileRepository, true, (Task)TaskGridView.SelectedRows[0].DataBoundItem);
                createEditFileTask.ShowDialog();
                RefreshTaskGridViewDataSource();
            }
        }
    }
}
