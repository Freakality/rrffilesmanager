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
    }
}
