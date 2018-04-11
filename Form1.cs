using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_processing3
{
    public partial class Form1 : Form
    {
        private Bitmap f_image = null;
        public Bitmap image;
        int colorRed = 0;
        int colorGreen = 0;
        int colorBlue = 0;
        int colorWhite = 0;
        int colorBlack = 0;
        int colorYellow = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_red_TextChanged(object sender, EventArgs e)
        {
            colorRed = Int32.Parse(txt_red.Text);
        }

        private void txt_green_TextChanged(object sender, EventArgs e)
        {
            colorGreen = Int32.Parse(txt_green.Text);
        }

        private void txt_blue_TextChanged(object sender, EventArgs e)
        {
            colorBlue = Int32.Parse(txt_blue.Text);
        }

        private void txt_white_TextChanged(object sender, EventArgs e)
        {
            colorWhite = Int32.Parse(txt_white.Text);
        }

        private void txt_black_TextChanged(object sender, EventArgs e)
        {
            colorBlack = Int32.Parse(txt_black.Text);
        }

        private void txt_yellow_TextChanged(object sender, EventArgs e)
        {
            colorYellow = Int32.Parse(txt_yellow.Text);
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            {
                openFileDialog1.Filter = "bitmap (*.bmp)|*.bmp";
                openFileDialog1.FilterIndex = 1;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (f_image != null) f_image.Dispose();
                        f_image = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName, false);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Can not open file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                image = new Bitmap(f_image.Width, f_image.Height);
               
                for (int i = 0; i < f_image.Height; i++)
                {
                    for (int j = 0; j < f_image.Width; j++)
                    {
                        Color PixelColor = f_image.GetPixel(j, i);
                        int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;

                        image.SetPixel(j, i, System.Drawing.Color.FromArgb(C_gray, C_gray, C_gray));

                    }
                }
                pictureBox1.Image = f_image;

                double[] runningSum = new double[256];
                int[] countColor = new int[256];
                int pixel = f_image.Height * f_image.Width;
                int color = 255;
                for (int i = 0; i < f_image.Width; i++)
                {
                    for (int j = 0; j < f_image.Height; j++)
                    {
                        Color PixelColor = f_image.GetPixel(i, j);
                        int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                        countColor[C_gray]++;
                    }
                }
                
                runningSum[0] = countColor[0];
                for (int i = 1; i < 256; i++)
                {
                    runningSum[i] = runningSum[i - 1] + countColor[i];
                    
                }

                for (int i = 0; i < 256; i++)
                {
                    runningSum[i] = Math.Round(runningSum[i] / pixel * color);
                    
                }

                image = new Bitmap(f_image.Width, f_image.Height);
                for (int i = 0; i < f_image.Width; i++)
                {
                    for (int j = 0; j < f_image.Height; j++)
                    {
                        Color PixelColor = f_image.GetPixel(i, j);
                        int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                        int NewColor = (int)runningSum[C_gray];
                        image.SetPixel(i, j, System.Drawing.Color.FromArgb(NewColor, NewColor, NewColor));
                    }
                }
                pictureBox2.Image = image;

                int[] arrGray = new int[256];

                for (int i = 0; i < f_image.Width; i++)
                {
                    for (int j = 0; j < f_image.Height; j++)
                    {
                        Color PixelColor = f_image.GetPixel(i, j);
                        arrGray[PixelColor.R]++;
                    }
                }


                for (int i = 1; i < arrGray.Length; i++)
                {
                    this.Histogram.Series["Color"].Points.AddXY(i, arrGray[i]);

                }
            }
        }

        private void btn_Intensity_Slicing_Click(object sender, EventArgs e)
        {

            int color_1 = Convert.ToInt32(txt_red.Text);
            int color_2 = Convert.ToInt32(txt_green.Text);
            int color_3 = Convert.ToInt32(txt_blue.Text);
            int color_4 = Convert.ToInt32(txt_white.Text);
            int color_5 = Convert.ToInt32(txt_black.Text);
            int color_6 = Convert.ToInt32(txt_yellow.Text);

            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    Color PixelColor = f_image.GetPixel(i, j);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;

                    if (C_gray >= color_6)
                    {
                        image.SetPixel(i, j, System.Drawing.Color.FromArgb(218, 112, 214));
                    }
                    else if (C_gray >= color_5)
                    {
                        image.SetPixel(i, j, System.Drawing.Color.FromArgb(0, 192, 192));
                    }
                    else if (C_gray >= color_4)
                    {
                        image.SetPixel(i, j, System.Drawing.Color.FromArgb(255, 255, 0));
                    }
                    else if (C_gray >= color_3)
                    {
                        image.SetPixel(i, j, System.Drawing.Color.FromArgb(0, 0, 255));
                    }
                    else if (C_gray >= color_2)
                    {
                        image.SetPixel(i, j, System.Drawing.Color.FromArgb(0, 255, 0));
                    }
                    else
                    {
                        image.SetPixel(i, j, System.Drawing.Color.FromArgb(255, 0, 0));
                    }
                }
            }
            pictureBox2.Image = image;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
