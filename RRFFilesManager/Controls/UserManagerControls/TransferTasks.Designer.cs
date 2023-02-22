
namespace RRFFilesManager.Controls.UserManagerControls
{
    partial class TransferTasks
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
            System.Windows.Forms.Label TransferTasksSelectedUserLabel;
            System.Windows.Forms.Label TransferTasksTransferToLabel;
            this.TransferTaskTransferToComboBox = new System.Windows.Forms.ComboBox();
            this.TransferTaskSelectedUserTextBox = new System.Windows.Forms.TextBox();
            this.TransferTasksButton = new System.Windows.Forms.Button();
            this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            TransferTasksSelectedUserLabel = new System.Windows.Forms.Label();
            TransferTasksTransferToLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransferTasksSelectedUserLabel
            // 
            TransferTasksSelectedUserLabel.AutoSize = true;
            TransferTasksSelectedUserLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            TransferTasksSelectedUserLabel.Location = new System.Drawing.Point(4, 0);
            TransferTasksSelectedUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TransferTasksSelectedUserLabel.Name = "TransferTasksSelectedUserLabel";
            TransferTasksSelectedUserLabel.Size = new System.Drawing.Size(119, 41);
            TransferTasksSelectedUserLabel.TabIndex = 146;
            TransferTasksSelectedUserLabel.Text = "Selected User:";
            TransferTasksSelectedUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TransferTasksTransferToLabel
            // 
            TransferTasksTransferToLabel.AutoSize = true;
            TransferTasksTransferToLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            TransferTasksTransferToLabel.Location = new System.Drawing.Point(4, 41);
            TransferTasksTransferToLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            TransferTasksTransferToLabel.Name = "TransferTasksTransferToLabel";
            TransferTasksTransferToLabel.Size = new System.Drawing.Size(119, 37);
            TransferTasksTransferToLabel.TabIndex = 147;
            TransferTasksTransferToLabel.Text = "Transfer Tasks To:";
            TransferTasksTransferToLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TransferTaskTransferToComboBox
            // 
            this.TransferTaskTransferToComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TransferTaskTransferToComboBox.BackColor = System.Drawing.Color.White;
            this.TransferTaskTransferToComboBox.DisplayMember = "MatterType";
            this.TransferTaskTransferToComboBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferTaskTransferToComboBox.FormattingEnabled = true;
            this.TransferTaskTransferToComboBox.Location = new System.Drawing.Point(131, 46);
            this.TransferTaskTransferToComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TransferTaskTransferToComboBox.Name = "TransferTaskTransferToComboBox";
            this.TransferTaskTransferToComboBox.Size = new System.Drawing.Size(357, 25);
            this.TransferTaskTransferToComboBox.TabIndex = 140;
            this.TransferTaskTransferToComboBox.ValueMember = "MatterType";
            // 
            // TransferTaskSelectedUserTextBox
            // 
            this.TransferTaskSelectedUserTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TransferTaskSelectedUserTextBox.Location = new System.Drawing.Point(131, 9);
            this.TransferTaskSelectedUserTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 13, 4);
            this.TransferTaskSelectedUserTextBox.Name = "TransferTaskSelectedUserTextBox";
            this.TransferTaskSelectedUserTextBox.Size = new System.Drawing.Size(348, 23);
            this.TransferTaskSelectedUserTextBox.TabIndex = 141;
            // 
            // TransferTasksButton
            // 
            this.TransferTasksButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TransferTasksButton.BackColor = System.Drawing.Color.Maroon;
            this.TableLayoutPanel2.SetColumnSpan(this.TransferTasksButton, 2);
            this.TransferTasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransferTasksButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransferTasksButton.ForeColor = System.Drawing.Color.White;
            this.TransferTasksButton.Location = new System.Drawing.Point(150, 95);
            this.TransferTasksButton.Margin = new System.Windows.Forms.Padding(4);
            this.TransferTasksButton.Name = "TransferTasksButton";
            this.TransferTasksButton.Size = new System.Drawing.Size(192, 46);
            this.TransferTasksButton.TabIndex = 145;
            this.TransferTasksButton.Text = "Transfer";
            this.TransferTasksButton.UseVisualStyleBackColor = false;
            this.TransferTasksButton.Click += new System.EventHandler(this.TransferTasksButton_Click);
            // 
            // TableLayoutPanel2
            // 
            this.TableLayoutPanel2.ColumnCount = 2;
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.81301F));
            this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.18699F));
            this.TableLayoutPanel2.Controls.Add(TransferTasksSelectedUserLabel, 0, 0);
            this.TableLayoutPanel2.Controls.Add(TransferTasksTransferToLabel, 0, 1);
            this.TableLayoutPanel2.Controls.Add(this.TransferTaskTransferToComboBox, 1, 1);
            this.TableLayoutPanel2.Controls.Add(this.TransferTaskSelectedUserTextBox, 1, 0);
            this.TableLayoutPanel2.Controls.Add(this.TransferTasksButton, 0, 2);
            this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.TableLayoutPanel2.Name = "TableLayoutPanel2";
            this.TableLayoutPanel2.RowCount = 3;
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel2.Size = new System.Drawing.Size(492, 158);
            this.TableLayoutPanel2.TabIndex = 148;
            // 
            // TransferTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 158);
            this.Controls.Add(this.TableLayoutPanel2);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferTasks";
            this.Text = "ChangePasswordUI";
            this.Load += new System.EventHandler(this.TransferTasks_Load);
            this.TableLayoutPanel2.ResumeLayout(false);
            this.TableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ComboBox TransferTaskTransferToComboBox;
        internal System.Windows.Forms.TextBox TransferTaskSelectedUserTextBox;
        private System.Windows.Forms.Button TransferTasksButton;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
    }
}