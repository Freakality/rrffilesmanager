using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace RRFFilesManager
{
    public partial class Submitting : Form
    {
        public Submitting()
        {
            InitializeComponent();
        }
        private static Submitting instance;
        public static Submitting Instance => instance == null || instance.IsDisposed ? (instance = new Submitting()) : instance;

        private void Submitting_Load(object sender, EventArgs e)
        {

        }
    }
}
