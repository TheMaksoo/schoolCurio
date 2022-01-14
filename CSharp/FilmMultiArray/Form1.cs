using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmMultiArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // make data
            string[,] films = { { "Star Wars: Episode IV: A New Hope", "1977"}, { "Aliens", "1986" }, { "The Silence of the Lambs", "1991" }, { "Die Hard", "1988" }, { "The Green Mile", "1999" }, { "Avatar", "2009" }, { "Avenger: Infinity War", "2018" } };
            int i = 0;
            string list1 = "";

            // loop through data making the text.
            while ((films.Length / 2) > i)
            {
                list1 += films[i, 0] + " - " + films[i, 1] + "\r\n";
                i++;
            }
           
            // send text to application.
            movies.Text = list1;
            
        }
    }
}
