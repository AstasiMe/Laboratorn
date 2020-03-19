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
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();

            label1.Text = string.Format("{0}", DateTime.Now.ToShortTimeString());
           // label2.Text = string.Format("{0}", f)
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Visible = false;
        }
    }
}
