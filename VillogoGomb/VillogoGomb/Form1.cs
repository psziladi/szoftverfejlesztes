using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        int M�ret = 20;
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
                    Sz�mol�Gomb b = new Sz�mol�Gomb();
                    //b.Height = M�ret;
                    //b.Width = M�ret;
                    b.Left = oszlop*M�ret;
                    b.Top = sor*M�ret;
                    //b.Text = ((sor + 1) * (oszlop + 1)).ToString();
                    Controls.Add(b);
                }
            }
        }
    }
}