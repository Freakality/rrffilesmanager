
namespace RRFFilesManager.Controls.FileControls
{
    partial class ABBinderControl
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.DocumentTypesBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExportPDFButton = new System.Windows.Forms.Button();
            this.ExportWordButton = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.SearchBox, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.DocumentTypesBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1396, 44);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // SearchBox
            // 
            this.SearchBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchBox.Location = new System.Drawing.Point(1057, 10);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(10);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(329, 20);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // DocumentTypesBox
            // 
            this.DocumentTypesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentTypesBox.FormattingEnabled = true;
            this.DocumentTypesBox.Location = new System.Drawing.Point(10, 10);
            this.DocumentTypesBox.Margin = new System.Windows.Forms.Padding(10);
            this.DocumentTypesBox.Name = "DocumentTypesBox";
            this.DocumentTypesBox.Size = new System.Drawing.Size(329, 21);
            this.DocumentTypesBox.TabIndex = 1;
            this.DocumentTypesBox.SelectedIndexChanged += new System.EventHandler(this.DocumentTypesBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1402, 462);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExportPDFButton);
            this.panel1.Controls.Add(this.ExportWordButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1396, 44);
            this.panel1.TabIndex = 3;
            // 
            // ExportPDFButton
            // 
            this.ExportPDFButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ExportPDFButton.BackColor = System.Drawing.Color.Firebrick;
            this.ExportPDFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportPDFButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ExportPDFButton.ForeColor = System.Drawing.Color.White;
            this.ExportPDFButton.Location = new System.Drawing.Point(1247, 4);
            this.ExportPDFButton.Name = "ExportPDFButton";
            this.ExportPDFButton.Size = new System.Drawing.Size(146, 36);
            this.ExportPDFButton.TabIndex = 165;
            this.ExportPDFButton.Text = "Export PDF";
            this.ExportPDFButton.UseVisualStyleBackColor = false;
            this.ExportPDFButton.Click += new System.EventHandler(this.ExportPDFButton_Click);
            // 
            // ExportWordButton
            // 
            this.ExportWordButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ExportWordButton.BackColor = System.Drawing.Color.Navy;
            this.ExportWordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportWordButton.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.ExportWordButton.ForeColor = System.Drawing.Color.White;
            this.ExportWordButton.Location = new System.Drawing.Point(1095, 4);
            this.ExportWordButton.Name = "ExportWordButton";
            this.ExportWordButton.Size = new System.Drawing.Size(146, 36);
            this.ExportWordButton.TabIndex = 166;
            this.ExportWordButton.Text = "Export Word";
            this.ExportWordButton.UseVisualStyleBackColor = false;
            this.ExportWordButton.Click += new System.EventHandler(this.ExportWordButton_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(3, 53);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.ReadOnly = true;
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.Size = new System.Drawing.Size(1396, 356);
            this.DataGridView.TabIndex = 2;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // ABBinderControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ABBinderControl";
            this.Size = new System.Drawing.Size(1402, 462);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.ComboBox DocumentTypesBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button ExportPDFButton;
        internal System.Windows.Forms.Button ExportWordButton;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
