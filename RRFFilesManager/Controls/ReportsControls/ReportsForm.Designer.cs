
namespace RRFFilesManager.Controls.ReportsControls
{
    partial class ReportsForm
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
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Mid = new System.Windows.Forms.Panel();
            this.Panel_InnerTop = new System.Windows.Forms.Panel();
            this.Panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel_Mid.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Top
            // 
            this.Panel_Top.BackColor = System.Drawing.Color.White;
            this.Panel_Top.Controls.Add(this.HomeButton);
            this.Panel_Top.Controls.Add(this.PictureBox1);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(945, 74);
            this.Panel_Top.TabIndex = 0;
            // 
            // HomeButton
            // 
            this.HomeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeButton.BackColor = System.Drawing.Color.Maroon;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Location = new System.Drawing.Point(813, 23);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(111, 35);
            this.HomeButton.TabIndex = 148;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureBox1.Image = global::RRFFilesManager.Properties.Resources.RRFLogo;
            this.PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(224, 74);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 147;
            this.PictureBox1.TabStop = false;
            // 
            // Panel_Mid
            // 
            this.Panel_Mid.Controls.Add(this.Panel_InnerTop);
            this.Panel_Mid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Mid.Location = new System.Drawing.Point(0, 74);
            this.Panel_Mid.Name = "Panel_Mid";
            this.Panel_Mid.Size = new System.Drawing.Size(945, 376);
            this.Panel_Mid.TabIndex = 1;
            // 
            // Panel_InnerTop
            // 
            this.Panel_InnerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_InnerTop.Location = new System.Drawing.Point(0, 0);
            this.Panel_InnerTop.Name = "Panel_InnerTop";
            this.Panel_InnerTop.Size = new System.Drawing.Size(945, 67);
            this.Panel_InnerTop.TabIndex = 0;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.Panel_Mid);
            this.Controls.Add(this.Panel_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.Panel_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel_Mid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.Panel Panel_Mid;
        internal System.Windows.Forms.Button HomeButton;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Panel Panel_InnerTop;
    }
}