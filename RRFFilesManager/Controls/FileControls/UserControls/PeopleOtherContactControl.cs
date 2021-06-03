using RRFFilesManager.Abstractions;
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

namespace RRFFilesManager.Controls.FileControls
{
    public partial class PeopleOtherContactControl : UserControl, IPeopleInformation
    {
        public Contact Contact { get; set; }
        public PeopleOtherContactControl()
        {
            InitializeComponent();
        }

        public void SetContact(Contact contact)
        {
            Contact = contact;
            SetForm(contact);
        }

        public void SetForm(Contact contact)
        {
            NameLabel.Text = $"{contact.Salutation} {Contact.FirstName} {contact.LastName} {contact.Suffix}";
            GroupLabel.Text = contact.Group?.ToString();

            DirectPhoneLabel.Text = $"{contact.DirectNumber}";
            if (!string.IsNullOrWhiteSpace(contact.DirectExtension))
                DirectPhoneLabel.Text += $"ext { contact.DirectExtension}";
            OfficePhoneLabel.Text = $"{contact.OfficeNumber} ext {contact.OfficeExtension}";
            if (!string.IsNullOrWhiteSpace(contact.OfficeExtension))
                OfficePhoneLabel.Text += $"ext { contact.OfficeExtension}";
            CellLabel.Text = contact.Cell;
            FaxLabel.Text = contact.Fax;
            EmailLabel.Text = contact.Email;

            Street1Label.Text = contact.AddressLine1;
            Street2Label.Text = contact.AddressLine2;
            CityProvinceLabel.Text = $"{contact.City}, {contact.Province}";
            PostalCodeLabel.Text = contact.PostalCode;
            WebsiteLabel.Text = contact.Website;

            OC1NameLabel.Text = contact.Contact1?.FirstName;
            OC1TeamMemberLabel.Text = contact.Contact1?.TeamMember;
            OC1PhoneLabel.Text = contact.Contact1?.DirectNumber;
            if (!string.IsNullOrWhiteSpace(contact.Contact1?.DirectExtension))
                OC1PhoneLabel.Text += $"ext { contact.Contact1?.DirectExtension}";
            OC1EmailLabel.Text = contact.Contact1?.Email;

            OC2NameLabel.Text = contact.Contact2?.FirstName;
            OC2TeamMemberLabel.Text = contact.Contact2?.TeamMember;
            OC2PhoneLabel.Text = contact.Contact2?.DirectNumber;
            if (!string.IsNullOrWhiteSpace(contact.Contact2?.DirectExtension))
                OC2PhoneLabel.Text += $"ext { contact.Contact2?.DirectExtension}";
            OC2EmailLabel.Text = contact.Contact2?.Email;

            LicenseNumberLabel.Text = contact.LicenseNumber;

            if (contact.Photo != null)
                PhotoPictureBox.Image = Utils.ByteArrayToImage(contact.Photo);
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PeopleClientControl_Load(object sender, EventArgs e)
        {

        }

        private void PhotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void EmailLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmailLabel.LinkVisited = true;
            System.Diagnostics.Process.Start($"mailto:{EmailLabel.Text}");
        }

        private void OC1EmailLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OC1EmailLabel.LinkVisited = true;
            System.Diagnostics.Process.Start($"mailto:{OC1EmailLabel.Text}");
        }

        private void OC2EmailLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OC2EmailLabel.LinkVisited = true;
            System.Diagnostics.Process.Start($"mailto:{OC2EmailLabel.Text}");
        }
    }
}
