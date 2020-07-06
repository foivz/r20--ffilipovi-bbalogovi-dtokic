using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Balogovic
{
    public partial class EvidentiraneNjege : Form
    {
        korisnik _korisnik = null;
        DataTable dt = new DataTable();
        public EvidentiraneNjege(korisnik kor)
        {
            InitializeComponent();
            _korisnik = kor;
            this.KeyPreview = true;
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

            dt.Columns.Add("Naziv usluge", typeof(string));
            dt.Columns.Add("Zaposlenik", typeof(string));
            dt.Columns.Add("Datum", typeof(DateTime));
            dt.Columns.Add("Napomena", typeof(string));
            UcitajTablicu();
        }
        private void UcitajTablicu()
        {
            try
            {
                using (var context = new Entities())
                {
                    var lista = evidencijaNjege.PretragaEvidencijaPoKorisnicima(_korisnik);
                    foreach (var item in lista)
                    {
                        DataRow row = dt.NewRow();
                        var query = from iu in context.imaUslugus
                                    where item.imaUsluguId == iu.imaUsluguId
                                    select iu.usluga.naziv;
                        row["Naziv usluge"] = query.First();
                        var query2 = from z in context.zaposleniks
                                     where z.oib == item.oib
                                     select z.osoba.ime + " " + z.osoba.prezime;
                        row["Zaposlenik"] = query2.First();
                        row["Datum"] = item.datum;
                        row["Napomena"] = item.napomena;
                        dt.Rows.Add(row);
                    }
                    dgvEvidentiraneNjege.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void EvidentiraneNjege_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, Path.GetFullPath("StarackiDomVedranaHelp.chm"));
            }
        }
    }
}
