
namespace RRFFilesManager.Controls.ArchiveControls
{
    partial class MedicalRecordWithAmountUserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FacilityName = new System.Windows.Forms.TextBox();
            this.HealthcarePractitioner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeOfAssessment = new System.Windows.Forms.TextBox();
            this.TreatmentAmount = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.FacilityName, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.HealthcarePractitioner, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.TypeOfAssessment, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.TreatmentAmount, 1, 3);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 5;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(868, 130);
            this.tableLayoutPanel8.TabIndex = 6;
            this.tableLayoutPanel8.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel8_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Facility Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Healthcare Practitioner";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FacilityName
            // 
            this.FacilityName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacilityName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacilityName.Location = new System.Drawing.Point(153, 3);
            this.FacilityName.Name = "FacilityName";
            this.FacilityName.Size = new System.Drawing.Size(278, 22);
            this.FacilityName.TabIndex = 12;
            this.FacilityName.TextChanged += new System.EventHandler(this.FacilityName_TextChanged);
            // 
            // HealthcarePractitioner
            // 
            this.HealthcarePractitioner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HealthcarePractitioner.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthcarePractitioner.Location = new System.Drawing.Point(153, 29);
            this.HealthcarePractitioner.Name = "HealthcarePractitioner";
            this.HealthcarePractitioner.Size = new System.Drawing.Size(278, 22);
            this.HealthcarePractitioner.TabIndex = 13;
            this.HealthcarePractitioner.TextChanged += new System.EventHandler(this.HealthcarePractitioner_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Type Of Assessment";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Treatment Amount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TypeOfAssessment
            // 
            this.TypeOfAssessment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeOfAssessment.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeOfAssessment.Location = new System.Drawing.Point(153, 55);
            this.TypeOfAssessment.Name = "TypeOfAssessment";
            this.TypeOfAssessment.Size = new System.Drawing.Size(278, 22);
            this.TypeOfAssessment.TabIndex = 16;
            this.TypeOfAssessment.TextChanged += new System.EventHandler(this.TypeOfAssessment_TextChanged);
            // 
            // TreatmentAmount
            // 
            this.TreatmentAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreatmentAmount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreatmentAmount.Location = new System.Drawing.Point(153, 81);
            this.TreatmentAmount.Name = "TreatmentAmount";
            this.TreatmentAmount.Size = new System.Drawing.Size(278, 22);
            this.TreatmentAmount.TabIndex = 17;
            this.TreatmentAmount.TextChanged += new System.EventHandler(this.TreatmentAmount_TextChanged);
            // 
            // MedicalRecordWithAmountUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel8);
            this.Name = "MedicalRecordWithAmountUserControl";
            this.Size = new System.Drawing.Size(868, 130);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FacilityName;
        private System.Windows.Forms.TextBox HealthcarePractitioner;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TypeOfAssessment;
        private System.Windows.Forms.TextBox TreatmentAmount;
    }
}
