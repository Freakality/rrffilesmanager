
namespace RRFFilesManager.Controls.ReportsControls.UserControls
{
    partial class IntakeReportControls
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Gb_FindInfoControls = new System.Windows.Forms.GroupBox();
            this.FindInfoButton = new System.Windows.Forms.Button();
            this.Dtp_To = new System.Windows.Forms.DateTimePicker();
            this.Dtp_From = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Gb_GroupBY = new System.Windows.Forms.GroupBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.GroupByButton = new System.Windows.Forms.Button();
            this.Chl_Columns = new System.Windows.Forms.CheckedListBox();
            this.Dg_Data = new System.Windows.Forms.DataGridView();
            this.Gb_FindInfoControls.SuspendLayout();
            this.Gb_GroupBY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // Gb_FindInfoControls
            // 
            this.Gb_FindInfoControls.Controls.Add(this.FindInfoButton);
            this.Gb_FindInfoControls.Controls.Add(this.Dtp_To);
            this.Gb_FindInfoControls.Controls.Add(this.Dtp_From);
            this.Gb_FindInfoControls.Controls.Add(this.label2);
            this.Gb_FindInfoControls.Controls.Add(this.label1);
            this.Gb_FindInfoControls.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_FindInfoControls.Location = new System.Drawing.Point(9, 8);
            this.Gb_FindInfoControls.Name = "Gb_FindInfoControls";
            this.Gb_FindInfoControls.Size = new System.Drawing.Size(229, 155);
            this.Gb_FindInfoControls.TabIndex = 0;
            this.Gb_FindInfoControls.TabStop = false;
            // 
            // FindInfoButton
            // 
            this.FindInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindInfoButton.BackColor = System.Drawing.Color.Maroon;
            this.FindInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindInfoButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindInfoButton.ForeColor = System.Drawing.Color.White;
            this.FindInfoButton.Location = new System.Drawing.Point(100, 114);
            this.FindInfoButton.Name = "FindInfoButton";
            this.FindInfoButton.Size = new System.Drawing.Size(111, 35);
            this.FindInfoButton.TabIndex = 154;
            this.FindInfoButton.Text = "Find Info";
            this.FindInfoButton.UseVisualStyleBackColor = false;
            this.FindInfoButton.Click += new System.EventHandler(this.FindInfoButton_Click);
            // 
            // Dtp_To
            // 
            this.Dtp_To.CustomFormat = "dd/MM/yyyy";
            this.Dtp_To.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_To.Location = new System.Drawing.Point(82, 74);
            this.Dtp_To.Name = "Dtp_To";
            this.Dtp_To.Size = new System.Drawing.Size(130, 27);
            this.Dtp_To.TabIndex = 153;
            // 
            // Dtp_From
            // 
            this.Dtp_From.CustomFormat = "dd/MM/yyyy";
            this.Dtp_From.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_From.Location = new System.Drawing.Point(82, 32);
            this.Dtp_From.Name = "Dtp_From";
            this.Dtp_From.Size = new System.Drawing.Size(130, 27);
            this.Dtp_From.TabIndex = 152;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 19);
            this.label2.TabIndex = 151;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 150;
            this.label1.Text = "From:";
            // 
            // Gb_GroupBY
            // 
            this.Gb_GroupBY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_GroupBY.Controls.Add(this.RefreshButton);
            this.Gb_GroupBY.Controls.Add(this.GroupByButton);
            this.Gb_GroupBY.Controls.Add(this.Chl_Columns);
            this.Gb_GroupBY.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_GroupBY.Location = new System.Drawing.Point(244, 8);
            this.Gb_GroupBY.Name = "Gb_GroupBY";
            this.Gb_GroupBY.Size = new System.Drawing.Size(618, 155);
            this.Gb_GroupBY.TabIndex = 1;
            this.Gb_GroupBY.TabStop = false;
            this.Gb_GroupBY.Text = "Group By";
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshButton.BackColor = System.Drawing.Color.Maroon;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.ForeColor = System.Drawing.Color.White;
            this.RefreshButton.Location = new System.Drawing.Point(501, 37);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(111, 35);
            this.RefreshButton.TabIndex = 156;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = false;
            // 
            // GroupByButton
            // 
            this.GroupByButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupByButton.BackColor = System.Drawing.Color.Maroon;
            this.GroupByButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupByButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupByButton.ForeColor = System.Drawing.Color.White;
            this.GroupByButton.Location = new System.Drawing.Point(501, 114);
            this.GroupByButton.Name = "GroupByButton";
            this.GroupByButton.Size = new System.Drawing.Size(111, 35);
            this.GroupByButton.TabIndex = 155;
            this.GroupByButton.Text = "Group Info";
            this.GroupByButton.UseVisualStyleBackColor = false;
            this.GroupByButton.Click += new System.EventHandler(this.GroupByButton_Click);
            // 
            // Chl_Columns
            // 
            this.Chl_Columns.CheckOnClick = true;
            this.Chl_Columns.ColumnWidth = 165;
            this.Chl_Columns.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chl_Columns.FormattingEnabled = true;
            this.Chl_Columns.Location = new System.Drawing.Point(16, 37);
            this.Chl_Columns.MultiColumn = true;
            this.Chl_Columns.Name = "Chl_Columns";
            this.Chl_Columns.Size = new System.Drawing.Size(194, 114);
            this.Chl_Columns.TabIndex = 0;
            // 
            // Dg_Data
            // 
            this.Dg_Data.AllowUserToAddRows = false;
            this.Dg_Data.AllowUserToDeleteRows = false;
            this.Dg_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dg_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dg_Data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Dg_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Data.Location = new System.Drawing.Point(9, 169);
            this.Dg_Data.Name = "Dg_Data";
            this.Dg_Data.ReadOnly = true;
            this.Dg_Data.RowHeadersVisible = false;
            this.Dg_Data.Size = new System.Drawing.Size(853, 245);
            this.Dg_Data.TabIndex = 2;
            // 
            // IntakeReportControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Dg_Data);
            this.Controls.Add(this.Gb_GroupBY);
            this.Controls.Add(this.Gb_FindInfoControls);
            this.Name = "IntakeReportControls";
            this.Size = new System.Drawing.Size(871, 431);
            this.Gb_FindInfoControls.ResumeLayout(false);
            this.Gb_FindInfoControls.PerformLayout();
            this.Gb_GroupBY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gb_FindInfoControls;
        internal System.Windows.Forms.Button FindInfoButton;
        private System.Windows.Forms.DateTimePicker Dtp_To;
        private System.Windows.Forms.DateTimePicker Dtp_From;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gb_GroupBY;
        private System.Windows.Forms.DataGridView Dg_Data;
        private System.Windows.Forms.CheckedListBox Chl_Columns;
        internal System.Windows.Forms.Button RefreshButton;
        internal System.Windows.Forms.Button GroupByButton;
    }
}
