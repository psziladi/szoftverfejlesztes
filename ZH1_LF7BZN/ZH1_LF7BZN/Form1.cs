namespace ZH1_LF7BZN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<SzamEsGyok> szamEsGyoks = new List<SzamEsGyok>();

            for (int i = 1; i < 16; i++)
            {
                Math.Sqrt(i);
                SzamEsGyok szamEsGyok = new SzamEsGyok();
                szamEsGyok.Sz�m = i;
                szamEsGyok.N�gyzetgy�k = Math.Sqrt(i);
                szamEsGyoks.Add(szamEsGyok);
            }

            dataGridView1.DataSource = szamEsGyoks;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int DarabSz�m = int.Parse(textBox1.Text);
            int M�ret = 140;

            for (int i = 1; i < DarabSz�m; i++)
            {
                DiceButton diceButton = new DiceButton();
                Controls.Add(diceButton);
                diceButton.Top = i * M�ret;

            }
        }
    }
}