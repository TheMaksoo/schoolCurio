using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekenMachineUI
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

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void Plus_Click(object sender, EventArgs e)
		{
            try 
			{ 
				Resultaat.Text = Convert.ToString(float.Parse(Input1.Text) + float.Parse(Input2.Text));
			}
			catch
            {
				FoutAfhandeling(Input1.Text, Input2.Text);
			}
		}

		private void Min_Click(object sender, EventArgs e)
		{
			try
			{
				Resultaat.Text = Convert.ToString(float.Parse(Input1.Text) - float.Parse(Input2.Text));
			}
			catch
			{
				FoutAfhandeling(Input1.Text, Input2.Text);
			}
		}

		private void Keer_Click(object sender, EventArgs e)
		{
			try
			{
				Resultaat.Text = Convert.ToString(float.Parse(Input1.Text) * float.Parse(Input2.Text));
			}
			catch 
			{
				FoutAfhandeling(Input1.Text, Input2.Text);
			}
		}
		private void Delen_Click(object sender, EventArgs e)
		{
			try
			{
				Resultaat.Text = Convert.ToString(float.Parse(Input1.Text) / float.Parse(Input2.Text));
			}
			catch 
			{
				FoutAfhandeling(Input1.Text, Input2.Text);
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
			try
			{
				Resultaat.Text = Convert.ToString(((float.Parse(Input1.Text) / 100) * float.Parse(Input2.Text)) + float.Parse(Input1.Text));
			}
			catch (Exception foutmelding)
			{
				MessageBox.Show("Er is een fout opgetreden. De melding is: " + foutmelding.Message);
			}
		}

		static (double?, double?) FoutAfhandeling(string getal1String, string getal2String)
		{
			bool getal1Check = double.TryParse(getal1String, out double result1);
			bool getal2Check = double.TryParse(getal2String, out double result2);

			if (getal1Check == true)
			{
				if (getal2Check == true)
				{
					return (result1, result2);
				}
				else
				{
					MessageBox.Show("U heeft in het tweede veld geen getal ingevuld.");
					return (null, null);
				}
			}
			else
			{
				if (getal2Check == true)
				{
					MessageBox.Show("U heeft inhet eerste veld geen getal ingevuld.");
					return (null, null);
				}
				else
				{
					MessageBox.Show("U heeft in beide velden geen getal ingevuld.");
					return (null, null);
				}
			}
		}
	}
}
