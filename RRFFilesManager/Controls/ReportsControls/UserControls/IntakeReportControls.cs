using ClosedXML.Excel;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.ReportsControls.UserControls
{
    public partial class IntakeReportControls : UserControl
    {
        private readonly IIntakeRepository _intakeRepository;
        private DataTable ReportingInfo { get; set; }
        private DataTable GroupInfo { get; set; } = new DataTable();

        public IntakeReportControls()
        {
            _intakeRepository = Program.GetService<IIntakeRepository>();
            InitializeComponent();
        }

        private void FindInfoButton_Click(object sender, EventArgs e)
        {
            ReportingInfo = Utils.Utils.ListToDataTable
                (_intakeRepository.SearchInfoForReporting(Dtp_From.Value, Dtp_To.Value).ToList());           
            Dg_Data.DataSource = ReportingInfo;

            SetEditedColumnsName();


            if (Dg_Data.Rows.Count == 0)
            {
                MessageBox.Show("¡There is no information between the selected dates!",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Chl_Columns.Items.Clear();

                foreach (DataGridViewColumn column in Dg_Data.Columns)
                {
                    Chl_Columns.Items.Add(column.HeaderText, false);
                }
            }


        }

        private void SetEditedColumnsName()
        {
            //DateOfCall = x.File.DateOfCall.ToString(),
            //    Interviewer = x.File.StaffInterviewer.Description,
            //    TypeOfMatter = x.File.MatterType.Description,
            //    HowHear = x.File.HowHear.Description,
            //    DateOfLoss = x.File.DateOFLoss.ToString(),
            //    ResponsibleLawyer = x.File.ResponsibleLawyer.Description,
            //    FileLawyer = x.File.FileLawyer.Description,
            //    Status = x.File.CurrentStatus.Description,
            //    LastName = x.File.Client.LastName,
            //    FirstName = x.File.Client.FirstName

            if (Dg_Data.DataSource == null) return;

            if (Dg_Data.Columns["DateOfCall"] != null)
            {
                Dg_Data.Columns["DateOfCall"].HeaderText = "Date of Call";           
            }
            if (Dg_Data.Columns["TypeOfMatter"] != null) Dg_Data.Columns["TypeOfMatter"].HeaderText = "Type of Matter";
            if (Dg_Data.Columns["HowHearAboutUs"]  != null) Dg_Data.Columns["HowHearAboutUs"].HeaderText = "How Hear About Us";
            if (Dg_Data.Columns["DateOfLoss"] != null) Dg_Data.Columns["DateOfLoss"].HeaderText = "Date of Loss";
            if (Dg_Data.Columns["ResponsibleLawyer"] != null) Dg_Data.Columns["ResponsibleLawyer"].HeaderText = "Responsible Lawyer";
            if (Dg_Data.Columns["FileLawyer"] != null) Dg_Data.Columns["FileLawyer"].HeaderText = "File Lawyer";
            if (Dg_Data.Columns["LastName"] != null) Dg_Data.Columns["LastName"].HeaderText = "Last Name";
            if (Dg_Data.Columns["FirstName"] != null) Dg_Data.Columns["FirstName"].HeaderText = "First Name";

        }

        private void GroupByButton_Click(object sender, EventArgs e)
        {
            List<string> FieldsList = new List<string>();
            if (Chl_Columns.CheckedItems.Count == 0)
            {
                MessageBox.Show("¡You must mark at least one field by which to group the information!","Stop",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            for (int i = 0; i < Chl_Columns.CheckedItems.Count; i++)
            {
                FieldsList.Add(Chl_Columns.CheckedItems[i].ToString().Replace(" ","")) ;
            }
            //var qfields = string.Join(", ", FieldsList.Select(x => $"it[\"{x}\"] as " + x));
            var qfields = string.Join(", ", FieldsList.Select(x => x));
         
            var GroupedInfoList = ReportingInfo
               .AsEnumerable()
               .AsQueryable()
               .GroupBy($"new(" + qfields + ")").Select("new (Key, Count() as Count)").ToDynamicList();
                      
            GroupInfo.Rows.Clear();
            GroupInfo.Columns.Clear();
           
            foreach (string field in FieldsList)
            {
                GroupInfo.Columns.Add(field,typeof(string));
            }
            GroupInfo.Columns.Add("Count", typeof(int));

            PropertyInfo[] Props = GroupedInfoList?.FirstOrDefault().Key?.GetType().GetProperties() ?? new PropertyInfo[] { };

            foreach (dynamic item in GroupedInfoList)
            {
                GroupInfo.Rows.Add();
                for (int i = 0; i < Props.Length -1; i++)
                {

                    GroupInfo.Rows[GroupInfo.Rows.Count - 1][$"{Props[i].Name}"] = item.Key.GetType().GetProperty(Props[i].Name).GetValue(item.Key, null).ToString();                    
                }
                GroupInfo.Rows[GroupInfo.Rows.Count - 1][$"Count"] = item.Count.ToString();

            }

            Dg_Data.DataSource = null;
            Dg_Data.DataSource = GroupInfo;
            SetEditedColumnsName();

        }

        private void ExcelExportButton_Click(object sender, EventArgs e)
        {
            if (Dg_Data.DataSource == null) 
            {
                MessageBox.Show($"¡There is no information to export!","Stop",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                return;
            }
            var wb = new XLWorkbook();
            //DataTable DtExport = (DataTable)Dg_Data.DataSource;            
            wb.Worksheets.Add((DataTable)Dg_Data.DataSource,"IntakeReport");
            foreach (IXLWorksheet sheet in wb.Worksheets)
            {
                sheet.Columns().AdjustToContents();
            }
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.FileName = "";
                saveFileDialog.Filter = "Excel Files | *.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("¡successful export!", "Succes",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Utils.Utils.OpenMicrosoftExcel(saveFileDialog.FileName);
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Dg_Data.DataSource = null;
            Chl_Columns.Items.Clear();
        }
    }
}
