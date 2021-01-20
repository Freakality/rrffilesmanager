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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.ContactControls
{
    public partial class ClientGroupControl : UserControl
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
            //Utils.SetComboBoxDataSource(comboBox1, _mobileCarrierRepository.List());
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

        public void FillClient(Contact client)
        {
            client.Salutation = Salutation.Text;
            client.FirstName = FirstName.Text;
            client.LastName = LastName.Text;
            client.Suffix = Suffix.Text;

            client.HomeNumber = HomeNumber.Text;
            client.WorkNumber = WorkNumber.Text;
            client.Cell = Cell.Text;
            client.Phone = Phone.Text;

            client.AddressLine1 = Street1.Text;
            client.AddressLine2 = Street2.Text;
            client.Email = Email.Text;
            client.Province = (Province)Province.SelectedItem;
            client.City = City.Text;
            client.PostalCode = PostalCode.Text;
            client.HomeNumber = HomeNumber.Text;
            client.WorkNumber = WorkNumber.Text;
            client.EmailToText = TextToEmail.Text;
            client.DateOfBirth = PCIDateOfBirth;
            client.Notes = Notes.Text;
        }

        public void FillForm(Contact client)
        {
            if (client == null)
                return;
            Salutation.Text = client.Salutation;
            FirstName.Text = client.FirstName;
            LastName.Text = client.LastName;
            Street1.Text = client.AddressLine1;
            Street2.Text = client.AddressLine2;
            Email.Text = client.Email;
            Province.SelectedItem = client.Province;
            City.Text = client.City;
            PostalCode.Text = client.PostalCode;
            HomeNumber.Text = client.HomeNumber;
            WorkNumber.Text = client.WorkNumber;
            TextToEmail.Text = client.EmailToText;
            YearBirth.Text = client.DateOfBirth?.Year.ToString();
            MonthBirth.Text = client.DateOfBirth != null ? Months[client.DateOfBirth.Value.Month - 1] : null;
            DayBirth.Text = client.DateOfBirth?.Day.ToString();
            Notes.Text = client.Notes;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PhotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void ClientGroupControl_Load(object sender, EventArgs e)
        {

        }

        private void MobileCarrier_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
