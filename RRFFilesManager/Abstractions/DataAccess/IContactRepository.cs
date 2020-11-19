using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Abstractions.DataAccess
{
    public interface IContactRepository
    {
        Task InsertAsync(Contact contact);
        Task UpdateAsync(Contact contact);
        Task SoftDelteAsync(int contactId);
        Task<Contact> GetByIdAsync(int contactId);
        Task<IEnumerable<Contact>> ListAsync();
        Task<IEnumerable<Contact>> SearchAsync(string searchText, int? take = null);
    }
}
