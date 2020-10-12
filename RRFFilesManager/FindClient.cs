using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess;
using RRFFilesManager.IntakeForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager
{
    public partial class FindClient : Form
    {
        public FindClient()
        {
            InitializeComponent();
        }

        private static FindClient instance;
        public static FindClient Instance => instance ?? (instance = new FindClient());

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FindClient_Load(object sender, EventArgs e)
        {
            ClientsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClientsGridView.MultiSelect = false;
            using (var context = new DataContext())
            {
                this.ClientsGridView.DataSource = context.Clients.ToList();
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                this.ClientsGridView.DataSource = context.Clients.Where(s => 
                    s.FirstName.Contains(SearchTextBox.Text) ||
                    s.LastName.Contains(SearchTextBox.Text) ||
                    s.Email.Contains(SearchTextBox.Text) ||
                    s.ID.ToString().Contains(SearchTextBox.Text)
                ).ToList();
            }
        }

        private void ClientsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var clientId = int.Parse(ClientsGridView?.SelectedRows?[0]?.Cells?["ID"]?.Value.ToString());
            using (var context = new DataContext())
            {
                var client = context.Clients.FirstOrDefault(s => s.ID == clientId);
                PotentialClientInfo.Instance.SetClient(client);
            }
            Hide();
        }
    }
}
