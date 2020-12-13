using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KvUr();
        }

        private void KvUr()
        {
            int x = 0;
            int z = 0;
            string a = "";

            try
            {
                x = Convert.ToInt32(textBox1.Text);
            }
            catch
            {
                if (x == 0)
                {
                    MessageBox.Show("Нельзя вводить 0");
                }
            }
            finally
            {
                textBox1.Clear();
                z = x * 22;
                a = z.ToString();
                MessageBox.Show($"Ответ: {a}");
            }
        }
    }
}
