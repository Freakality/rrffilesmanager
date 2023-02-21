﻿using ClosedXML.Excel;
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
            if (Dg_Data.Rows.Count == 0)
            {
                MessageBox.Show("¡There is no information between the selected dates!",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Chl_Columns.Items.Clear();

                foreach (DataColumn column in ReportingInfo.Columns)
                {
                    Chl_Columns.Items.Add(column.ColumnName, false);
                }
            }


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
                FieldsList.Add(Chl_Columns.CheckedItems[i].ToString()) ;
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
