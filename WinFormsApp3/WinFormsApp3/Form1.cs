using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        BindingList<Futók> futók = new();

        public Form1()
        {
            InitializeComponent();

            //dataGridView1.DataSource = futók; //!!!!!!!!!!!!!!!!!!

            futókBindingSource.DataSource = futók;
        }

        private void buttonBetöltés_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Futoverseny.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t = csv.GetRecords<Futók>();

                foreach (var item in t)
                {
                    futók.Add(item);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMentés_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                    csv.WriteRecords(futók);
                    streamWriter.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonTörlés_Click(object sender, EventArgs e)
        {
            if (futókBindingSource.Current == null) return;

            if (MessageBox.Show("A", "B", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                futókBindingSource.RemoveCurrent();
            }
        }

        private void buttonÚj_Click(object sender, EventArgs e)
        {
            FormÚjFutó formÚjFutó = new FormÚjFutó();

            if (formÚjFutó.ShowDialog() == DialogResult.OK)
            {
                futókBindingSource.Add(formÚjFutó.ÚjFutó);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double minimum = double.PositiveInfinity;
            string leggyorsabb = string.Empty;

            foreach (var item in futók)
            {
                if (item.EredmenyPerc < minimum)
                {
                    minimum = item.EredmenyPerc;
                    leggyorsabb += item.Nev;
                }
            }

            MessageBox.Show($"A lejobb idõ: {leggyorsabb}");
        }
    }
}
