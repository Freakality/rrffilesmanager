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
using RRFFilesManager.Controls.PredictorCalculatorControls;
using RRFFilesManager.Controls.MasterTaskControls;
using RRFFilesManager.Controls;
using RRFFilesManager.Abstractions;
using RRFFilesManager.Controls.FileControls;
using RRFFilesManager.Controls.UserManagerControls;

namespace RRFFilesManager
{
    public partial class Home : Form
    {
        public Home()
        {
            /* try
             {
                 using (LoginUI login = new LoginUI())
                 {
                     if (login.ShowDialog() != DialogResult.OK)
                     {
                         Environment.Exit(1);
                     }
                     else
                     {
                         if (CurrentUser.Level == EUserLevels.INVENTARIO && CurrentUser.Name != "NR")
                         {
                             MessageBox.Show("Usuario no admitido.");
                             Environment.Exit(1);
                         }
                     }
                 }
             }
             catch
             {
                 return;
             }*/
            User = Program.GetUser();
            InitializeComponent();
            UserFullName.Text = User.Description;
            UserName.Text = User.UserName;
            //UserFullName.Text = UserManager.GetUserFullName();
            //UserName.Text = UserManager.GetFullUserName();
        }

        private static Lawyer User;
        private static Home instance;
        public static Home Instance => instance ?? (instance = new Home());

        public static IntakeForm.IntakeForm IntakeForm { get; set; }

        public static FileManager FileManager { get; set; }
        public static ClientInfo ClientInfo { get; set; }
        public static ContactInfo ContactInfo { get; set; }
        public static CreateDocument CreateDocument { get; set; }
        public static CreateTemplate CreateTemplate { get; set; }
        public static MasterTaskManager MasterTaskManager { get; set; }
        public static AddTaskManager AddTaskManager { get; set; }
        public static ChangeLogView ChangeLogView { get; set; }
        public static UserManagerForm UserManagerForm { get; set; }

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
            /*var authorizedUsers = new string[] { "FOISYR", "MANZANOD", "ITDEV", "FELIX" };
            if (authorizedUsers.Any(user => UserManager.GetUserName().ToUpper() == user))
            {
                Utils.Utils.OpenForm<CommissionCalculatorForm>(this);
            }
            else
            {
                MessageBox.Show("Not Authorized");
            }*/
            if (User.ClearanceLevel == 0 || User.ClearanceLevel == 99)
                Utils.Utils.OpenForm<CommissionCalculatorForm>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");

        }

        private void PrescriptionSummariesButton_Click(object sender, EventArgs e)
        {
            Utils.Utils.OpenForm<PrescriptionSummariesForm>(this);
        }

        private void MedicalSummariesButton_Click(object sender, EventArgs e)
        {
            Utils.Utils.OpenForm<MedicalSummariesForm>(this);
        }

        private void PredictorCalculatorButton_Click(object sender, EventArgs e)
        {
            Utils.Utils.OpenForm<PredictorCalculatorForm>(this);
        }

        private void AddNewTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskManager = Utils.Utils.OpenForm<AddTaskManager>(this);
        }

        private void MasterTaskButton_Click(object sender, EventArgs e)
        {
            MasterTaskManager = Utils.Utils.OpenForm<MasterTaskManager>(this);
        }

        private void ChangeLogViewButton_Click(object sender, EventArgs e)
        {
            if (User.ClearanceLevel == 0 || User.ClearanceLevel == 99)
                ChangeLogView = Utils.Utils.OpenForm<ChangeLogView>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }

        private void UserName_Click(object sender, EventArgs e)
        {
            if (User.ClearanceLevel == 0 || User.ClearanceLevel == 99)
                UserManagerForm = Utils.Utils.OpenForm<UserManagerForm>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }
    }
}
