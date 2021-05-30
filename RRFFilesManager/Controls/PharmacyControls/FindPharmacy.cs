using RRFFilesManager.Abstractions;
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

namespace RRFFilesManager.Controls.PharmacyControls
{
    public partial class FindPharmacy : Form
    {
        private readonly IPharmacyRepository _pharmacyRepository;
        public FindPharmacy()
        {
            _pharmacyRepository = Program.GetService<IPharmacyRepository>();
            InitializeComponent();
        }
        private static FindPharmacy instance;
        public static FindPharmacy Instance => instance == null || instance.IsDisposed ? (instance = new FindPharmacy()) : instance;
        public Pharmacy Selected { get; set; }
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            this.GridView.DataSource = _pharmacyRepository.Search(SearchTextBox.Text);
        }

        private void FindPharmacy_Load(object sender, EventArgs e)
        {
            GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView.MultiSelect = false;
            GridView.ReadOnly = true;
            GridView.DataSource = _pharmacyRepository.Search(SearchTextBox.Text);
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = int.Parse(GridView?.SelectedRows?[0]?.Cells?["ID"]?.Value.ToString());
            var selected = _pharmacyRepository.GetById(id);
            this.Selected = selected;
            Close();
        }
    }
}
