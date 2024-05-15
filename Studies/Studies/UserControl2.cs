using Studies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studies
{
    public partial class UserControl2 : UserControl
    {
        StudiesContext context = new StudiesContext();

        public UserControl2()
        {
            InitializeComponent();
            FillDataSource();

        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            var ilist = from i in context.Courses
                        select i;
            listBox1.DataSource = ilist.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Course course = listBox1.SelectedItem as Course;
            var courses = from l in context.Lessons
                          where l.CourseFk == course.CourseSk
                          select new
                          {
                              Nap = l.DayFkNavigation.Name,
                              Idő = l.TimeFkNavigation.Name,
                              Oktató = l.InstructorFkNavigation.Name
                          };
            dataGridView1.DataSource = courses.ToList();
        }

        private void FillDataSource()
        {
            listBox1.DataSource = (from c in context.Courses
                                   where c.Name.Contains(textBox1.Text)
                                   select c).ToList();

        }

    }
}
