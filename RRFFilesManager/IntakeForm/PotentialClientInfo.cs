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

        public DateTime? PCIDateOfBirth
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.MonthBirth.Text) | string.IsNullOrWhiteSpace(this.DayBirth.Text) | string.IsNullOrWhiteSpace(this.YearBirth.Text))
                {
                    return default;
                }

                return DateTime.Parse(this.MonthBirth.Text + "-" + this.DayBirth.Text + "-" + this.YearBirth.Text);
            }
        }

        public DateTime? newLimDate
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.MonthBirth.Text) | string.IsNullOrWhiteSpace(this.DayBirth.Text) | string.IsNullOrWhiteSpace(this.YearBirth.Text))
                {
                    return default;
                }

                int newYear = Convert.ToInt32(this.YearBirth.Text);
                newYear = newYear + 20;
                return DateTime.Parse(this.MonthBirth.Text + "-" + this.DayBirth.Text + "-" + newYear.ToString());
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

        }

        // Private Sub PCIMobileNumber_TextChanged(sender As Object, e As EventArgs)
        // Dim newPN As String
        // If PCIMobileCarrier.Text <> "Other" Then
        // Dim dr() As System.Data.DataRow
        // dr = ActionLogDBDataSet.Tables("MobileCarrier").Select("Carrier='" & PCIMobileCarrier.Text & "'")
        // If dr.Length > 0 Then
        // Dim gateString As String = dr(0)("Gate").ToString()
        // newPN = PCIMobileNumber.Text.Replace("(", "")
        // newPN = newPN.Replace(")", "")
        // newPN = newPN.Replace(" ", "")
        // newPN = Trim(newPN.Replace("-", ""))
        // Me.PCIEmailToText.Text = newPN + "@" + gateString
        // End If
        // Else
        // Me.PCIEmailToText.Text = ""
        // End If
        // End Sub
        private void PotentialClientInfo_Load(object sender, EventArgs e)
        {
            //MobileCarrierTableAdapter.Fill(ActionLogDBDataSet.MobileCarrier);
            //ProvincesTableAdapter.Fill(ActionLogDBDataSet.Provinces);
            using (var context = new DataContext())
            {
                PCIProvince.DataSource = context.Provinces.ToList();
                PCIProvince.DisplayMember = nameof(Province.Description);

                PCIMobileCarrier.DataSource = context.MobileCarriers.ToList();
                PCIMobileCarrier.DisplayMember = nameof(MobileCarrier.Description);
            }
            
            //IntakesTableAdapter.Fill(ActionLogDBDataSet.Intakes);
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
            // IntakeForm.IntakesBindingSource.EndEdit()
            // IntakeForm.IntakesTableAdapter.Update(ActionLogDBDataSet.Intakes)
        }

        private void PCISalutation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PCIProvince_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
