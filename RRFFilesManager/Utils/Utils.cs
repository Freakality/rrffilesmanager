using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace RRFFilesManager.Utils
{
    public class Utils
    {
        public static void SetComboBoxDataSource(ComboBox comboBox, object dataSource, string displayMember = null)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.SelectedItem = null;
            comboBox.ResetText();
        }

        public static byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null)
                return null;
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);

                return ms.ToArray();
            }
        }

        public static Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null)
                return null;
            using (var ms = new MemoryStream(byteArrayIn))
            {
                var returnImage = Image.FromStream(ms);

                return returnImage;
            }
        }

        public static void SetContent(Control Content, Control control)
        {
            Content.Controls.Clear();
            if (control == null)
                return;
            Content.Controls.Add(control);
            Content.Controls[0].Dock = DockStyle.Fill;
        }

        public static T OpenForm<T>(Form from = null) where T : Form, new()
        {
            from?.Hide();
            PleaseWait.Instance.Show();
            var form = new T();
            form.Show();
            PleaseWait.Instance.Hide();
            form.FormClosing += ReturnHome_FormClosing;
            return form;
        }
        private static void ReturnHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseForm(sender as Form, Home.Instance);
        }
        public static void CloseForm(Form from, Form to)
        {
            to.Show();
        }

        public static void AddButtonToGridView(DataGridView GridView, string name, int columnIndex = 0, string text = null)
        {
            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
            editButtonColumn.Name = name;
            editButtonColumn.Text = text ?? name;
            editButtonColumn.UseColumnTextForButtonValue = true;
            if (GridView.Columns[name] == null)
            {
                GridView.Columns.Insert(columnIndex, editButtonColumn);
            }
        }

        public static int? GetDataGridViewId(DataGridView DataGridView)
        {
            if (DataGridView?.SelectedRows.Count == 0)
                return null;
            var id = DataGridView?.SelectedRows?[0]?.Cells?["ID"]?.Value.ToString();
            if (id == null)
                return null;
            return int.Parse(id);
        }

        public static  void InitializeDataGridViewWithCheck<T>(DataGridView DataGridView, List<T> items)
        {
            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.MultiSelect = false;
            DataGridView.DataSource = new SortableBindingList<T>(items);
            DataGridView.ReadOnly = false;
            foreach (DataGridViewColumn column in DataGridView.Columns)
            {
                column.ReadOnly = true;
            }
            DataGridView.Columns["Check"].ReadOnly = false;
            DataGridView.Columns["Check"].HeaderText = "";


            if (DataGridView.Columns.Count == 0)
                return;
            DataGridView.Columns["ID"].Visible = false;

        }
    }
}
