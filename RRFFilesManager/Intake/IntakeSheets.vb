Public Class IntakeSheets
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

    Public Sub bringMattertypeForm()
        ReceiveCopyGroupBox.Visible = False

        TabControl.TabPages.Clear()
        LiaWhereAccidentGroup.Text = "Where did the incident occur (place/address)?"
        LiaExplainGroup.Text = "Explain in detail how the incident ocurred"
        LiaHavePhotosGroup.Text = "Do you have any photos of the incident?"

        OthersLiabilityGroup.Visible = True
        MVALiabilityGroup.Visible = False
        If PreliminaryInfo.MatterTypeComboBox.Text = "Motor Vehicle Accident" Then
            ReceiveCopyGroupBox.Visible = True
            LiaWhereAccidentGroup.Text = "Where did the accident occur (place/address)?"
            LiaExplainGroup.Text = "Explain in detail how the accident ocurred"
            LiaHavePhotosGroup.Text = "Do you have any photos of the damaged vehicles?"
            OthersLiabilityGroup.Visible = False
            MVALiabilityGroup.Visible = True
        ElseIf PreliminaryInfo.MatterTypeComboBox.Text = "Occupiers Liability" Then
        ElseIf PreliminaryInfo.MatterTypeComboBox.Text = "Disability" Then
        ElseIf PreliminaryInfo.MatterTypeComboBox.Text = "General Negligence" Then
        Else

        End If


        If PreliminaryInfo.MatterTypeComboBox.Text = "Disability" Then
            TabControl.TabPages.Add(Policy)
        Else
            TabControl.TabPages.Add(Liability)
        End If

        If Not PreliminaryInfo.MatterTypeComboBox.Text = "Other Notes" Then
            TabControl.TabPages.Add(EmploymentIncomeLoss)
            TabControl.TabPages.Add(Damages)
        End If

        If PreliminaryInfo.MatterTypeComboBox.Text = "Motor Vehicle Accident" Then
            TabControl.TabPages.Add(AccidentBenefits)
        End If

        TabControl.TabPages.Add(OtherNotes)
        'getNewFileNumber(lastFileNumber)
    End Sub
    Private Sub IntakeSheets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CyaTemplatesTableAdapter.Fill(Me.ActionLogDBDataSet.CYATemplates)
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DisTypeTemplate_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DisTemplateName_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)

    End Sub
End Class
