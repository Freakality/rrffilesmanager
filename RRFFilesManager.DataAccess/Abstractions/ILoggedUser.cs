using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface ILoggedUser
    {
        Lawyer GetUser();
        void SetUser(Lawyer user);
    }
}
