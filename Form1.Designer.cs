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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_Intensity_Slicing = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_green = new System.Windows.Forms.TextBox();
            this.txt_blue = new System.Windows.Forms.TextBox();
            this.txt_white = new System.Windows.Forms.TextBox();
            this.txt_black = new System.Windows.Forms.TextBox();
            this.txt_yellow = new System.Windows.Forms.TextBox();
            this.txt_red = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(67, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Red";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Blue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "White";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Black";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Yellow";
            // 
            // txt_green
            // 
            this.txt_green.Location = new System.Drawing.Point(118, 316);
            this.txt_green.Name = "txt_green";
            this.txt_green.Size = new System.Drawing.Size(100, 20);
            this.txt_green.TabIndex = 5;
            this.txt_green.TextChanged += new System.EventHandler(this.txt_green_TextChanged);
            // 
            // txt_blue
            // 
            this.txt_blue.Location = new System.Drawing.Point(118, 340);
            this.txt_blue.Name = "txt_blue";
            this.txt_blue.Size = new System.Drawing.Size(100, 20);
            this.txt_blue.TabIndex = 5;
            this.txt_blue.TextChanged += new System.EventHandler(this.txt_blue_TextChanged);
            // 
            // txt_white
            // 
            this.txt_white.Location = new System.Drawing.Point(284, 292);
            this.txt_white.Name = "txt_white";
            this.txt_white.Size = new System.Drawing.Size(100, 20);
            this.txt_white.TabIndex = 5;
            this.txt_white.TextChanged += new System.EventHandler(this.txt_white_TextChanged);
            // 
            // txt_black
            // 
            this.txt_black.Location = new System.Drawing.Point(284, 316);
            this.txt_black.Name = "txt_black";
            this.txt_black.Size = new System.Drawing.Size(100, 20);
            this.txt_black.TabIndex = 5;
            this.txt_black.TextChanged += new System.EventHandler(this.txt_black_TextChanged);
            // 
            // txt_yellow
            // 
            this.txt_yellow.Location = new System.Drawing.Point(284, 340);
            this.txt_yellow.Name = "txt_yellow";
            this.txt_yellow.Size = new System.Drawing.Size(100, 20);
            this.txt_yellow.TabIndex = 5;
            this.txt_yellow.TextChanged += new System.EventHandler(this.txt_yellow_TextChanged);
            // 
            // txt_red
            // 
            this.txt_red.Location = new System.Drawing.Point(118, 294);
            this.txt_red.Name = "txt_red";
            this.txt_red.Size = new System.Drawing.Size(100, 20);
            this.txt_red.TabIndex = 5;
            this.txt_red.TextChanged += new System.EventHandler(this.txt_red_TextChanged);
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(406, 275);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(304, 186);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 510);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.txt_yellow);
            this.Controls.Add(this.txt_black);
            this.Controls.Add(this.txt_white);
            this.Controls.Add(this.txt_blue);
            this.Controls.Add(this.txt_red);
            this.Controls.Add(this.txt_green);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Intensity_Slicing);
            this.Controls.Add(this.btn_Open);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Intensity_Slicing;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_green;
        private System.Windows.Forms.TextBox txt_blue;
        private System.Windows.Forms.TextBox txt_white;
        private System.Windows.Forms.TextBox txt_black;
        private System.Windows.Forms.TextBox txt_yellow;
        private System.Windows.Forms.TextBox txt_red;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

