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
using RRFFilesManager.Abstractions;
using RRFFilesManager.Logic;
using RRFFilesManager.Abstractions.DataAccess;

namespace RRFFilesManager.IntakeForm
{
    public partial class IntakeSheets : UserControl
    {
        private readonly IIntakeRepository _intakeRepository;
        private readonly IDisabilityInsuranceCompanyRepository _disabilityInsuranceCompanyRepository;
        public IntakeSheets()
        {
            _intakeRepository = (IIntakeRepository)Program.ServiceProvider.GetService(typeof(IIntakeRepository));
            _disabilityInsuranceCompanyRepository = (IDisabilityInsuranceCompanyRepository)Program.ServiceProvider.GetService(typeof(IDisabilityInsuranceCompanyRepository));
            InitializeComponent();
        }

        public void BringMattertypeForm()
        {
            LoadLiabilityTab();
            LoadEmploymentIncomeLossTab();
            LoadDamagesTab();
            this.TabControl.TabPages.Clear();
            if (Home.IntakeForm.Intake.MatterType.Description == "Motor Vehicle Accident")
            {
                this.TabControl.TabPages.Add(this.Liability);
                this.TabControl.TabPages.Add(this.EmploymentIncomeLoss);
                this.TabControl.TabPages.Add(this.Damages);
                this.TabControl.TabPages.Add(this.AccidentBenefits);
                Liability.BackColor = Color.LightYellow;
                EmploymentIncomeLoss.BackColor = Color.LightYellow;
                Damages.BackColor = Color.LightYellow;
                AccidentBenefits.BackColor = Color.LightYellow;
                OtherNotes.BackColor = Color.LightYellow;
            }
            else if (Home.IntakeForm.Intake.MatterType.Description == "Occupiers Liability")
            {
                this.TabControl.TabPages.Add(this.Liability);
                this.TabControl.TabPages.Add(this.EmploymentIncomeLoss);
                this.TabControl.TabPages.Add(this.Damages);
                Liability.BackColor = Color.LightGreen;
                EmploymentIncomeLoss.BackColor = Color.LightGreen;
                Damages.BackColor = Color.LightGreen;
                OtherNotes.BackColor = Color.LightGreen;
            }
            else if (Home.IntakeForm.Intake.MatterType.Description == "Disability")
            {
                this.TabControl.TabPages.Add(this.Policy);
                this.TabControl.TabPages.Add(this.EmploymentIncomeLoss);
                this.TabControl.TabPages.Add(this.Damages);
                Policy.BackColor = Color.LightBlue;
                EmploymentIncomeLoss.BackColor = Color.LightBlue;
                Damages.BackColor = Color.LightBlue;
                OtherNotes.BackColor = Color.LightBlue;
            }
            else if (Home.IntakeForm.Intake.MatterType.Description == "General Negligence")
            {
                this.TabControl.TabPages.Add(this.Liability);
                this.TabControl.TabPages.Add(this.EmploymentIncomeLoss);
                this.TabControl.TabPages.Add(this.Damages);
                Liability.BackColor = Color.LightSalmon;
                EmploymentIncomeLoss.BackColor = Color.LightSalmon;
                Damages.BackColor = Color.LightSalmon;
                OtherNotes.BackColor = Color.LightSalmon;
            }

            this.TabControl.TabPages.Add(this.OtherNotes);
        }

        private void IntakeSheets_Load(object sender, EventArgs e)
        {
            Utils.SetComboBoxDataSource(PolCompanyDeniedBenefits, _disabilityInsuranceCompanyRepository.ListAsync()?.Result);
        }

        public void LoadLiabilityTab()
        {
            this.ReceiveCopyGroupBox.Visible = false;
            this.LiaWhereAccidentGroup.Text = "Where did the incident occur (place/address)?";
            this.LiaExplainGroup.Text = "Explain in detail how the incident ocurred";
            this.LiaHavePhotosGroup.Text = "Do you have any photos of the incident?";
            this.OthersLiabilityGroup.Visible = true;
            this.MVALiabilityGroup.Visible = false;
            if (Home.IntakeForm.Intake.MatterType.Description == "Motor Vehicle Accident")
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

            if (Home.IntakeForm.Intake.MatterType.Description == "Motor Vehicle Accident" || Home.IntakeForm.Intake.MatterType.Description == "Disability")
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

            if (Home.IntakeForm.Intake.MatterType.Description == "Motor Vehicle Accident" || Home.IntakeForm.Intake.MatterType.Description == "Disability")
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

        public void OnNext()
        {
            FillOrCreateIntakeClient();
        }

        public void FillOrCreateIntakeClient()
        {
            var intake = Home.IntakeForm.Intake;
            FillIntake(intake);
            if (intake.ID == default)
                _intakeRepository.InsertAsync(intake);
            else
                _intakeRepository.UpdateAsync(intake);
        }

        public void FillIntake(Intake intake)
        {

            FillIntakeFromLiabilityForm(intake);
            FillIntakeFromEmploymentForm(intake);
            FillIntakeFromDamagesForm(intake);
            FillIntakeFromAccidentBenefitsForm(intake);
            FillIntakeFromPolicyForm(intake);
            intake.Notes = Notes.Text;
        }
        public void FillIntakeFromLiabilityForm(Intake intake)
        {
            intake.LiaDate = LiaDate.Value;
            intake.LiaMVR = LiaMVR.Checked;
            intake.LiaReportCollision = LiaReportCollision.Checked;
            intake.LiaMVCExchange = LiaMVCExchange.Checked;
            intake.LiaOtherDoc = LiaOtherDoc.Checked;
            intake.LiaWhereAccident = LiaWhereAccident.Text;
            intake.LiaExplain = LiaExplain.Text;
            intake.LiaHavePhotos = LiaHavePhotos.Text;
            intake.LiaEstimDamage = LiaEstimDamage.Text;
            intake.LiaYourFault = LiaYourFault.Text;
            intake.LiaDriverName = LiaDriverName.Text;
            intake.LiaOwnerName = LiaOwnerName.Text;
            intake.LiaInsuranceCo = LiaInsuranceCo.Text;
            intake.LiaHaveCopy = LiaHaveCopy.Text;
            intake.LiaOwnNegligence = LiaOwnNegligence.Text;
            intake.LiaFaultPerson = LiaFaultPerson.Text;
            intake.LiaMunicipality = LiaMunicipality.Text;
            intake.LiaNotifiedMunicipality = LiaNotifiedMunicipality.Text;
            intake.LiaNotes = LiaNotes.Text;
        }

        public void FillIntakeFromEmploymentForm(Intake intake)
        {
            intake.EILWereEmployed = EILWereEmployed.Text;
            intake.EILEmployed4Weeks = EILEmployed4Weeks.Text;
            intake.EILEmployed52Weeks = EILEmployed52Weeks.Text;
            intake.EILT4Employee = EILT4Employee.Text;
            intake.EILT4Company = EILT4Company.Text;
            intake.EILCollecInsurance = EILCollecInsurance.Text;
            intake.EILEmployeeGrossEarning = EILEmployeeGrossEarning.Text;
            intake.EILHowLongEmployee = EILHowLongEmployee.Text;
            intake.EILJobTitle = EILJobTitle.Text;
            intake.EILExplainJob = EILExplainJob.Text;
            intake.EILWereSelfEmployed = EILWereSelfEmployed.Text;
            intake.EILSelfBusinessName = EILSelfBusinessName.Text;
            intake.EILSelfGrossEarning = EILSelfGrossEarning.Text;
            intake.EILHowLongBusiness = EILHowLongBusiness.Text;
            intake.EILNotes = EILNotes.Text;
        }
        public void FillIntakeFromDamagesForm(Intake intake)
        {
            intake.DamHitVehicleConcrete = DamHitVehicleConcrete.Text;
            intake.DamHeadInjuries = DamHeadInjuries.Text;
            intake.DamHeadInjuries = DamHeadInjuries.Text;
            intake.DamUpperBodyInjuries = DamUpperBodyInjuries.Text;
            intake.DamLowerBodyInjuries = DamLowerBodyInjuries.Text;
            intake.DamPsychologicalEffect = DamPsychologicalEffect.Text;
            intake.DamPrescribed = DamPrescribed.Text;
            intake.DamWereSeeingDoctor = DamWereSeeingDoctor.Text;
            intake.DamPreAccident = DamPreAccident.Text;
            intake.DamPreIllness = DamPreIllness.Text;
            intake.DamNotes = DamNotes.Text;
        }
        public void FillIntakeFromAccidentBenefitsForm(Intake intake)
        {
            intake.AccBenDriverPassenger = AccBenDriverPassenger.Text;
            intake.AccBenWereRegisOwner = AccBenWereRegisOwner.Text;
            intake.AccBenRegisOwnerName = AccBenRegisOwnerName.Text;
            intake.AccBenPolicyNumber = AccBenPolicyNumber.Text;
            intake.AccBenClaimNumber = AccBenClaimNumber.Text;
            intake.AccBenInsuranceCompany = AccBenInsuranceCompany.Text;
            intake.AccBenAdjuster = AccBenAdjuster.Text;
            intake.AccBenOCF1 = AccBenOCF1.Text;
            intake.AccBenOCF2 = AccBenOCF2.Text;
            intake.AccBenOCF3 = AccBenOCF3.Text;
            intake.AccBenReplacBenef = AccBenReplacBenef.Text;
            intake.AccBenNotes = AccBenNotes.Text;
        }

        public void FillIntakeFromPolicyForm(Intake intake)
        {
            intake.PolSickBenefits = PolSickBenefits.Text;
            intake.PolWhoPaidBenefits = PolWhoPaidBenefits.Text;
            intake.PolDateLostBenefits = PolDateLostBenefits.Value;
            intake.PolDeniedSTPorLTD = PolDeniedSTPorLTD.Text;
            intake.PolHowMuchBeingPaid = PolHowMuchBeingPaid.Text;
            intake.PolCompanyDeniedBenefits = (DisabilityInsuranceCompany)PolCompanyDeniedBenefits.SelectedItem;
            intake.PolLTDPrivateOrEmployerGroup = PolLTDPrivateOrEmployerGroup.Text;
            intake.PolDateSubmittedLTD = PolDateSubmittedLTD.Value;
            intake.PolDateStartedCollLTD = PolDateStartedCollLTD.Value;
            intake.PolDateLastDayLTD = PolDateLastDayLTD.Value;
            intake.PolFirstTimeLTDApproved = PolFirstTimeLTDApproved.Text;
            intake.PolReasonTerminateLTD = PolReasonTerminateLTD.Text;
            intake.PolApplicationForCPP = PolApplicationForCPP.Text;
            intake.PolCPPOwnOrCompany = PolCPPOwnOrCompany.Text;
            intake.PolCPPApproved = PolCPPApproved.Text;
            intake.PolOtherNotes = PolOtherNotes.Text;
        }


        public void FillForm(Intake intake)
        {

            FillLiabilityForm(intake);
            FillEmploymentForm(intake);
            FillDamagesForm(intake);
            FillAccidentBenefitsForm(intake);
            FillPolicyForm(intake);
            Notes.Text = intake.Notes;
        }
        public void FillLiabilityForm(Intake intake)
        {
            LiaDate.Value = intake.LiaDate;
            LiaMVR.Checked = intake.LiaMVR;
            LiaReportCollision.Checked = intake.LiaReportCollision;
            LiaMVCExchange.Checked = intake.LiaMVCExchange;
            LiaOtherDoc.Checked = intake.LiaOtherDoc;
            LiaWhereAccident.Text = intake.LiaWhereAccident;
            LiaExplain.Text = intake.LiaExplain;
            LiaHavePhotos.Text = intake.LiaHavePhotos;
            LiaEstimDamage.Text = intake.LiaEstimDamage;
            LiaYourFault.Text = intake.LiaYourFault;
            LiaDriverName.Text = intake.LiaDriverName;
            LiaOwnerName.Text = intake.LiaOwnerName;
            LiaInsuranceCo.Text = intake.LiaInsuranceCo;
            LiaHaveCopy.Text = intake.LiaHaveCopy;
            LiaOwnNegligence.Text = intake.LiaOwnNegligence;
            LiaFaultPerson.Text = intake.LiaFaultPerson;
            LiaMunicipality.Text = intake.LiaMunicipality;
            LiaNotifiedMunicipality.Text = intake.LiaNotifiedMunicipality;
            LiaNotes.Text = intake.LiaNotes;
        }

        public void FillEmploymentForm(Intake intake)
        {
            EILWereEmployed.Text = intake.EILWereEmployed;
            EILEmployed4Weeks.Text = intake.EILEmployed4Weeks;
            EILEmployed52Weeks.Text = intake.EILEmployed52Weeks;
            EILT4Employee.Text = intake.EILT4Employee;
            EILT4Company.Text = intake.EILT4Company;
            EILCollecInsurance.Text = intake.EILCollecInsurance;
            EILEmployeeGrossEarning.Text = intake.EILEmployeeGrossEarning;
            EILHowLongEmployee.Text = intake.EILHowLongEmployee;
            EILJobTitle.Text = intake.EILJobTitle;
            EILExplainJob.Text = intake.EILExplainJob;
            EILWereSelfEmployed.Text = intake.EILWereSelfEmployed;
            EILSelfBusinessName.Text = intake.EILSelfBusinessName;
            EILSelfGrossEarning.Text = intake.EILSelfGrossEarning;
            EILHowLongBusiness.Text = intake.EILHowLongBusiness;
            EILNotes.Text = intake.EILNotes;
        }
        public void FillDamagesForm(Intake intake)
        {
            DamHitVehicleConcrete.Text = intake.DamHitVehicleConcrete;
            DamHeadInjuries.Text = intake.DamHeadInjuries;
            DamHeadInjuries.Text = intake.DamHeadInjuries;
            DamUpperBodyInjuries.Text = intake.DamUpperBodyInjuries;
            DamLowerBodyInjuries.Text = intake.DamLowerBodyInjuries;
            DamPsychologicalEffect.Text = intake.DamPsychologicalEffect;
            DamPrescribed.Text = intake.DamPrescribed;
            DamWereSeeingDoctor.Text = intake.DamWereSeeingDoctor;
            DamPreAccident.Text = intake.DamPreAccident;
            DamPreIllness.Text = intake.DamPreIllness;
            DamNotes.Text = intake.DamNotes;
        }
        public void FillAccidentBenefitsForm(Intake intake)
        {
            AccBenDriverPassenger.Text = intake.AccBenDriverPassenger;
            AccBenWereRegisOwner.Text = intake.AccBenWereRegisOwner;
            AccBenRegisOwnerName.Text = intake.AccBenRegisOwnerName;
            AccBenPolicyNumber.Text = intake.AccBenPolicyNumber;
            AccBenClaimNumber.Text = intake.AccBenClaimNumber;
            AccBenInsuranceCompany.Text = intake.AccBenInsuranceCompany;
            AccBenAdjuster.Text = intake.AccBenAdjuster;
            AccBenOCF1.Text = intake.AccBenOCF1;
            AccBenOCF2.Text = intake.AccBenOCF2;
            AccBenOCF3.Text = intake.AccBenOCF3;
            AccBenReplacBenef.Text = intake.AccBenReplacBenef;
            AccBenNotes.Text = intake.AccBenNotes;
        }

        public void FillPolicyForm(Intake intake)
        {
            PolSickBenefits.Text = intake.PolSickBenefits;
            PolWhoPaidBenefits.Text = intake.PolWhoPaidBenefits;
            PolDateLostBenefits.Value = intake.PolDateLostBenefits;
            PolDeniedSTPorLTD.Text = intake.PolDeniedSTPorLTD;
            PolHowMuchBeingPaid.Text = intake.PolHowMuchBeingPaid;
            PolCompanyDeniedBenefits.SelectedItem = intake.PolCompanyDeniedBenefits;
            PolLTDPrivateOrEmployerGroup.Text = intake.PolLTDPrivateOrEmployerGroup;
            PolDateSubmittedLTD.Value = intake.PolDateSubmittedLTD;
            PolDateStartedCollLTD.Value = intake.PolDateStartedCollLTD;
            PolDateLastDayLTD.Value = intake.PolDateLastDayLTD;
            PolFirstTimeLTDApproved.Text = intake.PolFirstTimeLTDApproved;
            PolReasonTerminateLTD.Text = intake.PolReasonTerminateLTD;
            PolApplicationForCPP.Text = intake.PolApplicationForCPP;
            PolCPPOwnOrCompany.Text = intake.PolCPPOwnOrCompany;
            PolCPPApproved.Text = intake.PolCPPApproved;
            PolOtherNotes.Text = intake.PolOtherNotes;
        }

        private void Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Policy_Click(object sender, EventArgs e)
        {

        }

        private void PolDateLastDayLTD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LiaWhereAccident_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
