using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using RRFFilesManager.Abstractions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRFFilesManager.Logic
{
    public class TemplateManager
    {
        public Archive CreateAndFillTemplate(Abstractions.File file, Abstractions.Template template, Archive archive = null)
        {
            if(template == null)
                return CreateAndFillTemplateWorkbook(file, archive);
            return CreateAndFillTemplateDocument(file, template, archive);
        }
        public Archive CreateAndFillTemplateDocument(Abstractions.File file, Abstractions.Template template, Archive archive = null)
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.DisplayAlerts = WdAlertLevel.wdAlertsNone;
            var docuemntTemplatePath = GetDocumentTemplatePath(template.TemplatePath);
            if (!System.IO.File.Exists(docuemntTemplatePath))
                throw new Exception("File not found.");
            var document = wordApp?.Documents.Open(FileName: docuemntTemplatePath, ReadOnly: true);
            var fileName = $"{DateTime.Now:yyyyMMddhhmmss}_{template.TemplateName}.doc";
            var filePath = GetDocumentFilePath(file.FileNumber, fileName);

            wordApp.Visible = false;
            FillDocument(document, file);

            document.SaveAs(filePath);
            document.Close();
            wordApp.Quit();
            if (archive == null)
                archive = new Archive();
            archive.File = file;
            archive.Name = fileName;
            archive.Path = filePath;
            archive.Template = template;
            return archive;
        }

        private void FillDocument(Document document, Abstractions.File file)
        {
            Word.ReplaceAll(document, "$$$TodaysDate$$$", DateTime.Now.ToString("MMMM d, yyyy"));
            Word.ReplaceAll(document, "$$$FirstName$$$", file.Client?.FirstName);
            Word.ReplaceAll(document, "$$$LastName$$$", file.Client?.LastName);
            Word.ReplaceAll(document, "$$$Address1$$$", file.Client?.AddressLine1);
            Word.ReplaceAll(document, "$$$Address2$$$", file.Client?.AddressLine2);
            Word.ReplaceAll(document, "$$$City$$$", file.Client?.City);
            Word.ReplaceAll(document, "$$$Province$$$", file.Client?.Province?.Description);
            Word.ReplaceAll(document, "$$$PostalCode$$$", file.Client?.PostalCode);
            Word.ReplaceAll(document, "$$$Salutation$$$", file.Client?.Salutation);
            Word.ReplaceAll(document, "$$$E-mail$$$", file.Client?.Email);
            Word.ReplaceAll(document, "$$$DateOfLoss$$$", file.DateOFLoss.ToString("MMMM d, yyyy"));
            Word.ReplaceAll(document, "$$$FileNumber$$$", file.FileNumber.ToString());
            while (document.Content.Find.Execute(FindText: "  ", Wrap: WdFindWrap.wdFindContinue))
            {
                Word.ReplaceAll(document, "  ", " ");
            }
        }

        public string GetDocumentTemplatePath(string templateDocumentPath)
        {
            if (string.IsNullOrWhiteSpace(templateDocumentPath))
                throw new Exception("File path not found.");
            string wordTemplatesPathSetting = ConfigurationManager.AppSettings["WordTemplatesPath"];

            if (!string.IsNullOrWhiteSpace(wordTemplatesPathSetting))
                templateDocumentPath = templateDocumentPath.Replace(@"\\FS\FOISY\!", wordTemplatesPathSetting);
            return templateDocumentPath;
        }

        public string GetDocumentFilePath(int fileNumber, string fileName)
        {
            if (fileName == null)
                return null;
            var path = Path.Combine(ConfigurationManager.AppSettings["ExcelTemplatesPath"], fileNumber.ToString());
            Directory.CreateDirectory(path);
            return Path.Combine(path, fileName);
        }

        private Archive CreateAndFillTemplateWorkbook(Abstractions.File file, Archive archive = null)
        {
            var templatePath = GetWorkbookFilePath($"{file.MatterType.Description}.xlsx");
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.DisplayAlerts = false;
            var workbook = excelApp?.Workbooks?.Open(templatePath);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];
            FillWorkSheet(worksheet, file);
            var filename = $"{DateTime.Now:yyyyMMddhhmmss}_MVAIntakeReport.xlsx";
            string filePath = GetWorkbookFilePath(filename);
            workbook.SaveAs(Filename: filePath);
            workbook.Close();
            excelApp.Quit();
            if (archive == null)
                archive = new Archive();
            archive.File = file;
            archive.Name = filename;
            archive.Path = filePath;
            return archive;
        }
        public string GetWorkbookFilePath(string fileName)
        {
            if (fileName == null)
                return null;
            return Path.Combine(ConfigurationManager.AppSettings["ExcelTemplatesPath"], fileName);
        }
        private void FillWorkSheet(Worksheet worksheet, Abstractions.File file)
        {
            Excel.ReplaceAll(worksheet, "$$$FileNumber$$$", file.FileNumber);
            Excel.ReplaceAll(worksheet, "$$$DateOfCall$$$", file.DateOfCall);
            Excel.ReplaceAll(worksheet, "$$$DateOfLoss$$$", file.DateOFLoss);
            Excel.ReplaceAll(worksheet, "$$$StaffInterviewer$$$", file.StaffInterviewer?.Description);
            Excel.ReplaceAll(worksheet, "$$$HearAboutUs$$$", file.HowHear?.Description);
            Excel.ReplaceAll(worksheet, "$$$FileLawyer$$$", file.FileLawyer?.Description);
            Excel.ReplaceAll(worksheet, "$$$ResponsibleLawyer$$$", file.ResponsibleLawyer?.Description);
            Excel.ReplaceAll(worksheet, "$$$MatterSubType$$$", file.MatterSubType?.Description);
            Excel.ReplaceAll(worksheet, "$$$LimitationPeriod$$$", file.LimitationPeriod);
            Excel.ReplaceAll(worksheet, "$$$StatutoryNotice$$$", file.StatutoryNotice);
            Excel.ReplaceAll(worksheet, "$$$AdditionalNotes$$$", file.AdditionalNotes);
            Excel.ReplaceAll(worksheet, "$$$TodaysDate$$$", DateTime.Now);
            Excel.ReplaceAll(worksheet, "$$$FirstName$$$", file.Client?.FirstName);
            Excel.ReplaceAll(worksheet, "$$$LastName$$$", file.Client?.LastName);
            Excel.ReplaceAll(worksheet, "$$$Address1$$$", file.Client?.AddressLine1);
            Excel.ReplaceAll(worksheet, "$$$Address2$$$", file.Client?.AddressLine2);
            Excel.ReplaceAll(worksheet, "$$$City$$$", file.Client?.City);
            Excel.ReplaceAll(worksheet, "$$$Province$$$", file.Client?.Province?.Description);
            Excel.ReplaceAll(worksheet, "$$$PostalCode$$$", file.Client?.PostalCode);
            Excel.ReplaceAll(worksheet, "$$$Salutation$$$", file.Client?.Salutation);
            Excel.ReplaceAll(worksheet, "$$$E-mail$$$", file.Client?.Email);
            Excel.ReplaceAll(worksheet, "$$$HomeNumber$$$", file.Client?.HomeNumber);
            Excel.ReplaceAll(worksheet, "$$$WorkNumber$$$", file.Client?.WorkNumber);
            Excel.ReplaceAll(worksheet, "$$$MobileNumber$$$", file.Client?.MobileNumber);
            Excel.ReplaceAll(worksheet, "$$$MobileCarrier$$$", file.Client?.MobileCarrier);
            Excel.ReplaceAll(worksheet, "$$$EmailToText$$$", file.Client?.EmailToText);
            Excel.ReplaceAll(worksheet, "$$$DateOfBirth$$$", file.Client?.DateOfBirth);
            Excel.ReplaceAll(worksheet, "$$$OtherNotes$$$", file.Client?.Notes);

            Excel.ReplaceAll(worksheet, "$$$LiabilityDate$$$", file.Intake.LiaDate);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMVR$$$", file.Intake.LiaMVR);
            Excel.ReplaceAll(worksheet, "$$$LiabilityRC$$$", file.Intake.LiaReportCollision);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMVC$$$", file.Intake.LiaMVCExchange);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOtherDocuments$$$", file.Intake.LiaOtherDoc);
            Excel.ReplaceAll(worksheet, "$$$LiabilityWhere$$$", file.Intake.LiaWhereAccident);
            Excel.ReplaceAll(worksheet, "$$$LiabilityExplanation$$$", file.Intake.LiaExplain);
            Excel.ReplaceAll(worksheet, "$$$LiabilityHavePhotos$$$", file.Intake.LiaHavePhotos);
            Excel.ReplaceAll(worksheet, "$$$LiabilityDamageEstimation$$$", file.Intake.LiaEstimDamage);
            Excel.ReplaceAll(worksheet, "$$$LiabilityYourFault$$$", file.Intake.LiaYourFault);
            Excel.ReplaceAll(worksheet, "$$$LiabilityDriverName$$$", file.Intake.LiaDriverName);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOwnerName$$$", file.Intake.LiaOwnerName);
            Excel.ReplaceAll(worksheet, "$$$LiabilityInsuranceCompany$$$", file.Intake.LiaInsuranceCo);
            Excel.ReplaceAll(worksheet, "$$$LiabilityCopyReport$$$", file.Intake.LiaHaveCopy);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOwnNegligence$$$", file.Intake.LiaOwnNegligence);
            Excel.ReplaceAll(worksheet, "$$$LiabilityFaultPerson$$$", file.Intake.LiaFaultPerson);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMunicipalityName$$$", file.Intake.LiaMunicipality);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMunicipalityNoticedy$$$", file.Intake.LiaNotifiedMunicipality);
            Excel.ReplaceAll(worksheet, "$$$LiabilityNotes$$$", file.Intake.LiaNotes);

            Excel.ReplaceAll(worksheet, "$$$LiabilityDate$$$", file.Intake.LiaDate.ToString("MMMM d, yyyy"));
            Excel.ReplaceAll(worksheet, "$$$LiabilityMVR$$$", file.Intake.LiaMVR);
            Excel.ReplaceAll(worksheet, "$$$LiabilityRC$$$", file.Intake.LiaReportCollision);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMVC$$$", file.Intake.LiaMVCExchange);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOtherDocuments$$$", file.Intake.LiaOtherDoc);
            Excel.ReplaceAll(worksheet, "$$$LiabilityWhere$$$", file.Intake.LiaWhereAccident);
            Excel.ReplaceAll(worksheet, "$$$LiabilityExplanation$$$", file.Intake.LiaExplain);
            Excel.ReplaceAll(worksheet, "$$$LiabilityHavePhotos$$$", file.Intake.LiaHavePhotos);
            Excel.ReplaceAll(worksheet, "$$$LiabilityDamageEstimation$$$", file.Intake.LiaEstimDamage);
            Excel.ReplaceAll(worksheet, "$$$LiabilityYourFault$$$", file.Intake.LiaYourFault);
            Excel.ReplaceAll(worksheet, "$$$LiabilityDriverName$$$", file.Intake.LiaDriverName);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOwnerName$$$", file.Intake.LiaOwnerName);
            Excel.ReplaceAll(worksheet, "$$$LiabilityInsuranceCompany$$$", file.Intake.LiaInsuranceCo);
            Excel.ReplaceAll(worksheet, "$$$LiabilityCopyReport$$$", file.Intake.LiaHaveCopy);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOwnNegligence$$$", file.Intake.LiaOwnNegligence);
            Excel.ReplaceAll(worksheet, "$$$LiabilityFaultPerson$$$", file.Intake.LiaFaultPerson);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMunicipalityName$$$", file.Intake.LiaMunicipality);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMunicipalityNoticedy$$$", file.Intake.LiaNotifiedMunicipality);
            Excel.ReplaceAll(worksheet, "$$$LiabilityNotes$$$", file.Intake.LiaNotes);


            Excel.ReplaceAll(worksheet, "$$$PolicySickBenefits$$$", file.Intake.PolSickBenefits);
            Excel.ReplaceAll(worksheet, "$$$PolicyWhoPaidBenefits$$$", file.Intake.PolWhoPaidBenefits);
            Excel.ReplaceAll(worksheet, "$$$PolicyDateLostBenefits$$$", file.Intake.PolDateLostBenefits.ToString("MMMM d, yyyy"));
            Excel.ReplaceAll(worksheet, "$$$PolicyDeniedSTPorLTD$$$", file.Intake.PolDeniedSTPorLTD);
            Excel.ReplaceAll(worksheet, "$$$PolicyHowMuchBeingPaid$$$", file.Intake.PolHowMuchBeingPaid);
            Excel.ReplaceAll(worksheet, "$$$PolicyCompanyDeniedBenefits$$$", file.Intake.PolCompanyDeniedBenefits?.Description);
            Excel.ReplaceAll(worksheet, "$$$PolicyLTDPrivateOrEmployerGroup$$$", file.Intake.PolLTDPrivateOrEmployerGroup);
            Excel.ReplaceAll(worksheet, "$$$PolicyDateSubmittedLTD$$$", file.Intake.PolDateSubmittedLTD.ToString("MMMM d, yyyy"));
            Excel.ReplaceAll(worksheet, "$$$PolicyDateStartedCollLTD$$$", file.Intake.PolDateStartedCollLTD.ToString("MMMM d, yyyy"));
            Excel.ReplaceAll(worksheet, "$$$PolicyDateLastDayLTD$$$", file.Intake.PolDateLastDayLTD.ToString("MMMM d, yyyy"));
            Excel.ReplaceAll(worksheet, "$$$PolicyFirstTimeLTDApproved$$$", file.Intake.PolFirstTimeLTDApproved);
            Excel.ReplaceAll(worksheet, "$$$PolicyReasonTerminateLTD$$$", file.Intake.PolReasonTerminateLTD);
            Excel.ReplaceAll(worksheet, "$$$PolicyApplicationForCPP$$$", file.Intake.PolApplicationForCPP);
            Excel.ReplaceAll(worksheet, "$$$PolicyCPPOwnOrCompany$$$", file.Intake.PolCPPOwnOrCompany);
            Excel.ReplaceAll(worksheet, "$$$PolicyCPPApproved$$$", file.Intake.PolCPPApproved);
            Excel.ReplaceAll(worksheet, "$$$PolicyOtherNote$$$", file.Intake.PolOtherNotes);

            Excel.ReplaceAll(worksheet, "$$$EmploymentWereEmployed$$$", file.Intake.EILWereEmployed);
            Excel.ReplaceAll(worksheet, "$$$EmploymentEmployed4Weeks$$$", file.Intake.EILEmployed4Weeks);
            Excel.ReplaceAll(worksheet, "$$$EmploymentEmployed52Weeks$$$", file.Intake.EILEmployed52Weeks);
            Excel.ReplaceAll(worksheet, "$$$EmploymentT4Employee$$$", file.Intake.EILT4Employee);
            Excel.ReplaceAll(worksheet, "$$$EmploymentT4CompanyName$$$", file.Intake.EILT4Company);
            Excel.ReplaceAll(worksheet, "$$$EmploymentCollectingEmploymentInsurance$$$", file.Intake.EILCollecInsurance);
            Excel.ReplaceAll(worksheet, "$$$EmploymentGrossEarning$$$", file.Intake.EILEmployeeGrossEarning);
            Excel.ReplaceAll(worksheet, "$$$EmploymentTimeBeingEmployed$$$", file.Intake.EILHowLongEmployee);
            Excel.ReplaceAll(worksheet, "$$$EmploymentJobTitle$$$", file.Intake.EILJobTitle);
            Excel.ReplaceAll(worksheet, "$$$EmploymentJobResponsabilities$$$", file.Intake.EILExplainJob);
            Excel.ReplaceAll(worksheet, "$$$EmploymentSelfEmployed$$$", file.Intake.EILWereSelfEmployed);
            Excel.ReplaceAll(worksheet, "$$$EmploymentSelfEmployedBusinessName$$$", file.Intake.EILSelfBusinessName);
            Excel.ReplaceAll(worksheet, "$$$EmploymentSelfEmployedGrossEarning$$$", file.Intake.EILSelfGrossEarning);
            Excel.ReplaceAll(worksheet, "$$$EmploymentSelfEmployedTimeOperating$$$", file.Intake.EILHowLongBusiness);
            Excel.ReplaceAll(worksheet, "$$$EmploymentNotes$$$", file.Intake.EILNotes);

            Excel.ReplaceAll(worksheet, "$$$DamagesHitPartVehicleOrConcrete$$$", file.Intake.DamHitVehicleConcrete);
            Excel.ReplaceAll(worksheet, "$$$DamagesWentToHospital$$$", file.Intake.DamHeadInjuries);
            Excel.ReplaceAll(worksheet, "$$$DamagesHeadInjuries$$$", file.Intake.DamHeadInjuries);
            Excel.ReplaceAll(worksheet, "$$$DamagesUpperBodyInjuries$$$", file.Intake.DamUpperBodyInjuries);
            Excel.ReplaceAll(worksheet, "$$$DamagesLowerBodyInjuries$$$", file.Intake.DamLowerBodyInjuries);
            Excel.ReplaceAll(worksheet, "$$$DamagesPsychologicalEffect$$$", file.Intake.DamPsychologicalEffect);
            Excel.ReplaceAll(worksheet, "$$$DamagesBeenPrescribedMedication$$$", file.Intake.DamPrescribed);
            Excel.ReplaceAll(worksheet, "$$$DamagesSeeingAnyOther$$$", file.Intake.DamWereSeeingDoctor);
            Excel.ReplaceAll(worksheet, "$$$DamagesPreviousAccident$$$", file.Intake.DamPreAccident);
            Excel.ReplaceAll(worksheet, "$$$DamagesAnyOtherIllness$$$", file.Intake.DamPreIllness);
            Excel.ReplaceAll(worksheet, "$$$DamagesNotes$$$", file.Intake.DamNotes);

            Excel.ReplaceAll(worksheet, "$$$ABDriverPassenger$$$", file.Intake.AccBenDriverPassenger);
            Excel.ReplaceAll(worksheet, "$$$ABWereRegisteredOwner$$$", file.Intake.AccBenWereRegisOwner);
            Excel.ReplaceAll(worksheet, "$$$ABRegisteredOwnerName$$$", file.Intake.AccBenRegisOwnerName);
            Excel.ReplaceAll(worksheet, "$$$ABPolicyNumber$$$", file.Intake.AccBenPolicyNumber);
            Excel.ReplaceAll(worksheet, "$$$ABClaimNumber$$$", file.Intake.AccBenClaimNumber);
            Excel.ReplaceAll(worksheet, "$$$ABInsuranceCompany$$$", file.Intake.AccBenInsuranceCompany);
            Excel.ReplaceAll(worksheet, "$$$ABDealingSpecificAdjuster$$$", file.Intake.AccBenAdjuster);
            Excel.ReplaceAll(worksheet, "$$$ABCompletedOCF1$$$", file.Intake.AccBenOCF1);
            Excel.ReplaceAll(worksheet, "$$$ABCompletedOCF2$$$", file.Intake.AccBenOCF2);
            Excel.ReplaceAll(worksheet, "$$$ABCompletedOCF3$$$", file.Intake.AccBenOCF3);
            Excel.ReplaceAll(worksheet, "$$$ABReceivingBenefits$$$", file.Intake.AccBenReplacBenef);
            Excel.ReplaceAll(worksheet, "$$$ABNotes$$$", file.Intake.AccBenNotes);

            Excel.ReplaceAll(worksheet, "$$$OtherNotes$$$", file.Intake.Notes);
        }
    }
}
