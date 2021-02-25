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
using AxAcroPDFLib;
using Microsoft.Web.WebView2.Core;
using Microsoft.Win32;
using RRFFilesManager.Logic;

namespace RRFFilesManager.Controls.ArchiveControls
{
    public partial class UploadArchivesForm : Form
    {
        BindingList<FileInfo> UploadedFiles = new BindingList<FileInfo>();
        public UploadArchivesForm()
        {
            InitializeComponent();
            InitAsync();
            axAcroPDF.setShowToolbar(false);
            axAcroPDF.setShowScrollbars(true);

            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(UploadArchivesForm_DragEnter);
            this.DragDrop += new DragEventHandler(UploadArchivesForm_DragDrop);
            FilesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            FilesGridView.MultiSelect = false;
            FilesGridView.ReadOnly = true;
            FilesGridView.DragEnter += new DragEventHandler(UploadArchivesForm_DragEnter);
            FilesGridView.DragDrop += new DragEventHandler(UploadArchivesForm_DragDrop);
            this.FilesGridView.DataSource = this.UploadedFiles;
            //this.printPreviewControl.Document = new System.Drawing.Printing.PrintDocument();
            //this.printPreviewControl.Document.DocumentName = "C:\\Users\\felix\\Downloads\\327485 (1).pdf";
            
        }

        private async void InitAsync()
        {
            //await WebView.EnsureCoreWebView2Async(null);
            //WebView.Source = new Uri("C:\\Users\\felix\\Downloads\\327485 (1).pdf");
            //WebView.Source = new Uri("C:\\Users\\felix\\Downloads\\IntegracionGDS.docx");
            //WebView.Source = new Uri("C:\\Users\\felix\\Downloads\\Document Entry Form1 (2).jpg");
        }
        void UploadArchivesForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void UploadArchivesForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string path in paths) 
            {
                //if (UploadedFiles.Any(s => s.FullName == path))
                //    continue;
                if (File.Exists(path))
                {
                    var fileInfo = new FileInfo(path);
                    UploadedFiles.Add(fileInfo);
                }
                else if (Directory.Exists(path))
                {
                    var filesPath = Directory.GetFiles(path);
                    foreach (string filePath in filesPath)
                    {
                        //if (UploadedFiles.Any(s => s.FullName == filePath))
                        //    continue;
                        UploadedFiles.Add(new FileInfo(filePath));
                    }
                        
                }
                else
                {
                    // path doesn't exist.
                }
                //Directory.GetFiles(sourceDir)
                UpdateDataSource();
            }
        }

        private void UpdateDataSource()
        {
            FilesGridView.Update();
        }

        private void UploadArchivesForm_Load(object sender, EventArgs e)
        {

        }

        private void FilesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UploadArchivesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Home.Instance.Show();
        }

        private void FilesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var path = FilesGridView?.SelectedRows?[0]?.Cells?["FullName"]?.Value.ToString();
            //this.printPreviewControl.Document = new System.Drawing.Printing.PrintDocument();
            //this.printPreviewControl.Document.DocumentName = path;
            //if (WebView != null && WebView.CoreWebView2 != null)
            //{
            //    WebView.CoreWebView2.Navigate(path);
            //}
            //webView.NavigateToString("<h1>Hola Mundo!</h1>");//.Navigate(path);
            //PreviewHandlerHost = new PreviewHandlerHost();
            //Utils.SetContent(PreviewPanel, PreviewHandlerHost);
            previewHandlerHost1.Hide();
            axAcroPDF.Hide();
            pictureBox.Hide();
            richTextBox.Hide();

            var ext = Path.GetExtension(path);
            var perceivedType = Convert.ToString(Registry.ClassesRoot.OpenSubKey(ext).GetValue("PerceivedType"));
            if (ext == ".pdf")
            {
                //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadArchivesForm));
                //axAcroPDF = new AxAcroPDF();
                //((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).BeginInit();
                //this.axAcroPDF.Dock = System.Windows.Forms.DockStyle.Fill;
                //this.axAcroPDF.Enabled = true;
                //this.axAcroPDF.Location = new System.Drawing.Point(0, 0);
                //this.axAcroPDF.Name = "axAcroPDF";
                //this.axAcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF.OcxState")));
                //this.axAcroPDF.Size = new System.Drawing.Size(465, 665);
                //this.axAcroPDF.TabIndex = 0;
                //this.axAcroPDF.Visible = false;
                //((System.ComponentModel.ISupportInitialize)(this.axAcroPDF)).EndInit();
                axAcroPDF.LoadFile(path);
                axAcroPDF.src = path;
                axAcroPDF.setShowToolbar(false);
                //axAcroPDF.setLayoutMode("SinglePage");
                //axAcroPDF.setPageMode("PDUseNone");
                axAcroPDF.Show();
            }
            else if (ext == ".jpg" || ext == ".jpeg" || ext == ".png" || perceivedType == "image")
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
                var width =

                pictureBox.Image = resized;
                pictureBox.Show();
            }
            else if (ext == ".txt" || perceivedType == "text")
            {
                richTextBox.Text = File.ReadAllText(path);
                richTextBox.Show();
            }
            else
            {
                //if (ext == ".doc" || ext == ".docx" || ext == ".xls" || ext == ".xlsx")
                //{
                previewHandlerHost1.Open(path);
                previewHandlerHost1.Show();
                //}
            }


        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void PreviewPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PreviewHandlerControl_Load(object sender, EventArgs e)
        {

        }

        private void PreviewHandlerHost_Click(object sender, EventArgs e)
        {

        }
    }
}
