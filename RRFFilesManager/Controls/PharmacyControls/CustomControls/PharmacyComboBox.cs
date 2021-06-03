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

namespace RRFFilesManager.Controls.PharmacyControls
{
    public partial class PharmacyComboBox : ComboBox
    {
        public Pharmacy Pharmacy => SelectedItem as Pharmacy;
        private IPharmacyRepository _pharmacyRepository { get; set; }

        public PharmacyComboBox()
        {
            _pharmacyRepository = Program.GetService<IPharmacyRepository>();
            InitializeComponent();
            FillItems();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnTextUpdate(EventArgs e)
        {
            FillItems();
            SelectionStart = Text.Length;
            DroppedDown = true;
        }

        private void FillItems()
        {
            var items = _pharmacyRepository?.Search(Text, 10).ToArray();
            if (items == null)
                return;
            Items.Clear();
            Items.AddRange(items);
        }
    }
}
