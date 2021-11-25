using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeeftijdControle
{
    public partial class leeftijdCheck : Form
    {
        public leeftijdCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime geboorteDag = dtp.Value;
            DateTime today = DateTime.Now;
            int leeftijd = today.Year - geboorteDag.Year;
            double ageDays = ((today - (geboorteDag)).TotalDays);
            double minAge = 18 * 365.25;
            double dagenTot = minAge - ageDays;


            if (leeftijd >= 18)
            {
                MessageBox.Show("Je mag alcohol drinken!");
            }
            else if (leeftijd >= 17)
            {
                MessageBox.Show("Je mag over " + dagenTot.ToString("N0") + " dagen drinken!");
            }
            else
            {
                MessageBox.Show("Je mag geen alcohol drinken.");
            }
        }
    }
}
