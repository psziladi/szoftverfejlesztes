using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        int Méret = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    SzámolóGomb b = new SzámolóGomb();
                    //b.Height = Méret;
                    //b.Width = Méret;
                    b.Left = oszlop*Méret;
                    b.Top = sor*Méret;
                    //b.Text = ((sor + 1) * (oszlop + 1)).ToString();
                    Controls.Add(b);
                }
            }
        }
    }
}