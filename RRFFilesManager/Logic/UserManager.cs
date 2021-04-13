using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Logic
{
    public class UserManager
    {
        public static string GetUserFullName()
        {
            string DomainName = GetUserDomainName();
            string AccountName = GetUserName();
            SelectQuery query = new SelectQuery("select FullName from Win32_UserAccount where domain='" + DomainName + "' and name='" + AccountName + "'");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            var disk = searcher.Get().OfType<ManagementBaseObject>().FirstOrDefault();
            return disk["FullName"].ToString();
        }

        public static string GetUserName()
        {
            return Environment.UserName;
        }

        public static string GetUserDomainName()
        {
            return Environment.UserDomainName;
        }

        public static string  GetFullUserName()
        {
            return $"{GetUserDomainName()}\\{GetUserName()}";
        }
    }
}
