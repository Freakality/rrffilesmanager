
namespace RRFFilesManager.Controls.ArchiveControls
{
    partial class PreviewArchiveUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewArchiveUserControl));
            this.PreviewPanel = new System.Windows.Forms.Panel();
            this.previewHandlerHost1 = new RRFFilesManager.PreviewHandlerHost();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.axAcroPDF = new AxAcroPDFLib.AxAcroPDF();
            this.PreviewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // PreviewPanel
            // 
            this.PreviewPanel.Controls.Add(this.previewHandlerHost1);
            this.PreviewPanel.Controls.Add(this.richTextBox);
            this.PreviewPanel.Controls.Add(this.pictureBox);
            this.PreviewPanel.Controls.Add(this.axAcroPDF);
            this.PreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PreviewPanel.Location = new System.Drawing.Point(0, 0);
            this.PreviewPanel.Name = "PreviewPanel";
            this.PreviewPanel.Size = new System.Drawing.Size(465, 665);
            this.PreviewPanel.TabIndex = 2;
            // 
            // previewHandlerHost1
            // 
            this.previewHandlerHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewHandlerHost1.Location = new System.Drawing.Point(0, 0);
            this.previewHandlerHost1.Name = "previewHandlerHost1";
            this.previewHandlerHost1.Size = new System.Drawing.Size(465, 665);
            this.previewHandlerHost1.TabIndex = 4;
            this.previewHandlerHost1.Text = "previewHandlerHost2";
            this.previewHandlerHost1.Click += new System.EventHandler(this.previewHandlerHost1_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.White;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.Size = new System.Drawing.Size(465, 665);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            this.richTextBox.Visible = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(465, 665);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // axAcroPDF
            // 
            this.axAcroPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF.Enabled = true;
            this.axAcroPDF.Location = new System.Drawing.Point(0, 0);
            this.axAcroPDF.Name = "axAcroPDF";
            this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
            this.axAcroPDF.Size = new System.Drawing.Size(465, 665);
            this.axAcroPDF.TabIndex = 0;
            this.axAcroPDF.Visible = false;
            // 
            // PreviewArchiveUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PreviewPanel);
            this.Name = "PreviewArchiveUserControl";
            this.Size = new System.Drawing.Size(465, 665);
            this.PreviewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PreviewPanel;
        private PreviewHandlerHost previewHandlerHost1;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF;
    }
}
