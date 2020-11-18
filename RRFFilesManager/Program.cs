using Microsoft.Extensions.DependencyInjection;
using RRFFilesManager.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager
{
    static class Program
    {
        public static DataContext DBContext { get; set; } = new DataContext();
        public static IServiceProvider ServiceProvider { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(Home.Instance);
        }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.RegisterDataAccessServices();
            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
