﻿using RRFFilesManager.Abstractions;
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

        public override void FillArchiveInfo(Archive archive)
        {
            archive.Sender = Sender.Text;
            archive.Recipient = Recipient.Text;
            archive.AdditionalInfo = AdditionalInfo.Text;
        }

        public override string GetFileName(string text, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, DocumentNameTypeEnum documentNameType = default)
        {
            var filename = $"{base.GetFileName(text, documentDate, documentDateFrom, documentDateTo, documentNameType)} - From {Sender.Text} - To {Recipient.Text}";
            if (!string.IsNullOrWhiteSpace(AdditionalInfo.Text))
                filename += $" - {AdditionalInfo.Text}";
            return filename;
        }

        private void AdditionalInfo_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void Sender_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void Recipient_TextChanged(object sender, EventArgs e)
        {
            OnChange();
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
