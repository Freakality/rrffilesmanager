using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
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
    public partial class DenialsForm : Form
    {
        private readonly IDenialRepository _DenialRepository;
        private readonly IDenialBenefitRepository denialBenefitRepository;
        private readonly IDenialStatusRepository denialStatusRepository;

        public DenialsForm()
        {
            _DenialRepository = Program.GetService<IDenialRepository>();
            denialBenefitRepository = Program.GetService<IDenialBenefitRepository>();
            denialStatusRepository = Program.GetService<IDenialStatusRepository>();
            InitializeComponent();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            if (sender is DateTimePicker)
            {
                DateTimePicker dtp = new DateTimePicker();
                dtp = (DateTimePicker)sender;
                if (dtp.Name == "dtpTreatmentPlanDate")
                {
                    txtTreatmentPlanDate.Text = dtp.Value.ToShortDateString();
                }
                else if (dtp.Name == "dtpDateDenied")
                {
                    txtDateDenied.Text = dtp.Value.ToShortDateString();
                    txtLimitationDate.Text = dtp.Value.AddYears(2).ToShortDateString();
                }
            }
        }
        private bool IsEmpty()
        {
            bool val = false;
            foreach (Control item in panel1.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox c = new ComboBox();
                    c = item as ComboBox;
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        val = true;
                    }
                }
            }
            foreach (Control item in panel2.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = new TextBox();
                    txt = item as TextBox;
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        val = true;
                    }
                }
            }

            return val;
        }
        private void Save()
        {
            Denial data = new Denial
            {
                FileId = Home.FileManager.File.ID,
                DenialBenefit = denialBenefitRepository.GetByDescription(CboxDenialBenefit.Text),
                AmountInDispute = string.IsNullOrEmpty(txtAmountDispute.Text)? 0.00m :Convert.ToDecimal(txtAmountDispute.Text),
                TreatmentPlanDate = Convert.ToDateTime(txtTreatmentPlanDate.Text),
                DateDenied = Convert.ToDateTime(txtDateDenied.Text),
                ServiceProvider = TxtServicesProvider.Text,
                ServiceType = txtServicesType.Text,
                RangeFrom = RangeFrom.Text,
                RangeTo = RangeTo.Text,
                DisputeRelatedTo = txtDisputeRelateTo.Text,
                LimitationDate = Convert.ToDateTime(txtLimitationDate.Text),
                DenialStatus = denialStatusRepository.GetByDescription(CboxStatus.Text),
                DenialNotes = txtNotes.Text
            };
            _DenialRepository.Insert(data,Home.FileManager.File);
        }
        private void btnSaveDenials_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                MessageBox.Show("Complete all the requested information.");
                return;
            }
            else
            {
                Save();
                MessageBox.Show("the data was saved successfully.");
                this.DialogResult = DialogResult.OK;
                
            }
        }
        private void txtKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
