using ClosedXML.Excel;
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

        public DataTable Import()
        {
            OpenFileDialog openTaskDialog = new OpenFileDialog();
            DataTable dt = new DataTable();
            openTaskDialog.Filter = "Excel(*.xlsx;*.xlsm;*.xlsb)|*.xlsx;*.xlsm;*.xlsb";
            try
            {
                if (openTaskDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openTaskDialog.CheckFileExists)
                    {
                        string path = Path.GetFullPath(openTaskDialog.FileName);
                        if (path.Contains("xlsb"))
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
                                //Create a new DataTable.
                                dt.TableName = sheet.Name;
                                //Loop through the Worksheet rows.
                                bool firstCol = true;
                                //bool firstRowF = true;
                                //bool firstRowV = true;
                                foreach (IXLRow row in workSheet.Rows())
                                {
                                    //Use the first row to add columns to DataTable.
                                    if (firstCol)
                                    {
                                        foreach (IXLCell cell in row.Cells())
                                        {
                                            /*if (firstRowF)
                                            {
                                                firstRowF = false;
                                                continue;
                                            }*/
                                            dt.Columns.Add(cell.Value.ToString());
                                        }
                                        firstCol = false;
                                        continue;
                                    }
                                    else
                                    {
                                        dt.Rows.Add();
                                        int i = 0;
                                        foreach (IXLCell cell in row.Cells(1, dt.Columns.Count))
                                        {
                                            /*if (firstRowV)
                                            {
                                                firstRowV = false;
                                                continue;
                                            }*/
                                            dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
                                            i++;
                                            if (i > 1)
                                                break;
                                        }
                                    }
                                }
                                break;
                            }
                        }
                        return dt;
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
