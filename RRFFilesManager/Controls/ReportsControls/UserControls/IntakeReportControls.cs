using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RRFFilesManager.Controls.ReportsControls.UserControls
{    
    public partial class IntakeReportControls : UserControl
    {
        private readonly IIntakeRepository _intakeRepository;
        private DataTable ReportingInfo { get; set; }
        
        public IntakeReportControls()
        {
            _intakeRepository = Program.GetService<IIntakeRepository>();
            InitializeComponent();
        }

        private void FindInfoButton_Click(object sender, EventArgs e)
        {
            ReportingInfo = Utils.Utils.ListToDataTable
                (_intakeRepository.SearchInfoForReporting(Dtp_From.Value,Dtp_To.Value).ToList());
            Dg_Data.DataSource = ReportingInfo;
            if (Dg_Data.Rows.Count == 0) MessageBox.Show("¡There is no information between the selected dates!",
                "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }
    }
}
