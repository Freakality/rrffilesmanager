using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.Controls.StaffControls;
using RRFFilesManager.Controls.StaffControls.UserControls;
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

namespace RRFFilesManager.Controls.StaffControls
{
    public partial class StaffPortal : Form
    {
        public bool SettingFile = false;
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskCategoryRepository _taskCategoryRepository;
        private readonly ILawyerRepository _lawyerRepository;
        private readonly ITaskStateRepository _taskStateRepository;
        public readonly AdminViewControls AdminViewControls;
        public readonly StaffViewControls StaffViewControls;
        private Lawyer User;
        public StaffPortal()
        {
            _lawyerRepository = Program.GetService<ILawyerRepository>();
            _taskRepository = Program.GetService<ITaskRepository>();
            _taskCategoryRepository = Program.GetService<ITaskCategoryRepository>();
            _taskStateRepository = Program.GetService<ITaskStateRepository>();
            User = Program.GetUser();
            InitializeComponent();
            if (User.ClearanceLevel == 0 || User.ClearanceLevel == 99)
            {
                AdminViewControls = new AdminViewControls();
                Utils.Utils.SetContent(panel1, AdminViewControls);
            }
            else
            {
                StaffViewControls = new StaffViewControls();
                Utils.Utils.SetContent(panel1, StaffViewControls);
            }
        }

        private static StaffPortal instance;
        public static StaffPortal Instance => instance == null || instance.IsDisposed ? (instance = new StaffPortal()) : instance;
       
        private void StaffPortal_Load(object sender, EventArgs e)
        {
            
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Close();
            Home.Instance.Show();
        }

    }
}
