
namespace Wyrownanie_histogramu
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.button_wyrownianie = new System.Windows.Forms.Button();
            this.chart_zdj1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_wynik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_2_1 = new System.Windows.Forms.TextBox();
            this.textBox_2_2 = new System.Windows.Forms.TextBox();
            this.textBox_2_0 = new System.Windows.Forms.TextBox();
            this.textBox_1_1 = new System.Windows.Forms.TextBox();
            this.textBox_1_2 = new System.Windows.Forms.TextBox();
            this.textBox_1_0 = new System.Windows.Forms.TextBox();
            this.textBox_0_1 = new System.Windows.Forms.TextBox();
            this.textBox_0_2 = new System.Windows.Forms.TextBox();
            this.textBox_0_0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox_maska = new System.Windows.Forms.PictureBox();
            this.pictureBox_zdj1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart_zdj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_wynik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maska)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zdj1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Wyrownywanie histogramu";
            // 
            // button_wyrownianie
            // 
            this.button_wyrownianie.Location = new System.Drawing.Point(12, 317);
            this.button_wyrownianie.Name = "button_wyrownianie";
            this.button_wyrownianie.Size = new System.Drawing.Size(131, 23);
            this.button_wyrownianie.TabIndex = 5;
            this.button_wyrownianie.Text = "Wyrównianie histogramu";
            this.button_wyrownianie.UseVisualStyleBackColor = true;
            this.button_wyrownianie.Click += new System.EventHandler(this.button_wyrownianie_Click);
            // 
            // chart_zdj1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_zdj1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_zdj1.Legends.Add(legend3);
            this.chart_zdj1.Location = new System.Drawing.Point(163, 346);
            this.chart_zdj1.Name = "chart_zdj1";
            series7.BorderColor = System.Drawing.Color.Red;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Red;
            series7.Legend = "Legend1";
            series7.Name = "red";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Green;
            series8.Legend = "Legend1";
            series8.MarkerColor = System.Drawing.Color.Red;
            series8.Name = "green";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Blue;
            series9.Legend = "Legend1";
            series9.Name = "blue";
            this.chart_zdj1.Series.Add(series7);
            this.chart_zdj1.Series.Add(series8);
            this.chart_zdj1.Series.Add(series9);
            this.chart_zdj1.Size = new System.Drawing.Size(320, 103);
            this.chart_zdj1.TabIndex = 3;
            this.chart_zdj1.Text = "chart1";
            this.chart_zdj1.Click += new System.EventHandler(this.chart_zdj1_Click);
            // 
            // chart_wynik
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_wynik.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_wynik.Legends.Add(legend4);
            this.chart_wynik.Location = new System.Drawing.Point(163, 455);
            this.chart_wynik.Name = "chart_wynik";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.Name = "red";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.Green;
            series11.Legend = "Legend1";
            series11.Name = "green";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.Blue;
            series12.Legend = "Legend1";
            series12.Name = "blue";
            this.chart_wynik.Series.Add(series10);
            this.chart_wynik.Series.Add(series11);
            this.chart_wynik.Series.Add(series12);
            this.chart_wynik.Size = new System.Drawing.Size(318, 103);
            this.chart_wynik.TabIndex = 6;
            this.chart_wynik.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Histogram podstawowy zdjecia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wynik wyrownywania";
            // 
            // textBox_2_1
            // 
            this.textBox_2_1.Location = new System.Drawing.Point(726, 338);
            this.textBox_2_1.Name = "textBox_2_1";
            this.textBox_2_1.Size = new System.Drawing.Size(24, 20);
            this.textBox_2_1.TabIndex = 17;
            // 
            // textBox_2_2
            // 
            this.textBox_2_2.Location = new System.Drawing.Point(756, 338);
            this.textBox_2_2.Name = "textBox_2_2";
            this.textBox_2_2.Size = new System.Drawing.Size(24, 20);
            this.textBox_2_2.TabIndex = 16;
            // 
            // textBox_2_0
            // 
            this.textBox_2_0.Location = new System.Drawing.Point(696, 338);
            this.textBox_2_0.Name = "textBox_2_0";
            this.textBox_2_0.Size = new System.Drawing.Size(24, 20);
            this.textBox_2_0.TabIndex = 15;
            // 
            // textBox_1_1
            // 
            this.textBox_1_1.Location = new System.Drawing.Point(726, 312);
            this.textBox_1_1.Name = "textBox_1_1";
            this.textBox_1_1.Size = new System.Drawing.Size(24, 20);
            this.textBox_1_1.TabIndex = 20;
            // 
            // textBox_1_2
            // 
            this.textBox_1_2.Location = new System.Drawing.Point(756, 312);
            this.textBox_1_2.Name = "textBox_1_2";
            this.textBox_1_2.Size = new System.Drawing.Size(24, 20);
            this.textBox_1_2.TabIndex = 19;
            // 
            // textBox_1_0
            // 
            this.textBox_1_0.Location = new System.Drawing.Point(696, 312);
            this.textBox_1_0.Name = "textBox_1_0";
            this.textBox_1_0.Size = new System.Drawing.Size(24, 20);
            this.textBox_1_0.TabIndex = 18;
            // 
            // textBox_0_1
            // 
            this.textBox_0_1.Location = new System.Drawing.Point(726, 286);
            this.textBox_0_1.Name = "textBox_0_1";
            this.textBox_0_1.Size = new System.Drawing.Size(24, 20);
            this.textBox_0_1.TabIndex = 23;
            // 
            // textBox_0_2
            // 
            this.textBox_0_2.Location = new System.Drawing.Point(756, 286);
            this.textBox_0_2.Name = "textBox_0_2";
            this.textBox_0_2.Size = new System.Drawing.Size(24, 20);
            this.textBox_0_2.TabIndex = 22;
            // 
            // textBox_0_0
            // 
            this.textBox_0_0.Location = new System.Drawing.Point(696, 286);
            this.textBox_0_0.Name = "textBox_0_0";
            this.textBox_0_0.Size = new System.Drawing.Size(24, 20);
            this.textBox_0_0.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Maska:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Filtruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Filtruj_click);
            // 
            // pictureBox_maska
            // 
            this.pictureBox_maska.Image = global::Wyrownanie_histogramu.Properties.Resources.keydrop;
            this.pictureBox_maska.Location = new System.Drawing.Point(651, 12);
            this.pictureBox_maska.Name = "pictureBox_maska";
            this.pictureBox_maska.Size = new System.Drawing.Size(205, 258);
            this.pictureBox_maska.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_maska.TabIndex = 1;
            this.pictureBox_maska.TabStop = false;
            // 
            // pictureBox_zdj1
            // 
            this.pictureBox_zdj1.Image = global::Wyrownanie_histogramu.Properties.Resources.keydrop;
            this.pictureBox_zdj1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_zdj1.Name = "pictureBox_zdj1";
            this.pictureBox_zdj1.Size = new System.Drawing.Size(207, 259);
            this.pictureBox_zdj1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_zdj1.TabIndex = 0;
            this.pictureBox_zdj1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 921);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_0_1);
            this.Controls.Add(this.textBox_0_2);
            this.Controls.Add(this.textBox_0_0);
            this.Controls.Add(this.textBox_1_1);
            this.Controls.Add(this.textBox_1_2);
            this.Controls.Add(this.textBox_1_0);
            this.Controls.Add(this.textBox_2_1);
            this.Controls.Add(this.textBox_2_2);
            this.Controls.Add(this.textBox_2_0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart_wynik);
            this.Controls.Add(this.chart_zdj1);
            this.Controls.Add(this.button_wyrownianie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_maska);
            this.Controls.Add(this.pictureBox_zdj1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_zdj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_wynik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maska)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_zdj1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_zdj1;
        private System.Windows.Forms.PictureBox pictureBox_maska;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_wyrownianie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_zdj1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_wynik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_2_1;
        private System.Windows.Forms.TextBox textBox_2_2;
        private System.Windows.Forms.TextBox textBox_2_0;
        private System.Windows.Forms.TextBox textBox_1_1;
        private System.Windows.Forms.TextBox textBox_1_2;
        private System.Windows.Forms.TextBox textBox_1_0;
        private System.Windows.Forms.TextBox textBox_0_1;
        private System.Windows.Forms.TextBox textBox_0_2;
        private System.Windows.Forms.TextBox textBox_0_0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

