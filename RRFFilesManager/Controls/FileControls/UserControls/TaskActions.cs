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

namespace RRFFilesManager.Controls.FileControls.UserControls
{
    public partial class TaskActions : UserControl
    {
        private readonly IFileTaskRepository _fileTaskRepository;
        private readonly ITaskStateRepository _taskStateRepository;
        public DataGridView Grid;
        public int RowIndex;

        public FileTask fileTask;
        public LawyerTask lawyerTask;

        bool IsFileTask;

        public TaskActions(bool _isFileTask)
        {
            InitializeComponent();
            IsFileTask = _isFileTask;
            _fileTaskRepository = Program.GetService<IFileTaskRepository>();
            _taskStateRepository = Program.GetService<ITaskStateRepository>();
        }

        private void Ctms_TaskActions_Opening(object sender, CancelEventArgs e)
        {

            if (fileTask.State.ID == _taskStateRepository.GetByDescription("DONE").ID)
            {
                e.Cancel = true;
                return;
            }
            //editNotesToolStripMenuItem.Visible = false;
            if (fileTask.TaskStartedDate.ToString() != "01/01/0001 0:00:00")
            {
                startTaskToolStripMenuItem.Visible = false;
            }
            else
            {
                if (fileTask.WorkedOnDate1.ToString() != "01/01/0001 0:00:00" &&
                    fileTask.WorkedOnDate2.ToString() != "01/01/0001 0:00:00" &&
                    fileTask.WorkedOnDate3.ToString() != "01/01/0001 0:00:00")
                {
                    workedDayToolStripMenuItem.Visible = false;
                }
                if (fileTask.NotifiedRRFDate.ToString() != "01/01/0001 0:00:00")
                {
                    notifyRRFToolStripMenuItem.Visible = false;
                }
                completeTaskToolStripMenuItem.Visible = false;
            }

        }
        private void RefreshViews()
        {
            if (IsFileTask)
            {
                Home.FileManager.RefreshActionLogDataGridViewDataSource();
            }
            else
            {
                //Home.StaffPortal.
            }
        }

        private void startTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to start the task?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

            if (IsFileTask)
            {                                
                fileTask.TaskStartedDate= DateTime.Now;
                _fileTaskRepository.Update(fileTask);
                MessageBox.Show("¡Task started successfully!","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else // Para LawyerTask
            {

            }
            RefreshViews();
        }

        private void workedDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add a worked Day to the task?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

            if (IsFileTask)
            {
                if (fileTask.WorkedOnDate1.ToString() == "01/01/0001 0:00:00")
                {
                    fileTask.WorkedOnDate1 = DateTime.Now;
                }
                else if (fileTask.WorkedOnDate2.ToString() == "01/01/0001 0:00:00")
                {
                    fileTask.WorkedOnDate2 = DateTime.Now;
                }
                else if (fileTask.WorkedOnDate3.ToString() == "01/01/0001 0:00:00")
                {
                    fileTask.WorkedOnDate3 = DateTime.Now;
                }

                _fileTaskRepository.Update(fileTask);
                MessageBox.Show("¡Worked day added successfully!", "Success", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else // Para LawyerTask
            {

            }
            RefreshViews();

        }

        private void notifyRRFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to add the date of notification to RRF?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

            if (IsFileTask)
            {
                fileTask.NotifiedRRFDate = DateTime.Now;
                _fileTaskRepository.Update(fileTask);
                MessageBox.Show("¡Notification date successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Para LawyerTask
            {

            }
            RefreshViews();
        }

        private void completeTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to mark the task as completed?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Stop) != DialogResult.Yes) return;

            if (IsFileTask)
            {
                fileTask.State = _taskStateRepository.GetById(4);
                fileTask.CompletedDate = DateTime.Now;
                _fileTaskRepository.Update(fileTask);
                MessageBox.Show("¡Task succesfully completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // Para LawyerTask
            {

            }
            RefreshViews();
        }

        private void Ctms_TaskActions_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            startTaskToolStripMenuItem.Visible = true;
            workedDayToolStripMenuItem.Visible = true;
            notifyRRFToolStripMenuItem.Visible = true;
            completeTaskToolStripMenuItem.Visible = true;
            editNotesToolStripMenuItem.Visible = true;
        }

        private void editNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFileTask)
            {
                using (TaskManager taskManager = new TaskManager(true, true, fileTask))
                {
                    taskManager.ShowDialog();
                }
            }
            else
            {
                using (TaskManager taskManager = new TaskManager(true, true, null,lawyerTask))
                {
                    taskManager.ShowDialog();
                }
            }
            RefreshViews();
        }

        private void Ctms_TaskActions_Opened(object sender, EventArgs e)
        {
            
        }
    }
}
