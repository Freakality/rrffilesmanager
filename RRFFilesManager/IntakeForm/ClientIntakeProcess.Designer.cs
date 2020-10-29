namespace RRFFilesManager.IntakeForm
{
    partial class ClientIntakeProcess
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
            System.Windows.Forms.Label DateApptScheduledLabel;
            System.Windows.Forms.Label TimeOfApptLabel;
            System.Windows.Forms.Label ApptTypeLabel;
            System.Windows.Forms.Label TimeFrameLabel;
            System.Windows.Forms.Label NeedOnlineQuesLabel;
            this.PreliminayPanel = new System.Windows.Forms.Panel();
            this.Submit = new System.Windows.Forms.Button();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TimeFrame = new System.Windows.Forms.ComboBox();
            this.ApptType = new System.Windows.Forms.ComboBox();
            this.TimeOfAppt = new System.Windows.Forms.DateTimePicker();
            this.NeedOnlineQues = new System.Windows.Forms.ComboBox();
            this.DateApptScheduled = new System.Windows.Forms.DateTimePicker();
            this.Label42 = new System.Windows.Forms.Label();
            DateApptScheduledLabel = new System.Windows.Forms.Label();
            TimeOfApptLabel = new System.Windows.Forms.Label();
            ApptTypeLabel = new System.Windows.Forms.Label();
            TimeFrameLabel = new System.Windows.Forms.Label();
            NeedOnlineQuesLabel = new System.Windows.Forms.Label();
            this.PreliminayPanel.SuspendLayout();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateApptScheduledLabel
            // 
            DateApptScheduledLabel.AutoSize = true;
            DateApptScheduledLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DateApptScheduledLabel.ForeColor = System.Drawing.Color.Black;
            DateApptScheduledLabel.Location = new System.Drawing.Point(3, 46);
            DateApptScheduledLabel.Name = "DateApptScheduledLabel";
            DateApptScheduledLabel.Size = new System.Drawing.Size(151, 17);
            DateApptScheduledLabel.TabIndex = 12;
            DateApptScheduledLabel.Text = "Date Appt Scheduled:";
            // 
            // TimeOfApptLabel
            // 
            TimeOfApptLabel.AutoSize = true;
            TimeOfApptLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TimeOfApptLabel.ForeColor = System.Drawing.Color.Black;
            TimeOfApptLabel.Location = new System.Drawing.Point(3, 92);
            TimeOfApptLabel.Name = "TimeOfApptLabel";
            TimeOfApptLabel.Size = new System.Drawing.Size(94, 17);
            TimeOfApptLabel.TabIndex = 16;
            TimeOfApptLabel.Text = "Time of Appt:";
            // 
            // ApptTypeLabel
            // 
            ApptTypeLabel.AutoSize = true;
            ApptTypeLabel.Location = new System.Drawing.Point(3, 138);
            ApptTypeLabel.Name = "ApptTypeLabel";
            ApptTypeLabel.Size = new System.Drawing.Size(76, 17);
            ApptTypeLabel.TabIndex = 20;
            ApptTypeLabel.Text = "Appt Type:";
            // 
            // TimeFrameLabel
            // 
            TimeFrameLabel.AutoSize = true;
            TimeFrameLabel.Location = new System.Drawing.Point(3, 184);
            TimeFrameLabel.Name = "TimeFrameLabel";
            TimeFrameLabel.Size = new System.Drawing.Size(85, 17);
            TimeFrameLabel.TabIndex = 2;
            TimeFrameLabel.Text = "Time Frame:";
            // 
            // NeedOnlineQuesLabel
            // 
            NeedOnlineQuesLabel.AutoSize = true;
            NeedOnlineQuesLabel.Location = new System.Drawing.Point(3, 0);
            NeedOnlineQuesLabel.Name = "NeedOnlineQuesLabel";
            NeedOnlineQuesLabel.Size = new System.Drawing.Size(236, 17);
            NeedOnlineQuesLabel.TabIndex = 6;
            NeedOnlineQuesLabel.Text = "Need Online Ques before booking?";
            // 
            // PreliminayPanel
            // 
            this.PreliminayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreliminayPanel.BackColor = System.Drawing.Color.White;
            this.PreliminayPanel.Controls.Add(this.Submit);
            this.PreliminayPanel.Controls.Add(this.TableLayoutPanel1);
            this.PreliminayPanel.Controls.Add(this.Label42);
            this.PreliminayPanel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreliminayPanel.Location = new System.Drawing.Point(28, 38);
            this.PreliminayPanel.Name = "PreliminayPanel";
            this.PreliminayPanel.Size = new System.Drawing.Size(1295, 535);
            this.PreliminayPanel.TabIndex = 145;
            // 
            // Submit
            // 
            this.Submit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Submit.BackColor = System.Drawing.Color.Maroon;
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(319, 328);
            this.Submit.Margin = new System.Windows.Forms.Padding(300, 30, 30, 3);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(658, 54);
            this.Submit.TabIndex = 157;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10952F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.23673F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.27801F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.37574F));
            this.TableLayoutPanel1.Controls.Add(this.TimeFrame, 1, 4);
            this.TableLayoutPanel1.Controls.Add(this.ApptType, 1, 3);
            this.TableLayoutPanel1.Controls.Add(this.TimeOfAppt, 1, 2);
            this.TableLayoutPanel1.Controls.Add(this.NeedOnlineQues, 1, 0);
            this.TableLayoutPanel1.Controls.Add(TimeFrameLabel, 0, 4);
            this.TableLayoutPanel1.Controls.Add(ApptTypeLabel, 0, 3);
            this.TableLayoutPanel1.Controls.Add(TimeOfApptLabel, 0, 2);
            this.TableLayoutPanel1.Controls.Add(DateApptScheduledLabel, 0, 1);
            this.TableLayoutPanel1.Controls.Add(NeedOnlineQuesLabel, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.DateApptScheduled, 1, 1);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(25, 83);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 5;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(1232, 233);
            this.TableLayoutPanel1.TabIndex = 25;
            // 
            // TimeFrame
            // 
            this.TimeFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeFrame.DisplayMember = "Option";
            this.TimeFrame.FormattingEnabled = true;
            this.TimeFrame.Items.AddRange(new object[] {
            "During Business Hours",
            "During Off Hours",
            "Weekend"});
            this.TimeFrame.Location = new System.Drawing.Point(266, 187);
            this.TimeFrame.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.TimeFrame.Name = "TimeFrame";
            this.TimeFrame.Size = new System.Drawing.Size(956, 25);
            this.TimeFrame.TabIndex = 146;
            this.TimeFrame.ValueMember = "Option";
            // 
            // ApptType
            // 
            this.ApptType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApptType.DisplayMember = "Option";
            this.ApptType.FormattingEnabled = true;
            this.ApptType.Items.AddRange(new object[] {
            "In Office",
            "Virtual",
            "Out of Office"});
            this.ApptType.Location = new System.Drawing.Point(266, 141);
            this.ApptType.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.ApptType.Name = "ApptType";
            this.ApptType.Size = new System.Drawing.Size(956, 25);
            this.ApptType.TabIndex = 25;
            this.ApptType.ValueMember = "Option";
            this.ApptType.SelectedIndexChanged += new System.EventHandler(this.ApptType_SelectedIndexChanged);
            // 
            // TimeOfAppt
            // 
            this.TimeOfAppt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeOfAppt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeOfAppt.Location = new System.Drawing.Point(266, 95);
            this.TimeOfAppt.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.TimeOfAppt.Name = "TimeOfAppt";
            this.TimeOfAppt.ShowUpDown = true;
            this.TimeOfAppt.Size = new System.Drawing.Size(956, 23);
            this.TimeOfAppt.TabIndex = 24;
            // 
            // NeedOnlineQues
            // 
            this.NeedOnlineQues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NeedOnlineQues.DisplayMember = "Option";
            this.NeedOnlineQues.FormattingEnabled = true;
            this.NeedOnlineQues.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.NeedOnlineQues.Location = new System.Drawing.Point(266, 3);
            this.NeedOnlineQues.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.NeedOnlineQues.Name = "NeedOnlineQues";
            this.NeedOnlineQues.Size = new System.Drawing.Size(956, 25);
            this.NeedOnlineQues.TabIndex = 22;
            this.NeedOnlineQues.ValueMember = "Option";
            this.NeedOnlineQues.SelectedIndexChanged += new System.EventHandler(this.NeedOnlineQues_SelectedIndexChanged);
            // 
            // DateApptScheduled
            // 
            this.DateApptScheduled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateApptScheduled.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateApptScheduled.Location = new System.Drawing.Point(266, 49);
            this.DateApptScheduled.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.DateApptScheduled.Name = "DateApptScheduled";
            this.DateApptScheduled.Size = new System.Drawing.Size(956, 23);
            this.DateApptScheduled.TabIndex = 23;
            // 
            // Label42
            // 
            this.Label42.AutoSize = true;
            this.Label42.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label42.Location = new System.Drawing.Point(20, 0);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(234, 26);
            this.Label42.TabIndex = 143;
            this.Label42.Text = "Client Intake Process";
            // 
            // ClientIntakeProcess
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PreliminayPanel);
            this.Name = "ClientIntakeProcess";
            this.Size = new System.Drawing.Size(1350, 610);
            this.PreliminayPanel.ResumeLayout(false);
            this.PreliminayPanel.PerformLayout();
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PreliminayPanel;
        internal System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        internal System.Windows.Forms.ComboBox ApptType;
        private System.Windows.Forms.DateTimePicker TimeOfAppt;
        internal System.Windows.Forms.ComboBox NeedOnlineQues;
        private System.Windows.Forms.DateTimePicker DateApptScheduled;
        internal System.Windows.Forms.Label Label42;
        internal System.Windows.Forms.ComboBox TimeFrame;
        internal System.Windows.Forms.Button Submit;
    }
}
