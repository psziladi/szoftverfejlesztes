using CsvHelper;
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
using static System.Windows.Forms.DataFormats;

namespace Adatbetoltes
{
    public partial class CountryEdit : Form
    {
        public CountryData CountryData;

        public CountryEdit()
        {
            InitializeComponent();
        }

        private void CountryEdit_Load(object sender, EventArgs e)
        {
            countryDataBindingSource.DataSource = CountryData;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
