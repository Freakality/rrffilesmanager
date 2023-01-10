
namespace RRFFilesManager.Controls.ArchiveControls
{
    partial class StandardBenefitsStatementUserControl
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
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PolicyClaimLimit = new RRFFilesManager.Controls.Components.CurrencyTextBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.StatementPeriodTo = new System.Windows.Forms.DateTimePicker();
            this.StatementPeriodFrom = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InsuranceCompany = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PayeeTB = new System.Windows.Forms.TextBox();
            this.DatePaidDTP = new System.Windows.Forms.DateTimePicker();
            this.MRACGSAProvidedTB = new System.Windows.Forms.TextBox();
            this.AmountTB = new RRFFilesManager.Controls.Components.CurrencyTextBox();
            this.IEAmountTB = new RRFFilesManager.Controls.Components.CurrencyTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 6;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.PolicyClaimLimit, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 5, 0);
            this.tableLayoutPanel8.Controls.Add(this.label8, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.InsuranceCompany, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 5;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.30769F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.92308F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(856, 130);
            this.tableLayoutPanel8.TabIndex = 3;
            this.tableLayoutPanel8.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel8_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "Policy/Claim Limit";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.tableLayoutPanel8.SetColumnSpan(this.panel1, 6);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 29);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel8.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(850, 36);
            this.panel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.61871F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.47482F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.53957F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.82734F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.53957F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(850, 36);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date Paid";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "M/R A/C Good, Service or Assessment Provided";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(589, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(708, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "IE Amount";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // PolicyClaimLimit
            // 
            this.PolicyClaimLimit.CurrencySymbol = "$";
            this.PolicyClaimLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PolicyClaimLimit.DollarValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.PolicyClaimLimit.Location = new System.Drawing.Point(103, 3);
            this.PolicyClaimLimit.Name = "PolicyClaimLimit";
            this.PolicyClaimLimit.Size = new System.Drawing.Size(108, 22);
            this.PolicyClaimLimit.TabIndex = 12;
            this.PolicyClaimLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PolicyClaimLimit.TextChanged += new System.EventHandler(this.PolicyClaimLimit_TextChanged);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.StatementPeriodTo, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.StatementPeriodFrom, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(628, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(228, 26);
            this.tableLayoutPanel9.TabIndex = 10;
            // 
            // StatementPeriodTo
            // 
            this.StatementPeriodTo.CustomFormat = "MM/dd/yyyy";
            this.StatementPeriodTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatementPeriodTo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatementPeriodTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StatementPeriodTo.Location = new System.Drawing.Point(117, 3);
            this.StatementPeriodTo.Name = "StatementPeriodTo";
            this.StatementPeriodTo.Size = new System.Drawing.Size(108, 22);
            this.StatementPeriodTo.TabIndex = 6;
            // 
            // StatementPeriodFrom
            // 
            this.StatementPeriodFrom.CustomFormat = "MM/dd/yyyy";
            this.StatementPeriodFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatementPeriodFrom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatementPeriodFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StatementPeriodFrom.Location = new System.Drawing.Point(3, 3);
            this.StatementPeriodFrom.Name = "StatementPeriodFrom";
            this.StatementPeriodFrom.Size = new System.Drawing.Size(108, 22);
            this.StatementPeriodFrom.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 26);
            this.label8.TabIndex = 3;
            this.label8.Text = "Statement Period";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(217, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Insurance Company";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // InsuranceCompany
            // 
            this.InsuranceCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InsuranceCompany.Location = new System.Drawing.Point(367, 3);
            this.InsuranceCompany.Name = "InsuranceCompany";
            this.InsuranceCompany.Size = new System.Drawing.Size(108, 22);
            this.InsuranceCompany.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel8.SetColumnSpan(this.panel2, 6);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 71);
            this.panel2.Name = "panel2";
            this.tableLayoutPanel8.SetRowSpan(this.panel2, 2);
            this.panel2.Size = new System.Drawing.Size(850, 56);
            this.panel2.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.38362F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.38362F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.74425F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.74425F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.74425F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Controls.Add(this.PayeeTB, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DatePaidDTP, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.MRACGSAProvidedTB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AmountTB, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.IEAmountTB, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 5, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(848, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PayeeTB
            // 
            this.PayeeTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PayeeTB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayeeTB.Location = new System.Drawing.Point(3, 3);
            this.PayeeTB.Name = "PayeeTB";
            this.PayeeTB.Size = new System.Drawing.Size(206, 22);
            this.PayeeTB.TabIndex = 1;
            // 
            // DatePaidDTP
            // 
            this.DatePaidDTP.CustomFormat = "MM/dd/yyyy";
            this.DatePaidDTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatePaidDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePaidDTP.Location = new System.Drawing.Point(427, 3);
            this.DatePaidDTP.Name = "DatePaidDTP";
            this.DatePaidDTP.Size = new System.Drawing.Size(121, 22);
            this.DatePaidDTP.TabIndex = 3;
            // 
            // MRACGSAProvidedTB
            // 
            this.MRACGSAProvidedTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MRACGSAProvidedTB.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MRACGSAProvidedTB.Location = new System.Drawing.Point(215, 3);
            this.MRACGSAProvidedTB.Name = "MRACGSAProvidedTB";
            this.MRACGSAProvidedTB.Size = new System.Drawing.Size(206, 22);
            this.MRACGSAProvidedTB.TabIndex = 2;
            // 
            // AmountTB
            // 
            this.AmountTB.CurrencySymbol = "$";
            this.AmountTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AmountTB.DollarValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.AmountTB.Location = new System.Drawing.Point(554, 3);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(121, 22);
            this.AmountTB.TabIndex = 5;
            this.AmountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IEAmountTB
            // 
            this.IEAmountTB.CurrencySymbol = "$";
            this.IEAmountTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IEAmountTB.DollarValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.IEAmountTB.Location = new System.Drawing.Point(681, 3);
            this.IEAmountTB.Name = "IEAmountTB";
            this.IEAmountTB.Size = new System.Drawing.Size(121, 22);
            this.IEAmountTB.TabIndex = 6;
            this.IEAmountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(808, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StandardBenefitsStatementUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel8);
            this.Name = "StandardBenefitsStatementUserControl";
            this.Size = new System.Drawing.Size(856, 130);
            this.Load += new System.EventHandler(this.StandardBenefitsStatementUserControl_Load);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.DateTimePicker StatementPeriodTo;
        private System.Windows.Forms.DateTimePicker StatementPeriodFrom;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Components.CurrencyTextBox AmountTB;
        private Components.CurrencyTextBox IEAmountTB;
        private System.Windows.Forms.TextBox PayeeTB;
        private System.Windows.Forms.DateTimePicker DatePaidDTP;
        private System.Windows.Forms.TextBox MRACGSAProvidedTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Components.CurrencyTextBox PolicyClaimLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InsuranceCompany;
        private System.Windows.Forms.Panel panel2;
    }
}
