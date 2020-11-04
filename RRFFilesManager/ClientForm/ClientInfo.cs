using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.ClientForm
{
    public partial class ClientInfo : Form
    {
        public ClientInfo()
        {
            InitializeComponent();
        }

        private void FindClientButton_Click(object sender, EventArgs e)
        {
            FindClient.Instance.Show();
            FindClient.Instance.FormClosing += new FormClosingEventHandler(this.FindClient_FormClosing);
            
        }

        private void FindClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findClientForm = sender as FindClient;
            FillForm(findClientForm.SelectedClient);
        }

        private void ClientInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }

        public void FillForm(Client client)
        {
            if (client == null)
                return;
            ClientNameTextBox.Text =$"{client.FirstName} {client.LastName}";
            DateOfBirthTextBox.Text = client.DateOfBirth?.ToShortDateString();
            NotesTextBox.Text = client.OtherNotes;
        }

        private void NotesTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
