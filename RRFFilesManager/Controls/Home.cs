using Microsoft.Office.Interop.Outlook;
using RRFFilesManager.ClientForm;
using RRFFilesManager.ContactForm;
using RRFFilesManager.IntakeForm;
using RRFFilesManager.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.IO;
using RRFFilesManager.Controls.ArchiveControls;
using RRFFilesManager.Controls.CommisionCalculatorControls;
using RRFFilesManager.Controls.PrescriptionSummariesControls;
using RRFFilesManager.Controls.MedicalSummariesControls;

namespace RRFFilesManager
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            UserFullName.Text = UserManager.GetUserFullName();
            UserName.Text = UserManager.GetFullUserName();
        }

        private static Home instance;
        public static Home Instance => instance ?? (instance = new Home());

        public static IntakeForm.IntakeForm IntakeForm { get; set; }

        public static FileManager FileManager { get; set; }
        public static ClientInfo ClientInfo { get; set; }
        public static ContactInfo ContactInfo { get; set; }
        public static CreateDocument CreateDocument { get; set; }
        public static CreateTemplate CreateTemplate { get; set; }

        private void Home_Load(object sender, EventArgs e)
        {
            SplashScreen.Instance.Hide();
        }

        private void IntakeButton_Click(object sender, EventArgs e)
        {
            IntakeForm = Utils.Utils.OpenForm<IntakeForm.IntakeForm>(this);
        }

        private void ConflictChecks_Click(object sender, EventArgs e)
        {
            CNSignOn.StartProcess();
        }

        private void FileManagerButton_Click(object sender, EventArgs e)
        {
            FileManager = Utils.Utils.OpenForm<FileManager>(this);
        }

        private void ClientInfoButton_Click(object sender, EventArgs e)
        {
            ContactInfo = Utils.Utils.OpenForm<ContactInfo>(this);
        }

        private void Contacts_Click(object sender, EventArgs e)
        {
            ContactInfo = Utils.Utils.OpenForm<ContactInfo>(this);
        }

        private void CreateDocumentsButton_Click(object sender, EventArgs e)
        {
            CreateDocument = Utils.Utils.OpenForm<CreateDocument>(this);
        }

        private void CreateTemplates_Click(object sender, EventArgs e)
        {
            CreateTemplate = Utils.Utils.OpenForm<CreateTemplate>(this);
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            try
            {
                var oApp = new Microsoft.Office.Interop.Outlook.Application();
                var ns = oApp.GetNamespace("MAPI");
                ns.Logon();
                var inbox = ns.GetDefaultFolder(OlDefaultFolders.olFolderCalendar);
                if (oApp.Explorers.Count > 0)
                {
                    Explorer expl = oApp.Explorers[1];
                    expl.CurrentFolder = inbox;
                }

                inbox.Display();
            }
            catch { }
            
        }

        private void PrivateFootPrintButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ImportDocumentsButton_Click(object sender, EventArgs e)
        {
            Utils.Utils.OpenForm<UploadArchivesForm>(this);
        }

        private void CommisionCalculatorButton_Click(object sender, EventArgs e)
        {
            var authorizedUsers = new string[] { "FOISYR", "MANZANOD", "ITDEV", "FELIX" };
            if (authorizedUsers.Any(user => UserManager.GetUserName().ToUpper() == user))
            {
                Utils.Utils.OpenForm<CommissionCalculatorForm>(this);
            }
            else
            {
                MessageBox.Show("Not Authorized");
            }
            
        }

        private void PrescriptionSummariesButton_Click(object sender, EventArgs e)
        {
            Utils.Utils.OpenForm<PrescriptionSummariesForm>(this);
        }

        private void MedicalSummariesButton_Click(object sender, EventArgs e)
        {
            Utils.Utils.OpenForm<MedicalSummariesForm>(this);
        }
    }
}
