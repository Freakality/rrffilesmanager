
namespace RRFFilesManager.Controls.IntakeControls
{
    partial class ImportQuestionnaireFields
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
            this.fieldsDataGridView = new System.Windows.Forms.DataGridView();
            this.ImportButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UnselectAllButton = new System.Windows.Forms.Button();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OtherNotesRTB = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.fieldsDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fieldsDataGridView
            // 
            this.fieldsDataGridView.AllowUserToAddRows = false;
            this.fieldsDataGridView.AllowUserToDeleteRows = false;
            this.fieldsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fieldsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fieldsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.fieldsDataGridView.Name = "fieldsDataGridView";
            this.fieldsDataGridView.Size = new System.Drawing.Size(985, 304);
            this.fieldsDataGridView.TabIndex = 1;
            this.fieldsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fieldsDataGridView_CellContentClick);
            // 
            // ImportButton
            // 
            this.ImportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImportButton.BackColor = System.Drawing.Color.Maroon;
            this.ImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.ForeColor = System.Drawing.Color.White;
            this.ImportButton.Location = new System.Drawing.Point(869, 531);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(125, 36);
            this.ImportButton.TabIndex = 145;
            this.ImportButton.Text = "Import";
            this.ImportButton.UseVisualStyleBackColor = false;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ImportButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 570);
            this.tableLayoutPanel1.TabIndex = 146;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UnselectAllButton);
            this.panel1.Controls.Add(this.SelectAllButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 44);
            this.panel1.TabIndex = 146;
            // 
            // UnselectAllButton
            // 
            this.UnselectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UnselectAllButton.BackColor = System.Drawing.Color.Maroon;
            this.UnselectAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnselectAllButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnselectAllButton.ForeColor = System.Drawing.Color.White;
            this.UnselectAllButton.Location = new System.Drawing.Point(732, 3);
            this.UnselectAllButton.Name = "UnselectAllButton";
            this.UnselectAllButton.Size = new System.Drawing.Size(125, 36);
            this.UnselectAllButton.TabIndex = 147;
            this.UnselectAllButton.Text = "Unselect All";
            this.UnselectAllButton.UseVisualStyleBackColor = false;
            this.UnselectAllButton.Click += new System.EventHandler(this.UnselectAllButton_Click);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectAllButton.BackColor = System.Drawing.Color.Maroon;
            this.SelectAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAllButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectAllButton.ForeColor = System.Drawing.Color.White;
            this.SelectAllButton.Location = new System.Drawing.Point(863, 3);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(125, 36);
            this.SelectAllButton.TabIndex = 146;
            this.SelectAllButton.Text = "Select All";
            this.SelectAllButton.UseVisualStyleBackColor = false;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 382);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 135);
            this.panel2.TabIndex = 147;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OtherNotesRTB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(991, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other Notes";
            // 
            // OtherNotesRTB
            // 
            this.OtherNotesRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OtherNotesRTB.Location = new System.Drawing.Point(3, 16);
            this.OtherNotesRTB.Name = "OtherNotesRTB";
            this.OtherNotesRTB.Size = new System.Drawing.Size(985, 116);
            this.OtherNotesRTB.TabIndex = 0;
            this.OtherNotesRTB.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fieldsDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(991, 323);
            this.groupBox2.TabIndex = 148;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fields to import";
            // 
            // ImportQuestionnaireFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 570);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ImportQuestionnaireFields";
            this.Text = "ImportQuestionnaireFields";
            ((System.ComponentModel.ISupportInitialize)(this.fieldsDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fieldsDataGridView;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.Button UnselectAllButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox OtherNotesRTB;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}