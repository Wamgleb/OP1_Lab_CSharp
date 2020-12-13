using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fms2 = new Form2();
            //Вот тут поможет БД
            fms2.dataGridView1.Rows[0].Cells[0].Value = this.textBox1.Text;
            fms2.Show();
            Hide();
            //TODO Подключить базу данных
            /*Чтобы менять значение координат в грид таблице можно использовать перебор, цикл после выполнения
             * значение прибавляет 1 и так далее до завершения*/
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
