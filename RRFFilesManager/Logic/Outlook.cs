using ClosedXML.Excel;
using Microsoft.Office.Interop.Outlook;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace RRFFilesManager.Logic
{
    public class Outlook
    {
        public static void NewEmail(string recipentsName, string subject, string body, string[] attachmentsPath = null)
        {
            NewEmail(new[] { recipentsName }, subject, body, attachmentsPath);
        }

        public static bool NewEmail(string[] recipentsName, string subject, string body, string[] attachmentsPath = null)
        {
            try
            {
                
                MailItem OutlookMessage;
                var AppOutlook = new Microsoft.Office.Interop.Outlook.Application();
                OutlookMessage = (MailItem)AppOutlook.CreateItem(OlItemType.olMailItem);
                var Recipents = OutlookMessage.Recipients;
                foreach (var recipent in recipentsName)
                {
                    Recipents.Add(recipent);
                }

                OutlookMessage.Subject = subject;
                OutlookMessage.HTMLBody = body;
                OutlookMessage.BodyFormat = OlBodyFormat.olFormatHTML;
                if (attachmentsPath?.Length > 0)
                {
                    foreach (var attachmentPath in attachmentsPath)
                    {
                        OutlookMessage.Attachments.Add(attachmentPath);
                    }
                }

                OutlookMessage.Display();
            }
            catch(System.Exception e)
            {
                MessageBox.Show("Mail could not be sent");
                return false;
            }
            return true;
        }

        public static void SentExcel()
        {

        }

        public static void Excel(string sheetNombre, DataTable dt, string FileName)
        {
            using (SaveFileDialog sv = new SaveFileDialog())
            {
                sv.FileName = FileName;
                var Wb = new XLWorkbook();
                Wb.Worksheets.Add(dt, sheetNombre.Replace("/", "-"));
                sv.Filter = "Excel Files | *.xlsx";
                if (sv.ShowDialog() == DialogResult.OK)
                {
                    Wb.SaveAs(sv.FileName);
                    MessageBox.Show("Archivo exportado satisfactoriamente");
                }
            }
        }
    }
}
