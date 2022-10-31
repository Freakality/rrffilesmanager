
namespace RRFFilesManager.Controls.FileControls
{
    partial class AddTaskManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.AddCategoryTasksButton = new System.Windows.Forms.Button();
            this.CBoxTaskCategory = new System.Windows.Forms.ComboBox();
            this.TaskGridView = new System.Windows.Forms.DataGridView();
            this.FindFileButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskGridView)).BeginInit();
            this.SearchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::RRFFilesManager.Properties.Resources.RRFLogo;
            this.PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(224, 68);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 143;
            this.PictureBox1.TabStop = false;
            // 
            // AddCategoryTasksButton
            // 
            this.AddCategoryTasksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCategoryTasksButton.BackColor = System.Drawing.Color.Maroon;
            this.AddCategoryTasksButton.Enabled = false;
            this.AddCategoryTasksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategoryTasksButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategoryTasksButton.ForeColor = System.Drawing.Color.White;
            this.AddCategoryTasksButton.Location = new System.Drawing.Point(25, 144);
            this.AddCategoryTasksButton.Name = "AddCategoryTasksButton";
            this.AddCategoryTasksButton.Size = new System.Drawing.Size(1136, 37);
            this.AddCategoryTasksButton.TabIndex = 148;
            this.AddCategoryTasksButton.Text = "Add Tasks to File from Selected Category";
            this.AddCategoryTasksButton.UseVisualStyleBackColor = false;
            this.AddCategoryTasksButton.Click += new System.EventHandler(this.AddCategoryTasksButton_Click);
            // 
            // CBoxTaskCategory
            // 
            this.CBoxTaskCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBoxTaskCategory.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CBoxTaskCategory.FormattingEnabled = true;
            this.CBoxTaskCategory.Location = new System.Drawing.Point(9, 21);
            this.CBoxTaskCategory.Name = "CBoxTaskCategory";
            this.CBoxTaskCategory.Size = new System.Drawing.Size(1130, 25);
            this.CBoxTaskCategory.TabIndex = 149;
            // 
            // TaskGridView
            // 
            this.TaskGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.TaskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TaskGridView.DefaultCellStyle = dataGridViewCellStyle14;
            this.TaskGridView.Location = new System.Drawing.Point(25, 189);
            this.TaskGridView.Name = "TaskGridView";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.TaskGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TaskGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TaskGridView.Size = new System.Drawing.Size(1136, 343);
            this.TaskGridView.TabIndex = 151;
            // 
            // FindFileButton
            // 
            this.FindFileButton.BackColor = System.Drawing.Color.Maroon;
            this.FindFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindFileButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindFileButton.ForeColor = System.Drawing.Color.White;
            this.FindFileButton.Location = new System.Drawing.Point(851, 43);
            this.FindFileButton.Name = "FindFileButton";
            this.FindFileButton.Size = new System.Drawing.Size(152, 37);
            this.FindFileButton.TabIndex = 152;
            this.FindFileButton.Text = "Find File";
            this.FindFileButton.UseVisualStyleBackColor = false;
            this.FindFileButton.Click += new System.EventHandler(this.FindFileButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Maroon;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(1009, 43);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(152, 37);
            this.HomeButton.TabIndex = 153;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Controls.Add(this.CBoxTaskCategory);
            this.SearchBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.SearchBox.Location = new System.Drawing.Point(16, 86);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(1145, 52);
            this.SearchBox.TabIndex = 145;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search";
            // 
            // AddTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 597);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.FindFileButton);
            this.Controls.Add(this.TaskGridView);
            this.Controls.Add(this.AddCategoryTasksButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.PictureBox1);
            this.Name = "AddTaskManager";
            this.Text = "Add New Tasks";
            this.Load += new System.EventHandler(this.MasterTaskManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TaskGridView)).EndInit();
            this.SearchBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button AddCategoryTasksButton;
        private System.Windows.Forms.ComboBox CBoxTaskCategory;
        private System.Windows.Forms.DataGridView TaskGridView;
        internal System.Windows.Forms.Button FindFileButton;
        internal System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.GroupBox SearchBox;
    }
}