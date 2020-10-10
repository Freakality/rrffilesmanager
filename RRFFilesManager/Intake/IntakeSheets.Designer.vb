<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntakeSheets
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
        Me.ActionLogDBDataSet = New RRFFilesManager.ActionLogDBDataSet()
        Me.CyaTemplatesTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.CYATemplatesTableAdapter()
        Me.CYATemplatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OtherNotes = New System.Windows.Forms.TabPage()
        Me.Notes = New System.Windows.Forms.RichTextBox()
        Me.AccidentBenefits = New System.Windows.Forms.TabPage()
        Me.GroupBox31 = New System.Windows.Forms.GroupBox()
        Me.AccBenNotes = New System.Windows.Forms.TextBox()
        Me.GroupBox30 = New System.Windows.Forms.GroupBox()
        Me.AccBenReplacBenef = New System.Windows.Forms.TextBox()
        Me.AccBenOCF3 = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.AccBenOCF2 = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.AccBenOCF1 = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.AccBenAdjuster = New System.Windows.Forms.TextBox()
        Me.AccBenRegisOwnerName = New System.Windows.Forms.TextBox()
        Me.AccBenClaimNumber = New System.Windows.Forms.TextBox()
        Me.AccBenPolicyNumber = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.AccBenWereRegisOwner = New System.Windows.Forms.ComboBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.AccBenInsuranceCompany = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.AccBenDriverPassenger = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Damages = New System.Windows.Forms.TabPage()
        Me.GroupBox29 = New System.Windows.Forms.GroupBox()
        Me.DamNotes = New System.Windows.Forms.TextBox()
        Me.GroupBox28 = New System.Windows.Forms.GroupBox()
        Me.DamPreIllness = New System.Windows.Forms.TextBox()
        Me.GroupBox27 = New System.Windows.Forms.GroupBox()
        Me.DamPreAccident = New System.Windows.Forms.TextBox()
        Me.GroupBox26 = New System.Windows.Forms.GroupBox()
        Me.DamWereSeeingDoctor = New System.Windows.Forms.TextBox()
        Me.GroupBox25 = New System.Windows.Forms.GroupBox()
        Me.DamPrescribed = New System.Windows.Forms.TextBox()
        Me.GroupBox24 = New System.Windows.Forms.GroupBox()
        Me.DamPsychologicalEffect = New System.Windows.Forms.TextBox()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.DamLowerBodyInjuries = New System.Windows.Forms.TextBox()
        Me.GroupBox22 = New System.Windows.Forms.GroupBox()
        Me.DamUpperBodyInjuries = New System.Windows.Forms.TextBox()
        Me.GroupBox21 = New System.Windows.Forms.GroupBox()
        Me.DamHeadInjuries = New System.Windows.Forms.TextBox()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.DamWentToHospital = New System.Windows.Forms.TextBox()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.DamHitVehicleConcrete = New System.Windows.Forms.TextBox()
        Me.EmploymentIncomeLoss = New System.Windows.Forms.TabPage()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.EILNotes = New System.Windows.Forms.TextBox()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.EILHowLongBusiness = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.EILSelfGrossEarning = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.EILSelfBusinessName = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.EILWereSelfEmployed = New System.Windows.Forms.ComboBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.EILCollecInsurance = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.EILExplainJob = New System.Windows.Forms.TextBox()
        Me.EILJobTitle = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.EILHowLongEmployee = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.EILEmployeeGrossEarning = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.EILT4Company = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.EILT4Employee = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.EILEmployed52Weeks = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.EILEmployed4Weeks = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.EILWereEmployed = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Liability = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.IncidentDateTimeGroupBox = New System.Windows.Forms.GroupBox()
        Me.LiaDate = New System.Windows.Forms.DateTimePicker()
        Me.LiaTime = New System.Windows.Forms.DateTimePicker()
        Me.ReceiveCopyGroupBox = New System.Windows.Forms.GroupBox()
        Me.LiaOtherDoc = New System.Windows.Forms.CheckBox()
        Me.LiaMVCExchange = New System.Windows.Forms.CheckBox()
        Me.LiaReportCollision = New System.Windows.Forms.CheckBox()
        Me.LiaMVR = New System.Windows.Forms.CheckBox()
        Me.LiaWhereAccidentGroup = New System.Windows.Forms.GroupBox()
        Me.LiaWhereAccident = New System.Windows.Forms.TextBox()
        Me.LiaExplainGroup = New System.Windows.Forms.GroupBox()
        Me.LiaExplain = New System.Windows.Forms.TextBox()
        Me.LiaHavePhotosGroup = New System.Windows.Forms.GroupBox()
        Me.LiaHavePhotos = New System.Windows.Forms.TextBox()
        Me.MVALiabilityGroup = New System.Windows.Forms.GroupBox()
        Me.LiaEstimDamageGroup = New System.Windows.Forms.GroupBox()
        Me.LiaEstimDamage = New System.Windows.Forms.TextBox()
        Me.LiaInsuranceCoGroup = New System.Windows.Forms.GroupBox()
        Me.LiaInsuranceCo = New System.Windows.Forms.TextBox()
        Me.LiaOwnerNameGroup = New System.Windows.Forms.GroupBox()
        Me.LiaOwnerName = New System.Windows.Forms.TextBox()
        Me.LiaDriverNameGroup = New System.Windows.Forms.GroupBox()
        Me.LiaDriverName = New System.Windows.Forms.TextBox()
        Me.LiaYourFaultGroup = New System.Windows.Forms.GroupBox()
        Me.LiaYourFault = New System.Windows.Forms.TextBox()
        Me.OthersLiabilityGroup = New System.Windows.Forms.GroupBox()
        Me.GroupBox38 = New System.Windows.Forms.GroupBox()
        Me.LiaHaveCopy = New System.Windows.Forms.TextBox()
        Me.LieNotifiedMunicipalityGroup = New System.Windows.Forms.GroupBox()
        Me.LiaNotifiedMunicipality = New System.Windows.Forms.TextBox()
        Me.GroupBox35 = New System.Windows.Forms.GroupBox()
        Me.LiaMunicipality = New System.Windows.Forms.TextBox()
        Me.GroupBox36 = New System.Windows.Forms.GroupBox()
        Me.LiaFaultPerson = New System.Windows.Forms.TextBox()
        Me.GroupBox37 = New System.Windows.Forms.GroupBox()
        Me.LiaOwnNegligence = New System.Windows.Forms.TextBox()
        Me.LiaNotesGroup = New System.Windows.Forms.GroupBox()
        Me.LiaNotes = New System.Windows.Forms.TextBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.Policy = New System.Windows.Forms.TabPage()
        Me.GroupBox96 = New System.Windows.Forms.GroupBox()
        Me.TextBox75 = New System.Windows.Forms.TextBox()
        Me.GroupBox95 = New System.Windows.Forms.GroupBox()
        Me.TextBox74 = New System.Windows.Forms.TextBox()
        Me.GroupBox94 = New System.Windows.Forms.GroupBox()
        Me.TextBox73 = New System.Windows.Forms.TextBox()
        Me.GroupBox128 = New System.Windows.Forms.GroupBox()
        Me.TextBox107 = New System.Windows.Forms.TextBox()
        Me.GroupBox127 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker8 = New System.Windows.Forms.DateTimePicker()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.GroupBox126 = New System.Windows.Forms.GroupBox()
        Me.TextBox80 = New System.Windows.Forms.TextBox()
        Me.GroupBox125 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker7 = New System.Windows.Forms.DateTimePicker()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.GroupBox124 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.GroupBox101 = New System.Windows.Forms.GroupBox()
        Me.TextBox77 = New System.Windows.Forms.TextBox()
        Me.GroupBox123 = New System.Windows.Forms.GroupBox()
        Me.ComboBox39 = New System.Windows.Forms.ComboBox()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.GroupBox102 = New System.Windows.Forms.GroupBox()
        Me.ComboBox38 = New System.Windows.Forms.ComboBox()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.GroupBox98 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker6 = New System.Windows.Forms.DateTimePicker()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.GroupBox93 = New System.Windows.Forms.GroupBox()
        Me.TextBox72 = New System.Windows.Forms.TextBox()
        Me.GroupBox97 = New System.Windows.Forms.GroupBox()
        Me.TextBox76 = New System.Windows.Forms.TextBox()
        Me.GroupBox99 = New System.Windows.Forms.GroupBox()
        Me.TextBox78 = New System.Windows.Forms.TextBox()
        Me.GroupBox100 = New System.Windows.Forms.GroupBox()
        Me.TextBox79 = New System.Windows.Forms.TextBox()
        CType(Me.ActionLogDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CYATemplatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OtherNotes.SuspendLayout()
        Me.AccidentBenefits.SuspendLayout()
        Me.GroupBox31.SuspendLayout()
        Me.GroupBox30.SuspendLayout()
        Me.Damages.SuspendLayout()
        Me.GroupBox29.SuspendLayout()
        Me.GroupBox28.SuspendLayout()
        Me.GroupBox27.SuspendLayout()
        Me.GroupBox26.SuspendLayout()
        Me.GroupBox25.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.EmploymentIncomeLoss.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.Liability.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.IncidentDateTimeGroupBox.SuspendLayout()
        Me.ReceiveCopyGroupBox.SuspendLayout()
        Me.LiaWhereAccidentGroup.SuspendLayout()
        Me.LiaExplainGroup.SuspendLayout()
        Me.LiaHavePhotosGroup.SuspendLayout()
        Me.MVALiabilityGroup.SuspendLayout()
        Me.LiaEstimDamageGroup.SuspendLayout()
        Me.LiaInsuranceCoGroup.SuspendLayout()
        Me.LiaOwnerNameGroup.SuspendLayout()
        Me.LiaDriverNameGroup.SuspendLayout()
        Me.LiaYourFaultGroup.SuspendLayout()
        Me.OthersLiabilityGroup.SuspendLayout()
        Me.GroupBox38.SuspendLayout()
        Me.LieNotifiedMunicipalityGroup.SuspendLayout()
        Me.GroupBox35.SuspendLayout()
        Me.GroupBox36.SuspendLayout()
        Me.GroupBox37.SuspendLayout()
        Me.LiaNotesGroup.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.Policy.SuspendLayout()
        Me.GroupBox96.SuspendLayout()
        Me.GroupBox95.SuspendLayout()
        Me.GroupBox94.SuspendLayout()
        Me.GroupBox128.SuspendLayout()
        Me.GroupBox127.SuspendLayout()
        Me.GroupBox126.SuspendLayout()
        Me.GroupBox125.SuspendLayout()
        Me.GroupBox124.SuspendLayout()
        Me.GroupBox101.SuspendLayout()
        Me.GroupBox123.SuspendLayout()
        Me.GroupBox102.SuspendLayout()
        Me.GroupBox98.SuspendLayout()
        Me.GroupBox93.SuspendLayout()
        Me.GroupBox97.SuspendLayout()
        Me.GroupBox99.SuspendLayout()
        Me.GroupBox100.SuspendLayout()
        Me.SuspendLayout()
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
        'OtherNotes
        '
        Me.OtherNotes.BackColor = System.Drawing.SystemColors.Menu
        Me.OtherNotes.Controls.Add(Me.Notes)
        Me.OtherNotes.Location = New System.Drawing.Point(4, 22)
        Me.OtherNotes.Name = "OtherNotes"
        Me.OtherNotes.Padding = New System.Windows.Forms.Padding(3)
        Me.OtherNotes.Size = New System.Drawing.Size(1342, 584)
        Me.OtherNotes.TabIndex = 4
        Me.OtherNotes.Text = "Other Notes"
        '
        'Notes
        '
        Me.Notes.BackColor = System.Drawing.SystemColors.Window
        Me.Notes.Location = New System.Drawing.Point(40, 36)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(1117, 376)
        Me.Notes.TabIndex = 0
        Me.Notes.Text = ""
        '
        'AccidentBenefits
        '
        Me.AccidentBenefits.BackColor = System.Drawing.SystemColors.Menu
        Me.AccidentBenefits.Controls.Add(Me.GroupBox31)
        Me.AccidentBenefits.Controls.Add(Me.GroupBox30)
        Me.AccidentBenefits.Controls.Add(Me.AccBenOCF3)
        Me.AccidentBenefits.Controls.Add(Me.Label40)
        Me.AccidentBenefits.Controls.Add(Me.AccBenOCF2)
        Me.AccidentBenefits.Controls.Add(Me.Label39)
        Me.AccidentBenefits.Controls.Add(Me.AccBenOCF1)
        Me.AccidentBenefits.Controls.Add(Me.Label38)
        Me.AccidentBenefits.Controls.Add(Me.AccBenAdjuster)
        Me.AccidentBenefits.Controls.Add(Me.AccBenRegisOwnerName)
        Me.AccidentBenefits.Controls.Add(Me.AccBenClaimNumber)
        Me.AccidentBenefits.Controls.Add(Me.AccBenPolicyNumber)
        Me.AccidentBenefits.Controls.Add(Me.Label36)
        Me.AccidentBenefits.Controls.Add(Me.AccBenWereRegisOwner)
        Me.AccidentBenefits.Controls.Add(Me.Label35)
        Me.AccidentBenefits.Controls.Add(Me.Label31)
        Me.AccidentBenefits.Controls.Add(Me.Label34)
        Me.AccidentBenefits.Controls.Add(Me.Label33)
        Me.AccidentBenefits.Controls.Add(Me.AccBenInsuranceCompany)
        Me.AccidentBenefits.Controls.Add(Me.Label32)
        Me.AccidentBenefits.Controls.Add(Me.AccBenDriverPassenger)
        Me.AccidentBenefits.Controls.Add(Me.Label37)
        Me.AccidentBenefits.Location = New System.Drawing.Point(4, 22)
        Me.AccidentBenefits.Name = "AccidentBenefits"
        Me.AccidentBenefits.Padding = New System.Windows.Forms.Padding(3)
        Me.AccidentBenefits.Size = New System.Drawing.Size(1342, 584)
        Me.AccidentBenefits.TabIndex = 3
        Me.AccidentBenefits.Text = "Accident Benefits"
        '
        'GroupBox31
        '
        Me.GroupBox31.Controls.Add(Me.AccBenNotes)
        Me.GroupBox31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox31.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox31.Location = New System.Drawing.Point(6, 437)
        Me.GroupBox31.Name = "GroupBox31"
        Me.GroupBox31.Size = New System.Drawing.Size(1160, 93)
        Me.GroupBox31.TabIndex = 38
        Me.GroupBox31.TabStop = False
        Me.GroupBox31.Text = "Other relevant accident benefits notes"
        '
        'AccBenNotes
        '
        Me.AccBenNotes.BackColor = System.Drawing.Color.White
        Me.AccBenNotes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccBenNotes.Location = New System.Drawing.Point(8, 20)
        Me.AccBenNotes.Multiline = True
        Me.AccBenNotes.Name = "AccBenNotes"
        Me.AccBenNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AccBenNotes.Size = New System.Drawing.Size(1141, 67)
        Me.AccBenNotes.TabIndex = 1
        '
        'GroupBox30
        '
        Me.GroupBox30.Controls.Add(Me.AccBenReplacBenef)
        Me.GroupBox30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox30.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox30.Location = New System.Drawing.Point(6, 353)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Size = New System.Drawing.Size(1160, 78)
        Me.GroupBox30.TabIndex = 37
        Me.GroupBox30.TabStop = False
        Me.GroupBox30.Text = "Have you been receiving any income replacement benefits or non-earner benefits si" &
    "nce your accident. If so, which and how much per week"
        '
        'AccBenReplacBenef
        '
        Me.AccBenReplacBenef.BackColor = System.Drawing.Color.White
        Me.AccBenReplacBenef.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccBenReplacBenef.Location = New System.Drawing.Point(8, 20)
        Me.AccBenReplacBenef.Multiline = True
        Me.AccBenReplacBenef.Name = "AccBenReplacBenef"
        Me.AccBenReplacBenef.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AccBenReplacBenef.Size = New System.Drawing.Size(1141, 49)
        Me.AccBenReplacBenef.TabIndex = 1
        '
        'AccBenOCF3
        '
        Me.AccBenOCF3.FormattingEnabled = True
        Me.AccBenOCF3.Items.AddRange(New Object() {"Yes", "No", "Unsure"})
        Me.AccBenOCF3.Location = New System.Drawing.Point(586, 322)
        Me.AccBenOCF3.Name = "AccBenOCF3"
        Me.AccBenOCF3.Size = New System.Drawing.Size(70, 21)
        Me.AccBenOCF3.TabIndex = 36
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(11, 325)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(569, 16)
        Me.Label40.TabIndex = 35
        Me.Label40.Text = "Have you had your doctor or other health care provider complte a Disability Certi" &
    "ficate (OCF-3)?"
        '
        'AccBenOCF2
        '
        Me.AccBenOCF2.FormattingEnabled = True
        Me.AccBenOCF2.Items.AddRange(New Object() {"Yes", "No", "Unsure"})
        Me.AccBenOCF2.Location = New System.Drawing.Point(493, 287)
        Me.AccBenOCF2.Name = "AccBenOCF2"
        Me.AccBenOCF2.Size = New System.Drawing.Size(70, 21)
        Me.AccBenOCF2.TabIndex = 34
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(11, 290)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(478, 16)
        Me.Label39.TabIndex = 33
        Me.Label39.Text = "Have you had your employer complete an Employer Confirmation form (OCF-2)?"
        '
        'AccBenOCF1
        '
        Me.AccBenOCF1.FormattingEnabled = True
        Me.AccBenOCF1.Items.AddRange(New Object() {"Yes", "No", "Unsure"})
        Me.AccBenOCF1.Location = New System.Drawing.Point(417, 248)
        Me.AccBenOCF1.Name = "AccBenOCF1"
        Me.AccBenOCF1.Size = New System.Drawing.Size(70, 21)
        Me.AccBenOCF1.TabIndex = 32
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(11, 251)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(400, 16)
        Me.Label38.TabIndex = 31
        Me.Label38.Text = "Have you completed an Application for Accident Benefits (OCF-1)?"
        '
        'AccBenAdjuster
        '
        Me.AccBenAdjuster.BackColor = System.Drawing.Color.White
        Me.AccBenAdjuster.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccBenAdjuster.Location = New System.Drawing.Point(536, 207)
        Me.AccBenAdjuster.Name = "AccBenAdjuster"
        Me.AccBenAdjuster.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AccBenAdjuster.Size = New System.Drawing.Size(616, 22)
        Me.AccBenAdjuster.TabIndex = 30
        '
        'AccBenRegisOwnerName
        '
        Me.AccBenRegisOwnerName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccBenRegisOwnerName.Location = New System.Drawing.Point(804, 51)
        Me.AccBenRegisOwnerName.Name = "AccBenRegisOwnerName"
        Me.AccBenRegisOwnerName.Size = New System.Drawing.Size(348, 22)
        Me.AccBenRegisOwnerName.TabIndex = 3
        '
        'AccBenClaimNumber
        '
        Me.AccBenClaimNumber.BackColor = System.Drawing.Color.White
        Me.AccBenClaimNumber.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccBenClaimNumber.Location = New System.Drawing.Point(243, 169)
        Me.AccBenClaimNumber.Name = "AccBenClaimNumber"
        Me.AccBenClaimNumber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AccBenClaimNumber.Size = New System.Drawing.Size(909, 22)
        Me.AccBenClaimNumber.TabIndex = 1
        '
        'AccBenPolicyNumber
        '
        Me.AccBenPolicyNumber.BackColor = System.Drawing.Color.White
        Me.AccBenPolicyNumber.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccBenPolicyNumber.Location = New System.Drawing.Point(243, 135)
        Me.AccBenPolicyNumber.Name = "AccBenPolicyNumber"
        Me.AccBenPolicyNumber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AccBenPolicyNumber.Size = New System.Drawing.Size(909, 22)
        Me.AccBenPolicyNumber.TabIndex = 1
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(11, 210)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(519, 16)
        Me.Label36.TabIndex = 29
        Me.Label36.Text = "Have you been dealing with a specific adjuster regarding the injuries from the ac" &
    "cident?"
        '
        'AccBenWereRegisOwner
        '
        Me.AccBenWereRegisOwner.FormattingEnabled = True
        Me.AccBenWereRegisOwner.Items.AddRange(New Object() {"Yes", "No"})
        Me.AccBenWereRegisOwner.Location = New System.Drawing.Point(442, 51)
        Me.AccBenWereRegisOwner.Name = "AccBenWereRegisOwner"
        Me.AccBenWereRegisOwner.Size = New System.Drawing.Size(70, 21)
        Me.AccBenWereRegisOwner.TabIndex = 27
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(11, 54)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(410, 16)
        Me.Label35.TabIndex = 26
        Me.Label35.Text = "Were you the registered owner or spouse of the owner of the vehicle?"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(527, 54)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(271, 16)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Name of the Registered Owner of the vehicle:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(11, 172)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(224, 16)
        Me.Label34.TabIndex = 25
        Me.Label34.Text = "What is the Insurance Claim Number?"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(11, 138)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(226, 16)
        Me.Label33.TabIndex = 24
        Me.Label33.Text = "What is the Insurance Policy Number?"
        '
        'AccBenInsuranceCompany
        '
        Me.AccBenInsuranceCompany.DisplayMember = "Company"
        Me.AccBenInsuranceCompany.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccBenInsuranceCompany.FormattingEnabled = True
        Me.AccBenInsuranceCompany.Location = New System.Drawing.Point(372, 94)
        Me.AccBenInsuranceCompany.Name = "AccBenInsuranceCompany"
        Me.AccBenInsuranceCompany.Size = New System.Drawing.Size(780, 25)
        Me.AccBenInsuranceCompany.TabIndex = 22
        Me.AccBenInsuranceCompany.ValueMember = "Company"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(11, 97)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(355, 16)
        Me.Label32.TabIndex = 23
        Me.Label32.Text = "Name of the insurance company which insures your vehicle"
        '
        'AccBenDriverPassenger
        '
        Me.AccBenDriverPassenger.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccBenDriverPassenger.FormattingEnabled = True
        Me.AccBenDriverPassenger.Items.AddRange(New Object() {"Cyclist", "Driver", "Passenger", "Pedestrian"})
        Me.AccBenDriverPassenger.Location = New System.Drawing.Point(442, 12)
        Me.AccBenDriverPassenger.Name = "AccBenDriverPassenger"
        Me.AccBenDriverPassenger.Size = New System.Drawing.Size(184, 25)
        Me.AccBenDriverPassenger.TabIndex = 20
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(11, 15)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(415, 16)
        Me.Label37.TabIndex = 21
        Me.Label37.Text = "Were you a driver, passenger or cyclist in this motor vehicle accident?"
        '
        'Damages
        '
        Me.Damages.AutoScroll = True
        Me.Damages.BackColor = System.Drawing.SystemColors.Menu
        Me.Damages.Controls.Add(Me.GroupBox29)
        Me.Damages.Controls.Add(Me.GroupBox28)
        Me.Damages.Controls.Add(Me.GroupBox27)
        Me.Damages.Controls.Add(Me.GroupBox26)
        Me.Damages.Controls.Add(Me.GroupBox25)
        Me.Damages.Controls.Add(Me.GroupBox24)
        Me.Damages.Controls.Add(Me.GroupBox23)
        Me.Damages.Controls.Add(Me.GroupBox22)
        Me.Damages.Controls.Add(Me.GroupBox21)
        Me.Damages.Controls.Add(Me.GroupBox20)
        Me.Damages.Controls.Add(Me.GroupBox19)
        Me.Damages.Location = New System.Drawing.Point(4, 22)
        Me.Damages.Name = "Damages"
        Me.Damages.Padding = New System.Windows.Forms.Padding(3)
        Me.Damages.Size = New System.Drawing.Size(1342, 584)
        Me.Damages.TabIndex = 1
        Me.Damages.Text = "Damages"
        '
        'GroupBox29
        '
        Me.GroupBox29.Controls.Add(Me.DamNotes)
        Me.GroupBox29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox29.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox29.Location = New System.Drawing.Point(3, 1014)
        Me.GroupBox29.Name = "GroupBox29"
        Me.GroupBox29.Size = New System.Drawing.Size(1160, 95)
        Me.GroupBox29.TabIndex = 18
        Me.GroupBox29.TabStop = False
        Me.GroupBox29.Text = "Other relevant damages notes"
        '
        'DamNotes
        '
        Me.DamNotes.BackColor = System.Drawing.Color.White
        Me.DamNotes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamNotes.Location = New System.Drawing.Point(8, 20)
        Me.DamNotes.Multiline = True
        Me.DamNotes.Name = "DamNotes"
        Me.DamNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DamNotes.Size = New System.Drawing.Size(1141, 67)
        Me.DamNotes.TabIndex = 1
        '
        'GroupBox28
        '
        Me.GroupBox28.Controls.Add(Me.DamPreIllness)
        Me.GroupBox28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox28.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox28.Location = New System.Drawing.Point(3, 913)
        Me.GroupBox28.Name = "GroupBox28"
        Me.GroupBox28.Size = New System.Drawing.Size(1160, 95)
        Me.GroupBox28.TabIndex = 17
        Me.GroupBox28.TabStop = False
        Me.GroupBox28.Text = "Do you suffer from any other illness (unrelated to this motor vehicle accident) s" &
    "uch as cancer, heart issues, pre-existing anxiety or depression, etc.?"
        '
        'DamPreIllness
        '
        Me.DamPreIllness.BackColor = System.Drawing.Color.White
        Me.DamPreIllness.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamPreIllness.Location = New System.Drawing.Point(8, 20)
        Me.DamPreIllness.Multiline = True
        Me.DamPreIllness.Name = "DamPreIllness"
        Me.DamPreIllness.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DamPreIllness.Size = New System.Drawing.Size(1141, 67)
        Me.DamPreIllness.TabIndex = 1
        '
        'GroupBox27
        '
        Me.GroupBox27.Controls.Add(Me.DamPreAccident)
        Me.GroupBox27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox27.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox27.Location = New System.Drawing.Point(0, 812)
        Me.GroupBox27.Name = "GroupBox27"
        Me.GroupBox27.Size = New System.Drawing.Size(1160, 95)
        Me.GroupBox27.TabIndex = 16
        Me.GroupBox27.TabStop = False
        Me.GroupBox27.Text = "Prior to this accident, were you ever involved in a motor vehicle accident, slip " &
    "and fall accidents, workplace accidents?"
        '
        'DamPreAccident
        '
        Me.DamPreAccident.BackColor = System.Drawing.Color.White
        Me.DamPreAccident.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamPreAccident.Location = New System.Drawing.Point(8, 20)
        Me.DamPreAccident.Multiline = True
        Me.DamPreAccident.Name = "DamPreAccident"
        Me.DamPreAccident.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DamPreAccident.Size = New System.Drawing.Size(1141, 67)
        Me.DamPreAccident.TabIndex = 1
        '
        'GroupBox26
        '
        Me.GroupBox26.Controls.Add(Me.DamWereSeeingDoctor)
        Me.GroupBox26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox26.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox26.Location = New System.Drawing.Point(3, 710)
        Me.GroupBox26.Name = "GroupBox26"
        Me.GroupBox26.Size = New System.Drawing.Size(1160, 95)
        Me.GroupBox26.TabIndex = 15
        Me.GroupBox26.TabStop = False
        Me.GroupBox26.Text = "Were or are you seeing any other health care provider as a result of your injurie" &
    "s from this accident (specialist, physioterapist, pychologist, etc.)?"
        '
        'DamWereSeeingDoctor
        '
        Me.DamWereSeeingDoctor.BackColor = System.Drawing.Color.White
        Me.DamWereSeeingDoctor.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamWereSeeingDoctor.Location = New System.Drawing.Point(8, 20)
        Me.DamWereSeeingDoctor.Multiline = True
        Me.DamWereSeeingDoctor.Name = "DamWereSeeingDoctor"
        Me.DamWereSeeingDoctor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DamWereSeeingDoctor.Size = New System.Drawing.Size(1141, 67)
        Me.DamWereSeeingDoctor.TabIndex = 1
        '
        'GroupBox25
        '
        Me.GroupBox25.Controls.Add(Me.DamPrescribed)
        Me.GroupBox25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox25.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox25.Location = New System.Drawing.Point(3, 609)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(1160, 95)
        Me.GroupBox25.TabIndex = 14
        Me.GroupBox25.TabStop = False
        Me.GroupBox25.Text = "Since the accident, have you been prescribed any medication?"
        '
        'DamPrescribed
        '
        Me.DamPrescribed.BackColor = System.Drawing.Color.White
        Me.DamPrescribed.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamPrescribed.Location = New System.Drawing.Point(8, 20)
        Me.DamPrescribed.Multiline = True
        Me.DamPrescribed.Name = "DamPrescribed"
        Me.DamPrescribed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DamPrescribed.Size = New System.Drawing.Size(1141, 67)
        Me.DamPrescribed.TabIndex = 1
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.DamPsychologicalEffect)
        Me.GroupBox24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox24.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox24.Location = New System.Drawing.Point(3, 511)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(1160, 95)
        Me.GroupBox24.TabIndex = 13
        Me.GroupBox24.TabStop = False
        Me.GroupBox24.Text = "Please indicate psychocological effects as a result of this accident"
        '
        'DamPsychologicalEffect
        '
        Me.DamPsychologicalEffect.BackColor = System.Drawing.Color.White
        Me.DamPsychologicalEffect.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamPsychologicalEffect.Location = New System.Drawing.Point(8, 20)
        Me.DamPsychologicalEffect.Multiline = True
        Me.DamPsychologicalEffect.Name = "DamPsychologicalEffect"
        Me.DamPsychologicalEffect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DamPsychologicalEffect.Size = New System.Drawing.Size(1141, 67)
        Me.DamPsychologicalEffect.TabIndex = 1
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.Add(Me.DamLowerBodyInjuries)
        Me.GroupBox23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox23.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox23.Location = New System.Drawing.Point(6, 410)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(1160, 95)
        Me.GroupBox23.TabIndex = 12
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "Please indicate LOWER BODY INJURIES in this accident"
        '
        'DamLowerBodyInjuries
        '
        Me.DamLowerBodyInjuries.BackColor = System.Drawing.Color.White
        Me.DamLowerBodyInjuries.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamLowerBodyInjuries.Location = New System.Drawing.Point(8, 20)
        Me.DamLowerBodyInjuries.Multiline = True
        Me.DamLowerBodyInjuries.Name = "DamLowerBodyInjuries"
        Me.DamLowerBodyInjuries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DamLowerBodyInjuries.Size = New System.Drawing.Size(1141, 67)
        Me.DamLowerBodyInjuries.TabIndex = 1
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.DamUpperBodyInjuries)
        Me.GroupBox22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox22.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox22.Location = New System.Drawing.Point(6, 309)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(1160, 95)
        Me.GroupBox22.TabIndex = 11
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "Please indicate UPPER BODY INJURIES in this accident"
        '
        'DamUpperBodyInjuries
        '
        Me.DamUpperBodyInjuries.BackColor = System.Drawing.Color.White
        Me.DamUpperBodyInjuries.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamUpperBodyInjuries.Location = New System.Drawing.Point(8, 20)
        Me.DamUpperBodyInjuries.Multiline = True
        Me.DamUpperBodyInjuries.Name = "DamUpperBodyInjuries"
        Me.DamUpperBodyInjuries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DamUpperBodyInjuries.Size = New System.Drawing.Size(1141, 67)
        Me.DamUpperBodyInjuries.TabIndex = 1
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.DamHeadInjuries)
        Me.GroupBox21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox21.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox21.Location = New System.Drawing.Point(6, 208)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(1160, 95)
        Me.GroupBox21.TabIndex = 10
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "Please indicate HEAD INJURIES in this accident"
        '
        'DamHeadInjuries
        '
        Me.DamHeadInjuries.BackColor = System.Drawing.Color.White
        Me.DamHeadInjuries.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamHeadInjuries.Location = New System.Drawing.Point(8, 20)
        Me.DamHeadInjuries.Multiline = True
        Me.DamHeadInjuries.Name = "DamHeadInjuries"
        Me.DamHeadInjuries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DamHeadInjuries.Size = New System.Drawing.Size(1141, 67)
        Me.DamHeadInjuries.TabIndex = 1
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.DamWentToHospital)
        Me.GroupBox20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox20.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox20.Location = New System.Drawing.Point(6, 107)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(1160, 95)
        Me.GroupBox20.TabIndex = 9
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "Were you taken or did you go to a hospital to have your injuries looked at follow" &
    "ing this accident?"
        '
        'DamWentToHospital
        '
        Me.DamWentToHospital.BackColor = System.Drawing.Color.White
        Me.DamWentToHospital.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamWentToHospital.Location = New System.Drawing.Point(8, 20)
        Me.DamWentToHospital.Multiline = True
        Me.DamWentToHospital.Name = "DamWentToHospital"
        Me.DamWentToHospital.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DamWentToHospital.Size = New System.Drawing.Size(1141, 67)
        Me.DamWentToHospital.TabIndex = 1
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.DamHitVehicleConcrete)
        Me.GroupBox19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox19.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox19.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(1160, 95)
        Me.GroupBox19.TabIndex = 8
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "During this accident did your body hit any part of the inside of the vehicle or y" &
    "our body part with any other property such as concrete?"
        '
        'DamHitVehicleConcrete
        '
        Me.DamHitVehicleConcrete.BackColor = System.Drawing.Color.White
        Me.DamHitVehicleConcrete.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamHitVehicleConcrete.Location = New System.Drawing.Point(8, 20)
        Me.DamHitVehicleConcrete.Multiline = True
        Me.DamHitVehicleConcrete.Name = "DamHitVehicleConcrete"
        Me.DamHitVehicleConcrete.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DamHitVehicleConcrete.Size = New System.Drawing.Size(1141, 67)
        Me.DamHitVehicleConcrete.TabIndex = 1
        '
        'EmploymentIncomeLoss
        '
        Me.EmploymentIncomeLoss.AutoScroll = True
        Me.EmploymentIncomeLoss.BackColor = System.Drawing.SystemColors.Menu
        Me.EmploymentIncomeLoss.Controls.Add(Me.GroupBox18)
        Me.EmploymentIncomeLoss.Controls.Add(Me.GroupBox17)
        Me.EmploymentIncomeLoss.Controls.Add(Me.GroupBox16)
        Me.EmploymentIncomeLoss.Controls.Add(Me.GroupBox15)
        Me.EmploymentIncomeLoss.Controls.Add(Me.GroupBox14)
        Me.EmploymentIncomeLoss.Controls.Add(Me.GroupBox13)
        Me.EmploymentIncomeLoss.Location = New System.Drawing.Point(4, 22)
        Me.EmploymentIncomeLoss.Name = "EmploymentIncomeLoss"
        Me.EmploymentIncomeLoss.Padding = New System.Windows.Forms.Padding(3)
        Me.EmploymentIncomeLoss.Size = New System.Drawing.Size(1342, 584)
        Me.EmploymentIncomeLoss.TabIndex = 2
        Me.EmploymentIncomeLoss.Text = "Employment/Income Loss"
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.EILNotes)
        Me.GroupBox18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox18.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox18.Location = New System.Drawing.Point(16, 513)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(1160, 138)
        Me.GroupBox18.TabIndex = 23
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Other relevant Employement / Income Loss notes"
        '
        'EILNotes
        '
        Me.EILNotes.BackColor = System.Drawing.Color.White
        Me.EILNotes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EILNotes.Location = New System.Drawing.Point(8, 20)
        Me.EILNotes.Multiline = True
        Me.EILNotes.Name = "EILNotes"
        Me.EILNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.EILNotes.Size = New System.Drawing.Size(1141, 110)
        Me.EILNotes.TabIndex = 1
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.EILHowLongBusiness)
        Me.GroupBox17.Controls.Add(Me.Label30)
        Me.GroupBox17.Controls.Add(Me.EILSelfGrossEarning)
        Me.GroupBox17.Controls.Add(Me.Label29)
        Me.GroupBox17.Controls.Add(Me.EILSelfBusinessName)
        Me.GroupBox17.Controls.Add(Me.Label27)
        Me.GroupBox17.Controls.Add(Me.EILWereSelfEmployed)
        Me.GroupBox17.Controls.Add(Me.Label28)
        Me.GroupBox17.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox17.Location = New System.Drawing.Point(16, 384)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(1172, 123)
        Me.GroupBox17.TabIndex = 22
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "Self-Employed"
        '
        'EILHowLongBusiness
        '
        Me.EILHowLongBusiness.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EILHowLongBusiness.Location = New System.Drawing.Point(346, 90)
        Me.EILHowLongBusiness.Name = "EILHowLongBusiness"
        Me.EILHowLongBusiness.Size = New System.Drawing.Size(818, 22)
        Me.EILHowLongBusiness.TabIndex = 20
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(9, 93)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(331, 17)
        Me.Label30.TabIndex = 19
        Me.Label30.Text = "How long have you been operating your own business?"
        '
        'EILSelfGrossEarning
        '
        Me.EILSelfGrossEarning.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EILSelfGrossEarning.Location = New System.Drawing.Point(401, 55)
        Me.EILSelfGrossEarning.Name = "EILSelfGrossEarning"
        Me.EILSelfGrossEarning.Size = New System.Drawing.Size(762, 22)
        Me.EILSelfGrossEarning.TabIndex = 18
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(8, 58)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(389, 17)
        Me.Label29.TabIndex = 17
        Me.Label29.Text = "How much were you earning (gross) at the time of this accident?"
        '
        'EILSelfBusinessName
        '
        Me.EILSelfBusinessName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EILSelfBusinessName.Location = New System.Drawing.Point(401, 15)
        Me.EILSelfBusinessName.Name = "EILSelfBusinessName"
        Me.EILSelfBusinessName.Size = New System.Drawing.Size(762, 22)
        Me.EILSelfBusinessName.TabIndex = 16
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(258, 18)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(140, 17)
        Me.Label27.TabIndex = 15
        Me.Label27.Text = "Name of your Business:"
        '
        'EILWereSelfEmployed
        '
        Me.EILWereSelfEmployed.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EILWereSelfEmployed.FormattingEnabled = True
        Me.EILWereSelfEmployed.Items.AddRange(New Object() {"Yes", "No"})
        Me.EILWereSelfEmployed.Location = New System.Drawing.Point(171, 15)
        Me.EILWereSelfEmployed.Name = "EILWereSelfEmployed"
        Me.EILWereSelfEmployed.Size = New System.Drawing.Size(53, 25)
        Me.EILWereSelfEmployed.TabIndex = 1
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(6, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(159, 17)
        Me.Label28.TabIndex = 13
        Me.Label28.Text = "Were you self-employed?"
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.EILCollecInsurance)
        Me.GroupBox16.Controls.Add(Me.Label26)
        Me.GroupBox16.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox16.Location = New System.Drawing.Point(582, 102)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(606, 55)
        Me.GroupBox16.TabIndex = 21
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "Employment Insurance"
        '
        'EILCollecInsurance
        '
        Me.EILCollecInsurance.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EILCollecInsurance.FormattingEnabled = True
        Me.EILCollecInsurance.Items.AddRange(New Object() {"Yes", "No"})
        Me.EILCollecInsurance.Location = New System.Drawing.Point(525, 15)
        Me.EILCollecInsurance.Name = "EILCollecInsurance"
        Me.EILCollecInsurance.Size = New System.Drawing.Size(53, 25)
        Me.EILCollecInsurance.TabIndex = 7
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(513, 17)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Were you collecting Employment Insurance in the last 52 weeks before the accident" &
    "?"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.TableLayoutPanel5)
        Me.GroupBox15.Controls.Add(Me.EILJobTitle)
        Me.GroupBox15.Controls.Add(Me.Label24)
        Me.GroupBox15.Controls.Add(Me.EILHowLongEmployee)
        Me.GroupBox15.Controls.Add(Me.Label23)
        Me.GroupBox15.Controls.Add(Me.EILEmployeeGrossEarning)
        Me.GroupBox15.Controls.Add(Me.Label20)
        Me.GroupBox15.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.Location = New System.Drawing.Point(16, 163)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(1172, 215)
        Me.GroupBox15.TabIndex = 20
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Employment Info"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.55172!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.44827!))
        Me.TableLayoutPanel5.Controls.Add(Me.Label25, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.EILExplainJob, 1, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(6, 125)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1160, 70)
        Me.TableLayoutPanel5.TabIndex = 8
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(3, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(224, 34)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "Explain what your job responsibilities were for this job title:"
        '
        'EILExplainJob
        '
        Me.EILExplainJob.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EILExplainJob.Location = New System.Drawing.Point(252, 3)
        Me.EILExplainJob.Multiline = True
        Me.EILExplainJob.Name = "EILExplainJob"
        Me.EILExplainJob.Size = New System.Drawing.Size(854, 56)
        Me.EILExplainJob.TabIndex = 7
        '
        'EILJobTitle
        '
        Me.EILJobTitle.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EILJobTitle.Location = New System.Drawing.Point(258, 97)
        Me.EILJobTitle.Name = "EILJobTitle"
        Me.EILJobTitle.Size = New System.Drawing.Size(905, 22)
        Me.EILJobTitle.TabIndex = 5
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 97)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(246, 17)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "What is your job title with this employer?"
        '
        'EILHowLongEmployee
        '
        Me.EILHowLongEmployee.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EILHowLongEmployee.Location = New System.Drawing.Point(324, 61)
        Me.EILHowLongEmployee.Name = "EILHowLongEmployee"
        Me.EILHowLongEmployee.Size = New System.Drawing.Size(839, 22)
        Me.EILHowLongEmployee.TabIndex = 3
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 61)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(312, 17)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "How long have you been working for this employer?"
        '
        'EILEmployeeGrossEarning
        '
        Me.EILEmployeeGrossEarning.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EILEmployeeGrossEarning.Location = New System.Drawing.Point(401, 27)
        Me.EILEmployeeGrossEarning.Name = "EILEmployeeGrossEarning"
        Me.EILEmployeeGrossEarning.Size = New System.Drawing.Size(762, 22)
        Me.EILEmployeeGrossEarning.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 27)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(389, 17)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "How much were you earning (gross) at the time of this accident?"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.EILT4Company)
        Me.GroupBox14.Controls.Add(Me.Label21)
        Me.GroupBox14.Controls.Add(Me.EILT4Employee)
        Me.GroupBox14.Controls.Add(Me.Label22)
        Me.GroupBox14.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox14.Location = New System.Drawing.Point(582, 17)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(606, 79)
        Me.GroupBox14.TabIndex = 19
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "T4 Info"
        '
        'EILT4Company
        '
        Me.EILT4Company.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EILT4Company.Location = New System.Drawing.Point(171, 46)
        Me.EILT4Company.Name = "EILT4Company"
        Me.EILT4Company.Size = New System.Drawing.Size(429, 22)
        Me.EILT4Company.TabIndex = 16
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 46)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(145, 17)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "Name of the Company:"
        '
        'EILT4Employee
        '
        Me.EILT4Employee.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EILT4Employee.FormattingEnabled = True
        Me.EILT4Employee.Items.AddRange(New Object() {"Yes", "No"})
        Me.EILT4Employee.Location = New System.Drawing.Point(171, 15)
        Me.EILT4Employee.Name = "EILT4Employee"
        Me.EILT4Employee.Size = New System.Drawing.Size(53, 25)
        Me.EILT4Employee.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 18)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(159, 17)
        Me.Label22.TabIndex = 13
        Me.Label22.Text = "Were you a T4 Employee?"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.EILEmployed52Weeks)
        Me.GroupBox13.Controls.Add(Me.Label19)
        Me.GroupBox13.Controls.Add(Me.EILEmployed4Weeks)
        Me.GroupBox13.Controls.Add(Me.Label18)
        Me.GroupBox13.Controls.Add(Me.EILWereEmployed)
        Me.GroupBox13.Controls.Add(Me.Label17)
        Me.GroupBox13.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox13.Location = New System.Drawing.Point(16, 17)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(560, 140)
        Me.GroupBox13.TabIndex = 18
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Time of Employment"
        '
        'EILEmployed52Weeks
        '
        Me.EILEmployed52Weeks.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EILEmployed52Weeks.FormattingEnabled = True
        Me.EILEmployed52Weeks.Items.AddRange(New Object() {"Yes", "No"})
        Me.EILEmployed52Weeks.Location = New System.Drawing.Point(478, 96)
        Me.EILEmployed52Weeks.Name = "EILEmployed52Weeks"
        Me.EILEmployed52Weeks.Size = New System.Drawing.Size(53, 25)
        Me.EILEmployed52Weeks.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 99)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(466, 17)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Were you employed at least 52 weeks before of this motor vehicle accident?"
        '
        'EILEmployed4Weeks
        '
        Me.EILEmployed4Weeks.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EILEmployed4Weeks.FormattingEnabled = True
        Me.EILEmployed4Weeks.Items.AddRange(New Object() {"Yes", "No"})
        Me.EILEmployed4Weeks.Location = New System.Drawing.Point(471, 62)
        Me.EILEmployed4Weeks.Name = "EILEmployed4Weeks"
        Me.EILEmployed4Weeks.Size = New System.Drawing.Size(53, 25)
        Me.EILEmployed4Weeks.TabIndex = 14
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(459, 17)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Were you employed at least 4 weeks before of this motor vehicle accident?"
        '
        'EILWereEmployed
        '
        Me.EILWereEmployed.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EILWereEmployed.FormattingEnabled = True
        Me.EILWereEmployed.Items.AddRange(New Object() {"Yes", "No"})
        Me.EILWereEmployed.Location = New System.Drawing.Point(399, 32)
        Me.EILWereEmployed.Name = "EILWereEmployed"
        Me.EILWereEmployed.Size = New System.Drawing.Size(53, 25)
        Me.EILWereEmployed.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(387, 17)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Were you employed at the time of this motor vehicle accident?"
        '
        'Liability
        '
        Me.Liability.AutoScroll = True
        Me.Liability.BackColor = System.Drawing.SystemColors.Menu
        Me.Liability.Controls.Add(Me.FlowLayoutPanel1)
        Me.Liability.Location = New System.Drawing.Point(4, 22)
        Me.Liability.Name = "Liability"
        Me.Liability.Size = New System.Drawing.Size(1342, 584)
        Me.Liability.TabIndex = 6
        Me.Liability.Text = "Liability"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.IncidentDateTimeGroupBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.ReceiveCopyGroupBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.LiaWhereAccidentGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.LiaExplainGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.LiaHavePhotosGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.MVALiabilityGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.OthersLiabilityGroup)
        Me.FlowLayoutPanel1.Controls.Add(Me.LiaNotesGroup)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1342, 584)
        Me.FlowLayoutPanel1.TabIndex = 16
        '
        'IncidentDateTimeGroupBox
        '
        Me.IncidentDateTimeGroupBox.Controls.Add(Me.LiaDate)
        Me.IncidentDateTimeGroupBox.Controls.Add(Me.LiaTime)
        Me.IncidentDateTimeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IncidentDateTimeGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.IncidentDateTimeGroupBox.Name = "IncidentDateTimeGroupBox"
        Me.IncidentDateTimeGroupBox.Size = New System.Drawing.Size(448, 56)
        Me.IncidentDateTimeGroupBox.TabIndex = 5
        Me.IncidentDateTimeGroupBox.TabStop = False
        Me.IncidentDateTimeGroupBox.Text = "Indicate date and time of the accident"
        '
        'LiaDate
        '
        Me.LiaDate.Location = New System.Drawing.Point(8, 21)
        Me.LiaDate.Name = "LiaDate"
        Me.LiaDate.Size = New System.Drawing.Size(243, 20)
        Me.LiaDate.TabIndex = 1
        '
        'LiaTime
        '
        Me.LiaTime.CustomFormat = "hh:mm tt"
        Me.LiaTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.LiaTime.Location = New System.Drawing.Point(274, 21)
        Me.LiaTime.Name = "LiaTime"
        Me.LiaTime.ShowUpDown = True
        Me.LiaTime.Size = New System.Drawing.Size(152, 20)
        Me.LiaTime.TabIndex = 0
        '
        'ReceiveCopyGroupBox
        '
        Me.ReceiveCopyGroupBox.Controls.Add(Me.LiaOtherDoc)
        Me.ReceiveCopyGroupBox.Controls.Add(Me.LiaMVCExchange)
        Me.ReceiveCopyGroupBox.Controls.Add(Me.LiaReportCollision)
        Me.ReceiveCopyGroupBox.Controls.Add(Me.LiaMVR)
        Me.ReceiveCopyGroupBox.Location = New System.Drawing.Point(457, 3)
        Me.ReceiveCopyGroupBox.Name = "ReceiveCopyGroupBox"
        Me.ReceiveCopyGroupBox.Size = New System.Drawing.Size(706, 56)
        Me.ReceiveCopyGroupBox.TabIndex = 6
        Me.ReceiveCopyGroupBox.TabStop = False
        Me.ReceiveCopyGroupBox.Text = "Did you receive a copy of the following documents:"
        '
        'LiaOtherDoc
        '
        Me.LiaOtherDoc.AutoSize = True
        Me.LiaOtherDoc.Location = New System.Drawing.Point(639, 21)
        Me.LiaOtherDoc.Name = "LiaOtherDoc"
        Me.LiaOtherDoc.Size = New System.Drawing.Size(52, 17)
        Me.LiaOtherDoc.TabIndex = 3
        Me.LiaOtherDoc.Text = "Other"
        Me.LiaOtherDoc.UseVisualStyleBackColor = True
        '
        'LiaMVCExchange
        '
        Me.LiaMVCExchange.AutoSize = True
        Me.LiaMVCExchange.Location = New System.Drawing.Point(376, 21)
        Me.LiaMVCExchange.Name = "LiaMVCExchange"
        Me.LiaMVCExchange.Size = New System.Drawing.Size(180, 17)
        Me.LiaMVCExchange.TabIndex = 2
        Me.LiaMVCExchange.Text = "MVC Information Exchange Card"
        Me.LiaMVCExchange.UseVisualStyleBackColor = True
        '
        'LiaReportCollision
        '
        Me.LiaReportCollision.AutoSize = True
        Me.LiaReportCollision.Location = New System.Drawing.Point(87, 21)
        Me.LiaReportCollision.Name = "LiaReportCollision"
        Me.LiaReportCollision.Size = New System.Drawing.Size(205, 17)
        Me.LiaReportCollision.TabIndex = 1
        Me.LiaReportCollision.Text = "Report from Collision Reporting Centre"
        Me.LiaReportCollision.UseVisualStyleBackColor = True
        '
        'LiaMVR
        '
        Me.LiaMVR.AutoSize = True
        Me.LiaMVR.Location = New System.Drawing.Point(6, 21)
        Me.LiaMVR.Name = "LiaMVR"
        Me.LiaMVR.Size = New System.Drawing.Size(50, 17)
        Me.LiaMVR.TabIndex = 0
        Me.LiaMVR.Text = "MVR"
        Me.LiaMVR.UseVisualStyleBackColor = True
        '
        'LiaWhereAccidentGroup
        '
        Me.LiaWhereAccidentGroup.Controls.Add(Me.LiaWhereAccident)
        Me.LiaWhereAccidentGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LiaWhereAccidentGroup.Location = New System.Drawing.Point(3, 65)
        Me.LiaWhereAccidentGroup.Name = "LiaWhereAccidentGroup"
        Me.LiaWhereAccidentGroup.Size = New System.Drawing.Size(1160, 95)
        Me.LiaWhereAccidentGroup.TabIndex = 7
        Me.LiaWhereAccidentGroup.TabStop = False
        Me.LiaWhereAccidentGroup.Text = "Where did the incident occur (place/address)?"
        '
        'LiaWhereAccident
        '
        Me.LiaWhereAccident.BackColor = System.Drawing.Color.White
        Me.LiaWhereAccident.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiaWhereAccident.Location = New System.Drawing.Point(3, 16)
        Me.LiaWhereAccident.Multiline = True
        Me.LiaWhereAccident.Name = "LiaWhereAccident"
        Me.LiaWhereAccident.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LiaWhereAccident.Size = New System.Drawing.Size(1154, 76)
        Me.LiaWhereAccident.TabIndex = 1
        '
        'LiaExplainGroup
        '
        Me.LiaExplainGroup.Controls.Add(Me.LiaExplain)
        Me.LiaExplainGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LiaExplainGroup.Location = New System.Drawing.Point(3, 166)
        Me.LiaExplainGroup.Name = "LiaExplainGroup"
        Me.LiaExplainGroup.Size = New System.Drawing.Size(1160, 172)
        Me.LiaExplainGroup.TabIndex = 4
        Me.LiaExplainGroup.TabStop = False
        Me.LiaExplainGroup.Text = "Explain in detail how the incident ocurred"
        '
        'LiaExplain
        '
        Me.LiaExplain.BackColor = System.Drawing.Color.White
        Me.LiaExplain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiaExplain.Location = New System.Drawing.Point(3, 16)
        Me.LiaExplain.Multiline = True
        Me.LiaExplain.Name = "LiaExplain"
        Me.LiaExplain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LiaExplain.Size = New System.Drawing.Size(1154, 153)
        Me.LiaExplain.TabIndex = 1
        '
        'LiaHavePhotosGroup
        '
        Me.LiaHavePhotosGroup.Controls.Add(Me.LiaHavePhotos)
        Me.LiaHavePhotosGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LiaHavePhotosGroup.Location = New System.Drawing.Point(3, 344)
        Me.LiaHavePhotosGroup.Name = "LiaHavePhotosGroup"
        Me.LiaHavePhotosGroup.Size = New System.Drawing.Size(1160, 79)
        Me.LiaHavePhotosGroup.TabIndex = 8
        Me.LiaHavePhotosGroup.TabStop = False
        Me.LiaHavePhotosGroup.Text = "Do you have any photos of the incident?"
        '
        'LiaHavePhotos
        '
        Me.LiaHavePhotos.BackColor = System.Drawing.Color.White
        Me.LiaHavePhotos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiaHavePhotos.Location = New System.Drawing.Point(3, 16)
        Me.LiaHavePhotos.Multiline = True
        Me.LiaHavePhotos.Name = "LiaHavePhotos"
        Me.LiaHavePhotos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LiaHavePhotos.Size = New System.Drawing.Size(1154, 60)
        Me.LiaHavePhotos.TabIndex = 1
        '
        'MVALiabilityGroup
        '
        Me.MVALiabilityGroup.Controls.Add(Me.LiaEstimDamageGroup)
        Me.MVALiabilityGroup.Controls.Add(Me.LiaInsuranceCoGroup)
        Me.MVALiabilityGroup.Controls.Add(Me.LiaOwnerNameGroup)
        Me.MVALiabilityGroup.Controls.Add(Me.LiaDriverNameGroup)
        Me.MVALiabilityGroup.Controls.Add(Me.LiaYourFaultGroup)
        Me.MVALiabilityGroup.Location = New System.Drawing.Point(3, 429)
        Me.MVALiabilityGroup.Name = "MVALiabilityGroup"
        Me.MVALiabilityGroup.Size = New System.Drawing.Size(1163, 395)
        Me.MVALiabilityGroup.TabIndex = 20
        Me.MVALiabilityGroup.TabStop = False
        Me.MVALiabilityGroup.Text = "Information"
        '
        'LiaEstimDamageGroup
        '
        Me.LiaEstimDamageGroup.Controls.Add(Me.LiaEstimDamage)
        Me.LiaEstimDamageGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LiaEstimDamageGroup.Location = New System.Drawing.Point(3, 19)
        Me.LiaEstimDamageGroup.Name = "LiaEstimDamageGroup"
        Me.LiaEstimDamageGroup.Size = New System.Drawing.Size(1160, 79)
        Me.LiaEstimDamageGroup.TabIndex = 9
        Me.LiaEstimDamageGroup.TabStop = False
        Me.LiaEstimDamageGroup.Text = "As a result of this motor vehicle accident, please estimate the amount of damage " &
    "to the vehicle in which you were driving"
        '
        'LiaEstimDamage
        '
        Me.LiaEstimDamage.BackColor = System.Drawing.SystemColors.Window
        Me.LiaEstimDamage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiaEstimDamage.Location = New System.Drawing.Point(3, 16)
        Me.LiaEstimDamage.Multiline = True
        Me.LiaEstimDamage.Name = "LiaEstimDamage"
        Me.LiaEstimDamage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LiaEstimDamage.Size = New System.Drawing.Size(1154, 60)
        Me.LiaEstimDamage.TabIndex = 1
        '
        'LiaInsuranceCoGroup
        '
        Me.LiaInsuranceCoGroup.Controls.Add(Me.LiaInsuranceCo)
        Me.LiaInsuranceCoGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LiaInsuranceCoGroup.Location = New System.Drawing.Point(3, 328)
        Me.LiaInsuranceCoGroup.Name = "LiaInsuranceCoGroup"
        Me.LiaInsuranceCoGroup.Size = New System.Drawing.Size(1160, 64)
        Me.LiaInsuranceCoGroup.TabIndex = 13
        Me.LiaInsuranceCoGroup.TabStop = False
        Me.LiaInsuranceCoGroup.Text = "Do you know the name of the at-fault driver / owner's insurance company?"
        '
        'LiaInsuranceCo
        '
        Me.LiaInsuranceCo.BackColor = System.Drawing.Color.White
        Me.LiaInsuranceCo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiaInsuranceCo.Location = New System.Drawing.Point(3, 16)
        Me.LiaInsuranceCo.Multiline = True
        Me.LiaInsuranceCo.Name = "LiaInsuranceCo"
        Me.LiaInsuranceCo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LiaInsuranceCo.Size = New System.Drawing.Size(1154, 45)
        Me.LiaInsuranceCo.TabIndex = 1
        '
        'LiaOwnerNameGroup
        '
        Me.LiaOwnerNameGroup.Controls.Add(Me.LiaOwnerName)
        Me.LiaOwnerNameGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LiaOwnerNameGroup.Location = New System.Drawing.Point(3, 257)
        Me.LiaOwnerNameGroup.Name = "LiaOwnerNameGroup"
        Me.LiaOwnerNameGroup.Size = New System.Drawing.Size(1160, 65)
        Me.LiaOwnerNameGroup.TabIndex = 12
        Me.LiaOwnerNameGroup.TabStop = False
        Me.LiaOwnerNameGroup.Text = "Please provide us with the correct name of the owner of the vehicle who you belie" &
    "ve to be at-fault for this accident"
        '
        'LiaOwnerName
        '
        Me.LiaOwnerName.BackColor = System.Drawing.Color.White
        Me.LiaOwnerName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiaOwnerName.Location = New System.Drawing.Point(3, 16)
        Me.LiaOwnerName.Multiline = True
        Me.LiaOwnerName.Name = "LiaOwnerName"
        Me.LiaOwnerName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LiaOwnerName.Size = New System.Drawing.Size(1154, 46)
        Me.LiaOwnerName.TabIndex = 1
        '
        'LiaDriverNameGroup
        '
        Me.LiaDriverNameGroup.Controls.Add(Me.LiaDriverName)
        Me.LiaDriverNameGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LiaDriverNameGroup.Location = New System.Drawing.Point(3, 189)
        Me.LiaDriverNameGroup.Name = "LiaDriverNameGroup"
        Me.LiaDriverNameGroup.Size = New System.Drawing.Size(1160, 62)
        Me.LiaDriverNameGroup.TabIndex = 11
        Me.LiaDriverNameGroup.TabStop = False
        Me.LiaDriverNameGroup.Text = "Please provide us with the correct name of the driver who you believe to be at-fa" &
    "ult for this accident"
        '
        'LiaDriverName
        '
        Me.LiaDriverName.BackColor = System.Drawing.Color.White
        Me.LiaDriverName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiaDriverName.Location = New System.Drawing.Point(3, 16)
        Me.LiaDriverName.Multiline = True
        Me.LiaDriverName.Name = "LiaDriverName"
        Me.LiaDriverName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LiaDriverName.Size = New System.Drawing.Size(1154, 43)
        Me.LiaDriverName.TabIndex = 1
        '
        'LiaYourFaultGroup
        '
        Me.LiaYourFaultGroup.Controls.Add(Me.LiaYourFault)
        Me.LiaYourFaultGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LiaYourFaultGroup.Location = New System.Drawing.Point(3, 104)
        Me.LiaYourFaultGroup.Name = "LiaYourFaultGroup"
        Me.LiaYourFaultGroup.Size = New System.Drawing.Size(1160, 79)
        Me.LiaYourFaultGroup.TabIndex = 10
        Me.LiaYourFaultGroup.TabStop = False
        Me.LiaYourFaultGroup.Text = "Were you in any way at fault for the accident?"
        '
        'LiaYourFault
        '
        Me.LiaYourFault.BackColor = System.Drawing.SystemColors.Window
        Me.LiaYourFault.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiaYourFault.Location = New System.Drawing.Point(3, 16)
        Me.LiaYourFault.Multiline = True
        Me.LiaYourFault.Name = "LiaYourFault"
        Me.LiaYourFault.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LiaYourFault.Size = New System.Drawing.Size(1154, 60)
        Me.LiaYourFault.TabIndex = 1
        '
        'OthersLiabilityGroup
        '
        Me.OthersLiabilityGroup.Controls.Add(Me.GroupBox38)
        Me.OthersLiabilityGroup.Controls.Add(Me.LieNotifiedMunicipalityGroup)
        Me.OthersLiabilityGroup.Controls.Add(Me.GroupBox35)
        Me.OthersLiabilityGroup.Controls.Add(Me.GroupBox36)
        Me.OthersLiabilityGroup.Controls.Add(Me.GroupBox37)
        Me.OthersLiabilityGroup.Location = New System.Drawing.Point(3, 830)
        Me.OthersLiabilityGroup.Name = "OthersLiabilityGroup"
        Me.OthersLiabilityGroup.Size = New System.Drawing.Size(1163, 395)
        Me.OthersLiabilityGroup.TabIndex = 19
        Me.OthersLiabilityGroup.TabStop = False
        Me.OthersLiabilityGroup.Text = "Information"
        '
        'GroupBox38
        '
        Me.GroupBox38.Controls.Add(Me.LiaHaveCopy)
        Me.GroupBox38.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox38.Location = New System.Drawing.Point(3, 19)
        Me.GroupBox38.Name = "GroupBox38"
        Me.GroupBox38.Size = New System.Drawing.Size(1160, 79)
        Me.GroupBox38.TabIndex = 14
        Me.GroupBox38.TabStop = False
        Me.GroupBox38.Text = "Do you have a copy of any incident report?"
        '
        'LiaHaveCopy
        '
        Me.LiaHaveCopy.BackColor = System.Drawing.SystemColors.Window
        Me.LiaHaveCopy.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiaHaveCopy.Location = New System.Drawing.Point(3, 16)
        Me.LiaHaveCopy.Multiline = True
        Me.LiaHaveCopy.Name = "LiaHaveCopy"
        Me.LiaHaveCopy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LiaHaveCopy.Size = New System.Drawing.Size(1154, 60)
        Me.LiaHaveCopy.TabIndex = 1
        '
        'LieNotifiedMunicipalityGroup
        '
        Me.LieNotifiedMunicipalityGroup.Controls.Add(Me.LiaNotifiedMunicipality)
        Me.LieNotifiedMunicipalityGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LieNotifiedMunicipalityGroup.Location = New System.Drawing.Point(3, 328)
        Me.LieNotifiedMunicipalityGroup.Name = "LieNotifiedMunicipalityGroup"
        Me.LieNotifiedMunicipalityGroup.Size = New System.Drawing.Size(1160, 64)
        Me.LieNotifiedMunicipalityGroup.TabIndex = 18
        Me.LieNotifiedMunicipalityGroup.TabStop = False
        Me.LieNotifiedMunicipalityGroup.Text = "If applicable, was the municipality put on notice?"
        '
        'LiaNotifiedMunicipality
        '
        Me.LiaNotifiedMunicipality.BackColor = System.Drawing.Color.White
        Me.LiaNotifiedMunicipality.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiaNotifiedMunicipality.Location = New System.Drawing.Point(3, 16)
        Me.LiaNotifiedMunicipality.Multiline = True
        Me.LiaNotifiedMunicipality.Name = "LiaNotifiedMunicipality"
        Me.LiaNotifiedMunicipality.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LiaNotifiedMunicipality.Size = New System.Drawing.Size(1154, 45)
        Me.LiaNotifiedMunicipality.TabIndex = 1
        '
        'GroupBox35
        '
        Me.GroupBox35.Controls.Add(Me.LiaMunicipality)
        Me.GroupBox35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox35.Location = New System.Drawing.Point(3, 257)
        Me.GroupBox35.Name = "GroupBox35"
        Me.GroupBox35.Size = New System.Drawing.Size(1160, 65)
        Me.GroupBox35.TabIndex = 17
        Me.GroupBox35.TabStop = False
        Me.GroupBox35.Text = "If a municipality may be at-fault for this incident, name of municipality"
        '
        'LiaMunicipality
        '
        Me.LiaMunicipality.BackColor = System.Drawing.Color.White
        Me.LiaMunicipality.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiaMunicipality.Location = New System.Drawing.Point(3, 16)
        Me.LiaMunicipality.Multiline = True
        Me.LiaMunicipality.Name = "LiaMunicipality"
        Me.LiaMunicipality.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LiaMunicipality.Size = New System.Drawing.Size(1154, 46)
        Me.LiaMunicipality.TabIndex = 1
        '
        'GroupBox36
        '
        Me.GroupBox36.Controls.Add(Me.LiaFaultPerson)
        Me.GroupBox36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox36.Location = New System.Drawing.Point(3, 189)
        Me.GroupBox36.Name = "GroupBox36"
        Me.GroupBox36.Size = New System.Drawing.Size(1160, 62)
        Me.GroupBox36.TabIndex = 16
        Me.GroupBox36.TabStop = False
        Me.GroupBox36.Text = "Please provide us with the name of any person(s) who you claim to be at-fault for" &
    " this incident"
        '
        'LiaFaultPerson
        '
        Me.LiaFaultPerson.BackColor = System.Drawing.Color.White
        Me.LiaFaultPerson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiaFaultPerson.Location = New System.Drawing.Point(3, 16)
        Me.LiaFaultPerson.Multiline = True
        Me.LiaFaultPerson.Name = "LiaFaultPerson"
        Me.LiaFaultPerson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LiaFaultPerson.Size = New System.Drawing.Size(1154, 43)
        Me.LiaFaultPerson.TabIndex = 1
        '
        'GroupBox37
        '
        Me.GroupBox37.Controls.Add(Me.LiaOwnNegligence)
        Me.GroupBox37.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox37.Location = New System.Drawing.Point(3, 104)
        Me.GroupBox37.Name = "GroupBox37"
        Me.GroupBox37.Size = New System.Drawing.Size(1160, 79)
        Me.GroupBox37.TabIndex = 15
        Me.GroupBox37.TabStop = False
        Me.GroupBox37.Text = "Did you in any way contribute to your own negligence?"
        '
        'LiaOwnNegligence
        '
        Me.LiaOwnNegligence.BackColor = System.Drawing.SystemColors.Window
        Me.LiaOwnNegligence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiaOwnNegligence.Location = New System.Drawing.Point(3, 16)
        Me.LiaOwnNegligence.Multiline = True
        Me.LiaOwnNegligence.Name = "LiaOwnNegligence"
        Me.LiaOwnNegligence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LiaOwnNegligence.Size = New System.Drawing.Size(1154, 60)
        Me.LiaOwnNegligence.TabIndex = 1
        '
        'LiaNotesGroup
        '
        Me.LiaNotesGroup.Controls.Add(Me.LiaNotes)
        Me.LiaNotesGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LiaNotesGroup.Location = New System.Drawing.Point(3, 1231)
        Me.LiaNotesGroup.Name = "LiaNotesGroup"
        Me.LiaNotesGroup.Size = New System.Drawing.Size(1160, 138)
        Me.LiaNotesGroup.TabIndex = 14
        Me.LiaNotesGroup.TabStop = False
        Me.LiaNotesGroup.Text = "Other relevant liability notes"
        '
        'LiaNotes
        '
        Me.LiaNotes.BackColor = System.Drawing.Color.White
        Me.LiaNotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LiaNotes.Location = New System.Drawing.Point(3, 16)
        Me.LiaNotes.Multiline = True
        Me.LiaNotes.Name = "LiaNotes"
        Me.LiaNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LiaNotes.Size = New System.Drawing.Size(1154, 119)
        Me.LiaNotes.TabIndex = 1
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.Liability)
        Me.TabControl.Controls.Add(Me.Policy)
        Me.TabControl.Controls.Add(Me.EmploymentIncomeLoss)
        Me.TabControl.Controls.Add(Me.Damages)
        Me.TabControl.Controls.Add(Me.AccidentBenefits)
        Me.TabControl.Controls.Add(Me.OtherNotes)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1350, 610)
        Me.TabControl.TabIndex = 154
        '
        'Policy
        '
        Me.Policy.AutoScroll = True
        Me.Policy.BackColor = System.Drawing.SystemColors.Menu
        Me.Policy.Controls.Add(Me.GroupBox96)
        Me.Policy.Controls.Add(Me.GroupBox95)
        Me.Policy.Controls.Add(Me.GroupBox94)
        Me.Policy.Controls.Add(Me.GroupBox128)
        Me.Policy.Controls.Add(Me.GroupBox127)
        Me.Policy.Controls.Add(Me.GroupBox126)
        Me.Policy.Controls.Add(Me.GroupBox125)
        Me.Policy.Controls.Add(Me.GroupBox124)
        Me.Policy.Controls.Add(Me.GroupBox101)
        Me.Policy.Controls.Add(Me.GroupBox123)
        Me.Policy.Controls.Add(Me.GroupBox102)
        Me.Policy.Controls.Add(Me.GroupBox98)
        Me.Policy.Controls.Add(Me.GroupBox93)
        Me.Policy.Controls.Add(Me.GroupBox97)
        Me.Policy.Controls.Add(Me.GroupBox99)
        Me.Policy.Controls.Add(Me.GroupBox100)
        Me.Policy.Location = New System.Drawing.Point(4, 22)
        Me.Policy.Name = "Policy"
        Me.Policy.Size = New System.Drawing.Size(1342, 584)
        Me.Policy.TabIndex = 7
        Me.Policy.Text = "Policy"
        '
        'GroupBox96
        '
        Me.GroupBox96.Controls.Add(Me.TextBox75)
        Me.GroupBox96.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox96.Location = New System.Drawing.Point(16, 689)
        Me.GroupBox96.Name = "GroupBox96"
        Me.GroupBox96.Size = New System.Drawing.Size(1160, 58)
        Me.GroupBox96.TabIndex = 36
        Me.GroupBox96.TabStop = False
        Me.GroupBox96.Text = "Was your CPP Disability benefits application ever approved?"
        '
        'TextBox75
        '
        Me.TextBox75.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox75.Location = New System.Drawing.Point(8, 20)
        Me.TextBox75.Multiline = True
        Me.TextBox75.Name = "TextBox75"
        Me.TextBox75.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox75.Size = New System.Drawing.Size(1141, 27)
        Me.TextBox75.TabIndex = 1
        '
        'GroupBox95
        '
        Me.GroupBox95.Controls.Add(Me.TextBox74)
        Me.GroupBox95.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox95.Location = New System.Drawing.Point(16, 625)
        Me.GroupBox95.Name = "GroupBox95"
        Me.GroupBox95.Size = New System.Drawing.Size(1160, 58)
        Me.GroupBox95.TabIndex = 35
        Me.GroupBox95.TabStop = False
        Me.GroupBox95.Text = "Did you decided to apply for CPP Disability Benefits on you own or were you asked" &
    " to apply for CPP Disability by your insurance company?"
        '
        'TextBox74
        '
        Me.TextBox74.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox74.Location = New System.Drawing.Point(8, 20)
        Me.TextBox74.Multiline = True
        Me.TextBox74.Name = "TextBox74"
        Me.TextBox74.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox74.Size = New System.Drawing.Size(1141, 27)
        Me.TextBox74.TabIndex = 1
        '
        'GroupBox94
        '
        Me.GroupBox94.Controls.Add(Me.TextBox73)
        Me.GroupBox94.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox94.Location = New System.Drawing.Point(16, 561)
        Me.GroupBox94.Name = "GroupBox94"
        Me.GroupBox94.Size = New System.Drawing.Size(1160, 58)
        Me.GroupBox94.TabIndex = 34
        Me.GroupBox94.TabStop = False
        Me.GroupBox94.Text = "Before being terminated from LTD benefits had you ever made an application for CP" &
    "P disability benefits?"
        '
        'TextBox73
        '
        Me.TextBox73.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox73.Location = New System.Drawing.Point(8, 20)
        Me.TextBox73.Multiline = True
        Me.TextBox73.Name = "TextBox73"
        Me.TextBox73.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox73.Size = New System.Drawing.Size(1141, 27)
        Me.TextBox73.TabIndex = 1
        '
        'GroupBox128
        '
        Me.GroupBox128.Controls.Add(Me.TextBox107)
        Me.GroupBox128.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox128.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox128.Location = New System.Drawing.Point(16, 460)
        Me.GroupBox128.Name = "GroupBox128"
        Me.GroupBox128.Size = New System.Drawing.Size(1160, 95)
        Me.GroupBox128.TabIndex = 33
        Me.GroupBox128.TabStop = False
        Me.GroupBox128.Text = "Briefly explain the reason the insurance company provided to you when it decided " &
    "to terminate your LTD benefits"
        '
        'TextBox107
        '
        Me.TextBox107.BackColor = System.Drawing.Color.White
        Me.TextBox107.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox107.Location = New System.Drawing.Point(8, 20)
        Me.TextBox107.Multiline = True
        Me.TextBox107.Name = "TextBox107"
        Me.TextBox107.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox107.Size = New System.Drawing.Size(1141, 67)
        Me.TextBox107.TabIndex = 1
        '
        'GroupBox127
        '
        Me.GroupBox127.Controls.Add(Me.DateTimePicker8)
        Me.GroupBox127.Controls.Add(Me.Label120)
        Me.GroupBox127.Location = New System.Drawing.Point(867, 348)
        Me.GroupBox127.Name = "GroupBox127"
        Me.GroupBox127.Size = New System.Drawing.Size(323, 42)
        Me.GroupBox127.TabIndex = 32
        Me.GroupBox127.TabStop = False
        '
        'DateTimePicker8
        '
        Me.DateTimePicker8.CustomFormat = "MMM-dd-yyyy"
        Me.DateTimePicker8.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker8.Location = New System.Drawing.Point(222, 14)
        Me.DateTimePicker8.Name = "DateTimePicker8"
        Me.DateTimePicker8.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker8.TabIndex = 8
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.Location = New System.Drawing.Point(6, 13)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(218, 17)
        Me.Label120.TabIndex = 19
        Me.Label120.Text = "Last day you were paid LTD benefits"
        '
        'GroupBox126
        '
        Me.GroupBox126.Controls.Add(Me.TextBox80)
        Me.GroupBox126.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox126.Location = New System.Drawing.Point(16, 396)
        Me.GroupBox126.Name = "GroupBox126"
        Me.GroupBox126.Size = New System.Drawing.Size(1160, 58)
        Me.GroupBox126.TabIndex = 31
        Me.GroupBox126.TabStop = False
        Me.GroupBox126.Text = "Were your LTD benefits initially approved when you first applied for disability b" &
    "enefits?"
        '
        'TextBox80
        '
        Me.TextBox80.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox80.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox80.Location = New System.Drawing.Point(3, 16)
        Me.TextBox80.Multiline = True
        Me.TextBox80.Name = "TextBox80"
        Me.TextBox80.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox80.Size = New System.Drawing.Size(1154, 39)
        Me.TextBox80.TabIndex = 1
        '
        'GroupBox125
        '
        Me.GroupBox125.Controls.Add(Me.DateTimePicker7)
        Me.GroupBox125.Controls.Add(Me.Label119)
        Me.GroupBox125.Location = New System.Drawing.Point(503, 348)
        Me.GroupBox125.Name = "GroupBox125"
        Me.GroupBox125.Size = New System.Drawing.Size(361, 42)
        Me.GroupBox125.TabIndex = 30
        Me.GroupBox125.TabStop = False
        '
        'DateTimePicker7
        '
        Me.DateTimePicker7.CustomFormat = "MMM-dd-yyyy"
        Me.DateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker7.Location = New System.Drawing.Point(249, 13)
        Me.DateTimePicker7.Name = "DateTimePicker7"
        Me.DateTimePicker7.Size = New System.Drawing.Size(106, 20)
        Me.DateTimePicker7.TabIndex = 8
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.Location = New System.Drawing.Point(6, 13)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(246, 17)
        Me.Label119.TabIndex = 19
        Me.Label119.Text = "Date you started collecting LTD benefits"
        '
        'GroupBox124
        '
        Me.GroupBox124.Controls.Add(Me.DateTimePicker5)
        Me.GroupBox124.Controls.Add(Me.Label118)
        Me.GroupBox124.Location = New System.Drawing.Point(16, 348)
        Me.GroupBox124.Name = "GroupBox124"
        Me.GroupBox124.Size = New System.Drawing.Size(484, 42)
        Me.GroupBox124.TabIndex = 29
        Me.GroupBox124.TabStop = False
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.CustomFormat = "MMM-dd-yyyy"
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker5.Location = New System.Drawing.Point(358, 13)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(109, 20)
        Me.DateTimePicker5.TabIndex = 8
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label118.Location = New System.Drawing.Point(6, 13)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(346, 17)
        Me.Label118.TabIndex = 19
        Me.Label118.Text = "Date that you submitted your application for LTD benefits"
        '
        'GroupBox101
        '
        Me.GroupBox101.Controls.Add(Me.TextBox77)
        Me.GroupBox101.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox101.Location = New System.Drawing.Point(16, 284)
        Me.GroupBox101.Name = "GroupBox101"
        Me.GroupBox101.Size = New System.Drawing.Size(1160, 58)
        Me.GroupBox101.TabIndex = 28
        Me.GroupBox101.TabStop = False
        Me.GroupBox101.Text = "Is your LTD policy a private policy or an employer group policy?"
        '
        'TextBox77
        '
        Me.TextBox77.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox77.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox77.Location = New System.Drawing.Point(3, 16)
        Me.TextBox77.Multiline = True
        Me.TextBox77.Name = "TextBox77"
        Me.TextBox77.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox77.Size = New System.Drawing.Size(1154, 39)
        Me.TextBox77.TabIndex = 1
        '
        'GroupBox123
        '
        Me.GroupBox123.Controls.Add(Me.ComboBox39)
        Me.GroupBox123.Controls.Add(Me.Label116)
        Me.GroupBox123.Location = New System.Drawing.Point(16, 236)
        Me.GroupBox123.Name = "GroupBox123"
        Me.GroupBox123.Size = New System.Drawing.Size(689, 42)
        Me.GroupBox123.TabIndex = 27
        Me.GroupBox123.TabStop = False
        '
        'ComboBox39
        '
        Me.ComboBox39.DisplayMember = "Company"
        Me.ComboBox39.FormattingEnabled = True
        Me.ComboBox39.Location = New System.Drawing.Point(342, 11)
        Me.ComboBox39.Name = "ComboBox39"
        Me.ComboBox39.Size = New System.Drawing.Size(341, 21)
        Me.ComboBox39.TabIndex = 20
        Me.ComboBox39.ValueMember = "Company"
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.Location = New System.Drawing.Point(6, 13)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(330, 17)
        Me.Label116.TabIndex = 19
        Me.Label116.Text = "Name of Insurance company who denied your benefits"
        '
        'GroupBox102
        '
        Me.GroupBox102.Controls.Add(Me.ComboBox38)
        Me.GroupBox102.Controls.Add(Me.Label115)
        Me.GroupBox102.Location = New System.Drawing.Point(654, 126)
        Me.GroupBox102.Name = "GroupBox102"
        Me.GroupBox102.Size = New System.Drawing.Size(520, 42)
        Me.GroupBox102.TabIndex = 26
        Me.GroupBox102.TabStop = False
        '
        'ComboBox38
        '
        Me.ComboBox38.FormattingEnabled = True
        Me.ComboBox38.Items.AddRange(New Object() {"STD", "LTD", "STD & LTD"})
        Me.ComboBox38.Location = New System.Drawing.Point(219, 10)
        Me.ComboBox38.Name = "ComboBox38"
        Me.ComboBox38.Size = New System.Drawing.Size(292, 21)
        Me.ComboBox38.TabIndex = 20
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.Location = New System.Drawing.Point(6, 13)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(207, 17)
        Me.Label115.TabIndex = 19
        Me.Label115.Text = "Were you denied STD and/or LTD?"
        '
        'GroupBox98
        '
        Me.GroupBox98.Controls.Add(Me.DateTimePicker6)
        Me.GroupBox98.Controls.Add(Me.Label117)
        Me.GroupBox98.Location = New System.Drawing.Point(16, 126)
        Me.GroupBox98.Name = "GroupBox98"
        Me.GroupBox98.Size = New System.Drawing.Size(632, 42)
        Me.GroupBox98.TabIndex = 24
        Me.GroupBox98.TabStop = False
        '
        'DateTimePicker6
        '
        Me.DateTimePicker6.CustomFormat = "MMM-dd-yyyy"
        Me.DateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker6.Location = New System.Drawing.Point(466, 11)
        Me.DateTimePicker6.Name = "DateTimePicker6"
        Me.DateTimePicker6.Size = New System.Drawing.Size(150, 20)
        Me.DateTimePicker6.TabIndex = 8
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.Location = New System.Drawing.Point(6, 13)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(454, 17)
        Me.Label117.TabIndex = 19
        Me.Label117.Text = "Until what date were you paid sick benefits or short-term disability benefits?"
        '
        'GroupBox93
        '
        Me.GroupBox93.Controls.Add(Me.TextBox72)
        Me.GroupBox93.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox93.Location = New System.Drawing.Point(14, 752)
        Me.GroupBox93.Name = "GroupBox93"
        Me.GroupBox93.Size = New System.Drawing.Size(1160, 138)
        Me.GroupBox93.TabIndex = 14
        Me.GroupBox93.TabStop = False
        Me.GroupBox93.Text = "Other relevant policy notes"
        '
        'TextBox72
        '
        Me.TextBox72.BackColor = System.Drawing.Color.White
        Me.TextBox72.Location = New System.Drawing.Point(8, 20)
        Me.TextBox72.Multiline = True
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox72.Size = New System.Drawing.Size(1141, 110)
        Me.TextBox72.TabIndex = 1
        '
        'GroupBox97
        '
        Me.GroupBox97.Controls.Add(Me.TextBox76)
        Me.GroupBox97.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox97.Location = New System.Drawing.Point(17, 175)
        Me.GroupBox97.Name = "GroupBox97"
        Me.GroupBox97.Size = New System.Drawing.Size(1160, 58)
        Me.GroupBox97.TabIndex = 10
        Me.GroupBox97.TabStop = False
        Me.GroupBox97.Text = "How much were you being paid?"
        '
        'TextBox76
        '
        Me.TextBox76.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox76.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox76.Location = New System.Drawing.Point(3, 16)
        Me.TextBox76.Multiline = True
        Me.TextBox76.Name = "TextBox76"
        Me.TextBox76.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox76.Size = New System.Drawing.Size(1154, 39)
        Me.TextBox76.TabIndex = 1
        '
        'GroupBox99
        '
        Me.GroupBox99.Controls.Add(Me.TextBox78)
        Me.GroupBox99.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox99.Location = New System.Drawing.Point(16, 67)
        Me.GroupBox99.Name = "GroupBox99"
        Me.GroupBox99.Size = New System.Drawing.Size(1160, 56)
        Me.GroupBox99.TabIndex = 8
        Me.GroupBox99.TabStop = False
        Me.GroupBox99.Text = "Who paid those benefits to you?"
        '
        'TextBox78
        '
        Me.TextBox78.BackColor = System.Drawing.Color.White
        Me.TextBox78.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox78.Location = New System.Drawing.Point(3, 16)
        Me.TextBox78.Multiline = True
        Me.TextBox78.Name = "TextBox78"
        Me.TextBox78.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox78.Size = New System.Drawing.Size(1154, 37)
        Me.TextBox78.TabIndex = 1
        '
        'GroupBox100
        '
        Me.GroupBox100.Controls.Add(Me.TextBox79)
        Me.GroupBox100.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox100.Location = New System.Drawing.Point(18, 14)
        Me.GroupBox100.Name = "GroupBox100"
        Me.GroupBox100.Size = New System.Drawing.Size(1160, 52)
        Me.GroupBox100.TabIndex = 7
        Me.GroupBox100.TabStop = False
        Me.GroupBox100.Text = "When you went off work on disability did you collect any form of sick benefits or" &
    " short-term disability benefits?"
        '
        'TextBox79
        '
        Me.TextBox79.BackColor = System.Drawing.Color.White
        Me.TextBox79.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox79.Location = New System.Drawing.Point(3, 16)
        Me.TextBox79.Multiline = True
        Me.TextBox79.Name = "TextBox79"
        Me.TextBox79.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox79.Size = New System.Drawing.Size(1154, 33)
        Me.TextBox79.TabIndex = 1
        '
        'IntakeSheets
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TabControl)
        Me.Name = "IntakeSheets"
        Me.Size = New System.Drawing.Size(1350, 610)
        CType(Me.ActionLogDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CYATemplatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OtherNotes.ResumeLayout(False)
        Me.AccidentBenefits.ResumeLayout(False)
        Me.AccidentBenefits.PerformLayout()
        Me.GroupBox31.ResumeLayout(False)
        Me.GroupBox31.PerformLayout()
        Me.GroupBox30.ResumeLayout(False)
        Me.GroupBox30.PerformLayout()
        Me.Damages.ResumeLayout(False)
        Me.GroupBox29.ResumeLayout(False)
        Me.GroupBox29.PerformLayout()
        Me.GroupBox28.ResumeLayout(False)
        Me.GroupBox28.PerformLayout()
        Me.GroupBox27.ResumeLayout(False)
        Me.GroupBox27.PerformLayout()
        Me.GroupBox26.ResumeLayout(False)
        Me.GroupBox26.PerformLayout()
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox25.PerformLayout()
        Me.GroupBox24.ResumeLayout(False)
        Me.GroupBox24.PerformLayout()
        Me.GroupBox23.ResumeLayout(False)
        Me.GroupBox23.PerformLayout()
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox22.PerformLayout()
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox21.PerformLayout()
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.EmploymentIncomeLoss.ResumeLayout(False)
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.Liability.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.IncidentDateTimeGroupBox.ResumeLayout(False)
        Me.ReceiveCopyGroupBox.ResumeLayout(False)
        Me.ReceiveCopyGroupBox.PerformLayout()
        Me.LiaWhereAccidentGroup.ResumeLayout(False)
        Me.LiaWhereAccidentGroup.PerformLayout()
        Me.LiaExplainGroup.ResumeLayout(False)
        Me.LiaExplainGroup.PerformLayout()
        Me.LiaHavePhotosGroup.ResumeLayout(False)
        Me.LiaHavePhotosGroup.PerformLayout()
        Me.MVALiabilityGroup.ResumeLayout(False)
        Me.LiaEstimDamageGroup.ResumeLayout(False)
        Me.LiaEstimDamageGroup.PerformLayout()
        Me.LiaInsuranceCoGroup.ResumeLayout(False)
        Me.LiaInsuranceCoGroup.PerformLayout()
        Me.LiaOwnerNameGroup.ResumeLayout(False)
        Me.LiaOwnerNameGroup.PerformLayout()
        Me.LiaDriverNameGroup.ResumeLayout(False)
        Me.LiaDriverNameGroup.PerformLayout()
        Me.LiaYourFaultGroup.ResumeLayout(False)
        Me.LiaYourFaultGroup.PerformLayout()
        Me.OthersLiabilityGroup.ResumeLayout(False)
        Me.GroupBox38.ResumeLayout(False)
        Me.GroupBox38.PerformLayout()
        Me.LieNotifiedMunicipalityGroup.ResumeLayout(False)
        Me.LieNotifiedMunicipalityGroup.PerformLayout()
        Me.GroupBox35.ResumeLayout(False)
        Me.GroupBox35.PerformLayout()
        Me.GroupBox36.ResumeLayout(False)
        Me.GroupBox36.PerformLayout()
        Me.GroupBox37.ResumeLayout(False)
        Me.GroupBox37.PerformLayout()
        Me.LiaNotesGroup.ResumeLayout(False)
        Me.LiaNotesGroup.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.Policy.ResumeLayout(False)
        Me.GroupBox96.ResumeLayout(False)
        Me.GroupBox96.PerformLayout()
        Me.GroupBox95.ResumeLayout(False)
        Me.GroupBox95.PerformLayout()
        Me.GroupBox94.ResumeLayout(False)
        Me.GroupBox94.PerformLayout()
        Me.GroupBox128.ResumeLayout(False)
        Me.GroupBox128.PerformLayout()
        Me.GroupBox127.ResumeLayout(False)
        Me.GroupBox127.PerformLayout()
        Me.GroupBox126.ResumeLayout(False)
        Me.GroupBox126.PerformLayout()
        Me.GroupBox125.ResumeLayout(False)
        Me.GroupBox125.PerformLayout()
        Me.GroupBox124.ResumeLayout(False)
        Me.GroupBox124.PerformLayout()
        Me.GroupBox101.ResumeLayout(False)
        Me.GroupBox101.PerformLayout()
        Me.GroupBox123.ResumeLayout(False)
        Me.GroupBox123.PerformLayout()
        Me.GroupBox102.ResumeLayout(False)
        Me.GroupBox102.PerformLayout()
        Me.GroupBox98.ResumeLayout(False)
        Me.GroupBox98.PerformLayout()
        Me.GroupBox93.ResumeLayout(False)
        Me.GroupBox93.PerformLayout()
        Me.GroupBox97.ResumeLayout(False)
        Me.GroupBox97.PerformLayout()
        Me.GroupBox99.ResumeLayout(False)
        Me.GroupBox99.PerformLayout()
        Me.GroupBox100.ResumeLayout(False)
        Me.GroupBox100.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CYATemplatesBindingSource As BindingSource
    Friend WithEvents ActionLogDBDataSet As ActionLogDBDataSet
    Friend WithEvents CyaTemplatesTableAdapter As ActionLogDBDataSetTableAdapters.CYATemplatesTableAdapter
    Friend WithEvents OtherNotes As TabPage
    Friend WithEvents Notes As RichTextBox
    Friend WithEvents AccidentBenefits As TabPage
    Friend WithEvents GroupBox31 As GroupBox
    Friend WithEvents AccBenNotes As TextBox
    Friend WithEvents GroupBox30 As GroupBox
    Friend WithEvents AccBenReplacBenef As TextBox
    Friend WithEvents AccBenOCF3 As ComboBox
    Friend WithEvents Label40 As Label
    Friend WithEvents AccBenOCF2 As ComboBox
    Friend WithEvents Label39 As Label
    Friend WithEvents AccBenOCF1 As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents AccBenAdjuster As TextBox
    Friend WithEvents AccBenRegisOwnerName As TextBox
    Friend WithEvents AccBenClaimNumber As TextBox
    Friend WithEvents AccBenPolicyNumber As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents AccBenWereRegisOwner As ComboBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents AccBenInsuranceCompany As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents AccBenDriverPassenger As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Damages As TabPage
    Friend WithEvents GroupBox29 As GroupBox
    Friend WithEvents DamNotes As TextBox
    Friend WithEvents GroupBox28 As GroupBox
    Friend WithEvents DamPreIllness As TextBox
    Friend WithEvents GroupBox27 As GroupBox
    Friend WithEvents DamPreAccident As TextBox
    Friend WithEvents GroupBox26 As GroupBox
    Friend WithEvents DamWereSeeingDoctor As TextBox
    Friend WithEvents GroupBox25 As GroupBox
    Friend WithEvents DamPrescribed As TextBox
    Friend WithEvents GroupBox24 As GroupBox
    Friend WithEvents DamPsychologicalEffect As TextBox
    Friend WithEvents GroupBox23 As GroupBox
    Friend WithEvents DamLowerBodyInjuries As TextBox
    Friend WithEvents GroupBox22 As GroupBox
    Friend WithEvents DamUpperBodyInjuries As TextBox
    Friend WithEvents GroupBox21 As GroupBox
    Friend WithEvents DamHeadInjuries As TextBox
    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents DamWentToHospital As TextBox
    Friend WithEvents GroupBox19 As GroupBox
    Friend WithEvents DamHitVehicleConcrete As TextBox
    Friend WithEvents EmploymentIncomeLoss As TabPage
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents EILNotes As TextBox
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents EILHowLongBusiness As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents EILSelfGrossEarning As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents EILSelfBusinessName As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents EILWereSelfEmployed As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents EILCollecInsurance As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Label25 As Label
    Friend WithEvents EILExplainJob As TextBox
    Friend WithEvents EILJobTitle As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents EILHowLongEmployee As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents EILEmployeeGrossEarning As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents EILT4Company As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents EILT4Employee As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents EILEmployed52Weeks As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents EILEmployed4Weeks As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents EILWereEmployed As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Liability As TabPage
    Friend WithEvents LiaNotesGroup As GroupBox
    Friend WithEvents LiaNotes As TextBox
    Friend WithEvents LiaInsuranceCoGroup As GroupBox
    Friend WithEvents LiaInsuranceCo As TextBox
    Friend WithEvents LiaOwnerNameGroup As GroupBox
    Friend WithEvents LiaOwnerName As TextBox
    Friend WithEvents LiaDriverNameGroup As GroupBox
    Friend WithEvents LiaDriverName As TextBox
    Friend WithEvents LiaYourFaultGroup As GroupBox
    Friend WithEvents LiaYourFault As TextBox
    Friend WithEvents LiaEstimDamageGroup As GroupBox
    Friend WithEvents LiaEstimDamage As TextBox
    Friend WithEvents LiaHavePhotosGroup As GroupBox
    Friend WithEvents LiaHavePhotos As TextBox
    Friend WithEvents LiaWhereAccidentGroup As GroupBox
    Friend WithEvents LiaWhereAccident As TextBox
    Friend WithEvents ReceiveCopyGroupBox As GroupBox
    Friend WithEvents LiaOtherDoc As CheckBox
    Friend WithEvents LiaMVCExchange As CheckBox
    Friend WithEvents LiaReportCollision As CheckBox
    Friend WithEvents LiaMVR As CheckBox
    Friend WithEvents IncidentDateTimeGroupBox As GroupBox
    Friend WithEvents LiaDate As DateTimePicker
    Friend WithEvents LiaTime As DateTimePicker
    Friend WithEvents LiaExplainGroup As GroupBox
    Friend WithEvents LiaExplain As TextBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents Policy As TabPage
    Friend WithEvents GroupBox96 As GroupBox
    Friend WithEvents TextBox75 As TextBox
    Friend WithEvents GroupBox95 As GroupBox
    Friend WithEvents TextBox74 As TextBox
    Friend WithEvents GroupBox94 As GroupBox
    Friend WithEvents TextBox73 As TextBox
    Friend WithEvents GroupBox128 As GroupBox
    Friend WithEvents TextBox107 As TextBox
    Friend WithEvents GroupBox127 As GroupBox
    Friend WithEvents DateTimePicker8 As DateTimePicker
    Friend WithEvents Label120 As Label
    Friend WithEvents GroupBox126 As GroupBox
    Friend WithEvents TextBox80 As TextBox
    Friend WithEvents GroupBox125 As GroupBox
    Friend WithEvents DateTimePicker7 As DateTimePicker
    Friend WithEvents Label119 As Label
    Friend WithEvents GroupBox124 As GroupBox
    Friend WithEvents DateTimePicker5 As DateTimePicker
    Friend WithEvents Label118 As Label
    Friend WithEvents GroupBox101 As GroupBox
    Friend WithEvents TextBox77 As TextBox
    Friend WithEvents GroupBox123 As GroupBox
    Friend WithEvents ComboBox39 As ComboBox
    Friend WithEvents Label116 As Label
    Friend WithEvents GroupBox102 As GroupBox
    Friend WithEvents ComboBox38 As ComboBox
    Friend WithEvents Label115 As Label
    Friend WithEvents GroupBox98 As GroupBox
    Friend WithEvents DateTimePicker6 As DateTimePicker
    Friend WithEvents Label117 As Label
    Friend WithEvents GroupBox93 As GroupBox
    Friend WithEvents TextBox72 As TextBox
    Friend WithEvents GroupBox97 As GroupBox
    Friend WithEvents TextBox76 As TextBox
    Friend WithEvents GroupBox99 As GroupBox
    Friend WithEvents TextBox78 As TextBox
    Friend WithEvents GroupBox100 As GroupBox
    Friend WithEvents TextBox79 As TextBox
    Friend WithEvents LieNotifiedMunicipalityGroup As GroupBox
    Friend WithEvents LiaNotifiedMunicipality As TextBox
    Friend WithEvents GroupBox35 As GroupBox
    Friend WithEvents LiaMunicipality As TextBox
    Friend WithEvents GroupBox36 As GroupBox
    Friend WithEvents LiaFaultPerson As TextBox
    Friend WithEvents GroupBox37 As GroupBox
    Friend WithEvents LiaOwnNegligence As TextBox
    Friend WithEvents GroupBox38 As GroupBox
    Friend WithEvents LiaHaveCopy As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents MVALiabilityGroup As GroupBox
    Friend WithEvents OthersLiabilityGroup As GroupBox
End Class
