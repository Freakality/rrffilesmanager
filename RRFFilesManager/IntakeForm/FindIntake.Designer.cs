namespace RRFFilesManager.IntakeForm
{
    partial class FindIntake
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
            this.IntakesGridView = new System.Windows.Forms.DataGridView();
            this.SearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntakesGridView)).BeginInit();
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
            this.SearchTextBox.Size = new System.Drawing.Size(779, 20);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // IntakesGridView
            // 
            this.IntakesGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IntakesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.IntakesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IntakesGridView.Location = new System.Drawing.Point(0, 45);
            this.IntakesGridView.Name = "IntakesGridView";
            this.IntakesGridView.Size = new System.Drawing.Size(800, 406);
            this.IntakesGridView.TabIndex = 1;
            this.IntakesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IntakesGridView_CellClick);
            this.IntakesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IntakesGridView_CellContentClick);
            // 
            // FindIntake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.IntakesGridView);
            this.Name = "FindIntake";
            this.Text = "FindIntake";
            this.Load += new System.EventHandler(this.FindIntake_Load);
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntakesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView IntakesGridView;
    }
}