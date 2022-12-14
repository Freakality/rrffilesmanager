using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.FileControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.UserManagerControls
{
    public partial class UserManagerForm : Form
    {
        private readonly ILawyerRepository _lawyerRepository;
        private Lawyer SelectedLawyer;
        private string passwordhash = "";
        public UserManagerForm()
        {
            _lawyerRepository = Program.GetService<ILawyerRepository>();
            InitializeComponent();
            UserLawyerListBox.DataSource = _lawyerRepository.List();
            UserLawyerListBox.DisplayMember = "Description";
        }

        private void UserLawyerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedLawyer = UserLawyerListBox.SelectedItem as Lawyer;
            FillLawyerFields(SelectedLawyer);
        }

        private void FillLawyerFields(Lawyer lawyer)
        {
            TBoxDescriptionTextBox.Text = lawyer.Description;
            NUDNumberIDNUpDown.Value = Convert.ToDecimal(lawyer.NumberID);
            if (lawyer.ContractDate != null)
                DTPContractDateDateTime.Value = (DateTime)lawyer.ContractDate;
            else
                DTPContractDateDateTime.Value = DTPContractDateDateTime.MinDate;
            if (lawyer.EarnBaseCommissionAsFileLawyer != null)
            {
                if ((bool)lawyer.EarnBaseCommissionAsFileLawyer)
                    CBoxBaseComissionCheckBox.Checked = true;
            }
            else
                CBoxBaseComissionCheckBox.Checked = false;
            if (lawyer.ResponsibleLawyerBaseCommissionMultiplier != null)
                NUDComissionMultiplierNUpDown.Value = Convert.ToDecimal(lawyer.ResponsibleLawyerBaseCommissionMultiplier);
            if (lawyer.IsParalegal)
                CBoxIsParalegalCheckBox.Checked = true;
            else
                CBoxIsParalegalCheckBox.Checked = false;
            if (lawyer.UserName != null)
                TBoxUserNameTextBox.Text = lawyer.UserName;
            else
                TBoxUserNameTextBox.Clear();
            if (lawyer.ClearanceLevel != 99 && lawyer.ClearanceLevel <= 10 && lawyer.ClearanceLevel >= 0)
            {
                TBarClearanceLevelTrackBar.Value = lawyer.ClearanceLevel;
            }
            CBoxChangePasswordCheckBox.Checked = false;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AddUserLawyer(SelectedLawyer);
            MessageBox.Show("User data has been saved.");
        }

        private void FillLawyer(Lawyer lawyer)
        {
            lawyer.Description = TBoxDescriptionTextBox.Text;
            lawyer.NumberID = (int?)NUDNumberIDNUpDown.Value;
            if (DTPContractDateDateTime.Value != DTPContractDateDateTime.MinDate)
                lawyer.ContractDate = DTPContractDateDateTime.Value;
            lawyer.EarnBaseCommissionAsFileLawyer = CBoxBaseComissionCheckBox.Checked;
            if (NUDComissionMultiplierNUpDown.Value > 0)
                lawyer.ResponsibleLawyerBaseCommissionMultiplier = Convert.ToDouble(NUDComissionMultiplierNUpDown.Value);
            lawyer.IsParalegal = CBoxIsParalegalCheckBox.Checked;
            lawyer.ClearanceLevel = TBarClearanceLevelTrackBar.Value;
            if (!String.IsNullOrEmpty(TBoxUserNameTextBox.Text))
            {
                lawyer.UserName = TBoxUserNameTextBox.Text;
                if (CBoxChangePasswordCheckBox.Checked && TBoxNewPasswordTextBox.Text == TBoxConfirmPasswordTextBox.Text && !String.IsNullOrEmpty(TBoxNewPasswordTextBox.Text))
                    lawyer.Password = Utils.Utils.GetHash(TBoxUserNameTextBox.Text, TBoxNewPasswordTextBox.Text);
            }
        }

        /*private string GetPasswordHash(string username, string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(username + password, salt, 10310);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;
        }*/

        private void NewButton_Click(object sender, EventArgs e)
        {
            var lawyer = new Lawyer();
            AddUserLawyer(lawyer);
            MessageBox.Show("User has been added.");
        }

        private void AddUserLawyer(Lawyer lawyerToAdd)
        {
            var lawyer = lawyerToAdd;
            FillLawyer(lawyer);
            if (lawyer.ID == default)
                _lawyerRepository.Insert(lawyer);
            else
                _lawyerRepository.Update(lawyer);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Close();
            Home.Instance.Show();
        }
    }
}
