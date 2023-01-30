using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IClientNoteRepository
    {
        void Insert(ClientNote clientNote, File file);
        void Update(ClientNote clientNote);
        void SoftDelete(int clientNoteId);
        ClientNote GetById(int clientNoteId);
        IEnumerable<ClientNote> List();
        IEnumerable<ClientNote> Search(File file, DateTime date1, DateTime date2, int? take = null);
    }
}
