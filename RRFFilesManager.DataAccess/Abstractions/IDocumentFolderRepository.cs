using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IDocumentFolderRepository
    { 
        void Insert(DocumentFolder documentFolder);
        void Update(DocumentFolder documentFolder);
        void SoftDelete(int documentFolderId);
        DocumentFolder GetById(int documentFolderId);
        IEnumerable<DocumentFolder> List();
    }
}
