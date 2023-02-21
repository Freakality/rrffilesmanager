
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
            this.Gb_TypeOfTaskToAdd = new System.Windows.Forms.GroupBox();
            this.Rb_NewTask = new System.Windows.Forms.RadioButton();
            this.Rb_PrevioslyCreatedTask = new System.Windows.Forms.RadioButton();
            this.Gb_Notes = new System.Windows.Forms.GroupBox();
            this.Txt_Notes = new System.Windows.Forms.TextBox();
            this.Gb_NewTask = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_NewTaskDescription = new System.Windows.Forms.TextBox();
            this.Dtp_DeferUntilDate = new System.Windows.Forms.DateTimePicker();
            this.Dtp_DueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Gb_PrevioslyCreatedTasks = new System.Windows.Forms.GroupBox();
            this.Cbb_Tasks = new System.Windows.Forms.ComboBox();
            this.Cbb_TaskCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbb_ResponsibleLawyer = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Lbl_ResponsibleLawyer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Gb_TypeOfTaskToAdd.SuspendLayout();
            this.Gb_Notes.SuspendLayout();
            this.Gb_NewTask.SuspendLayout();
            this.Gb_PrevioslyCreatedTasks.SuspendLayout();
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
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Save);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 71);
            this.panel1.TabIndex = 148;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.Gb_TypeOfTaskToAdd);
            this.panel2.Controls.Add(this.Gb_Notes);
            this.panel2.Controls.Add(this.Gb_NewTask);
            this.panel2.Controls.Add(this.Gb_PrevioslyCreatedTasks);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 379);
            this.panel2.TabIndex = 149;
            // 
            // Gb_TypeOfTaskToAdd
            // 
            this.Gb_TypeOfTaskToAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_TypeOfTaskToAdd.BackColor = System.Drawing.Color.White;
            this.Gb_TypeOfTaskToAdd.Controls.Add(this.Rb_NewTask);
            this.Gb_TypeOfTaskToAdd.Controls.Add(this.Rb_PrevioslyCreatedTask);
            this.Gb_TypeOfTaskToAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Gb_TypeOfTaskToAdd.Location = new System.Drawing.Point(12, 26);
            this.Gb_TypeOfTaskToAdd.Name = "Gb_TypeOfTaskToAdd";
            this.Gb_TypeOfTaskToAdd.Size = new System.Drawing.Size(820, 98);
            this.Gb_TypeOfTaskToAdd.TabIndex = 18;
            this.Gb_TypeOfTaskToAdd.TabStop = false;
            this.Gb_TypeOfTaskToAdd.Text = "Indicates what type of task to add";
            // 
            // Rb_NewTask
            // 
            this.Rb_NewTask.AutoSize = true;
            this.Rb_NewTask.Location = new System.Drawing.Point(496, 44);
            this.Rb_NewTask.Name = "Rb_NewTask";
            this.Rb_NewTask.Size = new System.Drawing.Size(99, 23);
            this.Rb_NewTask.TabIndex = 1;
            this.Rb_NewTask.TabStop = true;
            this.Rb_NewTask.Text = "New Task";
            this.Rb_NewTask.UseVisualStyleBackColor = true;
            this.Rb_NewTask.CheckedChanged += new System.EventHandler(this.Rb_NewTask_CheckedChanged);
            // 
            // Rb_PrevioslyCreatedTask
            // 
            this.Rb_PrevioslyCreatedTask.AutoSize = true;
            this.Rb_PrevioslyCreatedTask.Location = new System.Drawing.Point(123, 44);
            this.Rb_PrevioslyCreatedTask.Name = "Rb_PrevioslyCreatedTask";
            this.Rb_PrevioslyCreatedTask.Size = new System.Drawing.Size(192, 23);
            this.Rb_PrevioslyCreatedTask.TabIndex = 0;
            this.Rb_PrevioslyCreatedTask.TabStop = true;
            this.Rb_PrevioslyCreatedTask.Text = "Previosly created task";
            this.Rb_PrevioslyCreatedTask.UseVisualStyleBackColor = true;
            this.Rb_PrevioslyCreatedTask.CheckedChanged += new System.EventHandler(this.Rb_PrevioslyCreatedTask_CheckedChanged);
            // 
            // Gb_Notes
            // 
            this.Gb_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_Notes.BackColor = System.Drawing.Color.White;
            this.Gb_Notes.Controls.Add(this.Txt_Notes);
            this.Gb_Notes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_Notes.Location = new System.Drawing.Point(12, 617);
            this.Gb_Notes.Name = "Gb_Notes";
            this.Gb_Notes.Size = new System.Drawing.Size(820, 129);
            this.Gb_Notes.TabIndex = 17;
            this.Gb_Notes.TabStop = false;
            this.Gb_Notes.Text = "Notes";
            // 
            // Txt_Notes
            // 
            this.Txt_Notes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Notes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Notes.Location = new System.Drawing.Point(13, 35);
            this.Txt_Notes.Multiline = true;
            this.Txt_Notes.Name = "Txt_Notes";
            this.Txt_Notes.Size = new System.Drawing.Size(793, 82);
            this.Txt_Notes.TabIndex = 0;
            // 
            // Gb_NewTask
            // 
            this.Gb_NewTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_NewTask.BackColor = System.Drawing.Color.White;
            this.Gb_NewTask.Controls.Add(this.Cbb_ResponsibleLawyer);
            this.Gb_NewTask.Controls.Add(this.label6);
            this.Gb_NewTask.Controls.Add(this.label5);
            this.Gb_NewTask.Controls.Add(this.Txt_NewTaskDescription);
            this.Gb_NewTask.Controls.Add(this.Dtp_DeferUntilDate);
            this.Gb_NewTask.Controls.Add(this.Dtp_DueDate);
            this.Gb_NewTask.Controls.Add(this.label3);
            this.Gb_NewTask.Controls.Add(this.label4);
            this.Gb_NewTask.Enabled = false;
            this.Gb_NewTask.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_NewTask.Location = new System.Drawing.Point(12, 316);
            this.Gb_NewTask.Name = "Gb_NewTask";
            this.Gb_NewTask.Size = new System.Drawing.Size(820, 296);
            this.Gb_NewTask.TabIndex = 15;
            this.Gb_NewTask.TabStop = false;
            this.Gb_NewTask.Text = "Indicate a new task";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Task Description:";
            // 
            // Txt_NewTaskDescription
            // 
            this.Txt_NewTaskDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_NewTaskDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NewTaskDescription.Location = new System.Drawing.Point(202, 26);
            this.Txt_NewTaskDescription.Multiline = true;
            this.Txt_NewTaskDescription.Name = "Txt_NewTaskDescription";
            this.Txt_NewTaskDescription.Size = new System.Drawing.Size(612, 150);
            this.Txt_NewTaskDescription.TabIndex = 1;
            // 
            // Dtp_DeferUntilDate
            // 
            this.Dtp_DeferUntilDate.CustomFormat = "dd-MM-yyyy";
            this.Dtp_DeferUntilDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_DeferUntilDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_DeferUntilDate.Location = new System.Drawing.Point(472, 194);
            this.Dtp_DeferUntilDate.Name = "Dtp_DeferUntilDate";
            this.Dtp_DeferUntilDate.Size = new System.Drawing.Size(123, 26);
            this.Dtp_DeferUntilDate.TabIndex = 3;
            // 
            // Dtp_DueDate
            // 
            this.Dtp_DueDate.CustomFormat = "dd-MM-yyyy";
            this.Dtp_DueDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtp_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_DueDate.Location = new System.Drawing.Point(202, 194);
            this.Dtp_DueDate.Name = "Dtp_DueDate";
            this.Dtp_DueDate.Size = new System.Drawing.Size(123, 26);
            this.Dtp_DueDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Defer until:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Due Date:";
            // 
            // Gb_PrevioslyCreatedTasks
            // 
            this.Gb_PrevioslyCreatedTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gb_PrevioslyCreatedTasks.BackColor = System.Drawing.Color.White;
            this.Gb_PrevioslyCreatedTasks.Controls.Add(this.Lbl_ResponsibleLawyer);
            this.Gb_PrevioslyCreatedTasks.Controls.Add(this.label7);
            this.Gb_PrevioslyCreatedTasks.Controls.Add(this.Cbb_Tasks);
            this.Gb_PrevioslyCreatedTasks.Controls.Add(this.Cbb_TaskCategories);
            this.Gb_PrevioslyCreatedTasks.Controls.Add(this.label2);
            this.Gb_PrevioslyCreatedTasks.Controls.Add(this.label1);
            this.Gb_PrevioslyCreatedTasks.Enabled = false;
            this.Gb_PrevioslyCreatedTasks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_PrevioslyCreatedTasks.Location = new System.Drawing.Point(12, 130);
            this.Gb_PrevioslyCreatedTasks.Name = "Gb_PrevioslyCreatedTasks";
            this.Gb_PrevioslyCreatedTasks.Size = new System.Drawing.Size(820, 180);
            this.Gb_PrevioslyCreatedTasks.TabIndex = 14;
            this.Gb_PrevioslyCreatedTasks.TabStop = false;
            this.Gb_PrevioslyCreatedTasks.Text = "Select a previously created task";
            // 
            // Cbb_Tasks
            // 
            this.Cbb_Tasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbb_Tasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb_Tasks.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_Tasks.FormattingEnabled = true;
            this.Cbb_Tasks.Location = new System.Drawing.Point(202, 86);
            this.Cbb_Tasks.Name = "Cbb_Tasks";
            this.Cbb_Tasks.Size = new System.Drawing.Size(604, 28);
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
            this.Cbb_TaskCategories.Location = new System.Drawing.Point(202, 44);
            this.Cbb_TaskCategories.Name = "Cbb_TaskCategories";
            this.Cbb_TaskCategories.Size = new System.Drawing.Size(604, 28);
            this.Cbb_TaskCategories.TabIndex = 2;
            this.Cbb_TaskCategories.SelectedIndexChanged += new System.EventHandler(this.Cbb_TaskCategories_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Task:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category:";
            // 
            // Cbb_ResponsibleLawyer
            // 
            this.Cbb_ResponsibleLawyer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbb_ResponsibleLawyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb_ResponsibleLawyer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbb_ResponsibleLawyer.FormattingEnabled = true;
            this.Cbb_ResponsibleLawyer.Location = new System.Drawing.Point(202, 246);
            this.Cbb_ResponsibleLawyer.Name = "Cbb_ResponsibleLawyer";
            this.Cbb_ResponsibleLawyer.Size = new System.Drawing.Size(604, 28);
            this.Cbb_ResponsibleLawyer.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Respoonsible Lawyer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Respoonsible Lawyer:";
            // 
            // Lbl_ResponsibleLawyer
            // 
            this.Lbl_ResponsibleLawyer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_ResponsibleLawyer.BackColor = System.Drawing.Color.Teal;
            this.Lbl_ResponsibleLawyer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ResponsibleLawyer.ForeColor = System.Drawing.Color.White;
            this.Lbl_ResponsibleLawyer.Location = new System.Drawing.Point(202, 135);
            this.Lbl_ResponsibleLawyer.Name = "Lbl_ResponsibleLawyer";
            this.Lbl_ResponsibleLawyer.Size = new System.Drawing.Size(604, 30);
            this.Lbl_ResponsibleLawyer.TabIndex = 8;
            this.Lbl_ResponsibleLawyer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(838, 489);
            this.Name = "TaskManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TaskManager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Gb_TypeOfTaskToAdd.ResumeLayout(false);
            this.Gb_TypeOfTaskToAdd.PerformLayout();
            this.Gb_Notes.ResumeLayout(false);
            this.Gb_Notes.PerformLayout();
            this.Gb_NewTask.ResumeLayout(false);
            this.Gb_NewTask.PerformLayout();
            this.Gb_PrevioslyCreatedTasks.ResumeLayout(false);
            this.Gb_PrevioslyCreatedTasks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox Gb_Notes;
        private System.Windows.Forms.TextBox Txt_Notes;
        private System.Windows.Forms.GroupBox Gb_NewTask;
        private System.Windows.Forms.DateTimePicker Dtp_DeferUntilDate;
        private System.Windows.Forms.DateTimePicker Dtp_DueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Gb_PrevioslyCreatedTasks;
        private System.Windows.Forms.ComboBox Cbb_Tasks;
        private System.Windows.Forms.ComboBox Cbb_TaskCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gb_TypeOfTaskToAdd;
        private System.Windows.Forms.RadioButton Rb_NewTask;
        private System.Windows.Forms.RadioButton Rb_PrevioslyCreatedTask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_NewTaskDescription;
        private System.Windows.Forms.ComboBox Cbb_ResponsibleLawyer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Lbl_ResponsibleLawyer;
        private System.Windows.Forms.Label label7;
    }
}