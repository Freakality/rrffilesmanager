using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IClientRepository
    {
        void Insert(Client client);
        void Update(Client client);
        void SoftDelete(int clientId);
        Client GetById(int clientId);
        IEnumerable<Client> List();
        IEnumerable<Client> Search(string searchText);
    }
}
