using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Balogovic
{
    public partial class UredjivanjeKorisnika : Form
    {
        korisnik trenutniKornisnik = null;
        public UredjivanjeKorisnika(korisnik kor)
        {
            InitializeComponent();
            trenutniKornisnik = kor;
        }

        private void UredjivanjeKorisnika_Load(object sender, EventArgs e)
        {
            txtAdresa.Text = trenutniKornisnik.osoba.adresa;
            txtAlergije.Text = trenutniKornisnik.alergije;
            txtIme.Text = trenutniKornisnik.osoba.ime;
            txtKontakt.Text = trenutniKornisnik.osoba.kontakt;
            txtNapomene.Text = trenutniKornisnik.napomene;
            txtOIB.Text = trenutniKornisnik.oib;
            txtPrezime.Text = trenutniKornisnik.osoba.prezime;
            txtSoba.Text = trenutniKornisnik.brojSobe.ToString();
            dtpDatumRodjenja.Value = trenutniKornisnik.osoba.datumRodjenja.GetValueOrDefault();
        }
    }
}
