using Lib;
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
    public partial class UredjivanjeKorisnika : Form
    {
        korisnik trenutniKornisnik = null;
        List<imaUslugu> popisUsluga = new List<imaUslugu>();
        List<string> popisUslugaTablica = new List<string>();
        List<usluga> sveUsluge = usluga.PronadjiUsluguPoImenu();
        public UredjivanjeKorisnika(korisnik kor)
        {
            InitializeComponent();
            trenutniKornisnik = kor;
            this.KeyPreview = true;
        }

        private void UredjivanjeKorisnika_Load(object sender, EventArgs e)
        {
            try
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

                foreach (var susl in sveUsluge)
                {
                    bool pronasao = false;
                    foreach (var usl in trenutniKornisnik.imaUslugus)
                    {
                        if (susl.uslugaId == usl.uslugaId)
                        {
                            popisUslugaTablica.Add(susl.naziv);
                            pronasao = true;
                        }
                    }
                    if (!pronasao)
                    {
                        cbxUsluge.Items.Add(susl.naziv);
                    }
                }

                dgvPopisUsluga.DataSource = null;
                var result = popisUslugaTablica.Select(s => new { Usluga = s }).ToList();
                dgvPopisUsluga.DataSource = result;

                using (var context = new Entities())
                {
                    foreach (var item in trenutniKornisnik.imaUslugus)
                    {
                        popisUsluga.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajUslugu_Click(object sender, EventArgs e)
        {
            try
            {
                imaUslugu u = new imaUslugu();
                foreach (var usluga in sveUsluge)
                {
                    if (cbxUsluge.SelectedItem.ToString() == usluga.naziv)
                    {
                        u.uslugaId = usluga.uslugaId;
                    }
                }

                popisUslugaTablica.Add(cbxUsluge.SelectedItem.ToString());
                dgvPopisUsluga.DataSource = null;
                var result = popisUslugaTablica.Select(s => new { Usluga = s }).ToList();
                dgvPopisUsluga.DataSource = result;

                popisUsluga.Add(u);
                int i = cbxUsluge.SelectedIndex;
                cbxUsluge.Items.RemoveAt(i);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUkloniUslugu_Click(object sender, EventArgs e)
        {
            try
            {
                string odabrano = dgvPopisUsluga.CurrentRow.Cells[0].Value.ToString();

                cbxUsluge.Items.Add(odabrano);

                int id = -1;
                foreach (var item in sveUsluge)
                {
                    if (item.naziv == odabrano)
                    {
                        id = item.uslugaId;
                    }
                }
                foreach (var item in popisUsluga.ToList())
                {
                    if (item.uslugaId == id)
                    {
                        popisUsluga.Remove(item);
                    }
                }

                popisUslugaTablica.Remove(odabrano);

                dgvPopisUsluga.DataSource = null;
                var result = popisUslugaTablica.Select(s => new { Usluga = s }).ToList();
                dgvPopisUsluga.DataSource = result;
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

        private void bntUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var usluga in popisUsluga)
                {
                    usluga.oib = txtOIB.Text;
                }
                trenutniKornisnik.UredjivanjePodataka(
                    txtKontakt.Text,
                    int.Parse(txtSoba.Text),
                    txtNapomene.Text,
                    popisUsluga);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UredjivanjeKorisnika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, Path.GetFullPath("StarackiDomVedranaHelp.chm"));
            }
        }
    }
}
