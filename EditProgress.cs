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
    public partial class EditProgress : Form
    {
        public demo1Entities1 db = new demo1Entities1();
        students item;
       
        public EditProgress(students stud)
        {
           
            item = stud;
            InitializeComponent();

            var groups_for_list = (from g in db.groups
                                   select g.name_group).Distinct();

            foreach (string it in groups_for_list)
            {
                comboBox1.Items.Add(it);
            }
            textBox1.Text = item.surname.ToString();
            textBox2.Text = item.name.ToString();

            var query = (from g in db.groups
                         where g.code_group == item.code_group
                         select g.name_group).ToList();

            var prog_for_list = (from p in db.progress
                                 select p.estimate).Distinct();

            comboBox1.SelectedItem = query[0];
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = ((Form2)Owner).db.students.SingleOrDefault(w => w.code_stud == item.code_stud);
            var res = ((Form2)Owner).db.progress.SingleOrDefault(w => w.code_stud == item.code_stud && w.code_subject == comboBox3.SelectedIndex);
            result.surname = textBox1.Text.ToString().Trim();
            result.name = textBox2.Text.ToString().Trim();

            var query = (from g in db.groups
                         where g.name_group == comboBox1.SelectedItem.ToString()
                         select g.code_group).ToList();

            var prog = (from p in db.progress
                        where p.estimate == comboBox2.SelectedIndex 
                        select p.code_stud).ToList();

            result.code_group = query[0];
            res.estimate = prog[0];
            ((Form2)Owner).db.SaveChanges();
            ((Form2)Owner).studentprogress = ((Form2)Owner).db.students.OrderBy(o => o.code_stud).ToList();
           
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditProgress_Load(object sender, EventArgs e)
        {

        }
    }
}
