using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls
{
    public partial class InputBox : Form
    {
        public string Value { get; set; }
        public InputBox(string title, string groupBoxTitle, string label, string value = null)
        {
            InitializeComponent();
            Text = title;
            GroupBox.Text = groupBoxTitle;
            Label.Text = label;
            Value = value;
            TextBox.Text = value;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Value = TextBox.Text;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Value = null;
            Close();
        }
    }
}
