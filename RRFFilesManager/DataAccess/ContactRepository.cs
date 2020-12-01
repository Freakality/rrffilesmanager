using RRFFilesManager.Abstractions;
using RRFFilesManager.Abstractions.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.DataAccess
{
    public class ContactRepository : IContactRepository
    {
        private readonly DataContext _context;
        public ContactRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Contact> GetByIdAsync(int contactId)
        {
            var account = await _context.Contacts.FirstOrDefaultAsync(x => x.ID == contactId).ConfigureAwait(false);
            return account;
        }

        public async Task InsertAsync(Contact contact)
        {
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<Contact>> ListAsync()
        {
            return await _context.Contacts.ToListAsync().ConfigureAwait(false); ;
        }

        public async Task SoftDelteAsync(int contactId)
        {
            var accountToDelete = await GetByIdAsync(contactId);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Contact contact)
        {
            var trxContact = await GetByIdAsync(contact.ID);
            _context.Entry(trxContact).CurrentValues.SetValues(contact);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<Contact>> SearchAsync(string searchText, int? take = null)
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
            return await query.ToListAsync().ConfigureAwait(false);
        }
    }
}
