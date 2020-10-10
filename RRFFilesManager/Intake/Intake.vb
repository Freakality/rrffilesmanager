Imports Microsoft.Reporting.WinForms
Imports outlook = Microsoft.Office.Interop.Outlook
Imports System.Runtime.InteropServices
Public Class Intake
    Public Property PreliminaryInfo As PreliminaryInfo
    Public Property PotentialClientInfo As PotentialClientInfo
    Public Property IntakeSheets As IntakeSheets
    Public Property NextSteps As NextSteps

    Public Property IntakeId As String


    Public Sub CreateSendItem(receip As String, attachmentPath As String)
        Dim OutlookMessage As outlook.MailItem
        Dim AppOutlook As New outlook.Application
        Try
            OutlookMessage = AppOutlook.CreateItem(outlook.OlItemType.olMailItem)
            Dim Recipents As outlook.Recipients = OutlookMessage.Recipients
            Recipents.Add(receip)
            OutlookMessage.Subject = "CIP Process Testing"
            OutlookMessage.Body = "CIP Process Testing"
            OutlookMessage.BodyFormat = outlook.OlBodyFormat.olFormatHTML
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
        Dim OutlookMessage As outlook.MailItem
        Dim AppOutlook As New outlook.Application
        'Try
        OutlookMessage = AppOutlook.CreateItem(outlook.OlItemType.olMailItem)
        Dim Recipents As outlook.Recipients = OutlookMessage.Recipients
        Recipents.Add(receip)
        OutlookMessage.Subject = "New CYA Process Invoked - " & nameStrg
        OutlookMessage.HTMLBody = "<p>Hi,</p><br><br>

                                        <p>Please be advised that the following initial intake has been
                                        completed. We will not be taking on this client at this time. Please arrange to
                                        complete the CYA process as indicated by the attached draft CYA correspondence.</p><br><br>

                                        <p>If you have any questions, please see me.</p><br>

                                        <p>Regards,</p><br>

                                        <p>" & signat & "</p>"
        OutlookMessage.BodyFormat = outlook.OlBodyFormat.olFormatHTML
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
    Private Sub Intake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ActionLogDBDataSet.CYATemplates' table. You can move, or remove it, as needed.
        If ActionLogDBDataSet Is Nothing Then
            Return
        End If


        Me.DisabilityInsuranceCompaniesTableAdapter.Fill(Me.ActionLogDBDataSet.DisabilityInsuranceCompanies)
        Me.InsuranceCompaniesTableAdapter.Fill(Me.ActionLogDBDataSet.InsuranceCompanies)


        Me.IntakesTableAdapter.Fill(Me.ActionLogDBDataSet.Intakes)
        'IntakesBindingSource.AddNew()

        PreliminaryInfo = New PreliminaryInfo()
        PreliminaryInfo.IntakeForm = Me
        PotentialClientInfo = New PotentialClientInfo()
        PotentialClientInfo.IntakeForm = Me
        IntakeSheets = New IntakeSheets()
        IntakeSheets.IntakeForm = Me
        NextSteps = New NextSteps()
        NextSteps.IntakeForm = Me
        SetContent(PreliminaryInfo)
        BackButton.Visible = False

    End Sub

    Private Sub SetContent(control As Control)
        Content.Controls.Clear()
        Content.Controls.Add(control)
    End Sub


    Private Sub Intake_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Home.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Home.Show()
    End Sub



    Private Sub Button14_Click(sender As Object, e As EventArgs)
        'Dim newFileRow As ActionLogDBDataSet.IntakesRow
        'newFileRow = ActionLogDBDataSet.Intakes.NewIntakesRow()

        'newFileRow.FileNumber = FileNumberTextBox.Text

        'ActionLogDBDataSet.Intakes.Rows.Add(newFileRow)

        'MsgBox("Done!")
        If Me.PreliminaryInfo.LawyerComboBox.Text <> "" Then
            Me.PreliminaryInfo.TextBox1.Text = Me.PreliminaryInfo.MatterTypeComboBox.Text
            IntakesBindingSource.EndEdit()
            IntakesTableAdapter.Update(ActionLogDBDataSet.Intakes)
            Dim attachmentPath As String = ""
            'If Me.MVAInvokeCIP.Checked = True Then CreateSendItem("rojascarlos82@hotmail.com",attachmentPath)
            'If Me.RadioButton6.Checked = True Then CreateSendItem("DManzano@InjuryLawyerCanada.com", attachmentPath)
            'If Me.RadioButton6.Checked = True Then CreateSendItem("RFoisy@InjuryLawyerCanada.com", attachmentPath)
            MsgBox("Submitted!")
            Me.Close()
        Else
            MsgBox("Please enter all mandatory fields")
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        'Dim newFileRow As ActionLogDBDataSet.IntakesRow
        'newFileRow = ActionLogDBDataSet.Intakes.NewIntakesRow()

        'newFileRow.FileNumber = FileNumberTextBox.Text

        'ActionLogDBDataSet.Intakes.Rows.Add(newFileRow)

        'MsgBox("Done!")
        If Me.PreliminaryInfo.LawyerComboBox.Text <> "" Then
            Me.PreliminaryInfo.TextBox1.Text = Me.PreliminaryInfo.MatterTypeComboBox.Text
            IntakesBindingSource.EndEdit()
            IntakesTableAdapter.Update(ActionLogDBDataSet.Intakes)
            Dim attachmentPath As String = ""
            'If Me.MVAInvokeCIP.Checked = True Then CreateSendItem("rojascarlos82@hotmail.com",attachmentPath)
            'If Me.RadioButton4.Checked = True Then CreateSendItem("DManzano@InjuryLawyerCanada.com", attachmentPath)
            'If Me.RadioButton4.Checked = True Then CreateSendItem("RFoisy@InjuryLawyerCanada.com", attachmentPath)
            MsgBox("Submitted!")
            Me.Close()
        Else
            MsgBox("Please enter all mandatory fields")
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)
        'Dim newFileRow As ActionLogDBDataSet.IntakesRow
        'newFileRow = ActionLogDBDataSet.Intakes.NewIntakesRow()

        'newFileRow.FileNumber = FileNumberTextBox.Text

        'ActionLogDBDataSet.Intakes.Rows.Add(newFileRow)

        'MsgBox("Done!")
        If Me.PreliminaryInfo.LawyerComboBox.Text <> "" Then
            Me.PreliminaryInfo.TextBox1.Text = Me.PreliminaryInfo.MatterTypeComboBox.Text
            IntakesBindingSource.EndEdit()
            IntakesTableAdapter.Update(ActionLogDBDataSet.Intakes)
            Dim attachmentPath As String = ""
            'If Me.MVAInvokeCIP.Checked = True Then CreateSendItem("rojascarlos82@hotmail.com",attachmentPath)
            'If Me.RadioButton8.Checked = True Then CreateSendItem("DManzano@InjuryLawyerCanada.com", attachmentPath)
            'If Me.RadioButton8.Checked = True Then CreateSendItem("RFoisy@InjuryLawyerCanada.com", attachmentPath)
            MsgBox("Submitted!")
            Me.Close()
        Else
            MsgBox("Please enter all mandatory fields")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Path = "M:\Task Manager\FilesManager\VBnetProgram\cnsignon.lnk"
        System.Diagnostics.Process.Start(Path)
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'Dim newFileRow As ActionLogDBDataSet.IntakesRow
        'newFileRow = ActionLogDBDataSet.Intakes.NewIntakesRow()

        'newFileRow.FileNumber = FileNumberTextBox.Text

        'ActionLogDBDataSet.Intakes.Rows.Add(newFileRow)

        'MsgBox("Done!")
        If Me.PreliminaryInfo.LawyerComboBox.Text <> "" Then
            Me.PreliminaryInfo.TextBox1.Text = Me.PreliminaryInfo.MatterTypeComboBox.Text
            IntakesBindingSource.EndEdit()
            IntakesTableAdapter.Update(ActionLogDBDataSet.Intakes)
            Dim attachmentPath As String = ""
            'If Me.MVAInvokeCIP.Checked = True Then CreateSendItem("rojascarlos82@hotmail.com",attachmentPath)
            'If Me.RadioButton2.Checked = True Then CreateSendItem("DManzano@InjuryLawyerCanada.com", attachmentPath)
            'If Me.RadioButton2.Checked = True Then CreateSendItem("RFoisy@InjuryLawyerCanada.com", attachmentPath)
            MsgBox("Submitted!")
            Me.Close()
        Else
            MsgBox("Please enter all mandatory fields")
        End If
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click

        Select Case Content.Controls(0).GetType()
            Case GetType(PreliminaryInfo)
                If PreliminaryInfo.Validate() Then
                    BackButton.Visible = True
                    SetContent(PotentialClientInfo)
                    PreliminaryInfo.OnNext()
                End If
            Case GetType(PotentialClientInfo)
                If PotentialClientInfo.Validate() Then
                    IntakeSheets.bringMattertypeForm()
                    SetContent(IntakeSheets)
                    'PotentialClientInfo.OnNext()
                End If
            Case GetType(IntakeSheets)
                If PotentialClientInfo.Validate() Then
                    NextButton.Visible = False
                    SetContent(NextSteps)
                End If
        End Select

        'If Content.GetType() Is GetType(PreliminaryInfo) Then

        'ElseIf 
        'End If

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Select Case Content?.Controls?(0).GetType()
            Case GetType(PotentialClientInfo)
                BackButton.Visible = False
                SetContent(PreliminaryInfo)
            Case GetType(IntakeSheets)
                SetContent(PotentialClientInfo)
            Case GetType(NextSteps)
                NextButton.Visible = True
                SetContent(IntakeSheets)
        End Select
    End Sub
End Class
