namespace RRFFilesManager.IntakeForm
{
    partial class IntakeForm
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
            this.Content = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.Actions = new System.Windows.Forms.Panel();
            this.NextButton = new System.Windows.Forms.Button();
            this.Container = new System.Windows.Forms.Panel();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Actions.SuspendLayout();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1350, 610);
            this.Content.TabIndex = 143;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.BackColor = System.Drawing.Color.Maroon;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(31, 11);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(111, 35);
            this.BackButton.TabIndex = 140;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Actions
            // 
            this.Actions.Controls.Add(this.NextButton);
            this.Actions.Controls.Add(this.BackButton);
            this.Actions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Actions.Location = new System.Drawing.Point(0, 613);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(1350, 64);
            this.Actions.TabIndex = 142;
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.BackColor = System.Drawing.Color.Maroon;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(1209, 11);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(111, 35);
            this.NextButton.TabIndex = 141;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.White;
            this.Container.Controls.Add(this.Actions);
            this.Container.Controls.Add(this.Content);
            this.Container.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Container.Location = new System.Drawing.Point(0, 51);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1350, 677);
            this.Container.TabIndex = 148;
            // 
            // Button5
            // 
            this.Button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button5.BackColor = System.Drawing.Color.Maroon;
            this.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.White;
            this.Button5.Location = new System.Drawing.Point(696, 11);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(211, 35);
            this.Button5.TabIndex = 147;
            this.Button5.Text = "Conflict Checks";
            this.Button5.UseVisualStyleBackColor = false;
            // 
            // Button4
            // 
            this.Button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button4.BackColor = System.Drawing.Color.Maroon;
            this.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.Location = new System.Drawing.Point(942, 11);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(111, 35);
            this.Button4.TabIndex = 146;
            this.Button4.Text = "Home";
            this.Button4.UseVisualStyleBackColor = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox1.Image = global::RRFFilesManager.Properties.Resources.RRFLogo;
            this.PictureBox1.Location = new System.Drawing.Point(1096, 2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(224, 68);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 145;
            this.PictureBox1.TabStop = false;
            // 
            // IntakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.PictureBox1);
            this.Name = "IntakeForm";
            this.Text = "Intake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Intake_FormClosing);
            this.Load += new System.EventHandler(this.Intake_Load);
            this.Actions.ResumeLayout(false);
            this.Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Content;
        internal System.Windows.Forms.Button BackButton;
        internal System.Windows.Forms.Panel Actions;
        internal System.Windows.Forms.Button NextButton;
        internal new System.Windows.Forms.Panel Container;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
    }
}