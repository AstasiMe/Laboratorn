﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private DateTime startTime, pauseTime;
        private TimeSpan pauseSpan;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                TimeSpan s = DateTime.Now - startTime - pauseSpan;
                label1.Text = string.Format("Timer {0}:{1}", s.Minutes * 60 + s.Seconds, s.Milliseconds / 100);
            }
            else label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
               button1.Enabled = button2.Enabled = true; //добавила строку, а то хз поч не работает без нее
               startTime = DateTime.Now;
               pauseSpan = TimeSpan.Zero;
               timer1.Interval = 100;
            }
            else
            {
                timer1.Interval = 1000;
                timer1_Tick(this, null);
                button1.Enabled = button2.Enabled = checkBox1.Checked;
                timer1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
                pauseSpan += DateTime.Now - pauseTime;
            else pauseTime = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pauseTime = startTime;
            pauseSpan = TimeSpan.Zero;
            label1.Text = "Timer 0:0";
        }

       
    }
}
