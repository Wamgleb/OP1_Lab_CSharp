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
    public partial class Form5 : Form
    {
        Form4 frm4;
        public Form5(Form4 fg1)
        {
            InitializeComponent();
            this.frm4 = fg1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm4.dataGridView2.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
        }
    }
}
