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
    public partial class Form7 : Form
    {
        Form6 frm6;
        public Form7(Form6 fg)
        {
            InitializeComponent();
            this.frm6 = fg;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm6.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
        }
    }
}
