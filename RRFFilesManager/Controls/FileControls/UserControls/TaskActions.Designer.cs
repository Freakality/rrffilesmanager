namespace RRFFilesManager.Controls.FileControls.UserControls
{
    partial class TaskActions
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Ctms_TaskActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workedDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyRRFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Ctms_TaskActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ctms_TaskActions
            // 
            this.Ctms_TaskActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startTaskToolStripMenuItem,
            this.workedDayToolStripMenuItem,
            this.notifyRRFToolStripMenuItem,
            this.completeTaskToolStripMenuItem,
            this.editNotesToolStripMenuItem});
            this.Ctms_TaskActions.Name = "Ctms_TaskActions";
            this.Ctms_TaskActions.Size = new System.Drawing.Size(181, 136);
            this.Ctms_TaskActions.Closed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.Ctms_TaskActions_Closed);
            this.Ctms_TaskActions.Opening += new System.ComponentModel.CancelEventHandler(this.Ctms_TaskActions_Opening);
            // 
            // startTaskToolStripMenuItem
            // 
            this.startTaskToolStripMenuItem.Name = "startTaskToolStripMenuItem";
            this.startTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startTaskToolStripMenuItem.Text = "Start Task";
            this.startTaskToolStripMenuItem.Click += new System.EventHandler(this.startTaskToolStripMenuItem_Click);
            // 
            // workedDayToolStripMenuItem
            // 
            this.workedDayToolStripMenuItem.Name = "workedDayToolStripMenuItem";
            this.workedDayToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.workedDayToolStripMenuItem.Text = "Worked Day";
            this.workedDayToolStripMenuItem.Click += new System.EventHandler(this.workedDayToolStripMenuItem_Click);
            // 
            // notifyRRFToolStripMenuItem
            // 
            this.notifyRRFToolStripMenuItem.Name = "notifyRRFToolStripMenuItem";
            this.notifyRRFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.notifyRRFToolStripMenuItem.Text = "Notify RRF";
            this.notifyRRFToolStripMenuItem.Click += new System.EventHandler(this.notifyRRFToolStripMenuItem_Click);
            // 
            // completeTaskToolStripMenuItem
            // 
            this.completeTaskToolStripMenuItem.Name = "completeTaskToolStripMenuItem";
            this.completeTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.completeTaskToolStripMenuItem.Text = "Complete Task";
            this.completeTaskToolStripMenuItem.Click += new System.EventHandler(this.completeTaskToolStripMenuItem_Click);
            // 
            // editNotesToolStripMenuItem
            // 
            this.editNotesToolStripMenuItem.Name = "editNotesToolStripMenuItem";
            this.editNotesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editNotesToolStripMenuItem.Text = "Edit Notes";
            this.editNotesToolStripMenuItem.Click += new System.EventHandler(this.editNotesToolStripMenuItem_Click);
            // 
            // TaskActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TaskActions";
            this.Size = new System.Drawing.Size(217, 50);
            this.Ctms_TaskActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem startTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workedDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeTaskToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip Ctms_TaskActions;
        private System.Windows.Forms.ToolStripMenuItem notifyRRFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNotesToolStripMenuItem;
    }
}
