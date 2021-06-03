
namespace RRFFilesManager.Controls.CommonControls
{
    partial class FindFileAndArchivePanelUserControl
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
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label DateOFCallLabel;
            this.IntakeInfo = new System.Windows.Forms.TableLayoutPanel();
            this.FindFileButton = new System.Windows.Forms.Button();
            this.FileNumberTextBox = new System.Windows.Forms.TextBox();
            this.ArchivesCB = new System.Windows.Forms.ComboBox();
            label15 = new System.Windows.Forms.Label();
            DateOFCallLabel = new System.Windows.Forms.Label();
            this.IntakeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = System.Windows.Forms.DockStyle.Fill;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(512, 8);
            label15.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(94, 27);
            label15.TabIndex = 145;
            label15.Text = "File Number:";
            label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DateOFCallLabel
            // 
            DateOFCallLabel.AutoSize = true;
            DateOFCallLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            DateOFCallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateOFCallLabel.Location = new System.Drawing.Point(153, 8);
            DateOFCallLabel.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            DateOFCallLabel.Name = "DateOFCallLabel";
            DateOFCallLabel.Size = new System.Drawing.Size(94, 27);
            DateOFCallLabel.TabIndex = 144;
            DateOFCallLabel.Text = "File Name:";
            DateOFCallLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // IntakeInfo
            // 
            this.IntakeInfo.ColumnCount = 5;
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.IntakeInfo.Controls.Add(this.FindFileButton, 0, 0);
            this.IntakeInfo.Controls.Add(this.FileNumberTextBox, 4, 0);
            this.IntakeInfo.Controls.Add(label15, 3, 0);
            this.IntakeInfo.Controls.Add(DateOFCallLabel, 1, 0);
            this.IntakeInfo.Controls.Add(this.ArchivesCB, 2, 0);
            this.IntakeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IntakeInfo.Location = new System.Drawing.Point(0, 0);
            this.IntakeInfo.Margin = new System.Windows.Forms.Padding(0);
            this.IntakeInfo.Name = "IntakeInfo";
            this.IntakeInfo.RowCount = 1;
            this.IntakeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.IntakeInfo.Size = new System.Drawing.Size(868, 35);
            this.IntakeInfo.TabIndex = 148;
            // 
            // FindFileButton
            // 
            this.FindFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindFileButton.BackColor = System.Drawing.Color.Maroon;
            this.FindFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindFileButton.ForeColor = System.Drawing.Color.White;
            this.FindFileButton.Location = new System.Drawing.Point(3, 3);
            this.FindFileButton.Name = "FindFileButton";
            this.FindFileButton.Size = new System.Drawing.Size(144, 29);
            this.FindFileButton.TabIndex = 146;
            this.FindFileButton.Text = "Find File";
            this.FindFileButton.UseVisualStyleBackColor = false;
            this.FindFileButton.Click += new System.EventHandler(this.FindFileButton_Click);
            // 
            // FileNumberTextBox
            // 
            this.FileNumberTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileNumberTextBox.Enabled = false;
            this.FileNumberTextBox.Location = new System.Drawing.Point(612, 8);
            this.FileNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.FileNumberTextBox.Name = "FileNumberTextBox";
            this.FileNumberTextBox.ReadOnly = true;
            this.FileNumberTextBox.Size = new System.Drawing.Size(253, 20);
            this.FileNumberTextBox.TabIndex = 143;
            // 
            // ArchivesCB
            // 
            this.ArchivesCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArchivesCB.FormattingEnabled = true;
            this.ArchivesCB.Location = new System.Drawing.Point(253, 8);
            this.ArchivesCB.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.ArchivesCB.Name = "ArchivesCB";
            this.ArchivesCB.Size = new System.Drawing.Size(253, 21);
            this.ArchivesCB.TabIndex = 147;
            this.ArchivesCB.SelectedIndexChanged += new System.EventHandler(this.ArchivesCB_SelectedIndexChanged);
            // 
            // FindFileAndArchivePanelUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.IntakeInfo);
            this.Name = "FindFileAndArchivePanelUserControl";
            this.Size = new System.Drawing.Size(868, 35);
            this.IntakeInfo.ResumeLayout(false);
            this.IntakeInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel IntakeInfo;
        private System.Windows.Forms.Button FindFileButton;
        private System.Windows.Forms.TextBox FileNumberTextBox;
        private System.Windows.Forms.ComboBox ArchivesCB;
    }
}
