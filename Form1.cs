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
                        
                        image.SetPixel(j, i, Color.FromArgb(C_gray, C_gray, C_gray));

                    }
                }
                pictureBox1.Image = f_image;
                pictureBox2.Image = image;
            }
        }

        int freRed = 0;
        int freWhite = 0;
        int freGreen = 0;
        int freBlue = 0;
        int freBlack = 0;
        int freYellow = 0;

        private void match_color(int color, int i, int j)
        {
            if (color == colorRed)
            {
                image.SetPixel(j, i, Color.FromArgb(255, 0, 0));
                freRed++;
            }
            else if (color == colorWhite)
            {
                image.SetPixel(j, i, Color.FromArgb(255, 255, 255));
                freWhite++;
            }
            else if (color == colorGreen)
            {
                image.SetPixel(j, i, Color.FromArgb(0, 255, 0));
                freGreen++;
            }
            else if (color == colorBlue)
            {
                image.SetPixel(j, i, Color.FromArgb(0, 0, 255));
                freBlue++;
            }
            else if (color == colorBlack)
            {
                image.SetPixel(j, i, Color.FromArgb(0, 0, 0));
                freBlack++;
            }
            else
            {
                image.SetPixel(j, i, Color.FromArgb(255, 255, 0));
                freYellow++;
            }
        }
        private void btn_Intensity_Slicing_Click(object sender, EventArgs e)
        {
            int[] color = new int[6];
            color[0] = colorRed;
            color[1] = colorWhite;
            color[2] = colorGreen;
            color[3] = colorBlue;
            color[4] = colorBlack;
            color[5] = colorYellow;
            freRed = 0;
            freWhite = 0;
            freGreen = 0;
            freBlue = 0;
            freBlack = 0;
            freYellow = 0;
            Array.Sort(color);
            //txtLevelWhite.Text = Convert.ToString(colorRed);
            for (int i = 0; i < f_image.Height; i++)
            {
                for (int j = 0; j < f_image.Width; j++)
                {
                    Color PixelColor = f_image.GetPixel(j, i);
                    int C_gray = (int)(PixelColor.R + PixelColor.G + PixelColor.B) / 3;
                    if (C_gray > color[0])
                    {
                        if (C_gray > color[1])
                        {
                            if (C_gray > color[2])
                            {
                                if (C_gray > color[3])
                                {
                                    if (C_gray > color[4])
                                    {
                                        match_color(color[5], i, j);
                                    }                                   
                                    else
                                    {
                                        match_color(color[4], i, j);
                                    }
                                }
                                else
                                {
                                    match_color(color[3], i, j);
                                }
                            }
                            else
                            {
                                match_color(color[2], i, j);
                            }
                        }
                        else
                        {
                            match_color(color[1], i, j);
                        }
                    }
                    else
                    {
                        match_color(color[0], i, j);
                    }
                    
                }
            }
            pictureBox2.Image = image;
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            this.chart1.Series["Color"].Points.AddXY("Red", freRed);
            this.chart1.Series["Color"].Points.AddXY("White", freWhite);
            this.chart1.Series["Color"].Points.AddXY("Green", freGreen);
            this.chart1.Series["Color"].Points.AddXY("Blue", freBlue);
            this.chart1.Series["Color"].Points.AddXY("Black", freBlue);
            this.chart1.Series["Color"].Points.AddXY("Yellow", freBlue);

        }

      
    }
}
