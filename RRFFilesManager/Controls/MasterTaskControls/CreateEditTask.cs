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
    public partial class CreateEditTask : Form
    {
        private readonly ITaskRepository _taskRepository;
        private readonly ILawyerRepository _lawyerRepository;
        private readonly ITaskCategoryRepository _taskCategoryRepository;
        private Task TaskToAdd;
        private List<Task> SelectedDependencies = new List<Task>();
        public CreateEditTask(ITaskRepository _repository, bool editState = false, Task task = null)
        {
            _taskRepository = _repository;
            _lawyerRepository = Program.GetService<ILawyerRepository>();
            _taskCategoryRepository = Program.GetService<ITaskCategoryRepository>();
            InitializeComponent();
            CBoxToBeCompletedBy.DataSource = _lawyerRepository.List();
            CBoxToBeCompletedBy.ValueMember = "ID";
            CBoxToBeCompletedBy.DisplayMember = "Description";
            CBoxCategory.DataSource = _taskCategoryRepository.List();
            CBoxCategory.ValueMember = "ID";
            CBoxCategory.DisplayMember = "Description";
            if (editState)
            {
                FillFields(task);
                TaskToAdd = task;
                if (!(task.Dependencies is null))
                {
                    foreach (TaskDependency DependencyToAdd in task.Dependencies)
                    {
                        SelectedDependencies.Add(DependencyToAdd.Dependency);
                    }
                }
            }
            else
            {
                TaskToAdd = new Task();
            }
        }

        private void AddEditTaskButton_Click(object sender, EventArgs e)
        {
            FillOrCreateTask();
            Close();
        }

        public void FillOrCreateTask()
        {
            bool filled = FillTask(TaskToAdd);
            if (filled)
            {
                if (TaskToAdd.ID == default)
                {
                    _taskRepository.Insert(TaskToAdd);
                    MessageBox.Show($"Master Task '{TaskToAdd.Description}' created.");
                }
                else
                {
                    _taskRepository.Update(TaskToAdd);
                    MessageBox.Show($"Master Task '{TaskToAdd.Description}' updated.");
                }
                if (SelectedDependencies.Count > 0)
                {
                    if (!(TaskToAdd.Dependencies is null))
                    {
                        foreach (TaskDependency DependencyToDelete in TaskToAdd.Dependencies)
                        {
                            _taskRepository.RemoveTaskDependency(TaskToAdd, DependencyToDelete.Dependency);
                        }
                    }
                    foreach (Task DependencyToAdd in SelectedDependencies)
                    {
                        _taskRepository.AddTaskDependency(TaskToAdd, DependencyToAdd);
                    }
                }

            }
            else
            {
                MessageBox.Show("All required fields (*) must be filled.");
            }
        }

        private void FillFields(Task task)
        {
            TBoxTaskName.Text = task.Description;
            NBoxDueBy.Value = task.DueBy;
            NBoxDeferBy.Value = task.DeferBy;
            CBoxToBeCompletedBy.SelectedValue = task.Lawyer.ID;
            CheckLockDue.Checked = task.LockDueDate;
            CBoxCategory.SelectedValue = task.TaskCategory.ID;
            if (!(task.Dependencies is null))
            {
                bool notfirst = false;
                foreach (TaskDependency DependencyToAdd in task.Dependencies)
                {
                    if (notfirst)
                        TBoxDependencies.Text += ", ";
                    //_taskRepository.AddTaskDependency(TaskToAdd, DependencyToAdd);
                    TBoxDependencies.Text += DependencyToAdd.Dependency.ToString();
                    SelectedDependencies.Add(DependencyToAdd.Dependency);
                    if (!notfirst)
                        notfirst = true;
                }
            }
        }
        private bool FillTask(Task task)
        {
            bool filled = false;
            if (!String.IsNullOrEmpty(TBoxTaskName.Text) && CBoxToBeCompletedBy.SelectedItem != null && CBoxCategory.SelectedItem != null)
            {
                task.Description = TBoxTaskName.Text;
                task.DueBy = Convert.ToInt32(NBoxDueBy.Value);
                task.DeferBy = Convert.ToInt32(NBoxDeferBy.Value);
                //var lawyer = _lawyerRepository.GetById(Convert.ToInt32(CBoxToBeCompletedBy.SelectedValue));
                task.Lawyer = (Lawyer)CBoxToBeCompletedBy.SelectedItem;//lawyer;
                task.LockDueDate = CheckLockDue.Checked;
                task.IsMasterTask = true;
                //var category = _taskCategoryRepository.GetById(Convert.ToInt32(CBoxCategory.SelectedValue));
                task.TaskCategory = (TaskCategory)CBoxCategory.SelectedItem;//category;
                task.CreatedBy = Program.GetUser();
                filled = true;
            }
            return filled;
        }

        private void SelectDependenciesButton_Click(object sender, EventArgs e)
        {
            DependencySelect dss = new DependencySelect(TaskToAdd, SelectedDependencies, _taskRepository);
            dss.FormClosing += DependencySelect_FormClosing2;
            dss.ShowDialog();
        }

        private void DependencySelect_FormClosing2(object sender, FormClosingEventArgs e)
        {
            var form = (DependencySelect)sender;
            if (form.Transferring)
            {
                TBoxDependencies.Clear();
                bool notfirst = false;
                SelectedDependencies = form.SelectedDependencies;
                foreach (Task DependencyToAdd in SelectedDependencies)
                { 
                    if (notfirst)
                        TBoxDependencies.Text += ", ";
                    //_taskRepository.AddTaskDependency(TaskToAdd, DependencyToAdd);
                    TBoxDependencies.Text += DependencyToAdd.ToString();
                    if (!notfirst)
                        notfirst = true;
                }
            }
        }

       
    }
}
