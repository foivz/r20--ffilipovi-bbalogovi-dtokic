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
    public partial class EvidencijaNjege : Form
    {
        korisnik _korisnik = null;
        zaposlenik _zaposlenik = null;

        List<imaUslugu> popisUsluga = new List<imaUslugu>();
        List<string> popisUslugaTablica = new List<string>();
        List<usluga> sveUsluge = usluga.PronadjiUsluguPoImenu();

        DataTable dt = new DataTable();
        List<string> popisNapomenaZaEvidentirat = new List<string>();
        public EvidencijaNjege(korisnik kor, zaposlenik zap)
        {
            InitializeComponent();
            _korisnik = kor;
            _zaposlenik = zap;
        }

        private void EvidencijaNjege_Load(object sender, EventArgs e)
        {
            try
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

                foreach (var susl in sveUsluge)
                {
                    foreach (var usl in _korisnik.imaUslugus)
                    {
                        if (susl.uslugaId == usl.uslugaId)
                        {
                            popisUslugaTablica.Add(susl.naziv);
                        }
                    }
                }

                dgvPopisUsluga.DataSource = null;
                var result = popisUslugaTablica.Select(s => new { Usluga = s }).ToList();
                dgvPopisUsluga.DataSource = result;

                dt.Columns.Add("Usluga", typeof(string));
                dt.Columns.Add("Napomena", typeof(string));
                dgvEvidentiraneUsluge.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEvidentiraj_Click(object sender, EventArgs e)
        {
            try
            {
                int id = 0;
                string uslNaziv = dgvPopisUsluga.CurrentRow.Cells[0].Value.ToString();
                foreach (var usl in sveUsluge)
                {
                    if (usl.naziv == uslNaziv)
                    {
                        id = usl.uslugaId;
                    }
                }
                using (var context = new Entities())
                {
                    var imauslugu = from iU in context.imaUslugus
                                    where iU.uslugaId == id
                                    && iU.oib == _korisnik.oib
                                    select iU;
                    popisUsluga.Add(imauslugu.First());
                    popisNapomenaZaEvidentirat.Add(txtNapomenaEvidencije.Text);
                }
                DataRow row = dt.NewRow();
                row["Usluga"] = uslNaziv;
                row["Napomena"] = txtNapomenaEvidencije.Text;
                dt.Rows.Add(row);
                txtNapomenaEvidencije.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bntUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Entities())
                {
                    for (int i = 0; i < popisUsluga.Count(); i++)
                    {
                        evidencijaNjege ev = new evidencijaNjege(
                            popisUsluga[i],
                            _korisnik,
                            _zaposlenik,
                            popisNapomenaZaEvidentirat[i]);
                        context.evidencijaNjeges.Add(ev);
                        context.SaveChanges();
                    }
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
