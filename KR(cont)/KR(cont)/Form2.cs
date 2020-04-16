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
    public partial class Form2 : Form
    {
        public contEntities db = new contEntities();
        public List<s_students> studentsheet;
        public Form2()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentsheet = (from stud in db.s_students
                            select stud).ToList();
            var query = (from stud in studentsheet
                         join g in db.s_in_group on stud.id_group equals g.id_group
                         orderby stud.id
                         select new { stud.id, stud.surname, stud.name, stud.middlename, g.kurs_num, g.group_num }).ToList();

            dataGridView1.DataSource = query;
            dataGridView1.Columns[0].HeaderText = "Номер зачетной книжки";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Номер курса";
            dataGridView1.Columns[5].HeaderText = "Номер группы";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = (from stud in studentsheet
                         join g in db.s_in_group on stud.id_group equals g.id_group
                         orderby stud.id
                         select new { stud.id, stud.surname, stud.name, stud.middlename, g.kurs_num, g.group_num }).ToList();

            if (textBox1.Text != "")
            {
               var surname1 = (from stud in studentsheet
                            join g in db.s_in_group on stud.id_group equals g.id_group
                            where stud.surname == textBox1.Text.ToString()
                            orderby stud.id
                            select new { stud.id, stud.surname, stud.name, stud.middlename, g.kurs_num, g.group_num }).ToList();

                dataGridView1.DataSource = surname1;
              
            }
            if (textBox2.Text != "")
            {
                dataGridView1.DataSource = query.Where(p => p.kurs_num.ToString() == textBox2.Text.ToString()).ToList();
            }
            if (textBox3.Text != "")
            {
                dataGridView1.DataSource = query.Where(p => p.group_num.ToString() == textBox3.Text.ToString()).ToList();
            }

            else
            {
                dataGridView1.DataSource = query;
            }

            dataGridView1.Update();
        }
    }
}
