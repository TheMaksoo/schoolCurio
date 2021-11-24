using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Huisberekenen
{
    public partial class huisBerekenen : Form
    {
        public huisBerekenen()
        {
            InitializeComponent();
        }

        private void OppervlakteVerdieping_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OppervlakteVerdieping.Text = Convert.ToString(oppervlakteVerdieping(float.Parse(LWoonkamer.Text), float.Parse(BWoonkamer.Text)));
                OppervlakteHuis.Text = Convert.ToString(Oppervlaktehuis(float.Parse(LWoonkamer.Text), float.Parse(BWoonkamer.Text), Convert.ToInt32(Verdiepingen.Text)));
                InhoudV.Text = Convert.ToString(InhoudVerdiepingen(float.Parse(LWoonkamer.Text), float.Parse(BWoonkamer.Text), float.Parse(HWoonkamer.Text)));
                InhoudW.Text = Convert.ToString(InhoudHuis(float.Parse(LWoonkamer.Text), float.Parse(BWoonkamer.Text), float.Parse(HWoonkamer.Text), Convert.ToInt32(Verdiepingen.Text)));
            }
            catch (Exception foutmelding)
            {
                MessageBox.Show("Er is een fout opgetreden. De melding is: " + foutmelding.Message);
            }
        }

        static float oppervlakteVerdieping(float Lengte, float Breedte)
        {
            float oppervlakteVerdieping = Lengte * Breedte;
            return oppervlakteVerdieping;
        }

        static float Oppervlaktehuis(float Lengte, float Breedte, int verdiepingen)
        {
            float Oppervlaktehuis = Lengte * Breedte * verdiepingen;
            return Oppervlaktehuis;
        }
        static float InhoudVerdiepingen(float Lengte, float Breedte, float Hoogte)
        {
            float InhoudVerdiepingen = Lengte * Breedte * Hoogte;
            return InhoudVerdiepingen;
        }
        static float InhoudHuis(float Lengte, float Breedte, float Hoogte, int Verdiepingen)
        {
            float InhoudHuis = Lengte * Breedte * Hoogte * Verdiepingen;
            return InhoudHuis;
        }
    }
}
