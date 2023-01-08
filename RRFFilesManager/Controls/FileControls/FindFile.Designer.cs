namespace RRFFilesManager.FileControls
{
    partial class FindFile
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
            this.GridView = new System.Windows.Forms.DataGridView();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SearchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.Location = new System.Drawing.Point(0, 56);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(800, 394);
            this.GridView.TabIndex = 3;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(9, 21);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(782, 26);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.SearchTextBox);
            this.SearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(0, 0);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(800, 56);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search";
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter_1);
            // 
            // FindFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.SearchBox);
            this.Name = "FindFile";
            this.Text = "FindFile";
            this.Load += new System.EventHandler(this.FindFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox SearchBox;
    }
}