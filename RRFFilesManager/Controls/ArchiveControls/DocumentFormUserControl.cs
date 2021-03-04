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
        DateTime DocumentDate { get; set; }
        //string DocumentExtension { get; set; }
        Control FileNameControl { get; set; }
        public virtual void ClearForm()
        {
        }
        public virtual string GetFileName()
        {
            return GetFileName(DocumentType, DocumentDate);
        }

        public virtual string GetFileName(DocumentType documentType, DateTime documentDate)
        {
            return $"{documentDate:yyyy-MM-dd} - {documentType.Description}";
        }

        public virtual void SetDocumentType(DocumentType documentType)
        {
            DocumentType = documentType;
        }
        public virtual void SetDocumentDate(DateTime documentDate)
        {
            DocumentDate = documentDate;
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
