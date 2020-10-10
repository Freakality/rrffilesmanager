<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NextSteps
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GroupBox32 = New System.Windows.Forms.GroupBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.GroupBox90 = New System.Windows.Forms.GroupBox()
        Me.InvokeCIP = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.InvokeCYP = New System.Windows.Forms.RadioButton()
        Me.MVATemplatesGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.TypeTemplate = New System.Windows.Forms.ComboBox()
        Me.TemplateName = New System.Windows.Forms.ComboBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.ActionLogDBDataSet = New RRFFilesManager.ActionLogDBDataSet()
        Me.CyaTemplatesTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.CYATemplatesTableAdapter()
        Me.CYATemplatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IntakesTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.IntakesTableAdapter()
        Me.IntakesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox32.SuspendLayout()
        Me.GroupBox90.SuspendLayout()
        Me.MVATemplatesGroupBox.SuspendLayout()
        CType(Me.ActionLogDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CYATemplatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntakesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox32
        '
        Me.GroupBox32.Controls.Add(Me.Label41)
        Me.GroupBox32.Controls.Add(Me.GroupBox90)
        Me.GroupBox32.Controls.Add(Me.MVATemplatesGroupBox)
        Me.GroupBox32.Controls.Add(Me.Submit)
        Me.GroupBox32.Location = New System.Drawing.Point(28, 32)
        Me.GroupBox32.Name = "GroupBox32"
        Me.GroupBox32.Size = New System.Drawing.Size(1295, 535)
        Me.GroupBox32.TabIndex = 2
        Me.GroupBox32.TabStop = False
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(17, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(124, 26)
        Me.Label41.TabIndex = 3
        Me.Label41.Text = "Next Steps"
        '
        'GroupBox90
        '
        Me.GroupBox90.Controls.Add(Me.InvokeCIP)
        Me.GroupBox90.Controls.Add(Me.RadioButton9)
        Me.GroupBox90.Controls.Add(Me.InvokeCYP)
        Me.GroupBox90.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox90.Location = New System.Drawing.Point(22, 74)
        Me.GroupBox90.Name = "GroupBox90"
        Me.GroupBox90.Size = New System.Drawing.Size(1252, 100)
        Me.GroupBox90.TabIndex = 161
        Me.GroupBox90.TabStop = False
        Me.GroupBox90.Text = "Steps"
        '
        'InvokeCIP
        '
        Me.InvokeCIP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InvokeCIP.AutoSize = True
        Me.InvokeCIP.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvokeCIP.Location = New System.Drawing.Point(29, 40)
        Me.InvokeCIP.Name = "InvokeCIP"
        Me.InvokeCIP.Size = New System.Drawing.Size(285, 26)
        Me.InvokeCIP.TabIndex = 0
        Me.InvokeCIP.TabStop = True
        Me.InvokeCIP.Text = "Invoke Client Intake Process"
        Me.InvokeCIP.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton9.Location = New System.Drawing.Point(1004, 40)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(228, 26)
        Me.RadioButton9.TabIndex = 160
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "Print and Hold Process"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'InvokeCYP
        '
        Me.InvokeCYP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InvokeCYP.AutoSize = True
        Me.InvokeCYP.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InvokeCYP.Location = New System.Drawing.Point(517, 40)
        Me.InvokeCYP.Name = "InvokeCYP"
        Me.InvokeCYP.Size = New System.Drawing.Size(210, 26)
        Me.InvokeCYP.TabIndex = 1
        Me.InvokeCYP.TabStop = True
        Me.InvokeCYP.Text = "Invoke CYA Process"
        Me.InvokeCYP.UseVisualStyleBackColor = True
        '
        'MVATemplatesGroupBox
        '
        Me.MVATemplatesGroupBox.Controls.Add(Me.Label74)
        Me.MVATemplatesGroupBox.Controls.Add(Me.Label73)
        Me.MVATemplatesGroupBox.Controls.Add(Me.TypeTemplate)
        Me.MVATemplatesGroupBox.Controls.Add(Me.TemplateName)
        Me.MVATemplatesGroupBox.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MVATemplatesGroupBox.Location = New System.Drawing.Point(22, 195)
        Me.MVATemplatesGroupBox.Name = "MVATemplatesGroupBox"
        Me.MVATemplatesGroupBox.Size = New System.Drawing.Size(1252, 132)
        Me.MVATemplatesGroupBox.TabIndex = 159
        Me.MVATemplatesGroupBox.TabStop = False
        Me.MVATemplatesGroupBox.Text = "Templates"
        Me.MVATemplatesGroupBox.Visible = False
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(172, 52)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(102, 16)
        Me.Label74.TabIndex = 160
        Me.Label74.Text = "Template Name"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(26, 52)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(109, 16)
        Me.Label73.TabIndex = 159
        Me.Label73.Text = "Type of Template"
        '
        'TypeTemplate
        '
        Me.TypeTemplate.FormattingEnabled = True
        Me.TypeTemplate.Items.AddRange(New Object() {"Email", "Letter"})
        Me.TypeTemplate.Location = New System.Drawing.Point(29, 72)
        Me.TypeTemplate.Name = "TypeTemplate"
        Me.TypeTemplate.Size = New System.Drawing.Size(106, 24)
        Me.TypeTemplate.TabIndex = 157
        '
        'TemplateName
        '
        Me.TemplateName.FormattingEnabled = True
        Me.TemplateName.Location = New System.Drawing.Point(175, 72)
        Me.TemplateName.Name = "TemplateName"
        Me.TemplateName.Size = New System.Drawing.Size(1057, 24)
        Me.TemplateName.TabIndex = 158
        '
        'Submit
        '
        Me.Submit.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Submit.BackColor = System.Drawing.Color.Maroon
        Me.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Submit.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.ForeColor = System.Drawing.Color.White
        Me.Submit.Location = New System.Drawing.Point(300, 367)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(658, 54)
        Me.Submit.TabIndex = 156
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = False
        Me.Submit.Visible = False
        '
        'ActionLogDBDataSet
        '
        Me.ActionLogDBDataSet.DataSetName = "ActionLogDBDataSet"
        Me.ActionLogDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CyaTemplatesTableAdapter
        '
        Me.CyaTemplatesTableAdapter.ClearBeforeFill = True
        '
        'CYATemplatesBindingSource
        '
        Me.CYATemplatesBindingSource.DataMember = "CYATemplates"
        Me.CYATemplatesBindingSource.DataSource = Me.ActionLogDBDataSet
        '
        'IntakesTableAdapter
        '
        Me.IntakesTableAdapter.ClearBeforeFill = True
        '
        'IntakesBindingSource
        '
        Me.IntakesBindingSource.DataMember = "Intakes"
        Me.IntakesBindingSource.DataSource = Me.ActionLogDBDataSet
        '
        'NextSteps
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GroupBox32)
        Me.Name = "NextSteps"
        Me.Size = New System.Drawing.Size(1350, 610)
        Me.GroupBox32.ResumeLayout(False)
        Me.GroupBox32.PerformLayout()
        Me.GroupBox90.ResumeLayout(False)
        Me.GroupBox90.PerformLayout()
        Me.MVATemplatesGroupBox.ResumeLayout(False)
        Me.MVATemplatesGroupBox.PerformLayout()
        CType(Me.ActionLogDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CYATemplatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntakesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox32 As GroupBox
    Friend WithEvents GroupBox90 As GroupBox
    Friend WithEvents InvokeCIP As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents InvokeCYP As RadioButton
    Friend WithEvents MVATemplatesGroupBox As GroupBox
    Friend WithEvents Label74 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents TypeTemplate As ComboBox
    Friend WithEvents TemplateName As ComboBox
    Friend WithEvents Submit As Button
    Friend WithEvents ActionLogDBDataSet As ActionLogDBDataSet
    Friend WithEvents CyaTemplatesTableAdapter As ActionLogDBDataSetTableAdapters.CYATemplatesTableAdapter
    Friend WithEvents CYATemplatesBindingSource As BindingSource
    Friend WithEvents IntakesTableAdapter As ActionLogDBDataSetTableAdapters.IntakesTableAdapter
    Friend WithEvents IntakesBindingSource As BindingSource
    Friend WithEvents Label41 As Label
End Class
