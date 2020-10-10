Public Class PotentialClientInfo
    Public Property IntakeForm As Intake

    Public ReadOnly Property PreliminaryInfo() As PreliminaryInfo
        Get
            Return IntakeForm.PreliminaryInfo
        End Get
    End Property

    Public ReadOnly Property PCIDateOfBirth() As Date?
        Get
            If (String.IsNullOrWhiteSpace(Me.monthBirth.Text) Or String.IsNullOrWhiteSpace(Me.dayBirth.Text) Or String.IsNullOrWhiteSpace(Me.yearBirth.Text)) Then
                Return Nothing
            End If
            Return Date.Parse(Me.monthBirth.Text + "-" + dayBirth.Text + "-" + yearBirth.Text)
        End Get
    End Property

    Public ReadOnly Property newLimDate() As Date?
        Get
            If (String.IsNullOrWhiteSpace(Me.monthBirth.Text) Or String.IsNullOrWhiteSpace(Me.dayBirth.Text) Or String.IsNullOrWhiteSpace(Me.yearBirth.Text)) Then
                Return Nothing
            End If
            Dim newYear As Integer = yearBirth.Text
            newYear = newYear + 20
            Return Date.Parse(Me.monthBirth.Text + "-" + dayBirth.Text + "-" + newYear.ToString())
        End Get
    End Property

    Private Sub PCIMobileNumber_TextChanged_1(sender As Object, e As EventArgs) Handles PCIMobileNumber.TextChanged
        Dim newPN As String
        If PCIMobileCarrier.Text <> "Other" Then
            Dim dr() As System.Data.DataRow
            dr = ActionLogDBDataSet.Tables("MobileCarrier").Select("Carrier='" & PCIMobileCarrier.Text & "'")
            If dr.Length > 0 Then
                Dim gateString As String = dr(0)("Gate").ToString()
                newPN = PCIMobileNumber.Text.Replace("(", "")
                newPN = newPN.Replace(")", "")
                newPN = newPN.Replace(" ", "")
                newPN = Trim(newPN.Replace("-", ""))
                Me.PCIEmailToText.Text = newPN + "@" + gateString
            End If
        Else
            Me.PCIEmailToText.Text = ""
        End If
    End Sub

    Private Sub monthBirth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles monthBirth.SelectedIndexChanged
        If Me.yearBirth.MaskCompleted = False Or monthBirth.Text = "" Or dayBirth.Text = "" Then
            If Me.monthBirth.Text = "" Then Exit Sub
            If Me.dayBirth.Text = "" Then Exit Sub
            If Me.yearBirth.MaskCompleted = False Then Exit Sub
        Else
            Dim date1 As Date = PreliminaryInfo.DateOfLossDateTimePicker.Value
            Dim date2 As Date = PCIDateOfBirth.Value
            Dim age As Long = DateDiff(DateInterval.Year, date2, date1)
            If age < 18 Then
                PreliminaryInfo.LimitationPeriodTextBox.Text = Format(Me.newLimDate.Value, "MMM-dd-yyyy")
                MsgBox("Limitation Period has been changed to " + PreliminaryInfo.LimitationPeriodTextBox.Text)
            End If
        End If
    End Sub

    Private Sub dayBirth_TextChanged(sender As Object, e As EventArgs) Handles dayBirth.TextChanged
        If Me.yearBirth.MaskCompleted = False Or monthBirth.Text = "" Or dayBirth.Text = "" Then
            If Me.monthBirth.Text = "" Then Exit Sub
            If Me.dayBirth.Text = "" Then Exit Sub
            If Me.yearBirth.MaskCompleted = False Then Exit Sub
        Else
            Dim date1 As Date = PreliminaryInfo.DateOfLossDateTimePicker.Value
            Dim date2 As Date = PCIDateOfBirth.Value
            Dim age As Long = DateDiff(DateInterval.Year, date2, date1)
            If age < 18 Then
                PreliminaryInfo.LimitationPeriodTextBox.Text = Format(Me.newLimDate.Value, "MMM-dd-yyyy")
                MsgBox("Limitation Period has been changed to " + PreliminaryInfo.LimitationPeriodTextBox.Text)
            End If
        End If
    End Sub

    Private Sub yearBirth_TextChanged(sender As Object, e As EventArgs) Handles yearBirth.TextChanged
        If Me.yearBirth.MaskCompleted = False Or monthBirth.Text = "" Or dayBirth.Text = "" Then
            If Me.monthBirth.Text = "" Then Exit Sub
            If Me.dayBirth.Text = "" Then Exit Sub
            If Me.yearBirth.MaskCompleted = False Then Exit Sub
        Else
            Dim date1 As Date = PreliminaryInfo.DateOfLossDateTimePicker.Value
            Dim date2 As Date = PCIDateOfBirth.Value
            Dim age As Long = DateDiff(DateInterval.Year, date2, date1)
            If age < 18 Then
                PreliminaryInfo.LimitationPeriodTextBox.Text = Format(Me.newLimDate.Value, "MMM-dd-yyyy")
                MsgBox("Limitation Period has been changed to " + PreliminaryInfo.LimitationPeriodTextBox.Text)
            End If
        End If
    End Sub
    Private Sub PCIMobileCarrier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PCIMobileCarrier.SelectedIndexChanged
        Dim newPN As String
        If PCIMobileCarrier.Text <> "Other" Then
            Dim dr() As System.Data.DataRow
            dr = ActionLogDBDataSet.Tables("MobileCarrier").Select("Carrier='" & PCIMobileCarrier.Text & "'")
            If dr.Length > 0 Then
                Dim gateString As String = dr(0)("Gate").ToString()
                newPN = PCIMobileNumber.Text.Replace("(", "")
                newPN = newPN.Replace(")", "")
                newPN = newPN.Replace(" ", "")
                newPN = Trim(newPN.Replace("-", ""))
                Me.PCIEmailToText.Text = newPN + "@" + gateString
            End If
        Else
            Me.PCIEmailToText.Text = ""
        End If
    End Sub

    'Private Sub PCIMobileNumber_TextChanged(sender As Object, e As EventArgs)
    '    Dim newPN As String
    '    If PCIMobileCarrier.Text <> "Other" Then
    '        Dim dr() As System.Data.DataRow
    '        dr = ActionLogDBDataSet.Tables("MobileCarrier").Select("Carrier='" & PCIMobileCarrier.Text & "'")
    '        If dr.Length > 0 Then
    '            Dim gateString As String = dr(0)("Gate").ToString()
    '            newPN = PCIMobileNumber.Text.Replace("(", "")
    '            newPN = newPN.Replace(")", "")
    '            newPN = newPN.Replace(" ", "")
    '            newPN = Trim(newPN.Replace("-", ""))
    '            Me.PCIEmailToText.Text = newPN + "@" + gateString
    '        End If
    '    Else
    '        Me.PCIEmailToText.Text = ""
    '    End If
    'End Sub
    Private Sub PotentialClientInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MobileCarrierTableAdapter.Fill(ActionLogDBDataSet.MobileCarrier)
        ProvincesTableAdapter.Fill(ActionLogDBDataSet.Provinces)
        IntakesTableAdapter.Fill(ActionLogDBDataSet.Intakes)
        Dim obj = IntakesBindingSource.AddNew()
        yearBirth.Text = "1970"
    End Sub

    Public Function Validate() As Boolean
        If Me.PCISalutation.Text = "" Then MsgBox("Please enter Salutation") : Return False
        If Me.PCIFirstName.Text = "" Then MsgBox("Please enter First Name") : Return False
        If Me.PCILastName.Text = "" Then MsgBox("Please enter Last Name") : Return False
        If Me.PCIEmail.Text = "" And Me.PCIAddress.Text = "" And Me.PCIPostalCode.Text = "" And Me.PCICity.Text = "" And Me.PCIProvince.Text = "" Then MsgBox("Please enter Email or Address") : Return False
        If Me.PCIEmail.Text = "" Then
            If Me.PCIAddress.Text = "" Or Me.PCIPostalCode.Text = "" Or Me.PCICity.Text = "" Or Me.PCIProvince.Text = "" Then
                If Me.PCIAddress.Text = "" Then MsgBox("Please enter Address") : Return False
                If Me.PCICity.Text = "" Then MsgBox("Please enter City") : Return False
                If Me.PCIProvince.Text = "" Then MsgBox("Please enter Province") : Return False
                If Me.PCIPostalCode.Text = "" Then MsgBox("Please enter Postal Code") : Return False
            End If
        End If
        If Me.PCIHomeNumber.MaskCompleted = False And Me.PCIWorkNumber.MaskCompleted = False And Me.PCIMobileNumber.MaskCompleted = False Then MsgBox("Please enter a Phone Number") : Return False
        If Me.yearBirth.MaskCompleted = False Or monthBirth.Text = "" Or dayBirth.Text = "" Then
            If Me.monthBirth.Text = "" Then MsgBox("Please enter Month of Birth") : Return False
            If Me.dayBirth.Text = "" Then MsgBox("Please enter Day of Birth") : Return False
            If Me.yearBirth.MaskCompleted = False Then MsgBox("Please enter Year of Birth") : Return False

        End If

        Return True
    End Function

    Public Sub OnNext()
        'IntakeForm.IntakesBindingSource.EndEdit()
        'IntakeForm.IntakesTableAdapter.Update(ActionLogDBDataSet.Intakes)
    End Sub
End Class
