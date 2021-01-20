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
            Content.Controls.Add(control);
            Content.Controls[0].Dock = DockStyle.Fill;
        }
    }
}
