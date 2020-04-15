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
    public partial class AddProgres : Form
    {
        public demo1Entities1 db = new demo1Entities1();
        public AddProgres()
        {
            InitializeComponent();
            var groups_for_list = (from g in db.groups
                                   select g.name_group).Distinct();
            foreach (string it in groups_for_list)
            {
                comboBox1.Items.Add(it);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = (from g in db.groups
                         where g.name_group == comboBox1.SelectedItem.ToString()
                         select g.code_group).ToList();

            int number_of_student = db.students.Max(n => n.code_stud) + 1;

            students new_student = new students
            {
                code_stud = number_of_student,
                surname = textBox1.Text,
                name = textBox2.Text,
                code_group = query[0],
            };

            progress new_progress = new progress
            {
                estimate = comboBox2.SelectedIndex,
                code_lector = comboBox4.SelectedIndex,
                code_subject = comboBox3.SelectedIndex
            };

            

            db.students.Add(new_student);
            db.progress.Add(new_progress);
            db.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
