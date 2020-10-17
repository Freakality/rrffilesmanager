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
            string clientFullName = $"{IntakeForm.Intake.Client.LastName}, {IntakeForm.Intake.Client.FirstName}";
            string receip = "rojascarlos82@hotmail.com";
            var subject = $"Print and Hold Process - {clientFullName}";
            var body = "";
            Outlook.NewEmail(receip, subject, body, new[] { attachmentPath });
        }
        public void CreateSendItemCYA()
        {
            var attachmentPath = CreateCYADocument();
            var attachmentPath2 = CreateIntakeWorkbook();
            string nameStr = $"{IntakeForm.Intake.Client.LastName}, {IntakeForm.Intake.Client.FirstName}";
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

            Word.ReplaceAll(document, "$$$TodaysDate$$$", DateTime.Now.ToString("MMMM d, yyyy"));
            Word.ReplaceAll(document, "$$$FirstName$$$", IntakeForm.Intake.Client.FirstName);
            Word.ReplaceAll(document, "$$$LastName$$$", IntakeForm.Intake.Client.LastName);
            Word.ReplaceAll(document, "$$$Address1$$$", IntakeForm.Intake.Client.Address);
            Word.ReplaceAll(document, "$$$Address2$$$", "");
            Word.ReplaceAll(document, "$$$City$$$", IntakeForm.Intake.Client.City);
            Word.ReplaceAll(document, "$$$Province$$$", IntakeForm.Intake.Client.Province?.Description);
            Word.ReplaceAll(document, "$$$PostalCode$$$", IntakeForm.Intake.Client.PostalCode);
            Word.ReplaceAll(document, "$$$Salutation$$$", IntakeForm.Intake.Client.PostalCode);
            Word.ReplaceAll(document, "$$$E-mail$$$", IntakeForm.Intake.Client.Email);
            Word.ReplaceAll(document, "$$$DateOfLoss$$$", IntakeForm.Intake.DateOFLoss.ToString("MMMM d, yyyy"));
            while (document.Content.Find.Execute(FindText: "  ", Wrap: WdFindWrap.wdFindContinue))
            {
                Word.ReplaceAll(document, "  ", " ");
            }

            string filePath = Path.Combine(ConfigurationManager.AppSettings["ExcelTemplatesPath"], $"CYACorrespondence{DateTime.Now:Mdyhhmmss}.doc");
            document.SaveAs(filePath);
            document.Close();
            wordApp.Quit();
            return filePath;
        }

        private string CreateAndFillTemplateWoorkbook(string templatePath)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excelApp?.Workbooks?.Open(templatePath);
            Worksheet Worksheet = (Worksheet)workbook.Sheets[1];
            Worksheet.Cells.Replace("$$$FileNumber$$$", IntakeForm.Intake.FileNumber);
            Worksheet.Cells.Replace("$$$DateOfCall$$$", IntakeForm.Intake.DateOfCall);
            Worksheet.Cells.Replace("$$$DateOfLoss$$$", IntakeForm.Intake.DateOFLoss.ToString("MMMM d, yyyy"));
            Worksheet.Cells.Replace("$$$StaffInterviewer$$$", IntakeForm.Intake.StaffInterviewer.Description);
            Worksheet.Cells.Replace("$$$HearAboutUs$$$", IntakeForm.Intake.HowHear.Description);
            Worksheet.Cells.Replace("$$$FileLawyer$$$", IntakeForm.Intake.FileNumber);
            Worksheet.Cells.Replace("$$$ResponsibleLawyer$$$", IntakeForm.Intake.ResponsibleLawyer.Description);
            Worksheet.Cells.Replace("$$$MatterSubType$$$", IntakeForm.Intake.MatterSubType.Description);
            Worksheet.Cells.Replace("$$$LimitationPeriod$$$", IntakeForm.Intake.LimitationPeriod);
            Worksheet.Cells.Replace("$$$StatutoryNotice$$$", IntakeForm.Intake.StatutoryNotice);
            Worksheet.Cells.Replace("$$$AdditionalNotes$$$", IntakeForm.Intake.AdditionalNotes);
            Worksheet.Cells.Replace("$$$TodaysDate$$$", DateTime.Now.ToString("MMMM d, yyyy"));
            Worksheet.Cells.Replace("$$$FirstName$$$", IntakeForm.Intake.Client.FirstName);
            Worksheet.Cells.Replace("$$$LastName$$$", IntakeForm.Intake.Client.LastName);
            Worksheet.Cells.Replace("$$$Address1$$$", IntakeForm.Intake.Client.Address);
            Worksheet.Cells.Replace("$$$Address2$$$", "");
            Worksheet.Cells.Replace("$$$City$$$", IntakeForm.Intake.Client.City);
            Worksheet.Cells.Replace("$$$Province$$$", IntakeForm.Intake.Client.Province);
            Worksheet.Cells.Replace("$$$PostalCode$$$", IntakeForm.Intake.Client.PostalCode);
            Worksheet.Cells.Replace("$$$Salutation$$$", IntakeForm.Intake.Client.Salutation);
            Worksheet.Cells.Replace("$$$E-mail$$$", IntakeForm.Intake.Client.Email);
            Worksheet.Cells.Replace("$$$HomeNumber$$$", IntakeForm.Intake.Client.HomeNumber);
            Worksheet.Cells.Replace("$$$WorkNumber$$$", IntakeForm.Intake.Client.WorkNumber);
            Worksheet.Cells.Replace("$$$MobileNumber$$$", IntakeForm.Intake.Client.MobileNumber);
            Worksheet.Cells.Replace("$$$MobileCarrier$$$", IntakeForm.Intake.Client.MobileCarrier);
            Worksheet.Cells.Replace("$$$EmailToText$$$", IntakeForm.Intake.Client.EmailToText);
            Worksheet.Cells.Replace("$$$DateOfBirth$$$", IntakeForm.Intake.Client.DateOfBirth.Value.ToString("MMMM d, yyyy"));
            Worksheet.Cells.Replace("$$$OtherNotes$$$", IntakeForm.Intake.Client.OtherNotes);

            Worksheet.Cells.Replace("$$$LiabilityDate$$$", IntakeForm.Intake.LiaDate.ToString("MMMM d, yyyy"));
            Worksheet.Cells.Replace("$$$LiabilityMVR$$$", IntakeForm.Intake.LiaMVR);
            Worksheet.Cells.Replace("$$$LiabilityRC$$$", IntakeForm.Intake.LiaReportCollision);
            Worksheet.Cells.Replace("$$$LiabilityMVC$$$", IntakeForm.Intake.LiaMVCExchange);
            Worksheet.Cells.Replace("$$$LiabilityOtherDocuments$$$", IntakeForm.Intake.LiaOtherDoc);
            Worksheet.Cells.Replace("$$$LiabilityWhere$$$", IntakeForm.Intake.LiaWhereAccident);
            Worksheet.Cells.Replace("$$$LiabilityExplanation$$$", IntakeForm.Intake.LiaExplain);
            Worksheet.Cells.Replace("$$$LiabilityHavePhotos$$$", IntakeForm.Intake.LiaHavePhotos);
            Worksheet.Cells.Replace("$$$LiabilityDamageEstimation$$$", IntakeForm.Intake.LiaEstimDamage);
            Worksheet.Cells.Replace("$$$LiabilityYourFault$$$", IntakeForm.Intake.LiaYourFault);
            Worksheet.Cells.Replace("$$$LiabilityDriverName$$$", IntakeForm.Intake.LiaDriverName);
            Worksheet.Cells.Replace("$$$LiabilityOwnerName$$$", IntakeForm.Intake.LiaOwnerName);
            Worksheet.Cells.Replace("$$$LiabilityInsuranceCompany$$$", IntakeForm.Intake.LiaInsuranceCo);
            Worksheet.Cells.Replace("$$$LiabilityCopyReport$$$", IntakeForm.Intake.LiaHaveCopy);
            Worksheet.Cells.Replace("$$$LiabilityOwnNegligence$$$", IntakeForm.Intake.LiaOwnNegligence);
            Worksheet.Cells.Replace("$$$LiabilityFaultPerson$$$", IntakeForm.Intake.LiaFaultPerson);
            Worksheet.Cells.Replace("$$$LiabilityMunicipalityName$$$", IntakeForm.Intake.LiaMunicipality);
            Worksheet.Cells.Replace("$$$LiabilityMunicipalityNoticedy$$$", IntakeForm.Intake.LiaNotifiedMunicipality);
            Worksheet.Cells.Replace("$$$LiabilityNotes$$$", IntakeForm.Intake.LiaNotes);

            Worksheet.Cells.Replace("$$$LiabilityDate$$$", IntakeForm.Intake.LiaDate.ToString("MMMM d, yyyy"));
            Worksheet.Cells.Replace("$$$LiabilityMVR$$$", IntakeForm.Intake.LiaMVR);
            Worksheet.Cells.Replace("$$$LiabilityRC$$$", IntakeForm.Intake.LiaReportCollision);
            Worksheet.Cells.Replace("$$$LiabilityMVC$$$", IntakeForm.Intake.LiaMVCExchange);
            Worksheet.Cells.Replace("$$$LiabilityOtherDocuments$$$", IntakeForm.Intake.LiaOtherDoc);
            Worksheet.Cells.Replace("$$$LiabilityWhere$$$", IntakeForm.Intake.LiaWhereAccident);
            Worksheet.Cells.Replace("$$$LiabilityExplanation$$$", IntakeForm.Intake.LiaExplain);
            Worksheet.Cells.Replace("$$$LiabilityHavePhotos$$$", IntakeForm.Intake.LiaHavePhotos);
            Worksheet.Cells.Replace("$$$LiabilityDamageEstimation$$$", IntakeForm.Intake.LiaEstimDamage);
            Worksheet.Cells.Replace("$$$LiabilityYourFault$$$", IntakeForm.Intake.LiaYourFault);
            Worksheet.Cells.Replace("$$$LiabilityDriverName$$$", IntakeForm.Intake.LiaDriverName);
            Worksheet.Cells.Replace("$$$LiabilityOwnerName$$$", IntakeForm.Intake.LiaOwnerName);
            Worksheet.Cells.Replace("$$$LiabilityInsuranceCompany$$$", IntakeForm.Intake.LiaInsuranceCo);
            Worksheet.Cells.Replace("$$$LiabilityCopyReport$$$", IntakeForm.Intake.LiaHaveCopy);
            Worksheet.Cells.Replace("$$$LiabilityOwnNegligence$$$", IntakeForm.Intake.LiaOwnNegligence);
            Worksheet.Cells.Replace("$$$LiabilityFaultPerson$$$", IntakeForm.Intake.LiaFaultPerson);
            Worksheet.Cells.Replace("$$$LiabilityMunicipalityName$$$", IntakeForm.Intake.LiaMunicipality);
            Worksheet.Cells.Replace("$$$LiabilityMunicipalityNoticedy$$$", IntakeForm.Intake.LiaNotifiedMunicipality);
            Worksheet.Cells.Replace("$$$LiabilityNotes$$$", IntakeForm.Intake.LiaNotes);


            Worksheet.Cells.Replace("$$$PolicySickBenefits$$$", IntakeForm.Intake.PolSickBenefits);
            Worksheet.Cells.Replace("$$$PolicyWhoPaidBenefits$$$", IntakeForm.Intake.PolWhoPaidBenefits);
            Worksheet.Cells.Replace("$$$PolicyDateLostBenefits$$$", IntakeForm.Intake.PolDateLostBenefits.ToString("MMMM d, yyyy"));
            Worksheet.Cells.Replace("$$$PolicyDeniedSTPorLTD$$$", IntakeForm.Intake.PolDeniedSTPorLTD);
            Worksheet.Cells.Replace("$$$PolicyHowMuchBeingPaid$$$", IntakeForm.Intake.PolHowMuchBeingPaid);
            Worksheet.Cells.Replace("$$$PolicyCompanyDeniedBenefits$$$", IntakeForm.Intake.PolCompanyDeniedBenefits);
            Worksheet.Cells.Replace("$$$PolicyLTDPrivateOrEmployerGroup$$$", IntakeForm.Intake.PolLTDPrivateOrEmployerGroup);
            Worksheet.Cells.Replace("$$$PolicyDateSubmittedLTD$$$", IntakeForm.Intake.PolDateSubmittedLTD.ToString("MMMM d, yyyy"));
            Worksheet.Cells.Replace("$$$PolicyDateStartedCollLTD$$$", IntakeForm.Intake.PolDateStartedCollLTD.ToString("MMMM d, yyyy"));
            Worksheet.Cells.Replace("$$$PolicyDateLastDayLTD$$$", IntakeForm.Intake.PolDateLastDayLTD.ToString("MMMM d, yyyy"));
            Worksheet.Cells.Replace("$$$PolicyFirstTimeLTDApproved$$$", IntakeForm.Intake.PolFirstTimeLTDApproved);
            Worksheet.Cells.Replace("$$$PolicyReasonTerminateLTD$$$", IntakeForm.Intake.PolReasonTerminateLTD);
            Worksheet.Cells.Replace("$$$PolicyApplicationForCPP$$$", IntakeForm.Intake.PolApplicationForCPP);
            Worksheet.Cells.Replace("$$$PolicyCPPOwnOrCompany$$$", IntakeForm.Intake.PolCPPOwnOrCompany);
            Worksheet.Cells.Replace("$$$PolicyCPPApproved$$$", IntakeForm.Intake.PolCPPApproved);
            Worksheet.Cells.Replace("$$$PolicyOtherNote$$$", IntakeForm.Intake.PolOtherNotes);

            Worksheet.Cells.Replace("$$$EmploymentWereEmployed$$$", IntakeForm.Intake.EILWereEmployed);
            Worksheet.Cells.Replace("$$$EmploymentEmployed4Weeks$$$", IntakeForm.Intake.EILEmployed4Weeks);
            Worksheet.Cells.Replace("$$$EmploymentEmployed52Weeks$$$", IntakeForm.Intake.EILEmployed52Weeks);
            Worksheet.Cells.Replace("$$$EmploymentT4Employee$$$", IntakeForm.Intake.EILT4Employee);
            Worksheet.Cells.Replace("$$$EmploymentT4CompanyName$$$", IntakeForm.Intake.EILT4Company);
            Worksheet.Cells.Replace("$$$EmploymentCollectingEmploymentInsurance$$$", IntakeForm.Intake.EILCollecInsurance);
            Worksheet.Cells.Replace("$$$EmploymentGrossEarning$$$", IntakeForm.Intake.EILEmployeeGrossEarning);
            Worksheet.Cells.Replace("$$$EmploymentTimeBeingEmployed$$$", IntakeForm.Intake.EILHowLongEmployee);
            Worksheet.Cells.Replace("$$$EmploymentJobTitle$$$", IntakeForm.Intake.EILJobTitle);
            Worksheet.Cells.Replace("$$$EmploymentJobResponsabilities$$$", IntakeForm.Intake.EILExplainJob);
            Worksheet.Cells.Replace("$$$EmploymentSelfEmployed$$$", IntakeForm.Intake.EILWereSelfEmployed);
            Worksheet.Cells.Replace("$$$EmploymentSelfEmployedBusinessName$$$", IntakeForm.Intake.EILSelfBusinessName);
            Worksheet.Cells.Replace("$$$EmploymentSelfEmployedGrossEarning$$$", IntakeForm.Intake.EILSelfGrossEarning);
            Worksheet.Cells.Replace("$$$EmploymentSelfEmployedTimeOperating$$$", IntakeForm.Intake.EILHowLongBusiness);
            Worksheet.Cells.Replace("$$$EmploymentNotes$$$", IntakeForm.Intake.EILNotes);

            Worksheet.Cells.Replace("$$$DamagesHitPartVehicleOrConcrete$$$", IntakeForm.Intake.DamHitVehicleConcrete);
            Worksheet.Cells.Replace("$$$DamagesWentToHospital$$$", IntakeForm.Intake.DamHeadInjuries);
            Worksheet.Cells.Replace("$$$DamagesHeadInjuries$$$", IntakeForm.Intake.DamHeadInjuries);
            Worksheet.Cells.Replace("$$$DamagesUpperBodyInjuries$$$", IntakeForm.Intake.DamUpperBodyInjuries);
            Worksheet.Cells.Replace("$$$DamagesLowerBodyInjuries$$$", IntakeForm.Intake.DamLowerBodyInjuries);
            Worksheet.Cells.Replace("$$$DamagesPsychologicalEffect$$$", IntakeForm.Intake.DamPsychologicalEffect);
            Worksheet.Cells.Replace("$$$DamagesBeenPrescribedMedication$$$", IntakeForm.Intake.DamPrescribed);
            Worksheet.Cells.Replace("$$$DamagesSeeingAnyOther$$$", IntakeForm.Intake.DamWereSeeingDoctor);
            Worksheet.Cells.Replace("$$$DamagesPreviousAccident$$$", IntakeForm.Intake.DamPreAccident);
            Worksheet.Cells.Replace("$$$DamagesAnyOtherIllness$$$", IntakeForm.Intake.DamPreIllness);
            Worksheet.Cells.Replace("$$$DamagesNotes$$$", IntakeForm.Intake.DamNotes);

            Worksheet.Cells.Replace("$$$ABDriverPassenger$$$", IntakeForm.Intake.AccBenDriverPassenger);
            Worksheet.Cells.Replace("$$$ABWereRegisteredOwner$$$", IntakeForm.Intake.AccBenWereRegisOwner);
            Worksheet.Cells.Replace("$$$ABRegisteredOwnerName$$$", IntakeForm.Intake.AccBenRegisOwnerName);
            Worksheet.Cells.Replace("$$$ABPolicyNumber$$$", IntakeForm.Intake.AccBenPolicyNumber);
            Worksheet.Cells.Replace("$$$ABClaimNumber$$$", IntakeForm.Intake.AccBenClaimNumber);
            Worksheet.Cells.Replace("$$$ABInsuranceCompany$$$", IntakeForm.Intake.AccBenInsuranceCompany);
            Worksheet.Cells.Replace("$$$ABDealingSpecificAdjuster$$$", IntakeForm.Intake.AccBenAdjuster);
            Worksheet.Cells.Replace("$$$ABCompletedOCF1$$$", IntakeForm.Intake.AccBenOCF1);
            Worksheet.Cells.Replace("$$$ABCompletedOCF2$$$", IntakeForm.Intake.AccBenOCF2);
            Worksheet.Cells.Replace("$$$ABCompletedOCF3$$$", IntakeForm.Intake.AccBenOCF3);
            Worksheet.Cells.Replace("$$$ABReceivingBenefits$$$", IntakeForm.Intake.AccBenReplacBenef);
            Worksheet.Cells.Replace("$$$ABNotes$$$", IntakeForm.Intake.AccBenNotes);

            Worksheet.Cells.Replace("$$$OtherNotes$$$", IntakeForm.Intake.Notes);
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
