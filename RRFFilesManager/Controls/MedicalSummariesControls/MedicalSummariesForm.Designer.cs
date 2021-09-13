
namespace RRFFilesManager.Controls.MedicalSummariesControls
{
    partial class MedicalSummariesForm
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
            this.DocumentDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.TreatmentCentrePostalCodeCKB = new System.Windows.Forms.CheckBox();
            this.ClientPostalCodeCKB = new System.Windows.Forms.CheckBox();
            this.ClientPostalCodeTB = new System.Windows.Forms.TextBox();
            this.TreatmentCentrePostalCodeTB = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.PreviewPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DocumentSummaryTB = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.DocumentGroupCB = new System.Windows.Forms.ComboBox();
            this.DocumentTypeCB = new System.Windows.Forms.ComboBox();
            this.DocumentCategoryCB = new System.Windows.Forms.ComboBox();
            this.DocumentGroupCKB = new System.Windows.Forms.CheckBox();
            this.DocumentTypeCKB = new System.Windows.Forms.CheckBox();
            this.DocumentCategoryCKB = new System.Windows.Forms.CheckBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.findFileAndArchivePanelUserControl1 = new RRFFilesManager.Controls.CommonControls.FindFileAndArchivePanelUserControl();
            this.previewArchiveUserControl1 = new RRFFilesManager.Controls.ArchiveControls.PreviewArchiveUserControl();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.PreviewPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // DocumentDateDTP
            // 
            this.DocumentDateDTP.CustomFormat = "MMM-dd-yyyy";
            this.DocumentDateDTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DocumentDateDTP.Location = new System.Drawing.Point(652, 3);
            this.DocumentDateDTP.Name = "DocumentDateDTP";
            this.DocumentDateDTP.ShowCheckBox = true;
            this.DocumentDateDTP.Size = new System.Drawing.Size(213, 20);
            this.DocumentDateDTP.TabIndex = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Travel Range";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.TreatmentCentrePostalCodeCKB, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.ClientPostalCodeCKB, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.ClientPostalCodeTB, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.TreatmentCentrePostalCodeTB, 3, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(649, 60);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(219, 30);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // TreatmentCentrePostalCodeCKB
            // 
            this.TreatmentCentrePostalCodeCKB.AutoSize = true;
            this.TreatmentCentrePostalCodeCKB.Location = new System.Drawing.Point(112, 6);
            this.TreatmentCentrePostalCodeCKB.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.TreatmentCentrePostalCodeCKB.Name = "TreatmentCentrePostalCodeCKB";
            this.TreatmentCentrePostalCodeCKB.Size = new System.Drawing.Size(15, 14);
            this.TreatmentCentrePostalCodeCKB.TabIndex = 152;
            this.TreatmentCentrePostalCodeCKB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.TreatmentCentrePostalCodeCKB.UseVisualStyleBackColor = true;
            // 
            // ClientPostalCodeCKB
            // 
            this.ClientPostalCodeCKB.AutoSize = true;
            this.ClientPostalCodeCKB.Location = new System.Drawing.Point(3, 6);
            this.ClientPostalCodeCKB.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.ClientPostalCodeCKB.Name = "ClientPostalCodeCKB";
            this.ClientPostalCodeCKB.Size = new System.Drawing.Size(15, 14);
            this.ClientPostalCodeCKB.TabIndex = 151;
            this.ClientPostalCodeCKB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.ClientPostalCodeCKB.UseVisualStyleBackColor = true;
            // 
            // ClientPostalCodeTB
            // 
            this.ClientPostalCodeTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientPostalCodeTB.Location = new System.Drawing.Point(33, 3);
            this.ClientPostalCodeTB.Name = "ClientPostalCodeTB";
            this.ClientPostalCodeTB.ReadOnly = true;
            this.ClientPostalCodeTB.Size = new System.Drawing.Size(73, 20);
            this.ClientPostalCodeTB.TabIndex = 0;
            // 
            // TreatmentCentrePostalCodeTB
            // 
            this.TreatmentCentrePostalCodeTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreatmentCentrePostalCodeTB.Location = new System.Drawing.Point(142, 3);
            this.TreatmentCentrePostalCodeTB.Name = "TreatmentCentrePostalCodeTB";
            this.TreatmentCentrePostalCodeTB.Size = new System.Drawing.Size(74, 20);
            this.TreatmentCentrePostalCodeTB.TabIndex = 1;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(3, 453);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(862, 209);
            this.DataGridView.TabIndex = 148;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.Controls.Add(this.previewArchiveUserControl1);
            this.PreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewPanel.Location = new System.Drawing.Point(879, 4);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.Size = new System.Drawing.Size(465, 665);
            this.PreviewPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Document Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.DocumentSummaryTB, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.DocumentDateDTP, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.DocumentGroupCB, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.DocumentGroupCKB, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.DocumentTypeCKB, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.DocumentCategoryCKB, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.DocumentCategoryCB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.DocumentTypeCB, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(868, 320);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // DocumentSummaryTB
            // 
            this.DocumentSummaryTB.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.SetColumnSpan(this.DocumentSummaryTB, 5);
            this.DocumentSummaryTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentSummaryTB.Location = new System.Drawing.Point(3, 93);
            this.DocumentSummaryTB.Multiline = true;
            this.DocumentSummaryTB.Name = "DocumentSummaryTB";
            this.DocumentSummaryTB.Size = new System.Drawing.Size(862, 224);
            this.DocumentSummaryTB.TabIndex = 154;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(3, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(194, 30);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Document Type";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DocumentGroupCB
            // 
            this.DocumentGroupCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentGroupCB.FormattingEnabled = true;
            this.DocumentGroupCB.Location = new System.Drawing.Point(203, 3);
            this.DocumentGroupCB.Name = "DocumentGroupCB";
            this.DocumentGroupCB.Size = new System.Drawing.Size(213, 21);
            this.DocumentGroupCB.TabIndex = 151;
            this.DocumentGroupCB.SelectedIndexChanged += new System.EventHandler(this.DocumentGroupCB_SelectedIndexChanged);
            // 
            // DocumentTypeCB
            // 
            this.DocumentTypeCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentTypeCB.FormattingEnabled = true;
            this.DocumentTypeCB.Location = new System.Drawing.Point(203, 63);
            this.DocumentTypeCB.Name = "DocumentTypeCB";
            this.DocumentTypeCB.Size = new System.Drawing.Size(213, 21);
            this.DocumentTypeCB.TabIndex = 153;
            this.DocumentTypeCB.SelectedIndexChanged += new System.EventHandler(this.DocumentTypeCB_SelectedIndexChanged);
            // 
            // DocumentCategoryCB
            // 
            this.DocumentCategoryCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentCategoryCB.FormattingEnabled = true;
            this.DocumentCategoryCB.Location = new System.Drawing.Point(203, 33);
            this.DocumentCategoryCB.Name = "DocumentCategoryCB";
            this.DocumentCategoryCB.Size = new System.Drawing.Size(213, 21);
            this.DocumentCategoryCB.TabIndex = 152;
            this.DocumentCategoryCB.SelectedIndexChanged += new System.EventHandler(this.DocumentCategoryCB_SelectedIndexChanged);
            // 
            // DocumentGroupCKB
            // 
            this.DocumentGroupCKB.AutoSize = true;
            this.DocumentGroupCKB.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DocumentGroupCKB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentGroupCKB.Location = new System.Drawing.Point(422, 3);
            this.DocumentGroupCKB.Name = "DocumentGroupCKB";
            this.DocumentGroupCKB.Size = new System.Drawing.Size(24, 24);
            this.DocumentGroupCKB.TabIndex = 155;
            this.DocumentGroupCKB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DocumentGroupCKB.UseVisualStyleBackColor = true;
            // 
            // DocumentTypeCKB
            // 
            this.DocumentTypeCKB.AutoSize = true;
            this.DocumentTypeCKB.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DocumentTypeCKB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentTypeCKB.Location = new System.Drawing.Point(422, 33);
            this.DocumentTypeCKB.Name = "DocumentTypeCKB";
            this.DocumentTypeCKB.Size = new System.Drawing.Size(24, 24);
            this.DocumentTypeCKB.TabIndex = 156;
            this.DocumentTypeCKB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DocumentTypeCKB.UseVisualStyleBackColor = true;
            // 
            // DocumentCategoryCKB
            // 
            this.DocumentCategoryCKB.AutoSize = true;
            this.DocumentCategoryCKB.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DocumentCategoryCKB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentCategoryCKB.Location = new System.Drawing.Point(422, 63);
            this.DocumentCategoryCKB.Name = "DocumentCategoryCKB";
            this.DocumentCategoryCKB.Size = new System.Drawing.Size(24, 24);
            this.DocumentCategoryCKB.TabIndex = 157;
            this.DocumentCategoryCKB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DocumentCategoryCKB.UseVisualStyleBackColor = true;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.DoneButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 320);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 30);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(868, 350);
            this.tableLayoutPanel8.TabIndex = 146;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DataGridView, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.findFileAndArchivePanelUserControl1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(868, 665);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // findFileAndArchivePanelUserControl1
            // 
            this.findFileAndArchivePanelUserControl1.Archive = null;
            this.findFileAndArchivePanelUserControl1.File = null;
            this.findFileAndArchivePanelUserControl1.Location = new System.Drawing.Point(3, 3);
            this.findFileAndArchivePanelUserControl1.Name = "findFileAndArchivePanelUserControl1";
            this.findFileAndArchivePanelUserControl1.Size = new System.Drawing.Size(862, 70);
            this.findFileAndArchivePanelUserControl1.TabIndex = 149;
            this.findFileAndArchivePanelUserControl1.Load += new System.EventHandler(this.findFileAndArchivePanelUserControl1_Load_1);
            // 
            // previewArchiveUserControl1
            // 
            this.previewArchiveUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewArchiveUserControl1.Location = new System.Drawing.Point(0, 0);
            this.previewArchiveUserControl1.Name = "previewArchiveUserControl1";
            this.previewArchiveUserControl1.Size = new System.Drawing.Size(465, 665);
            this.previewArchiveUserControl1.TabIndex = 0;
            this.previewArchiveUserControl1.Load += new System.EventHandler(this.previewArchiveUserControl1_Load);
            // 
            // MedicalSummariesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 673);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "MedicalSummariesForm";
            this.Text = "MedicalSummariesForm";
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.PreviewPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DocumentDateDTP;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox ClientPostalCodeTB;
        private System.Windows.Forms.TextBox TreatmentCentrePostalCodeTB;
        private System.Windows.Forms.CheckBox ClientPostalCodeCKB;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Panel PreviewPanel;
        private ArchiveControls.PreviewArchiveUserControl previewArchiveUserControl1;
        private CommonControls.FindFileAndArchivePanelUserControl findFileAndArchivePanelUserControl1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.CheckBox TreatmentCentrePostalCodeCKB;
        private System.Windows.Forms.ComboBox DocumentGroupCB;
        private System.Windows.Forms.ComboBox DocumentCategoryCB;
        private System.Windows.Forms.ComboBox DocumentTypeCB;
        internal System.Windows.Forms.TextBox DocumentSummaryTB;
        private System.Windows.Forms.CheckBox DocumentGroupCKB;
        private System.Windows.Forms.CheckBox DocumentTypeCKB;
        private System.Windows.Forms.CheckBox DocumentCategoryCKB;
    }
}