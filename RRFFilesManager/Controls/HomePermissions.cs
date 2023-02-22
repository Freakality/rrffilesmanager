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
    public partial class HomePermissions : UserControl
    {

        private readonly IPermissionRepository _permissionRepository;

        private Control b;
        public HomePermissions(Control control)
        {
            b = control;
            InitializeComponent();
            _permissionRepository = Program.GetService<IPermissionRepository>();
        }
        private void ButtonCheck(int newClearance)
        {
            Permission p = _permissionRepository.GetByDescription(b.Name);
            if (p != null)
            {
                p.MinClearance = newClearance;
                _permissionRepository.Update(p);
            }
            else
            {
                p = new Permission();
                p.ButtonDescription = b.Name;
                p.MinClearance = newClearance;
                _permissionRepository.Insert(p);
            }
        }

        private void HomePermissionsContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            var user = Program.GetUser();
            if (user.ClearanceLevel != 0 && user.ClearanceLevel != 99)
            {
                e.Cancel = true;
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonCheck(0);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ButtonCheck(1);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ButtonCheck(2);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ButtonCheck(3);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ButtonCheck(4);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ButtonCheck(5);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ButtonCheck(6);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ButtonCheck(7);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            ButtonCheck(8);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            ButtonCheck(9);
        }

        private void lowestClearanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonCheck(10);
        }
    }
}
