
namespace RRFFilesManager.Controls.StaffControls
{
    partial class StaffPortal
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeButton = new System.Windows.Forms.Button();
            this.StaffPortalMainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::RRFFilesManager.Properties.Resources.RRFLogo;
            this.PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(224, 68);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 143;
            this.PictureBox1.TabStop = false;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.Maroon;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(1009, 42);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(152, 37);
            this.HomeButton.TabIndex = 153;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // StaffPortalMainPanel
            // 
            this.StaffPortalMainPanel.Location = new System.Drawing.Point(12, 95);
            this.StaffPortalMainPanel.Name = "StaffPortalMainPanel";
            this.StaffPortalMainPanel.Size = new System.Drawing.Size(1149, 490);
            this.StaffPortalMainPanel.TabIndex = 154;
            // 
            // StaffPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 597);
            this.Controls.Add(this.StaffPortalMainPanel);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.PictureBox1);
            this.Name = "StaffPortal";
            this.Text = "Staff Portal";
            this.Load += new System.EventHandler(this.StaffPortal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button HomeButton;
        internal System.Windows.Forms.Panel StaffPortalMainPanel;
    }
}