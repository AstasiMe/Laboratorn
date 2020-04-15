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
    public partial class DeleteStud : Form
    {
        public demo1Entities1 db = new demo1Entities1();
        students item;
        public DeleteStud(students stud)
        {
            InitializeComponent();
            item = stud;
            label2.Text = item.surname + " " + item.name;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var del = from stud in db.students
                      where stud.code_stud == item.code_stud
                      select stud;

            foreach (var stud in del)
            {
                db.students.Remove(stud);
            }
            db.SaveChanges();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteStud_Load(object sender, EventArgs e)
        {

        }
    }
}
