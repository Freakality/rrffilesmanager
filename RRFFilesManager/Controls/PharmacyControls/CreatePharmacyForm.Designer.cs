
namespace RRFFilesManager.Controls.PharmacyControls
{
    partial class CreatePharmacyForm
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
            this.Address1TB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PhoneNumber1MTB = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PhoneNumber2MTB = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Address2TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CityTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProvinceCB = new RRFFilesManager.Controls.ProvinceControls.CustomControls.ProvinceComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PostalCodeTB = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Address1TB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.NameTB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumber1MTB, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumber2MTB, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Address2TB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CityTB, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ProvinceCB, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.PostalCodeTB, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(428, 265);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Address1TB
            // 
            this.Address1TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Address1TB.Location = new System.Drawing.Point(103, 36);
            this.Address1TB.Name = "Address1TB";
            this.Address1TB.Size = new System.Drawing.Size(322, 20);
            this.Address1TB.TabIndex = 5;
            // 
            // NameTB
            // 
            this.NameTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTB.Location = new System.Drawing.Point(103, 3);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(322, 20);
            this.NameTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "Phone Number 1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PhoneNumber1MTB
            // 
            this.PhoneNumber1MTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneNumber1MTB.Location = new System.Drawing.Point(103, 201);
            this.PhoneNumber1MTB.Mask = "(999) 000-0000";
            this.PhoneNumber1MTB.Name = "PhoneNumber1MTB";
            this.PhoneNumber1MTB.Size = new System.Drawing.Size(322, 20);
            this.PhoneNumber1MTB.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(3, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 34);
            this.label8.TabIndex = 31;
            this.label8.Text = "Phone Number 2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PhoneNumber2MTB
            // 
            this.PhoneNumber2MTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneNumber2MTB.Location = new System.Drawing.Point(103, 234);
            this.PhoneNumber2MTB.Mask = "(999) 000-0000";
            this.PhoneNumber2MTB.Name = "PhoneNumber2MTB";
            this.PhoneNumber2MTB.Size = new System.Drawing.Size(322, 20);
            this.PhoneNumber2MTB.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address 1";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 33);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Address2TB
            // 
            this.Address2TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Address2TB.Location = new System.Drawing.Point(103, 69);
            this.Address2TB.Name = "Address2TB";
            this.Address2TB.Size = new System.Drawing.Size(322, 20);
            this.Address2TB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "City";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CityTB
            // 
            this.CityTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CityTB.Location = new System.Drawing.Point(103, 102);
            this.CityTB.Name = "CityTB";
            this.CityTB.Size = new System.Drawing.Size(322, 20);
            this.CityTB.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Province";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProvinceCB
            // 
            this.ProvinceCB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProvinceCB.FormattingEnabled = true;
            this.ProvinceCB.Location = new System.Drawing.Point(103, 135);
            this.ProvinceCB.Name = "ProvinceCB";
            this.ProvinceCB.Size = new System.Drawing.Size(322, 21);
            this.ProvinceCB.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 33);
            this.label6.TabIndex = 14;
            this.label6.Text = "Postal Code";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PostalCodeTB
            // 
            this.PostalCodeTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostalCodeTB.Location = new System.Drawing.Point(103, 168);
            this.PostalCodeTB.Name = "PostalCodeTB";
            this.PostalCodeTB.Size = new System.Drawing.Size(322, 20);
            this.PostalCodeTB.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(434, 311);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Location = new System.Drawing.Point(20, 276);
            this.panel1.Margin = new System.Windows.Forms.Padding(20, 3, 20, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 30);
            this.panel1.TabIndex = 1;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Maroon;
            this.Cancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(0, 0);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(97, 30);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Maroon;
            this.Save.Dock = System.Windows.Forms.DockStyle.Right;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(297, 0);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 30);
            this.Save.TabIndex = 9;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CreatePharmacyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "CreatePharmacyForm";
            this.Text = "Create Pharmacy";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Address2TB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Address1TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CityTB;
        private System.Windows.Forms.TextBox PostalCodeTB;
        private System.Windows.Forms.Label label2;
        private ProvinceControls.CustomControls.ProvinceComboBox ProvinceCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.MaskedTextBox PhoneNumber2MTB;
        private System.Windows.Forms.Label label8;
        internal System.Windows.Forms.MaskedTextBox PhoneNumber1MTB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
    }
}