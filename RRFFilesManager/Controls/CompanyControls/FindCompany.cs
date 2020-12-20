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

namespace RRFFilesManager.Controls.CompanyControls
{
    public partial class FindCompany : Form
    {
        private readonly ICompanyRepository _companyRepository;
        public FindCompany()
        {
            _companyRepository = Program.GetService<ICompanyRepository>();
            InitializeComponent();
            GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView.MultiSelect = false;
            GridView.ReadOnly = true;
            GridView.DataSource = _companyRepository.Search(SearchTextBox.Text, 50);
        }

        private static FindCompany instance;
        public static FindCompany Instance => instance == null || instance.IsDisposed ? (instance = new FindCompany()) : instance;
        public Company Selected { get; set; }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            GridView.DataSource = _companyRepository.Search(SearchTextBox.Text, 50);
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRows = GridView?.SelectedRows;
            if (selectedRows?.Count > 0)
            {
                var id = int.Parse(selectedRows?[0]?.Cells?["ID"]?.Value.ToString());
                Selected = _companyRepository.GetById(id);
            }
            Close();
        }
    }
}
