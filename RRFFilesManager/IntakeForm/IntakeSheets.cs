using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRFFilesManager.DataAccess;

namespace RRFFilesManager.IntakeForm
{
    public partial class IntakeSheets : UserControl
    {
        public IntakeSheets()
        {
            InitializeComponent();
        }

        private static IntakeSheets instance;
        public static IntakeSheets Instance => instance ?? (instance = new IntakeSheets());
        public void bringMattertypeForm()
        {
            this.ReceiveCopyGroupBox.Visible = false;
            this.TabControl.TabPages.Clear();
            this.LiaWhereAccidentGroup.Text = "Where did the incident occur (place/address)?";
            this.LiaExplainGroup.Text = "Explain in detail how the incident ocurred";
            this.LiaHavePhotosGroup.Text = "Do you have any photos of the incident?";
            this.OthersLiabilityGroup.Visible = true;
            this.MVALiabilityGroup.Visible = false;
            if (PreliminaryInfo.Instance.MatterTypeComboBox.Text == "Motor Vehicle Accident")
            {
                this.ReceiveCopyGroupBox.Visible = true;
                this.LiaWhereAccidentGroup.Text = "Where did the accident occur (place/address)?";
                this.LiaExplainGroup.Text = "Explain in detail how the accident ocurred";
                this.LiaHavePhotosGroup.Text = "Do you have any photos of the damaged vehicles?";
                this.OthersLiabilityGroup.Visible = false;
                this.MVALiabilityGroup.Visible = true;
            }
            else if (PreliminaryInfo.Instance.MatterTypeComboBox.Text == "Occupiers Liability")
            {
            }
            else if (PreliminaryInfo.Instance.MatterTypeComboBox.Text == "Disability")
            {
            }
            else if (PreliminaryInfo.Instance.MatterTypeComboBox.Text == "General Negligence")
            {
            }
            else
            {
            }

            if (PreliminaryInfo.Instance.MatterTypeComboBox.Text == "Disability")
            {
                this.TabControl.TabPages.Add(this.Policy);
            }
            else
            {
                this.TabControl.TabPages.Add(this.Liability);
            }

            if (!(PreliminaryInfo.Instance.MatterTypeComboBox.Text == "Other Notes"))
            {
                this.TabControl.TabPages.Add(this.EmploymentIncomeLoss);
                this.TabControl.TabPages.Add(this.Damages);
            }

            if (PreliminaryInfo.Instance.MatterTypeComboBox.Text == "Motor Vehicle Accident")
            {
                this.TabControl.TabPages.Add(this.AccidentBenefits);
            }

            this.TabControl.TabPages.Add(this.OtherNotes);
            // getNewFileNumber(lastFileNumber)
        }

        private void IntakeSheets_Load(object sender, EventArgs e)
        {
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void DisTypeTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void DisTemplateName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Button14_Click(object sender, EventArgs e)
        {
        }

        private void LiaWhereAccident_TextChanged(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
