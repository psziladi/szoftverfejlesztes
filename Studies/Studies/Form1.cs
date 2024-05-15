using CsvHelper;
using System.Globalization;
using System.Windows.Forms;

namespace Studies
{
    public partial class Form1 : Form
    {
        Models.StudiesContext context;
        public Form1()
        {
            InitializeComponent();
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl userControl1 = new UserControl1();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }

        private void UserControl2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl userControl2 = new UserControl2();
            panel1.Controls.Add(userControl2);
            userControl2.Dock = DockStyle.Fill;
        }

        private void UserControl3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
        }

        private void UserControl4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl userControl4 = new UserControl4();
            panel1.Controls.Add(userControl4);
            userControl4.Dock = DockStyle.Fill;
        }
    }
}