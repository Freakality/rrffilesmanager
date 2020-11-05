﻿using RRFFilesManager.Abstractions;
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

namespace RRFFilesManager.ClientForm
{
    public partial class ClientInfo : Form
    {
        public ClientInfo()
        {
            InitializeComponent();
            Utils.SetComboBoxDataSource(PCIProvince, Program.DBContext.Provinces.ToList());
            Utils.SetComboBoxDataSource(PCIMobileCarrier, Program.DBContext.MobileCarriers.ToList());
            YearBirth.Text = "1970";
        }

        public Client Client { get; set; }

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

        private void FindClientButton_Click(object sender, EventArgs e)
        {
            FindClient.Instance.Show();
            FindClient.Instance.FormClosing += new FormClosingEventHandler(this.FindClient_FormClosing);
            
        }

        public void UpsertClient()
        {
            if (Client == null)
                Client = new Client();
            FillClient(Client);
            if(Client.ID == default)
                Program.DBContext.Clients.Add(Client);
            Program.DBContext.SaveChanges();
        }

        private void FindClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findClientForm = sender as FindClient;
            Client = findClientForm.SelectedClient;
            FillForm(Client);
        }

        private void ClientInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
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
            if (client == null)
                return;
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
            MonthBirth.Text = client.DateOfBirth != null ? Months[client.DateOfBirth.Value.Month - 1] : null;
            DayBirth.Text = client.DateOfBirth?.Day.ToString();
            PCIOtherNotes.Text = client.OtherNotes;
        }

        private void NotesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;
            UpsertClient();
            this.Hide();
            Home.Instance.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
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

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var lastIntake = Program.DBContext.Intakes.OrderByDescending(s => s.DateOfCall).FirstOrDefault();
            var filePath = IntakeManager.GetOrCreateIntakeWorkBook(lastIntake);
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var woorkbook = excelApp.Workbooks.Open(filePath);
            excelApp.Visible = true;
        }
    }
}
