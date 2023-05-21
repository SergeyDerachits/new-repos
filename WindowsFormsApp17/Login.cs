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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введите имя или пароль");
            }
            else
            {
                if (textBox1.Text == "1" && textBox2.Text == "1")
                {
                    Form1 Obj = new Form1();
                    Obj.Show();
                    this.Hide();
                    MessageBox.Show("Вы вошли в сеть");
                }
                else
                {
                    MessageBox.Show("Неверное имя пользователя или пароль");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
        }
    }
}
