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
    public partial class EvidentiraneNjege : Form
    {
        korisnik _korisnik = null;
        public EvidentiraneNjege(korisnik kor)
        {
            InitializeComponent();
            _korisnik = kor;
        }

        private void EvidentiraneNjege_Load(object sender, EventArgs e)
        {
            txtAdresa.Text = _korisnik.osoba.adresa;
            txtAlergije.Text = _korisnik.alergije;
            txtIme.Text = _korisnik.osoba.ime;
            txtKontakt.Text = _korisnik.osoba.kontakt;
            txtNapomene.Text = _korisnik.napomene;
            txtOIB.Text = _korisnik.oib;
            txtPrezime.Text = _korisnik.osoba.prezime;
            txtSoba.Text = _korisnik.brojSobe.ToString();
            dtpDatumRodjenja.Value = _korisnik.osoba.datumRodjenja.GetValueOrDefault();
        }
    }
}
