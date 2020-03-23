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
    public partial class Form2 : Form
    { 
        public Form2()
        {
                InitializeComponent();
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] text = File.ReadAllLines("user.txt");
            Form1 f1 = new Form1();
            if (Text == "Administrator")
            {
                if (text[0] == ("admin " + textBox1.Text))
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter("user.txt"))
                    {
                        file.Write(text[0].Replace(("admin " + textBox1.Text), ("admin " + textBox2.Text)) + "\n" + text[1]);
                        MessageBox.Show("Успешная смена пароля");
                    }
                }
            }
            if (text[1] == ("pass " + textBox1.Text))
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("user.txt"))
                {
                    file.Write(text[0] + "\n" + text[1].Replace(("pass " + textBox1.Text), ("pass " + textBox2.Text)));
                    MessageBox.Show("Успешная смена пароля");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Enabled = false;
            Close();
            
        }
    }
}
