using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess
{
    public class DocumentTypeRepository : IDocumentTypeRepository
    {
        private readonly DataContext _context;
        public DocumentTypeRepository(DataContext context)
        {
            _context = context;
        }

        public  DocumentType GetById(int documentTypeId)
        {
            var documentType = _context.DocumentTypes.FirstOrDefault(x => x.ID == documentTypeId);

            return documentType;

        }

        public void Insert(DocumentType documentType)
        {
            _context.DocumentTypes.Add(documentType);

            _context.SaveChanges();
        }



        public  IEnumerable<DocumentType> List()
        {
            var documentTypes = _context.DocumentTypes.ToList();
            return documentTypes;
        }


        public void SoftDelete(int documentTypeId)
        {
            var accountToDelete = _context.DocumentTypes.Find(documentTypeId);

            _context.SaveChanges();

        }

        public void Update(DocumentType documentType)
        {
            var trxDocumentType = GetById(documentType.ID);
            _context.Entry(trxDocumentType).CurrentValues.SetValues(documentType);
            _context.SaveChanges();

        }
    }
}
