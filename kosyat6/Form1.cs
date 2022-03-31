using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kosyat6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Da(int x, int y)
        {
            return x * x + y * y; 
        }

        public float Rast(float x1, float y1, float x2, float y2)
        {
            return (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public float Geron(float a, float b, float c)
        {
            float p = (a + b + c) / 2;
            return (float)Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float x1, x2, x3, x4;
            float y1, y2, y3, y4;
            x1 = Convert.ToSingle(xx1.Text);
            y1 = Convert.ToSingle(yy1.Text);
            x2 = Convert.ToSingle(xx2.Text);
            y2 = Convert.ToSingle(yy2.Text);
            x3 = Convert.ToSingle(xx3.Text);
            y3 = Convert.ToSingle(yy3.Text);
            x4 = Convert.ToSingle(xx4.Text);
            y4 = Convert.ToSingle(yy4.Text);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, d;
            a = Convert.ToInt32(vvod1.Text);
            b = Convert.ToInt32(vvod2.Text);
            c = Convert.ToInt32(vvod3.Text);
            d = Convert.ToInt32(vvod4.Text);

            if (Da(a, b) > Da(c, d))
                vivod1.Text = "Пара A, B дала больший ответ";
            else
                vivod1.Text = "Пара C, D дала больший ответ";
        }
    }
}
