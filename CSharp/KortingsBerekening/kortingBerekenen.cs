using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KortingsBerekening
{
    public partial class kortingBerekenen : Form
    {
        public kortingBerekenen()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double bedrag = Convert.ToDouble(inputBedrag.Text);

            if (bedrag < 10 && bedrag > 0)
            {
                double calc = kortingBerekenen(bedrag, 5);
                kortingPercentage.Text = "5%";
                kortingEuro.Text = Convert.ToString(calc);
                betalen.Text = Convert.ToString(bedrag - calc);
            } 
            else if (bedrag < 40 && bedrag > 0)
            {
                double calc = kortingBerekenen(bedrag, 12.50);
                kortingPercentage.Text = "12,50%";
                kortingEuro.Text = Convert.ToString(calc);
                betalen.Text = Convert.ToString(bedrag - calc);
            }
            else if (bedrag < 100 && bedrag > 0)
            {
                double calc = kortingBerekenen(bedrag, 15);
                kortingPercentage.Text = "15%";
                kortingEuro.Text = Convert.ToString(calc);
                betalen.Text = Convert.ToString(bedrag - calc);
            }
            else if (bedrag > 200)
            {
                double calc = kortingBerekenen(bedrag, 21.5);
                kortingPercentage.Text = "21,5%";
                kortingEuro.Text = Convert.ToString(calc);
                betalen.Text = Convert.ToString(bedrag - calc);
            }
            else
            {
                kortingPercentage.Text = "N.V.T.";
                kortingEuro.Text = "N.V.T.";
                betalen.Text = "N.V.T.";
            }
        }
        public static double kortingBerekenen(double bedrag, double korting)
        {
            double calc = (bedrag / 100) * korting;
            return calc;
        }
    }
}
