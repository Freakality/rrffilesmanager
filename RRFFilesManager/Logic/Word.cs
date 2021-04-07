using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Logic
{
    public class Word
    {

        public static void ReplaceAll(Document document, string findText, string replaceWith)
        {
            if(string.IsNullOrWhiteSpace(replaceWith))
                document.Content.Find.Execute(FindText: $"^p{findText}", ReplaceWith: replaceWith, Replace: WdReplace.wdReplaceAll);
            document.Content.Find.Execute(FindText: findText, ReplaceWith: replaceWith, Replace: WdReplace.wdReplaceAll);
        }

        public static void FillDocument(Document document, Abstractions.File file)
        {
            ReplaceAll(document, "$$$TodaysDate$$$", DateTime.Now.ToString("MMMM d, yyyy"));
            ReplaceAll(document, "$$$FirstName$$$", file.Client?.FirstName);
            ReplaceAll(document, "$$$LastName$$$", file.Client?.LastName);
            ReplaceAll(document, "$$$Address1$$$", file.Client?.AddressLine1);
            ReplaceAll(document, "$$$Address2$$$", file.Client?.AddressLine2);
            ReplaceAll(document, "$$$City$$$", file.Client?.City);
            ReplaceAll(document, "$$$Province$$$", file.Client?.Province?.Description);
            ReplaceAll(document, "$$$PostalCode$$$", file.Client?.PostalCode);
            ReplaceAll(document, "$$$Salutation$$$", file.Client?.Salutation);
            ReplaceAll(document, "$$$E-mail$$$", file.Client?.Email);
            ReplaceAll(document, "$$$DateOfLoss$$$", file.DateOFLoss.ToString("MMMM d, yyyy"));
            ReplaceAll(document, "$$$FileNumber$$$", file.FileNumber.ToString());
        }
    }
}
