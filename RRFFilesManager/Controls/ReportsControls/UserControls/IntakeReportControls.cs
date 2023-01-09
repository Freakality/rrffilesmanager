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


        struct ElnombreQueMeDeLaGana
        {
            int Count;
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
            var qfields = string.Join(", ", FieldsList.Select(x => x));


            //var GroupedInfoList = ReportingInfo
            //    .AsEnumerable()
            //    .AsQueryable()
            //    .GroupBy($"new(" + qfields + ")", "it").Select("new (it as Data, Count() as Count)").ToDynamicList();

            var GroupedInfoList = ReportingInfo
               .AsEnumerable()
               .AsQueryable()
               .GroupBy($"new(" + qfields + ")").Select("new (Key, Count() as Count)").ToDynamicList();
            //.GroupBy($"new(" + qfields + ")").Select(x => new ElnombreQueMeDeLaGana { Count = x.Count()}).ToDynamicList();

            //GroupedInfoList era q. La idea es acceder a las propiedades que estan en index.data.key; pueden ser 1 o varias depediendo
            // de cuantas columnas seleccione el usuario para agrupar la informacion, adelas de 1 que esta cantidad de registros 
            // que seria Count() as Count como esta justo arriba

            #region pruebas
            //var qfirst = q[0];

            //var fieldlist = FieldsList.Select(x => x);
            //foreach (string Field in fieldlist)
            //{
            //    //var dictval = from x in qfirst
            //    //              where x.Data.Key.Contains(Field)
            //    //              select x;

            //    var dictval = q[0].GetType().GetProperty(Field).GetValue(q[0], null);
            //}
            #endregion


            GroupInfo.Rows.Clear();
            GroupInfo.Columns.Clear();

            // aqui agrego las columnas seleccionadas por el usuario a un datatable vacio donde se ira ingresando la informacion
            // luego de acceder a la misma en la lista resultante GroupedInfoList
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
    }
}
