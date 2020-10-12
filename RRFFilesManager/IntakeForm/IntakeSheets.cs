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
        public void BringMattertypeForm()
        {
            LoadLiabilityTab();
            LoadEmploymentIncomeLossTab();
            LoadDamagesTab();
            this.TabControl.TabPages.Clear();
            if (IntakeForm.Intake.MatterType.Description == "Motor Vehicle Accident")
            {
                this.TabControl.TabPages.Add(this.Liability);
                this.TabControl.TabPages.Add(this.EmploymentIncomeLoss);
                this.TabControl.TabPages.Add(this.Damages);
                this.TabControl.TabPages.Add(this.AccidentBenefits);
            }
            else if (IntakeForm.Intake.MatterType.Description == "Occupiers Liability")
            {
                this.TabControl.TabPages.Add(this.Liability);
                this.TabControl.TabPages.Add(this.EmploymentIncomeLoss);
                this.TabControl.TabPages.Add(this.Damages);
            }
            else if (IntakeForm.Intake.MatterType.Description == "Disability")
            {
                this.TabControl.TabPages.Add(this.Policy);
                this.TabControl.TabPages.Add(this.EmploymentIncomeLoss);
                this.TabControl.TabPages.Add(this.Damages);
            }
            else if (IntakeForm.Intake.MatterType.Description == "General Negligence")
            {
                this.TabControl.TabPages.Add(this.Liability);
                this.TabControl.TabPages.Add(this.EmploymentIncomeLoss);
                this.TabControl.TabPages.Add(this.Damages);
            }

            this.TabControl.TabPages.Add(this.OtherNotes);
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

        private void Policy_Click(object sender, EventArgs e)
        {

        }

        private void Liability_Enter(object sender, EventArgs e)
        {

        }

        public void LoadLiabilityTab()
        {
            this.ReceiveCopyGroupBox.Visible = false;
            this.LiaWhereAccidentGroup.Text = "Where did the incident occur (place/address)?";
            this.LiaExplainGroup.Text = "Explain in detail how the incident ocurred";
            this.LiaHavePhotosGroup.Text = "Do you have any photos of the incident?";
            this.OthersLiabilityGroup.Visible = true;
            this.MVALiabilityGroup.Visible = false;
            if (IntakeForm.Intake.MatterType.Description == "Motor Vehicle Accident")
            {
                this.ReceiveCopyGroupBox.Visible = true;
                this.LiaWhereAccidentGroup.Text = "Where did the accident occur (place/address)?";
                this.LiaExplainGroup.Text = "Explain in detail how the accident ocurred";
                this.LiaHavePhotosGroup.Text = "Do you have any photos of the damaged vehicles?";
                this.OthersLiabilityGroup.Visible = false;
                this.MVALiabilityGroup.Visible = true;
            }
        }

        public void LoadEmploymentIncomeLossTab()
        {
            this.EILWereEmployedLabel.Text = "Were you employed at the time of this incident?";
            EILEmployed4WeeksLabel.Visible = false;
            EILEmployed4Weeks.Visible = false;
            EILEmployed52WeeksLabel.Visible = false;
            EILEmployed52Weeks.Visible = false;

            EILCollecInsuranceLabel.Text = "Were you collecting Employment Insurance in the last 52 weeks before the incident?";

            SocialAssistanceGroup.Visible = true;

            EILEmployeeGrossEarningLabel.Text = "How much were you earning (gross) at the time of this incident?";

            EILSelfGrossEarningLabel.Text = "How much were you earning (gross) at the time of this incident?";

            if (IntakeForm.Intake.MatterType.Description == "Motor Vehicle Accident" || IntakeForm.Intake.MatterType.Description == "Disability")
            {
                this.EILWereEmployedLabel.Text = "Were you employed at the time of this motor vehicle accident?";
                EILEmployed4WeeksLabel.Visible = true;
                EILEmployed4Weeks.Visible = true;
                EILEmployed52WeeksLabel.Visible = true;
                EILEmployed52Weeks.Visible = true;

                EILCollecInsuranceLabel.Text = "Were you collecting Employment Insurance in the last 52 weeks before the accident?";

                SocialAssistanceGroup.Visible = false;

                EILEmployeeGrossEarningLabel.Text = "How much were you earning (gross) at the time of this accident?";

                EILSelfGrossEarningLabel.Text = "How much were you earning (gross) at the time of this accident?";
            }
        }

        public void LoadDamagesTab()
        {
            DamHitVehicleConcreteGroupBox.Text = "During this incident did your body hit any other property such as concrete?";
            DamWentToHospitalGroupBox.Text = "Were you taken or did you go to a hospital to have your injuries looked at following this incident?";
            DamHeadInjuriesGroupBox.Text = "Please indicate HEAD INJURIES in this incident";
            DamUpperBodyInjuriesGroupBox.Text = "Please indicate UPPER BODY INJURIES in this incident";
            DamLowerBodyInjuriesGroupBox.Text = "Please indicate LOWER BODY INJURIES in this incident";
            DamPsychologicalEffectGroupBox.Text = "Please indicate psychocological effects as a result of this incident";
            DamPrescribedGroupBox.Text = "Since the accident, have you been prescribed any medication?";
            DamWereSeeingDoctorGroupBox.Text = "Were or are you seeing any other health care provider as a result of your injuries from this incident (specialist, physioterapist, pychologist, etc.)?";
            DamPreAccidentGroupBox.Text = "Prior to this incident, were you ever involved in a motor vehicle accident, slip and fall accidents, workplace accidents?";
            DamPreIllnessGroupBox.Text = "Do you suffer from any other illness (unrelated to this incident) such as cancer, heart issues, pre-existing anxiety or depression, etc.?";

            if (IntakeForm.Intake.MatterType.Description == "Motor Vehicle Accident" || IntakeForm.Intake.MatterType.Description == "Disability")
            {
                DamHitVehicleConcreteGroupBox.Text = "During this accident did your body hit any part of the inside of the vehicle or your body part with any other property such as concrete?";
                DamWentToHospitalGroupBox.Text = "Were you taken or did you go to a hospital to have your injuries looked at following this accident?";
                DamHeadInjuriesGroupBox.Text = "Please indicate HEAD INJURIES in this accident";
                DamUpperBodyInjuriesGroupBox.Text = "Please indicate UPPER BODY INJURIES in this accident";
                DamLowerBodyInjuriesGroupBox.Text = "Please indicate LOWER BODY INJURIES in this accident";
                DamPsychologicalEffectGroupBox.Text = "Please indicate psychocological effects as a result of this accident";
                DamPrescribedGroupBox.Text = "Since the incident, have you been prescribed any medication?";
                DamWereSeeingDoctorGroupBox.Text = "Were or are you seeing any other health care provider as a result of your injuries from this accident (specialist, physioterapist, pychologist, etc.)?";
                DamPreAccidentGroupBox.Text = "Prior to this accident, were you ever involved in a motor vehicle accident, slip and fall accidents, workplace accidents?";
                DamPreIllnessGroupBox.Text = "Do you suffer from any other illness (unrelated to this motor vehicle accident) such as cancer, heart issues, pre-existing anxiety or depression, etc.?";
            }
        }
    }
}
