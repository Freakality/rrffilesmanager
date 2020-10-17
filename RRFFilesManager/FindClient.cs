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
        public static FindClient Instance => instance == null || instance.IsDisposed ? (instance = new FindClient()) : instance;

        private void FindClient_Load(object sender, EventArgs e)
        {
            ClientsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClientsGridView.MultiSelect = false;
            ClientsGridView.ReadOnly = true;
            this.ClientsGridView.DataSource = Program.DBContext.Clients.ToList();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ClientsGridView.DataSource = Program.DBContext.Clients.Where(s => 
                s.FirstName.Contains(SearchTextBox.Text) ||
                s.LastName.Contains(SearchTextBox.Text) ||
                s.Email.Contains(SearchTextBox.Text) ||
                s.ID.ToString().Contains(SearchTextBox.Text)
            ).ToList();
        }

        private void ClientsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {

        }

        private void ClientsGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var clientId = int.Parse(ClientsGridView?.SelectedRows?[0]?.Cells?["ID"]?.Value.ToString());
            var client = Program.DBContext.Clients.FirstOrDefault(s => s.ID == clientId);
            Home.IntakeForm.PotentialClientInfo.SetClient(client);
            Close();
        }
    }
}
