using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int min, sec;
        int i;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

           button1.Enabled = true;
            sec = Convert.ToInt32(numericUpDown1.Value);
            label1.Text = string.Format("{1}:{0}", sec, min);
        }

        private void button1_Click(object sender, EventArgs e)
        {label1.Text = string.Format("{1}:{0}", sec, min);
            if (groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
                button1.Text = "Стоп";
                i = sec;
                timer1.Start();

                
            }
            else
            {
                label1.Text = "0:0";
                groupBox1.Visible = true;
                numericUpDown1.Value = 0;
                numericUpDown2.Value = 0;
                button1.Text = "Пуск";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (button1.Text == "Стоп") { 
            if (sec >= 0)
            {
                TimeSpan span = TimeSpan.FromMinutes(i);
                label1.Text = string.Format("{1}:{0}", sec, min);
                sec--;
                i--;
            }
            else { min--; sec = 59; }
                if (min <= 0 && sec < 0)
                {
                    timer1.Stop();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            min = Convert.ToInt32(numericUpDown2.Value);
            label1.Text = string.Format("{0}:0", min);
        }

    }
}
