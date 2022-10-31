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

namespace RRFFilesManager.Controls
{
    public partial class ChangePasswordUI : Form
    {
        private readonly ILawyerRepository _lawyerRepository;
        public ChangePasswordUI()
        {
            _lawyerRepository = Program.GetService<ILawyerRepository>();
            InitializeComponent();
            UserTextBox.Text = LoginUI.Instance.UserTextBox.Text;
            PasswordTextBox.Text = LoginUI.Instance.PasswordTextBox.Text;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
            LoginUI.Instance.Show();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            Lawyer user;
            string savedPasswordHash2 = "";
            user = _lawyerRepository.GetByUserName(UserTextBox.Text);
            if (user is null)
                savedPasswordHash2 = "";
            else
                savedPasswordHash2 = user.Password;

            if (user != null)
            {
                if (TBoxNewPasswordTextBox.Text == TBoxConfirmPasswordTextBox.Text)
                {
                    if (!String.IsNullOrEmpty(TBoxNewPasswordTextBox.Text))
                    {
                        if (Utils.Utils.UserLog(UserTextBox.Text, PasswordTextBox.Text, savedPasswordHash2) == 1)
                        {
                            user.Password = Utils.Utils.GetHash(UserTextBox.Text, TBoxNewPasswordTextBox.Text);
                            _lawyerRepository.Update(user);
                            MessageBox.Show("Password has been updated!");
                            Close();
                            LoginUI.Instance.Show();

                        }
                        else
                        {
                            MessageBox.Show("Invalid password!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Password field can't be empty!");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords don't match!");
                }

            }
            else
            {
                MessageBox.Show("Username not found!");
            }
        }
    }
}
