<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PreliminaryInfo
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim AdditionalNotesLabel As System.Windows.Forms.Label
        Dim FileNumberLabel As System.Windows.Forms.Label
        Dim StaffInterviewerLabel As System.Windows.Forms.Label
        Dim MatterSubTypeLabel As System.Windows.Forms.Label
        Dim LimitationPeriodLabel As System.Windows.Forms.Label
        Dim ResponsibleLawyerLabel As System.Windows.Forms.Label
        Dim HowHearLabel As System.Windows.Forms.Label
        Dim FileLawyerLabel As System.Windows.Forms.Label
        Dim DateOfLossLabel As System.Windows.Forms.Label
        Dim DateOFCallLabel As System.Windows.Forms.Label
        Me.PreliminayPanel = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.MatterTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.IntakesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ActionLogDBDataSet = New RRFFilesManager.ActionLogDBDataSet()
        Me.MatterTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AdditionalNotesTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LawyerComboBox = New System.Windows.Forms.ComboBox()
        Me.FileLawyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MatterSubTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.FileNumberTextBox = New System.Windows.Forms.TextBox()
        Me.StaffInterviewerComboBox = New System.Windows.Forms.ComboBox()
        Me.StaffInterviewerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ResponsibleLawyerComboBox = New System.Windows.Forms.ComboBox()
        Me.ResponsibleLawyerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LimitationPeriodTextBox = New System.Windows.Forms.TextBox()
        Me.HowHearComboBox = New System.Windows.Forms.ComboBox()
        Me.HearAboutUsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateOfLossDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatutoryNoticeBox = New System.Windows.Forms.TextBox()
        Me.DateOFCallDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.MatterTypeTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.MatterTypeTableAdapter()
        Me.MatterSubTypesTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.MatterSubTypesTableAdapter()
        Me.IntakesTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.IntakesTableAdapter()
        Me.ResponsibleLawyerTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.ResponsibleLawyerTableAdapter()
        Me.HearAboutUsTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.HearAboutUsTableAdapter()
        Me.StaffInterviewerTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.StaffInterviewerTableAdapter()
        Me.FileLawyerTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.FileLawyerTableAdapter()
        AdditionalNotesLabel = New System.Windows.Forms.Label()
        FileNumberLabel = New System.Windows.Forms.Label()
        StaffInterviewerLabel = New System.Windows.Forms.Label()
        MatterSubTypeLabel = New System.Windows.Forms.Label()
        LimitationPeriodLabel = New System.Windows.Forms.Label()
        ResponsibleLawyerLabel = New System.Windows.Forms.Label()
        HowHearLabel = New System.Windows.Forms.Label()
        FileLawyerLabel = New System.Windows.Forms.Label()
        DateOfLossLabel = New System.Windows.Forms.Label()
        DateOFCallLabel = New System.Windows.Forms.Label()
        Me.PreliminayPanel.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.IntakesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActionLogDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MatterTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.FileLawyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffInterviewerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResponsibleLawyerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HearAboutUsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdditionalNotesLabel
        '
        AdditionalNotesLabel.AutoSize = True
        AdditionalNotesLabel.Location = New System.Drawing.Point(3, 0)
        AdditionalNotesLabel.Name = "AdditionalNotesLabel"
        AdditionalNotesLabel.Size = New System.Drawing.Size(120, 17)
        AdditionalNotesLabel.TabIndex = 22
        AdditionalNotesLabel.Text = "Additional Notes:"
        '
        'FileNumberLabel
        '
        FileNumberLabel.AutoSize = True
        FileNumberLabel.Location = New System.Drawing.Point(3, 184)
        FileNumberLabel.Name = "FileNumberLabel"
        FileNumberLabel.Size = New System.Drawing.Size(88, 17)
        FileNumberLabel.TabIndex = 2
        FileNumberLabel.Text = "File Number:"
        '
        'StaffInterviewerLabel
        '
        StaffInterviewerLabel.AutoSize = True
        StaffInterviewerLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StaffInterviewerLabel.ForeColor = System.Drawing.Color.Black
        StaffInterviewerLabel.Location = New System.Drawing.Point(585, 0)
        StaffInterviewerLabel.Name = "StaffInterviewerLabel"
        StaffInterviewerLabel.Size = New System.Drawing.Size(115, 17)
        StaffInterviewerLabel.TabIndex = 10
        StaffInterviewerLabel.Text = "Staff Interviewer:"
        '
        'MatterSubTypeLabel
        '
        MatterSubTypeLabel.AutoSize = True
        MatterSubTypeLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MatterSubTypeLabel.ForeColor = System.Drawing.Color.Black
        MatterSubTypeLabel.Location = New System.Drawing.Point(585, 138)
        MatterSubTypeLabel.Name = "MatterSubTypeLabel"
        MatterSubTypeLabel.Size = New System.Drawing.Size(113, 17)
        MatterSubTypeLabel.TabIndex = 18
        MatterSubTypeLabel.Text = "Matter Sub Type:"
        '
        'LimitationPeriodLabel
        '
        LimitationPeriodLabel.AutoSize = True
        LimitationPeriodLabel.Location = New System.Drawing.Point(3, 138)
        LimitationPeriodLabel.Name = "LimitationPeriodLabel"
        LimitationPeriodLabel.Size = New System.Drawing.Size(76, 34)
        LimitationPeriodLabel.TabIndex = 20
        LimitationPeriodLabel.Text = "Limitation Period:"
        '
        'ResponsibleLawyerLabel
        '
        ResponsibleLawyerLabel.AutoSize = True
        ResponsibleLawyerLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ResponsibleLawyerLabel.ForeColor = System.Drawing.Color.Black
        ResponsibleLawyerLabel.Location = New System.Drawing.Point(3, 92)
        ResponsibleLawyerLabel.Name = "ResponsibleLawyerLabel"
        ResponsibleLawyerLabel.Size = New System.Drawing.Size(87, 34)
        ResponsibleLawyerLabel.TabIndex = 16
        ResponsibleLawyerLabel.Text = "Responsible Lawyer:"
        '
        'HowHearLabel
        '
        HowHearLabel.AutoSize = True
        HowHearLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HowHearLabel.ForeColor = System.Drawing.Color.Black
        HowHearLabel.Location = New System.Drawing.Point(3, 46)
        HowHearLabel.Name = "HowHearLabel"
        HowHearLabel.Size = New System.Drawing.Size(106, 34)
        HowHearLabel.TabIndex = 12
        HowHearLabel.Text = "How did you hear about us?"
        '
        'FileLawyerLabel
        '
        FileLawyerLabel.AutoSize = True
        FileLawyerLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FileLawyerLabel.ForeColor = System.Drawing.Color.Black
        FileLawyerLabel.Location = New System.Drawing.Point(585, 46)
        FileLawyerLabel.Name = "FileLawyerLabel"
        FileLawyerLabel.Size = New System.Drawing.Size(81, 17)
        FileLawyerLabel.TabIndex = 14
        FileLawyerLabel.Text = "File Lawyer:"
        '
        'DateOfLossLabel
        '
        DateOfLossLabel.AutoSize = True
        DateOfLossLabel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateOfLossLabel.ForeColor = System.Drawing.Color.Black
        DateOfLossLabel.Location = New System.Drawing.Point(585, 92)
        DateOfLossLabel.Name = "DateOfLossLabel"
        DateOfLossLabel.Size = New System.Drawing.Size(92, 17)
        DateOfLossLabel.TabIndex = 8
        DateOfLossLabel.Text = "Date Of Loss:"
        '
        'DateOFCallLabel
        '
        DateOFCallLabel.AutoSize = True
        DateOFCallLabel.Location = New System.Drawing.Point(3, 0)
        DateOFCallLabel.Name = "DateOFCallLabel"
        DateOFCallLabel.Size = New System.Drawing.Size(91, 17)
        DateOFCallLabel.TabIndex = 6
        DateOFCallLabel.Text = "Date of Call:"
        '
        'PreliminayPanel
        '
        Me.PreliminayPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PreliminayPanel.BackColor = System.Drawing.Color.White
        Me.PreliminayPanel.Controls.Add(Me.GroupBox6)
        Me.PreliminayPanel.Controls.Add(Me.TableLayoutPanel2)
        Me.PreliminayPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.PreliminayPanel.Controls.Add(Me.Label42)
        Me.PreliminayPanel.Controls.Add(Me.TextBox1)
        Me.PreliminayPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PreliminayPanel.Location = New System.Drawing.Point(24, 24)
        Me.PreliminayPanel.Name = "PreliminayPanel"
        Me.PreliminayPanel.Size = New System.Drawing.Size(1295, 535)
        Me.PreliminayPanel.TabIndex = 143
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.MatterTypeComboBox)
        Me.GroupBox6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(479, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(341, 68)
        Me.GroupBox6.TabIndex = 141
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Matter Type"
        '
        'MatterTypeComboBox
        '
        Me.MatterTypeComboBox.BackColor = System.Drawing.Color.White
        Me.MatterTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "MatterType", True))
        Me.MatterTypeComboBox.DataSource = Me.MatterTypeBindingSource
        Me.MatterTypeComboBox.DisplayMember = "MatterType"
        Me.MatterTypeComboBox.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MatterTypeComboBox.FormattingEnabled = True
        Me.MatterTypeComboBox.Location = New System.Drawing.Point(21, 28)
        Me.MatterTypeComboBox.Name = "MatterTypeComboBox"
        Me.MatterTypeComboBox.Size = New System.Drawing.Size(300, 25)
        Me.MatterTypeComboBox.TabIndex = 139
        Me.MatterTypeComboBox.ValueMember = "MatterType"
        '
        'IntakesBindingSource
        '
        Me.IntakesBindingSource.DataMember = "Intakes"
        Me.IntakesBindingSource.DataSource = Me.ActionLogDBDataSet
        '
        'ActionLogDBDataSet
        '
        Me.ActionLogDBDataSet.DataSetName = "ActionLogDBDataSet"
        Me.ActionLogDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MatterTypeBindingSource
        '
        Me.MatterTypeBindingSource.DataMember = "MatterType"
        Me.MatterTypeBindingSource.DataSource = Me.ActionLogDBDataSet
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30043!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.69957!))
        Me.TableLayoutPanel2.Controls.Add(AdditionalNotesLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.AdditionalNotesTextBox, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(25, 329)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1232, 183)
        Me.TableLayoutPanel2.TabIndex = 26
        '
        'AdditionalNotesTextBox
        '
        Me.AdditionalNotesTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdditionalNotesTextBox.BackColor = System.Drawing.Color.White
        Me.AdditionalNotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "AdditionalNotes", True))
        Me.AdditionalNotesTextBox.Location = New System.Drawing.Point(129, 3)
        Me.AdditionalNotesTextBox.Multiline = True
        Me.AdditionalNotesTextBox.Name = "AdditionalNotesTextBox"
        Me.AdditionalNotesTextBox.Size = New System.Drawing.Size(1100, 177)
        Me.AdditionalNotesTextBox.TabIndex = 23
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10952!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.23673!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.27801!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.37574!))
        Me.TableLayoutPanel1.Controls.Add(Me.LawyerComboBox, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(FileNumberLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.MatterSubTypeComboBox, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.FileNumberTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.StaffInterviewerComboBox, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(StaffInterviewerLabel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(MatterSubTypeLabel, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ResponsibleLawyerComboBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LimitationPeriodTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(LimitationPeriodLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(ResponsibleLawyerLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.HowHearComboBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DateOfLossDateTimePicker, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(HowHearLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(FileLawyerLabel, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(DateOfLossLabel, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.StatutoryNoticeBox, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(DateOFCallLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DateOFCallDateTimePicker, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(25, 83)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1232, 233)
        Me.TableLayoutPanel1.TabIndex = 25
        '
        'LawyerComboBox
        '
        Me.LawyerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "FileLawyer", True))
        Me.LawyerComboBox.DataSource = Me.FileLawyerBindingSource
        Me.LawyerComboBox.DisplayMember = "Lawyer"
        Me.LawyerComboBox.FormattingEnabled = True
        Me.LawyerComboBox.Location = New System.Drawing.Point(711, 49)
        Me.LawyerComboBox.Name = "LawyerComboBox"
        Me.LawyerComboBox.Size = New System.Drawing.Size(489, 25)
        Me.LawyerComboBox.TabIndex = 26
        Me.LawyerComboBox.ValueMember = "Lawyer"
        '
        'FileLawyerBindingSource
        '
        Me.FileLawyerBindingSource.DataMember = "FileLawyer"
        Me.FileLawyerBindingSource.DataSource = Me.ActionLogDBDataSet
        '
        'MatterSubTypeComboBox
        '
        Me.MatterSubTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "MatterSubType", True))
        Me.MatterSubTypeComboBox.FormattingEnabled = True
        Me.MatterSubTypeComboBox.Location = New System.Drawing.Point(711, 141)
        Me.MatterSubTypeComboBox.Name = "MatterSubTypeComboBox"
        Me.MatterSubTypeComboBox.Size = New System.Drawing.Size(489, 25)
        Me.MatterSubTypeComboBox.TabIndex = 24
        '
        'FileNumberTextBox
        '
        Me.FileNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "FileNumber", True))
        Me.FileNumberTextBox.Enabled = False
        Me.FileNumberTextBox.Location = New System.Drawing.Point(127, 187)
        Me.FileNumberTextBox.Name = "FileNumberTextBox"
        Me.FileNumberTextBox.Size = New System.Drawing.Size(435, 23)
        Me.FileNumberTextBox.TabIndex = 3
        '
        'StaffInterviewerComboBox
        '
        Me.StaffInterviewerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "StaffInterviewer", True))
        Me.StaffInterviewerComboBox.DataSource = Me.StaffInterviewerBindingSource
        Me.StaffInterviewerComboBox.DisplayMember = "Lawyer"
        Me.StaffInterviewerComboBox.FormattingEnabled = True
        Me.StaffInterviewerComboBox.Location = New System.Drawing.Point(711, 3)
        Me.StaffInterviewerComboBox.Name = "StaffInterviewerComboBox"
        Me.StaffInterviewerComboBox.Size = New System.Drawing.Size(489, 25)
        Me.StaffInterviewerComboBox.TabIndex = 11
        Me.StaffInterviewerComboBox.ValueMember = "Lawyer"
        '
        'StaffInterviewerBindingSource
        '
        Me.StaffInterviewerBindingSource.DataMember = "StaffInterviewer"
        Me.StaffInterviewerBindingSource.DataSource = Me.ActionLogDBDataSet
        '
        'ResponsibleLawyerComboBox
        '
        Me.ResponsibleLawyerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "ResponsibleLAwyer", True))
        Me.ResponsibleLawyerComboBox.DataSource = Me.ResponsibleLawyerBindingSource
        Me.ResponsibleLawyerComboBox.DisplayMember = "Lawyer"
        Me.ResponsibleLawyerComboBox.FormattingEnabled = True
        Me.ResponsibleLawyerComboBox.Location = New System.Drawing.Point(127, 95)
        Me.ResponsibleLawyerComboBox.Name = "ResponsibleLawyerComboBox"
        Me.ResponsibleLawyerComboBox.Size = New System.Drawing.Size(435, 25)
        Me.ResponsibleLawyerComboBox.TabIndex = 17
        Me.ResponsibleLawyerComboBox.ValueMember = "Lawyer"
        '
        'ResponsibleLawyerBindingSource
        '
        Me.ResponsibleLawyerBindingSource.DataMember = "ResponsibleLawyer"
        Me.ResponsibleLawyerBindingSource.DataSource = Me.ActionLogDBDataSet
        '
        'LimitationPeriodTextBox
        '
        Me.LimitationPeriodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "LimitationPeriod", True))
        Me.LimitationPeriodTextBox.Location = New System.Drawing.Point(127, 141)
        Me.LimitationPeriodTextBox.Name = "LimitationPeriodTextBox"
        Me.LimitationPeriodTextBox.Size = New System.Drawing.Size(435, 23)
        Me.LimitationPeriodTextBox.TabIndex = 21
        '
        'HowHearComboBox
        '
        Me.HowHearComboBox.DataSource = Me.HearAboutUsBindingSource
        Me.HowHearComboBox.DisplayMember = "Option"
        Me.HowHearComboBox.FormattingEnabled = True
        Me.HowHearComboBox.Location = New System.Drawing.Point(127, 49)
        Me.HowHearComboBox.Name = "HowHearComboBox"
        Me.HowHearComboBox.Size = New System.Drawing.Size(435, 25)
        Me.HowHearComboBox.TabIndex = 13
        Me.HowHearComboBox.ValueMember = "Option"
        '
        'HearAboutUsBindingSource
        '
        Me.HearAboutUsBindingSource.DataMember = "HearAboutUs"
        Me.HearAboutUsBindingSource.DataSource = Me.ActionLogDBDataSet
        '
        'DateOfLossDateTimePicker
        '
        Me.DateOfLossDateTimePicker.CustomFormat = " "
        Me.DateOfLossDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "DateOFLoss", True))
        Me.DateOfLossDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IntakesBindingSource, "DateOFLoss", True))
        Me.DateOfLossDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfLossDateTimePicker.Location = New System.Drawing.Point(711, 95)
        Me.DateOfLossDateTimePicker.Name = "DateOfLossDateTimePicker"
        Me.DateOfLossDateTimePicker.Size = New System.Drawing.Size(489, 23)
        Me.DateOfLossDateTimePicker.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(585, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Statutory Notice"
        '
        'StatutoryNoticeBox
        '
        Me.StatutoryNoticeBox.Location = New System.Drawing.Point(711, 187)
        Me.StatutoryNoticeBox.Name = "StatutoryNoticeBox"
        Me.StatutoryNoticeBox.Size = New System.Drawing.Size(489, 23)
        Me.StatutoryNoticeBox.TabIndex = 28
        '
        'DateOFCallDateTimePicker
        '
        Me.DateOFCallDateTimePicker.CustomFormat = "MMM-dd-yyyy"
        Me.DateOFCallDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "DateOFCall", True))
        Me.DateOFCallDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IntakesBindingSource, "DateOFCall", True))
        Me.DateOFCallDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOFCallDateTimePicker.Location = New System.Drawing.Point(127, 3)
        Me.DateOFCallDateTimePicker.Name = "DateOFCallDateTimePicker"
        Me.DateOFCallDateTimePicker.Size = New System.Drawing.Size(435, 23)
        Me.DateOFCallDateTimePicker.TabIndex = 7
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(20, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(174, 26)
        Me.Label42.TabIndex = 143
        Me.Label42.Text = "Preliminary Info"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(34, 463)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(183, 23)
        Me.TextBox1.TabIndex = 141
        '
        'MatterTypeTableAdapter
        '
        Me.MatterTypeTableAdapter.ClearBeforeFill = True
        '
        'MatterSubTypesTableAdapter
        '
        Me.MatterSubTypesTableAdapter.ClearBeforeFill = True
        '
        'IntakesTableAdapter
        '
        Me.IntakesTableAdapter.ClearBeforeFill = True
        '
        'ResponsibleLawyerTableAdapter
        '
        Me.ResponsibleLawyerTableAdapter.ClearBeforeFill = True
        '
        'HearAboutUsTableAdapter
        '
        Me.HearAboutUsTableAdapter.ClearBeforeFill = True
        '
        'StaffInterviewerTableAdapter
        '
        Me.StaffInterviewerTableAdapter.ClearBeforeFill = True
        '
        'FileLawyerTableAdapter
        '
        Me.FileLawyerTableAdapter.ClearBeforeFill = True
        '
        'PreliminaryInfo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PreliminayPanel)
        Me.Name = "PreliminaryInfo"
        Me.Size = New System.Drawing.Size(1350, 610)
        Me.PreliminayPanel.ResumeLayout(False)
        Me.PreliminayPanel.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.IntakesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActionLogDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MatterTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.FileLawyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffInterviewerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResponsibleLawyerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HearAboutUsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PreliminayPanel As Panel
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents MatterTypeComboBox As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents AdditionalNotesTextBox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LawyerComboBox As ComboBox
    Friend WithEvents MatterSubTypeComboBox As ComboBox
    Friend WithEvents FileNumberTextBox As TextBox
    Friend WithEvents StaffInterviewerComboBox As ComboBox
    Friend WithEvents ResponsibleLawyerComboBox As ComboBox
    Friend WithEvents LimitationPeriodTextBox As TextBox
    Friend WithEvents HowHearComboBox As ComboBox
    Friend WithEvents DateOfLossDateTimePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents StatutoryNoticeBox As TextBox
    Friend WithEvents DateOFCallDateTimePicker As DateTimePicker
    Friend WithEvents Label42 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents MatterTypeTableAdapter As ActionLogDBDataSetTableAdapters.MatterTypeTableAdapter
    Friend WithEvents MatterSubTypesTableAdapter As ActionLogDBDataSetTableAdapters.MatterSubTypesTableAdapter
    Friend WithEvents IntakesTableAdapter As ActionLogDBDataSetTableAdapters.IntakesTableAdapter
    Friend WithEvents FileLawyerBindingSource As BindingSource
    Friend WithEvents StaffInterviewerBindingSource As BindingSource
    Friend WithEvents ResponsibleLawyerBindingSource As BindingSource
    Friend WithEvents MatterTypeBindingSource As BindingSource
    Friend WithEvents ResponsibleLawyerTableAdapter As ActionLogDBDataSetTableAdapters.ResponsibleLawyerTableAdapter
    Friend WithEvents HearAboutUsTableAdapter As ActionLogDBDataSetTableAdapters.HearAboutUsTableAdapter
    Friend WithEvents StaffInterviewerTableAdapter As ActionLogDBDataSetTableAdapters.StaffInterviewerTableAdapter
    Friend WithEvents HearAboutUsBindingSource As BindingSource
    Friend WithEvents FileLawyerTableAdapter As ActionLogDBDataSetTableAdapters.FileLawyerTableAdapter
    Friend WithEvents ActionLogDBDataSet As ActionLogDBDataSet
    Friend WithEvents IntakesBindingSource As BindingSource
End Class
