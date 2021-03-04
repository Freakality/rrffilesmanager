using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.ArchiveControls
{
    public partial class SenderRecipientUserControl : DocumentFormUserControl
    {
        public SenderRecipientUserControl()
        {
            InitializeComponent();
        }

        public override void ClearForm()
        {
            Sender.ResetText();
            Recipient.ResetText();
            AdditionalInfo.ResetText();
        }

        public override void SetArchive(Archive archive)
        {
            archive.Sender = Sender.Text;
            archive.Recipient = Recipient.Text;
            archive.AdditionalInfo = AdditionalInfo.Text;
        }

        public override string GetFileName(DocumentType documentType, DateTime documentDate)
        {
            return $"{documentDate:yyyy-MM-dd} - {documentType.Description} - From {Sender} - To {Recipient}";
        }

        private void AdditionalInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sender_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void Recipient_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }
    }
}
