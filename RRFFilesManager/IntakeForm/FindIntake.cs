using RRFFilesManager.Abstractions.DataAccess;
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
        private readonly IIntakeRepository _intakeRepository;
        public FindIntake()
        {
            _intakeRepository = (IIntakeRepository)Program.ServiceProvider.GetService(typeof(IIntakeRepository));
            InitializeComponent();
        }

        private static FindIntake instance;
        public static FindIntake Instance => instance == null || instance.IsDisposed ? (instance = new FindIntake()) : instance;

        private void SearchBox_Enter(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            this.IntakesGridView.DataSource = _intakeRepository.SearchAsync(SearchTextBox.Text)?.Result;
        }

        private void IntakesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FindIntake_Load(object sender, EventArgs e)
        {
            IntakesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            IntakesGridView.MultiSelect = false;
            IntakesGridView.ReadOnly = true;
            this.IntakesGridView.DataSource = _intakeRepository.SearchAsync(SearchTextBox.Text)?.Result;
            IntakesGridView.Columns["ID"].Visible = false;
        }

        private void IntakesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var intakeId = int.Parse(IntakesGridView?.SelectedRows?[0]?.Cells?["ID"]?.Value.ToString());
            var intake = _intakeRepository.GetByIdAsync(intakeId)?.Result;
            Home.IntakeForm.SetIntake(intake);
            Close();
        }
    }
}
