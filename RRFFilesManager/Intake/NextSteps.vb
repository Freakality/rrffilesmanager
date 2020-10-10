Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop.Word

Public Class NextSteps
    Public Property IntakeForm As Intake
    Public ReadOnly Property PreliminaryInfo() As PreliminaryInfo
        Get
            Return IntakeForm.PreliminaryInfo
        End Get
    End Property

    Public ReadOnly Property PotentialClientInfo() As PotentialClientInfo
        Get
            Return IntakeForm.PotentialClientInfo
        End Get
    End Property

    Public ReadOnly Property IntakeSheets() As IntakeSheets
        Get
            Return IntakeForm.IntakeSheets
        End Get
    End Property

    Private Sub InvokeCYP_CheckedChanged(sender As Object, e As EventArgs) Handles InvokeCYP.CheckedChanged
        MVATemplatesGroupBox.Visible = InvokeCYP.Checked
        Submit.Visible = InvokeCYP.Checked
    End Sub

    Private Sub TypeTemplate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeTemplate.SelectedIndexChanged
        TemplateName.Text = ""
        TemplateName.Items.Clear()
        Dim Items = Me.ActionLogDBDataSet.CYATemplates.Where(Function(s)
                                                                 Return s.MatterType = PreliminaryInfo.MatterTypeComboBox.Text And s.TypeOfTemplate = TypeTemplate.Text
                                                             End Function).Select(Function(s) s.TemplateName)

        TemplateName.Items.AddRange(Items.ToArray())
    End Sub

    Private Sub NextSteps_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CyaTemplatesTableAdapter.Fill(Me.ActionLogDBDataSet.CYATemplates)
    End Sub
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        IntakesBindingSource.EndEdit()
        IntakesTableAdapter.Update(ActionLogDBDataSet.Intakes)
        Me.PreliminaryInfo.TextBox1.Text = Me.PreliminaryInfo.MatterTypeComboBox.Text

        'If Me.MVAInvokeCIP.Checked = True Then 
        Dim attachmentPath As String = ""
        Dim attachmentPath2 As String = ""
        If Me.InvokeCIP.Checked = True Then
            'CreateSendItem("rojascarlos82@hotmail.com",attachmentPath)
            CreateSendItem("DManzano@InjuryLawyerCanada.com", attachmentPath)
            CreateSendItem("RFoisy@InjuryLawyerCanada.com", attachmentPath)
        End If

        If Me.InvokeCYP.Checked = True Then
            Me.Hide()
            PleaseWait.Show()
            Dim CYATemplate = ActionLogDBDataSet.CYATemplates.FirstOrDefault(Function(s) s.MatterType = PreliminaryInfo.MatterTypeComboBox.Text And s.TypeOfTemplate = TypeTemplate.Text And s.TemplateName = TemplateName.Text)
            Dim templateDocumentPath = CYATemplate.TemplatePath.Replace("\\FS\FOISY\!", "C:\")
            attachmentPath = CreateAndFillTemplateDocument(templateDocumentPath)
            Dim templateExcelPath = "C:\test\IntakeReportTemplates\" & PreliminaryInfo.MatterTypeComboBox.Text & ".xlsx"
            attachmentPath2 = CreateAndFillTemplateWoorkbook(templateExcelPath)

            Dim nameSt As String = Me.PotentialClientInfo.PCILastName.Text & ", " & Me.PotentialClientInfo.PCIFirstName.Text
            Dim signa As String = Me.PreliminaryInfo.StaffInterviewerComboBox.Text
            Dim receip = "rojascarlos82@hotmail.com"
            CreateSendItemCYA(signa, nameSt, receip, attachmentPath, attachmentPath2)
            PleaseWait.Hide()
            IntakeForm.Close()
        End If
    End Sub

    Public Sub CreateSendItem(receip As String, attachmentPath As String)
        Dim OutlookMessage As Outlook.MailItem
        Dim AppOutlook As New Outlook.Application
        Try
            OutlookMessage = AppOutlook.CreateItem(Outlook.OlItemType.olMailItem)
            Dim Recipents As Outlook.Recipients = OutlookMessage.Recipients
            Recipents.Add(receip)
            OutlookMessage.Subject = "CIP Process Testing"
            OutlookMessage.Body = "CIP Process Testing"
            OutlookMessage.BodyFormat = Outlook.OlBodyFormat.olFormatHTML
            If attachmentPath <> "" Then
                OutlookMessage.Attachments.Add(attachmentPath)
            End If
            OutlookMessage.Display()
        Catch ex As Exception
            MessageBox.Show("Mail could not be sent")
        Finally
            OutlookMessage = Nothing
            AppOutlook = Nothing
        End Try
    End Sub
    Public Sub CreateSendItemCYA(signat As String, nameStrg As String, receip As String, attachmentPath As String, attachmentPath2 As String)
        Dim OutlookMessage As Outlook.MailItem
        Dim AppOutlook As New Outlook.Application
        'Try
        OutlookMessage = AppOutlook.CreateItem(Outlook.OlItemType.olMailItem)
        Dim Recipents As Outlook.Recipients = OutlookMessage.Recipients
        Recipents.Add(receip)
        OutlookMessage.Subject = "New CYA Process Invoked - " & nameStrg
        OutlookMessage.HTMLBody = "<p>Hi,</p><br><br>

                                        <p>Please be advised that the following initial intake has been
                                        completed. We will not be taking on this client at this time. Please arrange to
                                        complete the CYA process as indicated by the attached draft CYA correspondence.</p><br><br>

                                        <p>If you have any questions, please see me.</p><br>

                                        <p>Regards,</p><br>

                                        <p>" & signat & "</p>"
        OutlookMessage.BodyFormat = Outlook.OlBodyFormat.olFormatHTML
        If attachmentPath <> "" Then
            OutlookMessage.Attachments.Add(attachmentPath)
        End If
        If attachmentPath2 <> "" Then
            OutlookMessage.Attachments.Add(attachmentPath2)
        End If
        OutlookMessage.Display()
        'Catch ex As Exception
        'MessageBox.Show("Mail could not be sent")
        'Finally
        OutlookMessage = Nothing
        AppOutlook = Nothing
        'End Try
    End Sub

    Private Function CreateAndFillTemplateDocument(templatePath As String) As String
        Dim wordApp As New Word.Application
        Dim document = wordApp?.Documents?.Open(templatePath)
        document.Content.Find.Execute(FindText:="$$$TodaysDate$$$", ReplaceWith:=Format(Now(), "MMMM d, yyyy"), Replace:=WdReplace.wdReplaceAll)
        document.Content.Find.Execute(FindText:="$$$FirstName$$$", ReplaceWith:=PotentialClientInfo.PCIFirstName.Text, Replace:=WdReplace.wdReplaceAll)
        document.Content.Find.Execute(FindText:="$$$LastName$$$", ReplaceWith:=PotentialClientInfo.PCILastName.Text, Replace:=WdReplace.wdReplaceAll)
        document.Content.Find.Execute(FindText:="$$$Address1$$$", ReplaceWith:=PotentialClientInfo.PCIAddress.Text, Replace:=WdReplace.wdReplaceAll)
        document.Content.Find.Execute(FindText:="$$$Address2$$$", ReplaceWith:="", Replace:=WdReplace.wdReplaceAll)
        document.Content.Find.Execute(FindText:="$$$City$$$", ReplaceWith:=PotentialClientInfo.PCICity.Text, Replace:=WdReplace.wdReplaceAll)
        document.Content.Find.Execute(FindText:="$$$Province$$$", ReplaceWith:=PotentialClientInfo.PCIProvince.Text, Replace:=WdReplace.wdReplaceAll)
        document.Content.Find.Execute(FindText:="$$$PostalCode$$$", ReplaceWith:=PotentialClientInfo.PCIPostalCode.Text, Replace:=WdReplace.wdReplaceAll)
        document.Content.Find.Execute(FindText:="$$$Salutation$$$", ReplaceWith:=PotentialClientInfo.PCISalutation.Text, Replace:=WdReplace.wdReplaceAll)
        document.Content.Find.Execute(FindText:="$$$E-mail$$$", ReplaceWith:=PotentialClientInfo.PCIEmail.Text, Replace:=WdReplace.wdReplaceAll)
        document.Content.Find.Execute(FindText:="$$$DateOfLoss$$$", ReplaceWith:=Format(PreliminaryInfo.DateOfLossDateTimePicker.Value, "MMMM d, yyyy"), Replace:=WdReplace.wdReplaceAll)
        While document.Content.Find.Execute(FindText:="  ", Wrap:=WdFindWrap.wdFindContinue)
            document.Content.Find.Execute(FindText:="  ", ReplaceWith:=" ", Replace:=WdReplace.wdReplaceAll)
        End While
        Dim filePath = "C:\test" & "\CYACorrespondence" & Format(Now(), "Mdyhhmmss") & ".doc"
        document.SaveAs(FileName:=filePath)
        document.Close()
        wordApp.Quit()
        Return filePath
    End Function
    Private Function CreateAndFillTemplateWoorkbook(templatePath As String) As String
        Dim excelApp As New Excel.Application
        Dim workbook = excelApp?.Workbooks?.Open(templatePath)
        Dim Worksheet As Worksheet = workbook.Sheets(1)

        Worksheet.Cells.Replace("$$$FileNumber$$$", PreliminaryInfo.FileNumberTextBox.Text)
        Worksheet.Cells.Replace("$$$DateOfCall$$$", PreliminaryInfo.DateOFCallDateTimePicker.Text)
        Worksheet.Cells.Replace("$$$DateOfLoss$$$", PreliminaryInfo.DateOfLossDateTimePicker.Text)
        Worksheet.Cells.Replace("$$$StaffInterviewer$$$", PreliminaryInfo.StaffInterviewerComboBox.Text)
        Worksheet.Cells.Replace("$$$HearAboutUs$$$", PreliminaryInfo.HowHearComboBox.Text)
        Worksheet.Cells.Replace("$$$FileLawyer$$$", PreliminaryInfo.FileNumberTextBox.Text)
        Worksheet.Cells.Replace("$$$ResponsibleLawyer$$$", PreliminaryInfo.ResponsibleLawyerComboBox.Text)
        Worksheet.Cells.Replace("$$$MatterSubType$$$", PreliminaryInfo.MatterSubTypeComboBox.Text)
        Worksheet.Cells.Replace("$$$LimitationPeriod$$$", PreliminaryInfo.LimitationPeriodTextBox.Text)
        Worksheet.Cells.Replace("$$$StatutoryNotice$$$", PreliminaryInfo.StatutoryNoticeBox.Text)
        Worksheet.Cells.Replace("$$$AdditionalNotes$$$", PreliminaryInfo.AdditionalNotesTextBox.Text)


        Worksheet.Cells.Replace("$$$TodaysDate$$$", Format(Now(), "MMMM d, yyyy"))
        Worksheet.Cells.Replace("$$$FirstName$$$", PotentialClientInfo.PCIFirstName.Text)
        Worksheet.Cells.Replace("$$$LastName$$$", PotentialClientInfo.PCILastName.Text)
        Worksheet.Cells.Replace("$$$Address1$$$", PotentialClientInfo.PCIAddress.Text)
        Worksheet.Cells.Replace("$$$Address2$$$", "")
        Worksheet.Cells.Replace("$$$City$$$", PotentialClientInfo.PCICity.Text)
        Worksheet.Cells.Replace("$$$Province$$$", PotentialClientInfo.PCIProvince.Text)
        Worksheet.Cells.Replace("$$$PostalCode$$$", PotentialClientInfo.PCIPostalCode.Text)
        Worksheet.Cells.Replace("$$$Salutation$$$", PotentialClientInfo.PCISalutation.Text)
        Worksheet.Cells.Replace("$$$E-mail$$$", PotentialClientInfo.PCIEmail.Text)

        Worksheet.Cells.Replace("$$$HomeNumber$$$", PotentialClientInfo.PCIHomeNumber.Text)
        Worksheet.Cells.Replace("$$$WorkNumber$$$", PotentialClientInfo.PCIWorkNumber.Text)
        Worksheet.Cells.Replace("$$$MobileNumber$$$", PotentialClientInfo.PCIMobileNumber.Text)
        Worksheet.Cells.Replace("$$$MobileCarrier$$$", PotentialClientInfo.PCIMobileCarrier.Text)
        Worksheet.Cells.Replace("$$$EmailToText$$$", PotentialClientInfo.PCIEmailToText.Text)
        Worksheet.Cells.Replace("$$$DateOfBirth$$$", Format(PotentialClientInfo.PCIDateOfBirth, "MMMM d, yyyy"))
        Worksheet.Cells.Replace("$$$OtherNotes$$$", PotentialClientInfo.PCIOtherNotes.Text)

        Worksheet.Cells.Replace("$$$LiabilityDate$$$", IntakeSheets.LiaDate.Text)
        Worksheet.Cells.Replace("$$$LiabilityMVR$$$", IntakeSheets.LiaMVR.Checked)
        Worksheet.Cells.Replace("$$$LiabilityRC$$$", IntakeSheets.LiaReportCollision.Checked)
        Worksheet.Cells.Replace("$$$LiabilityMVC$$$", IntakeSheets.LiaMVR.Checked)
        Worksheet.Cells.Replace("$$$LiabilityOtherDocuments$$$", IntakeSheets.LiaOtherDoc.Checked)
        Worksheet.Cells.Replace("$$$LiabilityWhere$$$", IntakeSheets.LiaWhereAccident.Text)
        Worksheet.Cells.Replace("$$$LiabilityExplanation$$$", IntakeSheets.LiaExplain.Text)
        Worksheet.Cells.Replace("$$$LiabilityHavePhotos$$$", IntakeSheets.LiaHavePhotos.Text)

        Worksheet.Cells.Replace("$$$LiabilityDamageEstimation$$$", IntakeSheets.LiaEstimDamage.Text)
        Worksheet.Cells.Replace("$$$LiabilityYourFault$$$", IntakeSheets.LiaYourFault.Text)
        Worksheet.Cells.Replace("$$$LiabilityDriverName$$$", IntakeSheets.LiaDriverName.Text)
        Worksheet.Cells.Replace("$$$LiabilityOwnerName$$$", IntakeSheets.LiaOwnerName.Text)
        Worksheet.Cells.Replace("$$$LiabilityInsuranceCompany$$$", IntakeSheets.LiaInsuranceCo.Text)

        Worksheet.Cells.Replace("$$$LiabilityCopyReport$$$", IntakeSheets.LiaHaveCopy.Text)
        Worksheet.Cells.Replace("$$$LiabilityOwnNegligence$$$", IntakeSheets.LiaOwnNegligence.Text)
        Worksheet.Cells.Replace("$$$LiabilityFaultPerson$$$", IntakeSheets.LiaFaultPerson.Text)
        Worksheet.Cells.Replace("$$$LiabilityMunicipalityName$$$", IntakeSheets.LiaMunicipality.Text)
        Worksheet.Cells.Replace("$$$LiabilityMunicipalityNoticedy$$$", IntakeSheets.LiaNotifiedMunicipality.Text)


        Worksheet.Cells.Replace("$$$LiabilityNotes$$$", IntakeSheets.LiaNotes.Text)

        Worksheet.Cells.Replace("$$$EmploymentWereEmployed$$$", IntakeSheets.EILWereEmployed.Text)
        Worksheet.Cells.Replace("$$$EmploymentEmployed4Weeks$$$", IntakeSheets.EILEmployed4Weeks.Text)
        Worksheet.Cells.Replace("$$$EmploymentEmployed52Weeks$$$", IntakeSheets.EILEmployed52Weeks.Text)
        Worksheet.Cells.Replace("$$$EmploymentT4Employee$$$", IntakeSheets.EILT4Employee.Text)
        Worksheet.Cells.Replace("$$$EmploymentT4CompanyName$$$", IntakeSheets.EILT4Company.Text)
        Worksheet.Cells.Replace("$$$EmploymentCollectingEmploymentInsurance$$$", IntakeSheets.EILCollecInsurance.Text)
        Worksheet.Cells.Replace("$$$EmploymentGrossEarning$$$", IntakeSheets.EILEmployeeGrossEarning.Text)
        Worksheet.Cells.Replace("$$$EmploymentTimeBeingEmployed$$$", IntakeSheets.EILHowLongEmployee.Text)
        Worksheet.Cells.Replace("$$$EmploymentJobTitle$$$", IntakeSheets.EILJobTitle.Text)
        Worksheet.Cells.Replace("$$$EmploymentJobResponsabilities$$$", IntakeSheets.EILExplainJob.Text)
        Worksheet.Cells.Replace("$$$EmploymentSelfEmployed$$$", IntakeSheets.EILWereSelfEmployed.Text)
        Worksheet.Cells.Replace("$$$EmploymentSelfEmployedBusinessName$$$", IntakeSheets.EILSelfBusinessName.Text)
        Worksheet.Cells.Replace("$$$EmploymentSelfEmployedGrossEarning$$$", IntakeSheets.EILSelfGrossEarning.Text)
        Worksheet.Cells.Replace("$$$EmploymentSelfEmployedTimeOperating$$$", IntakeSheets.EILHowLongBusiness.Text)
        Worksheet.Cells.Replace("$$$EmploymentNotes$$$", IntakeSheets.EILNotes.Text)

        Worksheet.Cells.Replace("$$$DamagesHitPartVehicleOrConcrete$$$", IntakeSheets.DamHitVehicleConcrete.Text)
        Worksheet.Cells.Replace("$$$DamagesWentToHospital$$$", IntakeSheets.DamHeadInjuries.Text)
        Worksheet.Cells.Replace("$$$DamagesHeadInjuries$$$", IntakeSheets.DamHeadInjuries.Text)
        Worksheet.Cells.Replace("$$$DamagesUpperBodyInjuries$$$", IntakeSheets.DamUpperBodyInjuries.Text)
        Worksheet.Cells.Replace("$$$DamagesLowerBodyInjuries$$$", IntakeSheets.DamLowerBodyInjuries.Text)
        Worksheet.Cells.Replace("$$$DamagesPsychologicalEffect$$$", IntakeSheets.DamPsychologicalEffect.Text)
        Worksheet.Cells.Replace("$$$DamagesBeenPrescribedMedication$$$", IntakeSheets.DamPrescribed.Text)
        Worksheet.Cells.Replace("$$$DamagesSeeingAnyOther$$$", IntakeSheets.DamWereSeeingDoctor.Text)
        Worksheet.Cells.Replace("$$$DamagesPreviousAccident$$$", IntakeSheets.DamPreAccident.Text)
        Worksheet.Cells.Replace("$$$DamagesAnyOtherIllness$$$", IntakeSheets.DamPreIllness.Text)
        Worksheet.Cells.Replace("$$$DamagesNotes$$$", IntakeSheets.DamNotes.Text)

        Worksheet.Cells.Replace("$$$ABDriverPassenger$$$", IntakeSheets.AccBenDriverPassenger.Text)
        Worksheet.Cells.Replace("$$$ABWereRegisteredOwner$$$", IntakeSheets.AccBenWereRegisOwner.Text)
        Worksheet.Cells.Replace("$$$ABRegisteredOwnerName$$$", IntakeSheets.AccBenRegisOwnerName.Text)
        Worksheet.Cells.Replace("$$$ABPolicyNumber$$$", IntakeSheets.AccBenPolicyNumber.Text)
        Worksheet.Cells.Replace("$$$ABClaimNumber$$$", IntakeSheets.AccBenClaimNumber.Text)
        Worksheet.Cells.Replace("$$$ABInsuranceCompany$$$", IntakeSheets.AccBenInsuranceCompany.Text)
        Worksheet.Cells.Replace("$$$ABDealingSpecificAdjuster$$$", IntakeSheets.AccBenAdjuster.Text)
        Worksheet.Cells.Replace("$$$ABCompletedOCF1$$$", IntakeSheets.AccBenOCF1.Text)
        Worksheet.Cells.Replace("$$$ABCompletedOCF2$$$", IntakeSheets.AccBenOCF2.Text)
        Worksheet.Cells.Replace("$$$ABCompletedOCF3$$$", IntakeSheets.AccBenOCF3.Text)
        Worksheet.Cells.Replace("$$$ABReceivingBenefits$$$", IntakeSheets.AccBenReplacBenef.Text)
        Worksheet.Cells.Replace("$$$ABNotes$$$", IntakeSheets.AccBenNotes.Text)

        Worksheet.Cells.Replace("$$$OtherNotes$$$", IntakeSheets.Notes.Text)

        'With Worksheet
        '    .Range("B4").Value = Me.PreliminaryInfo.FileNumberTextBox.Text
        '    .Range("B5").Value = Me.PreliminaryInfo.DateOFCallDateTimePicker.Text
        '    .Range("B6").Value = Me.PreliminaryInfo.DateOfLossDateTimePicker.Text
        '    .Range("B7").Value = Me.PreliminaryInfo.StaffInterviewerComboBox.Text
        '    .Range("B8").Value = Me.PreliminaryInfo.HowHearComboBox.Text
        '    .Range("B9").Value = Me.PreliminaryInfo.LawyerComboBox.Text
        '    .Range("B10").Value = Me.PreliminaryInfo.ResponsibleLawyerComboBox.Text
        '    .Range("B11").Value = Me.PreliminaryInfo.MatterSubTypeComboBox.Text
        '    .Range("B12").Value = Me.PreliminaryInfo.LimitationPeriodTextBox.Text
        '    .Range("B13").Value = Me.PreliminaryInfo.StatutoryNoticeBox.Text
        '    .Range("B14").Value = Me.PreliminaryInfo.AdditionalNotesTextBox.Text
        '    .Range("B16").Value = Me.PotentialClientInfo.PCISalutation.Text & " " & PotentialClientInfo.PCIFirstName.Text & " " & PotentialClientInfo.PCILastName.Text
        '    .Range("B17").Value = Me.PotentialClientInfo.PCIAddress.Text & " " & PotentialClientInfo.PCISuiteApt.Text & " " & PotentialClientInfo.PCICity.Text & " " & PotentialClientInfo.PCIProvince.Text & " " & PotentialClientInfo.PCIPostalCode.Text
        '    .Range("B18").Value = Me.PotentialClientInfo.PCIEmail.Text
        '    .Range("B19").Value = Me.PotentialClientInfo.PCIHomeNumber.Text
        '    .Range("B20").Value = Me.PotentialClientInfo.PCIWorkNumber.Text
        '    .Range("B21").Value = Me.PotentialClientInfo.PCIMobileNumber.Text
        '    .Range("B22").Value = Me.PotentialClientInfo.PCIMobileCarrier.Text
        '    .Range("B23").Value = Me.PotentialClientInfo.PCIEmailToText.Text
        '    '.Range("B24").Value = Me.PotentialClientInfo.PCIDateOfBirth.Text
        '    .Range("B25").Value = Me.PotentialClientInfo.PCIOtherNotes.Text
        '    .Range("B27").Value = Me.IntakeSheets.LiaDate.Text
        '    If IntakeSheets.LiaMVR.CheckState <> 0 Then .Range("B28").Value = "Yes"
        '    If IntakeSheets.LiaMVR.CheckState <> 0 Then
        '        .Range("D28").Value = "Yes"
        '    Else
        '        .Range("D28").Value = "No"
        '    End If
        '    If IntakeSheets.LiaReportCollision.CheckState <> 0 Then
        '        .Range("D28").Value = "Yes"
        '    Else
        '        .Range("D28").Value = "No"
        '    End If
        '    If IntakeSheets.LiaMVCExchange.CheckState <> 0 Then
        '        .Range("F28").Value = "Yes"
        '    Else
        '        .Range("F28").Value = "No"
        '    End If
        '    If IntakeSheets.LiaOtherDoc.CheckState <> 0 Then
        '        .Range("B29").Value = "Yes"
        '    Else
        '        .Range("B29").Value = "No"
        '    End If
        '    .Range("B30").Value = Me.IntakeSheets.LiaWhereAccident.Text
        'End With
        Dim filePath = "C:\test" & "\MVAIntakeReport" & Format(Now(), "Mdyhhmmss") & ".xlsx"
        workbook.SaveAs(Filename:=filePath)
        workbook.Close()
        excelApp.Quit()
        Return filePath
    End Function
    Private Function OpenDocument(path As String) As Document
        Dim wordApp As New Word.Application
        Dim document = wordApp?.Documents?.Open(path)
        wordApp.Quit()
        Return document
    End Function
    Private Function OpenWorkbook(path As String) As Workbook
        Dim excelApp As New Excel.Application
        Dim workbook = excelApp?.Workbooks?.Open(path)
        excelApp.Quit()
        Return workbook
    End Function
End Class
