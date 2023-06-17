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

namespace RRFFilesManager.Controls.UserManagerControls
{
    public partial class TransferTasks : Form
    {
        private readonly ILawyerRepository _lawyerRepository;
        private readonly ILawyerTaskRepository _lawyerTaskRepository;
        private readonly IFileTaskRepository _fileTaskRepository;
        private readonly ITaskRepository _taskRepository;
        private Lawyer SelectedUser;
        public TransferTasks(Lawyer selectedUser)
        {
            _lawyerRepository = Program.GetService<ILawyerRepository>();
            _lawyerTaskRepository = Program.GetService<ILawyerTaskRepository>();
            _fileTaskRepository = Program.GetService<IFileTaskRepository>();
            _taskRepository = Program.GetService<ITaskRepository>();
            SelectedUser = selectedUser;
            InitializeComponent();
            TransferTaskSelectedUserTextBox.Text = selectedUser.Description;
            Utils.Utils.SetComboBoxDataSource(TransferTaskTransferToComboBox, _lawyerRepository.List());
        }

        private void TransferTasks_Load(object sender, EventArgs e)
        {

        }

        private void TransferTasksButton_Click(object sender, EventArgs e)
        {
            Lawyer newLawyer = TransferTaskTransferToComboBox.SelectedItem as Lawyer;
            if (newLawyer != null)
            {
                _lawyerTaskRepository.SwitchLawyer(SelectedUser, newLawyer);
                _fileTaskRepository.SwitchLawyer(SelectedUser, newLawyer);
                _taskRepository.SwitchLawyer(SelectedUser, newLawyer);
                MessageBox.Show("Tasks have been transfered successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
