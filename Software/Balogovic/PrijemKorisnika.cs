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
    public partial class PrijemKorisnika : Form
    {
        List<imaUslugu> popisUsluga = new List<imaUslugu>();
        List<string> popisUslugaTablica = new List<string>();
        List<usluga> sveUsluge = usluga.PronadjiUsluguPoImenu();
        public PrijemKorisnika()
        {
            InitializeComponent();
        }

        private void PrijemKorisnika_Load(object sender, EventArgs e)
        {
            OsvjeziPopis();
        }
        private void OsvjeziPopis()
        {
            try
            {
                cbxUsluge.Items.Clear();
                foreach (var usluga in sveUsluge)
                {
                    cbxUsluge.Items.Add(usluga.naziv);
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

        private void bntUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var usluga in popisUsluga)
                {
                    usluga.oib = txtOIB.Text;
                }
                using (var context = new Entities())
                {
                    korisnik noviKorisnik = new korisnik(
                        txtIme.Text,
                        txtPrezime.Text,
                        txtOIB.Text,
                        txtAdresa.Text,
                        dtpDatumRodjenja.Value,
                        txtKontakt.Text,
                        int.Parse(txtSoba.Text),
                        popisUsluga,
                        txtAlergije.Text,
                        txtNapomene.Text);
                    context.SaveChanges();

                    //ugovor

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
