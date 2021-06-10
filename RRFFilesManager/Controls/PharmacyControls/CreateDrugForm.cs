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
    public partial class CreateDrugForm : Form
    {
        public Drug Value { get; set; }
        private readonly IDrugRepository _drugRepository;
        public CreateDrugForm()
        {
            _drugRepository = Program.GetService<IDrugRepository>();
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!Validate())
                return;
            UpsertEntity();
            Close();
        }

        public new bool Validate()
        {
            if (string.IsNullOrEmpty(NameTB.Text))
            {
                MessageBox.Show("Please enter Name");
                return false;
            }
            return true;
        }

        public void UpsertEntity()
        {
            if (Value == null)
                Value = new Drug();
            FillEntity(Value);
            if (Value.ID == default)
                _drugRepository.Insert(Value);
            else
                _drugRepository.Update(Value);
        }
        public void FillEntity(Drug drug)
        {
            drug.DIN = DINTB.Text;
            drug.Name = NameTB.Text;
            drug.Schedule = ScheduleTB.Text;
            drug.ActiveIngredients = ActiveIngredientsTB.Text;
            drug.Strength = StrengthTB.Text;
        }
    }
}
