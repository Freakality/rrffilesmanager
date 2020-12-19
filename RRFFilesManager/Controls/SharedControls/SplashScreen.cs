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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        private static SplashScreen instance;
        public static SplashScreen Instance => instance ?? (instance = new SplashScreen());
        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
