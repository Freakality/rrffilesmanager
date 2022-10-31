using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class DocumentGroupRepository : IDocumentGroupRepository
    {
        private readonly DataContext _context;
        public DocumentGroupRepository(DataContext context)
        {
            _context = context;
        }

        public  DocumentGroup GetById(int documentFolderId)
        {
            var documentFolder = _context.DocumentGroups.FirstOrDefault(x => x.ID == documentFolderId);

            return documentFolder;

        }

        public void Insert(DocumentGroup documentFolder)
        {
            _context.DocumentGroups.Add(documentFolder);

            _context.SaveChanges();
        }



        public  IEnumerable<DocumentGroup> List()
        {
            var documentFolders = _context.DocumentGroups.OrderBy(x=>x.Description).ToList();
            return documentFolders;
        }


        public void SoftDelete(int documentFolderId)
        {
            var accountToDelete = _context.DocumentGroups.Find(documentFolderId);

            _context.SaveChanges();

        }

        public void Update(DocumentGroup documentFolder)
        {
            var trxDocumentFolder = GetById(documentFolder.ID);
            _context.Entry(trxDocumentFolder).CurrentValues.SetValues(documentFolder);
            _context.SaveChanges();

        }
    }
}
