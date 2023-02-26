using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.Controls.StaffControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRFFilesManager.Controls.FileControls.UserControls;
using RRFFilesManager.Controls.FileControls;

namespace RRFFilesManager.Controls.StaffControls.UserControls
{
    public partial class StaffViewControls : UserControl
    {
        private readonly ILawyerRepository _lawyerRepository;
        private readonly ILawyerTaskRepository _lawyerTaskRepository;
        private readonly ITaskStateRepository _taskStateRepository;
        private TaskState SelectedTaskState;
        TaskActions Task_Actions = new TaskActions(false);
        ContextMenuStrip Ctms_TaskActions;
        public StaffViewControls()
        {
            _lawyerRepository = Program.GetService<ILawyerRepository>();
            _lawyerTaskRepository = Program.GetService<ILawyerTaskRepository>();
            _taskStateRepository = Program.GetService<ITaskStateRepository>();
            InitializeComponent();
            Utils.Utils.SetComboBoxDataSource(StaffPortalTaskStateComboBox, _taskStateRepository.List());
            StaffPortalTaskStateComboBox.SelectedIndex = 1;
            Ctms_TaskActions = Task_Actions.Ctms_TaskActions;
        }

        internal void FillStaffLawyerTaskView()
        {
            //throw new NotImplementedException();
            StaffLawyerTaskView.DataSource = _lawyerTaskRepository.Search(StaffPortalSearchTextBox.Text, Program.GetUser(), SelectedTaskState);
        }
        private void StaffPortalFileStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTaskState = (Abstractions.TaskState)StaffPortalTaskStateComboBox.SelectedItem;
            FillStaffLawyerTaskView();
        }
        private void StaffPortalSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            FillStaffLawyerTaskView();
        }
        private void StaffLawyerTaskView_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                StaffLawyerTaskView.CurrentCell = StaffLawyerTaskView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Task_Actions.lawyerTask = _lawyerTaskRepository.GetById(Convert.ToInt32(StaffLawyerTaskView.Rows[e.RowIndex].Cells[0].Value));
            }
        }

        private void StaffPortalAddTaskButton_Click(object sender, EventArgs e)
        {
            using (TaskManager taskManager = new TaskManager(null, Program.GetUser()))
            {
                if (taskManager.ShowDialog() == DialogResult.OK)
                {
                    FillStaffLawyerTaskView();
                }
            }
        }
    }
}
