namespace RRFFilesManager
{
    partial class CreateDocument
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
            System.Windows.Forms.Label DateOFCallLabel;
            System.Windows.Forms.Label label1;
            this.FindFileButton = new System.Windows.Forms.Button();
            this.GroupBox32 = new System.Windows.Forms.GroupBox();
            this.Label41 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupBox90 = new System.Windows.Forms.GroupBox();
            this.IntakeInfo = new System.Windows.Forms.TableLayoutPanel();
            this.FileNumberTextBox = new System.Windows.Forms.TextBox();
            this.MatterTypeTextBox = new System.Windows.Forms.TextBox();
            this.TemplatesGroupBox = new System.Windows.Forms.GroupBox();
            this.Label74 = new System.Windows.Forms.Label();
            this.Label73 = new System.Windows.Forms.Label();
            this.TypeTemplate = new System.Windows.Forms.ComboBox();
            this.TemplateName = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            DateOFCallLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.GroupBox32.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.GroupBox90.SuspendLayout();
            this.IntakeInfo.SuspendLayout();
            this.TemplatesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateOFCallLabel
            // 
            DateOFCallLabel.AutoSize = true;
            DateOFCallLabel.Location = new System.Drawing.Point(3, 0);
            DateOFCallLabel.Name = "DateOFCallLabel";
            DateOFCallLabel.Size = new System.Drawing.Size(90, 17);
            DateOFCallLabel.TabIndex = 144;
            DateOFCallLabel.Text = "Matter Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(553, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 17);
            label1.TabIndex = 145;
            label1.Text = "File Number:";
            // 
            // FindFileButton
            // 
            this.FindFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindFileButton.BackColor = System.Drawing.Color.Maroon;
            this.FindFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindFileButton.ForeColor = System.Drawing.Color.White;
            this.FindFileButton.Location = new System.Drawing.Point(29, 31);
            this.FindFileButton.Name = "FindFileButton";
            this.FindFileButton.Size = new System.Drawing.Size(97, 36);
            this.FindFileButton.TabIndex = 141;
            this.FindFileButton.Text = "Find File";
            this.FindFileButton.UseVisualStyleBackColor = false;
            this.FindFileButton.Click += new System.EventHandler(this.FindFileButton_Click);
            // 
            // GroupBox32
            // 
            this.GroupBox32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GroupBox32.Controls.Add(this.Label41);
            this.GroupBox32.Controls.Add(this.flowLayoutPanel1);
            this.GroupBox32.Location = new System.Drawing.Point(12, 24);
            this.GroupBox32.Name = "GroupBox32";
            this.GroupBox32.Size = new System.Drawing.Size(1295, 535);
            this.GroupBox32.TabIndex = 142;
            this.GroupBox32.TabStop = false;
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label41.Location = new System.Drawing.Point(0, 0);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(203, 26);
            this.Label41.TabIndex = 3;
            this.Label41.Text = "Create Document";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.GroupBox90);
            this.flowLayoutPanel1.Controls.Add(this.TemplatesGroupBox);
            this.flowLayoutPanel1.Controls.Add(this.Submit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1289, 516);
            this.flowLayoutPanel1.TabIndex = 162;
            // 
            // GroupBox90
            // 
            this.GroupBox90.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox90.Controls.Add(this.IntakeInfo);
            this.GroupBox90.Controls.Add(this.FindFileButton);
            this.GroupBox90.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox90.Location = new System.Drawing.Point(15, 30);
            this.GroupBox90.Margin = new System.Windows.Forms.Padding(15, 30, 3, 3);
            this.GroupBox90.Name = "GroupBox90";
            this.GroupBox90.Size = new System.Drawing.Size(1252, 85);
            this.GroupBox90.TabIndex = 161;
            this.GroupBox90.TabStop = false;
            this.GroupBox90.Text = "Intake";
            // 
            // IntakeInfo
            // 
            this.IntakeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntakeInfo.ColumnCount = 4;
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.IntakeInfo.Controls.Add(DateOFCallLabel, 0, 0);
            this.IntakeInfo.Controls.Add(this.FileNumberTextBox, 3, 0);
            this.IntakeInfo.Controls.Add(this.MatterTypeTextBox, 1, 0);
            this.IntakeInfo.Controls.Add(label1, 2, 0);
            this.IntakeInfo.Location = new System.Drawing.Point(132, 31);
            this.IntakeInfo.Name = "IntakeInfo";
            this.IntakeInfo.RowCount = 1;
            this.IntakeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.IntakeInfo.Size = new System.Drawing.Size(1100, 35);
            this.IntakeInfo.TabIndex = 144;
            // 
            // FileNumberTextBox
            // 
            this.FileNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileNumberTextBox.Location = new System.Drawing.Point(718, 3);
            this.FileNumberTextBox.Name = "FileNumberTextBox";
            this.FileNumberTextBox.ReadOnly = true;
            this.FileNumberTextBox.Size = new System.Drawing.Size(379, 24);
            this.FileNumberTextBox.TabIndex = 143;
            // 
            // MatterTypeTextBox
            // 
            this.MatterTypeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatterTypeTextBox.Enabled = false;
            this.MatterTypeTextBox.Location = new System.Drawing.Point(168, 3);
            this.MatterTypeTextBox.Name = "MatterTypeTextBox";
            this.MatterTypeTextBox.ReadOnly = true;
            this.MatterTypeTextBox.Size = new System.Drawing.Size(379, 24);
            this.MatterTypeTextBox.TabIndex = 142;
            // 
            // TemplatesGroupBox
            // 
            this.TemplatesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplatesGroupBox.Controls.Add(this.Label74);
            this.TemplatesGroupBox.Controls.Add(this.Label73);
            this.TemplatesGroupBox.Controls.Add(this.TypeTemplate);
            this.TemplatesGroupBox.Controls.Add(this.TemplateName);
            this.TemplatesGroupBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemplatesGroupBox.Location = new System.Drawing.Point(15, 133);
            this.TemplatesGroupBox.Margin = new System.Windows.Forms.Padding(15, 15, 3, 3);
            this.TemplatesGroupBox.Name = "TemplatesGroupBox";
            this.TemplatesGroupBox.Size = new System.Drawing.Size(1252, 132);
            this.TemplatesGroupBox.TabIndex = 159;
            this.TemplatesGroupBox.TabStop = false;
            this.TemplatesGroupBox.Text = "Templates";
            this.TemplatesGroupBox.Visible = false;
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
            // Submit
            // 
            this.Submit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Submit.BackColor = System.Drawing.Color.Maroon;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(300, 298);
            this.Submit.Margin = new System.Windows.Forms.Padding(300, 30, 30, 3);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(658, 54);
            this.Submit.TabIndex = 156;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Visible = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // CreateDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 571);
            this.Controls.Add(this.GroupBox32);
            this.Name = "CreateDocument";
            this.Text = "CreateDocument";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateDocument_FormClosing);
            this.GroupBox32.ResumeLayout(false);
            this.GroupBox32.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.GroupBox90.ResumeLayout(false);
            this.IntakeInfo.ResumeLayout(false);
            this.IntakeInfo.PerformLayout();
            this.TemplatesGroupBox.ResumeLayout(false);
            this.TemplatesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FindFileButton;
        internal System.Windows.Forms.GroupBox GroupBox32;
        internal System.Windows.Forms.Label Label41;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.GroupBox GroupBox90;
        private System.Windows.Forms.TableLayoutPanel IntakeInfo;
        private System.Windows.Forms.TextBox FileNumberTextBox;
        private System.Windows.Forms.TextBox MatterTypeTextBox;
        internal System.Windows.Forms.GroupBox TemplatesGroupBox;
        internal System.Windows.Forms.Label Label74;
        internal System.Windows.Forms.Label Label73;
        internal System.Windows.Forms.ComboBox TypeTemplate;
        internal System.Windows.Forms.ComboBox TemplateName;
        internal System.Windows.Forms.Button Submit;
    }
}