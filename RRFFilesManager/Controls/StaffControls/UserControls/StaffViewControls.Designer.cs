
namespace RRFFilesManager.Controls.StaffControls.UserControls
{
    partial class StaffViewControls
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(822, 408);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.BackColor = System.Drawing.Color.Maroon;
            this.AddTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTaskButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTaskButton.ForeColor = System.Drawing.Color.White;
            this.AddTaskButton.Location = new System.Drawing.Point(517, 444);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(152, 37);
            this.AddTaskButton.TabIndex = 157;
            this.AddTaskButton.Text = "Add Task";
            this.AddTaskButton.UseVisualStyleBackColor = false;
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.Color.Maroon;
            this.SaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChangesButton.ForeColor = System.Drawing.Color.White;
            this.SaveChangesButton.Location = new System.Drawing.Point(686, 444);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(152, 37);
            this.SaveChangesButton.TabIndex = 156;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            // 
            // StaffViewControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddTaskButton);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StaffViewControls";
            this.Size = new System.Drawing.Size(859, 504);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button AddTaskButton;
        internal System.Windows.Forms.Button SaveChangesButton;
    }
}
