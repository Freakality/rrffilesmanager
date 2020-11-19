using RRFFilesManager.Abstractions;
using RRFFilesManager.Abstractions.DataAccess;
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
    public partial class FindContact : Form
    {

        private readonly IContactRepository _contactRepository;
        public FindContact()
        {
            _contactRepository = (IContactRepository)Program.ServiceProvider.GetService(typeof(IContactRepository));
            InitializeComponent();
            ContactsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ContactsGridView.MultiSelect = false;
            ContactsGridView.ReadOnly = true;
            ContactsGridView.DataSource = _contactRepository.SearchAsync(SearchTextBox.Text, 50)?.Result;
        }

        private static FindContact instance;
        public static FindContact Instance => instance == null || instance.IsDisposed ? (instance = new FindContact()) : instance;
        public Contact Selected { get; set; }
        

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ContactsGridView.DataSource = _contactRepository.SearchAsync(SearchTextBox.Text, 50)?.Result;
        }

        private void ContactsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var contactId = int.Parse(ContactsGridView?.SelectedRows?[0]?.Cells?["ID"]?.Value.ToString());
            Selected = _contactRepository.GetByIdAsync(contactId)?.Result;
            Close();
        }
    }
}
