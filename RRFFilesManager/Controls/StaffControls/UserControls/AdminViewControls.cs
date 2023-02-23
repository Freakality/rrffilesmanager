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
    public partial class AdminViewControls : UserControl
    {
        private readonly ILawyerRepository _lawyerRepository;
        private readonly ILawyerTaskRepository _lawyerTaskRepository;
        private readonly ITaskStateRepository _taskStateRepository;
        private Lawyer SelectedLawyer;
        private TaskState SelectedTaskState;
        TaskActions Task_Actions = new TaskActions(false);
        ContextMenuStrip Ctms_TaskActions;

        public AdminViewControls()
        {
            _lawyerRepository = Program.GetService<ILawyerRepository>();
            _lawyerTaskRepository = Program.GetService<ILawyerTaskRepository>();
            _taskStateRepository = Program.GetService<ITaskStateRepository>();
            InitializeComponent();
            AdminPortalUserLawyerListBox.DataSource = _lawyerRepository.List();
            AdminPortalUserLawyerListBox.DisplayMember = "Description";
            Utils.Utils.SetComboBoxDataSource(AdminPortalTaskStateComboBox, _taskStateRepository.List());
            AdminPortalTaskStateComboBox.SelectedIndex = 1;
            Ctms_TaskActions = Task_Actions.Ctms_TaskActions;

        }
        private void UserLawyerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedLawyer = AdminPortalUserLawyerListBox.SelectedItem as Lawyer;
            FillAdminLawyerTaskView();
        }

        internal void FillAdminLawyerTaskView()
        {
            //throw new NotImplementedException();
            AdminLawyerTaskView.DataSource = _lawyerTaskRepository.Search(AdminPortalSearchTextBox.Text, SelectedLawyer, SelectedTaskState);
            AdminLawyerTaskView.ContextMenuStrip = Ctms_TaskActions;
        }

        private void AdminPortalFileStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTaskState = (Abstractions.TaskState)AdminPortalTaskStateComboBox.SelectedItem;
            FillAdminLawyerTaskView();
        }

        private void AdminPortalSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            FillAdminLawyerTaskView();
        }

        private void AdminPortalSaveChangesButton_Click(object sender, EventArgs e)
        {

        }

        private void AdminPortalAddTaskButton_Click(object sender, EventArgs e)
        {
            if (SelectedLawyer == null)
            {
                MessageBox.Show($"No lawyer selected.", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            using (TaskManager taskManager = new TaskManager(null, SelectedLawyer))
            {
                if (taskManager.ShowDialog() == DialogResult.OK)
                {
                    FillAdminLawyerTaskView();
                }
            }
        }

        private void AdminLawyerTaskView_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                AdminLawyerTaskView.CurrentCell = AdminLawyerTaskView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Task_Actions.lawyerTask = _lawyerTaskRepository.GetById(Convert.ToInt32(AdminLawyerTaskView.Rows[e.RowIndex].Cells[0].Value));
            }
        }
    }
}
