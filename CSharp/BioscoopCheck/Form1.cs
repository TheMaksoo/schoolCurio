using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioscoopCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            if (passport.Checked)
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
                    result.Text = "Result: klant mag alcohol drinken!";
                }
                else
                {
                    result.Text = "Result: klant mag geen alcohol drinken.";
                }
            }
            else
            {
                result.Text = "Result: Geen passpoort";
            }
        }
    }
}
