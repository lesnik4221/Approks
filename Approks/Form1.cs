﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Approximation
{
    public partial class MainForm : Form
    {
        private float a, b, x_max;
        private float summa, summx, summy, summx2;

        private List<float> x;
        private List<float> y;
        private List<float> x2;
        private List<float> y2;


        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            x = new List<float>();
            y = new List<float>();
            x2 = new List<float>();
            y2 = new List<float>();

            summa = 0;
            summx = 0;
            summy = 0;
            summx2 = 0;
            a = 0;
            b = 0;
            x_max = float.MinValue;
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            x_max = float.MinValue;
            summa = 0;
            summx = 0;
            summy = 0;
            summx2 = 0;
            a = 0;
            b = 0;
            x.Clear();
            y.Clear();
            x2.Clear();
            y2.Clear();

            data_in.Columns.Clear();
            data_in.ColumnCount = 2;
            data_in.Columns[0].Name = "X";
            data_in.Columns[1].Name = "Y";

            plot.Series[0].Points.DataBindXY(x, y);
            plot.Series[1].Points.DataBindXY(x2, y2);
            plot.Series[1].Name = "y = ax + b";
        }

        private void approximate_button_Click(object sender, EventArgs e)
        {
            x.Clear();
            y.Clear();
            x2.Clear();
            y2.Clear();
            for (int i = 0; i < data_in.RowCount - 1; i++)
            {
                x.Add((float)Convert.ToDouble(data_in.Rows[i].Cells[0].Value));
                y.Add((float)Convert.ToDouble(data_in.Rows[i].Cells[1].Value));

                if ((float)Convert.ToDouble(data_in.Rows[i].Cells[0].Value) > x_max)
                {
                    x_max = (float)Convert.ToDouble(data_in.Rows[i].Cells[0].Value);
                }
            }
            Approximating();

            x2.Add(0);
            x2.Add((float)(x_max * 1.04));
            y2.Add(b);
            y2.Add(a * x2[1] + b);

            plot.Series[0].Points.DataBindXY(x, y);
            plot.Series[1].Points.DataBindXY(x2, y2);
            if (b < 0)
            {
                plot.Series[1].Name = "y = " + a + "x " + b;
            }
            else
            {
                plot.Series[1].Name = "y = " + a + "x + " + b;
            }
        }

        private void Approximating()
        {
            summa = 0;
            summx = 0;
            summy = 0;
            summx2 = 0;
            a = 0;
            b = 0;
            for (int i = 0; i < x.Count; i++)
            {
                summa += x[i] * y[i];
                summx += x[i];
                summy += y[i];
                summx2 += x[i] * x[i];
            }
            a = (x.Count * summa - summx * summy) / (x.Count * summx2 - summx * summx);
            b = (summy - a * summx) / x.Count;
        }
    }
}
