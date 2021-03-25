
namespace RRFFilesManager.Controls.ArchiveControls
{
    partial class NameAndTypeOfPartyUserControl
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
            this.label9 = new System.Windows.Forms.Label();
            this.NameOfParty = new System.Windows.Forms.TextBox();
            this.TypeOfParty = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 26);
            this.label9.TabIndex = 1;
            this.label9.Text = "Name Of Party";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NameOfParty
            // 
            this.NameOfParty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameOfParty.Location = new System.Drawing.Point(153, 3);
            this.NameOfParty.Name = "NameOfParty";
            this.NameOfParty.Size = new System.Drawing.Size(278, 20);
            this.NameOfParty.TabIndex = 9;
            this.NameOfParty.TextChanged += new System.EventHandler(this.NameOfParty_TextChanged);
            // 
            // TypeOfParty
            // 
            this.TypeOfParty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeOfParty.Location = new System.Drawing.Point(587, 3);
            this.TypeOfParty.Name = "TypeOfParty";
            this.TypeOfParty.Size = new System.Drawing.Size(278, 20);
            this.TypeOfParty.TabIndex = 12;
            this.TypeOfParty.TextChanged += new System.EventHandler(this.TypeOfParty_TextChanged);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.NameOfParty, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.TypeOfParty, 3, 0);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Type Of Party";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NameAndTypeOfPartyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel8);
            this.Name = "NameAndTypeOfPartyUserControl";
            this.Size = new System.Drawing.Size(868, 130);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NameOfParty;
        private System.Windows.Forms.TextBox TypeOfParty;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        internal System.Windows.Forms.Label label1;
    }
}
