namespace RRFFilesManager
{
    partial class FindClient
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
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ClientsGridView = new System.Windows.Forms.DataGridView();
            this.SearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Controls.Add(this.SearchTextBox);
            this.SearchBox.Location = new System.Drawing.Point(0, 0);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(797, 45);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search";
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(9, 16);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(782, 20);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // ClientsGridView
            // 
            this.ClientsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ClientsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGridView.Location = new System.Drawing.Point(0, 45);
            this.ClientsGridView.Name = "ClientsGridView";
            this.ClientsGridView.Size = new System.Drawing.Size(800, 406);
            this.ClientsGridView.TabIndex = 1;
            this.ClientsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsGridView_CellClick);
            this.ClientsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsGridView_CellContentClick);
            this.ClientsGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsGridView_RowEnter);
            // 
            // FindClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ClientsGridView);
            this.Name = "FindClient";
            this.Text = "FindClient";
            this.Load += new System.EventHandler(this.FindClient_Load);
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView ClientsGridView;
    }
}