
namespace RRFFilesManager.Controls.CompanyControls
{
    partial class FindCompany
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
            this.CreateCompanyButton = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.SearchBox.SuspendLayout();
            this.TableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Controls.Add(this.TableLayoutPanel);
            this.SearchBox.Location = new System.Drawing.Point(0, 0);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(797, 45);
            this.SearchBox.TabIndex = 4;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search";
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TableLayoutPanel.Controls.Add(this.SearchTextBox, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.CreateCompanyButton, 1, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(791, 26);
            this.TableLayoutPanel.TabIndex = 1;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTextBox.Location = new System.Drawing.Point(3, 3);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(685, 20);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // CreateCompanyButton
            // 
            this.CreateCompanyButton.BackColor = System.Drawing.SystemColors.Control;
            this.CreateCompanyButton.ForeColor = System.Drawing.Color.Black;
            this.CreateCompanyButton.Location = new System.Drawing.Point(694, 3);
            this.CreateCompanyButton.Name = "CreateCompanyButton";
            this.CreateCompanyButton.Size = new System.Drawing.Size(94, 20);
            this.CreateCompanyButton.TabIndex = 1;
            this.CreateCompanyButton.Text = "Create or Edit";
            this.CreateCompanyButton.UseVisualStyleBackColor = false;
            this.CreateCompanyButton.Visible = false;
            this.CreateCompanyButton.Click += new System.EventHandler(this.CreateCompanyButton_Click);
            // 
            // GridView
            // 
            this.GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(0, 45);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(800, 406);
            this.GridView.TabIndex = 5;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            this.GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellContentClick);
            // 
            // FindCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.GridView);
            this.Name = "FindCompany";
            this.Text = "FindCompany";
            this.SearchBox.ResumeLayout(false);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button CreateCompanyButton;
    }
}