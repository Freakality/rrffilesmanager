
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
            ((System.ComponentModel.ISupportInitialize)(this.fieldsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldsDataGridView
            // 
            this.fieldsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fieldsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.fieldsDataGridView.Name = "fieldsDataGridView";
            this.fieldsDataGridView.Size = new System.Drawing.Size(800, 450);
            this.fieldsDataGridView.TabIndex = 1;
            this.fieldsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fieldsDataGridView_CellContentClick);
            // 
            // ImportQuestionnaireFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fieldsDataGridView);
            this.Name = "ImportQuestionnaireFields";
            this.Text = "ImportQuestionnaireFields";
            ((System.ComponentModel.ISupportInitialize)(this.fieldsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fieldsDataGridView;
    }
}