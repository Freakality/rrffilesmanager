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
using RRFFilesManager.Controls.ReportsControls;
using RRFFilesManager.Controls.StaffControls;
using RRFFilesManager.Controls.FileControls.UserControls;
using RRFFilesManager.DataAccess.Abstractions;

namespace RRFFilesManager
{
    public partial class Home : Form
    {
        private readonly IPermissionRepository _permissionRepository;
        private int clearance;
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
            _permissionRepository = Program.GetService<IPermissionRepository>();
            InitializeComponent();
            UserFullName.Text = User?.Description;
            UserName.Text = User?.UserName;
            TableLayoutControlCollection controls = HomeTableLayoutPanel.Controls;

            for (int i = 0; i < controls.Count; i++)
            {
                if (controls[i] is Button)
                {
                    AddPermissionStrip(controls[i]);
                    /*HomePermissions homePermissions = new HomePermissions(controls[i]);
                    ContextMenuStrip contextMenuStrip = homePermissions.HomePermissionsContextMenuStrip;
                    controls[i].ContextMenuStrip = contextMenuStrip;*/
                }
            }
            AddPermissionStrip(ChangeLogViewButton);
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

        public static ReportsForm ReportsForm { get; set; }
        public static StaffPortal StaffPortal { get; set; }

        private void Home_Load(object sender, EventArgs e)
        {
            SplashScreen.Instance.Hide();
        }
        public void AddPermissionStrip(Control control)
        {
            HomePermissions homePermissions = new HomePermissions(control);
            ContextMenuStrip contextMenuStrip = homePermissions.HomePermissionsContextMenuStrip;
            control.ContextMenuStrip = contextMenuStrip;
        }
        private void IntakeButton_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                IntakeForm = Utils.Utils.OpenFormHome<IntakeForm.IntakeForm>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }
        private void ConflictChecks_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                CNSignOn.StartProcess();
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }
        private void FileManagerButton_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                FileManager = Utils.Utils.OpenFormHome<FileManager>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }
        private void ClientInfoButton_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                ContactInfo = Utils.Utils.OpenFormHome<ContactInfo>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }
        private void Contacts_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                ContactInfo = Utils.Utils.OpenFormHome<ContactInfo>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }
        private void CreateDocumentsButton_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                CreateDocument = Utils.Utils.OpenFormHome<CreateDocument>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }
        private void CreateTemplates_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                CreateTemplate = Utils.Utils.OpenFormHome<CreateTemplate>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }
        private void CalendarButton_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
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
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
            
        }
        private void PrivateFootPrintButton_Click(object sender, EventArgs e)
        {
            
        }
        internal int GetClearance(Control b)
        {
            Permission p = _permissionRepository.GetByDescription(b.Name);
            if (p != null)
            {
                clearance = p.MinClearance;
            }
            else
            {
                clearance = 10;
            }
            return clearance;
        }
        private void ImportDocumentsButton_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                Utils.Utils.OpenFormHome<UploadArchivesForm>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
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
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance|| User.ClearanceLevel == 99)
                Utils.Utils.OpenFormHome<CommissionCalculatorForm>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");

        }

        private void PrescriptionSummariesButton_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                Utils.Utils.OpenFormHome<PrescriptionSummariesForm>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }

        private void MedicalSummariesButton_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                Utils.Utils.OpenFormHome<MedicalSummariesForm>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }

        private void PredictorCalculatorButton_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                Utils.Utils.OpenFormHome<PredictorCalculatorForm>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                ReportsForm = Utils.Utils.OpenFormHome<ReportsForm>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }

        private void AddNewTaskButton_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                AddTaskManager = Utils.Utils.OpenFormHome<AddTaskManager>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }

        private void MasterTaskButton_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                MasterTaskManager = Utils.Utils.OpenFormHome<MasterTaskManager>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }

        private void ChangeLogViewButton_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                ChangeLogView = Utils.Utils.OpenFormHome<ChangeLogView>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }

        private void UserName_Click(object sender, EventArgs e)
        {
            if (User.ClearanceLevel == 0 || User.ClearanceLevel == 99)
                UserManagerForm = Utils.Utils.OpenFormHome<UserManagerForm>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }

        private void StaffPortalButton_Click(object sender, EventArgs e)
        {
            GetClearance(sender as Button);
            if (User.ClearanceLevel <= clearance || User.ClearanceLevel == 99)
                StaffPortal = Utils.Utils.OpenFormHome<StaffPortal>(this);
            else
                MessageBox.Show("User does not have enough permissions to access this screen.");
        }

        private void ButtonMouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Button)
            {
                Button btn = new Button();
                btn = (Button)sender;
                btn.Font = new Font("Century Gothic",11.00f,FontStyle.Bold);
            }
        }
        private void ButtonMouseLeave(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = new Button();
                btn = (Button)sender;
                btn.Font = new Font("Century Gothic", 9.75f, FontStyle.Bold);
            }
        }

        private void ClientNotesButton_Click(object sender, EventArgs e)
        {

        }

        private void DisbursementsButton_Click(object sender, EventArgs e)
        {

        }

        private void LimitationDeadlineTrackerButton_Click(object sender, EventArgs e)
        {

        }

        private void VariousDocumentUpdatesButton_Click(object sender, EventArgs e)
        {

        }

        private void ProtectedAccountsButton_Click(object sender, EventArgs e)
        {

        }

        private void ExpertDateBaseButton_Click(object sender, EventArgs e)
        {

        }

        private void ClientPortalButton_Click(object sender, EventArgs e)
        {

        }

        private void FileCloseOutButton_Click(object sender, EventArgs e)
        {

        }

        private void PostResolutionDataButton_Click(object sender, EventArgs e)
        {

        }

        private void HumanResourcesButton_Click(object sender, EventArgs e)
        {

        }

        private void MarketingButton_Click(object sender, EventArgs e)
        {

        }

        private void ProjectedOutcomesButton_Click(object sender, EventArgs e)
        {

        }

        private void ContinuingEducationButton_Click(object sender, EventArgs e)
        {

        }
    }
}
