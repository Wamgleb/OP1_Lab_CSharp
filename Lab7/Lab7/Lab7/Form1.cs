using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Обьявляем обект "полотно"
            Graphics g = pictureBox1.CreateGraphics();
            
            // Г
            // Создаем обект ручка
            Pen pen1 = new Pen(Color.Red);
            pen1.Width = 9.5F;
            // Рисуем линию по заданым координатам, верхняя координата (х) левая (у)           
            g.DrawLine(pen1, 10, 4, 10, 100);
            g.DrawLine(pen1, 10, 8, 50, 8);

            // Л
            Pen pen2 = new Pen(Color.Green);
            pen2.Width = 9.5F;
            
            g.DrawLine(pen2, 73, 6, 55, 98);
            g.DrawLine(pen2, 73, 6, 90, 98);


            // І
            Pen pen3 = new Pen(Color.Blue);
            pen3.Width = 9.5F;
          
            g.DrawLine(pen3, 110, 6, 110, 100);

            // Б
            Pen pen4 = new Pen(Color.Cyan);
            pen4.Width = 9.5F;
            
            g.DrawLine(pen4, 135, 6, 135, 100);
            g.DrawLine(pen4, 135, 95, 185, 95);
            g.DrawLine(pen4, 180, 95, 180, 50);
            g.DrawLine(pen4, 185, 50, 132, 50);
            g.DrawLine(pen4, 135, 9, 180, 9);

            // К
            Pen pen5 = new Pen(Color.Magenta);
            pen5.Width = 9.5F;

            g.DrawLine(pen5, 10, 120, 10, 220);
            g.DrawLine(pen5, 10, 160, 55, 125);
            g.DrawLine(pen5, 10, 160, 55, 215);

            // А
            Pen pen6 = new Pen(Color.DarkBlue);
            pen6.Width = 9.5F;

            g.DrawLine(pen6, 75, 220, 95, 120);
            g.DrawLine(pen6, 120, 220, 95, 120);
            g.DrawLine(pen6, 80, 175, 110, 175);

            // Л
            Pen pen7 = new Pen(Color.Bisque);
            pen7.Width = 9.5F;

            g.DrawLine(pen7, 140, 220, 166, 120);
            g.DrawLine(pen7, 185, 220, 166, 120);

            // І
            g.DrawLine(pen3, 210, 120, 210, 220);

            // Н
            Pen pen8 = new Pen(Color.BlueViolet);
            pen8.Width = 9.5f;

            g.DrawLine(pen8, 240, 120, 240, 220);
            g.DrawLine(pen8, 280, 120, 280, 220);
            g.DrawLine(pen8, 240, 160, 280, 160);

            // Ч
            Pen pen9 = new Pen(Color.CadetBlue);
            pen9.Width = 9.5f;

            g.DrawLine(pen9, 310, 120, 310, 180);
            g.DrawLine(pen9, 340, 120, 340, 220);
            g.DrawLine(pen9, 310, 175, 340, 175);

            // У
            Pen pen10 = new Pen(Color.Chartreuse);
            pen10.Width = 9.5f;

            g.DrawLine(pen10, 360, 120, 397, 165);
            g.DrawLine(pen10, 420, 120, 360, 220);

            // К
            g.DrawLine(pen5, 440, 120, 440, 220);
            g.DrawLine(pen5, 440, 160, 480, 125);
            g.DrawLine(pen5, 440, 160, 480, 215);


        }
    }
}
