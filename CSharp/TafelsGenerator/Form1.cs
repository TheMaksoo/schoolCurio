using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TafelsGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            result.Clear();
            int x = 0;
            int y = Convert.ToInt32(input.Text);


            while (x <= 10)
            { 
                int z = x * y;
                result.Text =  result.Text + x.ToString() + " x " + y.ToString() + " = " + z + "\r\n";
                x++;
            }
        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void wis_Click(object sender, EventArgs e)
        {
            result.Clear();
        }
    }
}
