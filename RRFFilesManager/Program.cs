using Microsoft.Extensions.DependencyInjection;
using RRFFilesManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;

namespace RRFFilesManager
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static T GetService<T>() {
            return (T)ServiceProvider.GetService(typeof(T));
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
                Application.Run(Home.Instance);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.RegisterDataAccessServices();
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
