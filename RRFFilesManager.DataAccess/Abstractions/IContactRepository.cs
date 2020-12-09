using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IContactRepository
    {
        void Insert(Contact contact);
        void Update(Contact contact);
        void SoftDelete(int contactId);
        Contact GetById(int contactId);
        IEnumerable<Contact> List();
        IEnumerable<Contact> Search(string searchText, int? take = null);
    }
}
