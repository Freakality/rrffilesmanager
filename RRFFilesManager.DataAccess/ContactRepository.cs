using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class ContactRepository : IContactRepository
    {
        private readonly DataContext _context;
        public ContactRepository(DataContext context)
        {
            _context = context;
        }

        public  Contact GetById(int contactId)
        {
            var account = _context.Contacts.FirstOrDefault(x => x.ID == contactId);
            return account;
        }

        public void Insert(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }

        public  IEnumerable<Contact> List()
        {
            return _context.Contacts.ToList(); ;
        }

        public void SoftDelete(int contactId)
        {
            var accountToDelete = GetById(contactId);
            _context.SaveChanges();
        }

        public void Update(Contact contact)
        {
            var trxContact = GetById(contact.ID);
            _context.Entry(trxContact).CurrentValues.SetValues(contact);
            _context.SaveChanges();
        }

        public  IEnumerable<Contact> Search(string searchText, int? take = null)
        {
            var query = _context.Contacts.Where(s =>
                s.FirstName.Contains(searchText) ||
                s.LastName.Contains(searchText) ||
                s.Email.Contains(searchText) ||
                s.ID.ToString().Contains(searchText)
            );
            if(take != null)
            {
                query = query.Take(take.Value);
            }
            return query.ToList();
        }
    }
}
