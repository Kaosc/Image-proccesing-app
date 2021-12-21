using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using AForge.Imaging.Filters;
using Emgu.CV;
using Emgu.CV.Structure;

namespace ImageProcessingApp
{
    public partial class Form1 : Form
    {

        private Bitmap sourceImage;
        private Image ImageFile;
        private Image prevImage;
        private bool isImageOpened = false;
        private bool grayClicked = false;
        private int backupCount = 0;
        private BitmapData ImageData;
        private byte[] buffer;
        private byte r, g, b, grayscale;
        private IntPtr pointer;

        public Form1()
        {
            InitializeComponent();
        }

        void OpenImage()
        {
            DialogResult openFileDialog = openFileDialog1.ShowDialog();

            if (openFileDialog == DialogResult.OK)
            {
                sourceImage = (Bitmap)Image.FromFile(openFileDialog1.FileName);
                ImageFile = (Image)sourceImage.Clone();
                pictureBox1.Image = ImageFile;
                isImageOpened = true;
                backupCount = 0;
                Backup();
            }
        }

        void SaveImage()
        {
            if (isImageOpened)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat imageFormat = ImageFormat.Png;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string uzanti = Path.GetExtension(saveFileDialog.FileName);

                    switch (uzanti)
                    {
                        case ".jpg":
                            imageFormat = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            imageFormat = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(saveFileDialog.FileName, imageFormat);
                }
            }
            else
            {
                WarnMessage();
            }
        }

        void RefreshImage()
        {
            if (isImageOpened)
            {
                ImageFile = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = ImageFile;
                isImageOpened = true;
            }
        }
        
        void Backup()
        {
            backupCount++;
            if (backupCount % 2 != 0) 
            {
                prevImage = (Image)pictureBox1.Image.Clone(); 
            }
        }

        void Undo()
        {
            if(backupCount == 1)
            {
                MessageBox.Show("You didn't apply a process yet!");
            }
            else if(backupCount == 0)
            {
                WarnMessage();
            }
            else
            {
                pictureBox1.Image = prevImage;
            }
        }

        void UndoAll()
        {
            grayClicked = false;
            prevImage = sourceImage;
            ImageFile = sourceImage;
            pictureBox1.Image = sourceImage;
        }

        void WarnMessage()
        {
            MessageBox.Show("You ain't opened an image yet!");
        }

        void SharpenFilter()
        {
            if(!isImageOpened)
            {
                WarnMessage();
            }
            else
            {
                Backup();
                Bitmap newImage = (Bitmap)pictureBox1.Image;
                Sharpen filtre = new Sharpen();
                pictureBox1.Image = filtre.Apply(newImage);
            }
        }

        void BlurFilter()
        {
            if(!isImageOpened)
            {
                WarnMessage();
            }
            else
            {
                Backup();
                Bitmap newImage = (Bitmap)pictureBox1.Image;
                Blur filtre = new Blur();
                pictureBox1.Image = filtre.Apply(newImage);
            }
        }

        void HistorgramEqual()
        {
            if(!isImageOpened)
            {
                WarnMessage();
            }
            else
            {
                Backup();
                Bitmap newImage = (Bitmap)ImageFile;
                HistogramEqualization filtre = new HistogramEqualization();
                pictureBox1.Image = filtre.Apply(newImage);
            }
        }

        void Delilation()
        {
            if (!isImageOpened)
            {
                WarnMessage();
            }
            else
            {
                Backup();
                Bitmap newImage = (Bitmap)pictureBox1.Image;
                Dilatation filtre = new Dilatation();
                pictureBox1.Image = filtre.Apply(newImage);
            }
        }

        void Erosion()
        {
            if (!isImageOpened)
            {
                WarnMessage();
            }
            else
            {
                Backup();
                Bitmap newImage = (Bitmap)pictureBox1.Image;
                Erosion filtre = new Erosion();
                pictureBox1.Image = filtre.Apply(newImage);
            }
        }

        void EdgeFilter()
        {
            if (!isImageOpened)
            {
                WarnMessage();
            }
            else
            {
                Backup();
                Bitmap newImage = (Bitmap)pictureBox1.Image;
                Edges filtre = new Edges();
                pictureBox1.Image = filtre.Apply(newImage);
            }
        }

        void ContrastInc()
        {
            if (!isImageOpened)
            {
                WarnMessage();
            }
            else
            {
                Bitmap newImage = (Bitmap)pictureBox1.Image;
                ContrastCorrection filtre = new ContrastCorrection();
                pictureBox1.Image = filtre.Apply(newImage);
            }
        }

        void ConvertBinary()
        {
            if(!isImageOpened)
            {
                WarnMessage();
            }
            else
            {
                Backup();
                Bitmap Image = (Bitmap)pictureBox1.Image;
                ImageData = Image.LockBits(new Rectangle(0, 0, Image.Width, Image.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
                buffer = new byte[3 * Image.Width * Image.Height];
                pointer = ImageData.Scan0;
                Marshal.Copy(pointer, buffer, 0, buffer.Length);
                for (int i = 0; i < Image.Height * 3 * Image.Width; i += 3)
                {
                    b = buffer[i];
                    g = buffer[i + 1];
                    r = buffer[i + 2];
                    grayscale = (byte)((r + g + b) / 3);
                    if (grayscale < 128)
                    {
                        buffer[i] = 0;
                        buffer[i + 1] = 0;
                        buffer[i + 2] = 0;
                    }
                    else
                    {
                        buffer[i] = 255;
                        buffer[i + 1] = 255;
                        buffer[i + 2] = 255;
                    }
                }

                Marshal.Copy(buffer, 0, pointer, buffer.Length);
                Image.UnlockBits(ImageData);
                pictureBox1.Image = Image;
            }
        }

        void HistogramGraph()
        {
            if(isImageOpened)
            {
                Backup();
                Image<Bgr, Byte> _inputImage;
                Image<Gray, Byte> R;
                Image<Gray, Byte> G;
                Image<Gray, Byte> B;

                string path = Path.GetFullPath(openFileDialog1.FileName);
                _inputImage = new Image<Bgr, Byte>(path);

                R = _inputImage[0];
                G = _inputImage[1];
                B = _inputImage[2];

                histogramBox1.ClearHistogram();
                histogramBox2.ClearHistogram();
                histogramBox3.ClearHistogram();

                histogramBox1.GenerateHistograms(R, 256);
                histogramBox2.GenerateHistograms(G, 256);
                histogramBox3.GenerateHistograms(B, 256);

                histogramBox1.Refresh();
                histogramBox2.Refresh();
                histogramBox3.Refresh();                
            }
        }
        void GrayFilter()
        {   
            if (!isImageOpened)
            {
                WarnMessage();
            }
            else
            {
                Backup();

                Bitmap newImage = (Bitmap)pictureBox1.Image;
                ImageAttributes ia = new ImageAttributes();     
                ColorMatrix cm = new ColorMatrix(new float[][]    
                {
                    new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0}
                });

                ia.SetColorMatrix(cm);
                Graphics g = Graphics.FromImage(newImage); 
                g.DrawImage(newImage, new Rectangle(0, 0, newImage.Width, newImage.Height), 0, 0, newImage.Width, newImage.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();                        
                pictureBox1.Image = newImage;
                grayClicked = true;
            }
        }

        public void ColorSettings()
        {
            if(!isImageOpened)
            {
                WarnMessage();
            }
            else
            {
                Backup();
                float redValue = RedBar.Value * 0.1f;
                float greenValue = GreenBar.Value * 0.1f;
                float blueValue = BlueBar.Value * 0.1f;
                float brightValue = BrightBar.Value * 0.05f;
                float ContrastValue = ContrastBar.Value * 0.1f;
                float grayValue1 = 0f;
                float grayValue2 = 0f;
                float grayValue3 = 0f;
                float staticNum = 1f;

                if(grayClicked)
                {
                    grayValue1 = 0.299f;
                    grayValue2 = 0.587f;
                    grayValue3 = 0.114f;
                    staticNum = 0f;
                    redValue = greenValue = blueValue = 0;
                }

                RefreshImage();

                Bitmap newImage = (Bitmap)ImageFile;

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cm = new ColorMatrix(new float[][]
                {
                    new float[]{ staticNum + redValue + grayValue1, 0 + grayValue1, 0 + grayValue1, 0, 0},
                    new float[]{0 + grayValue2, staticNum + greenValue + grayValue2, 0 + grayValue2, 0, 0},
                    new float[]{0 + grayValue3, 0 + grayValue3, staticNum + blueValue + grayValue3, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0+ brightValue + ContrastValue, 0+ brightValue + ContrastValue, 0+ brightValue + ContrastValue, 0, 0}
                });

                ia.SetColorMatrix(cm);
                Graphics g = Graphics.FromImage(newImage);
                g.DrawImage(newImage, new Rectangle(0, 0, newImage.Width, newImage.Height), 0, 0, newImage.Width, newImage.Height, GraphicsUnit.Pixel, ia);
                g.Dispose();
                ImageFile = newImage;
                pictureBox1.Image = ImageFile;
            }
        }

        private void RedBar_Scroll(object sender, EventArgs e)
        {
            ColorSettings();
        }

        private void GreenBar_Scroll(object sender, EventArgs e)
        {
            ColorSettings();
        }

        private void BlueBar_Scroll(object sender, EventArgs e)
        {
            ColorSettings();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            HistorgramEqual();
            HistogramGraph();
        }

        private void ContrastBar_Scroll(object sender, EventArgs e)
        {
            ColorSettings();
        }

        private void BrightBar_Scroll(object sender, EventArgs e)
        {
            ColorSettings();
        }

        private void OpenImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenImage();
        }

        private void SaveImageToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SaveImage();
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void UndoAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UndoAll();
        }

        private void ConvertGrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayFilter();
        }

        private void ContrastIncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContrastInc();
        }

        private void SharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SharpenFilter();
        }

        private void BlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlurFilter();
        }

        private void EdgesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EdgeFilter();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Delilation();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Erosion();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ConvertBinary();
        }
    }
}
 
