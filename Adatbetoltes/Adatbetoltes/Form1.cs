using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace Adatbetoltes
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new BindingList<CountryData>();

        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            using (StreamReader sr = new StreamReader("countries.csv"))
            {
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] s = sor.Split(",");
                    CountryData countryData = new CountryData();
                    countryData.Name = string.Format(s[0]);
                    countryData.Population = long.Parse(s[1]);
                    countryData.AreaInSquareKm = double.Parse(s[2]);

                    countryList.Add(countryData);
                };


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CountryEdit ce = new CountryEdit();
            ce.CountryData = countryDataBindingSource.Current as CountryData;
            ce.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("countries.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(countryList);
            };
        }
    }
}