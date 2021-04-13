using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.Components
{
    public class CurrencyTextBox : TextBox
    {
        public CurrencyTextBox()
        {
            TextAlign = HorizontalAlignment.Right;
        }
        public string CurrencySymbol { get; set; } = "$";

        public override string Text { 
            get => $"{CurrencySymbol} {base.Text}"; 
            set => base.Text = value;
        }
    }
}