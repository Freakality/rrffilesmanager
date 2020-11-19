using RRFFilesManager.Abstractions;
using RRFFilesManager.Abstractions.DataAccess;
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

namespace RRFFilesManager.ContactForm
{
    public partial class ContactInfo : Form
    {
        private readonly IContactRepository _contactRepository;
        private readonly IProvinceRepository _provinceRepository;
        private readonly ICompanyRepository _companyRepository;
        public ContactInfo()
        {
            _contactRepository = (IContactRepository)Program.ServiceProvider.GetService(typeof(IContactRepository));
            _provinceRepository = (IProvinceRepository)Program.ServiceProvider.GetService(typeof(IProvinceRepository));
            _companyRepository = (ICompanyRepository)Program.ServiceProvider.GetService(typeof(ICompanyRepository));
            InitializeComponent();
            Utils.SetComboBoxDataSource(Province, _provinceRepository.ListAsync()?.Result);
            //Utils.SetComboBoxDataSource(Company, _companyRepository.ListAsync()?.Result.Take(10));
        }
        public Contact Contact { get; set; }
        private void FindContactButton_Click(object sender, EventArgs e)
        {
            FindContact.Instance.Show();
            FindContact.Instance.FormClosing += new FormClosingEventHandler(this.FindContact_FormClosing);
        }

        private void FindContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findContactForm = sender as FindContact;
            Contact = findContactForm.Selected;
            FillForm(Contact);
        }

        public void FillContact(Contact contact)
        {
            contact.Salutation = Salutation.Text;
            contact.Prefix = Prefix.Text;
            contact.Suffix = Suffix.Text;
            contact.Initials = Initials.Text;
            contact.FirstName = FirstName.Text;
            contact.MiddleName = MiddleName.Text;
            contact.LastName = LastName.Text;
            contact.Email = Email.Text;
            contact.Company = (Company)Company.SelectedItem;
            contact.Province = (Province)Province.SelectedItem;
            contact.Street = Street.Text;
            contact.City = City.Text;
            contact.PostalCode = PostalCode.Text;
            contact.Phone = PhoneNumber.Text;
            contact.Memo = OtherNotes.Text;
        }

        public void FillForm(Contact contact)
        {
            if (contact == null)
                return;
            Salutation.Text = contact.Salutation;
            Prefix.Text = contact.Prefix;
            Suffix.Text = contact.Suffix;
            Initials.Text = contact.Initials;
            FirstName.Text = contact.FirstName;
            MiddleName.Text = contact.MiddleName;
            LastName.Text = contact.LastName;
            Email.Text = contact.Email;
            Company.SelectedItem = contact.Company;
            Province.SelectedItem = contact.Province;
            Street.Text = contact.Street;
            City.Text = contact.City;
            PostalCode.Text = contact.PostalCode;
            PhoneNumber.Text = contact.Phone;
            OtherNotes.Text = contact.Memo;
        }
        public void UpsertContact()
        {
            if (Contact == null)
                Contact = new Contact();
            FillContact(Contact);
            if (Contact.ID == default)
                _contactRepository.InsertAsync(Contact);
            else
                _contactRepository.UpdateAsync(Contact);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;
            UpsertContact();
            Close();
            Home.Instance.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
            Home.Instance.Show();
        }

        public new bool Validate()
        {
            if (string.IsNullOrEmpty(Salutation.Text))
            {
                MessageBox.Show("Please enter Salutation");
                return false;
            }

            if (string.IsNullOrEmpty(FirstName.Text))
            {
                MessageBox.Show("Please enter First Name");
                return false;
            }

            if (string.IsNullOrEmpty(MiddleName.Text))
            {
                MessageBox.Show("Please enter Middle Name");
                return false;
            }

            if (string.IsNullOrEmpty(LastName.Text))
            {
                MessageBox.Show("Please enter Last Name");
                return false;
            }

            if (string.IsNullOrEmpty(Email.Text))
            {
                MessageBox.Show("Please enter Email or Address");
                return false;
            }

            if (string.IsNullOrEmpty(this.City.Text))
            {
                MessageBox.Show("Please enter City");
                return false;
            }

            if (string.IsNullOrEmpty(this.Province.Text))
            {
                MessageBox.Show("Please enter Province");
                return false;
            }

            if (string.IsNullOrEmpty(this.PostalCode.Text))
            {
                MessageBox.Show("Please enter Postal Code");
                return false;
            }

            if (this.PhoneNumber.MaskCompleted == false)
            {
                MessageBox.Show("Please enter a Phone Number");
                return false;
            }

            return true;
        }

        private void ContactInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }
    }
}
