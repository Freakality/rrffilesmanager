using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.FileControls
{
    public partial class TaskManager : Form
    {               
        public Task task;
        private readonly File file;
        private readonly ITaskCategoryRepository _taskCategoryRepository;
        private readonly ITaskRepository _taskRepository;
        private readonly IFileTaskRepository _fileTaskRepository;
        private readonly ITaskStateRepository _taskStateRepository;
        private readonly ILawyerRepository _lawyerRepository;
        public TaskManager(File _file)
        {                       
            _taskCategoryRepository = Program.GetService<ITaskCategoryRepository>();
            _taskRepository = Program.GetService<ITaskRepository>();
            _fileTaskRepository = Program.GetService<IFileTaskRepository>();
            _taskStateRepository = Program.GetService<ITaskStateRepository>();
            _lawyerRepository = Program.GetService<ILawyerRepository>();
            file = _file;
            InitializeComponent();

            Cbb_TaskCategories.DataSource = _taskCategoryRepository.List();            
            Cbb_ResponsibleLawyer.DataSource = _lawyerRepository.List();            
            Cbb_ResponsibleLawyer.SelectedIndex = 0;
        }

        private void Cbb_TaskCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbb_TaskCategories.Items.Count > 0)
            {
                //taskList = (IEnumerable<Task>)(_taskRepository.List().Where(x => x.TaskCategory.Description == Cbb_TaskCategories.Text).ToList().AsEnumerable());
                Cbb_Tasks.DataSource = _taskRepository.List().Where(x => x.TaskCategory != null && x.TaskCategory.Description == Cbb_TaskCategories.Text).ToList();
                   
            }
        }

        private void Gb_Dates_Enter(object sender, EventArgs e)
        {

        }

        private void Cbb_Tasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbb_Tasks.Items.Count == 0)
            {
                Btn_Save.Enabled = false;
            }
            else
            {
                task = (Task)Cbb_Tasks.SelectedItem;
                Lbl_ResponsibleLawyer.Text = task.Lawyer.Description;
            }
        }

        private void Rb_PrevioslyCreatedTask_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_PrevioslyCreatedTask.Checked)
            {
                Gb_PrevioslyCreatedTasks.Enabled = true;
                Gb_NewTask.Enabled = false;
            }           
        }

        private void Rb_NewTask_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_NewTask.Checked)
            {
                Gb_NewTask.Enabled = true;
                Gb_PrevioslyCreatedTasks.Enabled = false;
                Gb_NewTask.Focus();
                Gb_NewTask.Select();
                Btn_Save.Enabled = true;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save the task?", "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes) return;
            

            if (Rb_PrevioslyCreatedTask.Checked)
            {
                FileTask fileTask = new FileTask();
                fileTask.TaskId = task.ID;
                fileTask.Task = task;
                fileTask.DueDate = DateTime.Now.AddDays(task.DueBy);
                fileTask.DeferUntilDate = DateTime.Now.AddDays(task.DeferBy);
                fileTask.Notes = Txt_Notes.Text.Trim();
                fileTask.AddedBy = Program.GetUser();
                fileTask.State = _taskStateRepository.GetById(1);
                fileTask.File = file;
                fileTask.FileId = file.ID;              
                _fileTaskRepository.Insert(fileTask);
            }
            else if (Rb_NewTask.Checked)
            {
                if (string.IsNullOrEmpty(Txt_NewTaskDescription.Text))
                {
                    MessageBox.Show("You must indicate the description of the task", "Missing Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
                    return;
                }

                task = new Task();
                task.Description = Txt_NewTaskDescription.Text;
                task.IsMasterTask = false;                
                task.TaskCategory = null;
                task.CreatedBy = Program.GetUser();
                task.Lawyer = ((Lawyer)Cbb_ResponsibleLawyer.SelectedItem);                
                _taskRepository.Insert(task);
                task = _taskRepository.GetLastTask();

                FileTask fileTask = new FileTask();
                fileTask.TaskId = task.ID;
                fileTask.Task = task;
                fileTask.DueDate = Dtp_DueDate.Value;
                fileTask.DeferUntilDate = Dtp_DeferUntilDate.Value;
                fileTask.Notes = Txt_Notes.Text.Trim();
                fileTask.AddedBy = Program.GetUser();
                fileTask.State = _taskStateRepository.GetById(1);
                fileTask.File = file;
                fileTask.FileId = file.ID;

                _fileTaskRepository.Insert(fileTask);
            }

            MessageBox.Show($"Task added succesfuly!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }
    }
}
