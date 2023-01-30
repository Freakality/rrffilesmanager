using ClosedXML.Excel;
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
using Task = RRFFilesManager.Abstractions.Task;

namespace RRFFilesManager.Controls.MasterTaskControls
{
    public partial class MasterTaskManager : Form
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskCategoryRepository _taskCategoryRepository;
        private readonly ILawyerRepository _lawyerRepository;
        private Abstractions.Task TaskToAdd;
        public MasterTaskManager()
        { 
            _taskRepository = Program.GetService<ITaskRepository>();
            _taskCategoryRepository = Program.GetService<ITaskCategoryRepository>();
            _lawyerRepository = Program.GetService<ILawyerRepository>();
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

        private void ImportTasksButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openTaskDialog = new OpenFileDialog();

            openTaskDialog.Filter = "Excel(*.xlsx;*.xlsm)|*.xlsx;*.xlsm";
            try
            {
                if (openTaskDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openTaskDialog.CheckFileExists)
                    {
                        string path = Path.GetFullPath(openTaskDialog.FileName);
                        DataSet ds = new DataSet("Master Tasks");
                        using (XLWorkbook workBook = new XLWorkbook(path))
                        {
                            foreach (IXLWorksheet sheet in workBook.Worksheets)
                            {
                                if (sheet.Name == "Information")
                                    continue;
                                //Read the first Sheet from Excel file.
                                IXLWorksheet workSheet = sheet;

                                //Create a new DataTable.
                                DataTable dt = new DataTable(sheet.Name);

                                //Loop through the Worksheet rows.
                                bool firstRow = true;
                                foreach (IXLRow row in workSheet.Rows())
                                {
                                    //Use the first row to add columns to DataTable.
                                    if (firstRow)
                                    {
                                        foreach (IXLCell cell in row.Cells())
                                        {
                                            dt.Columns.Add(cell.Value.ToString());
                                        }
                                        firstRow = false;
                                    }
                                    else
                                    {
                                        //Add rows to DataTable.
                                        dt.Rows.Add();
                                        int i = 0;
                                        foreach (IXLCell cell in row.Cells(1, dt.Columns.Count))
                                        {
                                            dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                            i++;
                                        }
                                    }
                                }
                                ds.Tables.Add(dt);
                            }

                        }
                        List<string> DependencyStack = new List<string>();
                        foreach (DataTable table in ds.Tables)
                        {
                            /*if (table.TableName.ToUpper() == "INFORMATION")
                            {
                                continue;
                            }*/
                            TaskCategory taskCategory = new TaskCategory();
                            var found = _taskCategoryRepository.Search(table.TableName);
                            if (found.Count() > 0)
                            {
                                taskCategory = found.First();
                            }
                            else
                            {
                                taskCategory.Description = table.TableName;
                                _taskCategoryRepository.Insert(taskCategory);
                                taskCategory = _taskCategoryRepository.Search(taskCategory.Description).First();
                            }
                            foreach(DataRow row in table.Rows)
                            {
                                if (String.IsNullOrEmpty(row[1].ToString()))
                                    continue;
                                var exists = _taskRepository.GetByTaskIdNumber(row[1].ToString());
                                if (exists == null)
                                {
                                    Task task = new Task();
                                    task.TaskIDNumber = row[1].ToString();
                                    task.TaskCategory = taskCategory;
                                    task.CreatedBy = Program.GetUser();
                                    task.Description = row[2].ToString();
                                    task.Lawyer = _lawyerRepository.GetByName(row[4].ToString());
                                    if (row[6] != null)
                                    {
                                        if (!String.IsNullOrEmpty(row[6].ToString()))
                                        {
                                            task.DueBy = Convert.ToInt32(row[6].ToString());
                                        }

                                    }
                                    if (row[5] != null)
                                    {
                                        if (!String.IsNullOrEmpty(row[5].ToString()))
                                        {
                                            task.DeferBy = Convert.ToInt32(row[5].ToString());
                                        }

                                    }
                                    task.IsMasterTask = true;
                                    if (row[7].ToString() == "TRUE")
                                    {
                                        task.LockDueDate = true;
                                    }
                                    else
                                    {
                                        task.LockDueDate = false;
                                    }
                                    List<Task> DependenciesToAdd = new List<Task>();
                                    if (row[3] != null)
                                    {
                                        if (!String.IsNullOrEmpty(row[3].ToString()))
                                        {
                                            string[] dependencies = row[3].ToString().Split(' ');
                                            foreach(string dependency in dependencies)
                                            {
                                                if (!String.IsNullOrEmpty(dependency))
                                                {
                                                    Task dependencyTask = _taskRepository.GetByTaskIdNumber(dependency);
                                                    if (dependencyTask != null)
                                                    {
                                                        DependenciesToAdd.Add(dependencyTask);
                                                    }
                                                    else
                                                    {
                                                        DependencyStack.Add($"{task.TaskIDNumber},{dependency}");
                                                    }
                                                }

                                            }
                                        }
                                    }
                                    _taskRepository.Insert(task);
                                    if (DependenciesToAdd.Count > 0)
                                    {
                                        task = _taskRepository.GetByTaskIdNumber(task.TaskIDNumber);
                                        foreach(Task dependencyToAdd in DependenciesToAdd)
                                        {
                                            _taskRepository.AddTaskDependency(task, dependencyToAdd);
                                        }
                                    }
                                }
                                /*task.Dependencies;*/

                            }
                        }
                        foreach(string taskAndDependency in DependencyStack)
                        {
                            string[] tasks = taskAndDependency.Split(',');
                            var task = _taskRepository.GetByTaskIdNumber(tasks[0]);
                            var dependency = _taskRepository.GetByTaskIdNumber(tasks[1]);
                            _taskRepository.AddTaskDependency(task, dependency);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please upload a valid Excel file.");
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }
        }
    }
}
