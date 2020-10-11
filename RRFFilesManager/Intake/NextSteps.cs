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

namespace RRFFilesManager.Intake
{
    public partial class NextSteps : UserControl
    {
        public NextSteps()
        {
            InitializeComponent();
        }
        private static NextSteps instance;
        public static NextSteps Instance => instance ?? (instance = new NextSteps());
        private void InvokeCYP_CheckedChanged(object sender, EventArgs e)
        {
            MVATemplatesGroupBox.Visible = this.InvokeCYP.Checked;
            Submit.Visible = this.InvokeCYP.Checked;
        }

        private void TypeTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TemplateName.Text = "";
            this.TemplateName.Items.Clear();
            var Items = this.ActionLogDBDataSet.CYATemplates.Where(s => s.MatterType == PreliminaryInfo.Instance.MatterTypeComboBox.Text && s.TypeOfTemplate == TypeTemplate.Text).Select(s => s.TemplateName);
            this.TemplateName.Items.AddRange(Items.ToArray());
        }

        private void NextSteps_Load(object sender, EventArgs e)
        {
            CyaTemplatesTableAdapter.Fill(ActionLogDBDataSet.CYATemplates);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            this.IntakesBindingSource.EndEdit();
            this.IntakesTableAdapter.Update(this.ActionLogDBDataSet.Intakes);
            PreliminaryInfo.Instance.TextBox1.Text = PreliminaryInfo.Instance.MatterTypeComboBox.Text;

            // If Me.MVAInvokeCIP.Checked = True Then 
            string attachmentPath = "";
            string attachmentPath2 = "";
            if (((this.InvokeCIP.Checked) == (true)))
            {
                // CreateSendItem("rojascarlos82@hotmail.com",attachmentPath)
                this.CreateSendItem("DManzano@InjuryLawyerCanada.com", attachmentPath);
                this.CreateSendItem("RFoisy@InjuryLawyerCanada.com", attachmentPath);
            }

            if (((this.InvokeCYP.Checked) == (true)))
            {
                Intake.Instance.Hide();
                PleaseWait.Instance.Show();
                var CYATemplate = ActionLogDBDataSet.CYATemplates.FirstOrDefault(s => ((((s.MatterType ?? "") == (PreliminaryInfo.Instance.MatterTypeComboBox.Text ?? "")) & ((s.TypeOfTemplate ?? "") == (this.TypeTemplate.Text ?? ""))) & ((s.TemplateName ?? "") == (this.TemplateName.Text ?? ""))));
                string templateDocumentPath = CYATemplate.TemplatePath.Replace(@"\\FS\FOISY\!", @"C:\");
                attachmentPath = this.CreateAndFillTemplateDocument(templateDocumentPath);
                string templateExcelPath = ((@"C:\test\IntakeReportTemplates\" + PreliminaryInfo.Instance.MatterTypeComboBox.Text) + ".xlsx");
                attachmentPath2 = this.CreateAndFillTemplateWoorkbook(templateExcelPath);
                string nameSt = ((PotentialClientInfo.Instance.PCILastName.Text + ", ") + PotentialClientInfo.Instance.PCIFirstName.Text);
                string signa = PreliminaryInfo.Instance.StaffInterviewerComboBox.Text;
                string receip = "rojascarlos82@hotmail.com";
                this.CreateSendItemCYA(signa, nameSt, receip, attachmentPath, attachmentPath2);
                PleaseWait.Instance.Hide();
                
            }
        }

        public void CreateSendItem(string receip, string attachmentPath)
        {
            Microsoft.Office.Interop.Outlook.MailItem OutlookMessage;
            var AppOutlook = new Microsoft.Office.Interop.Outlook.Application();
            try
            {
                OutlookMessage = (Microsoft.Office.Interop.Outlook.MailItem)AppOutlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
                var Recipents = OutlookMessage.Recipients;
                Recipents.Add(receip);
                OutlookMessage.Subject = "CIP Process Testing";
                OutlookMessage.Body = "CIP Process Testing";
                OutlookMessage.BodyFormat = Microsoft.Office.Interop.Outlook.OlBodyFormat.olFormatHTML;
                if (!string.IsNullOrEmpty(attachmentPath))
                {
                    OutlookMessage.Attachments.Add(attachmentPath);
                }

                OutlookMessage.Display();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail could not be sent");
            }
            finally
            {
                OutlookMessage = null;
                AppOutlook = null;
            }
        }

        public void CreateSendItemCYA(string signat, string nameStrg, string receip, string attachmentPath, string attachmentPath2)
        {
            Microsoft.Office.Interop.Outlook.MailItem OutlookMessage;
            var AppOutlook = new Microsoft.Office.Interop.Outlook.Application();
            // Try
            OutlookMessage = (Microsoft.Office.Interop.Outlook.MailItem)AppOutlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);
            var Recipents = OutlookMessage.Recipients;
            Recipents.Add(receip);
            OutlookMessage.Subject = ("New CYA Process Invoked - " + nameStrg);
            OutlookMessage.HTMLBody = ((@"<p>Hi,</p><br><br>

                                        <p>Please be advised that the following initial intake has been
                                        completed. We will not be taking on this client at this time. Please arrange to
                                        complete the CYA process as indicated by the attached draft CYA correspondence.</p><br><br>

                                        <p>If you have any questions, please see me.</p><br>

                                        <p>Regards,</p><br>

                                        <p>" + signat) + "</p>");
            OutlookMessage.BodyFormat = Microsoft.Office.Interop.Outlook.OlBodyFormat.olFormatHTML;
            if (!string.IsNullOrEmpty(attachmentPath))
            {
                OutlookMessage.Attachments.Add(attachmentPath);
            }

            if (!string.IsNullOrEmpty(attachmentPath2))
            {
                OutlookMessage.Attachments.Add(attachmentPath2);
            }

            OutlookMessage.Display();
            // Catch ex As Exception
            // MessageBox.Show("Mail could not be sent")
            // Finally
            OutlookMessage = null;
            AppOutlook = null;
            // End Try
        }

        private string CreateAndFillTemplateDocument(string templatePath)
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            var document = wordApp?.Documents.Open(templatePath);

            document.Content.Find.Execute(FindText: "$$$TodaysDate$$$", ReplaceWith: DateTime.Now.ToString("MMMM d, yyyy"), Replace: WdReplace.wdReplaceAll);
            document.Content.Find.Execute(FindText: "$$$FirstName$$$", ReplaceWith: PotentialClientInfo.Instance.PCIFirstName.Text, Replace: WdReplace.wdReplaceAll);
            document.Content.Find.Execute(FindText: "$$$LastName$$$", ReplaceWith: PotentialClientInfo.Instance.PCILastName.Text, Replace: WdReplace.wdReplaceAll);
            document.Content.Find.Execute(FindText: "$$$Address1$$$", ReplaceWith: PotentialClientInfo.Instance.PCIAddress.Text, Replace: WdReplace.wdReplaceAll);
            document.Content.Find.Execute(FindText: "$$$Address2$$$", ReplaceWith: "", Replace: WdReplace.wdReplaceAll);
            document.Content.Find.Execute(FindText: "$$$City$$$", ReplaceWith: PotentialClientInfo.Instance.PCICity.Text, Replace: WdReplace.wdReplaceAll);
            document.Content.Find.Execute(FindText: "$$$Province$$$", ReplaceWith: PotentialClientInfo.Instance.PCIProvince.Text, Replace: WdReplace.wdReplaceAll);
            document.Content.Find.Execute(FindText: "$$$PostalCode$$$", ReplaceWith: PotentialClientInfo.Instance.PCIPostalCode.Text, Replace: WdReplace.wdReplaceAll);
            document.Content.Find.Execute(FindText: "$$$Salutation$$$", ReplaceWith: PotentialClientInfo.Instance.PCIPostalCode.Text, Replace: WdReplace.wdReplaceAll);
            document.Content.Find.Execute(FindText: "$$$E-mail$$$", ReplaceWith: PotentialClientInfo.Instance.PCIEmail.Text, Replace: WdReplace.wdReplaceAll);
            document.Content.Find.Execute(FindText: "$$$DateOfLoss$$$", ReplaceWith: PreliminaryInfo.Instance.DateOfLossDateTimePicker.Value.ToString("MMMM d, yyyy"), Replace: WdReplace.wdReplaceAll);
            while (document.Content.Find.Execute(FindText: "  ", Wrap: WdFindWrap.wdFindContinue))
            {
                document.Content.Find.Execute(FindText: "  ", ReplaceWith: " ", Replace: WdReplace.wdReplaceAll);
            }

            string filePath = $"C:\\test\\CYACorrespondence{DateTime.Now:Mdyhhmmss}.doc";
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
            Worksheet.Cells.Replace("$$$FileNumber$$$", PreliminaryInfo.Instance.FileNumberTextBox.Text);
            Worksheet.Cells.Replace("$$$DateOfCall$$$", PreliminaryInfo.Instance.DateOFCallDateTimePicker.Text);
            Worksheet.Cells.Replace("$$$DateOfLoss$$$", PreliminaryInfo.Instance.DateOfLossDateTimePicker.Text);
            Worksheet.Cells.Replace("$$$StaffInterviewer$$$", PreliminaryInfo.Instance.StaffInterviewerComboBox.Text);
            Worksheet.Cells.Replace("$$$HearAboutUs$$$", PreliminaryInfo.Instance.HowHearComboBox.Text);
            Worksheet.Cells.Replace("$$$FileLawyer$$$", PreliminaryInfo.Instance.FileNumberTextBox.Text);
            Worksheet.Cells.Replace("$$$ResponsibleLawyer$$$", PreliminaryInfo.Instance.ResponsibleLawyerComboBox.Text);
            Worksheet.Cells.Replace("$$$MatterSubType$$$", PreliminaryInfo.Instance.MatterSubTypeComboBox.Text);
            Worksheet.Cells.Replace("$$$LimitationPeriod$$$", PreliminaryInfo.Instance.LimitationPeriodTextBox.Text);
            Worksheet.Cells.Replace("$$$StatutoryNotice$$$", PreliminaryInfo.Instance.StatutoryNoticeBox.Text);
            Worksheet.Cells.Replace("$$$AdditionalNotes$$$", PreliminaryInfo.Instance.AdditionalNotesTextBox.Text);
            Worksheet.Cells.Replace("$$$TodaysDate$$$", DateTime.Now.ToString("MMMM d, yyyy"));
            Worksheet.Cells.Replace("$$$FirstName$$$", PotentialClientInfo.Instance.PCIFirstName.Text);
            Worksheet.Cells.Replace("$$$LastName$$$", PotentialClientInfo.Instance.PCILastName.Text);
            Worksheet.Cells.Replace("$$$Address1$$$", PotentialClientInfo.Instance.PCIAddress.Text);
            Worksheet.Cells.Replace("$$$Address2$$$", "");
            Worksheet.Cells.Replace("$$$City$$$", PotentialClientInfo.Instance.PCICity.Text);
            Worksheet.Cells.Replace("$$$Province$$$", PotentialClientInfo.Instance.PCIProvince.Text);
            Worksheet.Cells.Replace("$$$PostalCode$$$", PotentialClientInfo.Instance.PCIPostalCode.Text);
            Worksheet.Cells.Replace("$$$Salutation$$$", PotentialClientInfo.Instance.PCISalutation.Text);
            Worksheet.Cells.Replace("$$$E-mail$$$", PotentialClientInfo.Instance.PCIEmail.Text);
            Worksheet.Cells.Replace("$$$HomeNumber$$$", PotentialClientInfo.Instance.PCIHomeNumber.Text);
            Worksheet.Cells.Replace("$$$WorkNumber$$$", PotentialClientInfo.Instance.PCIWorkNumber.Text);
            Worksheet.Cells.Replace("$$$MobileNumber$$$", PotentialClientInfo.Instance.PCIMobileNumber.Text);
            Worksheet.Cells.Replace("$$$MobileCarrier$$$", PotentialClientInfo.Instance.PCIMobileCarrier.Text);
            Worksheet.Cells.Replace("$$$EmailToText$$$", PotentialClientInfo.Instance.PCIEmailToText.Text);
            Worksheet.Cells.Replace("$$$DateOfBirth$$$", PotentialClientInfo.Instance.PCIDateOfBirth.Value.ToString("MMMM d, yyyy"));
            Worksheet.Cells.Replace("$$$OtherNotes$$$", PotentialClientInfo.Instance.PCIOtherNotes.Text);
            Worksheet.Cells.Replace("$$$LiabilityDate$$$", IntakeSheets.Instance.LiaDate.Text);
            Worksheet.Cells.Replace("$$$LiabilityMVR$$$", IntakeSheets.Instance.LiaMVR.Checked);
            Worksheet.Cells.Replace("$$$LiabilityRC$$$", IntakeSheets.Instance.LiaReportCollision.Checked);
            Worksheet.Cells.Replace("$$$LiabilityMVC$$$", IntakeSheets.Instance.LiaMVR.Checked);
            Worksheet.Cells.Replace("$$$LiabilityOtherDocuments$$$", IntakeSheets.Instance.LiaOtherDoc.Checked);
            Worksheet.Cells.Replace("$$$LiabilityWhere$$$", IntakeSheets.Instance.LiaWhereAccident.Text);
            Worksheet.Cells.Replace("$$$LiabilityExplanation$$$", IntakeSheets.Instance.LiaExplain.Text);
            Worksheet.Cells.Replace("$$$LiabilityHavePhotos$$$", IntakeSheets.Instance.LiaHavePhotos.Text);
            Worksheet.Cells.Replace("$$$LiabilityDamageEstimation$$$", IntakeSheets.Instance.LiaEstimDamage.Text);
            Worksheet.Cells.Replace("$$$LiabilityYourFault$$$", IntakeSheets.Instance.LiaYourFault.Text);
            Worksheet.Cells.Replace("$$$LiabilityDriverName$$$", IntakeSheets.Instance.LiaDriverName.Text);
            Worksheet.Cells.Replace("$$$LiabilityOwnerName$$$", IntakeSheets.Instance.LiaOwnerName.Text);
            Worksheet.Cells.Replace("$$$LiabilityInsuranceCompany$$$", IntakeSheets.Instance.LiaInsuranceCo.Text);
            Worksheet.Cells.Replace("$$$LiabilityCopyReport$$$", IntakeSheets.Instance.LiaHaveCopy.Text);
            Worksheet.Cells.Replace("$$$LiabilityOwnNegligence$$$", IntakeSheets.Instance.LiaOwnNegligence.Text);
            Worksheet.Cells.Replace("$$$LiabilityFaultPerson$$$", IntakeSheets.Instance.LiaFaultPerson.Text);
            Worksheet.Cells.Replace("$$$LiabilityMunicipalityName$$$", IntakeSheets.Instance.LiaMunicipality.Text);
            Worksheet.Cells.Replace("$$$LiabilityMunicipalityNoticedy$$$", IntakeSheets.Instance.LiaNotifiedMunicipality.Text);
            Worksheet.Cells.Replace("$$$LiabilityNotes$$$", IntakeSheets.Instance.LiaNotes.Text);
            Worksheet.Cells.Replace("$$$EmploymentWereEmployed$$$", IntakeSheets.Instance.EILWereEmployed.Text);
            Worksheet.Cells.Replace("$$$EmploymentEmployed4Weeks$$$", IntakeSheets.Instance.EILEmployed4Weeks.Text);
            Worksheet.Cells.Replace("$$$EmploymentEmployed52Weeks$$$", IntakeSheets.Instance.EILEmployed52Weeks.Text);
            Worksheet.Cells.Replace("$$$EmploymentT4Employee$$$", IntakeSheets.Instance.EILT4Employee.Text);
            Worksheet.Cells.Replace("$$$EmploymentT4CompanyName$$$", IntakeSheets.Instance.EILT4Company.Text);
            Worksheet.Cells.Replace("$$$EmploymentCollectingEmploymentInsurance$$$", IntakeSheets.Instance.EILCollecInsurance.Text);
            Worksheet.Cells.Replace("$$$EmploymentGrossEarning$$$", IntakeSheets.Instance.EILEmployeeGrossEarning.Text);
            Worksheet.Cells.Replace("$$$EmploymentTimeBeingEmployed$$$", IntakeSheets.Instance.EILHowLongEmployee.Text);
            Worksheet.Cells.Replace("$$$EmploymentJobTitle$$$", IntakeSheets.Instance.EILJobTitle.Text);
            Worksheet.Cells.Replace("$$$EmploymentJobResponsabilities$$$", IntakeSheets.Instance.EILExplainJob.Text);
            Worksheet.Cells.Replace("$$$EmploymentSelfEmployed$$$", IntakeSheets.Instance.EILWereSelfEmployed.Text);
            Worksheet.Cells.Replace("$$$EmploymentSelfEmployedBusinessName$$$", IntakeSheets.Instance.EILSelfBusinessName.Text);
            Worksheet.Cells.Replace("$$$EmploymentSelfEmployedGrossEarning$$$", IntakeSheets.Instance.EILSelfGrossEarning.Text);
            Worksheet.Cells.Replace("$$$EmploymentSelfEmployedTimeOperating$$$", IntakeSheets.Instance.EILHowLongBusiness.Text);
            Worksheet.Cells.Replace("$$$EmploymentNotes$$$", IntakeSheets.Instance.EILNotes.Text);
            Worksheet.Cells.Replace("$$$DamagesHitPartVehicleOrConcrete$$$", IntakeSheets.Instance.DamHitVehicleConcrete.Text);
            Worksheet.Cells.Replace("$$$DamagesWentToHospital$$$", IntakeSheets.Instance.DamHeadInjuries.Text);
            Worksheet.Cells.Replace("$$$DamagesHeadInjuries$$$", IntakeSheets.Instance.DamHeadInjuries.Text);
            Worksheet.Cells.Replace("$$$DamagesUpperBodyInjuries$$$", IntakeSheets.Instance.DamUpperBodyInjuries.Text);
            Worksheet.Cells.Replace("$$$DamagesLowerBodyInjuries$$$", IntakeSheets.Instance.DamLowerBodyInjuries.Text);
            Worksheet.Cells.Replace("$$$DamagesPsychologicalEffect$$$", IntakeSheets.Instance.DamPsychologicalEffect.Text);
            Worksheet.Cells.Replace("$$$DamagesBeenPrescribedMedication$$$", IntakeSheets.Instance.DamPrescribed.Text);
            Worksheet.Cells.Replace("$$$DamagesSeeingAnyOther$$$", IntakeSheets.Instance.DamWereSeeingDoctor.Text);
            Worksheet.Cells.Replace("$$$DamagesPreviousAccident$$$", IntakeSheets.Instance.DamPreAccident.Text);
            Worksheet.Cells.Replace("$$$DamagesAnyOtherIllness$$$", IntakeSheets.Instance.DamPreIllness.Text);
            Worksheet.Cells.Replace("$$$DamagesNotes$$$", IntakeSheets.Instance.DamNotes.Text);
            Worksheet.Cells.Replace("$$$ABDriverPassenger$$$", IntakeSheets.Instance.AccBenDriverPassenger.Text);
            Worksheet.Cells.Replace("$$$ABWereRegisteredOwner$$$", IntakeSheets.Instance.AccBenWereRegisOwner.Text);
            Worksheet.Cells.Replace("$$$ABRegisteredOwnerName$$$", IntakeSheets.Instance.AccBenRegisOwnerName.Text);
            Worksheet.Cells.Replace("$$$ABPolicyNumber$$$", IntakeSheets.Instance.AccBenPolicyNumber.Text);
            Worksheet.Cells.Replace("$$$ABClaimNumber$$$", IntakeSheets.Instance.AccBenClaimNumber.Text);
            Worksheet.Cells.Replace("$$$ABInsuranceCompany$$$", IntakeSheets.Instance.AccBenInsuranceCompany.Text);
            Worksheet.Cells.Replace("$$$ABDealingSpecificAdjuster$$$", IntakeSheets.Instance.AccBenAdjuster.Text);
            Worksheet.Cells.Replace("$$$ABCompletedOCF1$$$", IntakeSheets.Instance.AccBenOCF1.Text);
            Worksheet.Cells.Replace("$$$ABCompletedOCF2$$$", IntakeSheets.Instance.AccBenOCF2.Text);
            Worksheet.Cells.Replace("$$$ABCompletedOCF3$$$", IntakeSheets.Instance.AccBenOCF3.Text);
            Worksheet.Cells.Replace("$$$ABReceivingBenefits$$$", IntakeSheets.Instance.AccBenReplacBenef.Text);
            Worksheet.Cells.Replace("$$$ABNotes$$$", IntakeSheets.Instance.AccBenNotes.Text);
            Worksheet.Cells.Replace("$$$OtherNotes$$$", IntakeSheets.Instance.Notes.Text);

            // With Worksheet
            // .Range("B4").Value = Me.PreliminaryInfo.Instance.FileNumberTextBox.Text
            // .Range("B5").Value = Me.PreliminaryInfo.Instance.DateOFCallDateTimePicker.Text
            // .Range("B6").Value = Me.PreliminaryInfo.Instance.DateOfLossDateTimePicker.Text
            // .Range("B7").Value = Me.PreliminaryInfo.Instance.StaffInterviewerComboBox.Text
            // .Range("B8").Value = Me.PreliminaryInfo.Instance.HowHearComboBox.Text
            // .Range("B9").Value = Me.PreliminaryInfo.Instance.LawyerComboBox.Text
            // .Range("B10").Value = Me.PreliminaryInfo.Instance.ResponsibleLawyerComboBox.Text
            // .Range("B11").Value = Me.PreliminaryInfo.Instance.MatterSubTypeComboBox.Text
            // .Range("B12").Value = Me.PreliminaryInfo.Instance.LimitationPeriodTextBox.Text
            // .Range("B13").Value = Me.PreliminaryInfo.Instance.StatutoryNoticeBox.Text
            // .Range("B14").Value = Me.PreliminaryInfo.Instance.AdditionalNotesTextBox.Text
            // .Range("B16").Value = Me.PotentialClientInfo.Instance.PCISalutation.Text & " " & PotentialClientInfo.Instance.PCIFirstName.Text & " " & PotentialClientInfo.Instance.PCILastName.Text
            // .Range("B17").Value = Me.PotentialClientInfo.Instance.PCIAddress.Text & " " & PotentialClientInfo.Instance.PCISuiteApt.Text & " " & PotentialClientInfo.Instance.PCICity.Text & " " & PotentialClientInfo.Instance.PCIProvince.Text & " " & PotentialClientInfo.Instance.PCIPostalCode.Text
            // .Range("B18").Value = Me.PotentialClientInfo.Instance.PCIEmail.Text
            // .Range("B19").Value = Me.PotentialClientInfo.Instance.PCIHomeNumber.Text
            // .Range("B20").Value = Me.PotentialClientInfo.Instance.PCIWorkNumber.Text
            // .Range("B21").Value = Me.PotentialClientInfo.Instance.PCIMobileNumber.Text
            // .Range("B22").Value = Me.PotentialClientInfo.Instance.PCIMobileCarrier.Text
            // .Range("B23").Value = Me.PotentialClientInfo.Instance.PCIEmailToText.Text
            // '.Range("B24").Value = Me.PotentialClientInfo.Instance.PCIDateOfBirth.Text
            // .Range("B25").Value = Me.PotentialClientInfo.Instance.PCIOtherNotes.Text
            // .Range("B27").Value = Me.IntakeSheets.Instance.LiaDate.Text
            // If IntakeSheets.Instance.LiaMVR.CheckState <> 0 Then .Range("B28").Value = "Yes"
            // If IntakeSheets.Instance.LiaMVR.CheckState <> 0 Then
            // .Range("D28").Value = "Yes"
            // Else
            // .Range("D28").Value = "No"
            // End If
            // If IntakeSheets.Instance.LiaReportCollision.CheckState <> 0 Then
            // .Range("D28").Value = "Yes"
            // Else
            // .Range("D28").Value = "No"
            // End If
            // If IntakeSheets.Instance.LiaMVCExchange.CheckState <> 0 Then
            // .Range("F28").Value = "Yes"
            // Else
            // .Range("F28").Value = "No"
            // End If
            // If IntakeSheets.Instance.LiaOtherDoc.CheckState <> 0 Then
            // .Range("B29").Value = "Yes"
            // Else
            // .Range("B29").Value = "No"
            // End If
            // .Range("B30").Value = Me.IntakeSheets.Instance.LiaWhereAccident.Text
            // End With
            string filePath = $"C:\\test\\MVAIntakeReport{DateTime.Now:Mdyhhmmss}.xlsx";
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
    }
}
