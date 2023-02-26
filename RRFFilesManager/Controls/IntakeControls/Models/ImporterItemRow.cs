using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Controls.IntakeControls.Abstractions
{
    public class ImporterItemRow
    {
        private ImporterItemFieldValue importerItemFieldValue;
        public ImporterItemRow(ImporterItemFieldValue importerItemFieldValue)
        {
            questionnaireFieldName = importerItemFieldValue.Mapper.FormFieldName;
            QuestionnaireValue = importerItemFieldValue.FormValue;
            currentFileValue = importerItemFieldValue.FileValue;
            this.importerItemFieldValue = importerItemFieldValue;
        }
        public bool Import { get; set; }
        public string questionnaireFieldName;
        public object QuestionnaireFieldName { get => questionnaireFieldName; }
        public object QuestionnaireValue { get; set; }
        public readonly object currentFileValue;
        public object CurrentFileValue { get => currentFileValue; }
        public ImporterItemFieldValue GetImporterItemFieldValue() => this.importerItemFieldValue;
    }
}

