
namespace RRFFilesManager.Controls.FileControls.UserControls
{
    partial class SemiAnnualFileReviewControl
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
            this.TabControlFR = new System.Windows.Forms.TabControl();
            this.ReviewDoneSaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TabControlFR
            // 
            this.TabControlFR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlFR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlFR.Location = new System.Drawing.Point(18, 13);
            this.TabControlFR.Name = "TabControlFR";
            this.TabControlFR.SelectedIndex = 0;
            this.TabControlFR.Size = new System.Drawing.Size(1202, 289);
            this.TabControlFR.TabIndex = 0;
            // 
            // ReviewDoneSaveButton
            // 
            this.ReviewDoneSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReviewDoneSaveButton.BackColor = System.Drawing.Color.Maroon;
            this.ReviewDoneSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviewDoneSaveButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewDoneSaveButton.ForeColor = System.Drawing.Color.White;
            this.ReviewDoneSaveButton.Location = new System.Drawing.Point(961, 320);
            this.ReviewDoneSaveButton.Name = "ReviewDoneSaveButton";
            this.ReviewDoneSaveButton.Size = new System.Drawing.Size(259, 32);
            this.ReviewDoneSaveButton.TabIndex = 149;
            this.ReviewDoneSaveButton.Text = "Done";
            this.ReviewDoneSaveButton.UseVisualStyleBackColor = false;
            this.ReviewDoneSaveButton.Click += new System.EventHandler(this.ReviewDoneSaveButton_Click);
            // 
            // SemiAnnualFileReviewControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.ReviewDoneSaveButton);
            this.Controls.Add(this.TabControlFR);
            this.Name = "SemiAnnualFileReviewControl";
            this.Size = new System.Drawing.Size(1242, 368);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.TabControl TabControlFR;
        internal System.Windows.Forms.Button ReviewDoneSaveButton;
    }
}
