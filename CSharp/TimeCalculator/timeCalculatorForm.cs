using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace TimeCalculator
{
    public partial class timeCalculatorForm : Form
    {
        public timeCalculatorForm()
        {
            InitializeComponent();
        }

        private void btnJaar_Click(object sender, EventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            int jaar = vandaag.Year;
            result.Text = Convert.ToString(jaar);
        }

        private void btnLeeftijd_Click(object sender, EventArgs e)
        {
            DateTime geboorteDag = input.Value;
            DateTime today = DateTime.Now;
            int leeftijd = today.Year - geboorteDag.Year;
            result.Text = Convert.ToString(leeftijd);
        }

        private void btnSchrikkeljaar_Click(object sender, EventArgs e)
        {
            DateTime year = input.Value;
            bool date = DateTime.IsLeapYear(year.Year);
            result.Text = Convert.ToString(date);
        }

        private void btnWeek_Click(object sender, EventArgs e)
        {
            DateTime date = input.Value;
            DayOfWeek week = date.DayOfWeek;
            result.Text = Convert.ToString(week);
            
        }

        private void btnWeeknummer_Click(object sender, EventArgs e)
        {
            DateTime date = input.Value;
            result.Text = Convert.ToString(GetWeekNumber(date));

        }

        public static int GetWeekNumber(DateTime dtPassed)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        private void btnDagenTotDatum_Click(object sender, EventArgs e)
        {
            DateTime date = input.Value;
            result.Text = ((date - (DateTime.Now)).TotalDays).ToString("N0");
        }
    }
}