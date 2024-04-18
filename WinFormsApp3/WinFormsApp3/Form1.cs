using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        BindingList<Fut�k> fut�k = new();

        public Form1()
        {
            InitializeComponent();

            //dataGridView1.DataSource = fut�k; //!!!!!!!!!!!!!!!!!!

            fut�kBindingSource.DataSource = fut�k;
        }

        private void buttonBet�lt�s_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Futoverseny.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t = csv.GetRecords<Fut�k>();

                foreach (var item in t)
                {
                    fut�k.Add(item);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMent�s_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                    csv.WriteRecords(fut�k);
                    streamWriter.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonT�rl�s_Click(object sender, EventArgs e)
        {
            if (fut�kBindingSource.Current == null) return;

            if (MessageBox.Show("A", "B", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                fut�kBindingSource.RemoveCurrent();
            }
        }

        private void button�j_Click(object sender, EventArgs e)
        {
            Form�jFut� form�jFut� = new Form�jFut�();

            if (form�jFut�.ShowDialog() == DialogResult.OK)
            {
                fut�kBindingSource.Add(form�jFut�.�jFut�);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double minimum = double.PositiveInfinity;
            string leggyorsabb = string.Empty;

            foreach (var item in fut�k)
            {
                if (item.EredmenyPerc < minimum)
                {
                    minimum = item.EredmenyPerc;
                    leggyorsabb += item.Nev;
                }
            }

            MessageBox.Show($"A lejobb id�: {leggyorsabb}");
        }
    }
}
