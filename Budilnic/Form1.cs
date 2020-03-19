using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budilnic
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = DateTime.Now.ToShortTimeString();
        }

        int hour, min;
        DateTime timeBudil = new DateTime();
        DateTime timeNow = new DateTime();
        int result = 1;
        int MIN = DateTime.Now.Minute;
        int HOUR = DateTime.Now.Hour;
        int SEC = DateTime.Now.Second;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
                button1.Enabled = true;
            }
            else button1.Enabled = false;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            min = Convert.ToInt32(numericUpDown2.Value);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            timer1.Start();
            timer1.Enabled = true;
            notifyIcon1.Text = string.Format("{0}:{1}", hour, min);
            notifyIcon1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timer1.Enabled == true)
            {
                if (SEC == 59)
                {
                    SEC = 0;
                    MIN++;
                }
                else
                {
                    SEC++;
                    if (MIN == 59)
                    {
                        MIN = 0;
                        HOUR++;

                    }

                }

                timeNow = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
               HOUR, MIN, SEC);
                timeBudil = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
               hour, min, 0);
                result = DateTime.Compare(timeBudil, timeNow);
                if (result == 0)
                {
                    timer1.Stop();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                    Close();
                }
            }
        }

       
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           MessageBox.Show(string.Format("Будильник на сработет в {0}:{1}", hour, min));
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("О программе");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            hour = Convert.ToInt32(numericUpDown1.Value);
        }
    }
}
