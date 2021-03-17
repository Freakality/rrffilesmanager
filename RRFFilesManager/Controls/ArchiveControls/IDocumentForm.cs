using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Controls.ArchiveControls
{
    public interface IDocumentForm
    {
        void SetArchive(Archive archive);
        void ClearForm();
        string GetFileName(DocumentType documentType, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null);
    }
}
