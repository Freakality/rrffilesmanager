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
    public partial class StaffViewControls : UserControl
    {
        private readonly ILawyerRepository _lawyerRepository;
        private readonly ILawyerTaskRepository _lawyerTaskRepository;
        private readonly ITaskStateRepository _taskStateRepository;
        private TaskState SelectedTaskState;
        public StaffViewControls()
        {
            _lawyerRepository = Program.GetService<ILawyerRepository>();
            _lawyerTaskRepository = Program.GetService<ILawyerTaskRepository>();
            _taskStateRepository = Program.GetService<ITaskStateRepository>();
            InitializeComponent();
            Utils.Utils.SetComboBoxDataSource(StaffPortalTaskStateComboBox, _taskStateRepository.List());
            StaffPortalTaskStateComboBox.SelectedIndex = 1;
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

    }
}
