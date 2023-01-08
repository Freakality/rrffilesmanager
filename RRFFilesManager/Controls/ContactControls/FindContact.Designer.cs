namespace RRFFilesManager.ContactForm
{
    partial class FindContact
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
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ContactsGridView = new System.Windows.Forms.DataGridView();
            this.SearchBox.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.TableLayoutPanel);
            this.SearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(0, 0);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(800, 62);
            this.SearchBox.TabIndex = 2;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search";
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableLayoutPanel.Controls.Add(this.SearchTextBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.CreateButton, 1, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLayoutPanel.Location = new System.Drawing.Point(3, 22);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(794, 34);
            this.TableLayoutPanel.TabIndex = 2;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTextBox.Location = new System.Drawing.Point(3, 3);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(688, 26);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.SystemColors.Control;
            this.CreateButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateButton.ForeColor = System.Drawing.Color.Black;
            this.CreateButton.Location = new System.Drawing.Point(697, 3);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(94, 28);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Visible = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ContactsGridView
            // 
            this.ContactsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ContactsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactsGridView.Location = new System.Drawing.Point(0, 62);
            this.ContactsGridView.Name = "ContactsGridView";
            this.ContactsGridView.Size = new System.Drawing.Size(800, 388);
            this.ContactsGridView.TabIndex = 3;
            this.ContactsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContactsGridView_CellClick);
            // 
            // FindContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContactsGridView);
            this.Controls.Add(this.SearchBox);
            this.Name = "FindContact";
            this.Text = "FindContact";
            this.SearchBox.ResumeLayout(false);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.DataGridView ContactsGridView;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button CreateButton;
    }
}