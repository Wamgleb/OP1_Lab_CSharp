using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
            Hide();
        }

        private void LoadData()
        //Загружаем БД
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' as [DELETE] FROM Users", sqlConnection);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);
          
                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Users");
                dataGridView1.DataSource = dataSet.Tables["Users"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[3, i] = linkCell;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadData()
        //Перезагружаем БД
        {
            try
            {
                dataSet.Tables["Users"].Clear();

                sqlDataAdapter.Fill(dataSet, "Users");
                dataGridView1.DataSource = dataSet.Tables["Users"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dataGridView1[3, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gleb\Documents\C#\WindowsFormsApp2\WindowsFormsApp2\Database1.mdf;Integrated Security=True");
            sqlConnection.Open();

            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReloadData();
        }
    }
}

//TODO Сделать изминение в базу данных через новую форму;
//TODO Смотри видео; 
