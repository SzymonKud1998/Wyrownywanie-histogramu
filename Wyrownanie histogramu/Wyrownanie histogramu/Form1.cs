using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyrownanie_histogramu
{
    public partial class Form1 : Form
    {
        private int[] red = null;
        private int[] green = null;
        private int[] blue = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap b1 = (Bitmap)pictureBox_zdj1.Image;
            int r, g, b;
            red = new int[256];
            green = new int[256];
            blue = new int[256];
            for (int x = 0; x < pictureBox_zdj1.Image.Width; x++)
            {
                for (int y = 0; y < pictureBox_zdj1.Image.Height; y++)
                {
                    Color zdj_1 = b1.GetPixel(x, y);
                    r = zdj_1.R;
                    g = zdj_1.G;
                    b = zdj_1.B;
                    red[r]++;
                    green[g]++;
                    blue[b]++;
                }
            }
            //generowanie histogramu dla domyslnego zdj 1
            chart_zdj1.Series["red"].Points.Clear();
            chart_zdj1.Series["green"].Points.Clear();
            chart_zdj1.Series["blue"].Points.Clear();
            for (int i = 0; i < 256; i++)
            {
                chart_zdj1.Series["red"].Points.AddXY(i, red[i]);
                chart_zdj1.Series["green"].Points.AddXY(i, green[i]);
                chart_zdj1.Series["blue"].Points.AddXY(i, blue[i]);
            }
            chart_zdj1.Invalidate();
        }

        private void button_wyrownianie_Click(object sender, EventArgs e)
        {
                Bitmap b1 = (Bitmap)pictureBox_zdj1.Image;
                
                int r, g, b;
                
                int[] LUTred = calculateLUT(red, pictureBox_zdj1.Image.Width * pictureBox_zdj1.Image.Height) ;
                int[] LUTgreen = calculateLUT(green, pictureBox_zdj1.Image.Width * pictureBox_zdj1.Image.Height);
                int[] LUTblue = calculateLUT(blue, pictureBox_zdj1.Image.Width * pictureBox_zdj1.Image.Height);

                //Przetworz obraz i oblicz nowy histogram
                red = new int[256];
                green = new int[256];
                blue = new int[256];

                for (int x = 0; x < pictureBox_zdj1.Image.Width; x++)
                {
                    for (int y = 0; y < pictureBox_zdj1.Image.Height; y++)
                    {
                    Color k = b1.GetPixel(x, y);
             
                        r = k.R;
                        g = k.G;
                        b = k.B;

                        b1.SetPixel(x, y, Color.FromArgb(LUTred[r], LUTgreen[g], LUTblue[b]));
                        red[r]++;
                        green[g]++;
                        blue[b]++;
                    }
                }
                pictureBox_zdj1.Refresh();
                
                //Wyswietl histogram na wykresie
                chart_wynik.Series["red"].Points.Clear();
                chart_wynik.Series["green"].Points.Clear();
                chart_wynik.Series["blue"].Points.Clear();
                for (int i = 0; i < 256; i++)
                {
                    chart_wynik.Series["red"].Points.AddXY(i, LUTred[i]);
                    chart_wynik.Series["green"].Points.AddXY(i, LUTgreen[i]);
                    chart_wynik.Series["blue"].Points.AddXY(i, LUTblue[i]);
                }
                chart_zdj1.Invalidate();
            
        }
        private int[] calculateLUT(int[] values, int size)
        {
            //poszukaj wartości minimalnej - czyli pierwszej niezerowej wartosci dystrybuanty
            double minValue = 0;
            for (int i = 0; i < 256; i++)
            {
                if (values[i] != 0)
                {
                    minValue = values[i];
                    break;
                }
            }

            //przygotuj tablice zgodnie ze wzorem
            int[] result = new int[256];
            double sum = 0;
            for (int i = 0; i < 256; i++)
            {
                sum += values[i];
                result[i] = (int)(((sum - minValue) / (size - minValue)) * 255.0);
            }

            return result;
        }

        private void chart_zdj1_Click(object sender, EventArgs e)
        {

        }

        private void Filtruj_click(object sender, EventArgs e)
        {
            //inicjalizacja bitmapy oraz rozmiarow zdj
            Bitmap bitmapa_2 = (Bitmap)pictureBox_maska.Image;
            int zdj_wys = pictureBox_maska.Image.Height;
            int zdj_szer = pictureBox_maska.Image.Width;
            Color[,] k = new Color[3, 3];
            int r = 0, g = 0, b = 0;
            int suma_maski = 0;
            int[,] maska = new int[3, 3];
            //Macierz textboxow do pobrania maski od uzytkownika
            maska[0, 0] = Convert.ToInt32(textBox_0_0.Text);
            maska[0, 1] = Convert.ToInt32(textBox_0_1.Text);
            maska[0, 2] = Convert.ToInt32(textBox_0_2.Text);
            maska[1, 0] = Convert.ToInt32(textBox_1_0.Text);
            maska[1, 1] = Convert.ToInt32(textBox_1_1.Text);
            maska[1, 2] = Convert.ToInt32(textBox_1_2.Text);
            maska[2, 0] = Convert.ToInt32(textBox_2_0.Text);
            maska[2, 1] = Convert.ToInt32(textBox_2_1.Text);
            maska[2, 2] = Convert.ToInt32(textBox_2_2.Text);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    suma_maski += maska[i, j];
                }
            }

            for (int x = 0; x < zdj_szer; x++)
            {
                if (x == 0 || x == zdj_szer - 1)
                {
                    continue;
                }
                for (int y = 0; y < zdj_wys; y++)
                {
                    if (y == 0 || y == zdj_wys - 1)
                    {
                        continue;
                    }
                    for (int i = -1; i < 2; i++)
                    {

                        for (int j = -1; j < 2; j++)
                        {

                            k[i + 1, j + 1] = bitmapa_2.GetPixel(x + i, y + j);

                            r += (k[i + 1, j + 1].R * maska[i + 1, j + 1]);
                            g += (k[i + 1, j + 1].G * maska[i + 1, j + 1]);
                            b += (k[i + 1, j + 1].B * maska[i + 1, j + 1]);
                        }
                    }
                    if (suma_maski != 0)
                    {
                        r = r / suma_maski;
                        g = g / suma_maski;
                        b = b / suma_maski;

                    }

                    if (r > 255)
                    {
                        r = 255;
                    }
                    else if (r < 0)
                    {
                        r = 0;
                    }


                    if (g > 255)
                    {
                        g = 255;
                    }
                    else if (g < 0)
                    {
                        g = 0;
                    }


                    if (b > 255)
                    {
                        b = 255;
                    }
                    else if (b < 0)
                    {
                        b = 0;
                    }
                    bitmapa_2.SetPixel(x, y, Color.FromArgb(r, g, b));

                }
            }
            pictureBox_maska.Refresh();
        }
    }
}
