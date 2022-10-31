using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess
{
    public class LoggedUser : ILoggedUser
    {
        private readonly DataContext _context;
        public LoggedUser(DataContext context)
        {
            _context = context;
        }
        public void SetUser(Lawyer user)
        {
            _context.User = user;
        }

        public Lawyer GetUser()
        {
            return _context.User;
        }
    }
}
