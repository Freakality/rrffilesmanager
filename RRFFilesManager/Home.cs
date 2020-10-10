using System;
using System.Diagnostics;

namespace RRFFilesManager
{
    public partial class Home
    {
        public Home()
        {
            InitializeComponent();
            _Button1.Name = "Button1";
            _Button2.Name = "Button2";
            _Button12.Name = "Button12";
            _Button3.Name = "Button3";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RRFFilesManager.My.MyProject.Forms.Form1.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RRFFilesManager.My.MyProject.Forms.Intake.Show();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string Path = @"M:\Task Manager\FilesManager\VBnetProgram\cnsignon.lnk";
            Process.Start(Path);
        }
    }
}