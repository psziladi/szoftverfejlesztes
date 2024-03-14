using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZH1_LF7BZN
{
    internal class DiceButton : Label
    {
     
        public DiceButton()
        {
            Height = 140;
            Width = 140;
            BackColor = Color.Gray;
            this.Text = "\u2685";
            MouseClick += DiceButton_MouseClick;
        }

        private void DiceButton_MouseClick(object? sender, MouseEventArgs e)
        {
            Random rnd = new Random();
           
            for (int i = 1; i < 7; i++)
            {
                int véletlen = rnd.Next(1, 7);
                if (véletlen == 1)
                {
                    Text = "\u2680";
                }
                if (véletlen == 2)
                {
                    Text = "\u2681";
                }
                if (véletlen == 3)
                {
                    Text = "\u2682";
                }
                if (véletlen == 4)
                {
                    Text = "\u2683";
                }
                if (véletlen == 5)
                {
                    Text = "\u2684";
                }
                if (véletlen == 6)
                {
                    Text = "\u2685";
                }
            }
        }
    }
}
