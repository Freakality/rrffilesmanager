using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class DocumentCategoryRepository : IDocumentCategoryRepository
    {
        private readonly DataContext _context;
        public DocumentCategoryRepository(DataContext context)
        {
            _context = context;
        }

        public  DocumentCategory GetById(int documentTypeId)
        {
            var documentType = _context.DocumentCategories.FirstOrDefault(x => x.ID == documentTypeId);

            return documentType;

        }

        public void Insert(DocumentCategory documentType)
        {
            _context.DocumentCategories.Add(documentType);

            _context.SaveChanges();
        }



        public  IEnumerable<DocumentCategory> List()
        {
            var documentTypes = _context.DocumentCategories.ToList();
            return documentTypes;
        }


        public void SoftDelete(int documentTypeId)
        {
            var accountToDelete = _context.DocumentCategories.Find(documentTypeId);

            _context.SaveChanges();

        }

        public void Update(DocumentCategory documentType)
        {
            var trxDocumentType = GetById(documentType.ID);
            _context.Entry(trxDocumentType).CurrentValues.SetValues(documentType);
            _context.SaveChanges();

        }
    }
}
