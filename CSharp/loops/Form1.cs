using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double i = 1;
            while (i < 562949953421312)
            { 
                i = i * 2;
                txbGetallen.Text = txbGetallen.Text + i.ToString() + "\r\n";
            }
        }

        private void txbGetallen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
