
namespace RRFFilesManager.Controls
{
    partial class ChangePasswordUI
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
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.TBoxNewPasswordLabel = new System.Windows.Forms.Label();
            this.TBoxConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.TBoxNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.TBoxConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.10359F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.28685F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.60956F));
            this.tableLayoutPanel8.Controls.Add(this.TBoxConfirmPasswordTextBox, 1, 4);
            this.tableLayoutPanel8.Controls.Add(this.TBoxNewPasswordTextBox, 1, 3);
            this.tableLayoutPanel8.Controls.Add(this.PasswordTextBox, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.UserTextBox, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.Label, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.ExitBtn, 1, 5);
            this.tableLayoutPanel8.Controls.Add(this.EnterBtn, 2, 5);
            this.tableLayoutPanel8.Controls.Add(this.TBoxConfirmPasswordLabel, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.TBoxNewPasswordLabel, 0, 3);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 6;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00001F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(507, 378);
            this.tableLayoutPanel8.TabIndex = 151;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(125, 307);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(137, 68);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.SetColumnSpan(this.PasswordTextBox, 2);
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextBox.Location = new System.Drawing.Point(125, 94);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(379, 24);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(22, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 71);
            this.label1.TabIndex = 151;
            this.label1.Text = "CURRENT\r\nPASSWORD*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.SetColumnSpan(this.UserTextBox, 2);
            this.UserTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTextBox.Location = new System.Drawing.Point(125, 23);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(379, 24);
            this.UserTextBox.TabIndex = 1;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Dock = System.Windows.Forms.DockStyle.Right;
            this.Label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Label.Location = new System.Drawing.Point(76, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(43, 71);
            this.Label.TabIndex = 40;
            this.Label.Text = "USER";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.Color.Maroon;
            this.EnterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.EnterBtn.ForeColor = System.Drawing.Color.White;
            this.EnterBtn.Location = new System.Drawing.Point(268, 307);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(236, 68);
            this.EnterBtn.TabIndex = 5;
            this.EnterBtn.Text = "SAVE NEW PASSWORD";
            this.EnterBtn.UseVisualStyleBackColor = false;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // TBoxNewPasswordLabel
            // 
            this.TBoxNewPasswordLabel.AutoSize = true;
            this.TBoxNewPasswordLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TBoxNewPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxNewPasswordLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TBoxNewPasswordLabel.Location = new System.Drawing.Point(22, 162);
            this.TBoxNewPasswordLabel.Name = "TBoxNewPasswordLabel";
            this.TBoxNewPasswordLabel.Size = new System.Drawing.Size(97, 71);
            this.TBoxNewPasswordLabel.TabIndex = 158;
            this.TBoxNewPasswordLabel.Text = "NEW \r\nPASSWORD*";
            this.TBoxNewPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBoxConfirmPasswordLabel
            // 
            this.TBoxConfirmPasswordLabel.AutoSize = true;
            this.TBoxConfirmPasswordLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TBoxConfirmPasswordLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxConfirmPasswordLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TBoxConfirmPasswordLabel.Location = new System.Drawing.Point(22, 233);
            this.TBoxConfirmPasswordLabel.Name = "TBoxConfirmPasswordLabel";
            this.TBoxConfirmPasswordLabel.Size = new System.Drawing.Size(97, 71);
            this.TBoxConfirmPasswordLabel.TabIndex = 159;
            this.TBoxConfirmPasswordLabel.Text = "CONFIRM\r\nPASSWORD*";
            this.TBoxConfirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBoxNewPasswordTextBox
            // 
            this.TBoxNewPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.SetColumnSpan(this.TBoxNewPasswordTextBox, 2);
            this.TBoxNewPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxNewPasswordTextBox.Location = new System.Drawing.Point(125, 185);
            this.TBoxNewPasswordTextBox.Name = "TBoxNewPasswordTextBox";
            this.TBoxNewPasswordTextBox.Size = new System.Drawing.Size(379, 24);
            this.TBoxNewPasswordTextBox.TabIndex = 3;
            this.TBoxNewPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // TBoxConfirmPasswordTextBox
            // 
            this.TBoxConfirmPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.SetColumnSpan(this.TBoxConfirmPasswordTextBox, 2);
            this.TBoxConfirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxConfirmPasswordTextBox.Location = new System.Drawing.Point(125, 256);
            this.TBoxConfirmPasswordTextBox.Name = "TBoxConfirmPasswordTextBox";
            this.TBoxConfirmPasswordTextBox.Size = new System.Drawing.Size(379, 24);
            this.TBoxConfirmPasswordTextBox.TabIndex = 4;
            this.TBoxConfirmPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // ChangePasswordUI
            // 
            this.AcceptButton = this.EnterBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(531, 402);
            this.Controls.Add(this.tableLayoutPanel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordUI";
            this.Text = "ChangePasswordUI";
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        internal System.Windows.Forms.TextBox TBoxConfirmPasswordTextBox;
        internal System.Windows.Forms.TextBox TBoxNewPasswordTextBox;
        internal System.Windows.Forms.TextBox PasswordTextBox;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox UserTextBox;
        internal System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button EnterBtn;
        internal System.Windows.Forms.Label TBoxConfirmPasswordLabel;
        internal System.Windows.Forms.Label TBoxNewPasswordLabel;
    }
}