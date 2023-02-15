
namespace RRFFilesManager.Controls.FileControls
{
    partial class TaskManager
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
            this.Btn_Save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Gb_Notes = new System.Windows.Forms.GroupBox();
            this.Txt_Notes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Gb_Dates = new System.Windows.Forms.GroupBox();
            this.Dtp_WorkedOnDate2 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.Dtp_WorkedOnDate3 = new System.Windows.Forms.Label();
            this.Dtp_WorkedOnDate1 = new System.Windows.Forms.DateTimePicker();
            this.Dtp_StartedDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Dtp_DeferUntilDate = new System.Windows.Forms.DateTimePicker();
            this.Dtp_DueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Gb_Tasks = new System.Windows.Forms.GroupBox();
            this.Cbb_Tasks = new System.Windows.Forms.ComboBox();
            this.Cbb_TaskCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Gb_Notes.SuspendLayout();
            this.Gb_Dates.SuspendLayout();
            this.Gb_Tasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Save
            // 
            this.Btn_Save.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Location = new System.Drawing.Point(12, 15);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(152, 38);
            this.Btn_Save.TabIndex = 147;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 71);
            this.panel1.TabIndex = 148;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.Gb_Notes);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Gb_Dates);
            this.panel2.Controls.Add(this.Gb_Tasks);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 379);
            this.panel2.TabIndex = 149;
            // 
            // Gb_Notes
            // 
            this.Gb_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_Notes.BackColor = System.Drawing.Color.White;
            this.Gb_Notes.Controls.Add(this.Txt_Notes);
            this.Gb_Notes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Notes.Location = new System.Drawing.Point(12, 356);
            this.Gb_Notes.Name = "Gb_Notes";
            this.Gb_Notes.Size = new System.Drawing.Size(798, 129);
            this.Gb_Notes.TabIndex = 17;
            this.Gb_Notes.TabStop = false;
            this.Gb_Notes.Text = "Notes";
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Notes.Enabled = false;
            this.Txt_Notes.Location = new System.Drawing.Point(13, 35);
            this.Txt_Notes.Multiline = true;
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.Size = new System.Drawing.Size(771, 82);
            this.Txt_Notes.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Add Task";
            // 
            // Gb_Dates
            // 
            this.Gb_Dates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_Dates.BackColor = System.Drawing.Color.White;
            this.Gb_Dates.Controls.Add(this.Dtp_WorkedOnDate2);
            this.Gb_Dates.Controls.Add(this.dateTimePicker5);
            this.Gb_Dates.Controls.Add(this.dateTimePicker6);
            this.Gb_Dates.Controls.Add(this.Dtp_WorkedOnDate3);
            this.Gb_Dates.Controls.Add(this.Dtp_WorkedOnDate1);
            this.Gb_Dates.Controls.Add(this.Dtp_StartedDate);
            this.Gb_Dates.Controls.Add(this.label5);
            this.Gb_Dates.Controls.Add(this.label6);
            this.Gb_Dates.Controls.Add(this.Dtp_DeferUntilDate);
            this.Gb_Dates.Controls.Add(this.Dtp_DueDate);
            this.Gb_Dates.Controls.Add(this.label3);
            this.Gb_Dates.Controls.Add(this.label4);
            this.Gb_Dates.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Dates.Location = new System.Drawing.Point(12, 209);
            this.Gb_Dates.Name = "Gb_Dates";
            this.Gb_Dates.Size = new System.Drawing.Size(798, 129);
            this.Gb_Dates.TabIndex = 15;
            this.Gb_Dates.TabStop = false;
            this.Gb_Dates.Text = "Dates";
            // 
            // Dtp_WorkedOnDate2
            // 
            this.Dtp_WorkedOnDate2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtp_WorkedOnDate2.AutoSize = true;
            this.Dtp_WorkedOnDate2.Location = new System.Drawing.Point(515, 49);
            this.Dtp_WorkedOnDate2.Name = "Dtp_WorkedOnDate2";
            this.Dtp_WorkedOnDate2.Size = new System.Drawing.Size(140, 19);
            this.Dtp_WorkedOnDate2.TabIndex = 12;
            this.Dtp_WorkedOnDate2.Text = "WorkedOnDate2:";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker5.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker5.Enabled = false;
            this.dateTimePicker5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker5.Location = new System.Drawing.Point(661, 84);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(123, 26);
            this.dateTimePicker5.TabIndex = 11;
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker6.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker6.Enabled = false;
            this.dateTimePicker6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker6.Location = new System.Drawing.Point(661, 42);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(123, 26);
            this.dateTimePicker6.TabIndex = 10;
            // 
            // Dtp_WorkedOnDate3
            // 
            this.Dtp_WorkedOnDate3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Dtp_WorkedOnDate3.AutoSize = true;
            this.Dtp_WorkedOnDate3.Location = new System.Drawing.Point(515, 89);
            this.Dtp_WorkedOnDate3.Name = "Dtp_WorkedOnDate3";
            this.Dtp_WorkedOnDate3.Size = new System.Drawing.Size(140, 19);
            this.Dtp_WorkedOnDate3.TabIndex = 9;
            this.Dtp_WorkedOnDate3.Text = "WorkedOnDate3:";
            // 
            // Dtp_WorkedOnDate1
            // 
            this.Dtp_WorkedOnDate1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Dtp_WorkedOnDate1.CustomFormat = "dd-MM-yyyy";
            this.Dtp_WorkedOnDate1.Enabled = false;
            this.Dtp_WorkedOnDate1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_WorkedOnDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_WorkedOnDate1.Location = new System.Drawing.Point(386, 89);
            this.Dtp_WorkedOnDate1.Name = "Dtp_WorkedOnDate1";
            this.Dtp_WorkedOnDate1.Size = new System.Drawing.Size(123, 26);
            this.Dtp_WorkedOnDate1.TabIndex = 7;
            // 
            // Dtp_StartedDate
            // 
            this.Dtp_StartedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Dtp_StartedDate.CustomFormat = "dd-MM-yyyy";
            this.Dtp_StartedDate.Enabled = false;
            this.Dtp_StartedDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_StartedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_StartedDate.Location = new System.Drawing.Point(386, 47);
            this.Dtp_StartedDate.Name = "Dtp_StartedDate";
            this.Dtp_StartedDate.Size = new System.Drawing.Size(123, 26);
            this.Dtp_StartedDate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "WorkedOnDate1:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Started Date:";
            // 
            // Dtp_DeferUntilDate
            // 
            this.Dtp_DeferUntilDate.CustomFormat = "dd-MM-yyyy";
            this.Dtp_DeferUntilDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_DeferUntilDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_DeferUntilDate.Location = new System.Drawing.Point(113, 87);
            this.Dtp_DeferUntilDate.Name = "Dtp_DeferUntilDate";
            this.Dtp_DeferUntilDate.Size = new System.Drawing.Size(123, 26);
            this.Dtp_DeferUntilDate.TabIndex = 3;
            // 
            // Dtp_DueDate
            // 
            this.Dtp_DueDate.CustomFormat = "dd-MM-yyyy";
            this.Dtp_DueDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_DueDate.Location = new System.Drawing.Point(113, 44);
            this.Dtp_DueDate.Name = "Dtp_DueDate";
            this.Dtp_DueDate.Size = new System.Drawing.Size(123, 26);
            this.Dtp_DueDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Defer until:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Due Date:";
            // 
            // Gb_Tasks
            // 
            this.Gb_Tasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_Tasks.BackColor = System.Drawing.Color.White;
            this.Gb_Tasks.Controls.Add(this.Cbb_Tasks);
            this.Gb_Tasks.Controls.Add(this.Cbb_TaskCategories);
            this.Gb_Tasks.Controls.Add(this.label2);
            this.Gb_Tasks.Controls.Add(this.label1);
            this.Gb_Tasks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Tasks.Location = new System.Drawing.Point(12, 57);
            this.Gb_Tasks.Name = "Gb_Tasks";
            this.Gb_Tasks.Size = new System.Drawing.Size(798, 146);
            this.Gb_Tasks.TabIndex = 14;
            this.Gb_Tasks.TabStop = false;
            this.Gb_Tasks.Text = "Select Task";
            // 
            // Cbb_Tasks
            // 
            this.Cbb_Tasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbb_Tasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb_Tasks.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_Tasks.FormattingEnabled = true;
            this.Cbb_Tasks.Location = new System.Drawing.Point(123, 94);
            this.Cbb_Tasks.Name = "Cbb_Tasks";
            this.Cbb_Tasks.Size = new System.Drawing.Size(661, 28);
            this.Cbb_Tasks.TabIndex = 3;
            this.Cbb_Tasks.SelectedIndexChanged += new System.EventHandler(this.Cbb_Tasks_SelectedIndexChanged);
            // 
            // Cbb_TaskCategories
            // 
            this.Cbb_TaskCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbb_TaskCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb_TaskCategories.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_TaskCategories.FormattingEnabled = true;
            this.Cbb_TaskCategories.Location = new System.Drawing.Point(123, 44);
            this.Cbb_TaskCategories.Name = "Cbb_TaskCategories";
            this.Cbb_TaskCategories.Size = new System.Drawing.Size(661, 28);
            this.Cbb_TaskCategories.TabIndex = 2;
            this.Cbb_TaskCategories.SelectedIndexChanged += new System.EventHandler(this.Cbb_TaskCategories_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category:";
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(838, 489);
            this.Name = "TaskManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TaskManager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Gb_Notes.ResumeLayout(false);
            this.Gb_Notes.PerformLayout();
            this.Gb_Dates.ResumeLayout(false);
            this.Gb_Dates.PerformLayout();
            this.Gb_Tasks.ResumeLayout(false);
            this.Gb_Tasks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox Gb_Notes;
        private System.Windows.Forms.TextBox Txt_Notes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox Gb_Dates;
        private System.Windows.Forms.Label Dtp_WorkedOnDate2;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Label Dtp_WorkedOnDate3;
        private System.Windows.Forms.DateTimePicker Dtp_WorkedOnDate1;
        private System.Windows.Forms.DateTimePicker Dtp_StartedDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker Dtp_DeferUntilDate;
        private System.Windows.Forms.DateTimePicker Dtp_DueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Gb_Tasks;
        private System.Windows.Forms.ComboBox Cbb_Tasks;
        private System.Windows.Forms.ComboBox Cbb_TaskCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}