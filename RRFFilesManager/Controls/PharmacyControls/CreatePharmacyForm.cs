using RRFFilesManager.Abstractions;
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

namespace RRFFilesManager.Controls.PharmacyControls
{
    public partial class CreatePharmacyForm : Form
    {
        public Pharmacy Pharmacy { get; set; }
        private readonly IPharmacyRepository _pharmacyRepository;
        public CreatePharmacyForm()
        {
            _pharmacyRepository = Program.GetService<IPharmacyRepository>();
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;
            UpsertClient();
            Close();
        }

        public new bool Validate()
        {
            if (string.IsNullOrEmpty(NameTB.Text))
            {
                MessageBox.Show("Please enter Name");
                return false;
            }
            return true;
        }

        public void UpsertClient()
        {
            if (Pharmacy == null)
                Pharmacy = new Pharmacy();
            FillPharmacy(Pharmacy);
            if (Pharmacy.ID == default)
                _pharmacyRepository.Insert(Pharmacy);
            else
                _pharmacyRepository.Update(Pharmacy);
        }
        public void FillPharmacy(Pharmacy pharmacy)
        {
            pharmacy.Name = NameTB.Text;
            pharmacy.Address1 = Address1TB.Text;
            pharmacy.Address2 = Address2TB.Text;
            pharmacy.City = CityTB.Text;
            pharmacy.Province = ProvinceCB.Province;
            pharmacy.PostalCode = PostalCodeTB.Text;
            pharmacy.PhoneNumber1 = PhoneNumber1MTB.Text;
            pharmacy.PhoneNumber2 = PhoneNumber2MTB.Text;
        }
    }
}
