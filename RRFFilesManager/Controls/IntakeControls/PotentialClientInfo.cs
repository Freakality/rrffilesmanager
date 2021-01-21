using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using RRFFilesManager.DataAccess;
using RRFFilesManager.Abstractions;
using System.Text.RegularExpressions;
using RRFFilesManager.Logic;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.Controls.ContactControls;

namespace RRFFilesManager.IntakeForm
{
    public partial class PotentialClientInfo : UserControl
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly IMobileCarrierRepository _mobileCarrierRepository;
        private readonly IContactRepository _contactRepository;
        public PotentialClientInfo()
        {
            _provinceRepository = (IProvinceRepository)Program.ServiceProvider.GetService(typeof(IProvinceRepository));
            _mobileCarrierRepository = (IMobileCarrierRepository)Program.ServiceProvider.GetService(typeof(IMobileCarrierRepository));
            _contactRepository = (IContactRepository)Program.ServiceProvider.GetService(typeof(IContactRepository));
            InitializeComponent();
            Utils.SetContent(Content, new ClientGroupControl());

        }
        public IGroupControl GroupControl => (IGroupControl)Content.Controls?[0];
        public void SetClient(Contact client) {
            Home.IntakeForm.Intake.File.Client = client;
            FillForm(client);
        }


        public void UpsertClient()
        {
            if (Home.IntakeForm.Intake.File.Client == null)
                Home.IntakeForm.Intake.File.Client = new Contact();
            var client = Home.IntakeForm.Intake.File.Client;
            FillClient(client);
            if (client.ID == default)
                _contactRepository.Insert(client);
            else
                _contactRepository.Update(client);
        }

     

        public void OnNext()
        {
            UpsertClient();
        }

        public void FillClient(Contact client)
        {
            GroupControl.FillContact(client);
        }

        public void FillForm(Contact client)
        {
            if (client == null)
                return;
            GroupControl.FillForm(client);
        }

        private void PCISalutation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PCIProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FindClientButton_Click(object sender, EventArgs e)
        {
            FindClient.Instance.Show();
            FindClient.Instance.FormClosing += new FormClosingEventHandler(this.FindClient_FormClosing);
        }
        private void FindClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findClientForm = sender as FindClient;
            SetClient(findClientForm.SelectedClient);
        }

        private void PCIEmailToText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
