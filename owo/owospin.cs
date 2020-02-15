using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace owo
{
    public partial class owospin : Form
    {
        private String[] owos = { "( owo)", "(  ow)", "(   o)", "(    )", "(o   )", "(wo  )", "(owo )" };
        private int i = 0;

        public owospin()
        {
            InitializeComponent();
            Timer.Start();
        }

        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            i++;

            if (i >= owos.Length)
            {
                i = 0;
            }

            owo.Text = owos[i];
            this.Name = owos[i];
            this.Text = owos[i];
            BackColor = ColorFromHSV((DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalSeconds*10%360, 0.5, 0.75);
        }
    }
}
