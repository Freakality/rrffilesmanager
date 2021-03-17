using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.ArchiveControls
{
    public class DocumentFormUserControl : UserControl, IDocumentForm
    {
        public DocumentFormUserControl()
        {
            
        }
        DocumentType DocumentType { get; set; }
        DateTime? DocumentDate { get; set; }
        DateTime? DocumentDateFrom { get; set; }
        DateTime? DocumentDateTo { get; set; }
        //string DocumentExtension { get; set; }
        Control FileNameControl { get; set; }
        public virtual void ClearForm()
        {
        }
        public virtual string GetFileName()
        {
            return GetFileName(DocumentType, DocumentDate, DocumentDateFrom, DocumentDateTo);
        }

        public virtual string GetFileName(DocumentType documentType, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null)
        {
            if(documentDate != null)
                return $"{documentDate:yyyy-MM-dd} - {documentType.Description}";
            return $"{documentDateFrom:yyyy-MM-dd} - {documentDateTo:yyyy-MM-dd} - {documentType.Description}";
        }

        public virtual void SetDocumentParameters(DocumentType documentType, DateTime? documentDate, DateTime? from, DateTime? to)
        {
            DocumentType = documentType;
            DocumentDate = documentDate;
            DocumentDateFrom = from;
            DocumentDateTo = to;
        }

        //public void SetDocumentExtension(string documentExtension)
        //{
        //    DocumentExtension = documentExtension;
        //}

        public void SetFileNameControl(Control control)
        {
            FileNameControl = control;
        }

        public void OnChange()
        {
            FileNameControl.Text = GetFileName();
        }

        public virtual void SetArchive(Archive archive)
        {
        }
    }
}
