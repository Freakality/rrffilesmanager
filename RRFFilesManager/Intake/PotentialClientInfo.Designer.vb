<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PotentialClientInfo
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
        Me.PotentialClientInfoPanel = New System.Windows.Forms.Panel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PCIOtherNotes = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.PCIMobileNumber = New System.Windows.Forms.MaskedTextBox()
        Me.PCIWorkNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PCICity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PCISalutation = New System.Windows.Forms.ComboBox()
        Me.PCIFirstName = New System.Windows.Forms.TextBox()
        Me.PCILastName = New System.Windows.Forms.TextBox()
        Me.PCIAddress = New System.Windows.Forms.TextBox()
        Me.PCISuiteApt = New System.Windows.Forms.TextBox()
        Me.PCIEmail = New System.Windows.Forms.TextBox()
        Me.PCIProvince = New System.Windows.Forms.ComboBox()
        Me.PCIEmailToText = New System.Windows.Forms.TextBox()
        Me.PCIMobileCarrier = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PCIPostalCode = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PCIHomeNumber = New System.Windows.Forms.MaskedTextBox()
        Me.TableLayoutPanel9 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.monthBirth = New System.Windows.Forms.ComboBox()
        Me.yearBirth = New System.Windows.Forms.MaskedTextBox()
        Me.dayBirth = New System.Windows.Forms.ComboBox()
        Me.ActionLogDBDataSet = New RRFFilesManager.ActionLogDBDataSet()
        Me.MobileCarrierTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.MobileCarrierTableAdapter()
        Me.MobileCarrierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvincesTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.ProvincesTableAdapter()
        Me.ProvincesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IntakesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IntakesTableAdapter = New RRFFilesManager.ActionLogDBDataSetTableAdapters.IntakesTableAdapter()
        Me.PotentialClientInfoPanel.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel9.SuspendLayout()
        CType(Me.ActionLogDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileCarrierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvincesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntakesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PotentialClientInfoPanel
        '
        Me.PotentialClientInfoPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PotentialClientInfoPanel.BackColor = System.Drawing.Color.White
        Me.PotentialClientInfoPanel.Controls.Add(Me.Label41)
        Me.PotentialClientInfoPanel.Controls.Add(Me.TableLayoutPanel4)
        Me.PotentialClientInfoPanel.Controls.Add(Me.TableLayoutPanel3)
        Me.PotentialClientInfoPanel.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PotentialClientInfoPanel.Location = New System.Drawing.Point(51, 28)
        Me.PotentialClientInfoPanel.Name = "PotentialClientInfoPanel"
        Me.PotentialClientInfoPanel.Size = New System.Drawing.Size(1250, 554)
        Me.PotentialClientInfoPanel.TabIndex = 143
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(20, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(216, 26)
        Me.Label41.TabIndex = 2
        Me.Label41.Text = "Potential Client Info"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label16, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.PCIOtherNotes, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(25, 379)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1196, 156)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 19)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "Other Notes"
        '
        'PCIOtherNotes
        '
        Me.PCIOtherNotes.BackColor = System.Drawing.Color.White
        Me.PCIOtherNotes.Location = New System.Drawing.Point(3, 27)
        Me.PCIOtherNotes.Multiline = True
        Me.PCIOtherNotes.Name = "PCIOtherNotes"
        Me.PCIOtherNotes.Size = New System.Drawing.Size(1172, 126)
        Me.PCIOtherNotes.TabIndex = 21
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label69, 2, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.PCIMobileNumber, 2, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.PCIWorkNumber, 1, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 0, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.Label8, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label10, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.PCICity, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 0, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.PCISalutation, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.PCIFirstName, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.PCILastName, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.PCIAddress, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.PCISuiteApt, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.PCIEmail, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.PCIProvince, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.PCIEmailToText, 1, 9)
        Me.TableLayoutPanel3.Controls.Add(Me.PCIMobileCarrier, 0, 9)
        Me.TableLayoutPanel3.Controls.Add(Me.Label14, 1, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.PCIPostalCode, 2, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label13, 1, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 2, 6)
        Me.TableLayoutPanel3.Controls.Add(Me.PCIHomeNumber, 0, 7)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel9, 2, 9)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(25, 46)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 10
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1196, 307)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(799, 242)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(93, 15)
        Me.Label69.TabIndex = 33
        Me.Label69.Text = "Date of Birth"
        '
        'PCIMobileNumber
        '
        Me.PCIMobileNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "PCIMobileNumber", True))
        Me.PCIMobileNumber.Location = New System.Drawing.Point(799, 200)
        Me.PCIMobileNumber.Mask = "(999) 000-0000"
        Me.PCIMobileNumber.Name = "PCIMobileNumber"
        Me.PCIMobileNumber.Size = New System.Drawing.Size(374, 24)
        Me.PCIMobileNumber.TabIndex = 31
        '
        'PCIWorkNumber
        '
        Me.PCIWorkNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "PCIWorkNumber", True))
        Me.PCIWorkNumber.Location = New System.Drawing.Point(401, 200)
        Me.PCIWorkNumber.Mask = "(999) 000-0000"
        Me.PCIWorkNumber.Name = "PCIWorkNumber"
        Me.PCIWorkNumber.Size = New System.Drawing.Size(372, 24)
        Me.PCIWorkNumber.TabIndex = 30
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 242)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 15)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Mobile Carrier"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Province"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(799, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Postal Code"
        '
        'PCICity
        '
        Me.PCICity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "PCICity", True))
        Me.PCICity.Location = New System.Drawing.Point(401, 142)
        Me.PCICity.Name = "PCICity"
        Me.PCICity.Size = New System.Drawing.Size(372, 24)
        Me.PCICity.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(401, 121)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 18)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "City"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 182)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 15)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Home Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(401, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Suite/Apt."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(799, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Salutations"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(401, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(799, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Last Name"
        '
        'PCISalutation
        '
        Me.PCISalutation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "PCISalutation", True))
        Me.PCISalutation.FormattingEnabled = True
        Me.PCISalutation.Items.AddRange(New Object() {"Miss", "Ms.", "Mr."})
        Me.PCISalutation.Location = New System.Drawing.Point(3, 19)
        Me.PCISalutation.Name = "PCISalutation"
        Me.PCISalutation.Size = New System.Drawing.Size(121, 25)
        Me.PCISalutation.TabIndex = 3
        '
        'PCIFirstName
        '
        Me.PCIFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "PCIFirstName", True))
        Me.PCIFirstName.Location = New System.Drawing.Point(401, 19)
        Me.PCIFirstName.Name = "PCIFirstName"
        Me.PCIFirstName.Size = New System.Drawing.Size(372, 24)
        Me.PCIFirstName.TabIndex = 4
        '
        'PCILastName
        '
        Me.PCILastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "PCILastName", True))
        Me.PCILastName.Location = New System.Drawing.Point(799, 19)
        Me.PCILastName.Name = "PCILastName"
        Me.PCILastName.Size = New System.Drawing.Size(374, 24)
        Me.PCILastName.TabIndex = 5
        '
        'PCIAddress
        '
        Me.PCIAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "PCIAddress", True))
        Me.PCIAddress.Location = New System.Drawing.Point(3, 83)
        Me.PCIAddress.Name = "PCIAddress"
        Me.PCIAddress.Size = New System.Drawing.Size(372, 24)
        Me.PCIAddress.TabIndex = 9
        '
        'PCISuiteApt
        '
        Me.PCISuiteApt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "PCISuiteApt", True))
        Me.PCISuiteApt.Location = New System.Drawing.Point(401, 83)
        Me.PCISuiteApt.Name = "PCISuiteApt"
        Me.PCISuiteApt.Size = New System.Drawing.Size(372, 24)
        Me.PCISuiteApt.TabIndex = 10
        '
        'PCIEmail
        '
        Me.PCIEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "PCIEmail", True))
        Me.PCIEmail.Location = New System.Drawing.Point(799, 83)
        Me.PCIEmail.Name = "PCIEmail"
        Me.PCIEmail.Size = New System.Drawing.Size(372, 24)
        Me.PCIEmail.TabIndex = 11
        '
        'PCIProvince
        '
        Me.PCIProvince.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "PCIProvince", True))
        Me.PCIProvince.DataSource = Me.ProvincesBindingSource
        Me.PCIProvince.DisplayMember = "Province"
        Me.PCIProvince.FormattingEnabled = True
        Me.PCIProvince.Location = New System.Drawing.Point(3, 142)
        Me.PCIProvince.Name = "PCIProvince"
        Me.PCIProvince.Size = New System.Drawing.Size(372, 25)
        Me.PCIProvince.TabIndex = 15
        Me.PCIProvince.ValueMember = "Province"
        '
        'PCIEmailToText
        '
        Me.PCIEmailToText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "PCIEmailToText", True))
        Me.PCIEmailToText.Location = New System.Drawing.Point(401, 260)
        Me.PCIEmailToText.Name = "PCIEmailToText"
        Me.PCIEmailToText.Size = New System.Drawing.Size(372, 24)
        Me.PCIEmailToText.TabIndex = 27
        '
        'PCIMobileCarrier
        '
        Me.PCIMobileCarrier.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "PCIMobileCarrier", True))
        Me.PCIMobileCarrier.DataSource = Me.MobileCarrierBindingSource
        Me.PCIMobileCarrier.DisplayMember = "Carrier"
        Me.PCIMobileCarrier.FormattingEnabled = True
        Me.PCIMobileCarrier.Location = New System.Drawing.Point(3, 260)
        Me.PCIMobileCarrier.Name = "PCIMobileCarrier"
        Me.PCIMobileCarrier.Size = New System.Drawing.Size(372, 25)
        Me.PCIMobileCarrier.TabIndex = 28
        Me.PCIMobileCarrier.ValueMember = "Carrier"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(401, 242)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 15)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Email-to-Text"
        '
        'PCIPostalCode
        '
        Me.PCIPostalCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "PCIPostalCode", True))
        Me.PCIPostalCode.Location = New System.Drawing.Point(799, 142)
        Me.PCIPostalCode.Name = "PCIPostalCode"
        Me.PCIPostalCode.Size = New System.Drawing.Size(372, 24)
        Me.PCIPostalCode.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(401, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 15)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Work Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(799, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 15)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Mobile Number"
        '
        'PCIHomeNumber
        '
        Me.PCIHomeNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IntakesBindingSource, "PCIHomeNumber", True))
        Me.PCIHomeNumber.Location = New System.Drawing.Point(3, 200)
        Me.PCIHomeNumber.Mask = "(999) 000-0000"
        Me.PCIHomeNumber.Name = "PCIHomeNumber"
        Me.PCIHomeNumber.Size = New System.Drawing.Size(372, 24)
        Me.PCIHomeNumber.TabIndex = 29
        '
        'TableLayoutPanel9
        '
        Me.TableLayoutPanel9.ColumnCount = 3
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.1295!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.8705!))
        Me.TableLayoutPanel9.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel9.Controls.Add(Me.Label70, 0, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label71, 1, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.Label72, 2, 0)
        Me.TableLayoutPanel9.Controls.Add(Me.monthBirth, 1, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.yearBirth, 0, 1)
        Me.TableLayoutPanel9.Controls.Add(Me.dayBirth, 2, 1)
        Me.TableLayoutPanel9.Location = New System.Drawing.Point(799, 260)
        Me.TableLayoutPanel9.Name = "TableLayoutPanel9"
        Me.TableLayoutPanel9.RowCount = 2
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.62963!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.37037!))
        Me.TableLayoutPanel9.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel9.Size = New System.Drawing.Size(374, 44)
        Me.TableLayoutPanel9.TabIndex = 32
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(3, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(33, 13)
        Me.Label70.TabIndex = 34
        Me.Label70.Text = "Year"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label71.Location = New System.Drawing.Point(103, 0)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(44, 13)
        Me.Label71.TabIndex = 35
        Me.Label71.Text = "Month"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.Label72.Location = New System.Drawing.Point(265, 0)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(30, 13)
        Me.Label72.TabIndex = 36
        Me.Label72.Text = "Day"
        '
        'monthBirth
        '
        Me.monthBirth.FormattingEnabled = True
        Me.monthBirth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.monthBirth.Location = New System.Drawing.Point(103, 16)
        Me.monthBirth.Name = "monthBirth"
        Me.monthBirth.Size = New System.Drawing.Size(156, 25)
        Me.monthBirth.TabIndex = 38
        '
        'yearBirth
        '
        Me.yearBirth.Location = New System.Drawing.Point(3, 16)
        Me.yearBirth.Mask = "0000"
        Me.yearBirth.Name = "yearBirth"
        Me.yearBirth.Size = New System.Drawing.Size(94, 24)
        Me.yearBirth.TabIndex = 40
        Me.yearBirth.ValidatingType = GetType(Integer)
        '
        'dayBirth
        '
        Me.dayBirth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.dayBirth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.dayBirth.FormattingEnabled = True
        Me.dayBirth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.dayBirth.Location = New System.Drawing.Point(265, 16)
        Me.dayBirth.MaxDropDownItems = 11
        Me.dayBirth.Name = "dayBirth"
        Me.dayBirth.Size = New System.Drawing.Size(90, 25)
        Me.dayBirth.TabIndex = 41
        '
        'ActionLogDBDataSet
        '
        Me.ActionLogDBDataSet.DataSetName = "ActionLogDBDataSet"
        Me.ActionLogDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MobileCarrierTableAdapter
        '
        Me.MobileCarrierTableAdapter.ClearBeforeFill = True
        '
        'MobileCarrierBindingSource
        '
        Me.MobileCarrierBindingSource.DataMember = "MobileCarrier"
        Me.MobileCarrierBindingSource.DataSource = Me.ActionLogDBDataSet
        '
        'ProvincesTableAdapter
        '
        Me.ProvincesTableAdapter.ClearBeforeFill = True
        '
        'ProvincesBindingSource
        '
        Me.ProvincesBindingSource.DataMember = "Provinces"
        Me.ProvincesBindingSource.DataSource = Me.ActionLogDBDataSet
        '
        'IntakesBindingSource
        '
        Me.IntakesBindingSource.DataMember = "Intakes"
        Me.IntakesBindingSource.DataSource = Me.ActionLogDBDataSet
        '
        'IntakesTableAdapter
        '
        Me.IntakesTableAdapter.ClearBeforeFill = True
        '
        'PotentialClientInfo
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PotentialClientInfoPanel)
        Me.Name = "PotentialClientInfo"
        Me.Size = New System.Drawing.Size(1350, 610)
        Me.PotentialClientInfoPanel.ResumeLayout(False)
        Me.PotentialClientInfoPanel.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel9.ResumeLayout(False)
        Me.TableLayoutPanel9.PerformLayout()
        CType(Me.ActionLogDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileCarrierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvincesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntakesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PotentialClientInfoPanel As Panel
    Friend WithEvents Label41 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Label16 As Label
    Friend WithEvents PCIOtherNotes As TextBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Label69 As Label
    Friend WithEvents PCIMobileNumber As MaskedTextBox
    Friend WithEvents PCIWorkNumber As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PCICity As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PCISalutation As ComboBox
    Friend WithEvents PCIFirstName As TextBox
    Friend WithEvents PCILastName As TextBox
    Friend WithEvents PCIAddress As TextBox
    Friend WithEvents PCISuiteApt As TextBox
    Friend WithEvents PCIEmail As TextBox
    Friend WithEvents PCIProvince As ComboBox
    Friend WithEvents PCIEmailToText As TextBox
    Friend WithEvents PCIMobileCarrier As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PCIPostalCode As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PCIHomeNumber As MaskedTextBox
    Friend WithEvents TableLayoutPanel9 As TableLayoutPanel
    Friend WithEvents Label70 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents monthBirth As ComboBox
    Friend WithEvents yearBirth As MaskedTextBox
    Friend WithEvents dayBirth As ComboBox
    Friend WithEvents ActionLogDBDataSet As ActionLogDBDataSet
    Friend WithEvents MobileCarrierTableAdapter As ActionLogDBDataSetTableAdapters.MobileCarrierTableAdapter
    Friend WithEvents MobileCarrierBindingSource As BindingSource
    Friend WithEvents ProvincesTableAdapter As ActionLogDBDataSetTableAdapters.ProvincesTableAdapter
    Friend WithEvents ProvincesBindingSource As BindingSource
    Friend WithEvents IntakesBindingSource As BindingSource
    Friend WithEvents IntakesTableAdapter As ActionLogDBDataSetTableAdapters.IntakesTableAdapter
End Class
