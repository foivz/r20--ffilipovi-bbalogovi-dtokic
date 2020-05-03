using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Branimir
{
    public partial class DetaljiKorisnika : Form
    {
        private Korisnici korisnik = null;

        public DetaljiKorisnika(Korisnici odabraniKorisnik)
        {
            InitializeComponent();
            korisnik = odabraniKorisnik;
        }

        private void DetaljiKorisnika_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            ime.Text = korisnik.Ime;
            prezime.Text = korisnik.Prezime;
            usluge.DataSource = korisnik.PopisUsluga;
        }
    }
}
