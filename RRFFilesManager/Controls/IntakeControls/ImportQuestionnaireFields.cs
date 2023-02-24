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
        public ImportQuestionnaireFields()
        {
            InitializeComponent();
        }

        public void SetFieldsDataGridViewDataSource(DataTable dt)
        {
            fieldsDataGridView.DataSource = dt;
        }

        private void fieldsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
