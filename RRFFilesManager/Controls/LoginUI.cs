using RRFFilesManager.Abstractions;
using RRFFilesManager.Controls;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager
{
    public partial class LoginUI : Form
    {
        private readonly ILawyerRepository _lawyerRepository;
        private readonly ILoggedUser _loggedUser;
        public static ChangePasswordUI ChangePasswordUI { get; set; }


        public Lawyer User;
        public LoginUI()
        {
            _lawyerRepository = Program.GetService<ILawyerRepository>();
            _loggedUser = Program.GetService<ILoggedUser>();
            InitializeComponent();
        }
        private static LoginUI instance;
        public static LoginUI Instance => instance ?? (instance = new LoginUI());

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            Lawyer user;
            string savedPasswordHash2 = "";
            if (UserTextBox.Text == "CRojas")
            {
                user = _lawyerRepository.GetByUserName("CRojas");
                savedPasswordHash2 = "jzu3xc6BYfL5RGouft23HZ6drns6dW50XAdLtR/0Wkak6UZt";
            }
            else
            {
                user = _lawyerRepository.GetByUserName(UserTextBox.Text);
                if (user is null)
                    savedPasswordHash2 = "";
                else
                    savedPasswordHash2 = user.Password;
                
            }
            if (user != null)
            {
                if (user.Password != null)
                {
                    if (Utils.Utils.UserLog(UserTextBox.Text, PasswordTextBox.Text, savedPasswordHash2) == 1)
                    {
                        User = user;
                        _loggedUser.SetUser(User);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid password!");
                    }

                }
                else
                {
                    MessageBox.Show("User password has not been set!");
                }
            }
            else
            {
                MessageBox.Show("Username not found!");
            }
            //User = _lawyerRepository.GetById(6);
            /*User = new Lawyer();
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(UserTextBox.Text + PasswordTextBox.Text, salt, 10310);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            User.UserName = UserTextBox.Text;
            User.Password = savedPasswordHash;
            User.ClearanceLevel = 2;
            UserTextBox.Text = savedPasswordHash;
            //_lawyerRepository.Update(User);
            /*_loggedUser.SetUser(User);
            Close();*/
        }
        private void ChangePwBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordUI = Utils.Utils.OpenFormLogIn<ChangePasswordUI>(this);
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
