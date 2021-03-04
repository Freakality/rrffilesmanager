using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.DataAccess.Abstractions
{
    public interface IDocumentGroupRepository
    { 
        void Insert(DocumentGroup documentFolder);
        void Update(DocumentGroup documentFolder);
        void SoftDelete(int documentFolderId);
        DocumentGroup GetById(int documentFolderId);
        IEnumerable<DocumentGroup> List();
    }
}
