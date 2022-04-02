using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RRFFilesManager.Logic
{
    public class Excel
    {
        public static void Open(string path)
        {
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.DisplayAlerts = false;
            var workbook = excelApp?.Workbooks?.Open(path);
            excelApp.Visible = true;
        }
        public static void ReplaceAll(Worksheet worksheet, string findText, string replaceWith)
        {
            worksheet.Cells.Replace(findText, replaceWith);
        }
        public static void ReplaceAll(Worksheet worksheet, string findText, bool replaceWith)
        {
            worksheet.Cells.Replace(findText, replaceWith ? "Yes" : "No");
        }
        public static void ReplaceAll(Worksheet worksheet, string findText, DateTime? replaceWith)
        {
            worksheet.Cells.Replace(findText, replaceWith?.ToString("MMMM d, yyyy"));
        }
        public static void ReplaceAll(Worksheet worksheet, string findText, int replaceWith)
        {
            worksheet.Cells.Replace(findText, replaceWith.ToString());
        }

        public static void FillWorkSheet(Worksheet worksheet, Abstractions.Archive archive)
        {

        }
        public static void FillWorkSheet(Worksheet worksheet, Abstractions.File file, IEnumerable<Abstractions.Archive> archives = null)
        {
            ReplaceAll(worksheet, "$$$FileNumber$$$", file.FileNumber);
            ReplaceAll(worksheet, "$$$DateOfCall$$$", file.DateOfCall);
            ReplaceAll(worksheet, "$$$DateOfLoss$$$", file.DateOFLoss);
            ReplaceAll(worksheet, "$$$StaffInterviewer$$$", file.StaffInterviewer?.Description);
            ReplaceAll(worksheet, "$$$HearAboutUs$$$", file.HowHear?.Description);
            ReplaceAll(worksheet, "$$$FileLawyer$$$", file.FileLawyer?.Description);
            ReplaceAll(worksheet, "$$$ResponsibleLawyer$$$", file.ResponsibleLawyer?.Description);
            ReplaceAll(worksheet, "$$$MatterSubType$$$", file.MatterSubType?.Description);
            ReplaceAll(worksheet, "$$$LimitationPeriod$$$", file.LimitationPeriod);
            ReplaceAll(worksheet, "$$$StatutoryNotice$$$", file.StatutoryNotice);
            ReplaceAll(worksheet, "$$$AdditionalNotes$$$", file.AdditionalNotes);
            ReplaceAll(worksheet, "$$$TodaysDate$$$", DateTime.Now);
            ReplaceAll(worksheet, "$$$FirstName$$$", file.Client?.FirstName);
            ReplaceAll(worksheet, "$$$LastName$$$", file.Client?.LastName);
            ReplaceAll(worksheet, "$$$Address1$$$", file.Client?.AddressLine1);
            ReplaceAll(worksheet, "$$$Address2$$$", file.Client?.AddressLine2);
            ReplaceAll(worksheet, "$$$City$$$", file.Client?.City);
            ReplaceAll(worksheet, "$$$Province$$$", file.Client?.Province?.Description);
            ReplaceAll(worksheet, "$$$PostalCode$$$", file.Client?.PostalCode);
            ReplaceAll(worksheet, "$$$Salutation$$$", file.Client?.Salutation);
            ReplaceAll(worksheet, "$$$E-mail$$$", file.Client?.Email);
            ReplaceAll(worksheet, "$$$HomeNumber$$$", file.Client?.HomeNumber);
            ReplaceAll(worksheet, "$$$WorkNumber$$$", file.Client?.WorkNumber);
            ReplaceAll(worksheet, "$$$MobileNumber$$$", file.Client?.MobileNumber);
            ReplaceAll(worksheet, "$$$MobileCarrier$$$", file.Client?.MobileCarrier);
            ReplaceAll(worksheet, "$$$EmailToText$$$", file.Client?.EmailToText);
            ReplaceAll(worksheet, "$$$DateOfBirth$$$", file.Client?.DateOfBirth);
            ReplaceAll(worksheet, "$$$OtherNotes$$$", file.Client?.Notes);

            ReplaceAll(worksheet, "$$$LiabilityDate$$$", file.Intake.LiaDate);
            ReplaceAll(worksheet, "$$$LiabilityMVR$$$", file.Intake.LiaMVR);
            ReplaceAll(worksheet, "$$$LiabilityRC$$$", file.Intake.LiaReportCollision);
            ReplaceAll(worksheet, "$$$LiabilityMVC$$$", file.Intake.LiaMVCExchange);
            ReplaceAll(worksheet, "$$$LiabilityOtherDocuments$$$", file.Intake.LiaOtherDoc);
            ReplaceAll(worksheet, "$$$LiabilityWhere$$$", file.Intake.LiaWhereAccident);
            ReplaceAll(worksheet, "$$$LiabilityExplanation$$$", file.Intake.LiaExplain);
            ReplaceAll(worksheet, "$$$LiabilityHavePhotos$$$", file.Intake.LiaHavePhotos);
            ReplaceAll(worksheet, "$$$LiabilityDamageEstimation$$$", file.Intake.LiaEstimDamage);
            ReplaceAll(worksheet, "$$$LiabilityYourFault$$$", file.Intake.LiaYourFault);
            ReplaceAll(worksheet, "$$$LiabilityDriverName$$$", file.Intake.LiaDriverName);
            ReplaceAll(worksheet, "$$$LiabilityOwnerName$$$", file.Intake.LiaOwnerName);
            ReplaceAll(worksheet, "$$$LiabilityInsuranceCompany$$$", file.Intake.LiaInsuranceCo);
            ReplaceAll(worksheet, "$$$LiabilityCopyReport$$$", file.Intake.LiaHaveCopy);
            ReplaceAll(worksheet, "$$$LiabilityOwnNegligence$$$", file.Intake.LiaOwnNegligence);
            ReplaceAll(worksheet, "$$$LiabilityFaultPerson$$$", file.Intake.LiaFaultPerson);
            ReplaceAll(worksheet, "$$$LiabilityMunicipalityName$$$", file.Intake.LiaMunicipality);
            ReplaceAll(worksheet, "$$$LiabilityMunicipalityNoticedy$$$", file.Intake.LiaNotifiedMunicipality);
            ReplaceAll(worksheet, "$$$LiabilityNotes$$$", file.Intake.LiaNotes);

            ReplaceAll(worksheet, "$$$LiabilityDate$$$", file.Intake.LiaDate.ToString("MMMM d, yyyy"));
            ReplaceAll(worksheet, "$$$LiabilityMVR$$$", file.Intake.LiaMVR);
            ReplaceAll(worksheet, "$$$LiabilityRC$$$", file.Intake.LiaReportCollision);
            ReplaceAll(worksheet, "$$$LiabilityMVC$$$", file.Intake.LiaMVCExchange);
            ReplaceAll(worksheet, "$$$LiabilityOtherDocuments$$$", file.Intake.LiaOtherDoc);
            ReplaceAll(worksheet, "$$$LiabilityWhere$$$", file.Intake.LiaWhereAccident);
            ReplaceAll(worksheet, "$$$LiabilityExplanation$$$", file.Intake.LiaExplain);
            ReplaceAll(worksheet, "$$$LiabilityHavePhotos$$$", file.Intake.LiaHavePhotos);
            ReplaceAll(worksheet, "$$$LiabilityDamageEstimation$$$", file.Intake.LiaEstimDamage);
            ReplaceAll(worksheet, "$$$LiabilityYourFault$$$", file.Intake.LiaYourFault);
            ReplaceAll(worksheet, "$$$LiabilityDriverName$$$", file.Intake.LiaDriverName);
            ReplaceAll(worksheet, "$$$LiabilityOwnerName$$$", file.Intake.LiaOwnerName);
            ReplaceAll(worksheet, "$$$LiabilityInsuranceCompany$$$", file.Intake.LiaInsuranceCo);
            ReplaceAll(worksheet, "$$$LiabilityCopyReport$$$", file.Intake.LiaHaveCopy);
            ReplaceAll(worksheet, "$$$LiabilityOwnNegligence$$$", file.Intake.LiaOwnNegligence);
            ReplaceAll(worksheet, "$$$LiabilityFaultPerson$$$", file.Intake.LiaFaultPerson);
            ReplaceAll(worksheet, "$$$LiabilityMunicipalityName$$$", file.Intake.LiaMunicipality);
            ReplaceAll(worksheet, "$$$LiabilityMunicipalityNoticedy$$$", file.Intake.LiaNotifiedMunicipality);
            ReplaceAll(worksheet, "$$$LiabilityNotes$$$", file.Intake.LiaNotes);


            ReplaceAll(worksheet, "$$$PolicySickBenefits$$$", file.Intake.PolSickBenefits);
            ReplaceAll(worksheet, "$$$PolicyWhoPaidBenefits$$$", file.Intake.PolWhoPaidBenefits);
            ReplaceAll(worksheet, "$$$PolicyDateLostBenefits$$$", file.Intake.PolDateLostBenefits.ToString("MMMM d, yyyy"));
            ReplaceAll(worksheet, "$$$PolicyDeniedSTPorLTD$$$", file.Intake.PolDeniedSTPorLTD);
            ReplaceAll(worksheet, "$$$PolicyHowMuchBeingPaid$$$", file.Intake.PolHowMuchBeingPaid);
            ReplaceAll(worksheet, "$$$PolicyCompanyDeniedBenefits$$$", file.Intake.PolCompanyDeniedBenefits?.Description);
            ReplaceAll(worksheet, "$$$PolicyLTDPrivateOrEmployerGroup$$$", file.Intake.PolLTDPrivateOrEmployerGroup);
            ReplaceAll(worksheet, "$$$PolicyDateSubmittedLTD$$$", file.Intake.PolDateSubmittedLTD.ToString("MMMM d, yyyy"));
            ReplaceAll(worksheet, "$$$PolicyDateStartedCollLTD$$$", file.Intake.PolDateStartedCollLTD.ToString("MMMM d, yyyy"));
            ReplaceAll(worksheet, "$$$PolicyDateLastDayLTD$$$", file.Intake.PolDateLastDayLTD.ToString("MMMM d, yyyy"));
            ReplaceAll(worksheet, "$$$PolicyFirstTimeLTDApproved$$$", file.Intake.PolFirstTimeLTDApproved);
            ReplaceAll(worksheet, "$$$PolicyReasonTerminateLTD$$$", file.Intake.PolReasonTerminateLTD);
            ReplaceAll(worksheet, "$$$PolicyApplicationForCPP$$$", file.Intake.PolApplicationForCPP);
            ReplaceAll(worksheet, "$$$PolicyCPPOwnOrCompany$$$", file.Intake.PolCPPOwnOrCompany);
            ReplaceAll(worksheet, "$$$PolicyCPPApproved$$$", file.Intake.PolCPPApproved);
            ReplaceAll(worksheet, "$$$PolicyOtherNote$$$", file.Intake.PolOtherNotes);

            ReplaceAll(worksheet, "$$$EmploymentWereEmployed$$$", file.Intake.EILWereEmployed);
            ReplaceAll(worksheet, "$$$EmploymentEmployed4Weeks$$$", file.Intake.EILEmployed4Weeks);
            ReplaceAll(worksheet, "$$$EmploymentEmployed52Weeks$$$", file.Intake.EILEmployed52Weeks);
            ReplaceAll(worksheet, "$$$EmploymentT4Employee$$$", file.Intake.EILT4Employee);
            ReplaceAll(worksheet, "$$$EmploymentT4CompanyName$$$", file.Intake.EILT4Company);
            ReplaceAll(worksheet, "$$$EmploymentCollectingEmploymentInsurance$$$", file.Intake.EILCollecInsurance);
            ReplaceAll(worksheet, "$$$EmploymentGrossEarning$$$", file.Intake.EILEmployeeGrossEarning);
            ReplaceAll(worksheet, "$$$EmploymentTimeBeingEmployed$$$", file.Intake.EILHowLongEmployee);
            ReplaceAll(worksheet, "$$$EmploymentJobTitle$$$", file.Intake.EILJobTitle);
            ReplaceAll(worksheet, "$$$EmploymentJobResponsabilities$$$", file.Intake.EILExplainJob);
            ReplaceAll(worksheet, "$$$EmploymentSelfEmployed$$$", file.Intake.EILWereSelfEmployed);
            ReplaceAll(worksheet, "$$$EmploymentSelfEmployedBusinessName$$$", file.Intake.EILSelfBusinessName);
            ReplaceAll(worksheet, "$$$EmploymentSelfEmployedGrossEarning$$$", file.Intake.EILSelfGrossEarning);
            ReplaceAll(worksheet, "$$$EmploymentSelfEmployedTimeOperating$$$", file.Intake.EILHowLongBusiness);
            ReplaceAll(worksheet, "$$$EmploymentNotes$$$", file.Intake.EILNotes);

            ReplaceAll(worksheet, "$$$DamagesHitPartVehicleOrConcrete$$$", file.Intake.DamHitVehicleConcrete);
            ReplaceAll(worksheet, "$$$DamagesWentToHospital$$$", file.Intake.DamHeadInjuries);
            ReplaceAll(worksheet, "$$$DamagesHeadInjuries$$$", file.Intake.DamHeadInjuries);
            ReplaceAll(worksheet, "$$$DamagesUpperBodyInjuries$$$", file.Intake.DamUpperBodyInjuries);
            ReplaceAll(worksheet, "$$$DamagesLowerBodyInjuries$$$", file.Intake.DamLowerBodyInjuries);
            ReplaceAll(worksheet, "$$$DamagesPsychologicalEffect$$$", file.Intake.DamPsychologicalEffect);
            ReplaceAll(worksheet, "$$$DamagesBeenPrescribedMedication$$$", file.Intake.DamPrescribed);
            ReplaceAll(worksheet, "$$$DamagesSeeingAnyOther$$$", file.Intake.DamWereSeeingDoctor);
            ReplaceAll(worksheet, "$$$DamagesPreviousAccident$$$", file.Intake.DamPreAccident);
            ReplaceAll(worksheet, "$$$DamagesAnyOtherIllness$$$", file.Intake.DamPreIllness);
            ReplaceAll(worksheet, "$$$DamagesNotes$$$", file.Intake.DamNotes);

            ReplaceAll(worksheet, "$$$ABDriverPassenger$$$", file.Intake.AccBenDriverPassenger);
            ReplaceAll(worksheet, "$$$ABWereRegisteredOwner$$$", file.Intake.AccBenWereRegisOwner);
            ReplaceAll(worksheet, "$$$ABRegisteredOwnerName$$$", file.Intake.AccBenRegisOwnerName);
            ReplaceAll(worksheet, "$$$ABPolicyNumber$$$", file.Intake.AccBenPolicyNumber);
            ReplaceAll(worksheet, "$$$ABClaimNumber$$$", file.Intake.AccBenClaimNumber);
            ReplaceAll(worksheet, "$$$ABInsuranceCompany$$$", file.Intake.AccBenInsuranceCompany);
            ReplaceAll(worksheet, "$$$ABDealingSpecificAdjuster$$$", file.Intake.AccBenAdjuster);
            ReplaceAll(worksheet, "$$$ABCompletedOCF1$$$", file.Intake.AccBenOCF1);
            ReplaceAll(worksheet, "$$$ABCompletedOCF2$$$", file.Intake.AccBenOCF2);
            ReplaceAll(worksheet, "$$$ABCompletedOCF3$$$", file.Intake.AccBenOCF3);
            ReplaceAll(worksheet, "$$$ABReceivingBenefits$$$", file.Intake.AccBenReplacBenef);
            ReplaceAll(worksheet, "$$$ABNotes$$$", file.Intake.AccBenNotes);

            ReplaceAll(worksheet, "$$$OtherNotes$$$", file.Intake.Notes);

            if (archives != null)
            {
                if (archives.First().StandardBenefitRows.Count > 0)
                {
                    var archive = archives.First();
                    ReplaceAll(worksheet, $"$$$PolicyClaimLimit$$$", archive.PolicyClaimLimit);
                    ReplaceAll(worksheet, $"$$$InsuranceCompany$$$", archive.InsuranceCompany);
                    String _payee, _mrgsaprovided, _datepaid, _statementperiodends, _amount, _ieamount;
                    var rows = archive.StandardBenefitRows.ToList();
                    for (int i = 0; i <= 37; i++)
                    {
                        _payee = _mrgsaprovided = _datepaid = _statementperiodends = _amount = _ieamount = "";
                        if (i <= rows.Count - 1)
                        {
                            _payee = rows[i].Payee;
                            if (_payee.Length > 255)
                            {
                                _payee = _payee.Substring(0, 255);
                            }
                            _mrgsaprovided = rows[i].MRGSAProvided;
                            if (_mrgsaprovided.Length > 255)
                            {
                                _mrgsaprovided = _mrgsaprovided.Substring(0, 255);
                            }
                            _datepaid = rows[i].DatePaid.ToShortDateString();
                            _statementperiodends = archive.StatementPeriodTo.ToShortDateString();
                            _amount = rows[i].Amount.ToString();
                            _ieamount = rows[i].IEAmount.ToString();
                        }
                        ReplaceAll(worksheet, $"$$$Payee$$${i.ToString("D2")}", _payee);
                        ReplaceAll(worksheet, $"$$$MRGSAProvided$$${i.ToString("D2")}", _mrgsaprovided);
                        ReplaceAll(worksheet, $"$$$DatePaid$$${i.ToString("D2")}", _datepaid);
                        ReplaceAll(worksheet, $"$$$StatementPeriodEnds$$${i.ToString("D2")}", _statementperiodends);
                        ReplaceAll(worksheet, $"$$$Amount$$${i.ToString("D2")}", _amount);
                        ReplaceAll(worksheet, $"$$$IEAmount$$${i.ToString("D2")}", _ieamount);

                    }
                }
                else
                {
                    var archiveList = archives.ToList();
                    object[,] arr = new object[(archiveList.Count*2)-1, 9];

                    for (int i = 0, x = 0; i < (archiveList.Count*2)-1; i=i+2, x++)
                    {
                        var archive = archiveList[x];
                        arr[i, 0] = archive.DocumentDate.ToShortDateString();
                        arr[i, 1] = archive.MRACPaidToDate.ToString();
                        arr[i, 2] = archive.ACPaidToDate.ToString();
                        arr[i, 3] = archive.MRPaidToDate.ToString();
                        arr[i, 4] = archive.HHPaidToDate.ToString();
                        arr[i, 5] = archive.IRBPaidToDate.ToString();
                        arr[i, 6] = archive.NonEarnerPdToDate.ToString();
                        arr[i, 7] = archive.CGPaidToDate.ToString();
                        arr[i, 8] = archive.IEAssessPdToDate.ToString();
                        if (i+1 < (archiveList.Count*2)-1)
                            for (int j = 0; j <= 8; j++)
                            {
                                arr[i + 1, j] = "";
                            }
                    }
                    Range c1 = (Range)worksheet.Cells[4, 1];
                    Range c2 = (Range)worksheet.Cells[(archiveList.Count*2) + 2, 9];
                    Range range = worksheet.get_Range(c1, c2);
                    range.Value = arr;
                }
            }
        }
    }
}
