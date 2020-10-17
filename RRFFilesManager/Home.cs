using RRFFilesManager.IntakeForm;
using RRFFilesManager.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private static Home instance;
        public static Home Instance => instance ?? (instance = new Home());

        public static IntakeForm.IntakeForm IntakeForm { get; set; }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            SplashScreen.Instance.Hide();
        }

        private void IntakeButton_Click(object sender, EventArgs e)
        {
            Hide();
            PleaseWait.Instance.Show();
            IntakeForm = new IntakeForm.IntakeForm();
            IntakeForm.Show();
            PleaseWait.Instance.Hide();
        }

        private void ConflictChecks_Click(object sender, EventArgs e)
        {
            CNSignOn.StartProcess();
        }
    }
}
