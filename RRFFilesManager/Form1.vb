Imports System.ComponentModel

Public Class Form1
    Private Const FN As String = "FileNumber="

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ActionLogDBDataSet.SpecialDamages' table. You can move, or remove it, as needed.
        Me.SpecialDamagesTableAdapter.Fill(Me.ActionLogDBDataSet.SpecialDamages)
        'TODO: This line of code loads data into the 'ActionLogDBDataSet.LAT' table. You can move, or remove it, as needed.
        Me.LATTableAdapter.Fill(Me.ActionLogDBDataSet.LAT)
        'TODO: This line of code loads data into the 'ActionLogDBDataSet.ClientNotes' table. You can move, or remove it, as needed.
        ClientNotesTableAdapter.Fill(ActionLogDBDataSet.ClientNotes)
        ClientNotesDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ClientNotesDataGridView.Sort(ClientNotesDataGridView.Columns(0), direction:=ListSortDirection.Descending)
        'TODO: This line of code loads data into the 'ActionLogDBDataSet.Invoices' table. You can move, or remove it, as needed.
        InvoicesTableAdapter.Fill(ActionLogDBDataSet.Invoices)
        InvoicesDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'TODO: This line of code loads data into the 'ActionLogDBDataSet.Undertakings' table. You can move, or remove it, as needed.
        UndertakingsTableAdapter.Fill(ActionLogDBDataSet.Undertakings)
        UndertakingsDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'TODO: This line of code loads data into the 'ActionLogDBDataSet.ABDenials' table. You can move, or remove it, as needed.
        ABDenialsTableAdapter.Fill(ActionLogDBDataSet.ABDenials)
        ABDenialsDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        'TODO: This line of code loads data into the 'ActionLogDBDataSet.PLReports' table. You can move, or remove it, as needed.
        PLReportsTableAdapter.Fill(ActionLogDBDataSet.PLReports)
        'TODO: This line of code loads data into the 'ActionLogDBDataSet.MedAppts' table. You can move, or remove it, as needed.
        MedApptsTableAdapter.Fill(ActionLogDBDataSet.MedAppts)
        MedApptsDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        MedApptsDataGridView.Sort(MedApptsDataGridView.Columns(6), direction:=ListSortDirection.Descending)
        'MedApptsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        'TODO: This line of code loads data into the 'ActionLogDBDataSet.Main' table. You can move, or remove it, as needed.
        MainTableAdapter.Fill(ActionLogDBDataSet.Main)

        'TODO: This line of code loads data into the 'ActionLogDBDataSet.ActionLog' table. You can move, or remove it, as needed.
        ActionLogTableAdapter.Fill(ActionLogDBDataSet.ActionLog)
        ActionLogDataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        ActionLogDataGridView.Sort(ActionLogDataGridView.Columns(7), direction:=ListSortDirection.Descending)
        'ActionLogDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        Call updateTables()
        'Call GrayoutRows()
    End Sub

    Private Sub ActionLogBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Validate()
        ActionLogBindingSource.EndEdit()
        TableAdapterManager.UpdateAll(ActionLogDBDataSet)

    End Sub
    Private Sub MainComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainComboBox.SelectedIndexChanged
        Call updateTables()
        Call frmtDateTxtBox()
    End Sub
    Private Sub updateTables()
        LATBindingSource.RemoveFilter()
        ActionLogBindingSource.RemoveFilter()
        MedApptsBindingSource.RemoveFilter()
        PLReportsBindingSource.RemoveFilter()
        ABDenialsBindingSource.RemoveFilter()
        ClientNotesBindingSource.RemoveFilter()
        InvoicesBindingSource.RemoveFilter()
        UndertakingsBindingSource.RemoveFilter()
        On Error GoTo next1
        ActionLogBindingSource.Filter = FN & MainComboBox.Text
        MedApptsBindingSource.Filter = FN & MainComboBox.Text
        PLReportsBindingSource.Filter = FN & MainComboBox.Text
        ABDenialsBindingSource.Filter = FN & MainComboBox.Text
        ClientNotesBindingSource.Filter = FN & MainComboBox.Text
        InvoicesBindingSource.Filter = FN & MainComboBox.Text
        UndertakingsBindingSource.Filter = FN & MainComboBox.Text
        LATBindingSource.Filter = FN & MainComboBox.Text
        Exit Sub
next1:
        MsgBox("Search Not Found")

    End Sub
    Private Sub searchBox_TextChanged(sender As Object, e As EventArgs) Handles searchBox.TextChanged
        If searchBox.Text = "" Then
            updateTables()
            MainBindingSource.RemoveFilter()
            Exit Sub
        Else

            Call updateTables()
            MainBindingSource.Filter = "(cBoxClientName LIKE '%" + searchBox.Text + "%') OR (Convert(cBoxFileNumber,'System.String') LIKE '%" + searchBox.Text + "%')" '"(Convert(cBoxFileNumber,'System.String') LIKE '" & searchBox.Text & "') OR

        End If
    End Sub

    Private Sub TBoxLimDateTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxLimDateTextBox.TextChanged
        TBoxLimDateTextBox.Text = formatDate(TBoxLimDateTextBox)
    End Sub

    Private Function formatDate(txtBox As TextBox)
        If txtBox.Text <> "" Then
            'Dim dte As Date = Format(CDate(txtBox.Text), "MMM/dd/yyyy")
            formatDate = Format(CDate(txtBox.Text), "MMM-dd-yyyy")
        Else
            formatDate = Nothing
        End If
    End Function

    Private Sub TBoxDateOfLossTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxDateOfLossTextBox.TextChanged
        TBoxDateOfLossTextBox.Text = formatDate(TBoxDateOfLossTextBox)
    End Sub

    Private Sub TBoxFileOpenDateTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxFileOpenDateTextBox.TextChanged
        TBoxFileOpenDateTextBox.Text = formatDate(TBoxFileOpenDateTextBox)
    End Sub

    Private Sub TBoxFileCloseDateTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxFileCloseDateTextBox.TextChanged
        TBoxFileCloseDateTextBox.Text = formatDate(TBoxFileCloseDateTextBox)
    End Sub



    Private Sub ActionLogDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ActionLogDataGridView.CellFormatting
        For Each row As DataGridViewRow In ActionLogDataGridView.Rows
            If row.Cells(0).Value = "Done" Then
                row.DefaultCellStyle.ForeColor = Color.LightGray
            End If
            For i = 0 To 12
                If IsDate(row.Cells(i).Value) Then
                    row.Cells(i).Value = Format(CDate(row.Cells(i).Value), "MMM-dd-yy")
                End If
            Next i
        Next

    End Sub

    Private Sub MedApptsDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles MedApptsDataGridView.CellFormatting
        Dim dte As Date
        For Each row As DataGridViewRow In MedApptsDataGridView.Rows
            If IsDate(row.Cells(6).Value) Then
                dte = CDate(row.Cells(6).Value)
                If dte < Date.Now Then
                    row.DefaultCellStyle.ForeColor = Color.LightGray
                End If
                row.Cells(6).Value = Format(CDate(row.Cells(6).Value), "MMM-dd-yy")
            End If
            If IsDate(row.Cells(7).Value) Then
                row.Cells(7).Value = Format(CDate(row.Cells(7).Value), "hh:mm tt")
            End If
        Next

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "" Then
            ActionLogBindingSource.RemoveFilter()

            Exit Sub
        Else
            Dim strg As String = ComboBox2.Text
            On Error GoTo next1
            ActionLogBindingSource.Filter = "(FileNumber = " + MainComboBox.Text + ") AND (State = '" + strg + "')"

            Exit Sub
        End If
next1:
        ActionLogBindingSource.RemoveFilter()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox2.Text = ""
        ActionLogBindingSource.RemoveFilter()
        On Error Resume Next
        ActionLogBindingSource.Filter = "(FileNumber = " + MainComboBox.Text
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.Text = "" Then
            MedApptsBindingSource.RemoveFilter()
            Exit Sub
        Else
            Dim strg As String = ComboBox3.Text
            On Error GoTo next1
            MedApptsBindingSource.Filter = "(FileNumber = " + MainComboBox.Text + ") AND (State = '" + strg + "')"
            Exit Sub
        End If
next1:
        MedApptsBindingSource.RemoveFilter()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox3.Text = ""
        MedApptsBindingSource.RemoveFilter()
        On Error Resume Next
        MedApptsBindingSource.Filter = "(FileNumber = " + MainComboBox.Text
    End Sub

    Private Sub ClientNotesDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ClientNotesDataGridView.CellFormatting
        For Each row As DataGridViewRow In ClientNotesDataGridView.Rows
            If IsDate(row.Cells(1).Value) Then
                row.Cells(1).Value = Format(CDate(row.Cells(1).Value), "hh:mm tt")
            End If
            If IsDate(row.Cells(0).Value) Then
                row.Cells(0).Value = Format(CDate(row.Cells(0).Value), "MMM-dd-yy")
            End If
        Next
    End Sub

    Private Sub TBoxLiabilityMeetingDateTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxLiabilityMeetingDateTextBox.TextChanged

        TBoxLiabilityMeetingDateTextBox.Text = formatDate(TBoxLiabilityMeetingDateTextBox)
    End Sub

    Private Sub TBoxProposedDateIssueSOCTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxProposedDateIssueSOCTextBox.TextChanged

        TBoxProposedDateIssueSOCTextBox.Text = formatDate(TBoxProposedDateIssueSOCTextBox)
    End Sub

    Private Sub TBoxActualDateSOCIssuedTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxActualDateSOCIssuedTextBox.TextChanged

        TBoxActualDateSOCIssuedTextBox.Text = formatDate(TBoxActualDateSOCIssuedTextBox)
    End Sub

    Private Sub TBoxMedicalSummariesPreDiscDueDateTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxMedicalSummariesPreDiscDueDateTextBox.TextChanged

        TBoxMedicalSummariesPreDiscDueDateTextBox.Text = formatDate(TBoxMedicalSummariesPreDiscDueDateTextBox)
    End Sub

    Private Sub TBoxProposedDateToServeSOCTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxProposedDateToServeSOCTextBox.TextChanged

        TBoxProposedDateToServeSOCTextBox.Text = formatDate(TBoxProposedDateToServeSOCTextBox)
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Call ABDenialsFilters()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Call ABDenialsFilters()
    End Sub
    Private Sub ABDenialsFilters()
        Dim strg As String
        Dim strg1 As String
        If ComboBox4.Text = "" And ComboBox5.Text = "" Then
            ABDenialsBindingSource.RemoveFilter()
            Exit Sub
        ElseIf ComboBox4.Text <> "" And ComboBox5.Text = "" Then
            strg = ComboBox4.Text
            On Error GoTo next1
            ABDenialsBindingSource.Filter = "(FileNumber = " + MainComboBox.Text + ") AND (NameofBenefit = '" + strg + "')"
            Exit Sub
        ElseIf ComboBox4.Text = "" And ComboBox5.Text <> "" Then
            strg = ComboBox5.Text
            On Error GoTo next1
            ABDenialsBindingSource.Filter = "(FileNumber = " + MainComboBox.Text + ") AND (Status = '" + strg + "')"
            Exit Sub
        ElseIf ComboBox4.Text <> "" And ComboBox5.Text <> "" Then
            strg = ComboBox4.Text
            strg1 = ComboBox5.Text
            On Error GoTo next1
            ABDenialsBindingSource.Filter = "(FileNumber = " + MainComboBox.Text + ") AND (NameofBenefit = '" + strg + "') AND (Status = '" + strg1 + "')"
            Exit Sub
        End If
next1:
        ABDenialsBindingSource.RemoveFilter()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ABDenialsBindingSource.RemoveFilter()
        On Error Resume Next
        ABDenialsBindingSource.Filter = "(FileNumber = " + MainComboBox.Text
    End Sub

    Private Sub ABDenialsDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ABDenialsDataGridView.CellFormatting
        For Each row As DataGridViewRow In ABDenialsDataGridView.Rows
            Call dateFormattingDGCol(3, row)
            Call dateFormattingDGCol(4, row)
            Call dateFormattingDGCol(10, row)
        Next
    End Sub
    Private Sub dateFormattingDGCol(col As Integer, row As DataGridViewRow)
        If IsDate(row.Cells(col).Value) Then
            row.Cells(col).Value = Format(CDate(row.Cells(col).Value), "MMM-dd-yy")
        End If
    End Sub
    Private Sub frmtDateTxtBox()
        Dim tb As TextBox
        For Each tb In Controls.OfType(Of TextBox)()
            If tb.Text <> "" Then
                tb.Text = Format(CDate(tb.Text), "MMM-dd-yyyy")
            End If
        Next
    End Sub

    Private Sub TBoxActualDateSOCServedTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxActualDateSOCServedTextBox.TextChanged

        TBoxActualDateSOCServedTextBox.Text = formatDate(TBoxActualDateSOCServedTextBox)
    End Sub

    Private Sub TBoxDateToFileTrialRecordByTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxDateToFileTrialRecordByTextBox.TextChanged
        On Error Resume Next
        TBoxDateToFileTrialRecordByTextBox.Text = formatDate(TBoxDateToFileTrialRecordByTextBox)
    End Sub

    Private Sub TBoxPreDiscoveryMeetingDateTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxPreDiscoveryMeetingDateTextBox.TextChanged
        TBoxPreDiscoveryMeetingDateTextBox.Text = formatDate(TBoxPreDiscoveryMeetingDateTextBox)
    End Sub

    Private Sub TBoxDefendantAODRequestTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxDefendantAODRequestTextBox.TextChanged
        On Error Resume Next
        TBoxDefendantAODRequestTextBox.Text = formatDate(TBoxDefendantAODRequestTextBox)
        On Error GoTo 0
    End Sub

    Private Sub TBoxDateOfPaintiffDiscoveryTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxDateOfPaintiffDiscoveryTextBox.TextChanged
        On Error Resume Next
        TBoxDateOfPaintiffDiscoveryTextBox.Text = formatDate(TBoxDateOfPaintiffDiscoveryTextBox)
    End Sub

    Private Sub TBoxPlaintiffAODSentTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxPlaintiffAODSentTextBox.TextChanged
        On Error Resume Next
        TBoxPlaintiffAODSentTextBox.Text = formatDate(TBoxPlaintiffAODSentTextBox)
    End Sub

    Private Sub TBoxDateOfDefendantDiscoveryTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxDateOfDefendantDiscoveryTextBox.TextChanged
        On Error Resume Next
        TBoxDateOfDefendantDiscoveryTextBox.Text = formatDate(TBoxDateOfDefendantDiscoveryTextBox)
    End Sub

    Private Sub TBoxDateTrialRecordFiledTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxDateTrialRecordFiledTextBox.TextChanged
        On Error Resume Next
        TBoxDateTrialRecordFiledTextBox.Text = formatDate(TBoxDateTrialRecordFiledTextBox)
    End Sub

    Private Sub TBoxDatePaintiffUndertaikingCompleteTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxDatePaintiffUndertaikingCompleteTextBox.TextChanged
        On Error Resume Next
        TBoxDatePaintiffUndertaikingCompleteTextBox.Text = formatDate(TBoxDatePaintiffUndertaikingCompleteTextBox)
    End Sub

    Private Sub TBoxAllDefendantUndertaikingRecdTextBox_TextChanged(sender As Object, e As EventArgs) Handles TBoxAllDefendantUndertaikingRecdTextBox.TextChanged
        On Error Resume Next
        TBoxAllDefendantUndertaikingRecdTextBox.Text = formatDate(TBoxAllDefendantUndertaikingRecdTextBox)
    End Sub

    Private Sub PLReportsDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        For Each row As DataGridViewRow In PLReportsDataGridView.Rows
            Call dateFormattingDGCol(0, row)
            Call dateFormattingDGCol(6, row)
            Call dateFormattingDGCol(7, row)
        Next
    End Sub

    Private Sub InvoicesDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles InvoicesDataGridView.CellFormatting
        For Each row As DataGridViewRow In InvoicesDataGridView.Rows
            Call dateFormattingDGCol(1, row)
            Call dateFormattingDGCol(2, row)
            Call dateFormattingDGCol(5, row)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Home.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub TextBox32_TextChanged(sender As Object, e As EventArgs) Handles TextBox32.TextChanged, TextBox67.TextChanged

    End Sub

    Private Sub GroupBox33_Enter(sender As Object, e As EventArgs) Handles GroupBox33.Enter, GroupBox34.Enter

    End Sub
End Class
