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
			catch (Exception foutmelding)
            {
				MessageBox.Show("Er is een fout opgetreden. De melding is: " + foutmelding.Message);
			}
		}

		private void Min_Click(object sender, EventArgs e)
		{
			try
			{
				Resultaat.Text = Convert.ToString(float.Parse(Input1.Text) - float.Parse(Input2.Text));
			}
			catch (Exception foutmelding)
			{
				MessageBox.Show("Er is een fout opgetreden. De melding is: " + foutmelding.Message);
			}
		}

		private void Keer_Click(object sender, EventArgs e)
		{
			try
			{
				Resultaat.Text = Convert.ToString(float.Parse(Input1.Text) * float.Parse(Input2.Text));
			}
			catch (Exception foutmelding)
			{
				MessageBox.Show("Er is een fout opgetreden. De melding is: " + foutmelding.Message);
			}
		}
		private void Delen_Click(object sender, EventArgs e)
		{
			try
			{
				Resultaat.Text = Convert.ToString(float.Parse(Input1.Text) / float.Parse(Input2.Text));
			}
			catch (Exception foutmelding)
			{
				MessageBox.Show("Er is een fout opgetreden. De melding is: " + foutmelding.Message);
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
    }
}
