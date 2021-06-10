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

namespace RRFFilesManager.Controls.ProvinceControls.CustomControls
{
    public partial class ProvinceComboBox : ComboBox
    {
        public Province Province => SelectedItem as Province;
        private IProvinceRepository _provinceRepository { get; set; }
        public ProvinceComboBox()
        {
            _provinceRepository = Program.GetService<IProvinceRepository>();
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
            var items = _provinceRepository?.List().ToArray();
            if (items == null)
                return;
            Items.Clear();
            Items.AddRange(items);
        }
        public void Reset()
        {
            ResetText();
            FillItems();
        }
    }
}
