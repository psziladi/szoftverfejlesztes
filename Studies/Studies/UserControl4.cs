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
    public partial class UserControl4 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl4()
        {
            InitializeComponent();
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            var ilist = from l in context.Lessons
                        select l;
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
            Instructor selectedInstructor = listBox1.SelectedItem as Instructor;
            var instructor = from i in context.Instructors
                             where i.InstructorSk == selectedInstructor.InstructorSk
                             select new
                             {
                                 Névelőtag = i.Salutation,
                                 Név = i.Name,
                                 Státusz = i.StatusFkNavigation.Name,
                                 Foglalkoztatás = i.EmployementFkNavigation.Name
                             };
            dataGridView1.DataSource = instructor.ToList();
        }

        private void FillDataSource()
        {

        }
    }
}
