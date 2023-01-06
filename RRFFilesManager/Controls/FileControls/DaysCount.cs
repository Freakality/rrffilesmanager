using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.FileControls
{
    public partial class DaysCount : Form
    {
        public DaysCount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CboxSelectionDay.SelectedIndex < 0)
            {
                MessageBox.Show("Select the follow-up days");
                return;
            }
            else
            {
                
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
