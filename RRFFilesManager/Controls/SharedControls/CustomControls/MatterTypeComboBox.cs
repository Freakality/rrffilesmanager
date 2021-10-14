using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.SharedControls.CustomControls
{
    public partial class MatterTypeComboBox : ComboBox
    {
        public MatterType MatterType => SelectedItem as MatterType;
        private IMatterTypeRepository _matterTypeRepository { get; set; }

        public MatterTypeComboBox()
        {
            _matterTypeRepository = Program.GetService<IMatterTypeRepository>();
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
            var items = _matterTypeRepository?.List().ToArray();
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
