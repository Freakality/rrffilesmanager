using Microsoft.EntityFrameworkCore;
using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _context;
        public ClientRepository(DataContext context)
        {
            _context = context;
        }

        public Client GetById(int clientId)
        {
            var account = _context.Clients.FirstOrDefault(x => x.ID == clientId);
            return account;
        }

        public void Insert(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public IEnumerable<Client> List()
        {
            return _context.Clients.ToList(); ;
        }

        public void SoftDelete(int clientId)
        {
            var accountToDelete = GetById(clientId);
            _context.SaveChanges();
        }

        public void Update(Client client)
        {
            var trxClient = GetById(client.ID);
            _context.Entry(trxClient).CurrentValues.SetValues(client);
            _context.SaveChanges();
        }

        public IEnumerable<Client> Search(string searchText)
        {
            return _context.Clients.Where(s =>
                s.FirstName.Contains(searchText) ||
                s.LastName.Contains(searchText) ||
                s.Email.Contains(searchText) ||
                s.ID.ToString().Contains(searchText)
            ).ToList();
        }
    }
}
