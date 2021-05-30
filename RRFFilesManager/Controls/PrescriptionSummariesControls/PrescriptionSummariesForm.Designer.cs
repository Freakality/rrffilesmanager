﻿
namespace RRFFilesManager.Controls.PrescriptionSummariesControls
{
    partial class PrescriptionSummariesForm
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
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label DateOFCallLabel;
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PreviewPanel = new System.Windows.Forms.Panel();
            this.IntakeInfo = new System.Windows.Forms.TableLayoutPanel();
            this.FindFileButton = new System.Windows.Forms.Button();
            this.FileNumberTextBox = new System.Windows.Forms.TextBox();
            this.MatterTypeTextBox = new System.Windows.Forms.TextBox();
            label15 = new System.Windows.Forms.Label();
            DateOFCallLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.IntakeInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.PreviewPanel, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1348, 673);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.IntakeInfo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(868, 665);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewPanel.Location = new System.Drawing.Point(879, 4);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.Size = new System.Drawing.Size(465, 665);
            this.PreviewPanel.TabIndex = 1;
            // 
            // IntakeInfo
            // 
            this.IntakeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntakeInfo.ColumnCount = 5;
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.IntakeInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.IntakeInfo.Controls.Add(this.FindFileButton, 0, 0);
            this.IntakeInfo.Controls.Add(this.FileNumberTextBox, 4, 0);
            this.IntakeInfo.Controls.Add(label15, 3, 0);
            this.IntakeInfo.Controls.Add(this.MatterTypeTextBox, 2, 0);
            this.IntakeInfo.Controls.Add(DateOFCallLabel, 1, 0);
            this.IntakeInfo.Location = new System.Drawing.Point(0, 0);
            this.IntakeInfo.Margin = new System.Windows.Forms.Padding(0);
            this.IntakeInfo.Name = "IntakeInfo";
            this.IntakeInfo.RowCount = 1;
            this.IntakeInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.IntakeInfo.Size = new System.Drawing.Size(868, 35);
            this.IntakeInfo.TabIndex = 146;
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
            // 
            // FileNumberTextBox
            // 
            this.FileNumberTextBox.Enabled = false;
            this.FileNumberTextBox.Location = new System.Drawing.Point(612, 3);
            this.FileNumberTextBox.Name = "FileNumberTextBox";
            this.FileNumberTextBox.ReadOnly = true;
            this.FileNumberTextBox.Size = new System.Drawing.Size(253, 20);
            this.FileNumberTextBox.TabIndex = 143;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.Location = new System.Drawing.Point(512, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(84, 16);
            label15.TabIndex = 145;
            label15.Text = "File Number:";
            // 
            // MatterTypeTextBox
            // 
            this.MatterTypeTextBox.Enabled = false;
            this.MatterTypeTextBox.Location = new System.Drawing.Point(253, 3);
            this.MatterTypeTextBox.Name = "MatterTypeTextBox";
            this.MatterTypeTextBox.ReadOnly = true;
            this.MatterTypeTextBox.Size = new System.Drawing.Size(253, 20);
            this.MatterTypeTextBox.TabIndex = 142;
            // 
            // DateOFCallLabel
            // 
            DateOFCallLabel.AutoSize = true;
            DateOFCallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateOFCallLabel.Location = new System.Drawing.Point(153, 0);
            DateOFCallLabel.Name = "DateOFCallLabel";
            DateOFCallLabel.Size = new System.Drawing.Size(83, 16);
            DateOFCallLabel.TabIndex = 144;
            DateOFCallLabel.Text = "Matter Type:";
            // 
            // PrescriptionSummariesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 673);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Name = "PrescriptionSummariesForm";
            this.Text = "PrescriptionSummariesForm";
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.IntakeInfo.ResumeLayout(false);
            this.IntakeInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PreviewPanel;
        private System.Windows.Forms.TableLayoutPanel IntakeInfo;
        private System.Windows.Forms.Button FindFileButton;
        private System.Windows.Forms.TextBox FileNumberTextBox;
        private System.Windows.Forms.TextBox MatterTypeTextBox;
    }
}