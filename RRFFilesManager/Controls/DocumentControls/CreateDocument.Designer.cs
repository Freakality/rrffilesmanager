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
            this.GroupBox90 = new System.Windows.Forms.GroupBox();
            this.IntakeInfo = new System.Windows.Forms.TableLayoutPanel();
            this.FileNumberTextBox = new System.Windows.Forms.TextBox();
            this.MatterTypeTextBox = new System.Windows.Forms.TextBox();
            this.TemplatesGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.ComboBox();
            this.Label74 = new System.Windows.Forms.Label();
            this.Label73 = new System.Windows.Forms.Label();
            this.TypeTemplate = new System.Windows.Forms.ComboBox();
            this.TemplateName = new System.Windows.Forms.ComboBox();
            this.CreateAndEditButton = new System.Windows.Forms.Button();
            this.PotentialClientInfoPanel = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SendPDFButton = new System.Windows.Forms.Button();
            this.SendWordButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.SaveAndCloseButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            DateOFCallLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.GroupBox90.SuspendLayout();
            this.IntakeInfo.SuspendLayout();
            this.TemplatesGroupBox.SuspendLayout();
            this.PotentialClientInfoPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            label1.Location = new System.Drawing.Point(516, 0);
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
            this.FindFileButton.Size = new System.Drawing.Size(77, 36);
            this.FindFileButton.TabIndex = 141;
            this.FindFileButton.Text = "Find File";
            this.FindFileButton.UseVisualStyleBackColor = false;
            this.FindFileButton.Click += new System.EventHandler(this.FindFileButton_Click);
            // 
            // GroupBox90
            // 
            this.GroupBox90.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox90.Controls.Add(this.IntakeInfo);
            this.GroupBox90.Controls.Add(this.FindFileButton);
            this.GroupBox90.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox90.Location = new System.Drawing.Point(15, 49);
            this.GroupBox90.Margin = new System.Windows.Forms.Padding(15, 30, 3, 3);
            this.GroupBox90.Name = "GroupBox90";
            this.GroupBox90.Size = new System.Drawing.Size(1232, 85);
            this.GroupBox90.TabIndex = 161;
            this.GroupBox90.TabStop = false;
            this.GroupBox90.Text = "File";
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
            this.IntakeInfo.Location = new System.Drawing.Point(184, 31);
            this.IntakeInfo.Name = "IntakeInfo";
            this.IntakeInfo.RowCount = 1;
            this.IntakeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.IntakeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.IntakeInfo.Size = new System.Drawing.Size(1028, 35);
            this.IntakeInfo.TabIndex = 144;
            // 
            // FileNumberTextBox
            // 
            this.FileNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileNumberTextBox.Location = new System.Drawing.Point(670, 3);
            this.FileNumberTextBox.Name = "FileNumberTextBox";
            this.FileNumberTextBox.ReadOnly = true;
            this.FileNumberTextBox.Size = new System.Drawing.Size(355, 24);
            this.FileNumberTextBox.TabIndex = 143;
            // 
            // MatterTypeTextBox
            // 
            this.MatterTypeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatterTypeTextBox.Enabled = false;
            this.MatterTypeTextBox.Location = new System.Drawing.Point(157, 3);
            this.MatterTypeTextBox.Name = "MatterTypeTextBox";
            this.MatterTypeTextBox.ReadOnly = true;
            this.MatterTypeTextBox.Size = new System.Drawing.Size(353, 24);
            this.MatterTypeTextBox.TabIndex = 142;
            // 
            // TemplatesGroupBox
            // 
            this.TemplatesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TemplatesGroupBox.Controls.Add(this.label2);
            this.TemplatesGroupBox.Controls.Add(this.Category);
            this.TemplatesGroupBox.Controls.Add(this.Label74);
            this.TemplatesGroupBox.Controls.Add(this.Label73);
            this.TemplatesGroupBox.Controls.Add(this.TypeTemplate);
            this.TemplatesGroupBox.Controls.Add(this.TemplateName);
            this.TemplatesGroupBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemplatesGroupBox.Location = new System.Drawing.Point(15, 152);
            this.TemplatesGroupBox.Margin = new System.Windows.Forms.Padding(15, 15, 3, 3);
            this.TemplatesGroupBox.Name = "TemplatesGroupBox";
            this.TemplatesGroupBox.Size = new System.Drawing.Size(1232, 132);
            this.TemplatesGroupBox.TabIndex = 159;
            this.TemplatesGroupBox.TabStop = false;
            this.TemplatesGroupBox.Text = "Templates";
            this.TemplatesGroupBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 162;
            this.label2.Text = "Category";
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Location = new System.Drawing.Point(141, 72);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(261, 24);
            this.Category.TabIndex = 161;
            this.Category.SelectedIndexChanged += new System.EventHandler(this.Category_SelectedIndexChanged);
            // 
            // Label74
            // 
            this.Label74.AutoSize = true;
            this.Label74.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label74.Location = new System.Drawing.Point(405, 53);
            this.Label74.Name = "Label74";
            this.Label74.Size = new System.Drawing.Size(102, 16);
            this.Label74.TabIndex = 160;
            this.Label74.Text = "Template Name";
            this.Label74.Click += new System.EventHandler(this.Label74_Click);
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
            this.TemplateName.Location = new System.Drawing.Point(408, 72);
            this.TemplateName.Name = "TemplateName";
            this.TemplateName.Size = new System.Drawing.Size(804, 24);
            this.TemplateName.TabIndex = 158;
            this.TemplateName.SelectedIndexChanged += new System.EventHandler(this.TemplateName_SelectedIndexChanged);
            // 
            // CreateAndEditButton
            // 
            this.CreateAndEditButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CreateAndEditButton.BackColor = System.Drawing.Color.Maroon;
            this.CreateAndEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAndEditButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CreateAndEditButton.ForeColor = System.Drawing.Color.White;
            this.CreateAndEditButton.Location = new System.Drawing.Point(615, 3);
            this.CreateAndEditButton.Name = "CreateAndEditButton";
            this.CreateAndEditButton.Size = new System.Drawing.Size(146, 36);
            this.CreateAndEditButton.TabIndex = 162;
            this.CreateAndEditButton.Text = "Create and Edit";
            this.CreateAndEditButton.UseVisualStyleBackColor = false;
            this.CreateAndEditButton.Visible = false;
            this.CreateAndEditButton.Click += new System.EventHandler(this.CreateAndEditButton_Click);
            // 
            // PotentialClientInfoPanel
            // 
            this.PotentialClientInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PotentialClientInfoPanel.BackColor = System.Drawing.Color.White;
            this.PotentialClientInfoPanel.Controls.Add(this.Cancel);
            this.PotentialClientInfoPanel.Controls.Add(this.flowLayoutPanel1);
            this.PotentialClientInfoPanel.Controls.Add(this.label9);
            this.PotentialClientInfoPanel.Controls.Add(this.GroupBox90);
            this.PotentialClientInfoPanel.Controls.Add(this.TemplatesGroupBox);
            this.PotentialClientInfoPanel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotentialClientInfoPanel.Location = new System.Drawing.Point(34, 12);
            this.PotentialClientInfoPanel.Name = "PotentialClientInfoPanel";
            this.PotentialClientInfoPanel.Size = new System.Drawing.Size(1266, 547);
            this.PotentialClientInfoPanel.TabIndex = 164;
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Cancel.BackColor = System.Drawing.Color.Maroon;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(25, 501);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(97, 36);
            this.Cancel.TabIndex = 165;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.CreateAndEditButton);
            this.flowLayoutPanel1.Controls.Add(this.SendPDFButton);
            this.flowLayoutPanel1.Controls.Add(this.SendWordButton);
            this.flowLayoutPanel1.Controls.Add(this.EditButton);
            this.flowLayoutPanel1.Controls.Add(this.SaveAndCloseButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(483, 498);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(764, 42);
            this.flowLayoutPanel1.TabIndex = 164;
            // 
            // SendPDFButton
            // 
            this.SendPDFButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SendPDFButton.BackColor = System.Drawing.Color.Red;
            this.SendPDFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendPDFButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.SendPDFButton.ForeColor = System.Drawing.Color.White;
            this.SendPDFButton.Location = new System.Drawing.Point(463, 3);
            this.SendPDFButton.Name = "SendPDFButton";
            this.SendPDFButton.Size = new System.Drawing.Size(146, 36);
            this.SendPDFButton.TabIndex = 163;
            this.SendPDFButton.Text = "Send PDF";
            this.SendPDFButton.UseVisualStyleBackColor = false;
            this.SendPDFButton.Visible = false;
            this.SendPDFButton.Click += new System.EventHandler(this.SendPDFButton_Click);
            // 
            // SendWordButton
            // 
            this.SendWordButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SendWordButton.BackColor = System.Drawing.Color.Navy;
            this.SendWordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendWordButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.SendWordButton.ForeColor = System.Drawing.Color.White;
            this.SendWordButton.Location = new System.Drawing.Point(311, 3);
            this.SendWordButton.Name = "SendWordButton";
            this.SendWordButton.Size = new System.Drawing.Size(146, 36);
            this.SendWordButton.TabIndex = 164;
            this.SendWordButton.Text = "Send Word";
            this.SendWordButton.UseVisualStyleBackColor = false;
            this.SendWordButton.Visible = false;
            this.SendWordButton.Click += new System.EventHandler(this.SendWordButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.EditButton.BackColor = System.Drawing.Color.Maroon;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(159, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(146, 36);
            this.EditButton.TabIndex = 166;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Visible = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SaveAndCloseButton.BackColor = System.Drawing.Color.Maroon;
            this.SaveAndCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAndCloseButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.SaveAndCloseButton.ForeColor = System.Drawing.Color.White;
            this.SaveAndCloseButton.Location = new System.Drawing.Point(7, 3);
            this.SaveAndCloseButton.Name = "SaveAndCloseButton";
            this.SaveAndCloseButton.Size = new System.Drawing.Size(146, 36);
            this.SaveAndCloseButton.TabIndex = 167;
            this.SaveAndCloseButton.Text = "Save and Close";
            this.SaveAndCloseButton.UseVisualStyleBackColor = false;
            this.SaveAndCloseButton.Visible = false;
            this.SaveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 26);
            this.label9.TabIndex = 2;
            this.label9.Text = "Create Document";
            // 
            // CreateDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1334, 571);
            this.Controls.Add(this.PotentialClientInfoPanel);
            this.Name = "CreateDocument";
            this.Text = "CreateDocument";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateDocument_FormClosing);
            this.Load += new System.EventHandler(this.CreateDocument_Load);
            this.GroupBox90.ResumeLayout(false);
            this.IntakeInfo.ResumeLayout(false);
            this.IntakeInfo.PerformLayout();
            this.TemplatesGroupBox.ResumeLayout(false);
            this.TemplatesGroupBox.PerformLayout();
            this.PotentialClientInfoPanel.ResumeLayout(false);
            this.PotentialClientInfoPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FindFileButton;
        internal System.Windows.Forms.GroupBox GroupBox90;
        private System.Windows.Forms.TableLayoutPanel IntakeInfo;
        private System.Windows.Forms.TextBox FileNumberTextBox;
        private System.Windows.Forms.TextBox MatterTypeTextBox;
        internal System.Windows.Forms.GroupBox TemplatesGroupBox;
        internal System.Windows.Forms.Label Label74;
        internal System.Windows.Forms.Label Label73;
        internal System.Windows.Forms.ComboBox TypeTemplate;
        internal System.Windows.Forms.ComboBox TemplateName;
        internal System.Windows.Forms.Button CreateAndEditButton;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox Category;
        internal System.Windows.Forms.Panel PotentialClientInfoPanel;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button SendPDFButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal System.Windows.Forms.Button SendWordButton;
        private System.Windows.Forms.Button Cancel;
        internal System.Windows.Forms.Button EditButton;
        internal System.Windows.Forms.Button SaveAndCloseButton;
    }
}