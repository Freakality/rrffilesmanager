using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IClientRepository
    {
        Task InsertAsync(Client client);
        Task UpdateAsync(Client client);
        Task SoftDelteAsync(int clientId);
        Task<Client> GetByIdAsync(int clientId);
        Task<IEnumerable<Client>> ListAsync();
        Task<IEnumerable<Client>> SearchAsync(string searchText);
    }
}
