using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IFileRepository
    {
        Task InsertAsync(File file);
        Task UpdateAsync(File file);
        Task SoftDelteAsync(int fileId);
        Task<File> GetByIdAsync(int fileId);
        Task<IEnumerable<File>> ListAsync();
        Task<IEnumerable<File>> SearchAsync(string searchText, bool? hold = null, int? take = null);
        Task<File> GetLastFileAsync(int? clientId = null);
    }
}
