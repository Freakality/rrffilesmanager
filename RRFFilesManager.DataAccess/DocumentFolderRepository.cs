using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class DocumentFolderRepository : IDocumentFolderRepository
    {
        private readonly DataContext _context;
        public DocumentFolderRepository(DataContext context)
        {
            _context = context;
        }

        public  DocumentFolder GetById(int documentFolderId)
        {
            var documentFolder = _context.DocumentFolders.FirstOrDefault(x => x.ID == documentFolderId);

            return documentFolder;

        }

        public void Insert(DocumentFolder documentFolder)
        {
            _context.DocumentFolders.Add(documentFolder);

            _context.SaveChanges();
        }



        public  IEnumerable<DocumentFolder> List()
        {
            var documentFolders = _context.DocumentFolders.ToList();
            return documentFolders;
        }


        public void SoftDelete(int documentFolderId)
        {
            var accountToDelete = _context.DocumentFolders.Find(documentFolderId);

            _context.SaveChanges();

        }

        public void Update(DocumentFolder documentFolder)
        {
            var trxDocumentFolder = GetById(documentFolder.ID);
            _context.Entry(trxDocumentFolder).CurrentValues.SetValues(documentFolder);
            _context.SaveChanges();

        }
    }
}
