
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
            this.Settings = new System.Windows.Forms.Button();
            this.SelectFolders = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DoneButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.DocumentType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DocumentFormContent = new System.Windows.Forms.Panel();
            this.findFilePanelUserControl1 = new RRFFilesManager.Controls.CommonControls.FindFilePanelUserControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ArchivesGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.PreviewPanel = new System.Windows.Forms.Panel();
            this.previewArchiveUserControl = new RRFFilesManager.Controls.ArchiveControls.PreviewArchiveUserControl();
            this.previewArchiveUserControl1 = new RRFFilesManager.Controls.ArchiveControls.PreviewArchiveUserControl();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FilesGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ArchivesGridView)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.PreviewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.Settings);
            groupBox1.Controls.Add(this.SelectFolders);
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
            // Settings
            // 
            this.Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.Location = new System.Drawing.Point(603, -3);
            this.Settings.Margin = new System.Windows.Forms.Padding(0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(88, 20);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // SelectFolders
            // 
            this.SelectFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectFolders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFolders.Location = new System.Drawing.Point(691, -2);
            this.SelectFolders.Margin = new System.Windows.Forms.Padding(0);
            this.SelectFolders.Name = "SelectFolders";
            this.SelectFolders.Size = new System.Drawing.Size(88, 20);
            this.SelectFolders.TabIndex = 2;
            this.SelectFolders.Text = "Select Folder";
            this.SelectFolders.UseVisualStyleBackColor = true;
            this.SelectFolders.Click += new System.EventHandler(this.SelectFolders_Click);
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
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.findFilePanelUserControl1, 0, 0);
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
            this.DocumentDate.Checked = false;
            this.DocumentDate.CustomFormat = " ";
            this.DocumentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DocumentDate.Location = new System.Drawing.Point(587, 3);
            this.DocumentDate.Name = "DocumentDate";
            this.DocumentDate.ShowCheckBox = true;
            this.DocumentDate.Size = new System.Drawing.Size(278, 20);
            this.DocumentDate.TabIndex = 4;
            this.DocumentDate.Value = new System.DateTime(2021, 3, 16, 0, 0, 0, 0);
            this.DocumentDate.ValueChanged += new System.EventHandler(this.DocumentDate_ValueChanged);
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
            this.DateRangeTo.Checked = false;
            this.DateRangeTo.CustomFormat = " ";
            this.DateRangeTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateRangeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateRangeTo.Location = new System.Drawing.Point(145, 3);
            this.DateRangeTo.Name = "DateRangeTo";
            this.DateRangeTo.ShowCheckBox = true;
            this.DateRangeTo.Size = new System.Drawing.Size(136, 20);
            this.DateRangeTo.TabIndex = 6;
            this.DateRangeTo.Value = new System.DateTime(2021, 3, 16, 0, 0, 0, 0);
            this.DateRangeTo.ValueChanged += new System.EventHandler(this.DateRangeTo_ValueChanged);
            // 
            // DateRangeFrom
            // 
            this.DateRangeFrom.Checked = false;
            this.DateRangeFrom.CustomFormat = " ";
            this.DateRangeFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateRangeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateRangeFrom.Location = new System.Drawing.Point(3, 3);
            this.DateRangeFrom.Name = "DateRangeFrom";
            this.DateRangeFrom.ShowCheckBox = true;
            this.DateRangeFrom.Size = new System.Drawing.Size(136, 20);
            this.DateRangeFrom.TabIndex = 5;
            this.DateRangeFrom.Value = new System.DateTime(2021, 3, 16, 0, 0, 0, 0);
            this.DateRangeFrom.ValueChanged += new System.EventHandler(this.DateRangeFrom_ValueChanged);
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
            this.DocumentName.TextChanged += new System.EventHandler(this.DocumentName_TextChanged);
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
            // findFilePanelUserControl1
            // 
            this.findFilePanelUserControl1.File = null;
            this.findFilePanelUserControl1.Location = new System.Drawing.Point(3, 3);
            this.findFilePanelUserControl1.Name = "findFilePanelUserControl1";
            this.findFilePanelUserControl1.Size = new System.Drawing.Size(862, 35);
            this.findFilePanelUserControl1.TabIndex = 147;
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
            this.PreviewPanel.Controls.Add(this.previewArchiveUserControl);
            this.PreviewPanel.Controls.Add(this.previewArchiveUserControl1);
            this.PreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewPanel.Location = new System.Drawing.Point(879, 4);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.Size = new System.Drawing.Size(465, 665);
            this.PreviewPanel.TabIndex = 1;
            // 
            // previewArchiveUserControl
            // 
            this.previewArchiveUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewArchiveUserControl.Location = new System.Drawing.Point(0, 0);
            this.previewArchiveUserControl.Name = "previewArchiveUserControl";
            this.previewArchiveUserControl.Size = new System.Drawing.Size(465, 665);
            this.previewArchiveUserControl.TabIndex = 1;
            // 
            // previewArchiveUserControl1
            // 
            this.previewArchiveUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewArchiveUserControl1.Location = new System.Drawing.Point(0, 0);
            this.previewArchiveUserControl1.Name = "previewArchiveUserControl1";
            this.previewArchiveUserControl1.Size = new System.Drawing.Size(465, 665);
            this.previewArchiveUserControl1.TabIndex = 0;
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
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ArchivesGridView)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.PreviewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel PreviewPanel;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.ComboBox DocumentType;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel DocumentFormContent;
        private System.Windows.Forms.Button SelectFolders;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Settings;
        private PreviewArchiveUserControl previewArchiveUserControl1;
        private PreviewArchiveUserControl previewArchiveUserControl;
        private CommonControls.FindFilePanelUserControl findFilePanelUserControl1;
    }
}