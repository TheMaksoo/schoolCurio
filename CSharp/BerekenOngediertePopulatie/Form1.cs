using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerekenOngediertePopulatie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double start = 1000;
            int end = 10000;
            int year = 1942;
            while (start <= end)
            {
                year++;
                start = Math.Ceiling(start * 1.15);
                output.Text = output.Text + "\nJaar: " + year.ToString() + "\r\nAantal: " + start.ToString() + "\r\n\r\n";
            }
        }
    }
}
