using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.CompanyControls
{
    public partial class CompanyInfo : Form
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly ICompanyRepository _companyRepository;
        public CompanyInfo()
        {
            _provinceRepository = Program.GetService<IProvinceRepository>();
            _companyRepository = Program.GetService<ICompanyRepository>();
            InitializeComponent();
            Utils.SetComboBoxDataSource(Province, _provinceRepository.List());
        }

        public CompanyInfo(Company company) : this()
        {
            Company = company;
        }

        private Company company;
        public Company Company 
        {
            get 
            {
                if (company == null)
                    company = new Company();
                FillCompany(company);
                return company;
            }
            set 
            { 
                company = value;
                if (company == null)
                    return;
                FillForm(company); 
            } 
        }

        private void FindCompany_Click(object sender, EventArgs e)
        {
            var findCompany = new FindCompany();
            findCompany.Show();
            findCompany.FormClosing += new FormClosingEventHandler(this.FindCompany_FormClosing);
        }

        private void FindCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findCompany = sender as FindCompany;
            Company = findCompany.Selected;
        }

        public void FillCompany(Company company)
        {
            if (company == null)
                return;
            company.Description = Description.Text;
            company.Phone = PhoneNumber.Text;
            company.Email = Email.Text;
            company.Province = (Province)Province.SelectedItem;
            company.City = City.Text;
            company.Street = Street.Text;
            company.PostalCode = PostalCode.Text;
            company.Memo = Memo.Text;
        }

        public void FillForm(Company company)
        {
            if (company == null)
                return;
            Description.Text = company.Description;
            PhoneNumber.Text = company.Phone;
            Email.Text = company.Email;
            Province.SelectedItem = company.Province;
            City.Text = company.City;
            Street.Text = company.Street;
            PostalCode.Text = company.PostalCode;
            Memo.Text = company.Memo;
        }

        public void UpsertCompany()
        {           
            if (Company.ID == default)
                _companyRepository.Insert(Company);
            else
                _companyRepository.Update(Company);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;
            UpsertCompany();
            Close();
        }

        public new bool Validate()
        {
            if (string.IsNullOrEmpty(Description.Text))
            {
                MessageBox.Show("Please enter Description");
                return false;
            }
            return true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
