
namespace RRFFilesManager.Controls.MasterTaskControls
{
    partial class CreateEditTask
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CBoxCategory = new System.Windows.Forms.ComboBox();
            this.TBoxDependencies = new System.Windows.Forms.TextBox();
            this.NBoxDueBy = new System.Windows.Forms.NumericUpDown();
            this.TBoxTaskName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBoxToBeCompletedBy = new System.Windows.Forms.ComboBox();
            this.NBoxDeferBy = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckLockDue = new System.Windows.Forms.CheckBox();
            this.SelectDependenciesButton = new System.Windows.Forms.Button();
            this.CancelDialogButton = new System.Windows.Forms.Button();
            this.AddEditTaskButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NBoxDueBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBoxDeferBy)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel1.Controls.Add(this.CBoxCategory, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TBoxDependencies, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.NBoxDueBy, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBoxTaskName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CBoxToBeCompletedBy, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.NBoxDeferBy, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.CheckLockDue, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.SelectDependenciesButton, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(729, 163);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // CBoxCategory
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CBoxCategory, 4);
            this.CBoxCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBoxCategory.FormattingEnabled = true;
            this.CBoxCategory.Location = new System.Drawing.Point(181, 131);
            this.CBoxCategory.Name = "CBoxCategory";
            this.CBoxCategory.Size = new System.Drawing.Size(547, 25);
            this.CBoxCategory.TabIndex = 157;
            // 
            // TBoxDependencies
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TBoxDependencies, 3);
            this.TBoxDependencies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBoxDependencies.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TBoxDependencies.Location = new System.Drawing.Point(181, 67);
            this.TBoxDependencies.Name = "TBoxDependencies";
            this.TBoxDependencies.Size = new System.Drawing.Size(369, 23);
            this.TBoxDependencies.TabIndex = 154;
            // 
            // NBoxDueBy
            // 
            this.NBoxDueBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NBoxDueBy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBoxDueBy.Location = new System.Drawing.Point(181, 35);
            this.NBoxDueBy.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NBoxDueBy.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.NBoxDueBy.Name = "NBoxDueBy";
            this.NBoxDueBy.Size = new System.Drawing.Size(166, 26);
            this.NBoxDueBy.TabIndex = 152;
            // 
            // TBoxTaskName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TBoxTaskName, 4);
            this.TBoxTaskName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBoxTaskName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBoxTaskName.Location = new System.Drawing.Point(181, 3);
            this.TBoxTaskName.Name = "TBoxTaskName";
            this.TBoxTaskName.Size = new System.Drawing.Size(547, 23);
            this.TBoxTaskName.TabIndex = 152;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dependencies";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Due By";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Label2.Location = new System.Drawing.Point(3, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(172, 32);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Description*";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(3, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "To Be Completed By*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(3, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "Category*";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CBoxToBeCompletedBy
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CBoxToBeCompletedBy, 4);
            this.CBoxToBeCompletedBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBoxToBeCompletedBy.FormattingEnabled = true;
            this.CBoxToBeCompletedBy.Location = new System.Drawing.Point(181, 99);
            this.CBoxToBeCompletedBy.Name = "CBoxToBeCompletedBy";
            this.CBoxToBeCompletedBy.Size = new System.Drawing.Size(547, 25);
            this.CBoxToBeCompletedBy.TabIndex = 155;
            // 
            // NBoxDeferBy
            // 
            this.NBoxDeferBy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NBoxDeferBy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBoxDeferBy.Location = new System.Drawing.Point(556, 35);
            this.NBoxDeferBy.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NBoxDeferBy.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.NBoxDeferBy.Name = "NBoxDeferBy";
            this.NBoxDeferBy.Size = new System.Drawing.Size(172, 26);
            this.NBoxDeferBy.TabIndex = 153;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(473, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Defer By";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CheckLockDue
            // 
            this.CheckLockDue.AutoSize = true;
            this.CheckLockDue.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckLockDue.Location = new System.Drawing.Point(353, 35);
            this.CheckLockDue.Name = "CheckLockDue";
            this.CheckLockDue.Size = new System.Drawing.Size(114, 24);
            this.CheckLockDue.TabIndex = 156;
            this.CheckLockDue.Text = "Lock Due Date";
            this.CheckLockDue.UseVisualStyleBackColor = true;
            // 
            // SelectDependenciesButton
            // 
            this.SelectDependenciesButton.BackColor = System.Drawing.Color.Maroon;
            this.SelectDependenciesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectDependenciesButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDependenciesButton.ForeColor = System.Drawing.Color.White;
            this.SelectDependenciesButton.Location = new System.Drawing.Point(556, 67);
            this.SelectDependenciesButton.Name = "SelectDependenciesButton";
            this.SelectDependenciesButton.Size = new System.Drawing.Size(172, 26);
            this.SelectDependenciesButton.TabIndex = 152;
            this.SelectDependenciesButton.Text = "Select Dependencies";
            this.SelectDependenciesButton.UseVisualStyleBackColor = false;
            this.SelectDependenciesButton.Click += new System.EventHandler(this.SelectDependenciesButton_Click);
            // 
            // CancelDialogButton
            // 
            this.CancelDialogButton.BackColor = System.Drawing.Color.Maroon;
            this.CancelDialogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelDialogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelDialogButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelDialogButton.ForeColor = System.Drawing.Color.White;
            this.CancelDialogButton.Location = new System.Drawing.Point(596, 206);
            this.CancelDialogButton.Name = "CancelDialogButton";
            this.CancelDialogButton.Size = new System.Drawing.Size(152, 37);
            this.CancelDialogButton.TabIndex = 149;
            this.CancelDialogButton.Text = "Cancel";
            this.CancelDialogButton.UseVisualStyleBackColor = false;
            // 
            // AddEditTaskButton
            // 
            this.AddEditTaskButton.BackColor = System.Drawing.Color.Maroon;
            this.AddEditTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEditTaskButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEditTaskButton.ForeColor = System.Drawing.Color.White;
            this.AddEditTaskButton.Location = new System.Drawing.Point(438, 206);
            this.AddEditTaskButton.Name = "AddEditTaskButton";
            this.AddEditTaskButton.Size = new System.Drawing.Size(152, 37);
            this.AddEditTaskButton.TabIndex = 150;
            this.AddEditTaskButton.Text = "Add";
            this.AddEditTaskButton.UseVisualStyleBackColor = false;
            this.AddEditTaskButton.Click += new System.EventHandler(this.AddEditTaskButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 188);
            this.groupBox1.TabIndex = 151;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fields";
            // 
            // CreateEditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelDialogButton;
            this.ClientSize = new System.Drawing.Size(768, 251);
            this.Controls.Add(this.AddEditTaskButton);
            this.Controls.Add(this.CancelDialogButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateEditTask";
            this.Text = " ";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NBoxDueBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBoxDeferBy)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button CancelDialogButton;
        internal System.Windows.Forms.Button AddEditTaskButton;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox TBoxTaskName;
        private System.Windows.Forms.ComboBox CBoxCategory;
        internal System.Windows.Forms.TextBox TBoxDependencies;
        private System.Windows.Forms.NumericUpDown NBoxDueBy;
        private System.Windows.Forms.ComboBox CBoxToBeCompletedBy;
        private System.Windows.Forms.NumericUpDown NBoxDeferBy;
        private System.Windows.Forms.CheckBox CheckLockDue;
        internal System.Windows.Forms.Button SelectDependenciesButton;
    }
}