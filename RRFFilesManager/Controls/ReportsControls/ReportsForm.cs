using RRFFilesManager.Controls.ReportsControls.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.ReportsControls
{
    public partial class ReportsForm : Form
    {
        private IntakeReportControls intakeReportControls;
        public IntakeReportControls IntakeReportControls => intakeReportControls ?? (intakeReportControls = new IntakeReportControls());
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            Utils.Utils.SetContent(Panel_Mid, IntakeReportControls);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Close();
            Home.Instance.Show();
        }

        private void ReportsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home.Instance.Show();
        }
    }
}
