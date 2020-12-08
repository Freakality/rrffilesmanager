using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.DataAccess
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _context;
        public ClientRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Client> GetByIdAsync(int clientId)
        {
            var account = await _context.Clients.FirstOrDefaultAsync(x => x.ID == clientId).ConfigureAwait(false);
            return account;
        }

        public async Task InsertAsync(Client client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Client>> ListAsync()
        {
            return await _context.Clients.ToListAsync().ConfigureAwait(false); ;
        }

        public async Task SoftDelteAsync(int clientId)
        {
            var accountToDelete = await GetByIdAsync(clientId);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Client client)
        {
            var trxClient = await GetByIdAsync(client.ID);
            _context.Entry(trxClient).CurrentValues.SetValues(client);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Client>> SearchAsync(string searchText)
        {
            return await _context.Clients.Where(s =>
                s.FirstName.Contains(searchText) ||
                s.LastName.Contains(searchText) ||
                s.Email.Contains(searchText) ||
                s.ID.ToString().Contains(searchText)
            ).ToListAsync().ConfigureAwait(false);
        }
    }
}
