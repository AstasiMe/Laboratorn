using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_linq_1
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "user" && textBox2.Text == "user") || (textBox1.Text == "admin" && textBox2.Text == "admin"))
            {
                pictureBox1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
            else MessageBox.Show("Неверный логин или пароль");
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form1 f1 = new Form1(); 
           f1.Show();
            if (textBox1.Text == "user")
            {
                f1.button2.Enabled = false;
                f1.button3.Enabled = false;
                f1.button6.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
            if (textBox1.Text == "user") 
            {
                f1.button2.Enabled = false;
                f1.button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Form1 f1 = new Form1();
            f2.Close();
            f1.Close();
            pictureBox1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
