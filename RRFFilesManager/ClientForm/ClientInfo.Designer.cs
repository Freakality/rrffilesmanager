namespace RRFFilesManager.ClientForm
{
    partial class ClientInfo
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
            System.Windows.Forms.Label Label117;
            System.Windows.Forms.Label Label115;
            System.Windows.Forms.Label CBoxClientNameLabel;
            System.Windows.Forms.Label Label116;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInfo));
            this.LinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.GroupBox32 = new System.Windows.Forms.GroupBox();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.SINNumberTextBox = new System.Windows.Forms.TextBox();
            this.HealthcardNumberTextBox = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.FindClientButton = new System.Windows.Forms.Button();
            Label117 = new System.Windows.Forms.Label();
            Label115 = new System.Windows.Forms.Label();
            CBoxClientNameLabel = new System.Windows.Forms.Label();
            Label116 = new System.Windows.Forms.Label();
            this.GroupBox32.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.TableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label117
            // 
            Label117.AutoSize = true;
            Label117.Location = new System.Drawing.Point(3, 150);
            Label117.Name = "Label117";
            Label117.Size = new System.Drawing.Size(102, 13);
            Label117.TabIndex = 4;
            Label117.Text = "Healthcard Number:";
            // 
            // Label115
            // 
            Label115.AutoSize = true;
            Label115.Location = new System.Drawing.Point(3, 50);
            Label115.Name = "Label115";
            Label115.Size = new System.Drawing.Size(69, 13);
            Label115.TabIndex = 2;
            Label115.Text = "Date of Birth:";
            // 
            // CBoxClientNameLabel
            // 
            CBoxClientNameLabel.AutoSize = true;
            CBoxClientNameLabel.Location = new System.Drawing.Point(3, 0);
            CBoxClientNameLabel.Name = "CBoxClientNameLabel";
            CBoxClientNameLabel.Size = new System.Drawing.Size(67, 13);
            CBoxClientNameLabel.TabIndex = 0;
            CBoxClientNameLabel.Text = "Client Name:";
            // 
            // Label116
            // 
            Label116.AutoSize = true;
            Label116.Location = new System.Drawing.Point(3, 100);
            Label116.Name = "Label116";
            Label116.Size = new System.Drawing.Size(68, 13);
            Label116.TabIndex = 3;
            Label116.Text = "SIN Number:";
            // 
            // LinkLabel1
            // 
            this.LinkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LinkLabel1.AutoSize = true;
            this.LinkLabel1.Location = new System.Drawing.Point(543, 427);
            this.LinkLabel1.Name = "LinkLabel1";
            this.LinkLabel1.Size = new System.Drawing.Size(125, 13);
            this.LinkLabel1.TabIndex = 9;
            this.LinkLabel1.TabStop = true;
            this.LinkLabel1.Text = "Completed Questionnaire";
            // 
            // GroupBox32
            // 
            this.GroupBox32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox32.Controls.Add(this.NotesTextBox);
            this.GroupBox32.Location = new System.Drawing.Point(33, 325);
            this.GroupBox32.Name = "GroupBox32";
            this.GroupBox32.Size = new System.Drawing.Size(470, 230);
            this.GroupBox32.TabIndex = 8;
            this.GroupBox32.TabStop = false;
            this.GroupBox32.Text = "Notes";
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.NotesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesTextBox.Enabled = false;
            this.NotesTextBox.Location = new System.Drawing.Point(3, 16);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(464, 211);
            this.NotesTextBox.TabIndex = 8;
            this.NotesTextBox.TextChanged += new System.EventHandler(this.NotesTextBox_TextChanged);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(525, 100);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(204, 203);
            this.PictureBox2.TabIndex = 7;
            this.PictureBox2.TabStop = false;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel1.Controls.Add(Label117, 0, 3);
            this.TableLayoutPanel1.Controls.Add(Label115, 0, 1);
            this.TableLayoutPanel1.Controls.Add(CBoxClientNameLabel, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.ClientNameTextBox, 1, 0);
            this.TableLayoutPanel1.Controls.Add(Label116, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.DateOfBirthTextBox, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.SINNumberTextBox, 1, 2);
            this.TableLayoutPanel1.Controls.Add(this.HealthcardNumberTextBox, 1, 3);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(33, 100);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 4;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(470, 203);
            this.TableLayoutPanel1.TabIndex = 6;
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientNameTextBox.Enabled = false;
            this.ClientNameTextBox.Location = new System.Drawing.Point(203, 3);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(264, 20);
            this.ClientNameTextBox.TabIndex = 1;
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateOfBirthTextBox.Enabled = false;
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(203, 53);
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(264, 20);
            this.DateOfBirthTextBox.TabIndex = 5;
            // 
            // SINNumberTextBox
            // 
            this.SINNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SINNumberTextBox.Enabled = false;
            this.SINNumberTextBox.Location = new System.Drawing.Point(203, 103);
            this.SINNumberTextBox.Name = "SINNumberTextBox";
            this.SINNumberTextBox.Size = new System.Drawing.Size(264, 20);
            this.SINNumberTextBox.TabIndex = 6;
            // 
            // HealthcardNumberTextBox
            // 
            this.HealthcardNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HealthcardNumberTextBox.Enabled = false;
            this.HealthcardNumberTextBox.Location = new System.Drawing.Point(203, 153);
            this.HealthcardNumberTextBox.Name = "HealthcardNumberTextBox";
            this.HealthcardNumberTextBox.Size = new System.Drawing.Size(264, 20);
            this.HealthcardNumberTextBox.TabIndex = 7;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.Image = global::RRFFilesManager.Properties.Resources.RRFLogo;
            this.PictureBox1.Location = new System.Drawing.Point(534, -3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(224, 68);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 147;
            this.PictureBox1.TabStop = false;
            // 
            // FindClientButton
            // 
            this.FindClientButton.BackColor = System.Drawing.Color.Maroon;
            this.FindClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindClientButton.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.FindClientButton.ForeColor = System.Drawing.Color.White;
            this.FindClientButton.Location = new System.Drawing.Point(34, 12);
            this.FindClientButton.Name = "FindClientButton";
            this.FindClientButton.Size = new System.Drawing.Size(97, 36);
            this.FindClientButton.TabIndex = 149;
            this.FindClientButton.Text = "Find Client";
            this.FindClientButton.UseVisualStyleBackColor = false;
            this.FindClientButton.Click += new System.EventHandler(this.FindClientButton_Click);
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 574);
            this.Controls.Add(this.FindClientButton);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.LinkLabel1);
            this.Controls.Add(this.GroupBox32);
            this.Controls.Add(this.PictureBox2);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Name = "ClientInfo";
            this.Text = "Client Detail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientInfo_FormClosing);
            this.GroupBox32.ResumeLayout(false);
            this.GroupBox32.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.LinkLabel LinkLabel1;
        internal System.Windows.Forms.GroupBox GroupBox32;
        internal System.Windows.Forms.TextBox NotesTextBox;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.TextBox ClientNameTextBox;
        internal System.Windows.Forms.TextBox DateOfBirthTextBox;
        internal System.Windows.Forms.TextBox SINNumberTextBox;
        internal System.Windows.Forms.TextBox HealthcardNumberTextBox;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button FindClientButton;
    }
}