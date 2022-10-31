using Microsoft.Extensions.DependencyInjection;
using RRFFilesManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using RRFFilesManager.Abstractions;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace RRFFilesManager
{
    static class Program
    {

        public static IServiceProvider ServiceProvider { get; set; }

        private static Lawyer User { get; set; }

        public static T GetService<T>() {
            return (T)ServiceProvider?.GetService(typeof(T));
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                ConfigureServices();
                LoginUI.Instance.FormClosing += Login_FormClosing;
                Application.Run(LoginUI.Instance);
                if (GetUser() is null)
                    return;
                //Application.Run(LoginUI.Instance);
                Application.Run(Home.Instance);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private static void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            var form = (LoginUI)sender;
            if (form.User != null)
            {
                SetUser(form.User);
            }
        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.RegisterDataAccessServices();
            ServiceProvider = services.BuildServiceProvider();
        }

        public static void SetUser(Lawyer user)
        {
            User = user;
        }
        public static Lawyer GetUser()
        {
            return User;
        }
    }
}
