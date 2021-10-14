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
    public partial class ComissionSubTypeComboBox : ComboBox
    {
        public MatterType MatterType
        {
            get => matterType;
            set
            {
                SelectedItem = null;
                matterType = value;
                FillItems();
            }
        }
        private MatterType matterType;
        public ComissionSubType ComissionSubType => SelectedItem as ComissionSubType;
        private IGenericRepository<ComissionSubType> _comissionSubTypeRepository { get; set; }

        public ComissionSubTypeComboBox()
        {
            _comissionSubTypeRepository = Program.GetService<IGenericRepository<ComissionSubType>>();
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
            var items = _comissionSubTypeRepository?.List().Where(s => MatterType != null && s.MatterType.ID == MatterType.ID).ToArray();
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
