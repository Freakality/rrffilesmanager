using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RRFFilesManager.DataAccess;
using RRFFilesManager.Abstractions.DataAccess;
using RRFFilesManager.Abstractions;

namespace RRFFilesManager.IntakeForm
{
    public partial class PreliminaryInfo : UserControl
    {
        public PreliminaryInfo()
        {
            InitializeComponent();
        }

        private static PreliminaryInfo instance;
        public static PreliminaryInfo Instance => instance ?? (instance = new PreliminaryInfo());

        public new bool Validate()
        {
            if (string.IsNullOrEmpty(MatterTypeComboBox.Text) | string.IsNullOrEmpty(StaffInterviewerComboBox.Text) | string.IsNullOrEmpty(HowHearComboBox.Text) | string.IsNullOrEmpty(ResponsibleLawyerComboBox.Text) | string.IsNullOrEmpty(LawyerComboBox.Text) | DateOfLossDateTimePicker.CustomFormat == " ")
            {
                if (string.IsNullOrEmpty(MatterTypeComboBox.Text))
                {
                    MessageBox.Show("Please select: Matter Type");
                    return false;
                }

                if (string.IsNullOrEmpty(StaffInterviewerComboBox.Text))
                {
                    MessageBox.Show("Please select: Staff Interviewer");
                    return false;
                }

                if (string.IsNullOrEmpty(HowHearComboBox.Text))
                {
                    MessageBox.Show("Please select: How did you hear about us?");
                    return false;
                }

                if (string.IsNullOrEmpty(ResponsibleLawyerComboBox.Text))
                {
                    MessageBox.Show("Please select: Responsible Lawyer");
                    return false;
                }

                if (string.IsNullOrEmpty(LawyerComboBox.Text))
                {
                    MessageBox.Show("Please select: File Lawyer");
                    return false;
                }

                if (DateOfLossDateTimePicker.CustomFormat == " ")
                {
                    MessageBox.Show("Please select: Date of Loss");
                    return false;
                }
            }
            else if (MatterSubTypeComboBox.Items.Count > 0 & string.IsNullOrEmpty(MatterSubTypeComboBox.Text))
            {
                MessageBox.Show("Please select: Matter Sub Type");
                return false;
            }

            return true;
        }

        public int GetNewFileNumber(Lawyer lawyer)
        {
            var lastFileNumber = 999999;
            if (lawyer == null)
                return lastFileNumber;
            using (var context = new DataContext())
            {
                lastFileNumber = context.Intakes.Where(s => s.FileLawyer.ID == lawyer.ID).Max(s => (int?)s.FileNumber) ?? 999999;
            }
            var lastfileNumberFirstPart = lastFileNumber.ToString()?.Substring(0, 6);
            var fileNumberFirstPart = $"{DateTime.Now.Year}{lawyer.NumberID?.ToString() ?? ""}";
            if (lastfileNumberFirstPart == fileNumberFirstPart)
                return lastFileNumber + 1;
            else
            {
                return int.Parse($"{fileNumberFirstPart}000");
            }
        }

        private void MatterSubTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                var matterSubType = (MatterSubType)MatterSubTypeComboBox.SelectedItem;
                if (matterSubType?.StatutoryNotice != null)
                {
                    StatutoryNoticeBox.Text = DateOfLossDateTimePicker.Value.AddDays(10).ToString("MMM-dd-yyyy");
                }
                else
                {
                    StatutoryNoticeBox.Text = "";
                }
            }
        }

        private void DateOfLossDateTimePicker_ValueChanged(object Sender, EventArgs e)
        {
            DateOfLossDateTimePicker.CustomFormat = "MMM-dd-yyyy";
            DataRow[] dr;
            dr = ActionLogDBDataSet.Tables["MatterSubTypes"].Select("MatterSubType='" + MatterSubTypeComboBox.Text + "'");
            if (dr.Length > 0)
            {
                string statutoryNotice = dr[0]["StatutoryNotice"].ToString();
                if (!string.IsNullOrEmpty(statutoryNotice))
                    StatutoryNoticeBox.Text = DateOfLossDateTimePicker.Value.AddDays(10).ToString("MMM-dd-yyyy");
            }

            if (DateOfLossDateTimePicker.CustomFormat == "MMM-dd-yyyy")
            {
                LimitationPeriodTextBox.Text = DateOfLossDateTimePicker.Value.AddYears(2).ToString("MMM-dd-yyyy");
            }
        }

        private void LawyerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new DataContext())
            {
                var lawyer = (Lawyer)LawyerComboBox.SelectedItem;
                var fileNumber = GetNewFileNumber(lawyer);
                FileNumberTextBox.Text = fileNumber.ToString();
            }
        }

        private void PreliminaryInfo_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            using (var context = new DataContext())
            {
                MatterTypeComboBox.DataSource = context.MatterTypes.ToList();
                MatterTypeComboBox.DisplayMember = nameof(MatterType.Description);

                MatterSubTypeComboBox.DataSource = context.MatterSubTypes.ToList();
                MatterSubTypeComboBox.DisplayMember = nameof(MatterSubType.Description);

                HowHearComboBox.DataSource = context.HearAboutUs.ToList();
                HowHearComboBox.DisplayMember = nameof(HearAboutUs.Description);

                StaffInterviewerComboBox.DataSource = context.Lawyers.ToList();
                StaffInterviewerComboBox.DisplayMember = nameof(Lawyer.Description);

                ResponsibleLawyerComboBox.DataSource = context.Lawyers.ToList();
                ResponsibleLawyerComboBox.DisplayMember = nameof(Lawyer.Description);

                LawyerComboBox.DataSource = context.Lawyers.ToList();
                LawyerComboBox.DisplayMember = nameof(Lawyer.Description);
            }
            //HearAboutUsTableAdapter.Fill(ActionLogDBDataSet.HearAboutUs);
            //StaffInterviewerTableAdapter.Fill(ActionLogDBDataSet.StaffInterviewer);
            //ResponsibleLawyerTableAdapter.Fill(ActionLogDBDataSet.ResponsibleLawyer);
            //FileLawyerTableAdapter.Fill(ActionLogDBDataSet.FileLawyer);
            //IntakesTableAdapter.Fill(ActionLogDBDataSet.Intakes);
            //MatterTypeTableAdapter.Fill(ActionLogDBDataSet.MatterType);
            //var service = Program.ServiceProvider.GetService<IMatterTypeRepository>();
            //MatterSubTypesTableAdapter.Fill(ActionLogDBDataSet.MatterSubTypes);
            //var obj = IntakesBindingSource.AddNew();
            //MatterSubTypeComboBox.Items.Clear();
            //foreach (DataRow row in ActionLogDBDataSet.MatterSubTypes.Rows)
            //{
            //    if (row["Matter"].ToString() == "Motor Vehicle Accident")
            //    {
            //        MatterSubTypeComboBox.Items.Add(row["MatterSubType"].ToString());
            //    }
            //}

            //LawyerComboBox.SelectedIndex = -1;
            //string lastFileNumber = ActionLogDBDataSet.Tables["Intakes"].Rows[0]["FileNumber"].ToString();
            //getNewFileNumber(lastFileNumber);
            DateOfLossDateTimePicker.Format = DateTimePickerFormat.Custom;
            DateOfLossDateTimePicker.CustomFormat = " ";
            LimitationPeriodTextBox.Text = "";
        }

        public void OnNext()
        {
            //IntakeForm.IntakesBindingSource.EndEdit();
            //IntakeForm.IntakesTableAdapter.Update(ActionLogDBDataSet.Intakes);
        }

        private void MatterTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
    }
}
