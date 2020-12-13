using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form9 : Form
    {
        Form8 frm8;
        public Form9(Form8 fg)
        {
            InitializeComponent();
            this.frm8 = fg;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm8.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text);
        }
    }
}
