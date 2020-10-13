using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRFFilesManager.DataAccess;
using RRFFilesManager.Abstractions;
using System.Text.RegularExpressions;

namespace RRFFilesManager.IntakeForm
{
    public partial class PotentialClientInfo : UserControl
    {
        public PotentialClientInfo()
        {
            InitializeComponent();
        }

        private static PotentialClientInfo instance;
        public static PotentialClientInfo Instance => instance ?? (instance = new PotentialClientInfo());
        public void SetClient(Client client) {
            IntakeForm.Intake.Client = client;
            FillForm(client);
        }
        public DateTime? PCIDateOfBirth
        {
            get
            {
                if (string.IsNullOrWhiteSpace(MonthBirth.Text) || string.IsNullOrWhiteSpace(DayBirth.Text) || string.IsNullOrWhiteSpace(YearBirth.Text))
                {
                    return default;
                }

                return DateTime.Parse($"{MonthBirth.Text}-{DayBirth.Text}-{YearBirth.Text}");
            }
        }

        private void PCIMobileNumber_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void monthBirth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dayBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void yearBirth_TextChanged(object sender, EventArgs e)
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
                PCIProvince.DataSource = Program.DBContext.Provinces.ToList();
                PCIProvince.DisplayMember = nameof(Province.Description);

                PCIMobileCarrier.DataSource = Program.DBContext.MobileCarriers.ToList();
                PCIMobileCarrier.DisplayMember = nameof(MobileCarrier.Description);
            
            YearBirth.Text = "1970";
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
            FillOrCreateIntakeClient();
        }

        public void FillClient(Client client)
        {
            client.Salutation = PCISalutation.Text;
            client.FirstName = PCIFirstName.Text;
            client.LastName = PCILastName.Text;
            client.Address = PCIAddress.Text;
            client.SuiteApt = PCISuiteApt.Text;
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
            client.OtherNotes = PCIOtherNotes.Text;
        }

        public void FillForm(Client client)
        {
            PCISalutation.Text = client.Salutation;
            PCIFirstName.Text = client.FirstName;
            PCILastName.Text = client.LastName;
            PCIAddress.Text = client.Address;
            PCISuiteApt.Text = client.SuiteApt;
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
            MonthBirth.Text = client.DateOfBirth?.Month.ToString();
            DayBirth.Text = client.DateOfBirth?.Day.ToString();
            PCIOtherNotes.Text = client.OtherNotes;
        }

        public Client CreateClient()
        {
                var client = new Client();
                FillClient(client);
                Program.DBContext.Clients.Add(client);
                Program.DBContext.SaveChanges();
                return client;
        }

        public Client UpdateClient(int clientId)
        {
                var client = Program.DBContext.Clients.FirstOrDefault(s => s.ID == clientId);
                FillClient(client);
                Program.DBContext.SaveChanges();
                return client;
        }

        public void FillOrCreateIntakeClient()
        {
            if (IntakeForm.Intake.Client == null)
                IntakeForm.Intake.Client = CreateClient();
            else
                IntakeForm.Intake.Client = UpdateClient(IntakeForm.Intake.Client.ID);
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
        }
    }
}
