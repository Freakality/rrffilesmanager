
namespace RRFFilesManager.Controls.MasterTaskControls
{
    partial class DependencySelect
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
            this.DependencyCheckList = new System.Windows.Forms.CheckedListBox();
            this.OKDependenciesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DependencyCheckList
            // 
            this.DependencyCheckList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DependencyCheckList.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.DependencyCheckList.FormattingEnabled = true;
            this.DependencyCheckList.Location = new System.Drawing.Point(12, 29);
            this.DependencyCheckList.Name = "DependencyCheckList";
            this.DependencyCheckList.Size = new System.Drawing.Size(290, 466);
            this.DependencyCheckList.TabIndex = 0;
            // 
            // OKDependenciesButton
            // 
            this.OKDependenciesButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.OKDependenciesButton.BackColor = System.Drawing.Color.Maroon;
            this.OKDependenciesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKDependenciesButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKDependenciesButton.ForeColor = System.Drawing.Color.White;
            this.OKDependenciesButton.Location = new System.Drawing.Point(78, 505);
            this.OKDependenciesButton.Name = "OKDependenciesButton";
            this.OKDependenciesButton.Size = new System.Drawing.Size(152, 37);
            this.OKDependenciesButton.TabIndex = 151;
            this.OKDependenciesButton.Text = "OK";
            this.OKDependenciesButton.UseVisualStyleBackColor = false;
            this.OKDependenciesButton.Click += new System.EventHandler(this.OKDependenciesButton_Click);
            // 
            // DependencySelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 554);
            this.Controls.Add(this.OKDependenciesButton);
            this.Controls.Add(this.DependencyCheckList);
            this.Name = "DependencySelect";
            this.Text = "DependencySelect";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DependencySelect_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox DependencyCheckList;
        internal System.Windows.Forms.Button OKDependenciesButton;
    }
}