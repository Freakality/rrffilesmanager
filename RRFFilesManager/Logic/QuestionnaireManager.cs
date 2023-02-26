using ClosedXML.Excel;
using RRFFilesManager.Abstractions;
using RRFFilesManager.Controls.IntakeControls.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Logic
{
    public class QuestionnaireManager
    {
        private readonly IQuestionnaireFieldMapperRepository _questionnaireFieldMapperRepository;
        public QuestionnaireManager()
        {
            _questionnaireFieldMapperRepository = Program.GetService<IQuestionnaireFieldMapperRepository>();
        }

        public List<ImporterItemFieldValue> ImportQuestionnaire(Intake intake)
        {
            OpenFileDialog openTaskDialog = new OpenFileDialog();
            openTaskDialog.Filter = "Excel(*.xlsx;*.xlsm;*.xlsb)|*.xlsx;*.xlsm;*.xlsb";
            var importerItemFieldValues = new List<ImporterItemFieldValue>();
            var fieldMappers = _questionnaireFieldMapperRepository.List();
            try
            {
                if (openTaskDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openTaskDialog.CheckFileExists)
                    {
                        string path = Path.GetFullPath(openTaskDialog.FileName);
                        if (Path.GetExtension(path) == ".xlsb")
                        {
                            path = Excel.ToXLSX(path);
                        }
                        using (ClosedXML.Excel.XLWorkbook workBook = new ClosedXML.Excel.XLWorkbook(path))
                        {
                            foreach (IXLWorksheet sheet in workBook.Worksheets)
                            {
                                //Read the first Sheet from Excel file.
                                IXLWorksheet workSheet = sheet;
                                if (sheet.Name.ToLower() != "output")
                                    continue;
                                //Loop through the Worksheet rows.
                                
                                foreach (IXLRow row in workSheet.Rows())
                                {
                                    ImporterItemFieldValue importerItem = new ImporterItemFieldValue();
                                    var firstCol = true;
                                    //Use the first row to add columns to DataTable.
                                    foreach (IXLCell cell in row.Cells())
                                        if (firstCol)
                                        {
                                            var formFieldName = cell.Value.ToString().Trim();
                                            var mapper = fieldMappers.FirstOrDefault(s => s.FormFieldName == formFieldName);
                                            if (mapper != null)
                                            {
                                                importerItem.Mapper = mapper;
                                            }
                                            else
                                            {
                                                importerItem.Mapper = new QuestionnaireFieldMapper
                                                {
                                                    FormFieldName = formFieldName
                                                };
                                            }
                                            firstCol = false;
                                        } else
                                        {
                                            if (importerItem.Mapper.FileFieldName != null)
                                            {
                                                importerItem.FileValue = Utils.Utils.GetPropValueFromPropertyPath(intake, importerItem.Mapper.FileFieldName);
                                            }
                                            importerItem.FormValue = cell.Value.ToString();
                                        }
                                    if (importerItem != null)
                                        importerItemFieldValues.Add(importerItem);

                                }
                            }
                        }
                        return importerItemFieldValues;
                    }
                }
                else
                {
                    MessageBox.Show("Please upload a valid Excel file.");
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
