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
            Utils.SetComboBoxDataSource(PCIProvince, _provinceRepository.List());
            Utils.SetComboBoxDataSource(PCIMobileCarrier, _mobileCarrierRepository.List());
            YearBirth.Text = "1970";
        }

        public void SetClient(Contact client) {
            Home.IntakeForm.Intake.File.Client = client;
            FillForm(client);
        }

        public string[] Months => new string[]
        {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"
        };

        public DateTime? PCIDateOfBirth
        {
            get
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(MonthBirth.Text) || string.IsNullOrWhiteSpace(DayBirth.Text) || string.IsNullOrWhiteSpace(YearBirth.Text))
                    {
                        return default;
                    }
                
                    return DateTime.Parse($"{MonthBirth.Text}-{DayBirth.Text}-{YearBirth.Text}");
                }
                catch
                {
                    return null;
                }
            }
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

        private void PCIMobileNumber_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void PCIMobileCarrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            PCIMobileNumber_TextChanged(sender, e);
        }

        private void PCIMobileNumber_TextChanged(object sender, EventArgs e)
        {
            var mobileCarrier = (MobileCarrier)PCIMobileCarrier.SelectedItem;
            if (mobileCarrier != null)
                PCIEmailToText.Text = $"{Regex.Replace(PCIMobileNumber.Text, "[ ()-]", "")}@{mobileCarrier?.Gate.Trim()}";
            else
                PCIEmailToText.Text = "";
        }
        private void PotentialClientInfo_Load(object sender, EventArgs e)
        {
            
        }

        public new bool Validate()
        {
            if (string.IsNullOrEmpty(this.PCISalutation.Text))
            {
                MessageBox.Show("Please enter Salutation");
                return false;
            }

            if (string.IsNullOrEmpty(this.PCIFirstName.Text))
            {
                MessageBox.Show("Please enter First Name");
                return false;
            }

            if (string.IsNullOrEmpty(this.PCILastName.Text))
            {
                MessageBox.Show("Please enter Last Name");
                return false;
            }

            if (string.IsNullOrEmpty(this.PCIEmail.Text) & string.IsNullOrEmpty(this.PCIAddress.Text) & string.IsNullOrEmpty(this.PCIPostalCode.Text) & string.IsNullOrEmpty(this.PCICity.Text) & string.IsNullOrEmpty(this.PCIProvince.Text))
            {
                MessageBox.Show("Please enter Email or Address");
                return false;
            }

            if (string.IsNullOrEmpty(this.PCIEmail.Text))
            {
                if (string.IsNullOrEmpty(this.PCIAddress.Text) | string.IsNullOrEmpty(this.PCIPostalCode.Text) | string.IsNullOrEmpty(this.PCICity.Text) | string.IsNullOrEmpty(this.PCIProvince.Text))
                {
                    if (string.IsNullOrEmpty(this.PCIAddress.Text))
                    {
                        MessageBox.Show("Please enter Address");
                        return false;
                    }

                    if (string.IsNullOrEmpty(this.PCICity.Text))
                    {
                        MessageBox.Show("Please enter City");
                        return false;
                    }

                    if (string.IsNullOrEmpty(this.PCIProvince.Text))
                    {
                        MessageBox.Show("Please enter Province");
                        return false;
                    }

                    if (string.IsNullOrEmpty(this.PCIPostalCode.Text))
                    {
                        MessageBox.Show("Please enter Postal Code");
                        return false;
                    }
                }
            }

            if (this.PCIHomeNumber.MaskCompleted == false & this.PCIWorkNumber.MaskCompleted == false & this.PCIMobileNumber.MaskCompleted == false)
            {
                MessageBox.Show("Please enter a Phone Number");
                return false;
            }

            if (this.YearBirth.MaskCompleted == false | string.IsNullOrEmpty(this.MonthBirth.Text) | string.IsNullOrEmpty(this.DayBirth.Text))
            {
                if (string.IsNullOrEmpty(this.MonthBirth.Text))
                {
                    MessageBox.Show("Please enter Month of Birth");
                    return false;
                }

                if (string.IsNullOrEmpty(this.DayBirth.Text))
                {
                    MessageBox.Show("Please enter Day of Birth");
                    return false;
                }

                if (this.YearBirth.MaskCompleted == false)
                {
                    MessageBox.Show("Please enter Year of Birth");
                    return false;
                }
            }

            return true;
        }

        public void OnNext()
        {
            UpsertClient();
        }

        public void FillClient(Contact client)
        {
            client.Salutation = PCISalutation.Text;
            client.FirstName = PCIFirstName.Text;
            client.LastName = PCILastName.Text;
            client.AddressLine1 = PCIAddress.Text;
            client.AddressLine2 = PCISuiteApt.Text;
            client.Email = PCIEmail.Text;
            client.Province = (Province)PCIProvince.SelectedItem;
            client.City = PCICity.Text;
            client.PostalCode = PCIPostalCode.Text;
            client.HomeNumber = PCIHomeNumber.Text;
            client.WorkNumber = PCIWorkNumber.Text;
            client.MobileNumber = PCIMobileNumber.Text;
            client.MobileCarrier = PCIMobileCarrier.Text;
            client.EmailToText = PCIEmailToText.Text;
            client.DateOfBirth = PCIDateOfBirth;
            //client.OtherNotes = PCIOtherNotes.Text;
        }

        public void FillForm(Contact client)
        {
            if (client == null)
                return;
            PCISalutation.Text = client.Salutation;
            PCIFirstName.Text = client.FirstName;
            PCILastName.Text = client.LastName;
            PCIAddress.Text = client.AddressLine1;
            PCISuiteApt.Text = client.AddressLine2;
            PCIEmail.Text = client.Email;
            PCIProvince.SelectedItem = client.Province;
            PCICity.Text = client.City;
            PCIPostalCode.Text = client.PostalCode;
            PCIHomeNumber.Text = client.HomeNumber;
            PCIWorkNumber.Text = client.WorkNumber;
            PCIMobileNumber.Text = client.MobileNumber;
            PCIMobileCarrier.Text = client.MobileCarrier;
            PCIEmailToText.Text = client.EmailToText;
            YearBirth.Text = client.DateOfBirth?.Year.ToString();
            MonthBirth.Text = client.DateOfBirth != null ? Months[client.DateOfBirth.Value.Month - 1] : null;
            DayBirth.Text = client.DateOfBirth?.Day.ToString();
            PCIOtherNotes.Text = client.Notes;
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
    }
}
