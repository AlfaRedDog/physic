using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phys_lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // считывание пользовательских данных
            double 
            y0 = Convert.ToDouble(textBox1.Text),
            x0 = Convert.ToDouble(textBox3.Text),
            Wx = Convert.ToDouble(textBox2.Text),
            Wy = Convert.ToDouble(textBox4.Text),
            q  = Convert.ToDouble(textBox5.Text);
            //очистка поля от прошлого графика
            this.chart1.Series[0].Points.Clear();
            double t = 0, h = 0.01, x , y;
            //цикл посторения графика по точкам, срабатывает 10000 раз
            while(t <= 100)
            {
                // рассчет положения новой точки
                x = x0 * Math.Cos(Wx * t);
                y = y0 * Math.Cos(Wy * t + q);
                this.chart1.Series[0].Points.AddXY(x, y);
                t += h;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
