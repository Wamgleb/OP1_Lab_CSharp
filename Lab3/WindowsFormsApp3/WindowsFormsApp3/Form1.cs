/*
Лабораторна робота №3
виконав студент ЗПІ-ЗПО1
Калінчук Гліб Сергійович
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Реализация кнопки выхода;
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Переход на первую форму - Список клиентов; 
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fmr2 = new Form2();
            fmr2.Show();
            Hide();
        }

        //Переход на вторую форму (4) - Пополнение счета;
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 fmr4 = new Form4();
            fmr4.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Show();
            Hide();
        }
    }
}
