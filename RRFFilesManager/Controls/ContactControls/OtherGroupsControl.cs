using RRFFilesManager.Abstractions;
using RRFFilesManager.Controls.CompanyControls;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.ContactControls
{
    public partial class OtherGroupsControl : UserControl, IGroupControl
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly IMobileCarrierRepository _mobileCarrierRepository;
        private readonly IContactRepository _contactRepository;
        private readonly IPositionRepository _positionRepository;
        public OtherGroupsControl()
        {
            _provinceRepository = Program.GetService<IProvinceRepository>();
            _mobileCarrierRepository = Program.GetService<IMobileCarrierRepository>();
            _contactRepository = Program.GetService<IContactRepository>();
            _positionRepository = Program.GetService<IPositionRepository>();
            InitializeComponent();
            Utils.SetComboBoxDataSource(Province, _provinceRepository.List());
            
        }

        public Group Group { get; set; }
        public Contact Contact { get; set; }
        private Company company;
        public Company Company
        {
            get => company;
            set
            {
                company = value;
                FillForm(company);
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

        public void FillContact(Contact client)
        {
            client.Salutation = Salutation.Text;
            client.FirstName = FirstName.Text;
            client.LastName = LastName.Text;
            client.Email = Email.Text;
            client.Company = Company;
            client.JobTitle = JobTitle.Text;
            client.LicenseNumber = LicenseNumber.Text;
            client.Date = Date.Text;

            client.DirectNumber = DirectNumber.Text;
            client.DirectExtension = DirectExtension.Text;
            client.OfficeNumber = OfficeNumber.Text;
            client.OfficeExtension = OfficeExtension.Text;
            client.Fax = Fax.Text;
            client.Cell = Cell.Text;

            client.AddressLine1 = Street1.Text;
            client.AddressLine2 = Street2.Text;
            client.Province = (Province)Province.SelectedItem;
            client.City = City.Text;
            client.PostalCode = PostalCode.Text;
            client.Website = Website.Text;

            client.Notes = Notes.Text;

            if (PhotoPictureBox.Image != null)
                client.Photo = Utils.ImageToByteArray(PhotoPictureBox.Image);

            if (!string.IsNullOrWhiteSpace(OCIName1.Text))
            {
                if (client.Contact1 == null)
                    client.Contact1 = new Contact();

                client.Contact1.FirstName = OCIName1.Text;
                client.Contact1.TeamMember = OCITeamMember1.Text;
                client.Contact1.DirectNumber = OCIPhone1.Text;
                client.Contact1.DirectExtension = OCIPhoneExtension1.Text;
                client.Contact1.Email = OCIEmail1.Text;

                if (client.Contact1.ID == default)
                    _contactRepository.Insert(client.Contact1);
                else
                    _contactRepository.Update(client.Contact1);
            }


            if (!string.IsNullOrWhiteSpace(OCIName2.Text))
            {
                if (client.Contact2 == null)
                    client.Contact2 = new Contact();

                client.Contact2.FirstName = OCIName2.Text;
                client.Contact2.TeamMember = OCITeamMember2.Text;
                client.Contact2.DirectNumber = OCIPhone2.Text;
                client.Contact2.DirectExtension = OCIPhoneExtension2.Text;
                client.Contact2.Email = OCIEmail2.Text;

                if (client.Contact2.ID == default)
                    _contactRepository.Insert(client.Contact2);
                else
                    _contactRepository.Update(client.Contact2);
            }
        }

        public void FillForm(Contact client)
        {
            if (client == null)
                return;
            Salutation.Text = client.Salutation;
            FirstName.Text = client.FirstName;
            LastName.Text = client.LastName;
            Email.Text = client.Email;
            CompanyTextBox.Text = client.Company?.Description;
            JobTitle.Text = client.JobTitle;
            LicenseNumber.Text = client.LicenseNumber;
            Date.Text = client.Date;

            DirectNumber.Text = client.DirectNumber;
            DirectExtension.Text = client.DirectExtension;
            OfficeNumber.Text = client.OfficeNumber;
            OfficeExtension.Text = client.OfficeExtension;
            Fax.Text = client.Fax;
            Cell.Text = client.Cell;

            Street1.Text = client.AddressLine1;
            Street2.Text = client.AddressLine2;
            Province.SelectedItem = client.Province;
            City.Text = client.City;
            PostalCode.Text = client.PostalCode;
            Website.Text = client.EmailToText;

            Notes.Text = client.Notes;

            if (client.Photo != null)
                PhotoPictureBox.Image = Utils.ByteArrayToImage(client.Photo);

            OCIName1.Text = client.Contact1?.FirstName;
            OCITeamMember1.Text = client.Contact1?.TeamMember;
            OCIPhone1.Text = client.Contact1?.DirectNumber;
            OCIPhoneExtension1.Text = client.Contact1?.DirectExtension;
            OCIEmail1.Text = client.Contact1?.Email;

            OCIName2.Text = client.Contact2?.FirstName;
            OCITeamMember2.Text = client.Contact2?.TeamMember;
            OCIPhone2.Text = client.Contact2?.DirectNumber;
            OCIPhoneExtension2.Text = client.Contact2?.DirectExtension;
            OCIEmail2.Text = client.Contact2?.Email;
        }

        public void FillForm(Company company)
        {
            if (company == null)
                return;
            CompanyTextBox.Text = company.ToString();
            Province.SelectedItem = company.Province;
            Street1.Text = company.AddressLine1;
            Street2.Text = company.AddressLine2;
            City.Text = company.City;
            PostalCode.Text = company.PostalCode;
        }


        private void FindCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            var findCompanyForm = sender as FindCompany;
            Company = findCompanyForm.Selected;
            if (Company == null)
                CompanyTextBox.Text = Company.Description;
        }

        private void CompanyLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var findCompany = new FindCompany(true);
            findCompany.Show();
            findCompany.FormClosing += new FormClosingEventHandler(this.FindCompany_FormClosing);
        }

        private void PhotoPictureBox_Click(object sender, EventArgs e)
        {
            openPhotoDialog.Filter = "Image Only(*.jpg;*.jpeg;*.gif;*.bmp;*.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            try
            {
                if (openPhotoDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openPhotoDialog.CheckFileExists)
                    {
                        string path = Path.GetFullPath(openPhotoDialog.FileName);
                        PhotoPictureBox.Image = new Bitmap(openPhotoDialog.FileName);
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }
        }
        public void SetGroup(Group group)
        {
            Group = group;
            if (group == null)
                return;
            Utils.SetComboBoxDataSource(JobTitle, _positionRepository.List(group.ID));
        }
    }
}
