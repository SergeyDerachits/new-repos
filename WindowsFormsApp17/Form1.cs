using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 F3 = new Form2();
            F3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 F3 = new Form3();
            F3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 F3 = new Form4();
            F3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 F3 = new Form7();
            F3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 F3 = new Form6();
            F3.Show();
        }
    }
}
