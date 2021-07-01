
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
            System.Windows.Forms.Label label1;
            this.IntakeInfo = new System.Windows.Forms.TableLayoutPanel();
            this.FindFileButton = new System.Windows.Forms.Button();
            this.FileNumberTextBox = new System.Windows.Forms.TextBox();
            this.ClientTB = new System.Windows.Forms.TextBox();
            this.ArchivesCB = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label15 = new System.Windows.Forms.Label();
            DateOFCallLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.IntakeInfo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            DateOFCallLabel.Text = "Client:";
            DateOFCallLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 8);
            label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(244, 27);
            label1.TabIndex = 145;
            label1.Text = "Document Name:";
            label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.IntakeInfo.Controls.Add(this.ClientTB, 2, 0);
            this.IntakeInfo.Location = new System.Drawing.Point(0, 0);
            this.IntakeInfo.Margin = new System.Windows.Forms.Padding(0);
            this.IntakeInfo.Name = "IntakeInfo";
            this.IntakeInfo.RowCount = 1;
            this.IntakeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.IntakeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            // ClientTB
            // 
            this.ClientTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientTB.Enabled = false;
            this.ClientTB.Location = new System.Drawing.Point(253, 8);
            this.ClientTB.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.ClientTB.Name = "ClientTB";
            this.ClientTB.ReadOnly = true;
            this.ClientTB.Size = new System.Drawing.Size(253, 20);
            this.ClientTB.TabIndex = 147;
            // 
            // ArchivesCB
            // 
            this.ArchivesCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArchivesCB.FormattingEnabled = true;
            this.ArchivesCB.Location = new System.Drawing.Point(253, 8);
            this.ArchivesCB.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.ArchivesCB.Name = "ArchivesCB";
            this.ArchivesCB.Size = new System.Drawing.Size(612, 21);
            this.ArchivesCB.TabIndex = 147;
            this.ArchivesCB.SelectedIndexChanged += new System.EventHandler(this.ArchivesCB_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.IntakeInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(868, 70);
            this.tableLayoutPanel1.TabIndex = 149;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ArchivesCB, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 35);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(868, 35);
            this.tableLayoutPanel2.TabIndex = 149;
            // 
            // FindFileAndArchivePanelUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FindFileAndArchivePanelUserControl";
            this.Size = new System.Drawing.Size(868, 70);
            this.IntakeInfo.ResumeLayout(false);
            this.IntakeInfo.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel IntakeInfo;
        private System.Windows.Forms.Button FindFileButton;
        private System.Windows.Forms.TextBox FileNumberTextBox;
        private System.Windows.Forms.ComboBox ArchivesCB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox ClientTB;
    }
}
