using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RRFFilesManager.Abstractions
{
    public class QuestionnaireFieldMapper
    {
        public int ID { get; set; }
        public string FormFieldName { get; set; }
        public string FileFieldName { get; set; }

        public override string ToString() => $"{FormFieldName} => {FileFieldName}";
    }
}
