using RRFFilesManager.Abstractions;
using RRFFilesManager.ContactForm;
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

namespace RRFFilesManager.Controls.FileControls
{
    public partial class PeopleControl : UserControl
    {
        private File File { get; set; }
        private readonly PeopleClientControl PeopleClientControl;
        private readonly PeopleOtherContactControl PeopleOtherContactControl;
        private IPeopleInformation PeopleInformation => PeopleInformationPanel.Controls.Count > 0 ? PeopleInformationPanel.Controls[0] as IPeopleInformation : null;
        private readonly IFileRepository _fileRepository;
        private readonly IContactRepository _contactRepository;
        public PeopleControl()
        {
            _fileRepository = Program.GetService<IFileRepository>();
            _contactRepository = Program.GetService<IContactRepository>();
            InitializeComponent();
            PeopleClientControl = new PeopleClientControl();
            PeopleOtherContactControl = new PeopleOtherContactControl();
        }

        public void SetFile(File file)
        {
            File = file;
            FillPeopleDataGridView();
            var contact = File.Peoples.FirstOrDefault()?.Contact;
            if (contact == null)
                return;
            SetPeoplePanelInformation(contact);
        }

        private void SetPeoplePanelInformation(Contact contact)
        {
            if(contact.ID == File.Client.ID)
                Utils.SetContent(PeopleInformationPanel, PeopleClientControl);
            else
                Utils.SetContent(PeopleInformationPanel, PeopleOtherContactControl);
            if (PeopleInformation == null)
                return;
            PeopleInformation.SetContact(contact);
            PeopleNotes.Text = contact.Notes;
        }

        private void FillPeopleDataGridView()
        {
            PeoplesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PeoplesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PeoplesDataGridView.MultiSelect = false;
            PeoplesDataGridView.ReadOnly = true;
            PeoplesDataGridView.DataSource = File.Peoples.Select(s => new
            {
                ID = s.Contact.ID,
                Name = s.Contact.ToString(),
                Company = s.Contact.Company?.ToString(),
                Role = s.Contact.Group?.ToString()
            }).ToList();
            if (PeoplesDataGridView.Columns.Count == 0)
                return;
             PeoplesDataGridView.Columns["ID"].Visible = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            FindContact.Instance.Show();
            FindContact.Instance.FormClosing += new FormClosingEventHandler(this.FindContact_FormClosing);
        }

        private void FindContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findContactForm = sender as FindContact;
            var contact = findContactForm.Selected;
            if (contact == null)
                return;
            _fileRepository.AddFileContact(File, contact);
            FillPeopleDataGridView();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var contact = GetDataGridViewContact();
            if (contact == null)
                return;
            var contactform = new ContactInfo();
            PleaseWait.Instance.Show();
            contactform = new ContactInfo();
            contactform.FormClosing += new FormClosingEventHandler(this.EditContact_FormClosing);
            contactform.Show();
            PleaseWait.Instance.Hide();
            contactform.SetContact(contact);
        }
        private void EditContact_FormClosing(object sender, FormClosingEventArgs e)
        {
            FillPeopleDataGridView();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var contact = GetDataGridViewContact();
            if (contact == null)
                return;
            _fileRepository.RemoveFileContact(File, contact);
            FillPeopleDataGridView();
        }

        private void PeoplesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetCurrentPeoplePanelInformation();
        }
        private void SetCurrentPeoplePanelInformation()
        {
            var contact = GetDataGridViewContact();
            if (contact == null)
                return;
            SetPeoplePanelInformation(contact);
        }

        private Contact GetDataGridViewContact()
        {
            var id = GetDataGridViewId();
            if (id == null)
                return null;
            return _contactRepository.GetById(id.Value);
        }

        private int? GetDataGridViewId()
        {
            if (PeoplesDataGridView?.SelectedRows.Count == 0)
                return null;
            var id = PeoplesDataGridView?.SelectedRows?[0]?.Cells?["ID"]?.Value.ToString();
            if (id == null)
                return null;
            return int.Parse(id);
        }

        private void PeopleInformationPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
