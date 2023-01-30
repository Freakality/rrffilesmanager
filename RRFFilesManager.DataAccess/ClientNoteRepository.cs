using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess
{
    public class ClientNoteRepository : IClientNoteRepository
    {
        private readonly DataContext _context;
        public ClientNoteRepository(DataContext context)
        {
            _context = context;
        }

        public ClientNote GetById(int clientNoteId)
        {
            var account = _context.ClientNotes.FirstOrDefault(x => x.ID == clientNoteId);
            return account;
        }

        public void Insert(ClientNote clientNote, File file)
        {
            clientNote.File = file;
            _context.ClientNotes.Add(clientNote);
            _context.SaveChanges();
        }

        public IEnumerable<ClientNote> List()
        {
            return _context.ClientNotes.ToList(); ;
        }

        public void SoftDelete(int clientNoteId)
        {
            var accountToDelete = GetById(clientNoteId);
            _context.SaveChanges();
        }

        public void Update(ClientNote clientNote)
        {
            var trxFile = GetById(clientNote.ID);
            _context.Entry(trxFile).CurrentValues.SetValues(clientNote);
            _context.SaveChanges();
        }

        public IEnumerable<ClientNote> Search(File file, DateTime date1, DateTime date2, int? take = null)
        {
            var query = _context.ClientNotes.Where(s =>
                s.File.ID == file.ID &&
                s.Date >= date1 &&
                s.Date <= date2
            );

            if (take != null)
                query = query.Take(take.Value);

            return query.ToList();
        }
    }
}
