using RRFFilesManager.Abstractions;
using RRFFilesManager.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.ArchiveControls
{
    public partial class StandardBenefitsStatementUserControl : DocumentFormUserControl
    {
        List<Control> tomove = new List<Control>();
        private readonly IStandardBenefitRowRepository _standardBenefitRowRepository;
        //private readonly IArchiveRepository _archiveRepository;
        public StandardBenefitsStatementUserControl()
        {
            _standardBenefitRowRepository = Program.GetService<IStandardBenefitRowRepository>();
            //_archiveRepository = Program.GetService<IArchiveRepository>();
            InitializeComponent();
        }
        public override void FillAdditionalArchiveInfo(Archive archive)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("RowNumber", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Payee", System.Type.GetType("System.String"));
            dt.Columns.Add("MRACGSAProvided", System.Type.GetType("System.String"));
            dt.Columns.Add("DatePaid", System.Type.GetType("System.DateTime"));
            //dt.Columns.Add("StatementPeriodEnds", System.Type.GetType("System.DateTime"));
            dt.Columns.Add("Amount", System.Type.GetType("System.Double"));
            dt.Columns.Add("IEAmount", System.Type.GetType("System.Double"));
            for (int i = 0; i < tableLayoutPanel1.RowCount - 1; i++)
            {
                DataRow row = dt.NewRow();
                row["RowNumber"] = i;
                dt.Rows.Add(row);
            }
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Label)
                {
                    int rowN = tableLayoutPanel1.GetRow(control);
                    int columnN = tableLayoutPanel1.GetColumn(control);
                    string columnName = "";
                    string data = "";
                    bool amount = false;
                    bool date = false;
                    switch (columnN)
                    {
                        case 0:
                            columnName = "Payee";
                            break;
                        case 1:
                            columnName = "MRACGSAProvided";
                            break;
                        case 2:
                            columnName = "DatePaid";
                            date = true;
                            break;
                        case 3:
                            columnName = "Amount";
                            amount = true;
                            break;
                        case 4:
                            columnName = "IEAmount";
                            amount = true;
                            break;
                        default:
                            break;
                    }
                    data = control.Text;
                    if (amount)
                    {
                        dt.Rows[rowN][columnName] = double.Parse(data, NumberStyles.Currency);
                    }
                    else if (date)
                    {
                        dt.Rows[rowN][columnName] = Convert.ToDateTime(data);
                    }
                    else
                    {
                        dt.Rows[rowN][columnName] = data;
                    }
                }
            }
            foreach (DataRow row in dt.Rows)
            {
                bool filled = FilledRow(row);
                if (filled)
                {
                    StandardBenefitRow sbRow = new StandardBenefitRow();
                    sbRow.RowNumber = dt.Rows.IndexOf(row);
                    sbRow.Archive = archive;
                    sbRow.Payee = row["Payee"].ToString();
                    sbRow.MRGSAProvided = row["MRACGSAProvided"].ToString();
                    sbRow.DatePaid = Convert.ToDateTime(row["DatePaid"]);
                    sbRow.Amount = Convert.ToDouble(row["Amount"]);
                    sbRow.IEAmount = Convert.ToDouble(row["IEAmount"]);

                    _standardBenefitRowRepository.Insert(archive, sbRow);
                }
            }
        }
        public override void FillArchiveInfo(Archive archive)
        {
            archive.PolicyClaimLimit = PolicyClaimLimit.DollarValue.ToString();
            archive.InsuranceCompany = InsuranceCompany.Text;
            archive.StatementPeriodFrom = StatementPeriodFrom.Value;
            archive.StatementPeriodTo = StatementPeriodTo.Value;

            /*tableLayoutPanel1.Controls.Add(new Label() { Text = PayeeTB.Text }, 0, rowIndex);
            tableLayoutPanel1.Controls.Add(new Label() { Text = MRACGSAProvidedTB.Text }, 1, rowIndex);
            tableLayoutPanel1.Controls.Add(new Label() { Text = DatePaidDTP.Value.ToString("MM/dd/yyyy") }, 2, rowIndex);
            tableLayoutPanel1.Controls.Add(new Label() { Text = StatementPeriodEndsDTP.Value.ToString("MM/dd/yyyy") }, 3, rowIndex);
            tableLayoutPanel1.Controls.Add(new Label() { Text = AmountTB.DollarValue.ToString("C") }, 4, rowIndex);
            tableLayoutPanel1.Controls.Add(new Label() { Text = IEAmountTB.DollarValue.ToString("C") }, 5, rowIndex);*/
           

        }

        private bool FilledRow(DataRow row)
        {
            bool filled = true;
            foreach (DataColumn col in row.Table.Columns)
            {
                if (col.ColumnName == "IEAmount")
                {
                    continue;
                }
                if (String.IsNullOrEmpty(row[col].ToString()))
                {
                    filled = false;
                }
            }
            return filled;
        }
        public override void ClearForm()
        {
            PolicyClaimLimit.ResetText();
            StatementPeriodFrom.ResetText();
            StatementPeriodTo.ResetText();
            InsuranceCompany.ResetText();
            for(int i = tableLayoutPanel1.RowCount - 2; i>=0; i--)
            {
                deleteRow(i);
            }
            PayeeTB.ResetText();
            MRACGSAProvidedTB.ResetText();
            DatePaidDTP.ResetText();
            AmountTB.ResetText();
            IEAmountTB.ResetText();
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HHPaidToDate_TextChanged(object sender, EventArgs e)
        {

        }

        //public override string GetFileName(string text, DateTime? documentDate = null, DateTime? documentDateFrom = null, DateTime? documentDateTo = null, DocumentNameTypeEnum documentNameType = default)
        //{
        //    return $"{base.GetFileName(text, documentDate, documentDateFrom, documentDateTo, documentNameType)}";
        //}

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void IEAssessPdToDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void MRRemaining_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (String.IsNullOrWhiteSpace(PayeeTB.Text) || String.IsNullOrWhiteSpace(MRACGSAProvidedTB.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }*/
            int rowIndex = tableLayoutPanel1.RowCount - 1;
            int height = tableLayoutPanel1.Size.Height;

            tableLayoutPanel1.RowStyles.Insert(rowIndex, new RowStyle(SizeType.AutoSize));
            tableLayoutPanel1.RowCount++;
            /*foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (tableLayoutPanel1.GetRow(control) >= rowIndex)
                {
                    tableLayoutPanel1.SetRow(control, tableLayoutPanel1.GetRow(control) + 1);
                }
            }*/
            foreach (Control control in tomove)
            {
                tableLayoutPanel1.SetRow(control, tableLayoutPanel1.GetRow(control) + 1);
                Update();
            }
            tableLayoutPanel1.Controls.Add(new Label() { Text = PayeeTB.Text, Dock = DockStyle.Fill }, 0, rowIndex );
            Update();
            tableLayoutPanel1.Controls.Add(new Label() { Text = MRACGSAProvidedTB.Text, Dock = DockStyle.Fill}, 1, rowIndex);
            Update();
            tableLayoutPanel1.Controls.Add(new Label() { Text = DatePaidDTP.Value.ToString("MM/dd/yyyy"), Dock = DockStyle.Fill }, 2, rowIndex);
            Update();
            tableLayoutPanel1.Controls.Add(new Label() { Text = AmountTB.DollarValue.ToString("C"), Dock = DockStyle.Fill }, 3, rowIndex);
            Update();
            tableLayoutPanel1.Controls.Add(new Label() { Text = IEAmountTB.DollarValue.ToString("C"), Dock = DockStyle.Fill }, 4, rowIndex);
            Update();
            Button btn = new Button() { Text = "-" };
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Blue;
            btn.ForeColor = Color.White;
            btn.Size = new Size(20, 23);
            btn.Dock = DockStyle.Top;
            btn.Click += buttonminus_Click;
            tableLayoutPanel1.Controls.Add(btn, 5, rowIndex);
            Update();
            PayeeTB.Clear();
            MRACGSAProvidedTB.Clear();
            AmountTB.Clear();
            IEAmountTB.Clear();
            tableLayoutPanel1.Size = new Size(tableLayoutPanel1.Size.Width, height);
            Update();
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete this row?", "Deleting row...", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                return;
            }
            int row = tableLayoutPanel1.GetPositionFromControl(sender as Control).Row;
            deleteRow(row);
        }

        private void deleteRow(int row)
        {
            //MessageBox.Show($"Row {row}");
            int controlrow = 0;
            List<Control> todelete = new List<Control>();
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                controlrow = tableLayoutPanel1.GetRow(control);
                //MessageBox.Show($"Control {control.Text} Row {controlrow} must be equal to {row}");
                if (controlrow == row)
                {
                    todelete.Add(control);
                    //tableLayoutPanel1.Controls.Remove(control);
                    //Update();
                }
            }
            foreach (Control control in todelete)
            {
                tableLayoutPanel1.Controls.Remove(control);
            }
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (tableLayoutPanel1.GetRow(control) > row)
                {
                    tableLayoutPanel1.SetRow(control, tableLayoutPanel1.GetRow(control) - 1);
                }
            }
            int rowindex = tableLayoutPanel1.RowCount - 1;
            tableLayoutPanel1.RowStyles.RemoveAt(rowindex);
            tableLayoutPanel1.RowCount--;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StandardBenefitsStatementUserControl_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.AutoScroll = false;
            tableLayoutPanel1.HorizontalScroll.Maximum = 0;
            tableLayoutPanel1.VerticalScroll.Visible = false;
            tableLayoutPanel1.AutoScroll = true;
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                tomove.Add(control);
            }
        }

        private void PolicyClaimLimit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
