using RRFFilesManager.Abstractions;
using RRFFilesManager.Controls.CompanyControls;
using RRFFilesManager.Controls.ContactControls;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RRFFilesManager.ContactForm
{
    public partial class ContactInfo : Form
    {
        private readonly IContactRepository _contactRepository;
        private readonly IProvinceRepository _provinceRepository;
        private readonly ICompanyRepository _companyRepository;
        private readonly IGroupRepository _groupRepository;
        public ContactInfo()
        {
            _contactRepository = Program.GetService<IContactRepository>();
            _provinceRepository = Program.GetService<IProvinceRepository>();
            _companyRepository = Program.GetService<ICompanyRepository>();
            _groupRepository = Program.GetService<IGroupRepository>();
            InitializeComponent();
            Utils.SetComboBoxDataSource(Group, _groupRepository.List());
        }
        public Contact Contact { get; set; }
        private Company company;
        public Company Company 
        { 
            get => company; 
            set {
                company = value;
                FillForm(company);
            }
        }
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
           
        }

        public void FillForm(Contact contact)
        {
            if (contact == null)
                return;
   
        }

        public void FillForm(Company company)
        {
            if (company == null)
                return;
     
        }


        public void UpsertContact()
        {
            if (Contact == null)
                Contact = new Contact();
            FillContact(Contact);
            if (Contact.ID == default)
                _contactRepository.Insert(Contact);
            else
                _contactRepository.Update(Contact);
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

       

        private void ContactInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }


        private string GetInitials(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "";
            var values = value.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s));
            var initials = values.Select(s => s?[0]);
            return string.Join(" ", initials);
        }

        private void ContactInfoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Group.Text))
                return;
            if (Group.Text == "Client")
                Utils.SetContent(Content, new ClientGroupControl());
            else
                Utils.SetContent(Content, new OtherGroupsControl());
        }
    }
}
