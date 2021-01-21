using RRFFilesManager.Abstractions;
using RRFFilesManager.Controls.CompanyControls;
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

namespace RRFFilesManager.Controls.ContactControls
{
    public partial class OtherGroupsControl : UserControl, IGroupControl
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly IMobileCarrierRepository _mobileCarrierRepository;
        private readonly IContactRepository _contactRepository;
        public OtherGroupsControl()
        {
            _provinceRepository = Program.GetService<IProvinceRepository>();
            _mobileCarrierRepository = Program.GetService<IMobileCarrierRepository>();
            _contactRepository = Program.GetService<IContactRepository>();
            InitializeComponent();
            Utils.SetComboBoxDataSource(Province, _provinceRepository.List());
        }

        public Contact Contact { get; set; }
        private Company company;
        public Company Company
        {
            get => company;
            set
            {
                company = value;
                FillForm(company);
            }
        }
        public string[] Months => new string[]
        {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };

        public void FillContact(Contact client)
        {
            client.Salutation = Salutation.Text;
            client.FirstName = FirstName.Text;
            client.LastName = LastName.Text;
            client.Email = Email.Text;


            client.DirectNumber = DirectNumber.Text;
            client.OfficeNumber = OfficeNumber.Text;
            client.Fax = Fax.Text;
            //client.Phone = Phone.Text;

            client.AddressLine1 = Street1.Text;
            client.AddressLine2 = Street2.Text;
            client.Province = (Province)Province.SelectedItem;
            client.City = City.Text;
            client.PostalCode = PostalCode.Text;
            client.Website = Website.Text;


            client.Notes = Notes.Text;
        }

        public void FillForm(Contact client)
        {
            if (client == null)
                return;
            Salutation.Text = client.Salutation;
            FirstName.Text = client.FirstName;
            LastName.Text = client.LastName;
            Street1.Text = client.AddressLine1;
            Street2.Text = client.AddressLine2;
            Email.Text = client.Email;
            Province.SelectedItem = client.Province;
            City.Text = client.City;
            PostalCode.Text = client.PostalCode;
            DirectNumber.Text = client.HomeNumber;
            OfficeNumber.Text = client.OfficeNumber;
            Website.Text = client.EmailToText;

            Notes.Text = client.Notes;
        }

        public void FillForm(Company company)
        {
            if (company == null)
                return;
            CompanyTextBox.Text = company.ToString();
            Province.SelectedItem = company.Province;
            Street1.Text = company.AddressLine1;
            Street2.Text = company.AddressLine2;
            City.Text = company.City;
            PostalCode.Text = company.PostalCode;
        }


        private void FindCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findCompanyForm = sender as FindCompany;
            Company = findCompanyForm.Selected;
            if (Company == null)
                CompanyTextBox.Text = Company.Description;
        }

        private void CompanyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var findCompany = new FindCompany(true);
            findCompany.Show();
            findCompany.FormClosing += new FormClosingEventHandler(this.FindCompany_FormClosing);
        }

        private void PhotoPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
