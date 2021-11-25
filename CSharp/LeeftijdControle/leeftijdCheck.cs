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
            DateTime geboorteDatum = dtp.Value;
            geboorteDatum.AddYears(18).ToShortDateString();
            DateTime vandaag = DateTime.Now;
            int leeftijdJaren = vandaag.Year - geboorteDatum.Year;
            double leeftijdInDagen = ((vandaag - (geboorteDatum)).TotalDays);
            double minimaleLeeftijd = 18 * 365.25;
            double drinkLeeftijdInDagen = minimaleLeeftijd - leeftijdInDagen;


            if (leeftijdJaren >= 18)
            {
                MessageBox.Show("Je mag alcohol drinken!");
            }
            else if (leeftijdJaren >= 17)
            {
                MessageBox.Show("Je mag over " + drinkLeeftijdInDagen.ToString("N0") + " dagen drinken!");
            }
            else
            {
                MessageBox.Show("Je mag geen alcohol drinken.");
            }
        }
    }
}
