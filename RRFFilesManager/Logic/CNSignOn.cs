using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Logic
{
    public class CNSignOn
    {
        public static Process StartProcess()
        {
            var Path = ConfigurationManager.AppSettings["CNSignOnPath"];
            return Process.Start(Path);
        }
    }
}
