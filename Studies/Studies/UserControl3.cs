using CsvHelper;
using Studies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studies
{
    public partial class UserControl3 : UserControl
    {

        StudiesContext context = new StudiesContext();

        public UserControl3()
        {
            InitializeComponent();
            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            var ilist = from i in context.Instructors
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
            listBox1.DataSource = (from i in context.Instructors
                                   where i.Name.Contains(textBox1.Text)
                                   select i).ToList();
        }

        private void Mentés1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    var csv = new CsvWriter(sw, CultureInfo.InvariantCulture);
                    //csv.WriteRecords();
                    sw.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
