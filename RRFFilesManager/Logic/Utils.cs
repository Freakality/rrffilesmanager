using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace RRFFilesManager.Logic
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
            return form;
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
    }
}
