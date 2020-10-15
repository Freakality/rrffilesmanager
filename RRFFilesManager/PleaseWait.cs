using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager
{
    public partial class PleaseWait : Form
    {
        public PleaseWait()
        {
            InitializeComponent();
        }
        private static PleaseWait instance;
        public static PleaseWait Instance => instance == null || instance.IsDisposed ? (instance = new PleaseWait()) : instance;
        private void PleaseWait_Load(object sender, EventArgs e)
        {

        }
        static public void ShowForm()
        {
            instance = new PleaseWait();
            Application.Run(instance);
        }
        static public void CloseForm()
        {
            instance.Close();
        }
    }
}
