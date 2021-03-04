﻿
namespace RRFFilesManager.Controls.ArchiveControls
{
    partial class UploadArchivesForm
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
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.Label DateOFCallLabel;
            System.Windows.Forms.Label label15;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadArchivesForm));
            this.SelectFiles = new System.Windows.Forms.Button();
            this.FilesGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.DocumentCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.DocumentGroup = new System.Windows.Forms.ComboBox();
            this.DocumentDate = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.DateRangeTo = new System.Windows.Forms.DateTimePicker();
            this.DateRangeFrom = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.DocumentName = new System.Windows.Forms.TextBox();
            this.IntakeInfo = new System.Windows.Forms.TableLayoutPanel();
            this.FindFileButton = new System.Windows.Forms.Button();
            this.FileNumberTextBox = new System.Windows.Forms.TextBox();
            this.MatterTypeTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DoneButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.DocumentType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DocumentFormContent = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ArchivesGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.PreviewPanel = new System.Windows.Forms.Panel();
            this.previewHandlerHost1 = new RRFFilesManager.PreviewHandlerHost();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.axAcroPDF = new AxAcroPDFLib.AxAcroPDF();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            groupBox1 = new System.Windows.Forms.GroupBox();
            DateOFCallLabel = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilesGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.IntakeInfo.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArchivesGridView)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.PreviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.SelectFiles);
            groupBox1.Controls.Add(this.FilesGridView);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            groupBox1.Location = new System.Drawing.Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(862, 151);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uploaded files";
            // 
            // SelectFiles
            // 
            this.SelectFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFiles.Location = new System.Drawing.Point(779, -2);
            this.SelectFiles.Margin = new System.Windows.Forms.Padding(0);
            this.SelectFiles.Name = "SelectFiles";
            this.SelectFiles.Size = new System.Drawing.Size(81, 20);
            this.SelectFiles.TabIndex = 1;
            this.SelectFiles.Text = "Select Files";
            this.SelectFiles.UseVisualStyleBackColor = true;
            this.SelectFiles.Click += new System.EventHandler(this.SelectFiles_Click);
            // 
            // FilesGridView
            // 
            this.FilesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilesGridView.Location = new System.Drawing.Point(3, 18);
            this.FilesGridView.MultiSelect = false;
            this.FilesGridView.Name = "FilesGridView";
            this.FilesGridView.ReadOnly = true;
            this.FilesGridView.Size = new System.Drawing.Size(856, 130);
            this.FilesGridView.TabIndex = 0;
            this.FilesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilesGridView_CellClick);
            this.FilesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FilesGridView_CellContentClick);
            // 
            // DateOFCallLabel
            // 
            DateOFCallLabel.AutoSize = true;
            DateOFCallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateOFCallLabel.Location = new System.Drawing.Point(153, 0);
            DateOFCallLabel.Name = "DateOFCallLabel";
            DateOFCallLabel.Size = new System.Drawing.Size(83, 16);
            DateOFCallLabel.TabIndex = 144;
            DateOFCallLabel.Text = "Matter Type:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(512, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(84, 16);
            label15.TabIndex = 145;
            label15.Text = "File Number:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(868, 665);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 151);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.IntakeInfo, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 157);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(868, 350);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 50);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(868, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.DocumentCategory, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.Label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DocumentGroup, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.DocumentDate, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 3, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(868, 60);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(437, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date Range";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DocumentCategory
            // 
            this.DocumentCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentCategory.FormattingEnabled = true;
            this.DocumentCategory.Location = new System.Drawing.Point(153, 33);
            this.DocumentCategory.Name = "DocumentCategory";
            this.DocumentCategory.Size = new System.Drawing.Size(278, 21);
            this.DocumentCategory.TabIndex = 7;
            this.DocumentCategory.SelectedIndexChanged += new System.EventHandler(this.DocumentCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Document Category";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Document Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(3, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(144, 30);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Document Group";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DocumentGroup
            // 
            this.DocumentGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentGroup.FormattingEnabled = true;
            this.DocumentGroup.Location = new System.Drawing.Point(153, 3);
            this.DocumentGroup.Name = "DocumentGroup";
            this.DocumentGroup.Size = new System.Drawing.Size(278, 21);
            this.DocumentGroup.TabIndex = 2;
            this.DocumentGroup.SelectedIndexChanged += new System.EventHandler(this.DocumentFolder_SelectedIndexChanged);
            // 
            // DocumentDate
            // 
            this.DocumentDate.CustomFormat = "yyyy-MM-dd";
            this.DocumentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentDate.Location = new System.Drawing.Point(587, 3);
            this.DocumentDate.Name = "DocumentDate";
            this.DocumentDate.Size = new System.Drawing.Size(278, 20);
            this.DocumentDate.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.DateRangeTo, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.DateRangeFrom, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(584, 30);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(284, 30);
            this.tableLayoutPanel6.TabIndex = 5;
            // 
            // DateRangeTo
            // 
            this.DateRangeTo.CustomFormat = "yyyy-MM-dd";
            this.DateRangeTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateRangeTo.Location = new System.Drawing.Point(145, 3);
            this.DateRangeTo.Name = "DateRangeTo";
            this.DateRangeTo.Size = new System.Drawing.Size(136, 20);
            this.DateRangeTo.TabIndex = 6;
            // 
            // DateRangeFrom
            // 
            this.DateRangeFrom.CustomFormat = "yyyy-MM-dd";
            this.DateRangeFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateRangeFrom.Location = new System.Drawing.Point(3, 3);
            this.DateRangeFrom.Name = "DateRangeFrom";
            this.DateRangeFrom.Size = new System.Drawing.Size(136, 20);
            this.DateRangeFrom.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.DocumentName, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(868, 40);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 40);
            this.label4.TabIndex = 23;
            this.label4.Text = "Document Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DocumentName
            // 
            this.DocumentName.BackColor = System.Drawing.Color.White;
            this.DocumentName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentName.Location = new System.Drawing.Point(153, 3);
            this.DocumentName.Multiline = true;
            this.DocumentName.Name = "DocumentName";
            this.DocumentName.Size = new System.Drawing.Size(712, 34);
            this.DocumentName.TabIndex = 22;
            // 
            // IntakeInfo
            // 
            this.IntakeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntakeInfo.ColumnCount = 5;
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.IntakeInfo.Controls.Add(this.FindFileButton, 0, 0);
            this.IntakeInfo.Controls.Add(this.FileNumberTextBox, 4, 0);
            this.IntakeInfo.Controls.Add(label15, 3, 0);
            this.IntakeInfo.Controls.Add(this.MatterTypeTextBox, 2, 0);
            this.IntakeInfo.Controls.Add(DateOFCallLabel, 1, 0);
            this.IntakeInfo.Location = new System.Drawing.Point(0, 0);
            this.IntakeInfo.Margin = new System.Windows.Forms.Padding(0);
            this.IntakeInfo.Name = "IntakeInfo";
            this.IntakeInfo.RowCount = 1;
            this.IntakeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.IntakeInfo.Size = new System.Drawing.Size(868, 35);
            this.IntakeInfo.TabIndex = 145;
            // 
            // FindFileButton
            // 
            this.FindFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindFileButton.BackColor = System.Drawing.Color.Maroon;
            this.FindFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindFileButton.ForeColor = System.Drawing.Color.White;
            this.FindFileButton.Location = new System.Drawing.Point(3, 3);
            this.FindFileButton.Name = "FindFileButton";
            this.FindFileButton.Size = new System.Drawing.Size(144, 29);
            this.FindFileButton.TabIndex = 146;
            this.FindFileButton.Text = "Find File";
            this.FindFileButton.UseVisualStyleBackColor = false;
            this.FindFileButton.Click += new System.EventHandler(this.FindFileButton_Click);
            // 
            // FileNumberTextBox
            // 
            this.FileNumberTextBox.Enabled = false;
            this.FileNumberTextBox.Location = new System.Drawing.Point(612, 3);
            this.FileNumberTextBox.Name = "FileNumberTextBox";
            this.FileNumberTextBox.ReadOnly = true;
            this.FileNumberTextBox.Size = new System.Drawing.Size(253, 20);
            this.FileNumberTextBox.TabIndex = 143;
            // 
            // MatterTypeTextBox
            // 
            this.MatterTypeTextBox.Enabled = false;
            this.MatterTypeTextBox.Location = new System.Drawing.Point(253, 3);
            this.MatterTypeTextBox.Name = "MatterTypeTextBox";
            this.MatterTypeTextBox.ReadOnly = true;
            this.MatterTypeTextBox.Size = new System.Drawing.Size(253, 20);
            this.MatterTypeTextBox.TabIndex = 142;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.DocumentFormContent, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 150);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(868, 200);
            this.tableLayoutPanel8.TabIndex = 146;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DoneButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 170);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 30);
            this.panel2.TabIndex = 1;
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.Location = new System.Drawing.Point(779, 3);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DoneButton.Size = new System.Drawing.Size(81, 23);
            this.DoneButton.TabIndex = 0;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.DocumentType, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(868, 30);
            this.tableLayoutPanel9.TabIndex = 2;
            this.tableLayoutPanel9.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel9_Paint);
            // 
            // DocumentType
            // 
            this.DocumentType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentType.FormattingEnabled = true;
            this.DocumentType.Location = new System.Drawing.Point(153, 3);
            this.DocumentType.Name = "DocumentType";
            this.DocumentType.Size = new System.Drawing.Size(278, 21);
            this.DocumentType.TabIndex = 3;
            this.DocumentType.SelectedIndexChanged += new System.EventHandler(this.DocumentType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "Document Type";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DocumentFormContent
            // 
            this.DocumentFormContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentFormContent.Location = new System.Drawing.Point(0, 30);
            this.DocumentFormContent.Margin = new System.Windows.Forms.Padding(0);
            this.DocumentFormContent.Name = "DocumentFormContent";
            this.DocumentFormContent.Size = new System.Drawing.Size(868, 140);
            this.DocumentFormContent.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ArchivesGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 510);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 152);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processed files";
            // 
            // ArchivesGridView
            // 
            this.ArchivesGridView.AllowUserToAddRows = false;
            this.ArchivesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArchivesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArchivesGridView.Location = new System.Drawing.Point(3, 18);
            this.ArchivesGridView.MultiSelect = false;
            this.ArchivesGridView.Name = "ArchivesGridView";
            this.ArchivesGridView.ReadOnly = true;
            this.ArchivesGridView.Size = new System.Drawing.Size(856, 131);
            this.ArchivesGridView.TabIndex = 2;
            this.ArchivesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArchivesGridView_CellClick);
            this.ArchivesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArchivesGridView_CellContentClick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.PreviewPanel, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1348, 673);
            this.tableLayoutPanel5.TabIndex = 1;
            this.tableLayoutPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel5_Paint);
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.Controls.Add(this.previewHandlerHost1);
            this.PreviewPanel.Controls.Add(this.richTextBox);
            this.PreviewPanel.Controls.Add(this.pictureBox);
            this.PreviewPanel.Controls.Add(this.axAcroPDF);
            this.PreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewPanel.Location = new System.Drawing.Point(879, 4);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.Size = new System.Drawing.Size(465, 665);
            this.PreviewPanel.TabIndex = 1;
            // 
            // previewHandlerHost1
            // 
            this.previewHandlerHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewHandlerHost1.Location = new System.Drawing.Point(0, 0);
            this.previewHandlerHost1.Name = "previewHandlerHost1";
            this.previewHandlerHost1.Size = new System.Drawing.Size(465, 665);
            this.previewHandlerHost1.TabIndex = 4;
            this.previewHandlerHost1.Text = "previewHandlerHost2";
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.White;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(465, 665);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            this.richTextBox.Visible = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(465, 665);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // axAcroPDF
            // 
            this.axAcroPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF.Enabled = true;
            this.axAcroPDF.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF.Name = "axAcroPDF";
            this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
            this.axAcroPDF.Size = new System.Drawing.Size(465, 665);
            this.axAcroPDF.TabIndex = 0;
            this.axAcroPDF.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // UploadArchivesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 673);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "UploadArchivesForm";
            this.Text = "UploadArchivesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UploadArchivesForm_FormClosing);
            this.Load += new System.EventHandler(this.UploadArchivesForm_Load);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FilesGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.IntakeInfo.ResumeLayout(false);
            this.IntakeInfo.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ArchivesGridView)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.PreviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel PreviewPanel;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.DataGridView ArchivesGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView FilesGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SelectFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DocumentCategory;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ComboBox DocumentGroup;
        private System.Windows.Forms.DateTimePicker DocumentDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DateTimePicker DateRangeTo;
        private System.Windows.Forms.DateTimePicker DateRangeFrom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox DocumentName;
        private System.Windows.Forms.TableLayoutPanel IntakeInfo;
        private System.Windows.Forms.Button FindFileButton;
        private System.Windows.Forms.TextBox FileNumberTextBox;
        private System.Windows.Forms.TextBox MatterTypeTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.ComboBox DocumentType;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel DocumentFormContent;
        private PreviewHandlerHost previewHandlerHost1;
    }
}