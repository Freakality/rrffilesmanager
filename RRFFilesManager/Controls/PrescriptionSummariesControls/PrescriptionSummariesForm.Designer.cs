
namespace RRFFilesManager.Controls.PrescriptionSummariesControls
{
    partial class PrescriptionSummariesForm
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
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DoneButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.drugComboBox1 = new RRFFilesManager.Controls.PharmacyControls.DrugComboBox();
            this.NarcoticTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StrengthTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductNameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CreatePharmacyButton = new System.Windows.Forms.Button();
            this.pharmacyComboBox1 = new RRFFilesManager.Controls.PharmacyControls.PharmacyComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.RxFillDateTB = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.ClientPostalCodeTB = new System.Windows.Forms.TextBox();
            this.PharmacyPostalCodeTB = new System.Windows.Forms.TextBox();
            this.KeepRxFillDate = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DispenseQuantityNUD = new System.Windows.Forms.NumericUpDown();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.findFileAndArchivePanelUserControl1 = new RRFFilesManager.Controls.CommonControls.FindFileAndArchivePanelUserControl();
            this.PreviewPanel = new System.Windows.Forms.Panel();
            this.previewArchiveUserControl1 = new RRFFilesManager.Controls.ArchiveControls.PreviewArchiveUserControl();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DispenseQuantityNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.PreviewPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel5.TabIndex = 2;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.NarcoticTB, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.StrengthTB, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.ProductNameTB, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.DispenseQuantityNUD, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(868, 320);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel7.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.drugComboBox1, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(200, 90);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(275, 30);
            this.tableLayoutPanel7.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(248, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // drugComboBox1
            // 
            this.drugComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drugComboBox1.FormattingEnabled = true;
            this.drugComboBox1.Location = new System.Drawing.Point(3, 3);
            this.drugComboBox1.Name = "drugComboBox1";
            this.drugComboBox1.Size = new System.Drawing.Size(239, 21);
            this.drugComboBox1.TabIndex = 2;
            this.drugComboBox1.SelectedIndexChanged += new System.EventHandler(this.drugComboBox1_SelectedIndexChanged);
            // 
            // NarcoticTB
            // 
            this.NarcoticTB.Location = new System.Drawing.Point(203, 183);
            this.NarcoticTB.Name = "NarcoticTB";
            this.NarcoticTB.ReadOnly = true;
            this.NarcoticTB.Size = new System.Drawing.Size(96, 20);
            this.NarcoticTB.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Narcotic";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // StrengthTB
            // 
            this.StrengthTB.Location = new System.Drawing.Point(203, 153);
            this.StrengthTB.Name = "StrengthTB";
            this.StrengthTB.ReadOnly = true;
            this.StrengthTB.Size = new System.Drawing.Size(96, 20);
            this.StrengthTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Strength";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ProductNameTB
            // 
            this.ProductNameTB.Location = new System.Drawing.Point(203, 123);
            this.ProductNameTB.Name = "ProductNameTB";
            this.ProductNameTB.ReadOnly = true;
            this.ProductNameTB.Size = new System.Drawing.Size(239, 20);
            this.ProductNameTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Product Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Drug Iden No. (DIN)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rx Fill Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.Label2.Text = "PharmacyName";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Controls.Add(this.CreatePharmacyButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pharmacyComboBox1, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(200, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(398, 30);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // CreatePharmacyButton
            // 
            this.CreatePharmacyButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePharmacyButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreatePharmacyButton.Location = new System.Drawing.Point(371, 2);
            this.CreatePharmacyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.CreatePharmacyButton.Name = "CreatePharmacyButton";
            this.CreatePharmacyButton.Size = new System.Drawing.Size(24, 24);
            this.CreatePharmacyButton.TabIndex = 1;
            this.CreatePharmacyButton.Text = "+";
            this.CreatePharmacyButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CreatePharmacyButton.UseVisualStyleBackColor = true;
            // 
            // pharmacyComboBox1
            // 
            this.pharmacyComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pharmacyComboBox1.FormattingEnabled = true;
            this.pharmacyComboBox1.Location = new System.Drawing.Point(3, 3);
            this.pharmacyComboBox1.Name = "pharmacyComboBox1";
            this.pharmacyComboBox1.Size = new System.Drawing.Size(362, 21);
            this.pharmacyComboBox1.TabIndex = 2;
            this.pharmacyComboBox1.SelectedIndexChanged += new System.EventHandler(this.pharmacyComboBox1_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.RxFillDateTB, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.KeepRxFillDate, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(200, 30);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(668, 30);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // RxFillDateTB
            // 
            this.RxFillDateTB.CustomFormat = "MMM-dd-yyyy";
            this.RxFillDateTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RxFillDateTB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RxFillDateTB.Location = new System.Drawing.Point(23, 3);
            this.RxFillDateTB.Name = "RxFillDateTB";
            this.RxFillDateTB.Size = new System.Drawing.Size(218, 20);
            this.RxFillDateTB.TabIndex = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Travel Range";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.ClientPostalCodeTB, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.PharmacyPostalCodeTB, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(444, 0);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(224, 30);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // ClientPostalCodeTB
            // 
            this.ClientPostalCodeTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientPostalCodeTB.Location = new System.Drawing.Point(3, 3);
            this.ClientPostalCodeTB.Name = "ClientPostalCodeTB";
            this.ClientPostalCodeTB.ReadOnly = true;
            this.ClientPostalCodeTB.Size = new System.Drawing.Size(106, 20);
            this.ClientPostalCodeTB.TabIndex = 0;
            // 
            // PharmacyPostalCodeTB
            // 
            this.PharmacyPostalCodeTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PharmacyPostalCodeTB.Location = new System.Drawing.Point(115, 3);
            this.PharmacyPostalCodeTB.Name = "PharmacyPostalCodeTB";
            this.PharmacyPostalCodeTB.ReadOnly = true;
            this.PharmacyPostalCodeTB.Size = new System.Drawing.Size(106, 20);
            this.PharmacyPostalCodeTB.TabIndex = 1;
            // 
            // KeepRxFillDate
            // 
            this.KeepRxFillDate.AutoSize = true;
            this.KeepRxFillDate.Location = new System.Drawing.Point(3, 6);
            this.KeepRxFillDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.KeepRxFillDate.Name = "KeepRxFillDate";
            this.KeepRxFillDate.Size = new System.Drawing.Size(14, 14);
            this.KeepRxFillDate.TabIndex = 151;
            this.KeepRxFillDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.KeepRxFillDate.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 30);
            this.label8.TabIndex = 15;
            this.label8.Text = "Dispense Quantity";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DispenseQuantityNUD
            // 
            this.DispenseQuantityNUD.Location = new System.Drawing.Point(203, 63);
            this.DispenseQuantityNUD.Name = "DispenseQuantityNUD";
            this.DispenseQuantityNUD.Size = new System.Drawing.Size(96, 20);
            this.DispenseQuantityNUD.TabIndex = 16;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(3, 453);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(862, 209);
            this.DataGridView.TabIndex = 148;
            // 
            // findFileAndArchivePanelUserControl1
            // 
            this.findFileAndArchivePanelUserControl1.Archive = null;
            this.findFileAndArchivePanelUserControl1.File = null;
            this.findFileAndArchivePanelUserControl1.Location = new System.Drawing.Point(3, 3);
            this.findFileAndArchivePanelUserControl1.Name = "findFileAndArchivePanelUserControl1";
            this.findFileAndArchivePanelUserControl1.Size = new System.Drawing.Size(862, 35);
            this.findFileAndArchivePanelUserControl1.TabIndex = 149;
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
            // previewArchiveUserControl1
            // 
            this.previewArchiveUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewArchiveUserControl1.Location = new System.Drawing.Point(0, 0);
            this.previewArchiveUserControl1.Name = "previewArchiveUserControl1";
            this.previewArchiveUserControl1.Size = new System.Drawing.Size(465, 665);
            this.previewArchiveUserControl1.TabIndex = 0;
            // 
            // PrescriptionSummariesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 673);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "PrescriptionSummariesForm";
            this.Text = "PrescriptionSummariesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrescriptionSummariesForm_FormClosing);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DispenseQuantityNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.PreviewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PreviewPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button CreatePharmacyButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NarcoticTB;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StrengthTB;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProductNameTB;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox ClientPostalCodeTB;
        private System.Windows.Forms.TextBox PharmacyPostalCodeTB;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DateTimePicker RxFillDateTB;
        private System.Windows.Forms.CheckBox KeepRxFillDate;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown DispenseQuantityNUD;
        private PharmacyControls.DrugComboBox drugComboBox1;
        private PharmacyControls.PharmacyComboBox pharmacyComboBox1;
        private CommonControls.FindFileAndArchivePanelUserControl findFileAndArchivePanelUserControl1;
        private ArchiveControls.PreviewArchiveUserControl previewArchiveUserControl1;
    }
}