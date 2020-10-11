using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Intake
{
    public partial class PreliminaryInfo : UserControl
    {
        public PreliminaryInfo()
        {
            InitializeComponent();
        }

        private static PreliminaryInfo instance;
        public static PreliminaryInfo Instance => instance ?? (instance = new PreliminaryInfo());

        public bool Validate()
        {
            if (string.IsNullOrEmpty(this.MatterTypeComboBox.Text) | string.IsNullOrEmpty(this.StaffInterviewerComboBox.Text) | string.IsNullOrEmpty(this.HowHearComboBox.Text) | string.IsNullOrEmpty(this.ResponsibleLawyerComboBox.Text) | string.IsNullOrEmpty(this.LawyerComboBox.Text) | this.DateOfLossDateTimePicker.CustomFormat == " ")
            {
                if (string.IsNullOrEmpty(this.MatterTypeComboBox.Text))
                {
                    MessageBox.Show("Please select: Matter Type");
                    return false;
                }

                if (string.IsNullOrEmpty(this.StaffInterviewerComboBox.Text))
                {
                    MessageBox.Show("Please select: Staff Interviewer");
                    return false;
                }

                if (string.IsNullOrEmpty(this.HowHearComboBox.Text))
                {
                    MessageBox.Show("Please select: How did you hear about us?");
                    return false;
                }

                if (string.IsNullOrEmpty(this.ResponsibleLawyerComboBox.Text))
                {
                    MessageBox.Show("Please select: Responsible Lawyer");
                    return false;
                }

                if (string.IsNullOrEmpty(this.LawyerComboBox.Text))
                {
                    MessageBox.Show("Please select: File Lawyer");
                    return false;
                }

                if (this.DateOfLossDateTimePicker.CustomFormat == " ")
                {
                    MessageBox.Show("Please select: Date of Loss");
                    return false;
                }
            }
            else if (this.MatterSubTypeComboBox.Items.Count > 0 & string.IsNullOrEmpty(this.MatterSubTypeComboBox.Text))
            {
                MessageBox.Show("Please select: Matter Sub Type");
                return false;
            }

            return true;
        }

        public void getNewFileNumber(string lastFileNumber)
        {
            if (!string.IsNullOrEmpty(this.LawyerComboBox.Text))
            {
                DataRow[] dr;
                // Dim lastFileNumber As String = ActionLogDBDataSet.Tables("Intakes").Rows(0)("FileNumber")
                int lastFileNumberYear = Convert.ToInt32(lastFileNumber.Substring(0, 4));
                int thisYear = DateTime.Now.Year;
                if (thisYear == lastFileNumberYear)
                {
                    string nextFileString = "000";
                    string lastFile = lastFileNumber.Substring(6, 3);
                    int nextFileNumber = (int)(Convert.ToDouble(lastFile) + 1d);
                    if (nextFileNumber.ToString().Length == 1)
                        nextFileString = "00" + nextFileNumber;
                    if (nextFileNumber.ToString().Length == 2)
                        nextFileString = "0" + nextFileNumber;
                    if (nextFileNumber.ToString().Length == 3)
                        nextFileString = nextFileNumber.ToString();
                    dr = this.ActionLogDBDataSet.Tables["FileLawyer"].Select("Lawyer='" + this.LawyerComboBox.Text + "'");
                    if (dr.Length > 0)
                    {
                        string nextFile = thisYear + dr[0]["NumberID"].ToString() + nextFileString;
                        this.FileNumberTextBox.Text = nextFile;
                    }
                }
                else
                {
                    dr = this.ActionLogDBDataSet.Tables["FileLawyer"].Select("Lawyer='" + this.LawyerComboBox.Text + "'");
                    if (dr.Length > 0)
                    {
                        string nextFileString = "001";
                        string nextFile = thisYear + dr[0]["NumberID"].ToString() + nextFileString;
                        this.FileNumberTextBox.Text = nextFile;
                    }
                }
            }
            else
            {
                this.FileNumberTextBox.Clear();
            }
        }

        private void MatterSubTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var matterSubType = ActionLogDBDataSet.MatterSubTypes.FirstOrDefault(s => (s.MatterSubType ?? "") == (this.MatterSubTypeComboBox.Text ?? ""));
            if (matterSubType is object & !string.IsNullOrEmpty(matterSubType["StatutoryNotice"].ToString()))
            {
                this.StatutoryNoticeBox.Text = DateOfLossDateTimePicker.Value.AddDays(10).ToString("MMM-dd-yyyy");
            }
            else
            {
                this.StatutoryNoticeBox.Text = "";
            }
        }

        private void DateOfLossDateTimePicker_ValueChanged(object Sender, EventArgs e)
        {
            this.DateOfLossDateTimePicker.CustomFormat = "MMM-dd-yyyy";
            DataRow[] dr;
            dr = this.ActionLogDBDataSet.Tables["MatterSubTypes"].Select("MatterSubType='" + this.MatterSubTypeComboBox.Text + "'");
            if (dr.Length > 0)
            {
                string statutoryNotice = dr[0]["StatutoryNotice"].ToString();
                if (!string.IsNullOrEmpty(statutoryNotice))
                    this.StatutoryNoticeBox.Text = DateOfLossDateTimePicker.Value.AddDays(10).ToString("MMM-dd-yyyy");
            }

            if (this.DateOfLossDateTimePicker.CustomFormat == "MMM-dd-yyyy")
            {
                this.LimitationPeriodTextBox.Text = DateOfLossDateTimePicker.Value.AddYears(2).ToString("MMM-dd-yyyy");
            }
        }

        private void LawyerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            var lastFileNumber = ActionLogDBDataSet.Intakes.FirstOrDefault().FileNumber.ToString();
            this.getNewFileNumber(lastFileNumber);
        }

        private void PreliminaryInfo_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            this.HearAboutUsTableAdapter.Fill(this.ActionLogDBDataSet.HearAboutUs);
            this.StaffInterviewerTableAdapter.Fill(this.ActionLogDBDataSet.StaffInterviewer);
            this.ResponsibleLawyerTableAdapter.Fill(this.ActionLogDBDataSet.ResponsibleLawyer);
            this.FileLawyerTableAdapter.Fill(this.ActionLogDBDataSet.FileLawyer);
            this.IntakesTableAdapter.Fill(this.ActionLogDBDataSet.Intakes);
            this.MatterTypeTableAdapter.Fill(this.ActionLogDBDataSet.MatterType);
            this.MatterSubTypesTableAdapter.Fill(this.ActionLogDBDataSet.MatterSubTypes);
            var obj = this.IntakesBindingSource.AddNew();
            this.MatterSubTypeComboBox.Items.Clear();
            foreach (DataRow row in this.ActionLogDBDataSet.MatterSubTypes.Rows)
            {
                if (row["Matter"].ToString() == "Motor Vehicle Accident")
                {
                    this.MatterSubTypeComboBox.Items.Add(row["MatterSubType"].ToString());
                }
            }

            this.LawyerComboBox.SelectedIndex = -1;
            string lastFileNumber = this.ActionLogDBDataSet.Tables["Intakes"].Rows[0]["FileNumber"].ToString();
            getNewFileNumber(lastFileNumber);
            this.DateOfLossDateTimePicker.Format = DateTimePickerFormat.Custom;
            this.DateOfLossDateTimePicker.CustomFormat = " ";
            this.LimitationPeriodTextBox.Text = "";
        }

        public void OnNext()
        {
            //IntakeForm.IntakesBindingSource.EndEdit();
            //IntakeForm.IntakesTableAdapter.Update(this.ActionLogDBDataSet.Intakes);
        }

        private void MatterTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
