using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            SplashScreen.Instance.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Hide();
            Intake.Intake.Instance.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {

        }

        private void Button11_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var path = "M:\\Task Manager\\FilesManager\\VBnetProgram\\cnsignon.lnk";
            Process.Start(path);
        }
    }
}
