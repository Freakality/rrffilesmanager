using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
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
        public static T OpenFormLogIn<T>(Form from = null) where T : Form, new()
        {
            from?.Hide();
            PleaseWait.Instance.Show();
            var form = new T();
            form.Show();
            PleaseWait.Instance.Hide();
            form.FormClosing += ReturnLogIn_FormClosing;
            return form;
        }
        private static void ReturnHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseForm(sender as Form, Home.Instance);
        }
        private static void ReturnLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseForm(sender as Form, LoginUI.Instance);
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

        public static string GetHash(string username, string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);
            var pbkdf2 = new Rfc2898DeriveBytes(username + password, salt, 10310);
            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);
            string savedPasswordHash = Convert.ToBase64String(hashBytes);
            return savedPasswordHash;
        }

        public static int UserLog(string username, string password, string passwordHash2)
        {
            int ok = 1;
            byte[] hashBytes2 = Convert.FromBase64String(passwordHash2);
            byte[] salt2 = new byte[16];
            Array.Copy(hashBytes2, 0, salt2, 0, 16);
            var pbkdf22 = new Rfc2898DeriveBytes(username + password, salt2, 10310);
            byte[] hash2 = pbkdf22.GetBytes(20);
            for (int i = 0; i < 20; i++)
                if (hashBytes2[i + 16] != hash2[i])
                {
                    ok = 0;
                    break;
                }
            return ok;
        }

        public static DataTable ListToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            //PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            PropertyInfo[] Props = items?.FirstOrDefault()?.GetType().GetProperties()?? new PropertyInfo[] { };

            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }           
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item,null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }


    }
}
