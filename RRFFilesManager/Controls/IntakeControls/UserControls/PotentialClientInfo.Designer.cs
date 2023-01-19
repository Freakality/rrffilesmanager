namespace RRFFilesManager.IntakeForm
{
    partial class PotentialClientInfo
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
            this.Label41 = new System.Windows.Forms.Label();
            this.FindClientButton = new System.Windows.Forms.Button();
            this.Content = new System.Windows.Forms.Panel();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label41.Location = new System.Drawing.Point(45, 0);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(216, 26);
            this.Label41.TabIndex = 2;
            this.Label41.Text = "Potential Client Info";
            // 
            // FindClientButton
            // 
            this.FindClientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FindClientButton.BackColor = System.Drawing.Color.Maroon;
            this.FindClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindClientButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindClientButton.ForeColor = System.Drawing.Color.White;
            this.FindClientButton.Location = new System.Drawing.Point(1104, 3);
            this.FindClientButton.Name = "FindClientButton";
            this.FindClientButton.Size = new System.Drawing.Size(97, 36);
            this.FindClientButton.TabIndex = 3;
            this.FindClientButton.Text = "Find Client";
            this.FindClientButton.UseVisualStyleBackColor = false;
            this.FindClientButton.Click += new System.EventHandler(this.FindClientButton_Click);
            // 
            // Content
            // 
            this.Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Content.BackColor = System.Drawing.Color.White;
            this.Content.Controls.Add(this.FindClientButton);
            this.Content.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Content.Location = new System.Drawing.Point(50, 28);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1250, 554);
            this.Content.TabIndex = 144;
            this.Content.Paint += new System.Windows.Forms.PaintEventHandler(this.Content_Paint);
            // 
            // PotentialClientInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Label41);
            this.Name = "PotentialClientInfo";
            this.Size = new System.Drawing.Size(1350, 610);
            this.Content.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label41;
        private System.Windows.Forms.Button FindClientButton;
        internal System.Windows.Forms.Panel Content;
    }
}
