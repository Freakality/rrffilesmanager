using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using RRFFilesManager.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.TemplateControls
{
    public partial class FindTemplate : Form
    {
        private readonly ITemplateRepository _templateRepository;
        private readonly IMatterTypeRepository _matterTypeRepository;

        public FindTemplate()
        {
            _templateRepository = Program.GetService<ITemplateRepository>();
            _matterTypeRepository = Program.GetService<IMatterTypeRepository>();
            InitializeComponent();
            Initialize();
        }

        private static FindTemplate instance;
        public static FindTemplate Instance => instance == null || instance.IsDisposed ? (instance = new FindTemplate()) : instance;
        public Template SelectedTemplate { get; set; }

        private void Initialize()
        {
            Utils.Utils.SetComboBoxDataSource(MatterTypeComboBox, _matterTypeRepository.List());
            Utils.Utils.SetComboBoxDataSource(CategoryCombobox, _templateRepository.GetCategories());
            Utils.Utils.SetComboBoxDataSource(TypeOfTemplateComboBox, _templateRepository.GetTypesOfTemplate());
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchBox_Enter(object sender, EventArgs e)
        {

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshGridViewDataSource();
        }

        private void FindTemplate_Load(object sender, EventArgs e)
        {
            GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridView.MultiSelect = false;
            GridView.ReadOnly = true;
            RefreshGridViewDataSource();
            GridView.Columns["ID"].Visible = false;
        }

        private void RefreshGridViewDataSource()
        {
            var matterType = (MatterType)MatterTypeComboBox.SelectedItem;
            var category = (string)CategoryCombobox.SelectedItem;
            var typeOfTemplate = (string)TypeOfTemplateComboBox.SelectedItem;
            GridView.DataSource = _templateRepository.Search(SearchTextBox.Text, matterType, category, typeOfTemplate, 10);
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var entityId = int.Parse(GridView?.SelectedRows?[0]?.Cells?["ID"]?.Value.ToString());
            var entity = _templateRepository.GetById(entityId);
            SelectedTemplate = entity;
            Close();
        }

        private void MatterTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGridViewDataSource();
        }

        private void CategoryCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGridViewDataSource();
        }

        private void TypeOfTemplateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGridViewDataSource();
        }
    }
}
