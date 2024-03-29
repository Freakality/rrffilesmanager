﻿using RRFFilesManager.Abstractions;
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
        private bool _editing;
        public ContactInfo()
        {
            _contactRepository = Program.GetService<IContactRepository>();
            _provinceRepository = Program.GetService<IProvinceRepository>();
            _companyRepository = Program.GetService<ICompanyRepository>();
            _groupRepository = Program.GetService<IGroupRepository>();
            InitializeComponent();
            Utils.Utils.SetComboBoxDataSource(Group, _groupRepository.List());
        }

        public ContactInfo(Contact contact) : this()
        {
            Contact = contact;
        }

        private Contact contact;
        public Contact Contact
        {
            get
            {
                if (contact == null)
                    contact = new Contact();
                FillContact(contact);
                return contact;
            }
            set
            {
                contact = value;
                if (contact == null)
                    return;
                FillForm(contact);
            }
        }
        //private OtherGroupsControl otherGroupsControl;
        //public OtherGroupsControl OtherGroupsControl => otherGroupsControl ?? (otherGroupsControl = new OtherGroupsControl());

        //private ClientGroupControl clientGroupControl;
        //public ClientGroupControl ClientGroupControl => clientGroupControl ?? (clientGroupControl = new ClientGroupControl());

        public IGroupControl GroupControl => Content.Controls.Count > 0 ? (IGroupControl)Content.Controls?[0] : null;


        public void SetContact(Contact contact)
        {
            Contact = contact;
            FillForm(Contact);
        }
        
        private void FindContactButton_Click(object sender, EventArgs e)
        {
            var findContact = new FindContact();
            findContact.Show();
            findContact.FormClosing += new FormClosingEventHandler(this.FindContact_FormClosing);
        }

        private void FindContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findContactForm = sender as FindContact;
            SetContact(findContactForm.Selected);
        }

        public void FillContact(Contact client)
        {
            client.Group = (Abstractions.Group)Group.SelectedItem;
            GroupControl.FillContact(client);
        }

        public void FillForm(Contact client)
        {
            if (client == null)
                return;
            Group.SelectedItem = client.Group;
            SetContent();
            GroupControl.SetContact(client);
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
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
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
            if (_editing)
                return;
            SetContent();
            var group = (Abstractions.Group)Group?.SelectedItem;
            GroupControl?.SetGroup(group);
        }

        private void SetContent()
        {
            if (string.IsNullOrWhiteSpace(Group.Text))
            {
                Content.Controls.Clear();
                return;
            }
            if (Group.Text == "Client")
                Utils.Utils.SetContent(Content, new ClientGroupControl());
            else
                Utils.Utils.SetContent(Content, new OtherGroupsControl());
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddGroup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var groupForm = new GroupForm();
            groupForm.Show();
            groupForm.FormClosing += GroupForm_FormClosing;
        }

        private void GroupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _editing = true;
            Utils.Utils.SetComboBoxDataSource(Group, _groupRepository.List());
            _editing = false;
        }
    }
}
