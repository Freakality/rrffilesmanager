﻿using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
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
            ReportingInfo.Columns.Add("Quantity", typeof(int));
            foreach (DataRow row in ReportingInfo.Rows)
            {
                row["Quantity"] = 1;
            }
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
                MessageBox.Show("You have to check some columns to group the information");
                return;
            }


            for (int i = 0; i < Chl_Columns.CheckedItems.Count; i++)
            {
                FieldsList.Add(Chl_Columns.CheckedItems[i].ToString()) ;
            }

            //var qfields = string.Join(", ", FieldsList.Select(x => $"it[\"{x}\"] as " + x));
            var qfields = string.Join(", ", FieldsList);


            var q = ReportingInfo
                .AsEnumerable()
                .AsQueryable()
                .GroupBy($"new({qfields})", "it")
                .Select("new (it as Data, Count() as Count)").ToDynamicList();
                //.Select("new (it as Data, Count() as Count)").ToDynamicList();

            GroupInfo.Rows.Clear();
            GroupInfo.Columns.Clear();          
            foreach (string field in FieldsList)
            {
                GroupInfo.Columns.Add(field,typeof(string));
            }
            GroupInfo.Columns.Add("Count", typeof(int));
            
            foreach (dynamic item in q)
            {
                GroupInfo.Rows.Add(item.Data, item.Count);
                //foreach (DataRow row in item.Data)
                //{
                //    GroupInfo.Rows.Add(campos, item.Count);
                //}
            }

        }
    }
}
