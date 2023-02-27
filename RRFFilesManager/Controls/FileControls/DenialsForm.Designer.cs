
namespace RRFFilesManager.Controls.FileControls
{
    partial class DenialsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label110 = new System.Windows.Forms.Label();
            this.CboxStatus = new System.Windows.Forms.ComboBox();
            this.btnSaveDenials = new System.Windows.Forms.Button();
            this.Label109 = new System.Windows.Forms.Label();
            this.CboxDenialBenefit = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLimitationDate = new System.Windows.Forms.TextBox();
            this.txtDateDenied = new System.Windows.Forms.TextBox();
            this.txtTreatmentPlanDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtDisputeRelateTo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RangeTo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RangeFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServicesType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtServicesProvider = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateDenied = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpTreatmentPlanDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmountDispute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Label110);
            this.panel1.Controls.Add(this.CboxStatus);
            this.panel1.Controls.Add(this.btnSaveDenials);
            this.panel1.Controls.Add(this.Label109);
            this.panel1.Controls.Add(this.CboxDenialBenefit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 67);
            this.panel1.TabIndex = 0;
            // 
            // Label110
            // 
            this.Label110.AutoSize = true;
            this.Label110.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label110.ForeColor = System.Drawing.Color.White;
            this.Label110.Location = new System.Drawing.Point(216, 25);
            this.Label110.Name = "Label110";
            this.Label110.Size = new System.Drawing.Size(49, 18);
            this.Label110.TabIndex = 8;
            this.Label110.Text = "Status";
            // 
            // CboxStatus
            // 
            this.CboxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxStatus.FormattingEnabled = true;
            this.CboxStatus.Items.AddRange(new object[] {
            "Pending",
            "Withdrawn",
            "Filed for LAT",
            "Claiming in Tort",
            "Settled",
            "Not Pursuing"});
            this.CboxStatus.Location = new System.Drawing.Point(277, 22);
            this.CboxStatus.Name = "CboxStatus";
            this.CboxStatus.Size = new System.Drawing.Size(113, 24);
            this.CboxStatus.TabIndex = 9;
            // 
            // btnSaveDenials
            // 
            this.btnSaveDenials.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveDenials.BackColor = System.Drawing.Color.Black;
            this.btnSaveDenials.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDenials.ForeColor = System.Drawing.Color.White;
            this.btnSaveDenials.Location = new System.Drawing.Point(687, 17);
            this.btnSaveDenials.Name = "btnSaveDenials";
            this.btnSaveDenials.Size = new System.Drawing.Size(106, 32);
            this.btnSaveDenials.TabIndex = 10;
            this.btnSaveDenials.Text = "Save";
            this.btnSaveDenials.UseVisualStyleBackColor = false;
            this.btnSaveDenials.Click += new System.EventHandler(this.btnSaveDenials_Click);
            // 
            // Label109
            // 
            this.Label109.AutoSize = true;
            this.Label109.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label109.ForeColor = System.Drawing.Color.White;
            this.Label109.Location = new System.Drawing.Point(24, 25);
            this.Label109.Name = "Label109";
            this.Label109.Size = new System.Drawing.Size(58, 18);
            this.Label109.TabIndex = 6;
            this.Label109.Text = "Benefit";
            // 
            // CboxDenialBenefit
            // 
            this.CboxDenialBenefit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboxDenialBenefit.FormattingEnabled = true;
            this.CboxDenialBenefit.Items.AddRange(new object[] {
            "IRB - Pre-104",
            "IRB - Post 104",
            "Non-Earner",
            "Care Giver",
            "Med/Rehab",
            "AC",
            "HH",
            "MIG",
            "CAT "});
            this.CboxDenialBenefit.Location = new System.Drawing.Point(85, 22);
            this.CboxDenialBenefit.Name = "CboxDenialBenefit";
            this.CboxDenialBenefit.Size = new System.Drawing.Size(113, 24);
            this.CboxDenialBenefit.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtLimitationDate);
            this.panel2.Controls.Add(this.txtDateDenied);
            this.panel2.Controls.Add(this.txtTreatmentPlanDate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtNotes);
            this.panel2.Controls.Add(this.txtDisputeRelateTo);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.RangeTo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.RangeFrom);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtServicesType);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TxtServicesProvider);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtpDateDenied);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpTreatmentPlanDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtAmountDispute);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 383);
            this.panel2.TabIndex = 1;
            // 
            // txtLimitationDate
            // 
            this.txtLimitationDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLimitationDate.Location = new System.Drawing.Point(623, 83);
            this.txtLimitationDate.Name = "txtLimitationDate";
            this.txtLimitationDate.ReadOnly = true;
            this.txtLimitationDate.Size = new System.Drawing.Size(123, 26);
            this.txtLimitationDate.TabIndex = 22;
            // 
            // txtDateDenied
            // 
            this.txtDateDenied.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateDenied.Location = new System.Drawing.Point(623, 50);
            this.txtDateDenied.Name = "txtDateDenied";
            this.txtDateDenied.ReadOnly = true;
            this.txtDateDenied.Size = new System.Drawing.Size(123, 26);
            this.txtDateDenied.TabIndex = 21;
            // 
            // txtTreatmentPlanDate
            // 
            this.txtTreatmentPlanDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTreatmentPlanDate.Location = new System.Drawing.Point(623, 16);
            this.txtTreatmentPlanDate.Name = "txtTreatmentPlanDate";
            this.txtTreatmentPlanDate.ReadOnly = true;
            this.txtTreatmentPlanDate.Size = new System.Drawing.Size(123, 26);
            this.txtTreatmentPlanDate.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(388, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.LightGray;
            this.txtNotes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(3, 275);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(792, 103);
            this.txtNotes.TabIndex = 18;
            // 
            // txtDisputeRelateTo
            // 
            this.txtDisputeRelateTo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisputeRelateTo.Location = new System.Drawing.Point(211, 219);
            this.txtDisputeRelateTo.Name = "txtDisputeRelateTo";
            this.txtDisputeRelateTo.Size = new System.Drawing.Size(123, 26);
            this.txtDisputeRelateTo.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Dispute relate to";
            // 
            // RangeTo
            // 
            this.RangeTo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RangeTo.Location = new System.Drawing.Point(211, 178);
            this.RangeTo.Name = "RangeTo";
            this.RangeTo.Size = new System.Drawing.Size(123, 26);
            this.RangeTo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Range To";
            // 
            // RangeFrom
            // 
            this.RangeFrom.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RangeFrom.Location = new System.Drawing.Point(211, 139);
            this.RangeFrom.Name = "RangeFrom";
            this.RangeFrom.Size = new System.Drawing.Size(123, 26);
            this.RangeFrom.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Range From";
            // 
            // txtServicesType
            // 
            this.txtServicesType.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicesType.Location = new System.Drawing.Point(211, 99);
            this.txtServicesType.Name = "txtServicesType";
            this.txtServicesType.Size = new System.Drawing.Size(123, 26);
            this.txtServicesType.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Services of type";
            // 
            // TxtServicesProvider
            // 
            this.TxtServicesProvider.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtServicesProvider.Location = new System.Drawing.Point(211, 59);
            this.TxtServicesProvider.Name = "TxtServicesProvider";
            this.TxtServicesProvider.Size = new System.Drawing.Size(123, 26);
            this.TxtServicesProvider.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Name of services provider";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(442, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Limitation Date";
            // 
            // dtpDateDenied
            // 
            this.dtpDateDenied.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtpDateDenied.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateDenied.Location = new System.Drawing.Point(749, 50);
            this.dtpDateDenied.Name = "dtpDateDenied";
            this.dtpDateDenied.Size = new System.Drawing.Size(10, 26);
            this.dtpDateDenied.TabIndex = 5;
            this.dtpDateDenied.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date Denied";
            // 
            // dtpTreatmentPlanDate
            // 
            this.dtpTreatmentPlanDate.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dtpTreatmentPlanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTreatmentPlanDate.Location = new System.Drawing.Point(749, 16);
            this.dtpTreatmentPlanDate.Name = "dtpTreatmentPlanDate";
            this.dtpTreatmentPlanDate.Size = new System.Drawing.Size(10, 26);
            this.dtpTreatmentPlanDate.TabIndex = 3;
            this.dtpTreatmentPlanDate.ValueChanged += new System.EventHandler(this.dtp_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Treatment plan date";
            // 
            // txtAmountDispute
            // 
            this.txtAmountDispute.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountDispute.Location = new System.Drawing.Point(211, 20);
            this.txtAmountDispute.Name = "txtAmountDispute";
            this.txtAmountDispute.Size = new System.Drawing.Size(123, 26);
            this.txtAmountDispute.TabIndex = 1;
            this.txtAmountDispute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount in Dispute";
            // 
            // DenialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "DenialsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Denials";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label Label110;
        internal System.Windows.Forms.ComboBox CboxStatus;
        internal System.Windows.Forms.Label Label109;
        internal System.Windows.Forms.ComboBox CboxDenialBenefit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmountDispute;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDateDenied;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpTreatmentPlanDate;
        private System.Windows.Forms.TextBox RangeTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RangeFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtServicesType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtServicesProvider;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveDenials;
        private System.Windows.Forms.TextBox txtLimitationDate;
        private System.Windows.Forms.TextBox txtDateDenied;
        private System.Windows.Forms.TextBox txtTreatmentPlanDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtDisputeRelateTo;
        private System.Windows.Forms.Label label9;
    }
}