using RRFFilesManager.Abstractions;
using RRFFilesManager.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.FileControls
{
    public partial class PeopleClientControl : UserControl, IPeopleInformation
    {
        public Contact Contact { get; set; }
        public PeopleClientControl()
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

            HomePhoneLabel.Text = contact.HomeNumber;
            WorkPhoneLabel.Text = contact.WorkNumber;
            CellLabel.Text = contact.Cell;
            FaxLabel.Text = contact.Fax;
            EmailLabel.Text = contact.Email;

            Street1Label.Text = contact.AddressLine1;
            Street2Label.Text = contact.AddressLine2;
            CityProvinceLabel.Text = $"{contact.City}, {contact.Province}";
            PostalCodeLabel.Text = contact.PostalCode;
            TextToEmailLabel.Text = contact.EmailToText;

            DateOfBirthLabel.Text = contact.DateOfBirth?.ToString("d");
            var healthcardstr = contact.HealthCard;
            healthcardstr = Regex.Replace(healthcardstr, @"^(....)(...)(...)$", "$1-$2-$3");
            HealthCardLabel.Text = healthcardstr;
            SINLabel.Text = contact.SIN;
            FirstLanguageLabel.Text = contact.FirstLanguage;
            Email2Label.Text = contact.Email;

            OCNameLabel.Text = contact.Contact1?.FirstName;
            OCRelationshipLabel.Text = contact.Contact1?.Relationship;
            OCPhoneLabel.Text = contact.Contact1?.DirectNumber;
            OCEmail.Text = contact.Contact1?.Email;
            if (contact.Photo != null)
                PhotoPictureBox.Image = Utils.Utils.ByteArrayToImage(contact.Photo);
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void PhotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Email2Label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Email2Label.LinkVisited = true;
            System.Diagnostics.Process.Start($"mailto:{Email2Label.Text}");
        }

        private void EmailLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmailLabel.LinkVisited = true;
            System.Diagnostics.Process.Start($"mailto:{EmailLabel.Text}");
        }
    }
}
