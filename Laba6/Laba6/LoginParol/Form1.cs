using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginParol
{
    public partial class Form1 : Form
    {
        class User
        {
            public string login, parol;
            public void Read()
            {
                StreamReader sr = new StreamReader(@"C:\Users\27dro\source\repos\Визуальное\Laba6\Laba6\LoginParol\bin\Debug\user.txt");
                string line;
                bool prover = true;
                do
                {
                    line = sr.ReadLine();
                    if (line == string.Format(login + " " + parol) && login == "admin")
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        prover = false;
                        line = null;
                        sr.Close();
                    }
                    else
                    {
                        if (line == string.Format(login + " " + parol) && login == "pass")
                        {
                            Form3 f3 = new Form3();
                            f3.Show();  
                            prover = false;
                            line = null;
                        }
                    }
                } while (line != null);
               
                if (prover == true)
                MessageBox.Show(string.Format("Неверный логин или пароль"));
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.login = textBox1.Text;
            user.parol = textBox2.Text;
            user.Read();
            if (textBox1.Text =="pass" || textBox1.Text == "admin")
            Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Form2 f2 = new Form2();
            f2.Close();
            Form3 f3 = new Form3();
            f3.Close();
        }
    }
}
