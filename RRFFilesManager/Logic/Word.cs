using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Logic
{
    public class Word
    {

        public static void ReplaceAll(Document document, string findText, string replaceWith)
        {
            document.Content.Find.Execute(FindText: findText, ReplaceWith: replaceWith, Replace: WdReplace.wdReplaceAll);
        }
    }
}
