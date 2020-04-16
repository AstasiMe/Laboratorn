using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR_cont_
{
    public partial class Form4 : Form
    {
        public contEntities db = new contEntities();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = (from g in db.s_in_group
                         where g.group_num.ToString() == textBox4.ToString()
                         select g.id_group).ToList();
            int number_of_student = db.s_students.Max(n => n.id) + 1;

            s_students new_student = new s_students
            {
                id = number_of_student,
                surname = textBox1.Text,
                name = textBox2.Text,
                middlename = textBox3.Text
            };

            s_in_group newrr = new s_in_group
            {
                id_group = query[0],
                kurs_num = Convert.ToInt32(textBox5.Text),
                group_num = Convert.ToInt32(textBox4.Text)
            };


            db.s_students.Add(new_student);
            db.s_in_group.Add(newrr);
            db.SaveChanges();
            this.Close();
        }
    }
}
