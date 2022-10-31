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
using Task = RRFFilesManager.Abstractions.Task;

namespace RRFFilesManager.Controls.MasterTaskControls
{
    public partial class DependencySelect : Form
    {
        private readonly ITaskRepository _taskRepository;
        public List<Abstractions.Task> SelectedDependencies = new List<Abstractions.Task>();
        public bool Transferring = false;
        public DependencySelect(Task task, List<Abstractions.Task> SelectedDependencies, ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
            InitializeComponent();
            var taskList = _taskRepository.List();
            foreach (Task t in taskList)
            {
                if (t != task)
                {
                    DependencyCheckList.Items.Add(t);
                    if (SelectedDependencies.Contains(t))
                    {
                        DependencyCheckList.SetItemChecked(DependencyCheckList.Items.IndexOf(t), true);

                    }
                }
            }
        }

        private void OKDependenciesButton_Click(object sender, EventArgs e)
        {
            Transferring = true;
            Close();
        }

        private void DependencySelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Transferring)
            {
                foreach (object dependency in DependencyCheckList.CheckedItems)
                {
                    SelectedDependencies.Add((Task)dependency);
                }
            }

        }
    }
}
