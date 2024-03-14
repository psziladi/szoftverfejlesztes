using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace VillogoGomb
{
    internal class SzinezodoGomb : Button
    {
        int Méret = 20;
        public SzinezodoGomb()
        {
            Height = Méret;
            Width = Méret;
            Click += SzinezodoGomb_Click;
        }

        private void SzinezodoGomb_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
