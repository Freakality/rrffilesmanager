
namespace RRFFilesManager.Controls.StaffControls.UserControls
{
    partial class AdminViewControls
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
            this.UserLawyerBox = new System.Windows.Forms.GroupBox();
            this.UserLawyerListBox = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.UserLawyerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserLawyerBox
            // 
            this.UserLawyerBox.Controls.Add(this.UserLawyerListBox);
            this.UserLawyerBox.Location = new System.Drawing.Point(4, 19);
            this.UserLawyerBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserLawyerBox.Name = "UserLawyerBox";
            this.UserLawyerBox.Padding = new System.Windows.Forms.Padding(4);
            this.UserLawyerBox.Size = new System.Drawing.Size(299, 459);
            this.UserLawyerBox.TabIndex = 147;
            this.UserLawyerBox.TabStop = false;
            this.UserLawyerBox.Text = "Users / Lawyers";
            // 
            // UserLawyerListBox
            // 
            this.UserLawyerListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserLawyerListBox.FormattingEnabled = true;
            this.UserLawyerListBox.Location = new System.Drawing.Point(4, 17);
            this.UserLawyerListBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserLawyerListBox.Name = "UserLawyerListBox";
            this.UserLawyerListBox.Size = new System.Drawing.Size(291, 438);
            this.UserLawyerListBox.TabIndex = 145;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(326, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 402);
            this.dataGridView1.TabIndex = 148;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.Color.Maroon;
            this.SaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChangesButton.ForeColor = System.Drawing.Color.White;
            this.SaveChangesButton.Location = new System.Drawing.Point(782, 437);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(152, 37);
            this.SaveChangesButton.TabIndex = 154;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.BackColor = System.Drawing.Color.Maroon;
            this.AddTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTaskButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTaskButton.ForeColor = System.Drawing.Color.White;
            this.AddTaskButton.Location = new System.Drawing.Point(613, 437);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(152, 37);
            this.AddTaskButton.TabIndex = 155;
            this.AddTaskButton.Text = "Add Task";
            this.AddTaskButton.UseVisualStyleBackColor = false;
            // 
            // AdminViewControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.UserLawyerBox);
            this.Name = "AdminViewControls";
            this.Size = new System.Drawing.Size(951, 498);
            this.UserLawyerBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox UserLawyerBox;
        private System.Windows.Forms.ListBox UserLawyerListBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button SaveChangesButton;
        internal System.Windows.Forms.Button AddTaskButton;
    }
}
