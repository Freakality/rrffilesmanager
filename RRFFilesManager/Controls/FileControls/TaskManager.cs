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
        private readonly Lawyer lawyer;
        public FileTask fileTask;
        public LawyerTask lawyerTask;
        private readonly ITaskCategoryRepository _taskCategoryRepository;
        private readonly ITaskRepository _taskRepository;
        private readonly IFileTaskRepository _fileTaskRepository;
        private readonly ITaskStateRepository _taskStateRepository;
        private readonly ILawyerRepository _lawyerRepository;
        bool IsFileTask, Editing;

        public TaskManager(File _file = null, Lawyer _lawyer = null)
        {                       
            _taskCategoryRepository = Program.GetService<ITaskCategoryRepository>();
            _taskRepository = Program.GetService<ITaskRepository>();
            _fileTaskRepository = Program.GetService<IFileTaskRepository>();
            _taskStateRepository = Program.GetService<ITaskStateRepository>();
            _lawyerRepository = Program.GetService<ILawyerRepository>();
            file = _file;
            lawyer = _lawyer;
            InitializeComponent();

            Cbb_TaskCategories.DataSource = _taskCategoryRepository.List();            
            Cbb_ResponsibleLawyer.DataSource = _lawyerRepository.List();            
            Cbb_ResponsibleLawyer.SelectedIndex = 0;


            if (file == null && lawyer != null)
            {
                Rb_NewTask.Checked = true;
                Gb_TypeOfTaskToAdd.Enabled = false;
                Panel_GbTypeOfTaskToAdd.Visible = false;

                Gb_PrevioslyCreatedTasks.Enabled = false;
                Panel_GbPreviosluCreatedTask.Visible = false;

                Gb_NewTask.Enabled = true;
                Txt_NewTaskDescription.Enabled = true;
                Txt_NewTaskDescription.Focus();
                Txt_NewTaskDescription.Select();

                Gb_Notes.Enabled = true;
            }

        }


        public TaskManager(bool _isFileTask, bool _editing, FileTask _fileTask = null, LawyerTask _lawyerTask = null)
        {
            _taskCategoryRepository = Program.GetService<ITaskCategoryRepository>();
            _taskRepository = Program.GetService<ITaskRepository>();
            _fileTaskRepository = Program.GetService<IFileTaskRepository>();
            _taskStateRepository = Program.GetService<ITaskStateRepository>();
            _lawyerRepository = Program.GetService<ILawyerRepository>();            
            InitializeComponent();

            Cbb_TaskCategories.DataSource = _taskCategoryRepository.List();
            Cbb_ResponsibleLawyer.DataSource = _lawyerRepository.List();
            Cbb_ResponsibleLawyer.SelectedIndex = 0;

            fileTask = _fileTask;
            lawyerTask = _lawyerTask;

            IsFileTask = _isFileTask;
            Editing = _editing;

            if (IsFileTask)
            {
                if (fileTask.Task.IsMasterTask)
                {
                    Rb_PrevioslyCreatedTask.Checked = true;
                    Gb_TypeOfTaskToAdd.Enabled = false;

                    Cbb_TaskCategories.SelectedItem = fileTask.Task.TaskCategory.Description;
                    Cbb_Tasks.SelectedItem = fileTask.Task.Description;
                    Gb_PrevioslyCreatedTasks.Enabled = false;

                    Gb_NewTask.Enabled = false;

                    Gb_Notes.Enabled = true;
                    Txt_Notes.Enabled = true;
                    Txt_Notes.Text = fileTask.Notes;
                    Txt_Notes.Focus();
                    Txt_Notes.Select();
                }
                else
                {
                    Rb_NewTask.Checked = true;
                    Gb_TypeOfTaskToAdd.Enabled = false;

                    Gb_PrevioslyCreatedTasks.Enabled = false;

                    Txt_NewTaskDescription.Text = fileTask.Task.Description;
                    Gb_NewTask.Enabled = false;

                    Gb_Notes.Enabled = true;
                    Txt_Notes.Enabled = true;
                    Txt_Notes.Text = fileTask.Notes;
                    Txt_Notes.Focus();
                    Txt_Notes.Select();

                }
            }
            else // para lawyer task
            {

            }

        }


        private void Cbb_TaskCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbb_TaskCategories.Items.Count > 0)
            {
                //taskList = (IEnumerable<Task>)(_taskRepository.List().Where(x => x.TaskCategory.Description == Cbb_TaskCategories.Text).ToList().AsEnumerable());
                Cbb_Tasks.DataSource = _taskRepository.List().Where(x => x.TaskCategory != null && x.TaskCategory.Description == Cbb_TaskCategories.Text).ToList();
                   
            }
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

            if (!Editing)
            {
                if (file != null)
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

                    MessageBox.Show($"Task added succesfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else // Codigo para lawyer task
                {

                }
            }
            else
            {
                if (IsFileTask)
                {
                    fileTask.Notes = Txt_Notes.Text.Trim();
                    _fileTaskRepository.Update(fileTask);
                    MessageBox.Show($"¡Task successfully edited!","Succsess",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else // para lawyer task
                {

                }
            }
           
        }
    }
}
