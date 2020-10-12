namespace RRFFilesManager.Intake
{
    partial class PotentialClientInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ActionLogDBDataSet = new RRFFilesManager.ActionLogDBDataSet();
            this.MobileCarrierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PCIWorkNumber = new System.Windows.Forms.MaskedTextBox();
            this.IntakesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label15 = new System.Windows.Forms.Label();
            this.Label70 = new System.Windows.Forms.Label();
            this.Label71 = new System.Windows.Forms.Label();
            this.Label69 = new System.Windows.Forms.Label();
            this.PCIMobileNumber = new System.Windows.Forms.MaskedTextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.IntakesTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.IntakesTableAdapter();
            this.Label72 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.PCICity = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.yearBirth = new System.Windows.Forms.MaskedTextBox();
            this.dayBirth = new System.Windows.Forms.ComboBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.PCISalutation = new System.Windows.Forms.ComboBox();
            this.MobileCarrierTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.MobileCarrierTableAdapter();
            this.monthBirth = new System.Windows.Forms.ComboBox();
            this.PCIFirstName = new System.Windows.Forms.TextBox();
            this.PotentialClientInfoPanel = new System.Windows.Forms.Panel();
            this.Label41 = new System.Windows.Forms.Label();
            this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Label16 = new System.Windows.Forms.Label();
            this.PCIOtherNotes = new System.Windows.Forms.TextBox();
            this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.PCILastName = new System.Windows.Forms.TextBox();
            this.PCIAddress = new System.Windows.Forms.TextBox();
            this.PCISuiteApt = new System.Windows.Forms.TextBox();
            this.PCIEmail = new System.Windows.Forms.TextBox();
            this.PCIProvince = new System.Windows.Forms.ComboBox();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PCIEmailToText = new System.Windows.Forms.TextBox();
            this.PCIMobileCarrier = new System.Windows.Forms.ComboBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.PCIPostalCode = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.PCIHomeNumber = new System.Windows.Forms.MaskedTextBox();
            this.TableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ActionLogDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileCarrierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntakesBindingSource)).BeginInit();
            this.PotentialClientInfoPanel.SuspendLayout();
            this.TableLayoutPanel4.SuspendLayout();
            this.TableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            this.TableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActionLogDBDataSet
            // 
            this.ActionLogDBDataSet.DataSetName = "ActionLogDBDataSet";
            this.ActionLogDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MobileCarrierBindingSource
            // 
            this.MobileCarrierBindingSource.DataMember = "MobileCarrier";
            this.MobileCarrierBindingSource.DataSource = this.ActionLogDBDataSet;
            // 
            // PCIWorkNumber
            // 
            this.PCIWorkNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "PCIWorkNumber", true));
            this.PCIWorkNumber.Location = new System.Drawing.Point(401, 200);
            this.PCIWorkNumber.Mask = "(999) 000-0000";
            this.PCIWorkNumber.Name = "PCIWorkNumber";
            this.PCIWorkNumber.Size = new System.Drawing.Size(372, 24);
            this.PCIWorkNumber.TabIndex = 30;
            // 
            // IntakesBindingSource
            // 
            this.IntakesBindingSource.DataMember = "Intakes";
            this.IntakesBindingSource.DataSource = this.ActionLogDBDataSet;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(3, 242);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(105, 15);
            this.Label15.TabIndex = 25;
            this.Label15.Text = "Mobile Carrier";
            // 
            // Label70
            // 
            this.Label70.AutoSize = true;
            this.Label70.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label70.Location = new System.Drawing.Point(3, 0);
            this.Label70.Name = "Label70";
            this.Label70.Size = new System.Drawing.Size(33, 13);
            this.Label70.TabIndex = 34;
            this.Label70.Text = "Year";
            // 
            // Label71
            // 
            this.Label71.AutoSize = true;
            this.Label71.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Label71.Location = new System.Drawing.Point(103, 0);
            this.Label71.Name = "Label71";
            this.Label71.Size = new System.Drawing.Size(44, 13);
            this.Label71.TabIndex = 35;
            this.Label71.Text = "Month";
            // 
            // Label69
            // 
            this.Label69.AutoSize = true;
            this.Label69.Location = new System.Drawing.Point(799, 242);
            this.Label69.Name = "Label69";
            this.Label69.Size = new System.Drawing.Size(93, 15);
            this.Label69.TabIndex = 33;
            this.Label69.Text = "Date of Birth";
            // 
            // PCIMobileNumber
            // 
            this.PCIMobileNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "PCIMobileNumber", true));
            this.PCIMobileNumber.Location = new System.Drawing.Point(799, 200);
            this.PCIMobileNumber.Mask = "(999) 000-0000";
            this.PCIMobileNumber.Name = "PCIMobileNumber";
            this.PCIMobileNumber.Size = new System.Drawing.Size(374, 24);
            this.PCIMobileNumber.TabIndex = 31;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(3, 121);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(68, 18);
            this.Label8.TabIndex = 12;
            this.Label8.Text = "Province";
            // 
            // IntakesTableAdapter
            // 
            this.IntakesTableAdapter.ClearBeforeFill = true;
            // 
            // Label72
            // 
            this.Label72.AutoSize = true;
            this.Label72.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.Label72.Location = new System.Drawing.Point(265, 0);
            this.Label72.Name = "Label72";
            this.Label72.Size = new System.Drawing.Size(30, 13);
            this.Label72.TabIndex = 36;
            this.Label72.Text = "Day";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(799, 121);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(92, 18);
            this.Label10.TabIndex = 14;
            this.Label10.Text = "Postal Code";
            // 
            // PCICity
            // 
            this.PCICity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "PCICity", true));
            this.PCICity.Location = new System.Drawing.Point(401, 142);
            this.PCICity.Name = "PCICity";
            this.PCICity.Size = new System.Drawing.Size(372, 24);
            this.PCICity.TabIndex = 17;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(401, 121);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(36, 18);
            this.Label9.TabIndex = 13;
            this.Label9.Text = "City";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(3, 182);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(109, 15);
            this.Label12.TabIndex = 19;
            this.Label12.Text = "Home Number";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(3, 62);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(61, 18);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "Address";
            // 
            // yearBirth
            // 
            this.yearBirth.Location = new System.Drawing.Point(3, 16);
            this.yearBirth.Mask = "0000";
            this.yearBirth.Name = "yearBirth";
            this.yearBirth.Size = new System.Drawing.Size(94, 24);
            this.yearBirth.TabIndex = 40;
            this.yearBirth.ValidatingType = typeof(int);
            // 
            // dayBirth
            // 
            this.dayBirth.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dayBirth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dayBirth.FormattingEnabled = true;
            this.dayBirth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.dayBirth.Location = new System.Drawing.Point(265, 16);
            this.dayBirth.MaxDropDownItems = 11;
            this.dayBirth.Name = "dayBirth";
            this.dayBirth.Size = new System.Drawing.Size(90, 25);
            this.dayBirth.TabIndex = 41;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(401, 62);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(76, 18);
            this.Label6.TabIndex = 7;
            this.Label6.Text = "Suite/Apt.";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(799, 62);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(46, 18);
            this.Label7.TabIndex = 8;
            this.Label7.Text = "Email";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(3, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 16);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Salutations";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(401, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(79, 16);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "First Name";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(799, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(81, 16);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Last Name";
            // 
            // PCISalutation
            // 
            this.PCISalutation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "PCISalutation", true));
            this.PCISalutation.FormattingEnabled = true;
            this.PCISalutation.Items.AddRange(new object[] {
            "Miss",
            "Ms.",
            "Mr."});
            this.PCISalutation.Location = new System.Drawing.Point(3, 19);
            this.PCISalutation.Name = "PCISalutation";
            this.PCISalutation.Size = new System.Drawing.Size(121, 25);
            this.PCISalutation.TabIndex = 3;
            this.PCISalutation.SelectedIndexChanged += new System.EventHandler(this.PCISalutation_SelectedIndexChanged);
            // 
            // MobileCarrierTableAdapter
            // 
            this.MobileCarrierTableAdapter.ClearBeforeFill = true;
            // 
            // monthBirth
            // 
            this.monthBirth.FormattingEnabled = true;
            this.monthBirth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthBirth.Location = new System.Drawing.Point(103, 16);
            this.monthBirth.Name = "monthBirth";
            this.monthBirth.Size = new System.Drawing.Size(156, 25);
            this.monthBirth.TabIndex = 38;
            // 
            // PCIFirstName
            // 
            this.PCIFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "PCIFirstName", true));
            this.PCIFirstName.Location = new System.Drawing.Point(401, 19);
            this.PCIFirstName.Name = "PCIFirstName";
            this.PCIFirstName.Size = new System.Drawing.Size(372, 24);
            this.PCIFirstName.TabIndex = 4;
            // 
            // PotentialClientInfoPanel
            // 
            this.PotentialClientInfoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PotentialClientInfoPanel.BackColor = System.Drawing.Color.White;
            this.PotentialClientInfoPanel.Controls.Add(this.Label41);
            this.PotentialClientInfoPanel.Controls.Add(this.TableLayoutPanel4);
            this.PotentialClientInfoPanel.Controls.Add(this.TableLayoutPanel3);
            this.PotentialClientInfoPanel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotentialClientInfoPanel.Location = new System.Drawing.Point(50, 28);
            this.PotentialClientInfoPanel.Name = "PotentialClientInfoPanel";
            this.PotentialClientInfoPanel.Size = new System.Drawing.Size(1250, 554);
            this.PotentialClientInfoPanel.TabIndex = 144;
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label41.Location = new System.Drawing.Point(20, 0);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(216, 26);
            this.Label41.TabIndex = 2;
            this.Label41.Text = "Potential Client Info";
            // 
            // TableLayoutPanel4
            // 
            this.TableLayoutPanel4.ColumnCount = 1;
            this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel4.Controls.Add(this.Label16, 0, 0);
            this.TableLayoutPanel4.Controls.Add(this.PCIOtherNotes, 0, 1);
            this.TableLayoutPanel4.Location = new System.Drawing.Point(25, 379);
            this.TableLayoutPanel4.Name = "TableLayoutPanel4";
            this.TableLayoutPanel4.RowCount = 2;
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.TableLayoutPanel4.Size = new System.Drawing.Size(1196, 156);
            this.TableLayoutPanel4.TabIndex = 1;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(3, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(90, 19);
            this.Label16.TabIndex = 20;
            this.Label16.Text = "Other Notes";
            // 
            // PCIOtherNotes
            // 
            this.PCIOtherNotes.BackColor = System.Drawing.Color.White;
            this.PCIOtherNotes.Location = new System.Drawing.Point(3, 27);
            this.PCIOtherNotes.Multiline = true;
            this.PCIOtherNotes.Name = "PCIOtherNotes";
            this.PCIOtherNotes.Size = new System.Drawing.Size(1172, 126);
            this.PCIOtherNotes.TabIndex = 21;
            // 
            // TableLayoutPanel3
            // 
            this.TableLayoutPanel3.ColumnCount = 3;
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TableLayoutPanel3.Controls.Add(this.Label69, 2, 8);
            this.TableLayoutPanel3.Controls.Add(this.PCIMobileNumber, 2, 7);
            this.TableLayoutPanel3.Controls.Add(this.PCIWorkNumber, 1, 7);
            this.TableLayoutPanel3.Controls.Add(this.Label15, 0, 8);
            this.TableLayoutPanel3.Controls.Add(this.Label8, 0, 4);
            this.TableLayoutPanel3.Controls.Add(this.Label10, 2, 4);
            this.TableLayoutPanel3.Controls.Add(this.PCICity, 1, 5);
            this.TableLayoutPanel3.Controls.Add(this.Label9, 0, 4);
            this.TableLayoutPanel3.Controls.Add(this.Label12, 0, 6);
            this.TableLayoutPanel3.Controls.Add(this.Label5, 0, 2);
            this.TableLayoutPanel3.Controls.Add(this.Label6, 0, 2);
            this.TableLayoutPanel3.Controls.Add(this.Label7, 0, 2);
            this.TableLayoutPanel3.Controls.Add(this.Label2, 0, 0);
            this.TableLayoutPanel3.Controls.Add(this.Label3, 1, 0);
            this.TableLayoutPanel3.Controls.Add(this.Label4, 2, 0);
            this.TableLayoutPanel3.Controls.Add(this.PCISalutation, 0, 1);
            this.TableLayoutPanel3.Controls.Add(this.PCIFirstName, 1, 1);
            this.TableLayoutPanel3.Controls.Add(this.PCILastName, 2, 1);
            this.TableLayoutPanel3.Controls.Add(this.PCIAddress, 0, 3);
            this.TableLayoutPanel3.Controls.Add(this.PCISuiteApt, 1, 3);
            this.TableLayoutPanel3.Controls.Add(this.PCIEmail, 2, 3);
            this.TableLayoutPanel3.Controls.Add(this.PCIProvince, 0, 5);
            this.TableLayoutPanel3.Controls.Add(this.PCIEmailToText, 1, 9);
            this.TableLayoutPanel3.Controls.Add(this.PCIMobileCarrier, 0, 9);
            this.TableLayoutPanel3.Controls.Add(this.Label14, 1, 8);
            this.TableLayoutPanel3.Controls.Add(this.PCIPostalCode, 2, 5);
            this.TableLayoutPanel3.Controls.Add(this.Label13, 1, 6);
            this.TableLayoutPanel3.Controls.Add(this.Label11, 2, 6);
            this.TableLayoutPanel3.Controls.Add(this.PCIHomeNumber, 0, 7);
            this.TableLayoutPanel3.Controls.Add(this.TableLayoutPanel9, 2, 9);
            this.TableLayoutPanel3.Location = new System.Drawing.Point(25, 46);
            this.TableLayoutPanel3.Name = "TableLayoutPanel3";
            this.TableLayoutPanel3.RowCount = 10;
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel3.Size = new System.Drawing.Size(1196, 307);
            this.TableLayoutPanel3.TabIndex = 0;
            // 
            // PCILastName
            // 
            this.PCILastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "PCILastName", true));
            this.PCILastName.Location = new System.Drawing.Point(799, 19);
            this.PCILastName.Name = "PCILastName";
            this.PCILastName.Size = new System.Drawing.Size(374, 24);
            this.PCILastName.TabIndex = 5;
            // 
            // PCIAddress
            // 
            this.PCIAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "PCIAddress", true));
            this.PCIAddress.Location = new System.Drawing.Point(3, 83);
            this.PCIAddress.Name = "PCIAddress";
            this.PCIAddress.Size = new System.Drawing.Size(372, 24);
            this.PCIAddress.TabIndex = 9;
            // 
            // PCISuiteApt
            // 
            this.PCISuiteApt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "PCISuiteApt", true));
            this.PCISuiteApt.Location = new System.Drawing.Point(401, 83);
            this.PCISuiteApt.Name = "PCISuiteApt";
            this.PCISuiteApt.Size = new System.Drawing.Size(372, 24);
            this.PCISuiteApt.TabIndex = 10;
            // 
            // PCIEmail
            // 
            this.PCIEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "PCIEmail", true));
            this.PCIEmail.Location = new System.Drawing.Point(799, 83);
            this.PCIEmail.Name = "PCIEmail";
            this.PCIEmail.Size = new System.Drawing.Size(372, 24);
            this.PCIEmail.TabIndex = 11;
            // 
            // PCIProvince
            // 
            this.PCIProvince.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "PCIProvince", true));
            this.PCIProvince.DataSource = this.provincesBindingSource;
            this.PCIProvince.DisplayMember = "Description";
            this.PCIProvince.FormattingEnabled = true;
            this.PCIProvince.Location = new System.Drawing.Point(3, 142);
            this.PCIProvince.Name = "PCIProvince";
            this.PCIProvince.Size = new System.Drawing.Size(372, 25);
            this.PCIProvince.TabIndex = 15;
            this.PCIProvince.ValueMember = "Province";
            this.PCIProvince.SelectedIndexChanged += new System.EventHandler(this.PCIProvince_SelectedIndexChanged);
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataMember = "Provinces";
            this.provincesBindingSource.DataSource = this.ActionLogDBDataSet;
            // 
            // PCIEmailToText
            // 
            this.PCIEmailToText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "PCIEmailToText", true));
            this.PCIEmailToText.Location = new System.Drawing.Point(401, 260);
            this.PCIEmailToText.Name = "PCIEmailToText";
            this.PCIEmailToText.Size = new System.Drawing.Size(372, 24);
            this.PCIEmailToText.TabIndex = 27;
            // 
            // PCIMobileCarrier
            // 
            this.PCIMobileCarrier.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "PCIMobileCarrier", true));
            this.PCIMobileCarrier.DataSource = this.MobileCarrierBindingSource;
            this.PCIMobileCarrier.DisplayMember = "Carrier";
            this.PCIMobileCarrier.FormattingEnabled = true;
            this.PCIMobileCarrier.Location = new System.Drawing.Point(3, 260);
            this.PCIMobileCarrier.Name = "PCIMobileCarrier";
            this.PCIMobileCarrier.Size = new System.Drawing.Size(372, 25);
            this.PCIMobileCarrier.TabIndex = 28;
            this.PCIMobileCarrier.ValueMember = "Carrier";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(401, 242);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(96, 15);
            this.Label14.TabIndex = 24;
            this.Label14.Text = "Email-to-Text";
            // 
            // PCIPostalCode
            // 
            this.PCIPostalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "PCIPostalCode", true));
            this.PCIPostalCode.Location = new System.Drawing.Point(799, 142);
            this.PCIPostalCode.Name = "PCIPostalCode";
            this.PCIPostalCode.Size = new System.Drawing.Size(372, 24);
            this.PCIPostalCode.TabIndex = 16;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(401, 182);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(103, 15);
            this.Label13.TabIndex = 20;
            this.Label13.Text = "Work Number";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(799, 182);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(115, 15);
            this.Label11.TabIndex = 18;
            this.Label11.Text = "Mobile Number";
            // 
            // PCIHomeNumber
            // 
            this.PCIHomeNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "PCIHomeNumber", true));
            this.PCIHomeNumber.Location = new System.Drawing.Point(3, 200);
            this.PCIHomeNumber.Mask = "(999) 000-0000";
            this.PCIHomeNumber.Name = "PCIHomeNumber";
            this.PCIHomeNumber.Size = new System.Drawing.Size(372, 24);
            this.PCIHomeNumber.TabIndex = 29;
            // 
            // TableLayoutPanel9
            // 
            this.TableLayoutPanel9.ColumnCount = 3;
            this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.1295F));
            this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.8705F));
            this.TableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.TableLayoutPanel9.Controls.Add(this.Label70, 0, 0);
            this.TableLayoutPanel9.Controls.Add(this.Label71, 1, 0);
            this.TableLayoutPanel9.Controls.Add(this.Label72, 2, 0);
            this.TableLayoutPanel9.Controls.Add(this.monthBirth, 1, 1);
            this.TableLayoutPanel9.Controls.Add(this.yearBirth, 0, 1);
            this.TableLayoutPanel9.Controls.Add(this.dayBirth, 2, 1);
            this.TableLayoutPanel9.Location = new System.Drawing.Point(799, 260);
            this.TableLayoutPanel9.Name = "TableLayoutPanel9";
            this.TableLayoutPanel9.RowCount = 2;
            this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.62963F));
            this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.37037F));
            this.TableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel9.Size = new System.Drawing.Size(374, 44);
            this.TableLayoutPanel9.TabIndex = 32;
            // 
            // PotentialClientInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PotentialClientInfoPanel);
            this.Name = "PotentialClientInfo";
            this.Size = new System.Drawing.Size(1350, 610);
            this.Load += new System.EventHandler(this.PotentialClientInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActionLogDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileCarrierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntakesBindingSource)).EndInit();
            this.PotentialClientInfoPanel.ResumeLayout(false);
            this.PotentialClientInfoPanel.PerformLayout();
            this.TableLayoutPanel4.ResumeLayout(false);
            this.TableLayoutPanel4.PerformLayout();
            this.TableLayoutPanel3.ResumeLayout(false);
            this.TableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            this.TableLayoutPanel9.ResumeLayout(false);
            this.TableLayoutPanel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal ActionLogDBDataSet ActionLogDBDataSet;
        internal System.Windows.Forms.BindingSource MobileCarrierBindingSource;
        internal System.Windows.Forms.MaskedTextBox PCIWorkNumber;
        internal System.Windows.Forms.BindingSource IntakesBindingSource;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label70;
        internal System.Windows.Forms.Label Label71;
        internal System.Windows.Forms.Label Label69;
        internal System.Windows.Forms.MaskedTextBox PCIMobileNumber;
        internal System.Windows.Forms.Label Label8;
        internal ActionLogDBDataSetTableAdapters.IntakesTableAdapter IntakesTableAdapter;
        internal System.Windows.Forms.Label Label72;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox PCICity;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.MaskedTextBox yearBirth;
        internal System.Windows.Forms.ComboBox dayBirth;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ComboBox PCISalutation;
        internal ActionLogDBDataSetTableAdapters.MobileCarrierTableAdapter MobileCarrierTableAdapter;
        internal System.Windows.Forms.ComboBox monthBirth;
        internal System.Windows.Forms.TextBox PCIFirstName;
        internal System.Windows.Forms.Panel PotentialClientInfoPanel;
        internal System.Windows.Forms.Label Label41;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel4;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox PCIOtherNotes;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel3;
        internal System.Windows.Forms.TextBox PCILastName;
        internal System.Windows.Forms.TextBox PCIAddress;
        internal System.Windows.Forms.TextBox PCISuiteApt;
        internal System.Windows.Forms.TextBox PCIEmail;
        internal System.Windows.Forms.ComboBox PCIProvince;
        internal System.Windows.Forms.TextBox PCIEmailToText;
        internal System.Windows.Forms.ComboBox PCIMobileCarrier;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.TextBox PCIPostalCode;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.MaskedTextBox PCIHomeNumber;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel9;
        private System.Windows.Forms.BindingSource provincesBindingSource;
    }
}
