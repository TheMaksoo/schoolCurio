using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DessertsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            string[,] ijsjes = { { "Codemonkey", "Vanille", "BanaanciFi", "Chocoladesaus" }, { "Perl", "Aardbeien", "Aardbei", "Aardbeinensaus" }, { "Noob", "Vanille", "TumTum", "Sprinkles" }, { "Java", "Chocolade", "KoffieSaus", "Koffieboontjes" } };
            int aantalRijen = ijsjes.GetLength(0);
            int aantalKolommen = ijsjes.GetLength(1);

            dgvIjsjes.RowHeadersVisible = false;
            dgvIjsjes.AllowUserToAddRows = false;
            dgvIjsjes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvIjsjes.ColumnCount = aantalKolommen;
            dgvIjsjes.Columns[0].HeaderText = "Naam";
            dgvIjsjes.Columns[1].HeaderText = "Ijssoort";
            dgvIjsjes.Columns[2].HeaderText = "Ingrediënt_1";
            dgvIjsjes.Columns[3].HeaderText = "Ingrediënt_2";


            for (int r = 0; r < aantalRijen; r++)
            {
                DataGridViewRow dataRij = new DataGridViewRow();
                dataRij.CreateCells(dgvIjsjes);

                for (int k = 0; k < aantalKolommen; k++)
                {
                    dataRij.Cells[k].Value = ijsjes[r, k];
                }

                dgvIjsjes.Rows.Add(dataRij);
            }
        }

        private void addIcecream_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(naamInput.Text) || String.IsNullOrEmpty(ijssoortInput.Text) || String.IsNullOrEmpty(ingredient_1Input.Text) || String.IsNullOrEmpty(ingredient_2Input.Text))
            {
                errorMsg.Text = "Vul alle velden in!";
            }
            else
            {
                dgvIjsjes_addGrid(naamInput.Text, ijssoortInput.Text, ingredient_1Input.Text, ingredient_2Input.Text);
                updateNumber(dgvIjsjes.Rows.Count);
            }

        }

        private void dgvIjsjes_addGrid(string naam, string soort, string ingredient_1, string ingredient_2)
        {
            DataGridViewRow newIce = new DataGridViewRow();
            newIce.CreateCells(dgvIjsjes);
            newIce.Cells[0].Value = naam;
            newIce.Cells[1].Value = soort;
            newIce.Cells[2].Value = ingredient_1;
            newIce.Cells[3].Value = ingredient_2;
            dgvIjsjes.Rows.Add(newIce);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(number.Value - 1);
            if (dgvIjsjes.Rows.Count >= index && index > 0)
            {
                dgvIjsjes.Rows.RemoveAt(index);
                if (number.Maximum == number.Value)
                {
                    number.Value -= 1;
                }
                
            }
            else
            {
                errorMsg.Text = "Kan geen 0 zijn.";
            }


        }

        private void number_ValueChanged(object sender, EventArgs e)
        {
            updateNumber(dgvIjsjes.Rows.Count); 
        }

        private void updateNumber(int max)
        {
            number.Maximum = max;
        }
    }
}
