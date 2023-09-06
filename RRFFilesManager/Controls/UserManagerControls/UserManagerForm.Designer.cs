
namespace RRFFilesManager.Controls.UserManagerControls
{
    partial class UserManagerForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserLawyerListBox = new System.Windows.Forms.ListBox();
            this.UserLawyerBox = new System.Windows.Forms.GroupBox();
            this.UserNameChangeBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CBoxResponsibleCheckBox = new System.Windows.Forms.CheckBox();
            this.CBoxFileLawyerCheckBox = new System.Windows.Forms.CheckBox();
            this.CBoxIsParalegalCheckBox = new System.Windows.Forms.CheckBox();
            this.TBoxDescriptionLabel = new System.Windows.Forms.Label();
            this.CBoxBaseComissionCheckBox = new System.Windows.Forms.CheckBox();
            this.NUDNumberIDLabel = new System.Windows.Forms.Label();
            this.NUDComissionMultiplierNUpDown = new System.Windows.Forms.NumericUpDown();
            this.NUDComissionMultiplierLabel = new System.Windows.Forms.Label();
            this.DTPContractDateLabel = new System.Windows.Forms.Label();
            this.TBoxDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DTPContractDateDateTime = new System.Windows.Forms.DateTimePicker();
            this.NUDNumberIDNUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TBoxConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.TBoxConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.TBoxNewPasswordLabel = new System.Windows.Forms.Label();
            this.TBoxUserNameLabel = new System.Windows.Forms.Label();
            this.TBoxUserNameTextBox = new System.Windows.Forms.TextBox();
            this.TBarClearanceLevelTrackBar = new System.Windows.Forms.TrackBar();
            this.TBarClearanceLevelHighestLabel = new System.Windows.Forms.Label();
            this.TBarClearanceLevelLowestLabel = new System.Windows.Forms.Label();
            this.TBoxNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.CBoxChangePasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.TBarClearanceLevelLabel = new System.Windows.Forms.Label();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.UserManagerTransferButton = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UserLawyerBox.SuspendLayout();
            this.UserNameChangeBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDComissionMultiplierNUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberIDNUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBarClearanceLevelTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserLawyerListBox
            // 
            this.UserLawyerListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserLawyerListBox.FormattingEnabled = true;
            this.UserLawyerListBox.ItemHeight = 17;
            this.UserLawyerListBox.Location = new System.Drawing.Point(4, 20);
            this.UserLawyerListBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserLawyerListBox.Name = "UserLawyerListBox";
            this.UserLawyerListBox.Size = new System.Drawing.Size(291, 435);
            this.UserLawyerListBox.TabIndex = 145;
            this.UserLawyerListBox.SelectedIndexChanged += new System.EventHandler(this.UserLawyerListBox_SelectedIndexChanged);
            // 
            // UserLawyerBox
            // 
            this.UserLawyerBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UserLawyerBox.Controls.Add(this.UserLawyerListBox);
            this.UserLawyerBox.Location = new System.Drawing.Point(16, 113);
            this.UserLawyerBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserLawyerBox.Name = "UserLawyerBox";
            this.UserLawyerBox.Padding = new System.Windows.Forms.Padding(4);
            this.UserLawyerBox.Size = new System.Drawing.Size(299, 459);
            this.UserLawyerBox.TabIndex = 146;
            this.UserLawyerBox.TabStop = false;
            this.UserLawyerBox.Text = "Users / Lawyers";
            // 
            // UserNameChangeBox
            // 
            this.UserNameChangeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserNameChangeBox.Controls.Add(this.tableLayoutPanel1);
            this.UserNameChangeBox.Location = new System.Drawing.Point(335, 123);
            this.UserNameChangeBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserNameChangeBox.Name = "UserNameChangeBox";
            this.UserNameChangeBox.Padding = new System.Windows.Forms.Padding(4);
            this.UserNameChangeBox.Size = new System.Drawing.Size(716, 229);
            this.UserNameChangeBox.TabIndex = 147;
            this.UserNameChangeBox.TabStop = false;
            this.UserNameChangeBox.Text = "Info";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.CBoxResponsibleCheckBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CBoxFileLawyerCheckBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CBoxIsParalegalCheckBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TBoxDescriptionLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CBoxBaseComissionCheckBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.NUDNumberIDLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.NUDComissionMultiplierNUpDown, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.NUDComissionMultiplierLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.DTPContractDateLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.TBoxDescriptionTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DTPContractDateDateTime, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.NUDNumberIDNUpDown, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 205);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // CBoxResponsibleCheckBox
            // 
            this.CBoxResponsibleCheckBox.AutoSize = true;
            this.CBoxResponsibleCheckBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CBoxResponsibleCheckBox.Location = new System.Drawing.Point(29, 115);
            this.CBoxResponsibleCheckBox.Name = "CBoxResponsibleCheckBox";
            this.CBoxResponsibleCheckBox.Size = new System.Drawing.Size(204, 40);
            this.CBoxResponsibleCheckBox.TabIndex = 159;
            this.CBoxResponsibleCheckBox.Text = "Can be Responsible Lawyer";
            this.CBoxResponsibleCheckBox.UseVisualStyleBackColor = true;
            // 
            // CBoxFileLawyerCheckBox
            // 
            this.CBoxFileLawyerCheckBox.AutoSize = true;
            this.CBoxFileLawyerCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CBoxFileLawyerCheckBox.Location = new System.Drawing.Point(239, 115);
            this.CBoxFileLawyerCheckBox.Name = "CBoxFileLawyerCheckBox";
            this.CBoxFileLawyerCheckBox.Size = new System.Drawing.Size(149, 40);
            this.CBoxFileLawyerCheckBox.TabIndex = 158;
            this.CBoxFileLawyerCheckBox.Text = "Can be File Lawyer";
            this.CBoxFileLawyerCheckBox.UseVisualStyleBackColor = true;
            // 
            // CBoxIsParalegalCheckBox
            // 
            this.CBoxIsParalegalCheckBox.AutoSize = true;
            this.CBoxIsParalegalCheckBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CBoxIsParalegalCheckBox.Location = new System.Drawing.Point(132, 161);
            this.CBoxIsParalegalCheckBox.Name = "CBoxIsParalegalCheckBox";
            this.CBoxIsParalegalCheckBox.Size = new System.Drawing.Size(101, 41);
            this.CBoxIsParalegalCheckBox.TabIndex = 27;
            this.CBoxIsParalegalCheckBox.Text = "Is Paralegal";
            this.CBoxIsParalegalCheckBox.UseVisualStyleBackColor = true;
            // 
            // TBoxDescriptionLabel
            // 
            this.TBoxDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TBoxDescriptionLabel.AutoSize = true;
            this.TBoxDescriptionLabel.Location = new System.Drawing.Point(3, 0);
            this.TBoxDescriptionLabel.Name = "TBoxDescriptionLabel";
            this.TBoxDescriptionLabel.Size = new System.Drawing.Size(72, 46);
            this.TBoxDescriptionLabel.TabIndex = 19;
            this.TBoxDescriptionLabel.Text = "Full Name";
            this.TBoxDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBoxBaseComissionCheckBox
            // 
            this.CBoxBaseComissionCheckBox.AutoSize = true;
            this.CBoxBaseComissionCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CBoxBaseComissionCheckBox.Location = new System.Drawing.Point(239, 161);
            this.CBoxBaseComissionCheckBox.Name = "CBoxBaseComissionCheckBox";
            this.CBoxBaseComissionCheckBox.Size = new System.Drawing.Size(176, 41);
            this.CBoxBaseComissionCheckBox.TabIndex = 26;
            this.CBoxBaseComissionCheckBox.Text = "Earns Base Commission";
            this.CBoxBaseComissionCheckBox.UseVisualStyleBackColor = true;
            // 
            // NUDNumberIDLabel
            // 
            this.NUDNumberIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NUDNumberIDLabel.AutoSize = true;
            this.NUDNumberIDLabel.Location = new System.Drawing.Point(239, 0);
            this.NUDNumberIDLabel.Name = "NUDNumberIDLabel";
            this.NUDNumberIDLabel.Size = new System.Drawing.Size(77, 46);
            this.NUDNumberIDLabel.TabIndex = 21;
            this.NUDNumberIDLabel.Text = "ID Number";
            this.NUDNumberIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NUDComissionMultiplierNUpDown
            // 
            this.NUDComissionMultiplierNUpDown.DecimalPlaces = 2;
            this.NUDComissionMultiplierNUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUDComissionMultiplierNUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NUDComissionMultiplierNUpDown.Location = new System.Drawing.Point(475, 161);
            this.NUDComissionMultiplierNUpDown.Name = "NUDComissionMultiplierNUpDown";
            this.NUDComissionMultiplierNUpDown.Size = new System.Drawing.Size(230, 23);
            this.NUDComissionMultiplierNUpDown.TabIndex = 24;
            // 
            // NUDComissionMultiplierLabel
            // 
            this.NUDComissionMultiplierLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.NUDComissionMultiplierLabel.AutoSize = true;
            this.NUDComissionMultiplierLabel.Location = new System.Drawing.Point(475, 112);
            this.NUDComissionMultiplierLabel.Name = "NUDComissionMultiplierLabel";
            this.NUDComissionMultiplierLabel.Size = new System.Drawing.Size(181, 46);
            this.NUDComissionMultiplierLabel.TabIndex = 25;
            this.NUDComissionMultiplierLabel.Text = "Base Commission Multiplier";
            this.NUDComissionMultiplierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTPContractDateLabel
            // 
            this.DTPContractDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DTPContractDateLabel.AutoSize = true;
            this.DTPContractDateLabel.Location = new System.Drawing.Point(475, 0);
            this.DTPContractDateLabel.Name = "DTPContractDateLabel";
            this.DTPContractDateLabel.Size = new System.Drawing.Size(103, 46);
            this.DTPContractDateLabel.TabIndex = 23;
            this.DTPContractDateLabel.Text = "Contract Date";
            this.DTPContractDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBoxDescriptionTextBox
            // 
            this.TBoxDescriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBoxDescriptionTextBox.Location = new System.Drawing.Point(4, 50);
            this.TBoxDescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TBoxDescriptionTextBox.Name = "TBoxDescriptionTextBox";
            this.TBoxDescriptionTextBox.Size = new System.Drawing.Size(228, 23);
            this.TBoxDescriptionTextBox.TabIndex = 18;
            // 
            // DTPContractDateDateTime
            // 
            this.DTPContractDateDateTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTPContractDateDateTime.Location = new System.Drawing.Point(475, 49);
            this.DTPContractDateDateTime.Name = "DTPContractDateDateTime";
            this.DTPContractDateDateTime.Size = new System.Drawing.Size(230, 23);
            this.DTPContractDateDateTime.TabIndex = 22;
            // 
            // NUDNumberIDNUpDown
            // 
            this.NUDNumberIDNUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUDNumberIDNUpDown.Location = new System.Drawing.Point(239, 49);
            this.NUDNumberIDNUpDown.Name = "NUDNumberIDNUpDown";
            this.NUDNumberIDNUpDown.Size = new System.Drawing.Size(230, 23);
            this.NUDNumberIDNUpDown.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(335, 352);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(716, 182);
            this.groupBox1.TabIndex = 148;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Name and Password";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.3785F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.97496F));
            this.tableLayoutPanel2.Controls.Add(this.TBoxConfirmPasswordTextBox, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.TBoxConfirmPasswordLabel, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.TBoxNewPasswordLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TBoxUserNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TBoxUserNameTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.TBarClearanceLevelTrackBar, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.TBarClearanceLevelHighestLabel, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.TBarClearanceLevelLowestLabel, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.TBoxNewPasswordTextBox, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.CBoxChangePasswordCheckBox, 5, 4);
            this.tableLayoutPanel2.Controls.Add(this.TBarClearanceLevelLabel, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.86567F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.9403F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(708, 158);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // TBoxConfirmPasswordTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.TBoxConfirmPasswordTextBox, 2);
            this.TBoxConfirmPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBoxConfirmPasswordTextBox.Location = new System.Drawing.Point(298, 127);
            this.TBoxConfirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TBoxConfirmPasswordTextBox.Name = "TBoxConfirmPasswordTextBox";
            this.TBoxConfirmPasswordTextBox.Size = new System.Drawing.Size(248, 23);
            this.TBoxConfirmPasswordTextBox.TabIndex = 160;
            // 
            // TBoxConfirmPasswordLabel
            // 
            this.TBoxConfirmPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TBoxConfirmPasswordLabel.AutoSize = true;
            this.TBoxConfirmPasswordLabel.Location = new System.Drawing.Point(297, 104);
            this.TBoxConfirmPasswordLabel.Name = "TBoxConfirmPasswordLabel";
            this.TBoxConfirmPasswordLabel.Size = new System.Drawing.Size(125, 19);
            this.TBoxConfirmPasswordLabel.TabIndex = 158;
            this.TBoxConfirmPasswordLabel.Text = "Confirm Password";
            this.TBoxConfirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBoxNewPasswordLabel
            // 
            this.TBoxNewPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TBoxNewPasswordLabel.AutoSize = true;
            this.TBoxNewPasswordLabel.Location = new System.Drawing.Point(3, 104);
            this.TBoxNewPasswordLabel.Name = "TBoxNewPasswordLabel";
            this.TBoxNewPasswordLabel.Size = new System.Drawing.Size(103, 19);
            this.TBoxNewPasswordLabel.TabIndex = 157;
            this.TBoxNewPasswordLabel.Text = "New Password";
            this.TBoxNewPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBoxUserNameLabel
            // 
            this.TBoxUserNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TBoxUserNameLabel.AutoSize = true;
            this.TBoxUserNameLabel.Location = new System.Drawing.Point(3, 0);
            this.TBoxUserNameLabel.Name = "TBoxUserNameLabel";
            this.TBoxUserNameLabel.Size = new System.Drawing.Size(77, 31);
            this.TBoxUserNameLabel.TabIndex = 20;
            this.TBoxUserNameLabel.Text = "User Name";
            this.TBoxUserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBoxUserNameTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.TBoxUserNameTextBox, 2);
            this.TBoxUserNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBoxUserNameTextBox.Location = new System.Drawing.Point(4, 35);
            this.TBoxUserNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TBoxUserNameTextBox.Name = "TBoxUserNameTextBox";
            this.TBoxUserNameTextBox.Size = new System.Drawing.Size(266, 23);
            this.TBoxUserNameTextBox.TabIndex = 21;
            // 
            // TBarClearanceLevelTrackBar
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.TBarClearanceLevelTrackBar, 3);
            this.TBarClearanceLevelTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBarClearanceLevelTrackBar.Location = new System.Drawing.Point(297, 34);
            this.TBarClearanceLevelTrackBar.Name = "TBarClearanceLevelTrackBar";
            this.TBarClearanceLevelTrackBar.Size = new System.Drawing.Size(408, 25);
            this.TBarClearanceLevelTrackBar.TabIndex = 22;
            // 
            // TBarClearanceLevelHighestLabel
            // 
            this.TBarClearanceLevelHighestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TBarClearanceLevelHighestLabel.AutoSize = true;
            this.TBarClearanceLevelHighestLabel.Location = new System.Drawing.Point(297, 62);
            this.TBarClearanceLevelHighestLabel.Name = "TBarClearanceLevelHighestLabel";
            this.TBarClearanceLevelHighestLabel.Size = new System.Drawing.Size(59, 42);
            this.TBarClearanceLevelHighestLabel.TabIndex = 24;
            this.TBarClearanceLevelHighestLabel.Text = "Highest\r\n(Admin)\r\n";
            this.TBarClearanceLevelHighestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBarClearanceLevelLowestLabel
            // 
            this.TBarClearanceLevelLowestLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBarClearanceLevelLowestLabel.AutoSize = true;
            this.TBarClearanceLevelLowestLabel.Location = new System.Drawing.Point(652, 62);
            this.TBarClearanceLevelLowestLabel.Name = "TBarClearanceLevelLowestLabel";
            this.TBarClearanceLevelLowestLabel.Size = new System.Drawing.Size(53, 42);
            this.TBarClearanceLevelLowestLabel.TabIndex = 25;
            this.TBarClearanceLevelLowestLabel.Text = "Lowest";
            this.TBarClearanceLevelLowestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBoxNewPasswordTextBox
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.TBoxNewPasswordTextBox, 2);
            this.TBoxNewPasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBoxNewPasswordTextBox.Location = new System.Drawing.Point(4, 127);
            this.TBoxNewPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TBoxNewPasswordTextBox.Name = "TBoxNewPasswordTextBox";
            this.TBoxNewPasswordTextBox.Size = new System.Drawing.Size(266, 23);
            this.TBoxNewPasswordTextBox.TabIndex = 159;
            // 
            // CBoxChangePasswordCheckBox
            // 
            this.CBoxChangePasswordCheckBox.AutoSize = true;
            this.CBoxChangePasswordCheckBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CBoxChangePasswordCheckBox.Location = new System.Drawing.Point(553, 126);
            this.CBoxChangePasswordCheckBox.Name = "CBoxChangePasswordCheckBox";
            this.CBoxChangePasswordCheckBox.Size = new System.Drawing.Size(111, 29);
            this.CBoxChangePasswordCheckBox.TabIndex = 161;
            this.CBoxChangePasswordCheckBox.Text = "Set Password";
            this.CBoxChangePasswordCheckBox.UseVisualStyleBackColor = true;
            this.CBoxChangePasswordCheckBox.CheckedChanged += new System.EventHandler(this.CBoxChangePasswordCheckBox_CheckedChanged);
            // 
            // TBarClearanceLevelLabel
            // 
            this.TBarClearanceLevelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBarClearanceLevelLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.TBarClearanceLevelLabel, 3);
            this.TBarClearanceLevelLabel.Location = new System.Drawing.Point(297, 0);
            this.TBarClearanceLevelLabel.Name = "TBarClearanceLevelLabel";
            this.TBarClearanceLevelLabel.Size = new System.Drawing.Size(408, 31);
            this.TBarClearanceLevelLabel.TabIndex = 23;
            this.TBarClearanceLevelLabel.Text = "Clearance Level";
            this.TBarClearanceLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeButton
            // 
            this.HomeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeButton.BackColor = System.Drawing.Color.Maroon;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(848, 67);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(4);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(203, 48);
            this.HomeButton.TabIndex = 154;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.SteelBlue;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(335, 542);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(211, 30);
            this.SaveButton.TabIndex = 155;
            this.SaveButton.Text = "Save Selected User";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewButton.BackColor = System.Drawing.Color.SeaGreen;
            this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.ForeColor = System.Drawing.Color.White;
            this.NewButton.Location = new System.Drawing.Point(821, 542);
            this.NewButton.Margin = new System.Windows.Forms.Padding(4);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(230, 30);
            this.NewButton.TabIndex = 156;
            this.NewButton.Text = "Create New User / Lawyer";
            this.NewButton.UseVisualStyleBackColor = false;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // UserManagerTransferButton
            // 
            this.UserManagerTransferButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UserManagerTransferButton.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.UserManagerTransferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserManagerTransferButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserManagerTransferButton.ForeColor = System.Drawing.Color.White;
            this.UserManagerTransferButton.Location = new System.Drawing.Point(555, 542);
            this.UserManagerTransferButton.Margin = new System.Windows.Forms.Padding(4);
            this.UserManagerTransferButton.Name = "UserManagerTransferButton";
            this.UserManagerTransferButton.Size = new System.Drawing.Size(172, 30);
            this.UserManagerTransferButton.TabIndex = 157;
            this.UserManagerTransferButton.Text = "Transfer User Tasks";
            this.UserManagerTransferButton.UseVisualStyleBackColor = false;
            this.UserManagerTransferButton.Click += new System.EventHandler(this.UserManagerTransferButton_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::RRFFilesManager.Properties.Resources.RRFLogo;
            this.PictureBox1.Location = new System.Drawing.Point(20, 16);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(299, 89);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 144;
            this.PictureBox1.TabStop = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(740, 542);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(73, 30);
            this.DeleteButton.TabIndex = 158;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UserManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UserManagerTransferButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UserNameChangeBox);
            this.Controls.Add(this.UserLawyerBox);
            this.Controls.Add(this.PictureBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserManagerForm";
            this.Text = "User Manager";
            this.UserLawyerBox.ResumeLayout(false);
            this.UserNameChangeBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDComissionMultiplierNUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberIDNUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBarClearanceLevelTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ListBox UserLawyerListBox;
        private System.Windows.Forms.GroupBox UserLawyerBox;
        private System.Windows.Forms.GroupBox UserNameChangeBox;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button HomeButton;
        internal System.Windows.Forms.Button SaveButton;
        internal System.Windows.Forms.TextBox TBoxDescriptionTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label TBoxDescriptionLabel;
        private System.Windows.Forms.Label DTPContractDateLabel;
        private System.Windows.Forms.DateTimePicker DTPContractDateDateTime;
        private System.Windows.Forms.Label NUDNumberIDLabel;
        private System.Windows.Forms.NumericUpDown NUDNumberIDNUpDown;
        private System.Windows.Forms.CheckBox CBoxIsParalegalCheckBox;
        private System.Windows.Forms.CheckBox CBoxBaseComissionCheckBox;
        private System.Windows.Forms.NumericUpDown NUDComissionMultiplierNUpDown;
        private System.Windows.Forms.Label NUDComissionMultiplierLabel;
        private System.Windows.Forms.Label TBarClearanceLevelLowestLabel;
        private System.Windows.Forms.Label TBarClearanceLevelHighestLabel;
        private System.Windows.Forms.Label TBarClearanceLevelLabel;
        private System.Windows.Forms.TrackBar TBarClearanceLevelTrackBar;
        internal System.Windows.Forms.TextBox TBoxUserNameTextBox;
        private System.Windows.Forms.Label TBoxUserNameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        internal System.Windows.Forms.TextBox TBoxConfirmPasswordTextBox;
        private System.Windows.Forms.Label TBoxConfirmPasswordLabel;
        private System.Windows.Forms.Label TBoxNewPasswordLabel;
        internal System.Windows.Forms.TextBox TBoxNewPasswordTextBox;
        private System.Windows.Forms.CheckBox CBoxChangePasswordCheckBox;
        internal System.Windows.Forms.Button NewButton;
        internal System.Windows.Forms.Button UserManagerTransferButton;
        private System.Windows.Forms.CheckBox CBoxResponsibleCheckBox;
        private System.Windows.Forms.CheckBox CBoxFileLawyerCheckBox;
        internal System.Windows.Forms.Button DeleteButton;
    }
}