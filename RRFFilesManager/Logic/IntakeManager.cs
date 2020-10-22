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
    public class IntakeManager
    {
        public static int GetNewFileNumber(Lawyer lawyer)
        {
            if (lawyer == null)
                return 999999999;
            var lastFileNumber = Program.DBContext.Intakes.OrderByDescending(s => s.ID).FirstOrDefault()?.FileNumber;
            if(lastFileNumber == null)
                return int.Parse($"{DateTime.Now.Year}{lawyer.NumberID?.ToString() ?? ""}001");
            var lastNumber = int.Parse(lastFileNumber.ToString()?.Substring(6, 3));
            var newNumber = (lastNumber + 1).ToString().PadLeft(3, '0');
            return int.Parse($"{DateTime.Now.Year}{lawyer.NumberID?.ToString() ?? ""}{newNumber}");
        }
        public static string GetFilePath(string fileName)
        {
            if (fileName == null)
                return null;
            return Path.Combine(ConfigurationManager.AppSettings["ExcelTemplatesPath"], fileName);
        }
        private static string CreateAndFillTemplateDocument(string templatePath, Intake intake, string fileName = null)
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var document = wordApp?.Documents.Open(templatePath);
            var filePath = GetFilePath(fileName ?? $"CYACorrespondence{DateTime.Now:Mdyhhmmss}.doc");
            wordApp.Visible = false;
            Word.ReplaceAll(document, "$$$TodaysDate$$$", DateTime.Now.ToString("MMMM d, yyyy"));
            Word.ReplaceAll(document, "$$$FirstName$$$", intake.Client?.FirstName);
            Word.ReplaceAll(document, "$$$LastName$$$", intake.Client?.LastName);
            Word.ReplaceAll(document, "$$$Address1$$$", intake.Client?.Address);
            Word.ReplaceAll(document, "$$$Address2$$$", "");
            Word.ReplaceAll(document, "$$$City$$$", intake.Client?.City);
            Word.ReplaceAll(document, "$$$Province$$$", intake.Client?.Province?.Description);
            Word.ReplaceAll(document, "$$$PostalCode$$$", intake.Client?.PostalCode);
            Word.ReplaceAll(document, "$$$Salutation$$$", intake.Client?.Salutation);
            Word.ReplaceAll(document, "$$$E-mail$$$", intake.Client?.Email);
            Word.ReplaceAll(document, "$$$DateOfLoss$$$", intake.DateOFLoss.ToString("MMMM d, yyyy"));
            while (document.Content.Find.Execute(FindText: "  ", Wrap: WdFindWrap.wdFindContinue))
            {
                Word.ReplaceAll(document, "  ", " ");
            }

            document.SaveAs(filePath);
            document.Close();
            wordApp.Quit();
            return filePath;
        }


        private static string CreateAndFillTemplateWorkbook(string templatePath, Intake intake, string fileName = null)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            var workbook = excelApp?.Workbooks?.Open(templatePath);
            Worksheet worksheet = (Worksheet)workbook.Sheets[1];
            Excel.ReplaceAll(worksheet, "$$$FileNumber$$$", intake.FileNumber);
            Excel.ReplaceAll(worksheet, "$$$DateOfCall$$$", intake.DateOfCall);
            Excel.ReplaceAll(worksheet, "$$$DateOfLoss$$$", intake.DateOFLoss);
            Excel.ReplaceAll(worksheet, "$$$StaffInterviewer$$$", intake.StaffInterviewer?.Description);
            Excel.ReplaceAll(worksheet, "$$$HearAboutUs$$$", intake.HowHear?.Description);
            Excel.ReplaceAll(worksheet, "$$$FileLawyer$$$", intake.FileLawyer?.Description);
            Excel.ReplaceAll(worksheet, "$$$ResponsibleLawyer$$$", intake.ResponsibleLawyer?.Description);
            Excel.ReplaceAll(worksheet, "$$$MatterSubType$$$", intake.MatterSubType?.Description);
            Excel.ReplaceAll(worksheet, "$$$LimitationPeriod$$$", intake.LimitationPeriod);
            Excel.ReplaceAll(worksheet, "$$$StatutoryNotice$$$", intake.StatutoryNotice);
            Excel.ReplaceAll(worksheet, "$$$AdditionalNotes$$$", intake.AdditionalNotes);
            Excel.ReplaceAll(worksheet, "$$$TodaysDate$$$", DateTime.Now);
            Excel.ReplaceAll(worksheet, "$$$FirstName$$$", intake.Client?.FirstName);
            Excel.ReplaceAll(worksheet, "$$$LastName$$$", intake.Client?.LastName);
            Excel.ReplaceAll(worksheet, "$$$Address1$$$", intake.Client?.Address);
            Excel.ReplaceAll(worksheet, "$$$Address2$$$", "");
            Excel.ReplaceAll(worksheet, "$$$City$$$", intake.Client?.City);
            Excel.ReplaceAll(worksheet, "$$$Province$$$", intake.Client?.Province?.Description);
            Excel.ReplaceAll(worksheet, "$$$PostalCode$$$", intake.Client?.PostalCode);
            Excel.ReplaceAll(worksheet, "$$$Salutation$$$", intake.Client?.Salutation);
            Excel.ReplaceAll(worksheet, "$$$E-mail$$$", intake.Client?.Email);
            Excel.ReplaceAll(worksheet, "$$$HomeNumber$$$", intake.Client?.HomeNumber);
            Excel.ReplaceAll(worksheet, "$$$WorkNumber$$$", intake.Client?.WorkNumber);
            Excel.ReplaceAll(worksheet, "$$$MobileNumber$$$", intake.Client?.MobileNumber);
            Excel.ReplaceAll(worksheet, "$$$MobileCarrier$$$", intake.Client?.MobileCarrier);
            Excel.ReplaceAll(worksheet, "$$$EmailToText$$$", intake.Client?.EmailToText);
            Excel.ReplaceAll(worksheet, "$$$DateOfBirth$$$", intake.Client?.DateOfBirth);
            Excel.ReplaceAll(worksheet, "$$$OtherNotes$$$", intake.Client?.OtherNotes);

            Excel.ReplaceAll(worksheet, "$$$LiabilityDate$$$", intake.LiaDate);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMVR$$$", intake.LiaMVR);
            Excel.ReplaceAll(worksheet, "$$$LiabilityRC$$$", intake.LiaReportCollision);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMVC$$$", intake.LiaMVCExchange);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOtherDocuments$$$", intake.LiaOtherDoc);
            Excel.ReplaceAll(worksheet, "$$$LiabilityWhere$$$", intake.LiaWhereAccident);
            Excel.ReplaceAll(worksheet, "$$$LiabilityExplanation$$$", intake.LiaExplain);
            Excel.ReplaceAll(worksheet, "$$$LiabilityHavePhotos$$$", intake.LiaHavePhotos);
            Excel.ReplaceAll(worksheet, "$$$LiabilityDamageEstimation$$$", intake.LiaEstimDamage);
            Excel.ReplaceAll(worksheet, "$$$LiabilityYourFault$$$", intake.LiaYourFault);
            Excel.ReplaceAll(worksheet, "$$$LiabilityDriverName$$$", intake.LiaDriverName);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOwnerName$$$", intake.LiaOwnerName);
            Excel.ReplaceAll(worksheet, "$$$LiabilityInsuranceCompany$$$", intake.LiaInsuranceCo);
            Excel.ReplaceAll(worksheet, "$$$LiabilityCopyReport$$$", intake.LiaHaveCopy);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOwnNegligence$$$", intake.LiaOwnNegligence);
            Excel.ReplaceAll(worksheet, "$$$LiabilityFaultPerson$$$", intake.LiaFaultPerson);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMunicipalityName$$$", intake.LiaMunicipality);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMunicipalityNoticedy$$$", intake.LiaNotifiedMunicipality);
            Excel.ReplaceAll(worksheet, "$$$LiabilityNotes$$$", intake.LiaNotes);

            Excel.ReplaceAll(worksheet, "$$$LiabilityDate$$$", intake.LiaDate.ToString("MMMM d, yyyy"));
            Excel.ReplaceAll(worksheet, "$$$LiabilityMVR$$$", intake.LiaMVR);
            Excel.ReplaceAll(worksheet, "$$$LiabilityRC$$$", intake.LiaReportCollision);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMVC$$$", intake.LiaMVCExchange);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOtherDocuments$$$", intake.LiaOtherDoc);
            Excel.ReplaceAll(worksheet, "$$$LiabilityWhere$$$", intake.LiaWhereAccident);
            Excel.ReplaceAll(worksheet, "$$$LiabilityExplanation$$$", intake.LiaExplain);
            Excel.ReplaceAll(worksheet, "$$$LiabilityHavePhotos$$$", intake.LiaHavePhotos);
            Excel.ReplaceAll(worksheet, "$$$LiabilityDamageEstimation$$$", intake.LiaEstimDamage);
            Excel.ReplaceAll(worksheet, "$$$LiabilityYourFault$$$", intake.LiaYourFault);
            Excel.ReplaceAll(worksheet, "$$$LiabilityDriverName$$$", intake.LiaDriverName);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOwnerName$$$", intake.LiaOwnerName);
            Excel.ReplaceAll(worksheet, "$$$LiabilityInsuranceCompany$$$", intake.LiaInsuranceCo);
            Excel.ReplaceAll(worksheet, "$$$LiabilityCopyReport$$$", intake.LiaHaveCopy);
            Excel.ReplaceAll(worksheet, "$$$LiabilityOwnNegligence$$$", intake.LiaOwnNegligence);
            Excel.ReplaceAll(worksheet, "$$$LiabilityFaultPerson$$$", intake.LiaFaultPerson);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMunicipalityName$$$", intake.LiaMunicipality);
            Excel.ReplaceAll(worksheet, "$$$LiabilityMunicipalityNoticedy$$$", intake.LiaNotifiedMunicipality);
            Excel.ReplaceAll(worksheet, "$$$LiabilityNotes$$$", intake.LiaNotes);


            Excel.ReplaceAll(worksheet, "$$$PolicySickBenefits$$$", intake.PolSickBenefits);
            Excel.ReplaceAll(worksheet, "$$$PolicyWhoPaidBenefits$$$", intake.PolWhoPaidBenefits);
            Excel.ReplaceAll(worksheet, "$$$PolicyDateLostBenefits$$$", intake.PolDateLostBenefits.ToString("MMMM d, yyyy"));
            Excel.ReplaceAll(worksheet, "$$$PolicyDeniedSTPorLTD$$$", intake.PolDeniedSTPorLTD);
            Excel.ReplaceAll(worksheet, "$$$PolicyHowMuchBeingPaid$$$", intake.PolHowMuchBeingPaid);
            Excel.ReplaceAll(worksheet, "$$$PolicyCompanyDeniedBenefits$$$", intake.PolCompanyDeniedBenefits?.Description);
            Excel.ReplaceAll(worksheet, "$$$PolicyLTDPrivateOrEmployerGroup$$$", intake.PolLTDPrivateOrEmployerGroup);
            Excel.ReplaceAll(worksheet, "$$$PolicyDateSubmittedLTD$$$", intake.PolDateSubmittedLTD.ToString("MMMM d, yyyy"));
            Excel.ReplaceAll(worksheet, "$$$PolicyDateStartedCollLTD$$$", intake.PolDateStartedCollLTD.ToString("MMMM d, yyyy"));
            Excel.ReplaceAll(worksheet, "$$$PolicyDateLastDayLTD$$$", intake.PolDateLastDayLTD.ToString("MMMM d, yyyy"));
            Excel.ReplaceAll(worksheet, "$$$PolicyFirstTimeLTDApproved$$$", intake.PolFirstTimeLTDApproved);
            Excel.ReplaceAll(worksheet, "$$$PolicyReasonTerminateLTD$$$", intake.PolReasonTerminateLTD);
            Excel.ReplaceAll(worksheet, "$$$PolicyApplicationForCPP$$$", intake.PolApplicationForCPP);
            Excel.ReplaceAll(worksheet, "$$$PolicyCPPOwnOrCompany$$$", intake.PolCPPOwnOrCompany);
            Excel.ReplaceAll(worksheet, "$$$PolicyCPPApproved$$$", intake.PolCPPApproved);
            Excel.ReplaceAll(worksheet, "$$$PolicyOtherNote$$$", intake.PolOtherNotes);

            Excel.ReplaceAll(worksheet, "$$$EmploymentWereEmployed$$$", intake.EILWereEmployed);
            Excel.ReplaceAll(worksheet, "$$$EmploymentEmployed4Weeks$$$", intake.EILEmployed4Weeks);
            Excel.ReplaceAll(worksheet, "$$$EmploymentEmployed52Weeks$$$", intake.EILEmployed52Weeks);
            Excel.ReplaceAll(worksheet, "$$$EmploymentT4Employee$$$", intake.EILT4Employee);
            Excel.ReplaceAll(worksheet, "$$$EmploymentT4CompanyName$$$", intake.EILT4Company);
            Excel.ReplaceAll(worksheet, "$$$EmploymentCollectingEmploymentInsurance$$$", intake.EILCollecInsurance);
            Excel.ReplaceAll(worksheet, "$$$EmploymentGrossEarning$$$", intake.EILEmployeeGrossEarning);
            Excel.ReplaceAll(worksheet, "$$$EmploymentTimeBeingEmployed$$$", intake.EILHowLongEmployee);
            Excel.ReplaceAll(worksheet, "$$$EmploymentJobTitle$$$", intake.EILJobTitle);
            Excel.ReplaceAll(worksheet, "$$$EmploymentJobResponsabilities$$$", intake.EILExplainJob);
            Excel.ReplaceAll(worksheet, "$$$EmploymentSelfEmployed$$$", intake.EILWereSelfEmployed);
            Excel.ReplaceAll(worksheet, "$$$EmploymentSelfEmployedBusinessName$$$", intake.EILSelfBusinessName);
            Excel.ReplaceAll(worksheet, "$$$EmploymentSelfEmployedGrossEarning$$$", intake.EILSelfGrossEarning);
            Excel.ReplaceAll(worksheet, "$$$EmploymentSelfEmployedTimeOperating$$$", intake.EILHowLongBusiness);
            Excel.ReplaceAll(worksheet, "$$$EmploymentNotes$$$", intake.EILNotes);

            Excel.ReplaceAll(worksheet, "$$$DamagesHitPartVehicleOrConcrete$$$", intake.DamHitVehicleConcrete);
            Excel.ReplaceAll(worksheet, "$$$DamagesWentToHospital$$$", intake.DamHeadInjuries);
            Excel.ReplaceAll(worksheet, "$$$DamagesHeadInjuries$$$", intake.DamHeadInjuries);
            Excel.ReplaceAll(worksheet, "$$$DamagesUpperBodyInjuries$$$", intake.DamUpperBodyInjuries);
            Excel.ReplaceAll(worksheet, "$$$DamagesLowerBodyInjuries$$$", intake.DamLowerBodyInjuries);
            Excel.ReplaceAll(worksheet, "$$$DamagesPsychologicalEffect$$$", intake.DamPsychologicalEffect);
            Excel.ReplaceAll(worksheet, "$$$DamagesBeenPrescribedMedication$$$", intake.DamPrescribed);
            Excel.ReplaceAll(worksheet, "$$$DamagesSeeingAnyOther$$$", intake.DamWereSeeingDoctor);
            Excel.ReplaceAll(worksheet, "$$$DamagesPreviousAccident$$$", intake.DamPreAccident);
            Excel.ReplaceAll(worksheet, "$$$DamagesAnyOtherIllness$$$", intake.DamPreIllness);
            Excel.ReplaceAll(worksheet, "$$$DamagesNotes$$$", intake.DamNotes);

            Excel.ReplaceAll(worksheet, "$$$ABDriverPassenger$$$", intake.AccBenDriverPassenger);
            Excel.ReplaceAll(worksheet, "$$$ABWereRegisteredOwner$$$", intake.AccBenWereRegisOwner);
            Excel.ReplaceAll(worksheet, "$$$ABRegisteredOwnerName$$$", intake.AccBenRegisOwnerName);
            Excel.ReplaceAll(worksheet, "$$$ABPolicyNumber$$$", intake.AccBenPolicyNumber);
            Excel.ReplaceAll(worksheet, "$$$ABClaimNumber$$$", intake.AccBenClaimNumber);
            Excel.ReplaceAll(worksheet, "$$$ABInsuranceCompany$$$", intake.AccBenInsuranceCompany);
            Excel.ReplaceAll(worksheet, "$$$ABDealingSpecificAdjuster$$$", intake.AccBenAdjuster);
            Excel.ReplaceAll(worksheet, "$$$ABCompletedOCF1$$$", intake.AccBenOCF1);
            Excel.ReplaceAll(worksheet, "$$$ABCompletedOCF2$$$", intake.AccBenOCF2);
            Excel.ReplaceAll(worksheet, "$$$ABCompletedOCF3$$$", intake.AccBenOCF3);
            Excel.ReplaceAll(worksheet, "$$$ABReceivingBenefits$$$", intake.AccBenReplacBenef);
            Excel.ReplaceAll(worksheet, "$$$ABNotes$$$", intake.AccBenNotes);

            Excel.ReplaceAll(worksheet, "$$$OtherNotes$$$", intake.Notes);
            string filePath = GetFilePath(fileName ?? $"MVAIntakeReport{DateTime.Now:Mdyhhmmss}.xlsx");
            workbook.SaveAs(Filename: filePath);
            workbook.Close();
            excelApp.Quit();
            return filePath;
        }

        public static string CreateIntakeWorkbook(Intake intake, string fileName = null)
        {
            string templateExcelPath = Path.Combine(ConfigurationManager.AppSettings["ExcelTemplatesPath"], $"{intake.MatterType.Description}.xlsx");
            return CreateAndFillTemplateWorkbook(templateExcelPath, intake, !string.IsNullOrWhiteSpace(fileName)? fileName : null);
        }
        public static string CreateCYADocument(string templateDocumentPath, Intake intake, string fileName = null)
        {
            string wordTemplatesPathSetting = ConfigurationManager.AppSettings["WordTemplatesPath"];

            if (!string.IsNullOrWhiteSpace(wordTemplatesPathSetting))
                templateDocumentPath = templateDocumentPath.Replace(@"\\FS\FOISY\!", wordTemplatesPathSetting);

            return CreateAndFillTemplateDocument(templateDocumentPath, intake, !string.IsNullOrWhiteSpace(fileName) ? fileName : null);
        }
        public static void SaveIntakeDocumentFileName(Intake intake, string wordFileName)
        {
            var trxIntake = Program.DBContext.Intakes.FirstOrDefault(s => s.ID == intake.ID);
            trxIntake.WordFile = wordFileName;
            Program.DBContext.SaveChanges();
        }

        public static void SaveIntakeWorkBookFileName(Intake intake, string excelFileName)
        {
            var trxIntake = Program.DBContext.Intakes.FirstOrDefault(s => s.ID == intake.ID);
            trxIntake.ExcelFile = excelFileName;
            Program.DBContext.SaveChanges();
        }

        public static string CreateOrRefillIntakeDocument(Intake intake, string templateDocumentPath, bool? refillDocument = null)
        {
            string filePath = GetFilePath(intake.WordFile);
            
            if (string.IsNullOrWhiteSpace(filePath))
            {
                filePath = CreateCYADocument(templateDocumentPath, intake);
                SaveIntakeDocumentFileName(intake, Path.GetFileName(filePath));
            }
            else if (refillDocument.Value)
            {
                filePath = CreateCYADocument(templateDocumentPath, intake, Path.GetFileName(filePath));
            }
            return filePath;
        }

        public static string CreateOrRefillIntakeWorkBook(Intake intake, bool? refillDocument = null)
        {
            string filePath = GetFilePath(intake.ExcelFile);
            
            if (string.IsNullOrWhiteSpace(filePath))
            {
                filePath = CreateIntakeWorkbook(intake);
                SaveIntakeWorkBookFileName(intake, Path.GetFileName(filePath));
            }
            else if (refillDocument.Value)
            {
                var fileName = Path.GetFileName(filePath);
                filePath = CreateIntakeWorkbook(intake, fileName);
            }
            return filePath;
        }
    }
}
