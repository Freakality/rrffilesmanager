using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IDocumentCategoryRepository
    { 
        void Insert(DocumentCategory documentType);
        void Update(DocumentCategory documentType);
        void SoftDelete(int documentTypeId);
        DocumentCategory GetById(int documentTypeId);
        IEnumerable<DocumentCategory> List();
    }
}
