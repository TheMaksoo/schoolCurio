using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kassa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tosti_TextChanged(object sender, EventArgs e)
        {
            string uitvoer;
            switch (tosti.Text)
            {
                case "tosti":
                {
                    uitvoer = "Prijs: 6,50€";
                    break;
                }
                case "uitsmijter":
                {
                    uitvoer = "Prijs: 7,95€";
                    break;
                }
                case "koffie":
                {
                    uitvoer = "Prijs: 2,25€";
                    break;
                }
                case "melk":
                {
                    uitvoer = "Prijs: 2,00€";
                    break;
                }
                case "frisdrank":
                {
                    uitvoer = "Prijs: 2,50€";
                    break;
                }
                default:
                { 
                    uitvoer = "Dit item hebben we niet.";
                    break;
                }
            }
            prijs.Text = uitvoer;
        }
    }
}
