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

namespace RRFFilesManager.Controls.StaffControls.UserControls
{
    public partial class AdminViewControls : UserControl
    {
        private readonly ILawyerRepository _lawyerRepository;
        private readonly ILawyerTaskRepository _lawyerTaskRepository;
        private readonly ITaskStateRepository _taskStateRepository;
        private Lawyer SelectedLawyer;
        private TaskState SelectedTaskState;
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

        }
        private void UserLawyerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedLawyer = AdminPortalUserLawyerListBox.SelectedItem as Lawyer;
            FillAdminLawyerTaskView();
        }

        private void FillAdminLawyerTaskView()
        {
            //throw new NotImplementedException();
            AdminLawyerTaskView.DataSource = _lawyerTaskRepository.Search(AdminPortalSearchTextBox.Text, SelectedLawyer, SelectedTaskState);
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

        }
    }
}
