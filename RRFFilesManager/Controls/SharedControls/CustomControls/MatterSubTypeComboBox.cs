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
    public partial class MatterSubTypeComboBox : ComboBox
    {
        public MatterType MatterType { 
            get => matterType; 
            set {
                SelectedItem = null;
                matterType = value;
                FillItems();
            }
        }
        private MatterType matterType;
        public MatterSubType MatterSubType => SelectedItem as MatterSubType;
        private IMatterSubTypeRepository _matterSubTypeRepository { get; set; }

        public MatterSubTypeComboBox()
        {
            _matterSubTypeRepository = Program.GetService<IMatterSubTypeRepository>();
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
            var items = _matterSubTypeRepository?.List().Where(s => MatterType != null && s.MatterType.ID == MatterType.ID).ToArray();
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
