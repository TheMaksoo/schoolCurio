using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filmLijst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // make data
            string[] titles = { "Star Wars: Episode IV: A New Hope", "Aliens", "The Silence of the Lambs", "Die Hard", "The Green Mile", "Avatar", "Avenger: Infinity War" };
            int[] movieAge = { 1977, 1986, 1991, 1988, 1999, 2009, 2018 };
            int i = 0;
            string list1 = "";
            string list2 = "";
            string list3 = "";

            // loop through data making the text.
            while (titles.Length > i)
            {
                list1 += titles[i] + "\r\n";
                list2 += i + "\r\n";
                list3 += movieAge[i] + "\r\n";
                i++;
            }

            // send text to application.
            movies.Text = list1;
            number.Text = list2;
            age.Text = list3;

        }

        private void movies_TextChanged(object sender, EventArgs e)
        {

            
        }
    
    }
}
