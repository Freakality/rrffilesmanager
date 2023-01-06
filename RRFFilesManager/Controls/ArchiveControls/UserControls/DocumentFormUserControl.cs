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
        string Text { get; set; }
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
            return GetFileName(Text, DocumentDate, DocumentDateFrom, DocumentDateTo, DocumentNameType);
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

        public virtual string GetFileName(string text, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, DocumentNameTypeEnum documentNameType = default)
        {
            var datePart = GetFileNameDatePart(documentDate, documentDateFrom, documentDateTo);
            //if(documentNameType == DocumentNameTypeEnum.FirstDate)
                return $"{datePart} {text}";
            //return $"{text} - {datePart}";
        }

        public virtual void SetDocumentParameters(string text, DateTime? documentDate, DateTime? from, DateTime? to, DocumentNameTypeEnum documentNameType = default)
        {
            Text = text;
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

        public virtual void FillAdditionalArchiveInfo(Archive archive)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // DocumentFormUserControl
            // 
            this.Name = "DocumentFormUserControl";
            this.Load += new System.EventHandler(this.DocumentFormUserControl_Load);
            this.ResumeLayout(false);

        }

        private void DocumentFormUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
