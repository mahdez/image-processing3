namespace image_processing3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Intensity_Slicing = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_green = new System.Windows.Forms.TextBox();
            this.txt_blue = new System.Windows.Forms.TextBox();
            this.txt_white = new System.Windows.Forms.TextBox();
            this.txt_black = new System.Windows.Forms.TextBox();
            this.txt_yellow = new System.Windows.Forms.TextBox();
            this.txt_red = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.Histogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histogram)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(619, 40);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 23);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_Intensity_Slicing
            // 
            this.btn_Intensity_Slicing.Location = new System.Drawing.Point(619, 69);
            this.btn_Intensity_Slicing.Name = "btn_Intensity_Slicing";
            this.btn_Intensity_Slicing.Size = new System.Drawing.Size(91, 23);
            this.btn_Intensity_Slicing.TabIndex = 1;
            this.btn_Intensity_Slicing.Text = "Intensity Slicing";
            this.btn_Intensity_Slicing.UseVisualStyleBackColor = true;
            this.btn_Intensity_Slicing.Click += new System.EventHandler(this.btn_Intensity_Slicing_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 240);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(315, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(284, 240);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color";
            // 
            // txt_green
            // 
            this.txt_green.Location = new System.Drawing.Point(57, 320);
            this.txt_green.Name = "txt_green";
            this.txt_green.Size = new System.Drawing.Size(100, 20);
            this.txt_green.TabIndex = 5;
            this.txt_green.TextChanged += new System.EventHandler(this.txt_green_TextChanged);
            // 
            // txt_blue
            // 
            this.txt_blue.Location = new System.Drawing.Point(57, 344);
            this.txt_blue.Name = "txt_blue";
            this.txt_blue.Size = new System.Drawing.Size(100, 20);
            this.txt_blue.TabIndex = 5;
            this.txt_blue.TextChanged += new System.EventHandler(this.txt_blue_TextChanged);
            // 
            // txt_white
            // 
            this.txt_white.Location = new System.Drawing.Point(223, 296);
            this.txt_white.Name = "txt_white";
            this.txt_white.Size = new System.Drawing.Size(100, 20);
            this.txt_white.TabIndex = 5;
            this.txt_white.TextChanged += new System.EventHandler(this.txt_white_TextChanged);
            // 
            // txt_black
            // 
            this.txt_black.Location = new System.Drawing.Point(223, 320);
            this.txt_black.Name = "txt_black";
            this.txt_black.Size = new System.Drawing.Size(100, 20);
            this.txt_black.TabIndex = 5;
            this.txt_black.TextChanged += new System.EventHandler(this.txt_black_TextChanged);
            // 
            // txt_yellow
            // 
            this.txt_yellow.Location = new System.Drawing.Point(223, 344);
            this.txt_yellow.Name = "txt_yellow";
            this.txt_yellow.Size = new System.Drawing.Size(100, 20);
            this.txt_yellow.TabIndex = 5;
            this.txt_yellow.TextChanged += new System.EventHandler(this.txt_yellow_TextChanged);
            // 
            // txt_red
            // 
            this.txt_red.Location = new System.Drawing.Point(57, 298);
            this.txt_red.Name = "txt_red";
            this.txt_red.Size = new System.Drawing.Size(100, 20);
            this.txt_red.TabIndex = 5;
            this.txt_red.TextChanged += new System.EventHandler(this.txt_red_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Red;
            this.pictureBox3.Location = new System.Drawing.Point(23, 296);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 19);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox4.Location = new System.Drawing.Point(23, 320);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 19);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Blue;
            this.pictureBox5.Location = new System.Drawing.Point(23, 344);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(28, 19);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.Location = new System.Drawing.Point(189, 297);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 19);
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Black;
            this.pictureBox7.Location = new System.Drawing.Point(189, 320);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(28, 19);
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox8.Location = new System.Drawing.Point(189, 344);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(28, 19);
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // Histogram
            // 
            this.Histogram.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.Histogram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Histogram.Legends.Add(legend1);
            this.Histogram.Location = new System.Drawing.Point(366, 296);
            this.Histogram.Name = "Histogram";
            this.Histogram.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Color";
            series1.ShadowColor = System.Drawing.Color.Red;
            this.Histogram.Series.Add(series1);
            this.Histogram.Size = new System.Drawing.Size(328, 152);
            this.Histogram.TabIndex = 20;
            this.Histogram.Text = "Histogram";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 510);
            this.Controls.Add(this.Histogram);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt_yellow);
            this.Controls.Add(this.txt_black);
            this.Controls.Add(this.txt_white);
            this.Controls.Add(this.txt_blue);
            this.Controls.Add(this.txt_red);
            this.Controls.Add(this.txt_green);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Intensity_Slicing);
            this.Controls.Add(this.btn_Open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Histogram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Intensity_Slicing;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_green;
        private System.Windows.Forms.TextBox txt_blue;
        private System.Windows.Forms.TextBox txt_white;
        private System.Windows.Forms.TextBox txt_black;
        private System.Windows.Forms.TextBox txt_yellow;
        private System.Windows.Forms.TextBox txt_red;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.DataVisualization.Charting.Chart Histogram;
    }
}

