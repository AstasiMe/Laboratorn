using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NPOI.XSSF.UserModel;


namespace laba_linq_1
{
    public partial class Form2 : Form
    {
        public demo1Entities1 db = new demo1Entities1();
        public List<students> studentprogress;
        public Form2()
        {
            InitializeComponent();
            studentprogress = (from stud in db.students
                               select stud).ToList();
            var query = (from stud in studentprogress
                         join g in db.groups on stud.code_group equals g.code_group
                         join p in db.progress on stud.code_stud equals p.code_stud
                         join l in db.lectors on p.code_lector equals l.code_lector
                         join s in db.subjects on p.code_subject equals s.code_subject
                         orderby stud.code_stud
                         select new { stud.code_stud, stud.surname, stud.name, g.name_group, p.estimate, s.name_subject, l.name_lector }).ToList();

            dataGridView1.DataSource = query;
            dataGridView1.ReadOnly = true;
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
            dataGridView1.Columns[0].HeaderText = "Номер студента";
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Номер группы";
            dataGridView1.Columns[4].HeaderText = "Количество баллов";
            dataGridView1.Columns[5].HeaderText = "Дисциплина";
            dataGridView1.Columns[6].HeaderText = "ФИО преподавателя";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = (from stud in studentprogress
                         join g in db.groups on stud.code_group equals g.code_group
                         join p in db.progress on stud.code_stud equals p.code_stud
                         join l in db.lectors on p.code_lector equals l.code_lector
                         join s in db.subjects on p.code_subject equals s.code_subject
                         orderby stud.code_stud
                         select new { stud.code_stud, stud.surname, stud.name, g.name_group, p.estimate, s.name_subject, l.name_lector }).ToList();

            if (textBox1.Text != "")
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0: dataGridView1.DataSource = query.Where(p => p.code_stud.ToString() == textBox1.Text.ToString()).ToList(); break;
                    case 1: dataGridView1.DataSource = query.Where(p => p.surname.ToString() == textBox1.Text.ToString()).ToList(); break;
                    case 2: dataGridView1.DataSource = query.Where(p => p.name.ToString() == textBox1.Text.ToString()).ToList(); break;
                    case 3: dataGridView1.DataSource = query.Where(p => p.name_group.ToString() == textBox1.Text.ToString()).ToList(); break;
                    case 4: dataGridView1.DataSource = query.Where(p => p.estimate.ToString() == textBox1.Text.ToString()).ToList(); break;
                    case 5: dataGridView1.DataSource = query.Where(p => p.name_subject.ToString() == textBox1.Text.ToString()).ToList(); break;
                    case 6: dataGridView1.DataSource = query.Where(p => p.name_lector.ToString() == textBox1.Text.ToString()).ToList(); break;
                }
            }
            else
            {
                dataGridView1.DataSource = query;
            }

            dataGridView1.Update();
            if (dataGridView1.RowCount == 0) label1.Visible = true;
            else label1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<students> query = (from stud in db.students
                                    select stud).ToList();
            if (dataGridView1.SelectedCells.Count == 1)
            {
                if (Application.OpenForms.Count == 2)
                {
                    students item = query.First(w => w.code_stud.ToString() == dataGridView1.SelectedCells[0]
                    .OwningRow.Cells[0].Value.ToString());

                    EditProgress editSt = new EditProgress(item);
                    editSt.Owner = this;
                    editSt.Show();
                }
                else MessageBox.Show("Ацтой");
                    //Application.OpenForms[0].Focus();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count <= 3)
            {
                AddProgres addSt = new AddProgres();
                addSt.Owner = this;
                addSt.Show();
            }
            else Application.OpenForms[0].Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var query = (from stud in studentprogress
                         join g in db.groups on stud.code_group equals g.code_group
                         join p in db.progress on stud.code_stud equals p.code_stud
                         join l in db.lectors on p.code_lector equals l.code_lector
                         join s in db.subjects on p.code_subject equals s.code_subject
                         orderby stud.code_stud
                         select new { stud.code_stud, stud.surname, stud.name, g.name_group, p.estimate, s.name_subject, l.name_lector }).ToList();
            dataGridView1.DataSource = query;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dialog.DefaultExt = ".xls";

            dialog.Filter = "Таблицы Excel (*.xls)|*.xls|Все файлы (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.FileName = "Отчет успеваемости";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var file = new FileStream(dialog.FileName, FileMode.Create, FileAccess.ReadWrite);

                var query = (from stud in studentprogress
                             join g in db.groups on stud.code_group equals g.code_group
                             join p in db.progress on stud.code_stud equals p.code_stud
                             join l in db.lectors on p.code_lector equals l.code_lector
                             join s in db.subjects on p.code_subject equals s.code_subject
                             orderby stud.code_stud
                             select new { stud.code_stud, stud.surname, stud.name, g.name_group, p.estimate, s.name_subject, l.name_lector }).ToList();

                var progressStud = new MemoryStream(Properties.Resources.progressStud, true);
                var workbook = new XSSFWorkbook(progressStud);
                var sheet1 = workbook.GetSheet("Лист1");
                int row = 2;

                foreach (var item in query.OrderBy(o => o.code_stud))
                {
                    var rowInsert = sheet1.CreateRow(row);
                    rowInsert.CreateCell(0).SetCellValue(item.code_stud);
                    rowInsert.CreateCell(1).SetCellValue(item.surname);
                    rowInsert.CreateCell(2).SetCellValue(item.name);
                    rowInsert.CreateCell(3).SetCellValue(item.name_group);
                    rowInsert.CreateCell(4).SetCellValue(Convert.ToDouble(item.estimate));
                    rowInsert.CreateCell(5).SetCellValue(item.name_subject);
                    rowInsert.CreateCell(6).SetCellValue(item.name_lector);
                    row++;
                }
                workbook.Write(file);
            }
        }
    }
}
