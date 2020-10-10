Public Class PreliminaryInfo

    Public Property IntakeForm As Intake

    Public Function Validate() As Boolean
        If Me.MatterTypeComboBox.Text = "" Or Me.StaffInterviewerComboBox.Text = "" Or Me.HowHearComboBox.Text = "" Or ResponsibleLawyerComboBox.Text = "" Or LawyerComboBox.Text = "" Or DateOfLossDateTimePicker.CustomFormat = " " Then
            If Me.MatterTypeComboBox.Text = "" Then MsgBox("Please select: Matter Type") : Return False
            If Me.StaffInterviewerComboBox.Text = "" Then MsgBox("Please select: Staff Interviewer") : Return False
            If Me.HowHearComboBox.Text = "" Then MsgBox("Please select: How did you hear about us?") : Return False
            If Me.ResponsibleLawyerComboBox.Text = "" Then MsgBox("Please select: Responsible Lawyer") : Return False
            If Me.LawyerComboBox.Text = "" Then MsgBox("Please select: File Lawyer") : Return False
            If DateOfLossDateTimePicker.CustomFormat = " " Then MsgBox("Please select: Date of Loss") : Return False
        Else
            If MatterSubTypeComboBox.Items.Count > 0 And MatterSubTypeComboBox.Text = "" Then
                MsgBox("Please select: Matter Sub Type") : Return False
            End If
        End If
        Return True
    End Function

    Public Sub getNewFileNumber(lastFileNumber As String)

        If LawyerComboBox.Text <> "" Then

            Dim dr() As System.Data.DataRow
            'Dim lastFileNumber As String = ActionLogDBDataSet.Tables("Intakes").Rows(0)("FileNumber")
            Dim lastFileNumberYear As Integer = lastFileNumber.Substring(0, 4)
            Dim thisYear As Integer = Year(Now())
            If thisYear = lastFileNumberYear Then
                Dim nextFileString As String = "000"
                Dim lastFile As String = lastFileNumber.Substring(6, 3)
                Dim nextFileNumber As Integer = lastFile + 1
                If Len(nextFileNumber.ToString) = 1 Then nextFileString = "00" & nextFileNumber
                If Len(nextFileNumber.ToString) = 2 Then nextFileString = "0" & nextFileNumber
                If Len(nextFileNumber.ToString) = 3 Then nextFileString = nextFileNumber

                dr = ActionLogDBDataSet.Tables("FileLawyer").Select("Lawyer='" & LawyerComboBox.Text & "'")
                If dr.Length > 0 Then
                    Dim nextFile As String = thisYear & dr(0)("NumberID").ToString() & nextFileString
                    Me.FileNumberTextBox.Text = nextFile

                End If
            Else
                dr = ActionLogDBDataSet.Tables("FileLawyer").Select("Lawyer='" & LawyerComboBox.Text & "'")
                If dr.Length > 0 Then
                    Dim nextFileString As String = "001"
                    Dim nextFile As String = thisYear & dr(0)("NumberID").ToString() & nextFileString
                    Me.FileNumberTextBox.Text = nextFile

                End If

            End If
        Else
            Me.FileNumberTextBox.Clear()
        End If
    End Sub





    Private Sub MatterSubTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MatterSubTypeComboBox.SelectedIndexChanged
        Dim matterSubType = ActionLogDBDataSet.MatterSubTypes.FirstOrDefault(Function(s) s.MatterSubType = MatterSubTypeComboBox.Text)
        If Not matterSubType Is Nothing And Not String.IsNullOrEmpty(matterSubType("StatutoryNotice").ToString()) Then
            StatutoryNoticeBox.Text = Format(DateAdd("d", 10, DateOfLossDateTimePicker.Value), "MMM-dd-yyyy")
        Else
            StatutoryNoticeBox.Text = ""
        End If
    End Sub

    Private Sub DateOfLossDateTimePicker_ValueChanged(Sender As Object, e As EventArgs) Handles DateOfLossDateTimePicker.ValueChanged
        DateOfLossDateTimePicker.CustomFormat = "MMM-dd-yyyy"
        Dim dr() As System.Data.DataRow
        dr = ActionLogDBDataSet.Tables("MatterSubTypes").Select("MatterSubType='" & MatterSubTypeComboBox.Text & "'")
        If dr.Length > 0 Then
            Dim statutoryNotice As String = dr(0)("StatutoryNotice").ToString()
            If statutoryNotice <> "" Then Me.StatutoryNoticeBox.Text = Format(DateAdd("d", 10, Me.DateOfLossDateTimePicker.Value), "MMM-dd-yyyy")
        End If
        If DateOfLossDateTimePicker.CustomFormat = "MMM-dd-yyyy" Then
            LimitationPeriodTextBox.Text = Format(Sender.Value.AddYears(2), "MMM-dd-yyyy")
        End If
    End Sub

    Private Sub LawyerComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LawyerComboBox.SelectedIndexChanged
        Dim lastFileNumber As String = ActionLogDBDataSet.Intakes.FirstOrDefault()?("FileNumber")
        getNewFileNumber(lastFileNumber)
    End Sub

    Private Sub PreliminaryInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Initialize()
    End Sub

    Private Sub Initialize()
        Me.HearAboutUsTableAdapter.Fill(Me.ActionLogDBDataSet.HearAboutUs)
        Me.StaffInterviewerTableAdapter.Fill(Me.ActionLogDBDataSet.StaffInterviewer)
        Me.ResponsibleLawyerTableAdapter.Fill(Me.ActionLogDBDataSet.ResponsibleLawyer)
        Me.FileLawyerTableAdapter.Fill(Me.ActionLogDBDataSet.FileLawyer)
        Me.IntakesTableAdapter.Fill(Me.ActionLogDBDataSet.Intakes)
        Me.MatterTypeTableAdapter.Fill(ActionLogDBDataSet.MatterType)
        Me.MatterSubTypesTableAdapter.Fill(ActionLogDBDataSet.MatterSubTypes)
        Dim obj = IntakesBindingSource.AddNew()

        MatterSubTypeComboBox.Items.Clear()
        For Each row As DataRow In ActionLogDBDataSet.MatterSubTypes.Rows
            If row("Matter").ToString = "Motor Vehicle Accident" Then
                Me.MatterSubTypeComboBox.Items.Add(row("MatterSubType").ToString)
            End If
        Next
        Me.LawyerComboBox.SelectedIndex = -1
        Dim lastFileNumber As String = ActionLogDBDataSet.Tables("Intakes").Rows(0)("FileNumber")
        getNewFileNumber(lastFileNumber)
        DateOfLossDateTimePicker.Format = DateTimePickerFormat.Custom
        DateOfLossDateTimePicker.CustomFormat = " "
        Me.MatterTypeComboBox.SelectedValue = vbNull
        Me.LimitationPeriodTextBox.Text = ""
    End Sub

    Public Sub OnNext()
        IntakeForm.IntakesBindingSource.EndEdit()
        IntakeForm.IntakesTableAdapter.Update(ActionLogDBDataSet.Intakes)
    End Sub

    Private Sub MatterTypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MatterTypeComboBox.SelectedIndexChanged

    End Sub
End Class
