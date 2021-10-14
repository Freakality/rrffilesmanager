
namespace RRFFilesManager.Controls.PredictorCalculatorControls
{
    partial class PredictorCalculatorForm
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContingencyFeeTypeCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.FileOpenDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ProfitPredictorCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ContingencyFeeCB = new System.Windows.Forms.ComboBox();
            this.SettlementDateTB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.FileOpenDateTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectedSettlementDateTB = new System.Windows.Forms.TextBox();
            this.ContingencyFeeTB = new System.Windows.Forms.TextBox();
            this.ProjectedSettlementAmountTB = new System.Windows.Forms.TextBox();
            this.ProjectedFeesTB = new System.Windows.Forms.TextBox();
            this.ProjectedDisbursementsTB = new System.Windows.Forms.TextBox();
            this.DeductibleAmountTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ProjectedProfitTB = new System.Windows.Forms.TextBox();
            this.BestPredictorTB = new System.Windows.Forms.TextBox();
            this.Label41 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CalculateWhatCB = new System.Windows.Forms.ComboBox();
            this.SettlementAmountTB = new RRFFilesManager.Controls.Components.CurrencyTextBox();
            this.matterTypeComboBox1 = new RRFFilesManager.Controls.SharedControls.CustomControls.MatterTypeComboBox();
            this.comissionSubTypeComboBox1 = new RRFFilesManager.Controls.SharedControls.CustomControls.ComissionSubTypeComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateButton.BackColor = System.Drawing.Color.Maroon;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculateButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.Location = new System.Drawing.Point(470, 198);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(134, 33);
            this.CalculateButton.TabIndex = 155;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::RRFFilesManager.Properties.Resources.RRFLogo;
            this.PictureBox1.Location = new System.Drawing.Point(1118, 5);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(224, 42);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 149;
            this.PictureBox1.TabStop = false;
            // 
            // ContingencyFeeTypeCB
            // 
            this.ContingencyFeeTypeCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContingencyFeeTypeCB.FormattingEnabled = true;
            this.ContingencyFeeTypeCB.Items.AddRange(new object[] {
            "Default Contigency Fee (DCF%)",
            "Choose CF%"});
            this.ContingencyFeeTypeCB.Location = new System.Drawing.Point(7, 7);
            this.ContingencyFeeTypeCB.Margin = new System.Windows.Forms.Padding(7);
            this.ContingencyFeeTypeCB.Name = "ContingencyFeeTypeCB";
            this.ContingencyFeeTypeCB.Size = new System.Drawing.Size(340, 21);
            this.ContingencyFeeTypeCB.TabIndex = 15;
            this.ContingencyFeeTypeCB.SelectedIndexChanged += new System.EventHandler(this.ContingencyFeeTypeCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "Profit Predictor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.FileOpenDateDTP, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.CalculateButton, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.ProfitPredictorCB, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.SettlementAmountTB, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.SettlementDateTB, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49953F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.50328F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(607, 319);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 39);
            this.label1.TabIndex = 159;
            this.label1.Text = "Settlement Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FileOpenDateDTP
            // 
            this.FileOpenDateDTP.CustomFormat = "MMM-dd-yyyy";
            this.FileOpenDateDTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileOpenDateDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FileOpenDateDTP.Location = new System.Drawing.Point(157, 7);
            this.FileOpenDateDTP.Margin = new System.Windows.Forms.Padding(7);
            this.FileOpenDateDTP.Name = "FileOpenDateDTP";
            this.FileOpenDateDTP.Size = new System.Drawing.Size(443, 20);
            this.FileOpenDateDTP.TabIndex = 156;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "File Open Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProfitPredictorCB
            // 
            this.ProfitPredictorCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfitPredictorCB.FormattingEnabled = true;
            this.ProfitPredictorCB.Items.AddRange(new object[] {
            "40%",
            "30%"});
            this.ProfitPredictorCB.Location = new System.Drawing.Point(157, 163);
            this.ProfitPredictorCB.Margin = new System.Windows.Forms.Padding(7);
            this.ProfitPredictorCB.Name = "ProfitPredictorCB";
            this.ProfitPredictorCB.Size = new System.Drawing.Size(443, 21);
            this.ProfitPredictorCB.TabIndex = 158;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 39);
            this.label5.TabIndex = 4;
            this.label5.Text = "Settlement Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 39);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contingency Fee %";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.ContingencyFeeTypeCB, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ContingencyFeeCB, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(150, 78);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(457, 39);
            this.tableLayoutPanel2.TabIndex = 157;
            // 
            // ContingencyFeeCB
            // 
            this.ContingencyFeeCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContingencyFeeCB.FormattingEnabled = true;
            this.ContingencyFeeCB.Items.AddRange(new object[] {
            "15.0%",
            "20.0%"});
            this.ContingencyFeeCB.Location = new System.Drawing.Point(361, 7);
            this.ContingencyFeeCB.Margin = new System.Windows.Forms.Padding(7);
            this.ContingencyFeeCB.Name = "ContingencyFeeCB";
            this.ContingencyFeeCB.Size = new System.Drawing.Size(89, 21);
            this.ContingencyFeeCB.TabIndex = 155;
            this.ContingencyFeeCB.Visible = false;
            // 
            // SettlementDateTB
            // 
            this.SettlementDateTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettlementDateTB.Enabled = false;
            this.SettlementDateTB.Location = new System.Drawing.Point(157, 46);
            this.SettlementDateTB.Margin = new System.Windows.Forms.Padding(7);
            this.SettlementDateTB.Name = "SettlementDateTB";
            this.SettlementDateTB.Size = new System.Drawing.Size(443, 20);
            this.SettlementDateTB.TabIndex = 160;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 277);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1326, 384);
            this.tableLayoutPanel4.TabIndex = 153;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.label12, 0, 8);
            this.tableLayoutPanel6.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.label15, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.FileOpenDateTB, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.ProjectedSettlementDateTB, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.ContingencyFeeTB, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.ProjectedSettlementAmountTB, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.ProjectedFeesTB, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.ProjectedDisbursementsTB, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.DeductibleAmountTB, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.label9, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 7);
            this.tableLayoutPanel6.Controls.Add(this.ProjectedProfitTB, 1, 7);
            this.tableLayoutPanel6.Controls.Add(this.BestPredictorTB, 1, 8);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(716, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 9;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11037F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11371F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11371F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(607, 378);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 329);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 49);
            this.label12.TabIndex = 15;
            this.label12.Text = "Best Predictor";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 246);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 41);
            this.label10.TabIndex = 13;
            this.label10.Text = "Deductible Amount";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(5, 41);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 41);
            this.label15.TabIndex = 2;
            this.label15.Text = "Projected Settlement Date";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(5, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 41);
            this.label16.TabIndex = 0;
            this.label16.Text = "File Open Date";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FileOpenDateTB
            // 
            this.FileOpenDateTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileOpenDateTB.Enabled = false;
            this.FileOpenDateTB.Location = new System.Drawing.Point(157, 7);
            this.FileOpenDateTB.Margin = new System.Windows.Forms.Padding(7);
            this.FileOpenDateTB.Name = "FileOpenDateTB";
            this.FileOpenDateTB.Size = new System.Drawing.Size(443, 20);
            this.FileOpenDateTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contingency Fee %";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProjectedSettlementDateTB
            // 
            this.ProjectedSettlementDateTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectedSettlementDateTB.Enabled = false;
            this.ProjectedSettlementDateTB.Location = new System.Drawing.Point(157, 48);
            this.ProjectedSettlementDateTB.Margin = new System.Windows.Forms.Padding(7);
            this.ProjectedSettlementDateTB.Name = "ProjectedSettlementDateTB";
            this.ProjectedSettlementDateTB.Size = new System.Drawing.Size(443, 20);
            this.ProjectedSettlementDateTB.TabIndex = 4;
            // 
            // ContingencyFeeTB
            // 
            this.ContingencyFeeTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContingencyFeeTB.Enabled = false;
            this.ContingencyFeeTB.Location = new System.Drawing.Point(157, 89);
            this.ContingencyFeeTB.Margin = new System.Windows.Forms.Padding(7);
            this.ContingencyFeeTB.Name = "ContingencyFeeTB";
            this.ContingencyFeeTB.Size = new System.Drawing.Size(443, 20);
            this.ContingencyFeeTB.TabIndex = 5;
            // 
            // ProjectedSettlementAmountTB
            // 
            this.ProjectedSettlementAmountTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectedSettlementAmountTB.Enabled = false;
            this.ProjectedSettlementAmountTB.Location = new System.Drawing.Point(157, 130);
            this.ProjectedSettlementAmountTB.Margin = new System.Windows.Forms.Padding(7);
            this.ProjectedSettlementAmountTB.Name = "ProjectedSettlementAmountTB";
            this.ProjectedSettlementAmountTB.Size = new System.Drawing.Size(443, 20);
            this.ProjectedSettlementAmountTB.TabIndex = 6;
            // 
            // ProjectedFeesTB
            // 
            this.ProjectedFeesTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectedFeesTB.Enabled = false;
            this.ProjectedFeesTB.Location = new System.Drawing.Point(157, 171);
            this.ProjectedFeesTB.Margin = new System.Windows.Forms.Padding(7);
            this.ProjectedFeesTB.Name = "ProjectedFeesTB";
            this.ProjectedFeesTB.Size = new System.Drawing.Size(443, 20);
            this.ProjectedFeesTB.TabIndex = 7;
            // 
            // ProjectedDisbursementsTB
            // 
            this.ProjectedDisbursementsTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectedDisbursementsTB.Enabled = false;
            this.ProjectedDisbursementsTB.Location = new System.Drawing.Point(157, 212);
            this.ProjectedDisbursementsTB.Margin = new System.Windows.Forms.Padding(7);
            this.ProjectedDisbursementsTB.Name = "ProjectedDisbursementsTB";
            this.ProjectedDisbursementsTB.Size = new System.Drawing.Size(443, 20);
            this.ProjectedDisbursementsTB.TabIndex = 8;
            // 
            // DeductibleAmountTB
            // 
            this.DeductibleAmountTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeductibleAmountTB.Enabled = false;
            this.DeductibleAmountTB.Location = new System.Drawing.Point(157, 253);
            this.DeductibleAmountTB.Margin = new System.Windows.Forms.Padding(7);
            this.DeductibleAmountTB.Name = "DeductibleAmountTB";
            this.DeductibleAmountTB.Size = new System.Drawing.Size(443, 20);
            this.DeductibleAmountTB.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 41);
            this.label7.TabIndex = 10;
            this.label7.Text = "Projected Settlement Amount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 164);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 41);
            this.label8.TabIndex = 11;
            this.label8.Text = "Projected Fees";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 205);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 41);
            this.label9.TabIndex = 12;
            this.label9.Text = "Projected Disbursements";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 287);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 42);
            this.label11.TabIndex = 14;
            this.label11.Text = "Projected Profit %";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProjectedProfitTB
            // 
            this.ProjectedProfitTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectedProfitTB.Enabled = false;
            this.ProjectedProfitTB.Location = new System.Drawing.Point(157, 294);
            this.ProjectedProfitTB.Margin = new System.Windows.Forms.Padding(7);
            this.ProjectedProfitTB.Name = "ProjectedProfitTB";
            this.ProjectedProfitTB.Size = new System.Drawing.Size(443, 20);
            this.ProjectedProfitTB.TabIndex = 16;
            // 
            // BestPredictorTB
            // 
            this.BestPredictorTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BestPredictorTB.Enabled = false;
            this.BestPredictorTB.Location = new System.Drawing.Point(157, 336);
            this.BestPredictorTB.Margin = new System.Windows.Forms.Padding(7);
            this.BestPredictorTB.Name = "BestPredictorTB";
            this.BestPredictorTB.Size = new System.Drawing.Size(443, 20);
            this.BestPredictorTB.TabIndex = 17;
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label41.Location = new System.Drawing.Point(16, 15);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(365, 26);
            this.Label41.TabIndex = 150;
            this.Label41.Text = "File Opening Predictor Calculator";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(336, 92);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 53);
            this.tableLayoutPanel1.TabIndex = 152;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.matterTypeComboBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Matter Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comissionSubTypeComboBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(336, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matter Sub-Type";
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Maroon;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(935, 10);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(152, 37);
            this.HomeButton.TabIndex = 151;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CalculateWhatCB);
            this.groupBox3.Location = new System.Drawing.Point(502, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 47);
            this.groupBox3.TabIndex = 154;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculate What";
            // 
            // CalculateWhatCB
            // 
            this.CalculateWhatCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalculateWhatCB.FormattingEnabled = true;
            this.CalculateWhatCB.Items.AddRange(new object[] {
            "Profit Predictor",
            "Settlement Amount",
            "Settlement Date"});
            this.CalculateWhatCB.Location = new System.Drawing.Point(3, 16);
            this.CalculateWhatCB.Name = "CalculateWhatCB";
            this.CalculateWhatCB.Size = new System.Drawing.Size(321, 21);
            this.CalculateWhatCB.TabIndex = 0;
            this.CalculateWhatCB.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SettlementAmountTB
            // 
            this.SettlementAmountTB.CurrencySymbol = "$";
            this.SettlementAmountTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettlementAmountTB.Location = new System.Drawing.Point(157, 124);
            this.SettlementAmountTB.Margin = new System.Windows.Forms.Padding(7);
            this.SettlementAmountTB.Name = "SettlementAmountTB";
            this.SettlementAmountTB.Size = new System.Drawing.Size(443, 20);
            this.SettlementAmountTB.TabIndex = 155;
            this.SettlementAmountTB.Text = "$ ";
            this.SettlementAmountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // matterTypeComboBox1
            // 
            this.matterTypeComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matterTypeComboBox1.FormattingEnabled = true;
            this.matterTypeComboBox1.Location = new System.Drawing.Point(3, 16);
            this.matterTypeComboBox1.Name = "matterTypeComboBox1";
            this.matterTypeComboBox1.Size = new System.Drawing.Size(321, 21);
            this.matterTypeComboBox1.TabIndex = 0;
            this.matterTypeComboBox1.SelectedIndexChanged += new System.EventHandler(this.matterTypeComboBox1_SelectedIndexChanged);
            // 
            // comissionSubTypeComboBox1
            // 
            this.comissionSubTypeComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comissionSubTypeComboBox1.FormattingEnabled = true;
            this.comissionSubTypeComboBox1.Location = new System.Drawing.Point(3, 16);
            this.comissionSubTypeComboBox1.MatterType = null;
            this.comissionSubTypeComboBox1.Name = "comissionSubTypeComboBox1";
            this.comissionSubTypeComboBox1.Size = new System.Drawing.Size(321, 21);
            this.comissionSubTypeComboBox1.TabIndex = 0;
            // 
            // PredictorCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 673);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.Label41);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.HomeButton);
            this.Name = "PredictorCalculatorForm";
            this.Text = "PredictorCalculatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CalculateButton;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ComboBox ContingencyFeeTypeCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox FileOpenDateTB;
        internal System.Windows.Forms.Label Label41;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private SharedControls.CustomControls.MatterTypeComboBox matterTypeComboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CalculateWhatCB;
        private System.Windows.Forms.DateTimePicker FileOpenDateDTP;
        private System.Windows.Forms.ComboBox ContingencyFeeCB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Components.CurrencyTextBox SettlementAmountTB;
        private System.Windows.Forms.ComboBox ProfitPredictorCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SettlementDateTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProjectedSettlementDateTB;
        private System.Windows.Forms.TextBox ContingencyFeeTB;
        private System.Windows.Forms.TextBox ProjectedSettlementAmountTB;
        private System.Windows.Forms.TextBox ProjectedFeesTB;
        private System.Windows.Forms.TextBox ProjectedDisbursementsTB;
        private System.Windows.Forms.TextBox DeductibleAmountTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ProjectedProfitTB;
        private System.Windows.Forms.TextBox BestPredictorTB;
        private SharedControls.CustomControls.ComissionSubTypeComboBox comissionSubTypeComboBox1;
    }
}