using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace ImageConverter
{
    public partial class FrmMain : Form
    {
        public Thread thread;
        public bool running = false;
        public int current;
        public int total;

        public Image source = null;

        public Size SmallImageSize { get { return new Size((int)numWidth.Value, (int)numHeight.Value); } }

        public FrmMain()
        {
            InitializeComponent();
            comboExtension.SelectedIndex = 0;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Image Splitter - Load Source Image";
            ofd.Filter = "All Images|*.png;*.jpg;*.bmp";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    source = Image.FromFile(ofd.FileName);
                    txtLoad.Text = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Unable to load the image!", "Image Splitter - Error");
                    txtLoad.Text = "";
                    source = null;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Location to where the small images should be stored.";
            fbd.ShowNewFolderButton = true;
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSave.Text = fbd.SelectedPath + @"\";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (source == null)
            {
                MessageBox.Show("Please enter a valid source!", "Image Splitter - Error");
                return;
            }
            if (txtSave.Text == "")
            {
                MessageBox.Show("Please enter a valid save location!", "Image Splitter - Error");
                return;
            }
            if (!running)
            {
                running = true;
                btnStart.Text = "Stop!";
                numHeight.ReadOnly = true;
                numWidth.ReadOnly = true;
                btnSave.Enabled = false;
                btnLoad.Enabled = false;
                
                thread = new Thread(new ParameterizedThreadStart(Action));
                thread.Start(comboExtension.SelectedItem);
            }
            else
            {
                running = false;
                thread.Abort();
                btnStart.Text = "Start!";
                numHeight.ReadOnly = false;
                numWidth.ReadOnly = false;
                btnSave.Enabled = true;
                btnLoad.Enabled = true;
            }
        }

        public void Action(object ext)
        {
            string extension = ext.ToString();
            current = 0;
            Size newSize = new Size((int)numWidth.Value, (int)numHeight.Value);
            int rows = (source.Width / (int)numWidth.Value);
            int columns = (source.Height / (int)numHeight.Value);
            total = rows * columns;

            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < columns; i++)
                {
                    
                    Image curImage = new Bitmap(newSize.Width, newSize.Height);
                    int x = i * newSize.Height;
                    int y = j * newSize.Width;
                    Rectangle rect = new Rectangle(new Point(x, y), newSize);
                    using (Graphics g = Graphics.FromImage(curImage))
                    {
                        g.DrawImage(source, 0, 0, rect, GraphicsUnit.Pixel);
                    }
                    curImage.Save(txtSave.Text + txtFilename.Text.Replace("{num}", current.ToString()) + "." + extension, (extension == "png" ? ImageFormat.Png : extension == "jpg" ? ImageFormat.Jpeg : ImageFormat.Bmp));
                    current++;
                    this.Invoke((MethodInvoker)delegate
                    {
                        this.Text = "Image Splitter (" + current.ToString() + "/" + total.ToString() + ")";
                    });
                }
            }
            this.Invoke((MethodInvoker)delegate
            {
                running = false;
                btnStart.Text = "Start!";
                numHeight.ReadOnly = false;
                numWidth.ReadOnly = false;
                btnSave.Enabled = true;
                btnLoad.Enabled = true;
                this.Text = "Image Splitter";
                if (MessageBox.Show("Finished! Splitting Image.\n Want to open location?", "Image Splitter - Finished!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    Process.Start(txtSave.Text);
            });
        }

        private void FrmMain_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("Image Splitter © 2012 Visual Bounds\n\nThis tool will allow you to split a single image into\n multiple smaller images of a predefined size.\n\nThis tool is free to use and open sourced.", "Image Spliter - About");
        }

    }
}
