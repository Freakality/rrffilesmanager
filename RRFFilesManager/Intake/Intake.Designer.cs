namespace RRFFilesManager.Intake
{
    partial class Intake
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
            this.components = new System.ComponentModel.Container();
            this.ActionLogDBDataSet = new RRFFilesManager.ActionLogDBDataSet();
            this.Content = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.Actions = new System.Windows.Forms.Panel();
            this.NextButton = new System.Windows.Forms.Button();
            this.Container = new System.Windows.Forms.Panel();
            this.CYATemplatesTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.CYATemplatesTableAdapter();
            this.IntakesTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.IntakesTableAdapter();
            this.MatterSubTypesTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.MatterSubTypesTableAdapter();
            this.DisabilityInsuranceCompaniesTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.DisabilityInsuranceCompaniesTableAdapter();
            this.InsuranceCompaniesTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.InsuranceCompaniesTableAdapter();
            this.MobileCarrierTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.MobileCarrierTableAdapter();
            this.ProvincesTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.ProvincesTableAdapter();
            this.HearAboutUsTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.HearAboutUsTableAdapter();
            this.StaffInterviewerTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.StaffInterviewerTableAdapter();
            this.ResponsibleLawyerTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.ResponsibleLawyerTableAdapter();
            this.TableAdapterManager = new RRFFilesManager.ActionLogDBDataSetTableAdapters.TableAdapterManager();
            this.FileLawyerTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.FileLawyerTableAdapter();
            this.MatterTypeTableAdapter = new RRFFilesManager.ActionLogDBDataSetTableAdapters.MatterTypeTableAdapter();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.CYATemplatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MatterSubTypes1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MobileCarrierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProvincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HearAboutUsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DisabilityInsuranceCompaniesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InsuranceCompaniesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IntakesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MatterSubTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ActionLogDBDataSet)).BeginInit();
            this.Actions.SuspendLayout();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CYATemplatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatterSubTypes1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileCarrierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProvincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HearAboutUsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisabilityInsuranceCompaniesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceCompaniesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntakesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatterSubTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ActionLogDBDataSet
            // 
            this.ActionLogDBDataSet.DataSetName = "ActionLogDBDataSet";
            this.ActionLogDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click_1);
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
            // CYATemplatesTableAdapter
            // 
            this.CYATemplatesTableAdapter.ClearBeforeFill = true;
            // 
            // IntakesTableAdapter
            // 
            this.IntakesTableAdapter.ClearBeforeFill = true;
            // 
            // MatterSubTypesTableAdapter
            // 
            this.MatterSubTypesTableAdapter.ClearBeforeFill = true;
            // 
            // DisabilityInsuranceCompaniesTableAdapter
            // 
            this.DisabilityInsuranceCompaniesTableAdapter.ClearBeforeFill = true;
            // 
            // InsuranceCompaniesTableAdapter
            // 
            this.InsuranceCompaniesTableAdapter.ClearBeforeFill = true;
            // 
            // MobileCarrierTableAdapter
            // 
            this.MobileCarrierTableAdapter.ClearBeforeFill = true;
            // 
            // ProvincesTableAdapter
            // 
            this.ProvincesTableAdapter.ClearBeforeFill = true;
            // 
            // HearAboutUsTableAdapter
            // 
            this.HearAboutUsTableAdapter.ClearBeforeFill = true;
            // 
            // StaffInterviewerTableAdapter
            // 
            this.StaffInterviewerTableAdapter.ClearBeforeFill = true;
            // 
            // ResponsibleLawyerTableAdapter
            // 
            this.ResponsibleLawyerTableAdapter.ClearBeforeFill = true;
            // 
            // TableAdapterManager
            // 
            this.TableAdapterManager.ABDenialsTableAdapter = null;
            this.TableAdapterManager.ActionLogTableAdapter = null;
            this.TableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.TableAdapterManager.ClientNotesTableAdapter = null;
            this.TableAdapterManager.CYATemplatesTableAdapter = null;
            this.TableAdapterManager.DisabilityInsuranceCompaniesTableAdapter = null;
            this.TableAdapterManager.FileLawyerTableAdapter = this.FileLawyerTableAdapter;
            this.TableAdapterManager.HearAboutUsTableAdapter = null;
            this.TableAdapterManager.InsuranceCompaniesTableAdapter = null;
            this.TableAdapterManager.IntakesTableAdapter = null;
            this.TableAdapterManager.InvoicesTableAdapter = null;
            this.TableAdapterManager.LATTableAdapter = null;
            this.TableAdapterManager.MainTableAdapter = null;
            this.TableAdapterManager.MatterSubTypesTableAdapter = null;
            this.TableAdapterManager.MatterTypeTableAdapter = this.MatterTypeTableAdapter;
            this.TableAdapterManager.MedApptsTableAdapter = null;
            this.TableAdapterManager.MobileCarrierTableAdapter = null;
            this.TableAdapterManager.PLReportsTableAdapter = null;
            this.TableAdapterManager.ProvincesTableAdapter = null;
            this.TableAdapterManager.ResponsibleLawyerTableAdapter = this.ResponsibleLawyerTableAdapter;
            this.TableAdapterManager.SpecialDamagesTableAdapter = null;
            this.TableAdapterManager.StaffInterviewerTableAdapter = this.StaffInterviewerTableAdapter;
            this.TableAdapterManager.UndertakingsTableAdapter = null;
            this.TableAdapterManager.UpdateOrder = RRFFilesManager.ActionLogDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FileLawyerTableAdapter
            // 
            this.FileLawyerTableAdapter.ClearBeforeFill = true;
            // 
            // MatterTypeTableAdapter
            // 
            this.MatterTypeTableAdapter.ClearBeforeFill = true;
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
            this.PictureBox1.Location = new System.Drawing.Point(1096, 2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(224, 68);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 145;
            this.PictureBox1.TabStop = false;
            // 
            // Intake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.PictureBox1);
            this.Name = "Intake";
            this.Text = "Intake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Intake_FormClosing);
            this.Load += new System.EventHandler(this.Intake_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActionLogDBDataSet)).EndInit();
            this.Actions.ResumeLayout(false);
            this.Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CYATemplatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatterSubTypes1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobileCarrierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProvincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HearAboutUsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisabilityInsuranceCompaniesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceCompaniesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntakesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MatterSubTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.BindingSource CYATemplatesBindingSource;
        internal System.Windows.Forms.BindingSource MatterSubTypes1BindingSource;
        internal System.Windows.Forms.BindingSource MobileCarrierBindingSource;
        internal System.Windows.Forms.BindingSource ProvincesBindingSource;
        internal System.Windows.Forms.BindingSource HearAboutUsBindingSource;
        internal System.Windows.Forms.BindingSource DisabilityInsuranceCompaniesBindingSource;
        internal System.Windows.Forms.BindingSource InsuranceCompaniesBindingSource;
        internal System.Windows.Forms.BindingSource IntakesBindingSource;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal ActionLogDBDataSet ActionLogDBDataSet;
        internal System.Windows.Forms.Panel Content;
        internal System.Windows.Forms.Button BackButton;
        internal System.Windows.Forms.Panel Actions;
        internal System.Windows.Forms.Button NextButton;
        internal new System.Windows.Forms.Panel Container;
        internal ActionLogDBDataSetTableAdapters.CYATemplatesTableAdapter CYATemplatesTableAdapter;
        internal ActionLogDBDataSetTableAdapters.IntakesTableAdapter IntakesTableAdapter;
        internal ActionLogDBDataSetTableAdapters.MatterSubTypesTableAdapter MatterSubTypesTableAdapter;
        internal ActionLogDBDataSetTableAdapters.DisabilityInsuranceCompaniesTableAdapter DisabilityInsuranceCompaniesTableAdapter;
        internal ActionLogDBDataSetTableAdapters.InsuranceCompaniesTableAdapter InsuranceCompaniesTableAdapter;
        internal ActionLogDBDataSetTableAdapters.MobileCarrierTableAdapter MobileCarrierTableAdapter;
        internal ActionLogDBDataSetTableAdapters.ProvincesTableAdapter ProvincesTableAdapter;
        internal ActionLogDBDataSetTableAdapters.HearAboutUsTableAdapter HearAboutUsTableAdapter;
        internal ActionLogDBDataSetTableAdapters.StaffInterviewerTableAdapter StaffInterviewerTableAdapter;
        internal ActionLogDBDataSetTableAdapters.ResponsibleLawyerTableAdapter ResponsibleLawyerTableAdapter;
        internal ActionLogDBDataSetTableAdapters.TableAdapterManager TableAdapterManager;
        internal ActionLogDBDataSetTableAdapters.FileLawyerTableAdapter FileLawyerTableAdapter;
        internal ActionLogDBDataSetTableAdapters.MatterTypeTableAdapter MatterTypeTableAdapter;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.BindingSource MatterSubTypesBindingSource;
    }
}