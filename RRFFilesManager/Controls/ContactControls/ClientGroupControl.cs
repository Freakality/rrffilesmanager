using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.Logic;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.ContactControls
{
    public partial class ClientGroupControl : UserControl, IGroupControl
    {
        private readonly IProvinceRepository _provinceRepository;
        private readonly IMobileCarrierRepository _mobileCarrierRepository;
        private readonly IContactRepository _contactRepository;

        public ClientGroupControl()
        {
            _provinceRepository = Program.GetService<IProvinceRepository>();
            _mobileCarrierRepository = Program.GetService<IMobileCarrierRepository>();
            _contactRepository = Program.GetService<IContactRepository>();
            InitializeComponent();
            Utils.SetComboBoxDataSource(Province, _provinceRepository.List());
            Utils.SetComboBoxDataSource(MobileCarrierComboBox, _mobileCarrierRepository.List());
        }
        public Abstractions.Group Group { get; set; }
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

        public void FillContact(Contact client)
        {
            client.Salutation = Salutation.Text;
            client.FirstName = FirstName.Text;
            client.LastName = LastName.Text;
            client.Suffix = Suffix.Text;
            client.Email = Email.Text;
            client.Email2 = Email2.Text;

            client.HomeNumber = HomeNumber.Text;
            client.WorkNumber = WorkNumber.Text;
            client.Cell = Cell.Text;
            client.Fax = Fax.Text;

            client.AddressLine1 = Street1.Text;
            client.AddressLine2 = Street2.Text;
            client.Province = (Province)Province.SelectedItem;
            client.City = City.Text;
            client.PostalCode = PostalCode.Text;
            client.MobileCarrier = MobileCarrierComboBox.Text;
            client.MobileNumber = MobileNumber.Text;
            client.EmailToText = TextToEmail.Text;

            client.DateOfBirth = PCIDateOfBirth;
            client.HealthCard = HealthCard.Text;
            client.SIN = SIN.Text;
            client.FirstLenguage = FirstLenguage.Text;

            client.Notes = Notes.Text;

            if (PhotoPictureBox.Image != null)
                client.Photo = Utils.ImageToByteArray(PhotoPictureBox.Image);

            if (!string.IsNullOrWhiteSpace(OCIName1.Text))
            {
                if(client.Contact1 == null)
                    client.Contact1 = new Contact();

                client.Contact1.FirstName = OCIName1.Text;
                client.Contact1.Relationship = OCIRelationship1.Text;
                client.Contact1.DirectNumber = OCIPhone1.Text;
                client.Contact1.Email = OCIEmail1.Text;

                if (client.Contact1.ID == default)
                    _contactRepository.Insert(client.Contact1);
                else
                    _contactRepository.Update(client.Contact1);
            }
                
        }

        public void FillForm(Contact client)
        {
            if (client == null)
                return;
            Salutation.Text = client.Salutation;
            FirstName.Text = client.FirstName;
            LastName.Text = client.LastName;
            Suffix.Text = client.Suffix;
            Email.Text = client.Email;
            Email2.Text = client.Email2;

            HomeNumber.Text = client.HomeNumber;
            WorkNumber.Text = client.WorkNumber;
            Cell.Text = client.Cell;
            Fax.Text = client.Fax;
            
            Street1.Text = client.AddressLine1;
            Street2.Text = client.AddressLine2;
            Province.SelectedItem = client.Province;
            City.Text = client.City;
            PostalCode.Text = client.PostalCode;
            MobileCarrierComboBox.Text = client.MobileCarrier;
            MobileNumber.Text = client.MobileNumber;
            TextToEmail.Text = client.EmailToText;

            YearBirth.Text = client.DateOfBirth?.Year.ToString();
            MonthBirth.Text = client.DateOfBirth != null ? Months[client.DateOfBirth.Value.Month - 1] : null;
            DayBirth.Text = client.DateOfBirth?.Day.ToString();
            HealthCard.Text = client.HealthCard;
            SIN.Text = client.SIN;
            FirstLenguage.Text = client.FirstLenguage;

            Notes.Text = client.Notes;

            if (client.Photo != null)
                PhotoPictureBox.Image = Utils.ByteArrayToImage(client.Photo);

            OCIName1.Text = client.Contact1?.FirstName;
            OCIRelationship1.Text = client.Contact1?.Relationship;
            OCIPhone1.Text = client.Contact1?.DirectNumber;
            OCIEmail1.Text = client.Contact1?.Email;
        }
        private void MobileCarrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void MobileCarrierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MobileNumber_TextChanged(sender, e);
        }

        private void MobileNumber_TextChanged(object sender, EventArgs e)
        {
            var mobileCarrier = (MobileCarrier)MobileCarrierComboBox.SelectedItem;
            if (mobileCarrier != null)
                TextToEmail.Text = $"{Regex.Replace(MobileNumber.Text, "[ ()-]", "")}@{mobileCarrier?.Gate.Trim()}";
            else
                TextToEmail.Text = "";
        }

        private void Salutation_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        public void SetGroup(Abstractions.Group group)
        {
            Group = group;
        }
    }
}
