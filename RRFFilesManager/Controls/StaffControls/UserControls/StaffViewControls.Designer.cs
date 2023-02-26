
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
            this.StaffPortalButtonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StaffPortalAddTaskButton = new System.Windows.Forms.Button();
            this.StaffPortalMainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.StaffPortalGridLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.StaffPortalTaskStateComboBox = new System.Windows.Forms.ComboBox();
            this.StaffPortalSearchTextBox = new System.Windows.Forms.TextBox();
            this.StaffLawyerTaskView = new System.Windows.Forms.DataGridView();
            this.StaffPortalButtonLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffPortalMainSplitContainer)).BeginInit();
            this.StaffPortalMainSplitContainer.Panel1.SuspendLayout();
            this.StaffPortalMainSplitContainer.Panel2.SuspendLayout();
            this.StaffPortalMainSplitContainer.SuspendLayout();
            this.StaffPortalGridLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffLawyerTaskView)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffPortalButtonLayoutPanel
            // 
            this.StaffPortalButtonLayoutPanel.ColumnCount = 3;
            this.StaffPortalButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 547F));
            this.StaffPortalButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.68853F));
            this.StaffPortalButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.31147F));
            this.StaffPortalButtonLayoutPanel.Controls.Add(this.StaffPortalAddTaskButton, 1, 0);
            this.StaffPortalButtonLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffPortalButtonLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.StaffPortalButtonLayoutPanel.Name = "StaffPortalButtonLayoutPanel";
            this.StaffPortalButtonLayoutPanel.RowCount = 1;
            this.StaffPortalButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StaffPortalButtonLayoutPanel.Size = new System.Drawing.Size(859, 53);
            this.StaffPortalButtonLayoutPanel.TabIndex = 156;
            // 
            // StaffPortalAddTaskButton
            // 
            this.StaffPortalAddTaskButton.BackColor = System.Drawing.Color.Maroon;
            this.StaffPortalButtonLayoutPanel.SetColumnSpan(this.StaffPortalAddTaskButton, 2);
            this.StaffPortalAddTaskButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffPortalAddTaskButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffPortalAddTaskButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffPortalAddTaskButton.ForeColor = System.Drawing.Color.White;
            this.StaffPortalAddTaskButton.Location = new System.Drawing.Point(551, 5);
            this.StaffPortalAddTaskButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StaffPortalAddTaskButton.Name = "StaffPortalAddTaskButton";
            this.StaffPortalAddTaskButton.Size = new System.Drawing.Size(304, 43);
            this.StaffPortalAddTaskButton.TabIndex = 155;
            this.StaffPortalAddTaskButton.Text = "Add Task";
            this.StaffPortalAddTaskButton.UseVisualStyleBackColor = false;
            this.StaffPortalAddTaskButton.Click += new System.EventHandler(this.StaffPortalAddTaskButton_Click);
            // 
            // StaffPortalMainSplitContainer
            // 
            this.StaffPortalMainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffPortalMainSplitContainer.IsSplitterFixed = true;
            this.StaffPortalMainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.StaffPortalMainSplitContainer.Name = "StaffPortalMainSplitContainer";
            this.StaffPortalMainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // StaffPortalMainSplitContainer.Panel1
            // 
            this.StaffPortalMainSplitContainer.Panel1.Controls.Add(this.StaffPortalGridLayoutPanel);
            // 
            // StaffPortalMainSplitContainer.Panel2
            // 
            this.StaffPortalMainSplitContainer.Panel2.Controls.Add(this.StaffPortalButtonLayoutPanel);
            this.StaffPortalMainSplitContainer.Size = new System.Drawing.Size(859, 504);
            this.StaffPortalMainSplitContainer.SplitterDistance = 447;
            this.StaffPortalMainSplitContainer.TabIndex = 159;
            // 
            // StaffPortalGridLayoutPanel
            // 
            this.StaffPortalGridLayoutPanel.ColumnCount = 2;
            this.StaffPortalGridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.049F));
            this.StaffPortalGridLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.951F));
            this.StaffPortalGridLayoutPanel.Controls.Add(this.StaffPortalTaskStateComboBox, 0, 0);
            this.StaffPortalGridLayoutPanel.Controls.Add(this.StaffPortalSearchTextBox, 1, 0);
            this.StaffPortalGridLayoutPanel.Controls.Add(this.StaffLawyerTaskView, 0, 1);
            this.StaffPortalGridLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffPortalGridLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.StaffPortalGridLayoutPanel.Name = "StaffPortalGridLayoutPanel";
            this.StaffPortalGridLayoutPanel.RowCount = 2;
            this.StaffPortalGridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.488987F));
            this.StaffPortalGridLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.51102F));
            this.StaffPortalGridLayoutPanel.Size = new System.Drawing.Size(859, 447);
            this.StaffPortalGridLayoutPanel.TabIndex = 159;
            // 
            // StaffPortalTaskStateComboBox
            // 
            this.StaffPortalTaskStateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StaffPortalTaskStateComboBox.FormattingEnabled = true;
            this.StaffPortalTaskStateComboBox.ItemHeight = 13;
            this.StaffPortalTaskStateComboBox.Location = new System.Drawing.Point(4, 12);
            this.StaffPortalTaskStateComboBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StaffPortalTaskStateComboBox.Name = "StaffPortalTaskStateComboBox";
            this.StaffPortalTaskStateComboBox.Size = new System.Drawing.Size(189, 21);
            this.StaffPortalTaskStateComboBox.TabIndex = 156;
            this.StaffPortalTaskStateComboBox.SelectedIndexChanged += new System.EventHandler(this.StaffPortalFileStatusComboBox_SelectedIndexChanged);
            // 
            // StaffPortalSearchTextBox
            // 
            this.StaffPortalSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StaffPortalSearchTextBox.Location = new System.Drawing.Point(201, 8);
            this.StaffPortalSearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StaffPortalSearchTextBox.Name = "StaffPortalSearchTextBox";
            this.StaffPortalSearchTextBox.Size = new System.Drawing.Size(654, 20);
            this.StaffPortalSearchTextBox.TabIndex = 157;
            this.StaffPortalSearchTextBox.TextChanged += new System.EventHandler(this.StaffPortalSearchTextBox_TextChanged);
            // 
            // StaffLawyerTaskView
            // 
            this.StaffLawyerTaskView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffPortalGridLayoutPanel.SetColumnSpan(this.StaffLawyerTaskView, 2);
            this.StaffLawyerTaskView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffLawyerTaskView.Location = new System.Drawing.Point(4, 38);
            this.StaffLawyerTaskView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StaffLawyerTaskView.Name = "StaffLawyerTaskView";
            this.StaffLawyerTaskView.Size = new System.Drawing.Size(851, 404);
            this.StaffLawyerTaskView.TabIndex = 148;
            // 
            // StaffViewControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StaffPortalMainSplitContainer);
            this.Name = "StaffViewControls";
            this.Size = new System.Drawing.Size(859, 504);
            this.StaffPortalButtonLayoutPanel.ResumeLayout(false);
            this.StaffPortalMainSplitContainer.Panel1.ResumeLayout(false);
            this.StaffPortalMainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaffPortalMainSplitContainer)).EndInit();
            this.StaffPortalMainSplitContainer.ResumeLayout(false);
            this.StaffPortalGridLayoutPanel.ResumeLayout(false);
            this.StaffPortalGridLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffLawyerTaskView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel StaffPortalButtonLayoutPanel;
        internal System.Windows.Forms.Button StaffPortalAddTaskButton;
        private System.Windows.Forms.SplitContainer StaffPortalMainSplitContainer;
        private System.Windows.Forms.TableLayoutPanel StaffPortalGridLayoutPanel;
        private System.Windows.Forms.ComboBox StaffPortalTaskStateComboBox;
        private System.Windows.Forms.TextBox StaffPortalSearchTextBox;
        private System.Windows.Forms.DataGridView StaffLawyerTaskView;
    }
}
