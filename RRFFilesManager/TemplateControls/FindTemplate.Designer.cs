namespace RRFFilesManager.TemplateControls
{
    partial class FindTemplate
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
            System.Windows.Forms.Label DateOFCallLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MatterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryCombobox = new System.Windows.Forms.ComboBox();
            this.TypeOfTemplateComboBox = new System.Windows.Forms.ComboBox();
            DateOFCallLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Controls.Add(this.tableLayoutPanel1);
            this.SearchBox.Controls.Add(this.SearchTextBox);
            this.SearchBox.Location = new System.Drawing.Point(0, 0);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(797, 99);
            this.SearchBox.TabIndex = 4;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search";
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(9, 19);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(779, 20);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // GridView
            // 
            this.GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(0, 105);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(800, 346);
            this.GridView.TabIndex = 5;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            this.GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(DateOFCallLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MatterTypeComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CategoryCombobox, 3, 0);
            this.tableLayoutPanel1.Controls.Add(label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TypeOfTemplateComboBox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(779, 54);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // DateOFCallLabel
            // 
            DateOFCallLabel.AutoSize = true;
            DateOFCallLabel.Location = new System.Drawing.Point(3, 0);
            DateOFCallLabel.Name = "DateOFCallLabel";
            DateOFCallLabel.Size = new System.Drawing.Size(64, 13);
            DateOFCallLabel.TabIndex = 142;
            DateOFCallLabel.Text = "MatterType:";
            // 
            // MatterTypeComboBox
            // 
            this.MatterTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MatterTypeComboBox.BackColor = System.Drawing.Color.White;
            this.MatterTypeComboBox.DisplayMember = "MatterType";
            this.MatterTypeComboBox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatterTypeComboBox.FormattingEnabled = true;
            this.MatterTypeComboBox.Location = new System.Drawing.Point(80, 3);
            this.MatterTypeComboBox.Name = "MatterTypeComboBox";
            this.MatterTypeComboBox.Size = new System.Drawing.Size(305, 25);
            this.MatterTypeComboBox.TabIndex = 143;
            this.MatterTypeComboBox.ValueMember = "MatterType";
            this.MatterTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.MatterTypeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(391, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 13);
            label1.TabIndex = 144;
            label1.Text = "Category:";
            // 
            // CategoryCombobox
            // 
            this.CategoryCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryCombobox.BackColor = System.Drawing.Color.White;
            this.CategoryCombobox.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCombobox.FormattingEnabled = true;
            this.CategoryCombobox.Location = new System.Drawing.Point(468, 3);
            this.CategoryCombobox.Name = "CategoryCombobox";
            this.CategoryCombobox.Size = new System.Drawing.Size(308, 25);
            this.CategoryCombobox.TabIndex = 145;
            this.CategoryCombobox.SelectedIndexChanged += new System.EventHandler(this.CategoryCombobox_SelectedIndexChanged);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 26);
            label2.TabIndex = 160;
            label2.Text = "Type of Template:";
            // 
            // TypeOfTemplateComboBox
            // 
            this.TypeOfTemplateComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeOfTemplateComboBox.FormattingEnabled = true;
            this.TypeOfTemplateComboBox.Location = new System.Drawing.Point(80, 30);
            this.TypeOfTemplateComboBox.Name = "TypeOfTemplateComboBox";
            this.TypeOfTemplateComboBox.Size = new System.Drawing.Size(305, 21);
            this.TypeOfTemplateComboBox.TabIndex = 161;
            this.TypeOfTemplateComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeOfTemplateComboBox_SelectedIndexChanged);
            // 
            // FindTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.GridView);
            this.Name = "FindTemplate";
            this.Text = "FindTemplate";
            this.Load += new System.EventHandler(this.FindTemplate_Load);
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.ComboBox MatterTypeComboBox;
        internal System.Windows.Forms.ComboBox CategoryCombobox;
        internal System.Windows.Forms.ComboBox TypeOfTemplateComboBox;
    }
}