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
        private readonly bool CanEdit;
        public FindCompany(bool canCreate = false, bool canEdit = true)
        {
            _companyRepository = Program.GetService<ICompanyRepository>();
            InitializeComponent();
            GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView.MultiSelect = false;
            GridView.ReadOnly = true;
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = "Edit";
            editButtonColumn.Text = "Edit";
            editButtonColumn.UseColumnTextForButtonValue = true;
            int columnIndex = 0;
            if (GridView.Columns["Edit"] == null)
            {
                GridView.Columns.Insert(columnIndex, editButtonColumn);
            }

            GridView.DataSource = _companyRepository.Search(SearchTextBox.Text, 50);
            CanEdit = canEdit;
            CreateCompanyButton.Visible = canCreate;
            if (!canCreate)
                TableLayoutPanel.ColumnCount = 1;
        }

        public Company Selected { get; set; }

        public CompanyInfo CompanyInfo { get; set; }

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
                if (e.ColumnIndex == GridView.Columns["Edit"].Index)
                {
                    OpenCompanyInfo();
                    return;
                }
            }
            Close();
        }

        private void CreateCompanyButton_Click(object sender, EventArgs e)
        {
            OpenCompanyInfo();
        }

        private void OpenCompanyInfo()
        {
            CompanyInfo = new CompanyInfo(Selected);
            CompanyInfo.Show();
            CompanyInfo.FormClosing += new FormClosingEventHandler(this.CompanyInfo_FormClosing);
        }

        private void CompanyInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            var companyInfo = sender as CompanyInfo;
            if(companyInfo.Company.ID != default)
            {
                Selected = companyInfo.Company;
                Close();
            }
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
