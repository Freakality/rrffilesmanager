using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace RRFFilesManager.ContactForm
{
    public partial class FindContact : Form
    {

        private readonly IContactRepository _contactRepository;
        private readonly bool CanEdit;
        public FindContact(bool canCreate = false, bool canEdit = true)
        {
            _contactRepository = (IContactRepository)Program.ServiceProvider.GetService(typeof(IContactRepository));
            InitializeComponent();
            ContactsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ContactsGridView.MultiSelect = false;
            ContactsGridView.ReadOnly = true;
            ContactsGridView.DataSource = _contactRepository.Search(SearchTextBox.Text, 50);
            CanEdit = canEdit;
            CreateButton.Visible = canCreate;
            if (!canCreate)
                TableLayoutPanel.ColumnCount = 1;
        }

        public Contact Selected { get; set; }

        public ContactInfo ContactInfo { get; set; }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ContactsGridView.DataSource = _contactRepository.Search(SearchTextBox.Text, 50);
        }

        private void ContactsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRows = ContactsGridView?.SelectedRows;
            if (selectedRows?.Count > 0)
            {
                var contactId = int.Parse(ContactsGridView?.SelectedRows?[0]?.Cells?["ID"]?.Value.ToString());
                Selected = _contactRepository.GetById(contactId);
            }
            Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            OpenContactInfo();
        }

        private void OpenContactInfo()
        {
            ContactInfo = new ContactInfo(Selected);
            ContactInfo.Show();
            ContactInfo.FormClosing += new FormClosingEventHandler(this.ContactInfo_FormClosing);
        }
        private void ContactInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            var companyInfo = sender as ContactInfo;
            if (companyInfo.Contact.ID != default)
            {
                Selected = companyInfo.Contact;
                Close();
            }
        }
    }
}
