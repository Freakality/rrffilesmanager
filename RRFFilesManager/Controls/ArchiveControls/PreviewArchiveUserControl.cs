using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRFFilesManager.Controls.ArchiveControls
{
    public partial class PreviewArchiveUserControl : UserControl
    {
        public PreviewArchiveUserControl()
        {
            InitializeComponent();

            axAcroPDF.setShowToolbar(false);
            axAcroPDF.setShowScrollbars(true);
        }

        private void previewHandlerHost1_Click(object sender, EventArgs e)
        {

        }

        public void Preview(string path)
        {
            if (path == null || previewHandlerHost1 == null || axAcroPDF == null || pictureBox == null || richTextBox == null)
                return;
            previewHandlerHost1.Hide();
            axAcroPDF.Hide();
            pictureBox.Hide();
            richTextBox.Hide();
            try
            {
                var ext = Path.GetExtension(path);
                var perceivedType = Convert.ToString(Registry.ClassesRoot.OpenSubKey(ext).GetValue("PerceivedType"));
                if (ext == ".pdf")
                {
                    PreviewPDF(path);
                }
                else if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || perceivedType == "image")
                {
                    PreviewPicture(path);
                }
                else if (ext == ".txt" || perceivedType == "text")
                {
                    PreviewText(path);
                }
                else
                {
                    PreviewDefault(path);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show($"Error al intentar previsualizar archivo: {e.Message}");
            }
            
        }

        private void PreviewPDF(string path)
        {
            axAcroPDF.LoadFile(path);
            axAcroPDF.src = path;
            axAcroPDF.setShowToolbar(false);
            axAcroPDF.Refresh();
            axAcroPDF.Size = PreviewPanel.Size;
            axAcroPDF.Show();
        }

        private void PreviewPicture(string path)
        {
            var imagenOriginal = new Bitmap(path);
            Bitmap resized = imagenOriginal;
            var maxWidth = PreviewPanel.Width;
            var maxHeight = PreviewPanel.Height;
            if (imagenOriginal.Width > maxWidth)
            {
                var ratio = (double)imagenOriginal.Width / (double)maxWidth;
                var height = Convert.ToInt32(Math.Round((double)imagenOriginal.Height / ratio));
                resized = new Bitmap(imagenOriginal, new Size(maxWidth, height));
            }
            else if (imagenOriginal.Height > Height)
            {
                var ratio = (double)imagenOriginal.Height / (double)Height;
                var newWidth = Convert.ToInt32(Math.Round((double)imagenOriginal.Width / ratio));
                resized = new Bitmap(imagenOriginal, new Size(newWidth, maxHeight));
            }
            pictureBox.Image = resized;
            pictureBox.Show();
        }

        private void PreviewText(string path)
        {
            richTextBox.Text = System.IO.File.ReadAllText(path);
            richTextBox.Show();
        }

        private void PreviewDefault(string path)
        {
            //if (ext == ".doc" || ext == ".docx" || ext == ".xls" || ext == ".xlsx")
            //{
            previewHandlerHost1.Open(path);
            previewHandlerHost1.Show();
            //}
        }
    }
}
