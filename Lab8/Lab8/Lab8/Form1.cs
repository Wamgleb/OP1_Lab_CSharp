using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        int i;
        double l, a;
        const
            int d0 = 283,
            x0 = 200,
            y0 = 200;

        private void button1_Click(object sender, EventArgs e)
        {
            l = d0;
            a = 0;
            for (i = 1; i <= 50; i++)
            {
                DrawSquare(l, a);
                a = a + Math.PI / 19;
                l = l * Math.Sin(Math.PI / 3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        void DrawSquare(double c, double b)
        {
            int x1, x2, x3, x4, y1, y2, y3, y4;

            Pen myPen = new Pen(Color.Black, 1);

            Graphics g = pictureBox1.CreateGraphics();
            x1 = (int)(x0 + c * Math.Cos(b + 1 * Math.PI / 4));//Координаты правой нижней
            y1 = (int)(y0 + c * Math.Sin(b + 1 * Math.PI / 4));//точки
            x2 = (int)(x0 + c * Math.Cos(b + 3 * Math.PI / 4)); //Координаты левой нижней 
            y2 = (int)(y0 + c * Math.Sin(b + 3 * Math.PI / 4)); //точки
            x3 = (int)(x0 + c * Math.Cos(b + 5 * Math.PI / 4)); //Координаты левой верхней
            y3 = (int)(y0 + c * Math.Sin(b + 5 * Math.PI / 4)); //точки 
            x4 = (int)(x0 + c * Math.Cos(b + 7 * Math.PI / 4));//Координаты правой верхней
            y4 = (int)(y0 + c * Math.Sin(b + 7 * Math.PI / 4)); //точки
            

            g.DrawPolygon(myPen, new Point[]
            {
                new Point(x1,y1), new Point(x2,y2),
                new Point(x3,y3), new Point(x4,y4),
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
