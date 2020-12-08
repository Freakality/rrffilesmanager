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
    public class FileRepository : IFileRepository
    {
        private readonly DataContext _context;
        public FileRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<File> GetByIdAsync(int fileId)
        {
            var account = await _context.Files.FirstOrDefaultAsync(x => x.ID == fileId).ConfigureAwait(false);
            return account;
        }

        public async Task InsertAsync(File file)
        {
            _context.Files.Add(file);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<File>> ListAsync()
        {
            return await _context.Files.ToListAsync().ConfigureAwait(false); ;
        }

        public async Task SoftDelteAsync(int fileId)
        {
            var accountToDelete = await GetByIdAsync(fileId);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(File file)
        {
            var trxFile = await GetByIdAsync(file.ID);
            _context.Entry(trxFile).CurrentValues.SetValues(file);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<File>> SearchAsync(string searchText, bool? hold = null, int? take = null)
        {
            var query = _context.Files.Where(s =>
                s.FileNumber.ToString().Contains(searchText) ||
                s.Client.FirstName.Contains(searchText) ||
                s.Client.LastName.Contains(searchText) ||
                s.Client.Email.Contains(searchText) ||
                s.MatterType.Description.Contains(searchText)
            );

            if (take != null)
                query = query.Take(take.Value);

            return await query.ToListAsync().ConfigureAwait(false);
        }

        public async Task<File> GetLastFileAsync(int? clientId = null)
        {
            var query = _context.Files.OrderByDescending(s => s.ID);
            if (clientId != null)
                query = (IOrderedQueryable<File>)query.Where(s => s.Client != null && s.Client.ID == clientId.Value);
            return await query.FirstOrDefaultAsync().ConfigureAwait(false);
        }

        
    }
}
