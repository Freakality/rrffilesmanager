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

        public void getNewFileNumber(string lastFileNumber)
        {
            if (!string.IsNullOrEmpty(LawyerComboBox.Text))
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
                    dr = ActionLogDBDataSet.Tables["FileLawyer"].Select("Lawyer='" + LawyerComboBox.Text + "'");
                    if (dr.Length > 0)
                    {
                        string nextFile = thisYear + dr[0]["NumberID"].ToString() + nextFileString;
                        FileNumberTextBox.Text = nextFile;
                    }
                }
                else
                {
                    dr = ActionLogDBDataSet.Tables["FileLawyer"].Select("Lawyer='" + LawyerComboBox.Text + "'");
                    if (dr.Length > 0)
                    {
                        string nextFileString = "001";
                        string nextFile = thisYear + dr[0]["NumberID"].ToString() + nextFileString;
                        FileNumberTextBox.Text = nextFile;
                    }
                }
            }
            else
            {
                FileNumberTextBox.Clear();
            }
        }

        private void MatterSubTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var matterSubType = ActionLogDBDataSet.MatterSubTypes.FirstOrDefault(s => (s.MatterSubType ?? "") == (MatterSubTypeComboBox.Text ?? ""));
            if (matterSubType is object & !string.IsNullOrEmpty(matterSubType["StatutoryNotice"].ToString()))
            {
                StatutoryNoticeBox.Text = DateOfLossDateTimePicker.Value.AddDays(10).ToString("MMM-dd-yyyy");
            }
            else
            {
                StatutoryNoticeBox.Text = "";
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

            var lastFileNumber = ActionLogDBDataSet.Intakes.FirstOrDefault().FileNumber.ToString();
            getNewFileNumber(lastFileNumber);
        }

        private void PreliminaryInfo_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            HearAboutUsTableAdapter.Fill(ActionLogDBDataSet.HearAboutUs);
            StaffInterviewerTableAdapter.Fill(ActionLogDBDataSet.StaffInterviewer);
            ResponsibleLawyerTableAdapter.Fill(ActionLogDBDataSet.ResponsibleLawyer);
            FileLawyerTableAdapter.Fill(ActionLogDBDataSet.FileLawyer);
            IntakesTableAdapter.Fill(ActionLogDBDataSet.Intakes);
            MatterTypeTableAdapter.Fill(ActionLogDBDataSet.MatterType);
            MatterSubTypesTableAdapter.Fill(ActionLogDBDataSet.MatterSubTypes);
            //var obj = IntakesBindingSource.AddNew();
            MatterSubTypeComboBox.Items.Clear();
            foreach (DataRow row in ActionLogDBDataSet.MatterSubTypes.Rows)
            {
                if (row["Matter"].ToString() == "Motor Vehicle Accident")
                {
                    MatterSubTypeComboBox.Items.Add(row["MatterSubType"].ToString());
                }
            }

            LawyerComboBox.SelectedIndex = -1;
            string lastFileNumber = ActionLogDBDataSet.Tables["Intakes"].Rows[0]["FileNumber"].ToString();
            getNewFileNumber(lastFileNumber);
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
            var Provinces = Program.DataContext.Provinces.ToList();
        }
    }
}
