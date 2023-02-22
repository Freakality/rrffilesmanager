
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
            this.AdminPortalUserLawyerBox = new System.Windows.Forms.GroupBox();
            this.AdminPortalUserLawyerListBox = new System.Windows.Forms.ListBox();
            this.AdminLawyerTaskView = new System.Windows.Forms.DataGridView();
            this.AdminPortalSaveChangesButton = new System.Windows.Forms.Button();
            this.AdminPortalAddTaskButton = new System.Windows.Forms.Button();
            this.AdminPortalTaskStateComboBox = new System.Windows.Forms.ComboBox();
            this.AdminPortalSearchTextBox = new System.Windows.Forms.TextBox();
            this.AdminPortalMainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.AdminPortalTopSplitContainer = new System.Windows.Forms.SplitContainer();
            this.AdminPortalGridLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AdminPortalButtonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AdminPortalUserLawyerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminLawyerTaskView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPortalMainSplitContainer)).BeginInit();
            this.AdminPortalMainSplitContainer.Panel1.SuspendLayout();
            this.AdminPortalMainSplitContainer.Panel2.SuspendLayout();
            this.AdminPortalMainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminPortalTopSplitContainer)).BeginInit();
            this.AdminPortalTopSplitContainer.Panel1.SuspendLayout();
            this.AdminPortalTopSplitContainer.Panel2.SuspendLayout();
            this.AdminPortalTopSplitContainer.SuspendLayout();
            this.AdminPortalGridLayoutPanel.SuspendLayout();
            this.AdminPortalButtonLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminPortalUserLawyerBox
            // 
            this.AdminPortalUserLawyerBox.Controls.Add(this.AdminPortalUserLawyerListBox);
            this.AdminPortalUserLawyerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPortalUserLawyerBox.Location = new System.Drawing.Point(0, 0);
            this.AdminPortalUserLawyerBox.Margin = new System.Windows.Forms.Padding(6);
            this.AdminPortalUserLawyerBox.Name = "AdminPortalUserLawyerBox";
            this.AdminPortalUserLawyerBox.Padding = new System.Windows.Forms.Padding(6);
            this.AdminPortalUserLawyerBox.Size = new System.Drawing.Size(214, 455);
            this.AdminPortalUserLawyerBox.TabIndex = 147;
            this.AdminPortalUserLawyerBox.TabStop = false;
            this.AdminPortalUserLawyerBox.Text = "Users / Lawyers";
            // 
            // AdminPortalUserLawyerListBox
            // 
            this.AdminPortalUserLawyerListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPortalUserLawyerListBox.FormattingEnabled = true;
            this.AdminPortalUserLawyerListBox.ItemHeight = 20;
            this.AdminPortalUserLawyerListBox.Location = new System.Drawing.Point(6, 25);
            this.AdminPortalUserLawyerListBox.Margin = new System.Windows.Forms.Padding(6);
            this.AdminPortalUserLawyerListBox.Name = "AdminPortalUserLawyerListBox";
            this.AdminPortalUserLawyerListBox.Size = new System.Drawing.Size(202, 424);
            this.AdminPortalUserLawyerListBox.TabIndex = 145;
            this.AdminPortalUserLawyerListBox.SelectedIndexChanged += new System.EventHandler(this.UserLawyerListBox_SelectedIndexChanged);
            // 
            // AdminLawyerTaskView
            // 
            this.AdminLawyerTaskView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminPortalGridLayoutPanel.SetColumnSpan(this.AdminLawyerTaskView, 2);
            this.AdminLawyerTaskView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminLawyerTaskView.Location = new System.Drawing.Point(4, 39);
            this.AdminLawyerTaskView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminLawyerTaskView.Name = "AdminLawyerTaskView";
            this.AdminLawyerTaskView.Size = new System.Drawing.Size(606, 411);
            this.AdminLawyerTaskView.TabIndex = 148;
            // 
            // AdminPortalSaveChangesButton
            // 
            this.AdminPortalSaveChangesButton.BackColor = System.Drawing.Color.Maroon;
            this.AdminPortalSaveChangesButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPortalSaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminPortalSaveChangesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPortalSaveChangesButton.ForeColor = System.Drawing.Color.White;
            this.AdminPortalSaveChangesButton.Location = new System.Drawing.Point(661, 5);
            this.AdminPortalSaveChangesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminPortalSaveChangesButton.Name = "AdminPortalSaveChangesButton";
            this.AdminPortalSaveChangesButton.Size = new System.Drawing.Size(167, 43);
            this.AdminPortalSaveChangesButton.TabIndex = 154;
            this.AdminPortalSaveChangesButton.Text = "Save Changes";
            this.AdminPortalSaveChangesButton.UseVisualStyleBackColor = false;
            this.AdminPortalSaveChangesButton.Click += new System.EventHandler(this.AdminPortalSaveChangesButton_Click);
            // 
            // AdminPortalAddTaskButton
            // 
            this.AdminPortalAddTaskButton.BackColor = System.Drawing.Color.Maroon;
            this.AdminPortalAddTaskButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPortalAddTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminPortalAddTaskButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPortalAddTaskButton.ForeColor = System.Drawing.Color.White;
            this.AdminPortalAddTaskButton.Location = new System.Drawing.Point(551, 5);
            this.AdminPortalAddTaskButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminPortalAddTaskButton.Name = "AdminPortalAddTaskButton";
            this.AdminPortalAddTaskButton.Size = new System.Drawing.Size(102, 43);
            this.AdminPortalAddTaskButton.TabIndex = 155;
            this.AdminPortalAddTaskButton.Text = "Add Task";
            this.AdminPortalAddTaskButton.UseVisualStyleBackColor = false;
            this.AdminPortalAddTaskButton.Click += new System.EventHandler(this.AdminPortalAddTaskButton_Click);
            // 
            // AdminPortalTaskStateComboBox
            // 
            this.AdminPortalTaskStateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminPortalTaskStateComboBox.FormattingEnabled = true;
            this.AdminPortalTaskStateComboBox.ItemHeight = 20;
            this.AdminPortalTaskStateComboBox.Location = new System.Drawing.Point(4, 6);
            this.AdminPortalTaskStateComboBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminPortalTaskStateComboBox.Name = "AdminPortalTaskStateComboBox";
            this.AdminPortalTaskStateComboBox.Size = new System.Drawing.Size(133, 28);
            this.AdminPortalTaskStateComboBox.TabIndex = 156;
            this.AdminPortalTaskStateComboBox.SelectedIndexChanged += new System.EventHandler(this.AdminPortalFileStatusComboBox_SelectedIndexChanged);
            // 
            // AdminPortalSearchTextBox
            // 
            this.AdminPortalSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminPortalSearchTextBox.Location = new System.Drawing.Point(145, 5);
            this.AdminPortalSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminPortalSearchTextBox.Name = "AdminPortalSearchTextBox";
            this.AdminPortalSearchTextBox.Size = new System.Drawing.Size(465, 26);
            this.AdminPortalSearchTextBox.TabIndex = 157;
            this.AdminPortalSearchTextBox.TextChanged += new System.EventHandler(this.AdminPortalSearchTextBox_TextChanged);
            // 
            // AdminPortalMainSplitContainer
            // 
            this.AdminPortalMainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPortalMainSplitContainer.IsSplitterFixed = true;
            this.AdminPortalMainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.AdminPortalMainSplitContainer.Name = "AdminPortalMainSplitContainer";
            this.AdminPortalMainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // AdminPortalMainSplitContainer.Panel1
            // 
            this.AdminPortalMainSplitContainer.Panel1.Controls.Add(this.AdminPortalTopSplitContainer);
            // 
            // AdminPortalMainSplitContainer.Panel2
            // 
            this.AdminPortalMainSplitContainer.Panel2.Controls.Add(this.AdminPortalButtonLayoutPanel);
            this.AdminPortalMainSplitContainer.Size = new System.Drawing.Size(832, 512);
            this.AdminPortalMainSplitContainer.SplitterDistance = 455;
            this.AdminPortalMainSplitContainer.TabIndex = 158;
            // 
            // AdminPortalTopSplitContainer
            // 
            this.AdminPortalTopSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPortalTopSplitContainer.IsSplitterFixed = true;
            this.AdminPortalTopSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.AdminPortalTopSplitContainer.Name = "AdminPortalTopSplitContainer";
            // 
            // AdminPortalTopSplitContainer.Panel1
            // 
            this.AdminPortalTopSplitContainer.Panel1.Controls.Add(this.AdminPortalUserLawyerBox);
            // 
            // AdminPortalTopSplitContainer.Panel2
            // 
            this.AdminPortalTopSplitContainer.Panel2.Controls.Add(this.AdminPortalGridLayoutPanel);
            this.AdminPortalTopSplitContainer.Size = new System.Drawing.Size(832, 455);
            this.AdminPortalTopSplitContainer.SplitterDistance = 214;
            this.AdminPortalTopSplitContainer.TabIndex = 159;
            // 
            // AdminPortalGridLayoutPanel
            // 
            this.AdminPortalGridLayoutPanel.ColumnCount = 2;
            this.AdminPortalGridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.049F));
            this.AdminPortalGridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.951F));
            this.AdminPortalGridLayoutPanel.Controls.Add(this.AdminPortalTaskStateComboBox, 0, 0);
            this.AdminPortalGridLayoutPanel.Controls.Add(this.AdminPortalSearchTextBox, 1, 0);
            this.AdminPortalGridLayoutPanel.Controls.Add(this.AdminLawyerTaskView, 0, 1);
            this.AdminPortalGridLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPortalGridLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminPortalGridLayoutPanel.Name = "AdminPortalGridLayoutPanel";
            this.AdminPortalGridLayoutPanel.RowCount = 2;
            this.AdminPortalGridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.488987F));
            this.AdminPortalGridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.51102F));
            this.AdminPortalGridLayoutPanel.Size = new System.Drawing.Size(614, 455);
            this.AdminPortalGridLayoutPanel.TabIndex = 158;
            // 
            // AdminPortalButtonLayoutPanel
            // 
            this.AdminPortalButtonLayoutPanel.ColumnCount = 3;
            this.AdminPortalButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 547F));
            this.AdminPortalButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.68853F));
            this.AdminPortalButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.31147F));
            this.AdminPortalButtonLayoutPanel.Controls.Add(this.AdminPortalAddTaskButton, 1, 0);
            this.AdminPortalButtonLayoutPanel.Controls.Add(this.AdminPortalSaveChangesButton, 2, 0);
            this.AdminPortalButtonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminPortalButtonLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminPortalButtonLayoutPanel.Name = "AdminPortalButtonLayoutPanel";
            this.AdminPortalButtonLayoutPanel.RowCount = 1;
            this.AdminPortalButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AdminPortalButtonLayoutPanel.Size = new System.Drawing.Size(832, 53);
            this.AdminPortalButtonLayoutPanel.TabIndex = 156;
            // 
            // AdminViewControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdminPortalMainSplitContainer);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminViewControls";
            this.Size = new System.Drawing.Size(832, 512);
            this.AdminPortalUserLawyerBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminLawyerTaskView)).EndInit();
            this.AdminPortalMainSplitContainer.Panel1.ResumeLayout(false);
            this.AdminPortalMainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminPortalMainSplitContainer)).EndInit();
            this.AdminPortalMainSplitContainer.ResumeLayout(false);
            this.AdminPortalTopSplitContainer.Panel1.ResumeLayout(false);
            this.AdminPortalTopSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminPortalTopSplitContainer)).EndInit();
            this.AdminPortalTopSplitContainer.ResumeLayout(false);
            this.AdminPortalGridLayoutPanel.ResumeLayout(false);
            this.AdminPortalGridLayoutPanel.PerformLayout();
            this.AdminPortalButtonLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AdminPortalUserLawyerBox;
        private System.Windows.Forms.ListBox AdminPortalUserLawyerListBox;
        private System.Windows.Forms.DataGridView AdminLawyerTaskView;
        internal System.Windows.Forms.Button AdminPortalSaveChangesButton;
        internal System.Windows.Forms.Button AdminPortalAddTaskButton;
        private System.Windows.Forms.ComboBox AdminPortalTaskStateComboBox;
        private System.Windows.Forms.TextBox AdminPortalSearchTextBox;
        private System.Windows.Forms.TableLayoutPanel AdminPortalGridLayoutPanel;
        private System.Windows.Forms.SplitContainer AdminPortalMainSplitContainer;
        private System.Windows.Forms.SplitContainer AdminPortalTopSplitContainer;
        private System.Windows.Forms.TableLayoutPanel AdminPortalButtonLayoutPanel;
    }
}
