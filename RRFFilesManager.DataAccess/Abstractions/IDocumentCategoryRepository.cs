using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IDocumentTypeRepository
    { 
        void Insert(DocumentType documentType);
        void Update(DocumentType documentType);
        void SoftDelete(int documentTypeId);
        DocumentType GetById(int documentTypeId);
        IEnumerable<DocumentType> List();
    }
}
