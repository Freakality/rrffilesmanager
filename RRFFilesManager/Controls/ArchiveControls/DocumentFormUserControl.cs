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
        DocumentNameTypeEnum DocumentNameType { get; set; }
        //string DocumentExtension { get; set; }
        Control FileNameControl { get; set; }
        public virtual void ClearForm()
        {
        }
        public virtual string GetFileName()
        {
            return GetFileName(DocumentType, DocumentDate, DocumentDateFrom, DocumentDateTo, DocumentNameType);
        }

        public virtual string GetFileNameDatePart(DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null)
        {
            string datePart;
            if (documentDate != null)
                datePart = $"{documentDate:yyyy-MM-dd}";
            else
                datePart = $"{documentDateFrom:yyyy-MM-dd} - {documentDateTo:yyyy-MM-dd}";
            return datePart;
        }

        public virtual string GetFileName(DocumentType documentType, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, DocumentNameTypeEnum documentNameType = default)
        {
            var datePart = GetFileNameDatePart(documentDate, documentDateFrom, documentDateTo);
            if(documentNameType == DocumentNameTypeEnum.FirstDate)
                return $"{datePart} - {documentType.Description}";
            return $"{documentType.Description} - {datePart}";
        }

        public virtual void SetDocumentParameters(DocumentType documentType, DateTime? documentDate, DateTime? from, DateTime? to, DocumentNameTypeEnum documentNameType = default)
        {
            DocumentType = documentType;
            DocumentDate = documentDate;
            DocumentDateFrom = from;
            DocumentDateTo = to;
            DocumentNameType = documentNameType;
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

        public virtual void FillArchiveInfo(Archive archive)
        {
        }
    }
}
