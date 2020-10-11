namespace RRFFilesManager.Intake
{
    partial class PreliminaryInfo
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
            System.Windows.Forms.Label FileNumberLabel;
            System.Windows.Forms.Label StaffInterviewerLabel;
            System.Windows.Forms.Label MatterSubTypeLabel;
            System.Windows.Forms.Label LimitationPeriodLabel;
            System.Windows.Forms.Label ResponsibleLawyerLabel;
            System.Windows.Forms.Label HowHearLabel;
            System.Windows.Forms.Label FileLawyerLabel;
            System.Windows.Forms.Label DateOfLossLabel;
            System.Windows.Forms.Label DateOFCallLabel;
            System.Windows.Forms.Label AdditionalNotesLabel;
            this.AdditionalNotesTextBox = new System.Windows.Forms.TextBox();
            this.IntakesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ActionLogDBDataSet = new RRFFilesManager.ActionLogDBDataSet();
            this.LawyerComboBox = new System.Windows.Forms.ComboBox();
            this.FileLawyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StaffInterviewerTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.StaffInterviewerTableAdapter();
            this.StaffInterviewerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ResponsibleLawyerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HearAboutUsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MatterSubTypeComboBox = new System.Windows.Forms.ComboBox();
            this.FileNumberTextBox = new System.Windows.Forms.TextBox();
            this.StaffInterviewerComboBox = new System.Windows.Forms.ComboBox();
            this.ResponsibleLawyerComboBox = new System.Windows.Forms.ComboBox();
            this.LimitationPeriodTextBox = new System.Windows.Forms.TextBox();
            this.HowHearComboBox = new System.Windows.Forms.ComboBox();
            this.DateOfLossDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Label1 = new System.Windows.Forms.Label();
            this.StatutoryNoticeBox = new System.Windows.Forms.TextBox();
            this.DateOFCallDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Label42 = new System.Windows.Forms.Label();
            this.MatterTypeTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.MatterTypeTableAdapter();
            this.MatterSubTypesTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.MatterSubTypesTableAdapter();
            this.IntakesTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.IntakesTableAdapter();
            this.ResponsibleLawyerTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.ResponsibleLawyerTableAdapter();
            this.HearAboutUsTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.HearAboutUsTableAdapter();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.FileLawyerTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.FileLawyerTableAdapter();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PreliminayPanel = new System.Windows.Forms.Panel();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.MatterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.MatterTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            FileNumberLabel = new System.Windows.Forms.Label();
            StaffInterviewerLabel = new System.Windows.Forms.Label();
            MatterSubTypeLabel = new System.Windows.Forms.Label();
            LimitationPeriodLabel = new System.Windows.Forms.Label();
            ResponsibleLawyerLabel = new System.Windows.Forms.Label();
            HowHearLabel = new System.Windows.Forms.Label();
            FileLawyerLabel = new System.Windows.Forms.Label();
            DateOfLossLabel = new System.Windows.Forms.Label();
            DateOFCallLabel = new System.Windows.Forms.Label();
            AdditionalNotesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IntakesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionLogDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileLawyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffInterviewerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResponsibleLawyerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HearAboutUsBindingSource)).BeginInit();
            this.TableLayoutPanel1.SuspendLayout();
            this.TableLayoutPanel2.SuspendLayout();
            this.PreliminayPanel.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatterTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AdditionalNotesTextBox
            // 
            this.AdditionalNotesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdditionalNotesTextBox.BackColor = System.Drawing.Color.White;
            this.AdditionalNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "AdditionalNotes", true));
            this.AdditionalNotesTextBox.Location = new System.Drawing.Point(129, 3);
            this.AdditionalNotesTextBox.Multiline = true;
            this.AdditionalNotesTextBox.Name = "AdditionalNotesTextBox";
            this.AdditionalNotesTextBox.Size = new System.Drawing.Size(1100, 177);
            this.AdditionalNotesTextBox.TabIndex = 23;
            // 
            // IntakesBindingSource
            // 
            this.IntakesBindingSource.DataMember = "Intakes";
            this.IntakesBindingSource.DataSource = this.ActionLogDBDataSet;
            // 
            // ActionLogDBDataSet
            // 
            this.ActionLogDBDataSet.DataSetName = "ActionLogDBDataSet";
            this.ActionLogDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LawyerComboBox
            // 
            this.LawyerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "FileLawyer", true));
            this.LawyerComboBox.DataSource = this.FileLawyerBindingSource;
            this.LawyerComboBox.DisplayMember = "Lawyer";
            this.LawyerComboBox.FormattingEnabled = true;
            this.LawyerComboBox.Location = new System.Drawing.Point(711, 49);
            this.LawyerComboBox.Name = "LawyerComboBox";
            this.LawyerComboBox.Size = new System.Drawing.Size(489, 25);
            this.LawyerComboBox.TabIndex = 26;
            this.LawyerComboBox.ValueMember = "Lawyer";
            // 
            // FileLawyerBindingSource
            // 
            this.FileLawyerBindingSource.DataMember = "FileLawyer";
            this.FileLawyerBindingSource.DataSource = this.ActionLogDBDataSet;
            // 
            // StaffInterviewerTableAdapter
            // 
            this.StaffInterviewerTableAdapter.ClearBeforeFill = true;
            // 
            // StaffInterviewerBindingSource
            // 
            this.StaffInterviewerBindingSource.DataMember = "StaffInterviewer";
            this.StaffInterviewerBindingSource.DataSource = this.ActionLogDBDataSet;
            // 
            // ResponsibleLawyerBindingSource
            // 
            this.ResponsibleLawyerBindingSource.DataMember = "ResponsibleLawyer";
            this.ResponsibleLawyerBindingSource.DataSource = this.ActionLogDBDataSet;
            // 
            // HearAboutUsBindingSource
            // 
            this.HearAboutUsBindingSource.DataMember = "HearAboutUs";
            this.HearAboutUsBindingSource.DataSource = this.ActionLogDBDataSet;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 4;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10952F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.23673F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.27801F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.37574F));
            this.TableLayoutPanel1.Controls.Add(this.LawyerComboBox, 3, 1);
            this.TableLayoutPanel1.Controls.Add(FileNumberLabel, 0, 4);
            this.TableLayoutPanel1.Controls.Add(this.MatterSubTypeComboBox, 3, 3);
            this.TableLayoutPanel1.Controls.Add(this.FileNumberTextBox, 1, 4);
            this.TableLayoutPanel1.Controls.Add(this.StaffInterviewerComboBox, 3, 0);
            this.TableLayoutPanel1.Controls.Add(StaffInterviewerLabel, 2, 0);
            this.TableLayoutPanel1.Controls.Add(MatterSubTypeLabel, 2, 3);
            this.TableLayoutPanel1.Controls.Add(this.ResponsibleLawyerComboBox, 1, 2);
            this.TableLayoutPanel1.Controls.Add(this.LimitationPeriodTextBox, 1, 3);
            this.TableLayoutPanel1.Controls.Add(LimitationPeriodLabel, 0, 3);
            this.TableLayoutPanel1.Controls.Add(ResponsibleLawyerLabel, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.HowHearComboBox, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.DateOfLossDateTimePicker, 3, 2);
            this.TableLayoutPanel1.Controls.Add(HowHearLabel, 0, 1);
            this.TableLayoutPanel1.Controls.Add(FileLawyerLabel, 2, 1);
            this.TableLayoutPanel1.Controls.Add(DateOfLossLabel, 2, 2);
            this.TableLayoutPanel1.Controls.Add(this.Label1, 2, 4);
            this.TableLayoutPanel1.Controls.Add(this.StatutoryNoticeBox, 3, 4);
            this.TableLayoutPanel1.Controls.Add(DateOFCallLabel, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.DateOFCallDateTimePicker, 1, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(25, 83);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 5;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1232, 233);
            this.TableLayoutPanel1.TabIndex = 25;
            // 
            // FileNumberLabel
            // 
            FileNumberLabel.AutoSize = true;
            FileNumberLabel.Location = new System.Drawing.Point(3, 184);
            FileNumberLabel.Name = "FileNumberLabel";
            FileNumberLabel.Size = new System.Drawing.Size(88, 17);
            FileNumberLabel.TabIndex = 2;
            FileNumberLabel.Text = "File Number:";
            // 
            // MatterSubTypeComboBox
            // 
            this.MatterSubTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "MatterSubType", true));
            this.MatterSubTypeComboBox.FormattingEnabled = true;
            this.MatterSubTypeComboBox.Location = new System.Drawing.Point(711, 141);
            this.MatterSubTypeComboBox.Name = "MatterSubTypeComboBox";
            this.MatterSubTypeComboBox.Size = new System.Drawing.Size(489, 25);
            this.MatterSubTypeComboBox.TabIndex = 24;
            // 
            // FileNumberTextBox
            // 
            this.FileNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "FileNumber", true));
            this.FileNumberTextBox.Enabled = false;
            this.FileNumberTextBox.Location = new System.Drawing.Point(127, 187);
            this.FileNumberTextBox.Name = "FileNumberTextBox";
            this.FileNumberTextBox.Size = new System.Drawing.Size(435, 23);
            this.FileNumberTextBox.TabIndex = 3;
            // 
            // StaffInterviewerComboBox
            // 
            this.StaffInterviewerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "StaffInterviewer", true));
            this.StaffInterviewerComboBox.DataSource = this.StaffInterviewerBindingSource;
            this.StaffInterviewerComboBox.DisplayMember = "Lawyer";
            this.StaffInterviewerComboBox.FormattingEnabled = true;
            this.StaffInterviewerComboBox.Location = new System.Drawing.Point(711, 3);
            this.StaffInterviewerComboBox.Name = "StaffInterviewerComboBox";
            this.StaffInterviewerComboBox.Size = new System.Drawing.Size(489, 25);
            this.StaffInterviewerComboBox.TabIndex = 11;
            this.StaffInterviewerComboBox.ValueMember = "Lawyer";
            // 
            // StaffInterviewerLabel
            // 
            StaffInterviewerLabel.AutoSize = true;
            StaffInterviewerLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            StaffInterviewerLabel.ForeColor = System.Drawing.Color.Black;
            StaffInterviewerLabel.Location = new System.Drawing.Point(585, 0);
            StaffInterviewerLabel.Name = "StaffInterviewerLabel";
            StaffInterviewerLabel.Size = new System.Drawing.Size(115, 17);
            StaffInterviewerLabel.TabIndex = 10;
            StaffInterviewerLabel.Text = "Staff Interviewer:";
            // 
            // MatterSubTypeLabel
            // 
            MatterSubTypeLabel.AutoSize = true;
            MatterSubTypeLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            MatterSubTypeLabel.ForeColor = System.Drawing.Color.Black;
            MatterSubTypeLabel.Location = new System.Drawing.Point(585, 138);
            MatterSubTypeLabel.Name = "MatterSubTypeLabel";
            MatterSubTypeLabel.Size = new System.Drawing.Size(113, 17);
            MatterSubTypeLabel.TabIndex = 18;
            MatterSubTypeLabel.Text = "Matter Sub Type:";
            // 
            // ResponsibleLawyerComboBox
            // 
            this.ResponsibleLawyerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "ResponsibleLAwyer", true));
            this.ResponsibleLawyerComboBox.DataSource = this.ResponsibleLawyerBindingSource;
            this.ResponsibleLawyerComboBox.DisplayMember = "Lawyer";
            this.ResponsibleLawyerComboBox.FormattingEnabled = true;
            this.ResponsibleLawyerComboBox.Location = new System.Drawing.Point(127, 95);
            this.ResponsibleLawyerComboBox.Name = "ResponsibleLawyerComboBox";
            this.ResponsibleLawyerComboBox.Size = new System.Drawing.Size(435, 25);
            this.ResponsibleLawyerComboBox.TabIndex = 17;
            this.ResponsibleLawyerComboBox.ValueMember = "Lawyer";
            // 
            // LimitationPeriodTextBox
            // 
            this.LimitationPeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "LimitationPeriod", true));
            this.LimitationPeriodTextBox.Location = new System.Drawing.Point(127, 141);
            this.LimitationPeriodTextBox.Name = "LimitationPeriodTextBox";
            this.LimitationPeriodTextBox.Size = new System.Drawing.Size(435, 23);
            this.LimitationPeriodTextBox.TabIndex = 21;
            // 
            // LimitationPeriodLabel
            // 
            LimitationPeriodLabel.AutoSize = true;
            LimitationPeriodLabel.Location = new System.Drawing.Point(3, 138);
            LimitationPeriodLabel.Name = "LimitationPeriodLabel";
            LimitationPeriodLabel.Size = new System.Drawing.Size(76, 34);
            LimitationPeriodLabel.TabIndex = 20;
            LimitationPeriodLabel.Text = "Limitation Period:";
            // 
            // ResponsibleLawyerLabel
            // 
            ResponsibleLawyerLabel.AutoSize = true;
            ResponsibleLawyerLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ResponsibleLawyerLabel.ForeColor = System.Drawing.Color.Black;
            ResponsibleLawyerLabel.Location = new System.Drawing.Point(3, 92);
            ResponsibleLawyerLabel.Name = "ResponsibleLawyerLabel";
            ResponsibleLawyerLabel.Size = new System.Drawing.Size(87, 34);
            ResponsibleLawyerLabel.TabIndex = 16;
            ResponsibleLawyerLabel.Text = "Responsible Lawyer:";
            // 
            // HowHearComboBox
            // 
            this.HowHearComboBox.DataSource = this.HearAboutUsBindingSource;
            this.HowHearComboBox.DisplayMember = "Option";
            this.HowHearComboBox.FormattingEnabled = true;
            this.HowHearComboBox.Location = new System.Drawing.Point(127, 49);
            this.HowHearComboBox.Name = "HowHearComboBox";
            this.HowHearComboBox.Size = new System.Drawing.Size(435, 25);
            this.HowHearComboBox.TabIndex = 13;
            this.HowHearComboBox.ValueMember = "Option";
            // 
            // DateOfLossDateTimePicker
            // 
            this.DateOfLossDateTimePicker.CustomFormat = " ";
            this.DateOfLossDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "DateOFLoss", true));
            this.DateOfLossDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.IntakesBindingSource, "DateOFLoss", true));
            this.DateOfLossDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfLossDateTimePicker.Location = new System.Drawing.Point(711, 95);
            this.DateOfLossDateTimePicker.Name = "DateOfLossDateTimePicker";
            this.DateOfLossDateTimePicker.Size = new System.Drawing.Size(489, 23);
            this.DateOfLossDateTimePicker.TabIndex = 9;
            this.DateOfLossDateTimePicker.ValueChanged += new System.EventHandler(this.DateOfLossDateTimePicker_ValueChanged);
            // 
            // HowHearLabel
            // 
            HowHearLabel.AutoSize = true;
            HowHearLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            HowHearLabel.ForeColor = System.Drawing.Color.Black;
            HowHearLabel.Location = new System.Drawing.Point(3, 46);
            HowHearLabel.Name = "HowHearLabel";
            HowHearLabel.Size = new System.Drawing.Size(106, 34);
            HowHearLabel.TabIndex = 12;
            HowHearLabel.Text = "How did you hear about us?";
            // 
            // FileLawyerLabel
            // 
            FileLawyerLabel.AutoSize = true;
            FileLawyerLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            FileLawyerLabel.ForeColor = System.Drawing.Color.Black;
            FileLawyerLabel.Location = new System.Drawing.Point(585, 46);
            FileLawyerLabel.Name = "FileLawyerLabel";
            FileLawyerLabel.Size = new System.Drawing.Size(81, 17);
            FileLawyerLabel.TabIndex = 14;
            FileLawyerLabel.Text = "File Lawyer:";
            // 
            // DateOfLossLabel
            // 
            DateOfLossLabel.AutoSize = true;
            DateOfLossLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateOfLossLabel.ForeColor = System.Drawing.Color.Black;
            DateOfLossLabel.Location = new System.Drawing.Point(585, 92);
            DateOfLossLabel.Name = "DateOfLossLabel";
            DateOfLossLabel.Size = new System.Drawing.Size(92, 17);
            DateOfLossLabel.TabIndex = 8;
            DateOfLossLabel.Text = "Date Of Loss:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(585, 184);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 17);
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Statutory Notice";
            // 
            // StatutoryNoticeBox
            // 
            this.StatutoryNoticeBox.Location = new System.Drawing.Point(711, 187);
            this.StatutoryNoticeBox.Name = "StatutoryNoticeBox";
            this.StatutoryNoticeBox.Size = new System.Drawing.Size(489, 23);
            this.StatutoryNoticeBox.TabIndex = 28;
            // 
            // DateOFCallLabel
            // 
            DateOFCallLabel.AutoSize = true;
            DateOFCallLabel.Location = new System.Drawing.Point(3, 0);
            DateOFCallLabel.Name = "DateOFCallLabel";
            DateOFCallLabel.Size = new System.Drawing.Size(91, 17);
            DateOFCallLabel.TabIndex = 6;
            DateOFCallLabel.Text = "Date of Call:";
            // 
            // DateOFCallDateTimePicker
            // 
            this.DateOFCallDateTimePicker.CustomFormat = "MMM-dd-yyyy";
            this.DateOFCallDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "DateOFCall", true));
            this.DateOFCallDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.IntakesBindingSource, "DateOFCall", true));
            this.DateOFCallDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOFCallDateTimePicker.Location = new System.Drawing.Point(127, 3);
            this.DateOFCallDateTimePicker.Name = "DateOFCallDateTimePicker";
            this.DateOFCallDateTimePicker.Size = new System.Drawing.Size(435, 23);
            this.DateOFCallDateTimePicker.TabIndex = 7;
            // 
            // Label42
            // 
            this.Label42.AutoSize = true;
            this.Label42.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label42.Location = new System.Drawing.Point(20, 0);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(174, 26);
            this.Label42.TabIndex = 143;
            this.Label42.Text = "Preliminary Info";
            // 
            // MatterTypeTableAdapter
            // 
            this.MatterTypeTableAdapter.ClearBeforeFill = true;
            // 
            // MatterSubTypesTableAdapter
            // 
            this.MatterSubTypesTableAdapter.ClearBeforeFill = true;
            // 
            // IntakesTableAdapter
            // 
            this.IntakesTableAdapter.ClearBeforeFill = true;
            // 
            // ResponsibleLawyerTableAdapter
            // 
            this.ResponsibleLawyerTableAdapter.ClearBeforeFill = true;
            // 
            // HearAboutUsTableAdapter
            // 
            this.HearAboutUsTableAdapter.ClearBeforeFill = true;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(34, 463);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(183, 23);
            this.TextBox1.TabIndex = 141;
            // 
            // FileLawyerTableAdapter
            // 
            this.FileLawyerTableAdapter.ClearBeforeFill = true;
            // 
            // AdditionalNotesLabel
            // 
            AdditionalNotesLabel.AutoSize = true;
            AdditionalNotesLabel.Location = new System.Drawing.Point(3, 0);
            AdditionalNotesLabel.Name = "AdditionalNotesLabel";
            AdditionalNotesLabel.Size = new System.Drawing.Size(120, 17);
            AdditionalNotesLabel.TabIndex = 22;
            AdditionalNotesLabel.Text = "Additional Notes:";
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel2.ColumnCount = 2;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30043F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.69957F));
            this.TableLayoutPanel2.Controls.Add(AdditionalNotesLabel, 0, 0);
            this.TableLayoutPanel2.Controls.Add(this.AdditionalNotesTextBox, 1, 0);
            this.TableLayoutPanel2.Location = new System.Drawing.Point(25, 329);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 1;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(1232, 183);
            this.TableLayoutPanel2.TabIndex = 26;
            // 
            // PreliminayPanel
            // 
            this.PreliminayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreliminayPanel.BackColor = System.Drawing.Color.White;
            this.PreliminayPanel.Controls.Add(this.GroupBox6);
            this.PreliminayPanel.Controls.Add(this.TableLayoutPanel2);
            this.PreliminayPanel.Controls.Add(this.TableLayoutPanel1);
            this.PreliminayPanel.Controls.Add(this.Label42);
            this.PreliminayPanel.Controls.Add(this.TextBox1);
            this.PreliminayPanel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreliminayPanel.Location = new System.Drawing.Point(28, 38);
            this.PreliminayPanel.Name = "PreliminayPanel";
            this.PreliminayPanel.Size = new System.Drawing.Size(1295, 535);
            this.PreliminayPanel.TabIndex = 144;
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.MatterTypeComboBox);
            this.GroupBox6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox6.ForeColor = System.Drawing.Color.Black;
            this.GroupBox6.Location = new System.Drawing.Point(479, 3);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(341, 68);
            this.GroupBox6.TabIndex = 141;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "Matter Type";
            // 
            // MatterTypeComboBox
            // 
            this.MatterTypeComboBox.BackColor = System.Drawing.Color.White;
            this.MatterTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.IntakesBindingSource, "MatterType", true));
            this.MatterTypeComboBox.DataSource = this.MatterTypeBindingSource;
            this.MatterTypeComboBox.DisplayMember = "MatterType";
            this.MatterTypeComboBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatterTypeComboBox.FormattingEnabled = true;
            this.MatterTypeComboBox.Location = new System.Drawing.Point(21, 28);
            this.MatterTypeComboBox.Name = "MatterTypeComboBox";
            this.MatterTypeComboBox.Size = new System.Drawing.Size(300, 25);
            this.MatterTypeComboBox.TabIndex = 139;
            this.MatterTypeComboBox.ValueMember = "MatterType";
            this.MatterTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.MatterTypeComboBox_SelectedIndexChanged);
            // 
            // MatterTypeBindingSource
            // 
            this.MatterTypeBindingSource.DataMember = "MatterType";
            this.MatterTypeBindingSource.DataSource = this.ActionLogDBDataSet;
            // 
            // PreliminaryInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PreliminayPanel);
            this.Name = "PreliminaryInfo";
            this.Size = new System.Drawing.Size(1350, 610);
            this.Load += new System.EventHandler(this.PreliminaryInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IntakesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionLogDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileLawyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StaffInterviewerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResponsibleLawyerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HearAboutUsBindingSource)).EndInit();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel2.PerformLayout();
            this.PreliminayPanel.ResumeLayout(false);
            this.PreliminayPanel.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MatterTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox AdditionalNotesTextBox;
        internal System.Windows.Forms.BindingSource IntakesBindingSource;
        internal ActionLogDBDataSet ActionLogDBDataSet;
        internal System.Windows.Forms.ComboBox LawyerComboBox;
        internal System.Windows.Forms.BindingSource FileLawyerBindingSource;
        internal ActionLogDBDataSetTableAdapters.StaffInterviewerTableAdapter StaffInterviewerTableAdapter;
        internal System.Windows.Forms.BindingSource StaffInterviewerBindingSource;
        internal System.Windows.Forms.BindingSource ResponsibleLawyerBindingSource;
        internal System.Windows.Forms.BindingSource HearAboutUsBindingSource;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.ComboBox MatterSubTypeComboBox;
        internal System.Windows.Forms.TextBox FileNumberTextBox;
        internal System.Windows.Forms.ComboBox StaffInterviewerComboBox;
        internal System.Windows.Forms.ComboBox ResponsibleLawyerComboBox;
        internal System.Windows.Forms.TextBox LimitationPeriodTextBox;
        internal System.Windows.Forms.ComboBox HowHearComboBox;
        internal System.Windows.Forms.DateTimePicker DateOfLossDateTimePicker;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox StatutoryNoticeBox;
        internal System.Windows.Forms.DateTimePicker DateOFCallDateTimePicker;
        internal System.Windows.Forms.Label Label42;
        internal ActionLogDBDataSetTableAdapters.MatterTypeTableAdapter MatterTypeTableAdapter;
        internal ActionLogDBDataSetTableAdapters.MatterSubTypesTableAdapter MatterSubTypesTableAdapter;
        internal ActionLogDBDataSetTableAdapters.IntakesTableAdapter IntakesTableAdapter;
        internal ActionLogDBDataSetTableAdapters.ResponsibleLawyerTableAdapter ResponsibleLawyerTableAdapter;
        internal ActionLogDBDataSetTableAdapters.HearAboutUsTableAdapter HearAboutUsTableAdapter;
        internal System.Windows.Forms.TextBox TextBox1;
        internal ActionLogDBDataSetTableAdapters.FileLawyerTableAdapter FileLawyerTableAdapter;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
        internal System.Windows.Forms.Panel PreliminayPanel;
        internal System.Windows.Forms.GroupBox GroupBox6;
        internal System.Windows.Forms.ComboBox MatterTypeComboBox;
        internal System.Windows.Forms.BindingSource MatterTypeBindingSource;
    }
}
