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
        private IEnumerable<Task> taskList;
        private readonly ITaskCategoryRepository _taskCategoryRepository;
        private readonly ITaskRepository _taskRepository;             
        public TaskManager()
        {                       
            _taskCategoryRepository = Program.GetService<ITaskCategoryRepository>();
            _taskRepository = Program.GetService<ITaskRepository>();            
            InitializeComponent();

            Cbb_TaskCategories.DataSource = _taskCategoryRepository.List();

        }

        private void Cbb_TaskCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cbb_TaskCategories.Items.Count > 0)
            {
                //taskList = (IEnumerable<Task>)(_taskRepository.List().Where(x => x.TaskCategory.Description == Cbb_TaskCategories.Text).ToList().AsEnumerable());
                Cbb_Tasks.DataSource = _taskRepository.List().Where(x => x.TaskCategory.Description == Cbb_TaskCategories.Text).ToList();
                   
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
            }
        }
    }
}
