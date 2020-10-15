namespace RRFFilesManager
{
    partial class Submitting
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
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::RRFFilesManager.Properties.Resources.RRFLogoSmall;
            this.PictureBox1.Location = new System.Drawing.Point(35, 20);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(261, 258);
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(14, 291);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(304, 58);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Submitting...";
            // 
            // Submitting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 368);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Submitting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submitting";
            this.Load += new System.EventHandler(this.Submitting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label1;
    }
}