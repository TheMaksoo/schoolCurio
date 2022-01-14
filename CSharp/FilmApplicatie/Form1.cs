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
    public partial class dgvFilms : Form
    {
        public dgvFilms()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[,] films = { { "Star Wars: Episode IV: A New Hope", "1977","SciFi" }, { "Aliens", "1986", "Horror"}, { "The Silence of the Lambs", "1991", "Thriller" }, { "Die Hard", "1988","Actie "}, { "The Green Mile", "1999", "Drama" }, { "Avatar", "2009", "SciFi" }, { "Avenger: Infinity War", "2018", "Actie" } };
        }
    }
}
