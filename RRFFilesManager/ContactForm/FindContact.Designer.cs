namespace RRFFilesManager.ContactForm
{
    partial class FindContact
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
            this.ContactsGridView = new System.Windows.Forms.DataGridView();
            this.SearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGridView)).BeginInit();
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
            this.SearchBox.TabIndex = 2;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search";
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
            // ContactsGridView
            // 
            this.ContactsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ContactsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsGridView.Location = new System.Drawing.Point(0, 45);
            this.ContactsGridView.Name = "ContactsGridView";
            this.ContactsGridView.Size = new System.Drawing.Size(800, 406);
            this.ContactsGridView.TabIndex = 3;
            this.ContactsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContactsGridView_CellClick);
            // 
            // FindContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.ContactsGridView);
            this.Name = "FindContact";
            this.Text = "FindContact";
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView ContactsGridView;
    }
}