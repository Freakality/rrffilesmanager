using RRFFilesManager.Abstractions;
using RRFFilesManager.Controls.IntakeControls.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.IntakeControls
{
    public partial class ImportQuestionnaireFields : Form
    {
        BindingList<ImporterItemRow> Fields = new BindingList<ImporterItemRow>();
        BindingList<ImporterItemRow> OtherFields = new BindingList<ImporterItemRow>();
        private readonly IIntakeRepository _intakeRepository;
        public ImportQuestionnaireFields()
        {
            _intakeRepository = Program.GetService<IIntakeRepository>();
            InitializeComponent();
            fieldsDataGridView.DataSource = Fields;
        }

        public void SetFields(List<ImporterItemFieldValue> fields)
        {
            foreach(var field in fields)
            {
                if (string.IsNullOrWhiteSpace(field.FormValue))
                    continue;
                if (field.Mapper.FileFieldName != null)
                    Fields.Add(new ImporterItemRow(field));
                else
                {
                    OtherFields.Add(new ImporterItemRow(field));
                }
            }
            OtherNotesRTB.Text = String.Join("\n", OtherFields.Select(field => $"{field.questionnaireFieldName}: {field.QuestionnaireValue}"));
        }

        private void fieldsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            var fieldsToImport = Fields.Where(field => field.Import);
            foreach (var field in fieldsToImport)
            {
                var importerItemFieldValue = field.GetImporterItemFieldValue();
                Utils.Utils.SetPropValueFromPropertyPath(Home.IntakeForm.Intake, importerItemFieldValue.Mapper.FileFieldName, field.QuestionnaireValue);
            }
            Home.IntakeForm.Intake.Notes = OtherNotesRTB.Text;
            _intakeRepository.Update(Home.IntakeForm.Intake);
            this.Close();
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            foreach(var field in Fields)
            {
                field.Import = true;
            }
            fieldsDataGridView.Invalidate();
        }

        private void UnselectAllButton_Click(object sender, EventArgs e)
        {
            foreach (var field in Fields)
            {
                field.Import = false;
            }
            fieldsDataGridView.Invalidate();
        }
    }
}
