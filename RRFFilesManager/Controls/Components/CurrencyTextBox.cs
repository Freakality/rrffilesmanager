using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.Components
{
    public partial class CurrencyTextBox : TextBox
    {
        private Decimal mDollarValue;
        public CurrencyTextBox()
        {
            DollarValue = 0;
            TextAlign = HorizontalAlignment.Right;
            KeyPress += CurrencyTextBox_KeyPress;
            Validated += CurrencyTextBox_Validated;
            Click += CurrencyTextBox_Click;
            TextChanged += CurrencyTextBox_TextChanged;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void CurrencyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numbers, decimals and control characters
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && this.Text.Contains("."))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && this.Text.Length < 1)
            {
                e.Handled = true;
            }
        }

        private void CurrencyTextBox_Validated(object sender, EventArgs e)
        {
            try
            {
                // format the value as currency
                Decimal dTmp = Convert.ToDecimal(this.Text);
                this.Text = $"{CurrencySymbol} {String.Format("{0:n}", dTmp)}";
            }
            catch { }
        }
        private void CurrencyTextBox_Click(object sender, EventArgs e)
        {
            this.Text = mDollarValue.ToString();
            if (this.Text == "0" || this.Text == "")
                this.Clear();
            this.SelectionStart = this.Text.Length;
        }
        private void CurrencyTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DollarValue = Convert.ToDecimal(this.Text);
            }
            catch 
            {
                if (this.Text == "")
                    DollarValue = 0;
            }
        }
        public decimal DollarValue
        {
            get
            {
                return mDollarValue;
            }
            set
            {
                mDollarValue = value;
                if (mDollarValue > 0)
                {
                    this.Text = $"{CurrencySymbol} {String.Format("{0:n}", mDollarValue)}";
                }
            }
        }
        public string CurrencySymbol { get; set; } = "$";

        /*public override string Text
        {
            get => $"{CurrencySymbol} {base.Text}";
            set => base.Text = value;
        }*/


    }
}