using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Logic
{
    public class Excel
    {
        public static void ReplaceAll(Worksheet worksheet, string findText, string replaceWith)
        {
            worksheet.Cells.Replace(findText, replaceWith);
        }
        public static void ReplaceAll(Worksheet worksheet, string findText, bool replaceWith)
        {
            worksheet.Cells.Replace(findText, replaceWith ? "Yes" : "No");
        }
        public static void ReplaceAll(Worksheet worksheet, string findText, DateTime? replaceWith)
        {
            worksheet.Cells.Replace(findText, replaceWith?.ToString("MMMM d, yyyy"));
        }
        public static void ReplaceAll(Worksheet worksheet, string findText, int replaceWith)
        {
            worksheet.Cells.Replace(findText, replaceWith.ToString());
        }
    }
}
