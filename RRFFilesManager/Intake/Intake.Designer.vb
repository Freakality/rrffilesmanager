<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Intake
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.MatterTypeTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.MatterTypeTableAdapter()
        Me.FileLawyerTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.FileLawyerTableAdapter()
        Me.TableAdapterManager = New RRFFilesManager.ActionLogDBDataSetTableAdapters.TableAdapterManager()
        Me.MatterSubTypes1TableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.MatterSubTypes1TableAdapter()
        Me.ResponsibleLawyerTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.ResponsibleLawyerTableAdapter()
        Me.StaffInterviewerTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.StaffInterviewerTableAdapter()
        Me.HearAboutUsTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.HearAboutUsTableAdapter()
        Me.ProvincesTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.ProvincesTableAdapter()
        Me.MobileCarrierTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.MobileCarrierTableAdapter()
        Me.InsuranceCompaniesTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.InsuranceCompaniesTableAdapter()
        Me.DisabilityInsuranceCompaniesTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.DisabilityInsuranceCompaniesTableAdapter()
        Me.MatterSubTypesTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.MatterSubTypesTableAdapter()
        Me.IntakesTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.IntakesTableAdapter()
        Me.CYATemplatesTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.CYATemplatesTableAdapter()
        Me.Container = New System.Windows.Forms.Panel()
        Me.Actions = New System.Windows.Forms.Panel()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.Content = New System.Windows.Forms.Panel()
        Me.ActionLogDBDataSet = New RRFFilesManager.ActionLogDBDataSet()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IntakesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InsuranceCompaniesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DisabilityInsuranceCompaniesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HearAboutUsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvincesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MobileCarrierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MatterSubTypes1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MatterSubTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CYATemplatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Container.SuspendLayout()
        Me.Actions.SuspendLayout()
        CType(Me.ActionLogDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntakesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InsuranceCompaniesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisabilityInsuranceCompaniesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HearAboutUsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvincesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileCarrierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatterSubTypes1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatterSubTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CYATemplatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.Maroon
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(942, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 35)
        Me.Button4.TabIndex = 139
        Me.Button4.Text = "Home"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.Maroon
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(696, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(211, 35)
        Me.Button5.TabIndex = 143
        Me.Button5.Text = "Conflict Checks"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'MatterTypeTableAdapter
        '
        Me.MatterTypeTableAdapter.ClearBeforeFill = True
        '
        'FileLawyerTableAdapter
        '
        Me.FileLawyerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ABDenialsTableAdapter = Nothing
        Me.TableAdapterManager.ActionLogTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientNotesTableAdapter = Nothing
        Me.TableAdapterManager.CYATemplatesTableAdapter = Nothing
        Me.TableAdapterManager.DisabilityInsuranceCompaniesTableAdapter = Nothing
        Me.TableAdapterManager.FileLawyer1TableAdapter = Nothing
        Me.TableAdapterManager.FileLawyerTableAdapter = Me.FileLawyerTableAdapter
        Me.TableAdapterManager.HearAboutUsTableAdapter = Nothing
        Me.TableAdapterManager.InsuranceCompaniesTableAdapter = Nothing
        Me.TableAdapterManager.IntakesTableAdapter = Nothing
        Me.TableAdapterManager.InvoicesTableAdapter = Nothing
        Me.TableAdapterManager.LATTableAdapter = Nothing
        Me.TableAdapterManager.MainTableAdapter = Nothing
        Me.TableAdapterManager.MatterSubTypes1TableAdapter = Me.MatterSubTypes1TableAdapter
        Me.TableAdapterManager.MatterSubTypesTableAdapter = Nothing
        Me.TableAdapterManager.MatterTypeTableAdapter = Me.MatterTypeTableAdapter
        Me.TableAdapterManager.MedApptsTableAdapter = Nothing
        Me.TableAdapterManager.MobileCarrierTableAdapter = Nothing
        Me.TableAdapterManager.PLReportsTableAdapter = Nothing
        Me.TableAdapterManager.ProvincesTableAdapter = Nothing
        Me.TableAdapterManager.ResponsibleLawyerTableAdapter = Me.ResponsibleLawyerTableAdapter
        Me.TableAdapterManager.SpecialDamagesTableAdapter = Nothing
        Me.TableAdapterManager.StaffInterviewerTableAdapter = Me.StaffInterviewerTableAdapter
        Me.TableAdapterManager.UndertakingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = RRFFilesManager.ActionLogDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MatterSubTypes1TableAdapter
        '
        Me.MatterSubTypes1TableAdapter.ClearBeforeFill = True
        '
        'ResponsibleLawyerTableAdapter
        '
        Me.ResponsibleLawyerTableAdapter.ClearBeforeFill = True
        '
        'StaffInterviewerTableAdapter
        '
        Me.StaffInterviewerTableAdapter.ClearBeforeFill = True
        '
        'HearAboutUsTableAdapter
        '
        Me.HearAboutUsTableAdapter.ClearBeforeFill = True
        '
        'ProvincesTableAdapter
        '
        Me.ProvincesTableAdapter.ClearBeforeFill = True
        '
        'MobileCarrierTableAdapter
        '
        Me.MobileCarrierTableAdapter.ClearBeforeFill = True
        '
        'InsuranceCompaniesTableAdapter
        '
        Me.InsuranceCompaniesTableAdapter.ClearBeforeFill = True
        '
        'DisabilityInsuranceCompaniesTableAdapter
        '
        Me.DisabilityInsuranceCompaniesTableAdapter.ClearBeforeFill = True
        '
        'MatterSubTypesTableAdapter
        '
        Me.MatterSubTypesTableAdapter.ClearBeforeFill = True
        '
        'IntakesTableAdapter
        '
        Me.IntakesTableAdapter.ClearBeforeFill = True
        '
        'CYATemplatesTableAdapter
        '
        Me.CYATemplatesTableAdapter.ClearBeforeFill = True
        '
        'Container
        '
        Me.Container.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Container.BackColor = System.Drawing.Color.White
        Me.Container.Controls.Add(Me.Actions)
        Me.Container.Controls.Add(Me.Content)
        Me.Container.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Container.Location = New System.Drawing.Point(0, 52)
        Me.Container.Name = "Container"
        Me.Container.Size = New System.Drawing.Size(1350, 677)
        Me.Container.TabIndex = 144
        '
        'Actions
        '
        Me.Actions.Controls.Add(Me.NextButton)
        Me.Actions.Controls.Add(Me.BackButton)
        Me.Actions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Actions.Location = New System.Drawing.Point(0, 613)
        Me.Actions.Name = "Actions"
        Me.Actions.Size = New System.Drawing.Size(1350, 64)
        Me.Actions.TabIndex = 142
        '
        'NextButton
        '
        Me.NextButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NextButton.BackColor = System.Drawing.Color.Maroon
        Me.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NextButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextButton.ForeColor = System.Drawing.Color.White
        Me.NextButton.Location = New System.Drawing.Point(1209, 11)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(111, 35)
        Me.NextButton.TabIndex = 141
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackButton.BackColor = System.Drawing.Color.Maroon
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Location = New System.Drawing.Point(31, 11)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(111, 35)
        Me.BackButton.TabIndex = 140
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'Content
        '
        Me.Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Content.Location = New System.Drawing.Point(0, 0)
        Me.Content.Name = "Content"
        Me.Content.Size = New System.Drawing.Size(1350, 677)
        Me.Content.TabIndex = 143
        '
        'ActionLogDBDataSet
        '
        Me.ActionLogDBDataSet.DataSetName = "ActionLogDBDataSet"
        Me.ActionLogDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.RRFFilesManager.My.Resources.Resources.RRFLogo
        Me.PictureBox1.Location = New System.Drawing.Point(1096, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 138
        Me.PictureBox1.TabStop = False
        '
        'Intake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Container)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Intake"
        Me.Text = "Intake Sheets"
        Me.Container.ResumeLayout(False)
        Me.Actions.ResumeLayout(False)
        CType(Me.ActionLogDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntakesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InsuranceCompaniesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisabilityInsuranceCompaniesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HearAboutUsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvincesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileCarrierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatterSubTypes1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatterSubTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CYATemplatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents MatterTypeTableAdapter As ActionLogDBDataSetTableAdapters.MatterTypeTableAdapter
    Friend WithEvents FileLawyerTableAdapter As ActionLogDBDataSetTableAdapters.FileLawyerTableAdapter
    Friend WithEvents IntakesBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As ActionLogDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MatterSubTypes1TableAdapter As ActionLogDBDataSetTableAdapters.MatterSubTypes1TableAdapter
    Friend WithEvents MatterSubTypes1BindingSource As BindingSource
    Friend WithEvents ResponsibleLawyerTableAdapter As ActionLogDBDataSetTableAdapters.ResponsibleLawyerTableAdapter
    Friend WithEvents StaffInterviewerTableAdapter As ActionLogDBDataSetTableAdapters.StaffInterviewerTableAdapter
    Friend WithEvents HearAboutUsBindingSource As BindingSource
    Friend WithEvents HearAboutUsTableAdapter As ActionLogDBDataSetTableAdapters.HearAboutUsTableAdapter
    Friend WithEvents ProvincesBindingSource As BindingSource
    Friend WithEvents ProvincesTableAdapter As ActionLogDBDataSetTableAdapters.ProvincesTableAdapter
    Friend WithEvents MobileCarrierBindingSource As BindingSource
    Friend WithEvents MobileCarrierTableAdapter As ActionLogDBDataSetTableAdapters.MobileCarrierTableAdapter
    Friend WithEvents InsuranceCompaniesBindingSource As BindingSource
    Friend WithEvents InsuranceCompaniesTableAdapter As ActionLogDBDataSetTableAdapters.InsuranceCompaniesTableAdapter
    Friend WithEvents DisabilityInsuranceCompaniesBindingSource As BindingSource
    Friend WithEvents DisabilityInsuranceCompaniesTableAdapter As ActionLogDBDataSetTableAdapters.DisabilityInsuranceCompaniesTableAdapter
    Friend WithEvents Button5 As Button
    Friend WithEvents MatterSubTypesBindingSource As BindingSource
    Friend WithEvents MatterSubTypesTableAdapter As ActionLogDBDataSetTableAdapters.MatterSubTypesTableAdapter
    Friend WithEvents IntakesTableAdapter As ActionLogDBDataSetTableAdapters.IntakesTableAdapter
    Friend WithEvents CYATemplatesBindingSource As BindingSource
    Friend WithEvents CYATemplatesTableAdapter As ActionLogDBDataSetTableAdapters.CYATemplatesTableAdapter
    Friend WithEvents Container As Panel
    Friend WithEvents Actions As Panel
    Friend WithEvents NextButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents Content As Panel
    Friend WithEvents ActionLogDBDataSet As ActionLogDBDataSet
End Class
