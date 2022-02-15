using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmApplicatie
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[,] films = { { "Star Wars: Episode IV: A New Hope", "1977", "SciFi" }, { "Aliens", "1986", "Horror" }, { "The Silence of the Lambs", "1991", "Thriller" }, { "Die Hard", "1988", "Actie " }, { "The Green Mile", "1999", "Drama" }, { "Avatar", "2009", "SciFi" }, { "Avenger: Infinity War", "2018", "Actie" } };
            int aantalRijen = films.GetLength(0);
            int aantalKolommen = films.GetLength (1);

            dgvFilms.RowHeadersVisible = false;
            dgvFilms.AllowUserToAddRows = false;
            dgvFilms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvFilms.ColumnCount = aantalKolommen;
            dgvFilms.Columns[0].HeaderText = "Titel";
            dgvFilms.Columns[1].HeaderText = "Jaar";
            dgvFilms.Columns[1].HeaderText = "Genre";


            for (int r = 0; r < aantalRijen; r++)
            {
                DataGridViewRow dataRij = new DataGridViewRow();
                dataRij.CreateCells(dgvFilms);

                for (int k = 0; k < aantalKolommen; k++)
                {
                    dataRij.Cells[k].Value = films[r, k];
                }

                dgvFilms.Rows.Add(dataRij);
            }
        }
    }
}
