using Adatbazis1.Models;

namespace Adatbazis1
{
    public partial class Form1 : Form
    {
        Models.StudentContext studentContext = new Models.StudentContext();
        public StudentContext context;
        

        public Form1()
        {
            InitializeComponent();
            studentBindingSource.DataSource = studentContext.Students.ToList();
            context = new StudentContext();
            listBox1.DataSource = (from x in context.Students select x.Neptun).ToList();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                studentContext.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message);
            }


        }

        private void buttonSz�r�s_Click(object sender, EventArgs e)
        {
            context = new StudentContext();

            var eredm�ny = (from x in context.Students
                            where x.Name.StartsWith("A")
                            select x).ToList();

            studentBindingSource.DataSource = eredm�ny.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            context = new StudentContext();

            var be�r�s = (from x in context.Students
                          where x.Name.StartsWith(textBox1.Text)
                          select x).ToList();

            studentBindingSource.DataSource = be�r�s.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kiv�lasztottelem = listBox1.SelectedItem;

            studentBindingSource.DataSource = (from x in context.Students
                                               where x.Neptun == kiv�lasztottelem
                                               select x).ToList();
        }
    }
}