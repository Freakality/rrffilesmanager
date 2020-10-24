namespace RRFFilesManager.IntakeForm
{
    partial class NextSteps
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
            this.Submit = new System.Windows.Forms.Button();
            this.Label74 = new System.Windows.Forms.Label();
            this.Label73 = new System.Windows.Forms.Label();
            this.InvokeCYP = new System.Windows.Forms.RadioButton();
            this.TypeTemplate = new System.Windows.Forms.ComboBox();
            this.TemplateName = new System.Windows.Forms.ComboBox();
            this.InvokeCIP = new System.Windows.Forms.RadioButton();
            this.PAHProcess = new System.Windows.Forms.RadioButton();
            this.Label41 = new System.Windows.Forms.Label();
            this.GroupBox90 = new System.Windows.Forms.GroupBox();
            this.MVATemplatesGroupBox = new System.Windows.Forms.GroupBox();
            this.GroupBox32 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.DocumentPreview = new System.Windows.Forms.Button();
            this.GroupBox90.SuspendLayout();
            this.MVATemplatesGroupBox.SuspendLayout();
            this.GroupBox32.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Submit.BackColor = System.Drawing.Color.Maroon;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(300, 313);
            this.Submit.Margin = new System.Windows.Forms.Padding(300, 30, 30, 3);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(658, 54);
            this.Submit.TabIndex = 156;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Visible = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Label74
            // 
            this.Label74.AutoSize = true;
            this.Label74.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label74.Location = new System.Drawing.Point(172, 52);
            this.Label74.Name = "Label74";
            this.Label74.Size = new System.Drawing.Size(102, 16);
            this.Label74.TabIndex = 160;
            this.Label74.Text = "Template Name";
            // 
            // Label73
            // 
            this.Label73.AutoSize = true;
            this.Label73.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label73.Location = new System.Drawing.Point(26, 52);
            this.Label73.Name = "Label73";
            this.Label73.Size = new System.Drawing.Size(109, 16);
            this.Label73.TabIndex = 159;
            this.Label73.Text = "Type of Template";
            // 
            // InvokeCYP
            // 
            this.InvokeCYP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvokeCYP.AutoSize = true;
            this.InvokeCYP.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvokeCYP.Location = new System.Drawing.Point(517, 40);
            this.InvokeCYP.Name = "InvokeCYP";
            this.InvokeCYP.Size = new System.Drawing.Size(210, 26);
            this.InvokeCYP.TabIndex = 1;
            this.InvokeCYP.TabStop = true;
            this.InvokeCYP.Text = "Invoke CYA Process";
            this.InvokeCYP.UseVisualStyleBackColor = true;
            this.InvokeCYP.CheckedChanged += new System.EventHandler(this.InvokeCYP_CheckedChanged);
            // 
            // TypeTemplate
            // 
            this.TypeTemplate.FormattingEnabled = true;
            this.TypeTemplate.Location = new System.Drawing.Point(29, 72);
            this.TypeTemplate.Name = "TypeTemplate";
            this.TypeTemplate.Size = new System.Drawing.Size(106, 24);
            this.TypeTemplate.TabIndex = 157;
            this.TypeTemplate.SelectedIndexChanged += new System.EventHandler(this.TypeTemplate_SelectedIndexChanged);
            // 
            // TemplateName
            // 
            this.TemplateName.FormattingEnabled = true;
            this.TemplateName.Location = new System.Drawing.Point(175, 72);
            this.TemplateName.Name = "TemplateName";
            this.TemplateName.Size = new System.Drawing.Size(1057, 24);
            this.TemplateName.TabIndex = 158;
            this.TemplateName.SelectedIndexChanged += new System.EventHandler(this.TemplateName_SelectedIndexChanged);
            // 
            // InvokeCIP
            // 
            this.InvokeCIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvokeCIP.AutoSize = true;
            this.InvokeCIP.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvokeCIP.Location = new System.Drawing.Point(29, 40);
            this.InvokeCIP.Name = "InvokeCIP";
            this.InvokeCIP.Size = new System.Drawing.Size(285, 26);
            this.InvokeCIP.TabIndex = 0;
            this.InvokeCIP.TabStop = true;
            this.InvokeCIP.Text = "Invoke Client Intake Process";
            this.InvokeCIP.UseVisualStyleBackColor = true;
            this.InvokeCIP.CheckedChanged += new System.EventHandler(this.InvokeCIP_CheckedChanged);
            // 
            // PAHProcess
            // 
            this.PAHProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PAHProcess.AutoSize = true;
            this.PAHProcess.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAHProcess.Location = new System.Drawing.Point(1004, 40);
            this.PAHProcess.Name = "PAHProcess";
            this.PAHProcess.Size = new System.Drawing.Size(228, 26);
            this.PAHProcess.TabIndex = 160;
            this.PAHProcess.TabStop = true;
            this.PAHProcess.Text = "Print and Hold Process";
            this.PAHProcess.UseVisualStyleBackColor = true;
            this.PAHProcess.CheckedChanged += new System.EventHandler(this.PAHProcess_CheckedChanged);
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label41.Location = new System.Drawing.Point(0, 0);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(124, 26);
            this.Label41.TabIndex = 3;
            this.Label41.Text = "Next Steps";
            // 
            // GroupBox90
            // 
            this.GroupBox90.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox90.Controls.Add(this.InvokeCIP);
            this.GroupBox90.Controls.Add(this.PAHProcess);
            this.GroupBox90.Controls.Add(this.InvokeCYP);
            this.GroupBox90.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox90.Location = new System.Drawing.Point(15, 30);
            this.GroupBox90.Margin = new System.Windows.Forms.Padding(15, 30, 3, 3);
            this.GroupBox90.Name = "GroupBox90";
            this.GroupBox90.Size = new System.Drawing.Size(1252, 100);
            this.GroupBox90.TabIndex = 161;
            this.GroupBox90.TabStop = false;
            this.GroupBox90.Text = "Steps";
            // 
            // MVATemplatesGroupBox
            // 
            this.MVATemplatesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MVATemplatesGroupBox.Controls.Add(this.Label74);
            this.MVATemplatesGroupBox.Controls.Add(this.Label73);
            this.MVATemplatesGroupBox.Controls.Add(this.TypeTemplate);
            this.MVATemplatesGroupBox.Controls.Add(this.TemplateName);
            this.MVATemplatesGroupBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MVATemplatesGroupBox.Location = new System.Drawing.Point(15, 148);
            this.MVATemplatesGroupBox.Margin = new System.Windows.Forms.Padding(15, 15, 3, 3);
            this.MVATemplatesGroupBox.Name = "MVATemplatesGroupBox";
            this.MVATemplatesGroupBox.Size = new System.Drawing.Size(1252, 132);
            this.MVATemplatesGroupBox.TabIndex = 159;
            this.MVATemplatesGroupBox.TabStop = false;
            this.MVATemplatesGroupBox.Text = "Templates";
            this.MVATemplatesGroupBox.Visible = false;
            this.MVATemplatesGroupBox.Enter += new System.EventHandler(this.MVATemplatesGroupBox_Enter);
            // 
            // GroupBox32
            // 
            this.GroupBox32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupBox32.Controls.Add(this.Label41);
            this.GroupBox32.Controls.Add(this.flowLayoutPanel1);
            this.GroupBox32.Location = new System.Drawing.Point(28, 38);
            this.GroupBox32.Name = "GroupBox32";
            this.GroupBox32.Size = new System.Drawing.Size(1295, 535);
            this.GroupBox32.TabIndex = 3;
            this.GroupBox32.TabStop = false;
            this.GroupBox32.Enter += new System.EventHandler(this.GroupBox32_Enter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.GroupBox90);
            this.flowLayoutPanel1.Controls.Add(this.MVATemplatesGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.Submit);
            this.flowLayoutPanel1.Controls.Add(this.DocumentPreview);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1289, 516);
            this.flowLayoutPanel1.TabIndex = 162;
            // 
            // DocumentPreview
            // 
            this.DocumentPreview.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DocumentPreview.BackColor = System.Drawing.Color.DarkBlue;
            this.DocumentPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DocumentPreview.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentPreview.ForeColor = System.Drawing.Color.White;
            this.DocumentPreview.Location = new System.Drawing.Point(520, 440);
            this.DocumentPreview.Margin = new System.Windows.Forms.Padding(520, 70, 3, 3);
            this.DocumentPreview.Name = "DocumentPreview";
            this.DocumentPreview.Size = new System.Drawing.Size(220, 54);
            this.DocumentPreview.TabIndex = 162;
            this.DocumentPreview.Text = "Document Preview";
            this.DocumentPreview.UseVisualStyleBackColor = false;
            this.DocumentPreview.Click += new System.EventHandler(this.DocumentPreview_Click);
            // 
            // NextSteps
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GroupBox32);
            this.Name = "NextSteps";
            this.Size = new System.Drawing.Size(1350, 610);
            this.Load += new System.EventHandler(this.NextSteps_Load);
            this.GroupBox90.ResumeLayout(false);
            this.GroupBox90.PerformLayout();
            this.MVATemplatesGroupBox.ResumeLayout(false);
            this.MVATemplatesGroupBox.PerformLayout();
            this.GroupBox32.ResumeLayout(false);
            this.GroupBox32.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button Submit;
        internal System.Windows.Forms.Label Label74;
        internal System.Windows.Forms.Label Label73;
        internal System.Windows.Forms.RadioButton InvokeCYP;
        internal System.Windows.Forms.ComboBox TypeTemplate;
        internal System.Windows.Forms.ComboBox TemplateName;
        internal System.Windows.Forms.RadioButton InvokeCIP;
        internal System.Windows.Forms.RadioButton PAHProcess;
        internal System.Windows.Forms.Label Label41;
        internal System.Windows.Forms.GroupBox GroupBox90;
        internal System.Windows.Forms.GroupBox MVATemplatesGroupBox;
        internal System.Windows.Forms.GroupBox GroupBox32;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button DocumentPreview;
    }
}
