using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.IntakeForm
{
    public partial class FindIntake : Form
    {
        public FindIntake()
        {
            InitializeComponent();
        }

        private static FindIntake instance;
        public static FindIntake Instance => instance == null || instance.IsDisposed ? (instance = new FindIntake()) : instance;

        private void SearchBox_Enter(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            this.IntakesGridView.DataSource = Program.DBContext.Intakes.Where(s =>
                s.FileNumber.ToString().Contains(SearchTextBox.Text) ||
                s.Client.FirstName.Contains(SearchTextBox.Text) ||
                s.Client.LastName.Contains(SearchTextBox.Text) ||
                s.Client.Email.Contains(SearchTextBox.Text) ||
                s.MatterType.ToString().Contains(SearchTextBox.Text)
            ).ToList();
        }

        private void IntakesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var intakeId = int.Parse(IntakesGridView?.SelectedRows?[0]?.Cells?["ID"]?.Value.ToString());
            var intake = Program.DBContext.Intakes.FirstOrDefault(s => s.ID == intakeId);
            IntakeForm.Instance.SetIntake(intake);
            Hide();
        }

        private void FindIntake_Load(object sender, EventArgs e)
        {
            IntakesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            IntakesGridView.MultiSelect = false;
            IntakesGridView.ReadOnly = true;
            this.IntakesGridView.DataSource = Program.DBContext.Intakes.ToList();
        }
    }
}
