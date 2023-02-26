using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Controls.IntakeControls.Abstractions
{
    public class ImporterItemFieldValue
    {
        public QuestionnaireFieldMapper Mapper { get; set; }
        public string FormValue { get; set; }
        public object FileValue { get; set; }
    }
}

