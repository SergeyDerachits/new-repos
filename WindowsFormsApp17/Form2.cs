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

namespace WindowsFormsApp17
{
    public partial class Form2 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\aptek.mdf;Integrated Security=True;Connect Timeout=30 ");
        public Form2()
        {
            InitializeComponent();
        }
        public void TextboxFilter()
        {
            Con.Open();
            string query = "select * from Preparats where Name = '" + textBox4.Text + "' ";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            Con.Close();
        }
        public void populateGrid()
        {
            Con.Open();
            string query = "select * from Preparats";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            populateGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Con.Open();
            SqlCommand cmd = new SqlCommand(" insert into Preparats values ( '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "') ", Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Добавлено");
            Con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            populateGrid();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextboxFilter();
        }

        
    }

}
