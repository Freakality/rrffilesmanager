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
    public partial class PharmacyTextBoxControl : TextBox
    {
        public Pharmacy Pharmacy { get; set; }
        private IPharmacyRepository _pharmacyRepository { get; set; }
        private AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
        private IEnumerable<Pharmacy> Items { get; set; }
        public PharmacyTextBoxControl()
        {
            _pharmacyRepository = Program.GetService<IPharmacyRepository>();
            InitializeComponent();
            AutoCompleteMode = AutoCompleteMode.Suggest;
            AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteCustomSource = autoCompleteStringCollection;
            FillAutocompleteStringCollection();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            FillAutocompleteStringCollection();

            var pharmacy = Items.FirstOrDefault(s => s.ToString() == Text);
            if (pharmacy != null)
                Pharmacy = pharmacy;
        }

        private void FillAutocompleteStringCollection()
        {
            if (AutoCompleteCustomSource.Contains(Text))
                Items = _pharmacyRepository.Search(Text, 10);

            var items = Items.Select(s => s.ToString()).ToArray();
            //autoCompleteStringCollection.Clear();
            AutoCompleteCustomSource.AddRange(items);
        }
    }
}
