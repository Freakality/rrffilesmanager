
namespace RRFFilesManager.Controls.MasterTaskControls
{
    partial class MasterTaskManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteTaskButton = new System.Windows.Forms.Button();
            this.EditTaskButton = new System.Windows.Forms.Button();
            this.CreateTaskButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.CBoxTaskCategory = new System.Windows.Forms.ComboBox();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.TaskGridView = new System.Windows.Forms.DataGridView();
            this.HomeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskGridView)).BeginInit();
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
            // DeleteTaskButton
            // 
            this.DeleteTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteTaskButton.BackColor = System.Drawing.Color.Maroon;
            this.DeleteTaskButton.Enabled = false;
            this.DeleteTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTaskButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTaskButton.ForeColor = System.Drawing.Color.White;
            this.DeleteTaskButton.Location = new System.Drawing.Point(1018, 548);
            this.DeleteTaskButton.Name = "DeleteTaskButton";
            this.DeleteTaskButton.Size = new System.Drawing.Size(152, 37);
            this.DeleteTaskButton.TabIndex = 146;
            this.DeleteTaskButton.Text = "Delete Task";
            this.DeleteTaskButton.UseVisualStyleBackColor = false;
            this.DeleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
            // 
            // EditTaskButton
            // 
            this.EditTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditTaskButton.BackColor = System.Drawing.Color.Maroon;
            this.EditTaskButton.Enabled = false;
            this.EditTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditTaskButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditTaskButton.ForeColor = System.Drawing.Color.White;
            this.EditTaskButton.Location = new System.Drawing.Point(860, 548);
            this.EditTaskButton.Name = "EditTaskButton";
            this.EditTaskButton.Size = new System.Drawing.Size(152, 37);
            this.EditTaskButton.TabIndex = 147;
            this.EditTaskButton.Text = "Edit Task";
            this.EditTaskButton.UseVisualStyleBackColor = false;
            this.EditTaskButton.Click += new System.EventHandler(this.EditTaskButton_Click);
            // 
            // CreateTaskButton
            // 
            this.CreateTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateTaskButton.BackColor = System.Drawing.Color.Maroon;
            this.CreateTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateTaskButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTaskButton.ForeColor = System.Drawing.Color.White;
            this.CreateTaskButton.Location = new System.Drawing.Point(702, 548);
            this.CreateTaskButton.Name = "CreateTaskButton";
            this.CreateTaskButton.Size = new System.Drawing.Size(152, 37);
            this.CreateTaskButton.TabIndex = 148;
            this.CreateTaskButton.Text = "Create Task";
            this.CreateTaskButton.UseVisualStyleBackColor = false;
            this.CreateTaskButton.Click += new System.EventHandler(this.CreateTaskButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(9, 19);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(1136, 24);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Controls.Add(this.SearchTextBox);
            this.SearchBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.SearchBox.Location = new System.Drawing.Point(16, 86);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(1154, 52);
            this.SearchBox.TabIndex = 145;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search";
            // 
            // CBoxTaskCategory
            // 
            this.CBoxTaskCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBoxTaskCategory.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.CBoxTaskCategory.FormattingEnabled = true;
            this.CBoxTaskCategory.Location = new System.Drawing.Point(25, 154);
            this.CBoxTaskCategory.Name = "CBoxTaskCategory";
            this.CBoxTaskCategory.Size = new System.Drawing.Size(1008, 25);
            this.CBoxTaskCategory.TabIndex = 149;
            this.CBoxTaskCategory.SelectedValueChanged += new System.EventHandler(this.CBoxTaskCategory_SelectedValueChanged);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddCategoryButton.BackColor = System.Drawing.Color.Maroon;
            this.AddCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategoryButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.AddCategoryButton.ForeColor = System.Drawing.Color.White;
            this.AddCategoryButton.Location = new System.Drawing.Point(1039, 144);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(122, 39);
            this.AddCategoryButton.TabIndex = 150;
            this.AddCategoryButton.Text = "Add Category";
            this.AddCategoryButton.UseVisualStyleBackColor = false;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // TaskGridView
            // 
            this.TaskGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TaskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TaskGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.TaskGridView.Location = new System.Drawing.Point(25, 189);
            this.TaskGridView.Name = "TaskGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TaskGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TaskGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TaskGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TaskGridView.Size = new System.Drawing.Size(1136, 343);
            this.TaskGridView.TabIndex = 151;
            this.TaskGridView.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.TaskGridView_RowStateChanged);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Maroon;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(1018, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(152, 37);
            this.HomeButton.TabIndex = 154;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // MasterTaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 597);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.TaskGridView);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.CBoxTaskCategory);
            this.Controls.Add(this.CreateTaskButton);
            this.Controls.Add(this.EditTaskButton);
            this.Controls.Add(this.DeleteTaskButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.PictureBox1);
            this.Name = "MasterTaskManager";
            this.Text = "Master Tasks";
            this.Load += new System.EventHandler(this.MasterTaskManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button DeleteTaskButton;
        internal System.Windows.Forms.Button EditTaskButton;
        internal System.Windows.Forms.Button CreateTaskButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.ComboBox CBoxTaskCategory;
        internal System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.DataGridView TaskGridView;
        internal System.Windows.Forms.Button HomeButton;
    }
}