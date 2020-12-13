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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5(this);
            frm5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int intdd = dataGridView2.SelectedCells[0].RowIndex;
                dataGridView2.Rows.RemoveAt(intdd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream mystr1 = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((mystr1 = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader myread1 = new StreamReader(mystr1);
                    string[] str;
                    int num = 0;
                    try
                    {
                        string[] str2 = myread1.ReadToEnd().Split('\n');
                        num = str2.Count();
                        dataGridView2.RowCount = num;

                        for (int i = 0; i < num; i++)
                        {
                            str = str2[i].Split(';');

                            for (int j = 0; j < dataGridView2.ColumnCount; j++)
                            {
                                try
                                {
                                    dataGridView2.Rows[i].Cells[j].Value = str[j];
                                }
                                catch
                                {

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myread1.Close();
                    }
                }
            }
        }

        private void зберигтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter myWriter = new StreamWriter(myStream);
                    try
                    {
                        for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                        {
                            for (int j = 0; j < dataGridView2.ColumnCount; j++)
                            {
                                myWriter.Write(dataGridView2.Rows[i].Cells[j].Value.ToString());
                                if ((dataGridView2.ColumnCount - j) != 1)
                                {
                                    myWriter.Write(";");
                                }
                            }
                            myWriter.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myWriter.Close();
                    }
                    myStream.Close();
                }
            }
        }
    }
}
