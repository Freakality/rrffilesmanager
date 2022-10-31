using RRFFilesManager.Abstractions;
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
using Task = RRFFilesManager.Abstractions.Task;

namespace RRFFilesManager.Controls.MasterTaskControls
{
    public partial class MasterTaskManager : Form
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskCategoryRepository _taskCategoryRepository;
        private Abstractions.Task TaskToAdd;
        public MasterTaskManager()
        { 
            _taskRepository = Program.GetService<ITaskRepository>();
            _taskCategoryRepository = Program.GetService<ITaskCategoryRepository>();
            InitializeComponent();
            RefreshTaskCategoryCBoxDataSource();
        }

        private static MasterTaskManager instance;
        public static MasterTaskManager Instance => instance == null || instance.IsDisposed ? (instance = new MasterTaskManager()) : instance;
        public Abstractions.Task SelectedTask { get; set; }
        private bool? OnlyHoldIntakes { get; set; }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshTaskGridViewDataSource();
        }
        private void RefreshTaskCategoryCBoxDataSource()
        {
            CBoxTaskCategory.DataSource = _taskCategoryRepository.List();
            CBoxTaskCategory.ValueMember = "ID";
            CBoxTaskCategory.DisplayMember = "Description";
        }
        private void RefreshTaskGridViewDataSource()
        {
            int taskCategoryID = -1;
            if (!(CBoxTaskCategory.SelectedValue is null))
            {
                if (!Int32.TryParse(CBoxTaskCategory.SelectedValue.ToString(), out taskCategoryID))
                {
                    taskCategoryID = -1;
                }
            }
            TaskGridView.DataSource = _taskRepository.Search(SearchTextBox.Text, taskCategoryID, OnlyHoldIntakes, 20);
        }
        public void SetOnlyHoldIntakes(bool value)
        {
            OnlyHoldIntakes = value;
            RefreshTaskGridViewDataSource();
        }
        private void MasterTaskManager_Load(object sender, EventArgs e)
        {
            TaskGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TaskGridView.MultiSelect = false;
            TaskGridView.ReadOnly = true;
            RefreshTaskGridViewDataSource();
            TaskGridView.Columns["ID"].HeaderText = "";
            TaskGridView.Columns["Dependencies"].Visible = false;
            TaskGridView.Columns["Description"].HeaderText = "Task";
            TaskGridView.Columns["DueBy"].HeaderText = "Due By";
            TaskGridView.Columns["DeferBy"].HeaderText = "Defer By";
            TaskGridView.Columns["LockDueDate"].HeaderText = "Lock Due Date";
            TaskGridView.Columns["IsMasterTask"].HeaderText = "Is Master Task";
            TaskGridView.Columns["TaskCategory"].HeaderText = "Category";
            TaskGridView.Columns["CreatedBy"].HeaderText = "Creator";
        }

        private void CreateTaskButton_Click(object sender, EventArgs e)
        {
            CreateEditTask createEditTask = new CreateEditTask(_taskRepository);
            createEditTask.ShowDialog();
            RefreshTaskGridViewDataSource();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            var found = _taskCategoryRepository.Search(CBoxTaskCategory.Text);
            if (found.Count() > 0)
            {
                CBoxTaskCategory.SelectedValue = found.First().ID;
                return;
            }
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want you add the task category '{CBoxTaskCategory.Text}'?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TaskCategory taskCategory = new TaskCategory();
                taskCategory.Description = CBoxTaskCategory.Text;
                _taskCategoryRepository.Insert(taskCategory);
                MessageBox.Show($"Task category '{CBoxTaskCategory.Text}' has been added.");
                RefreshTaskCategoryCBoxDataSource();
            }
        }

        private void CBoxTaskCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            RefreshTaskGridViewDataSource();
        }
        private void TaskGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;

            EditTaskButton.Enabled = true;
            DeleteTaskButton.Enabled = true;
        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            CreateEditTask createEditTask = new CreateEditTask(_taskRepository, true, (Task)TaskGridView.SelectedRows[0].DataBoundItem);
            createEditTask.ShowDialog();
            RefreshTaskGridViewDataSource();
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Are you sure you want you delete the task '{((Task)TaskGridView.SelectedRows[0].DataBoundItem).Description}'?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string name = ((Task)TaskGridView.SelectedRows[0].DataBoundItem).Description;
                _taskRepository.SoftDelete(((Task)TaskGridView.SelectedRows[0].DataBoundItem).ID);
                MessageBox.Show($"Task category '{name}' has been deleted [Work in Progress].");
                RefreshTaskCategoryCBoxDataSource();
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Close();
            Home.Instance.Show();
        }
    }
}
