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

namespace RRFFilesManager.Controls.ContactControls
{
    public partial class GroupForm : Form
    {
        private readonly IGroupRepository _groupRepository;
        public GroupForm()
        {
            _groupRepository = Program.GetService<IGroupRepository>();
            InitializeComponent();
        }

        public Group Group { get; set; }

        public void FillGroup(Group group)
        {
            group.Name = Name.Text;
        }

        public void FillForm(Group group)
        {
            if (group == null)
                return;
            Name.Text = group.Name;
        }
        public void UpsertGroup()
        {
            if (Group == null)
                Group = new Group();
            FillGroup(Group);
            if (Group.ID == default)
                _groupRepository.Insert(Group);
            else
                _groupRepository.Update(Group);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            UpsertGroup();
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
