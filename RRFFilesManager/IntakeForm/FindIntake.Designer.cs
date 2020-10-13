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
            this.Content = new System.Windows.Forms.FlowLayoutPanel();
            this.IntakesGridView = new System.Windows.Forms.DataGridView();
            this.SearchBox.SuspendLayout();
            this.Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntakesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.SearchTextBox);
            this.SearchBox.Location = new System.Drawing.Point(3, 3);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(797, 45);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search";
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(9, 16);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(782, 20);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.White;
            this.Content.Controls.Add(this.SearchBox);
            this.Content.Controls.Add(this.IntakesGridView);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(800, 450);
            this.Content.TabIndex = 1;
            // 
            // IntakesGridView
            // 
            this.IntakesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IntakesGridView.Location = new System.Drawing.Point(3, 54);
            this.IntakesGridView.Name = "IntakesGridView";
            this.IntakesGridView.Size = new System.Drawing.Size(797, 396);
            this.IntakesGridView.TabIndex = 1;
            this.IntakesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IntakesGridView_CellContentClick);
            // 
            // FindIntake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Content);
            this.Name = "FindIntake";
            this.Text = "FindIntake";
            this.Load += new System.EventHandler(this.FindIntake_Load);
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            this.Content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IntakesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.FlowLayoutPanel Content;
        private System.Windows.Forms.DataGridView IntakesGridView;
    }
}