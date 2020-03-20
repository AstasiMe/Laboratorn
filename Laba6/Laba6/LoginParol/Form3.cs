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

namespace LoginParol
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] text = File.ReadAllLines("user.txt");

            if (text[0] == ("pass " + textBox1.Text))
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("user.txt"))
                {
                    file.Write(text[0] + "\n" + text[1].Replace(("pass " + textBox1.Text), ("pass " + textBox2.Text)));
                    MessageBox.Show("Успешная смена пароля");
                }
            }
        }
    }
}
