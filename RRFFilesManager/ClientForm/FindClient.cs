using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
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
        private readonly IClientRepository _clientRepository;
        public FindClient()
        {
            _clientRepository = (IClientRepository)Program.ServiceProvider.GetService(typeof(IClientRepository));
            InitializeComponent();
        }

        private static FindClient instance;
        public static FindClient Instance => instance == null || instance.IsDisposed ? (instance = new FindClient()) : instance;
        public Client SelectedClient { get; set; }

        private void FindClient_Load(object sender, EventArgs e)
        {
            ClientsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClientsGridView.MultiSelect = false;
            ClientsGridView.ReadOnly = true;
            this.ClientsGridView.DataSource = _clientRepository.SearchAsync(SearchTextBox.Text)?.Result;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ClientsGridView.DataSource = _clientRepository.SearchAsync(SearchTextBox.Text)?.Result;
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
            var client = _clientRepository.GetByIdAsync(clientId)?.Result;
            this.SelectedClient = client;
            Close();
        }
    }
}
