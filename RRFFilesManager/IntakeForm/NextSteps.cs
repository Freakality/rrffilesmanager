using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using RRFFilesManager.DataAccess;
using System.Configuration;
using System.IO;
using Microsoft.Office.Interop.Outlook;
using RRFFilesManager.Abstractions;
using RRFFilesManager.Logic;

namespace RRFFilesManager.IntakeForm
{
    public partial class NextSteps : UserControl
    {
        public NextSteps()
        {
            InitializeComponent();
            var typesOfTemplates = Program.DBContext.CYATemplates.Where(s => s.MatterType.ID == IntakeForm.Intake.MatterType.ID)?.Select(s => s.TypeOfTemplate).Distinct().ToArray();
            TypeTemplate.Items.AddRange(typesOfTemplates);
        }
        private void InvokeCYP_CheckedChanged(object sender, EventArgs e)
        {
            MVATemplatesGroupBox.Visible = this.InvokeCYP.Checked;
            Submit.Visible = this.InvokeCYP.Checked;
            Submit.Text = "Submit";
        }

        private void PAHProcess_CheckedChanged(object sender, EventArgs e)
        {
            MVATemplatesGroupBox.Visible = this.InvokeCYP.Checked;
            Submit.Visible = this.PAHProcess.Checked;
            Submit.Text = "Print and Hold";
        }

        private void TypeTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            TemplateName.DataSource = Program.DBContext.CYATemplates.Where(s => s.MatterType.ID == IntakeForm.Intake.MatterType.ID && s.TypeOfTemplate == TypeTemplate.Text)?.ToList();
            TemplateName.DisplayMember = nameof(CYATemplate.TemplateName);
        }

        private void NextSteps_Load(object sender, EventArgs e)
        {
                
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            Home.IntakeForm.Hide();
            Submitting.Instance.Show();
            if (InvokeCIP.Checked)
            {
                SetHoldIntake(false);
                // CreateSendItem("rojascarlos82@hotmail.com",attachmentPath)
                Outlook.NewEmail("DManzano@InjuryLawyerCanada.com", "CIP Process Testing", "CIP Process Testing");
                Outlook.NewEmail("RFoisy@InjuryLawyerCanada.com", "CIP Process Testing", "CIP Process Testing");
            }
            else if (InvokeCYP.Checked)
            {
                SetHoldIntake(false);
                CreateSendItemCYA();
            }
            else if (PAHProcess.Checked)
            {
                PrintAndHold();
            }
            Submitting.Instance.Hide();
            Home.IntakeForm.Close();
            Home.Instance.Show();
        }
        

        public void PrintAndHold()
        {
            SetHoldIntake(true);
            CreateSendItemPAH();

        }
        public void SetHoldIntake(bool hold)
        {
            var intake = Program.DBContext.Intakes.FirstOrDefault(s => s.ID == IntakeForm.Intake.ID);
            intake.Hold = hold;
            Program.DBContext.SaveChanges();
        }
        public void CreateSendItemPAH()
        {
            var attachmentPath = CreateIntakeWorkbook();
            string clientFullName = $"{IntakeForm.Intake.Client?.LastName}, {IntakeForm.Intake.Client?.FirstName}";
            string receip = "rojascarlos82@hotmail.com";
            var subject = $"Print and Hold Process - {clientFullName}";
            var body = "";
            Outlook.NewEmail(receip, subject, body, new[] { attachmentPath });
        }
        public void CreateSendItemCYA()
        {
            var attachmentPath = CreateCYADocument();
            var attachmentPath2 = CreateIntakeWorkbook();
            string nameStr = $"{IntakeForm.Intake.Client?.LastName}, {IntakeForm.Intake.Client?.FirstName}";
            string signat = IntakeForm.Intake.StaffInterviewer.Description;
            string receip = "rojascarlos82@hotmail.com";

            var subject = $"New CYA Process Invoked - {nameStr}";
            var body = $@"<p>Hi,</p><br><br>

                        <p>Please be advised that the following initial intake has been
                        completed. We will not be taking on this client at this time. Please arrange to
                        complete the CYA process as indicated by the attached draft CYA correspondence.</p><br><br>

                        <p>If you have any questions, please see me.</p><br>

                        <p>Regards,</p><br>

                        <p>{signat}</p>";
            Outlook.NewEmail(new[] { receip }, subject, body, new[] { attachmentPath, attachmentPath2 });
        }
        private string CreateIntakeWorkbook()
        {
            string templateExcelPath = Path.Combine(ConfigurationManager.AppSettings["ExcelTemplatesPath"], $"{IntakeForm.Intake.MatterType.Description}.xlsx");
            return this.CreateAndFillTemplateWoorkbook(templateExcelPath);
        }
        private string CreateCYADocument()
        {
            var CYATemplate = (CYATemplate)TemplateName.SelectedItem;
            string templateDocumentPath = CYATemplate.TemplatePath;
            string wordTemplatesPathSetting = ConfigurationManager.AppSettings["WordTemplatesPath"];

            if (!string.IsNullOrWhiteSpace(wordTemplatesPathSetting))
                templateDocumentPath = templateDocumentPath.Replace(@"\\FS\FOISY\!", wordTemplatesPathSetting);

            return this.CreateAndFillTemplateDocument(templateDocumentPath); ;
        }


        private string CreateAndFillTemplateDocument(string templatePath)
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var document = wordApp?.Documents.Open(templatePath);
            var filePath = Path.Combine(ConfigurationManager.AppSettings["ExcelTemplatesPath"], $"CYACorrespondence{DateTime.Now:Mdyhhmmss}.doc");
            wordApp.Visible = true;
            Word.ReplaceAll(document, "$$$TodaysDate$$$", DateTime.Now.ToString("MMMM d, yyyy"));
            Word.ReplaceAll(document, "$$$FirstName$$$", IntakeForm.Intake.Client?.FirstName);
            Word.ReplaceAll(document, "$$$LastName$$$", IntakeForm.Intake.Client?.LastName);
            Word.ReplaceAll(document, "$$$Address1$$$", IntakeForm.Intake.Client?.Address);
            Word.ReplaceAll(document, "$$$Address2$$$", "");
            Word.ReplaceAll(document, "$$$City$$$", IntakeForm.Intake.Client?.City);
            Word.ReplaceAll(document, "$$$Province$$$", IntakeForm.Intake.Client?.Province?.Description);
            Word.ReplaceAll(document, "$$$PostalCode$$$", IntakeForm.Intake.Client?.PostalCode);
            Word.ReplaceAll(document, "$$$Salutation$$$", IntakeForm.Intake.Client?.Salutation);
            Word.ReplaceAll(document, "$$$E-mail$$$", IntakeForm.Intake.Client?.Email);
            Word.ReplaceAll(document, "$$$DateOfLoss$$$", IntakeForm.Intake.DateOFLoss.ToString("MMMM d, yyyy"));
            while (document.Content.Find.Execute(FindText: "  ", Wrap: WdFindWrap.wdFindContinue))
            {
                Word.ReplaceAll(document, "  ", " ");
            }

            
            document.SaveAs(filePath);
            document.Close();
            wordApp.Quit();
            return filePath;
        }

        private string CreateAndFillTemplateWoorkbook(string templatePath)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excelApp?.Workbooks?.Open(templatePath);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];
            Excel.ReplaceAll(worksheet, "$$$FileNumber$$$", IntakeForm.Intake.FileNumber);
            Excel.ReplaceAll(worksheet, "$$$DateOfCall$$$", IntakeForm.Intake.DateOfCall);
            Excel.ReplaceAll(worksheet, "$$$DateOfLoss$$$", IntakeForm.Intake.DateOFLoss);
            Excel.ReplaceAll(worksheet, "$$$StaffInterviewer$$$", IntakeForm.Intake.StaffInterviewer?.Description);
            Excel.ReplaceAll(worksheet, "$$$HearAboutUs$$$", IntakeForm.Intake.HowHear?.Description);
            Excel.ReplaceAll(worksheet, "$$$FileLawyer$$$", IntakeForm.Intake.FileLawyer?.Description);
            Excel.ReplaceAll(worksheet, "$$$ResponsibleLawyer$$$", IntakeForm.Intake.ResponsibleLawyer?.Description);
            Excel.ReplaceAll(worksheet, "$$$MatterSubType$$$", IntakeForm.Intake.MatterSubType?.Description);
            Excel.ReplaceAll(worksheet, "$$$LimitationPeriod$$$", IntakeForm.Intake.LimitationPeriod);
            Excel.ReplaceAll(worksheet, "$$$StatutoryNotice$$$", IntakeForm.Intake.StatutoryNotice);
            Excel.ReplaceAll(worksheet, "$$$AdditionalNotes$$$", IntakeForm.Intake.AdditionalNotes);
            Excel.ReplaceAll(worksheet, "$$$TodaysDate$$$", DateTime.Now);
            Excel.ReplaceAll(worksheet, "$$$FirstName$$$", IntakeForm.Intake.Client?.FirstName);
            Excel.ReplaceAll(worksheet, "$$$LastName$$$", IntakeForm.Intake.Client?.LastName);
            Excel.ReplaceAll(worksheet, "$$$Address1$$$", IntakeForm.Intake.Client?.Address);
            Excel.ReplaceAll(worksheet, "$$$Address2$$$", "");
            Excel.ReplaceAll(worksheet, "$$$City$$$", IntakeForm.Intake.Client?.City);
            Excel.ReplaceAll(worksheet, "$$$Province$$$", IntakeForm.Intake.Client?.Province?.Description);
            Excel.ReplaceAll(worksheet, "$$$PostalCode$$$", IntakeForm.Intake.Client?.PostalCode);
            Excel.ReplaceAll(worksheet, "$$$Salutation$$$", IntakeForm.Intake.Client?.Salutation);
            Excel.ReplaceAll(worksheet, "$$$E-mail$$$", IntakeForm.Intake.Client?.Email);
            Excel.ReplaceAll(worksheet, "$$$HomeNumber$$$", IntakeForm.Intake.Client?.HomeNumber);
            Excel.ReplaceAll(worksheet, "$$$WorkNumber$$$", IntakeForm.Intake.Client?.WorkNumber);
            Excel.ReplaceAll(worksheet, "$$$MobileNumber$$$", IntakeForm.Intake.Client?.MobileNumber);
            Excel.ReplaceAll(worksheet, "$$$MobileCarrier$$$", IntakeForm.Intake.Client?.MobileCarrier);
            Excel.ReplaceAll(worksheet, "$$$EmailToText$$$", IntakeForm.Intake.Client?.EmailToText);
            Excel.ReplaceAll(worksheet, "$$$DateOfBirth$$$", IntakeForm.Intake.Client?.DateOfBirth);
            Excel.ReplaceAll(worksheet, "$$$OtherNotes$$$", IntakeForm.Intake.Client?.OtherNotes);

            Excel.ReplaceAll(worksheet, "$$$LiabilityDate$$$", IntakeForm.Intake.LiaDate);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMVR$$$", IntakeForm.Intake.LiaMVR);
            Excel.ReplaceAll(worksheet, "$$$LiabilityRC$$$", IntakeForm.Intake.LiaReportCollision);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMVC$$$", IntakeForm.Intake.LiaMVCExchange);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOtherDocuments$$$", IntakeForm.Intake.LiaOtherDoc);
            Excel.ReplaceAll(worksheet, "$$$LiabilityWhere$$$", IntakeForm.Intake.LiaWhereAccident);
            Excel.ReplaceAll(worksheet, "$$$LiabilityExplanation$$$", IntakeForm.Intake.LiaExplain);
            Excel.ReplaceAll(worksheet, "$$$LiabilityHavePhotos$$$", IntakeForm.Intake.LiaHavePhotos);
            Excel.ReplaceAll(worksheet, "$$$LiabilityDamageEstimation$$$", IntakeForm.Intake.LiaEstimDamage);
            Excel.ReplaceAll(worksheet, "$$$LiabilityYourFault$$$", IntakeForm.Intake.LiaYourFault);
            Excel.ReplaceAll(worksheet, "$$$LiabilityDriverName$$$", IntakeForm.Intake.LiaDriverName);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOwnerName$$$", IntakeForm.Intake.LiaOwnerName);
            Excel.ReplaceAll(worksheet, "$$$LiabilityInsuranceCompany$$$", IntakeForm.Intake.LiaInsuranceCo);
            Excel.ReplaceAll(worksheet, "$$$LiabilityCopyReport$$$", IntakeForm.Intake.LiaHaveCopy);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOwnNegligence$$$", IntakeForm.Intake.LiaOwnNegligence);
            Excel.ReplaceAll(worksheet, "$$$LiabilityFaultPerson$$$", IntakeForm.Intake.LiaFaultPerson);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMunicipalityName$$$", IntakeForm.Intake.LiaMunicipality);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMunicipalityNoticedy$$$", IntakeForm.Intake.LiaNotifiedMunicipality);
            Excel.ReplaceAll(worksheet, "$$$LiabilityNotes$$$", IntakeForm.Intake.LiaNotes);

            Excel.ReplaceAll(worksheet, "$$$LiabilityDate$$$", IntakeForm.Intake.LiaDate.ToString("MMMM d, yyyy"));
            Excel.ReplaceAll(worksheet, "$$$LiabilityMVR$$$", IntakeForm.Intake.LiaMVR);
            Excel.ReplaceAll(worksheet, "$$$LiabilityRC$$$", IntakeForm.Intake.LiaReportCollision);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMVC$$$", IntakeForm.Intake.LiaMVCExchange);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOtherDocuments$$$", IntakeForm.Intake.LiaOtherDoc);
            Excel.ReplaceAll(worksheet, "$$$LiabilityWhere$$$", IntakeForm.Intake.LiaWhereAccident);
            Excel.ReplaceAll(worksheet, "$$$LiabilityExplanation$$$", IntakeForm.Intake.LiaExplain);
            Excel.ReplaceAll(worksheet, "$$$LiabilityHavePhotos$$$", IntakeForm.Intake.LiaHavePhotos);
            Excel.ReplaceAll(worksheet, "$$$LiabilityDamageEstimation$$$", IntakeForm.Intake.LiaEstimDamage);
            Excel.ReplaceAll(worksheet, "$$$LiabilityYourFault$$$", IntakeForm.Intake.LiaYourFault);
            Excel.ReplaceAll(worksheet, "$$$LiabilityDriverName$$$", IntakeForm.Intake.LiaDriverName);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOwnerName$$$", IntakeForm.Intake.LiaOwnerName);
            Excel.ReplaceAll(worksheet, "$$$LiabilityInsuranceCompany$$$", IntakeForm.Intake.LiaInsuranceCo);
            Excel.ReplaceAll(worksheet, "$$$LiabilityCopyReport$$$", IntakeForm.Intake.LiaHaveCopy);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOwnNegligence$$$", IntakeForm.Intake.LiaOwnNegligence);
            Excel.ReplaceAll(worksheet, "$$$LiabilityFaultPerson$$$", IntakeForm.Intake.LiaFaultPerson);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMunicipalityName$$$", IntakeForm.Intake.LiaMunicipality);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMunicipalityNoticedy$$$", IntakeForm.Intake.LiaNotifiedMunicipality);
            Excel.ReplaceAll(worksheet, "$$$LiabilityNotes$$$", IntakeForm.Intake.LiaNotes);


            Excel.ReplaceAll(worksheet, "$$$PolicySickBenefits$$$", IntakeForm.Intake.PolSickBenefits);
            Excel.ReplaceAll(worksheet, "$$$PolicyWhoPaidBenefits$$$", IntakeForm.Intake.PolWhoPaidBenefits);
            Excel.ReplaceAll(worksheet, "$$$PolicyDateLostBenefits$$$", IntakeForm.Intake.PolDateLostBenefits.ToString("MMMM d, yyyy"));
            Excel.ReplaceAll(worksheet, "$$$PolicyDeniedSTPorLTD$$$", IntakeForm.Intake.PolDeniedSTPorLTD);
            Excel.ReplaceAll(worksheet, "$$$PolicyHowMuchBeingPaid$$$", IntakeForm.Intake.PolHowMuchBeingPaid);
            Excel.ReplaceAll(worksheet, "$$$PolicyCompanyDeniedBenefits$$$", IntakeForm.Intake.PolCompanyDeniedBenefits?.Description);
            Excel.ReplaceAll(worksheet, "$$$PolicyLTDPrivateOrEmployerGroup$$$", IntakeForm.Intake.PolLTDPrivateOrEmployerGroup);
            Excel.ReplaceAll(worksheet, "$$$PolicyDateSubmittedLTD$$$", IntakeForm.Intake.PolDateSubmittedLTD.ToString("MMMM d, yyyy"));
            Excel.ReplaceAll(worksheet, "$$$PolicyDateStartedCollLTD$$$", IntakeForm.Intake.PolDateStartedCollLTD.ToString("MMMM d, yyyy"));
            Excel.ReplaceAll(worksheet, "$$$PolicyDateLastDayLTD$$$", IntakeForm.Intake.PolDateLastDayLTD.ToString("MMMM d, yyyy"));
            Excel.ReplaceAll(worksheet, "$$$PolicyFirstTimeLTDApproved$$$", IntakeForm.Intake.PolFirstTimeLTDApproved);
            Excel.ReplaceAll(worksheet, "$$$PolicyReasonTerminateLTD$$$", IntakeForm.Intake.PolReasonTerminateLTD);
            Excel.ReplaceAll(worksheet, "$$$PolicyApplicationForCPP$$$", IntakeForm.Intake.PolApplicationForCPP);
            Excel.ReplaceAll(worksheet, "$$$PolicyCPPOwnOrCompany$$$", IntakeForm.Intake.PolCPPOwnOrCompany);
            Excel.ReplaceAll(worksheet, "$$$PolicyCPPApproved$$$", IntakeForm.Intake.PolCPPApproved);
            Excel.ReplaceAll(worksheet, "$$$PolicyOtherNote$$$", IntakeForm.Intake.PolOtherNotes);

            Excel.ReplaceAll(worksheet, "$$$EmploymentWereEmployed$$$", IntakeForm.Intake.EILWereEmployed);
            Excel.ReplaceAll(worksheet, "$$$EmploymentEmployed4Weeks$$$", IntakeForm.Intake.EILEmployed4Weeks);
            Excel.ReplaceAll(worksheet, "$$$EmploymentEmployed52Weeks$$$", IntakeForm.Intake.EILEmployed52Weeks);
            Excel.ReplaceAll(worksheet, "$$$EmploymentT4Employee$$$", IntakeForm.Intake.EILT4Employee);
            Excel.ReplaceAll(worksheet, "$$$EmploymentT4CompanyName$$$", IntakeForm.Intake.EILT4Company);
            Excel.ReplaceAll(worksheet, "$$$EmploymentCollectingEmploymentInsurance$$$", IntakeForm.Intake.EILCollecInsurance);
            Excel.ReplaceAll(worksheet, "$$$EmploymentGrossEarning$$$", IntakeForm.Intake.EILEmployeeGrossEarning);
            Excel.ReplaceAll(worksheet, "$$$EmploymentTimeBeingEmployed$$$", IntakeForm.Intake.EILHowLongEmployee);
            Excel.ReplaceAll(worksheet, "$$$EmploymentJobTitle$$$", IntakeForm.Intake.EILJobTitle);
            Excel.ReplaceAll(worksheet, "$$$EmploymentJobResponsabilities$$$", IntakeForm.Intake.EILExplainJob);
            Excel.ReplaceAll(worksheet, "$$$EmploymentSelfEmployed$$$", IntakeForm.Intake.EILWereSelfEmployed);
            Excel.ReplaceAll(worksheet, "$$$EmploymentSelfEmployedBusinessName$$$", IntakeForm.Intake.EILSelfBusinessName);
            Excel.ReplaceAll(worksheet, "$$$EmploymentSelfEmployedGrossEarning$$$", IntakeForm.Intake.EILSelfGrossEarning);
            Excel.ReplaceAll(worksheet, "$$$EmploymentSelfEmployedTimeOperating$$$", IntakeForm.Intake.EILHowLongBusiness);
            Excel.ReplaceAll(worksheet, "$$$EmploymentNotes$$$", IntakeForm.Intake.EILNotes);

            Excel.ReplaceAll(worksheet, "$$$DamagesHitPartVehicleOrConcrete$$$", IntakeForm.Intake.DamHitVehicleConcrete);
            Excel.ReplaceAll(worksheet, "$$$DamagesWentToHospital$$$", IntakeForm.Intake.DamHeadInjuries);
            Excel.ReplaceAll(worksheet, "$$$DamagesHeadInjuries$$$", IntakeForm.Intake.DamHeadInjuries);
            Excel.ReplaceAll(worksheet, "$$$DamagesUpperBodyInjuries$$$", IntakeForm.Intake.DamUpperBodyInjuries);
            Excel.ReplaceAll(worksheet, "$$$DamagesLowerBodyInjuries$$$", IntakeForm.Intake.DamLowerBodyInjuries);
            Excel.ReplaceAll(worksheet, "$$$DamagesPsychologicalEffect$$$", IntakeForm.Intake.DamPsychologicalEffect);
            Excel.ReplaceAll(worksheet, "$$$DamagesBeenPrescribedMedication$$$", IntakeForm.Intake.DamPrescribed);
            Excel.ReplaceAll(worksheet, "$$$DamagesSeeingAnyOther$$$", IntakeForm.Intake.DamWereSeeingDoctor);
            Excel.ReplaceAll(worksheet, "$$$DamagesPreviousAccident$$$", IntakeForm.Intake.DamPreAccident);
            Excel.ReplaceAll(worksheet, "$$$DamagesAnyOtherIllness$$$", IntakeForm.Intake.DamPreIllness);
            Excel.ReplaceAll(worksheet, "$$$DamagesNotes$$$", IntakeForm.Intake.DamNotes);

            Excel.ReplaceAll(worksheet, "$$$ABDriverPassenger$$$", IntakeForm.Intake.AccBenDriverPassenger);
            Excel.ReplaceAll(worksheet, "$$$ABWereRegisteredOwner$$$", IntakeForm.Intake.AccBenWereRegisOwner);
            Excel.ReplaceAll(worksheet, "$$$ABRegisteredOwnerName$$$", IntakeForm.Intake.AccBenRegisOwnerName);
            Excel.ReplaceAll(worksheet, "$$$ABPolicyNumber$$$", IntakeForm.Intake.AccBenPolicyNumber);
            Excel.ReplaceAll(worksheet, "$$$ABClaimNumber$$$", IntakeForm.Intake.AccBenClaimNumber);
            Excel.ReplaceAll(worksheet, "$$$ABInsuranceCompany$$$", IntakeForm.Intake.AccBenInsuranceCompany);
            Excel.ReplaceAll(worksheet, "$$$ABDealingSpecificAdjuster$$$", IntakeForm.Intake.AccBenAdjuster);
            Excel.ReplaceAll(worksheet, "$$$ABCompletedOCF1$$$", IntakeForm.Intake.AccBenOCF1);
            Excel.ReplaceAll(worksheet, "$$$ABCompletedOCF2$$$", IntakeForm.Intake.AccBenOCF2);
            Excel.ReplaceAll(worksheet, "$$$ABCompletedOCF3$$$", IntakeForm.Intake.AccBenOCF3);
            Excel.ReplaceAll(worksheet, "$$$ABReceivingBenefits$$$", IntakeForm.Intake.AccBenReplacBenef);
            Excel.ReplaceAll(worksheet, "$$$ABNotes$$$", IntakeForm.Intake.AccBenNotes);

            Excel.ReplaceAll(worksheet, "$$$OtherNotes$$$", IntakeForm.Intake.Notes);
            string filePath = Path.Combine(ConfigurationManager.AppSettings["ExcelTemplatesPath"], $"MVAIntakeReport{DateTime.Now:Mdyhhmmss}.xlsx");
            workbook.SaveAs(Filename: filePath);
            workbook.Close();
            excelApp.Quit();
            return filePath;
        }

        private Document OpenDocument(string path)
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var document = wordApp?.Documents.Open(path);
            wordApp.Quit();
            return document;
        }

        private Workbook OpenWorkbook(string path)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excelApp?.Workbooks?.Open(path);
            excelApp.Quit();
            return workbook;
        }

        private void TemplateName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox32_Enter(object sender, EventArgs e)
        {

        }
    }
}
