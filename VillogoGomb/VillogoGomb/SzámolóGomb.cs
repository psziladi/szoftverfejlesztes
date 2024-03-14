using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzámolóGomb : Button
    {
        int szám = 1;
        public SzámolóGomb()
        {
            Height = 20;
            Width = 20;
            Text = szám.ToString();
            Click += SzámolóGomb_Click;

            
        }

        private void SzámolóGomb_Click(object? sender, EventArgs e)
        {
            szám++;
            if (szám == 6)
            {
                szám = 1;
            }
            Text = szám.ToString();
        }
    }
}
