using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Balogovic
{
    public partial class EvidencijaKorisnika : Form
    {
        zaposlenik _zaposlenik = null;
        public EvidencijaKorisnika(zaposlenik zap)
        {
            InitializeComponent();
            _zaposlenik = zap;
            this.KeyPreview = true;
        }

        private void EvidencijaKorisnika_Load(object sender, EventArgs e)
        {
            OsvjeziPopis();
        }
        private void OsvjeziPopis()
        {
            try
            {
                if (cbxFilter.Checked)
                {
                    btnUkloni.Enabled = false;
                    btnUrediKorisnika.Enabled = false;
                    btnEvidentirajNjegu.Enabled = false;
                }
                else
                {
                    btnUkloni.Enabled = true;
                    btnUrediKorisnika.Enabled = true;
                    btnEvidentirajNjegu.Enabled = true;
                }
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnik.PretragaKorisnika(cbxFilter.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNoviKorisnik_Click(object sender, EventArgs e)
        {
            PrijemKorisnika forma = new PrijemKorisnika();
            forma.ShowDialog();
            OsvjeziPopis();
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            try
            {
                string oib = dgvKorisnici.CurrentRow.Cells[0].Value.ToString();
                using (var context = new Entities())
                {
                    korisnik ukloni = (from k in context.korisniks
                                       where k.oib == oib
                                       select k).First<korisnik>();
                    ukloni.MakniKorisnika(ukloni);
                    context.SaveChanges();
                }
                OsvjeziPopis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMakniFiltere_Click(object sender, EventArgs e)
        {
            OsvjeziPopis();
            txtPrezime.Text = "";
            txtIme.Text = "";
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxFilter.Checked)
                {
                    btnUkloni.Enabled = false;
                    btnUrediKorisnika.Enabled = false;
                    btnEvidentirajNjegu.Enabled = false;
                }
                else
                {
                    btnUkloni.Enabled = true;
                    btnUrediKorisnika.Enabled = true;
                    btnEvidentirajNjegu.Enabled = true;
                }
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnik.PretragaKorisnika(cbxFilter.Checked, txtIme.Text, txtPrezime.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxFilter_CheckedChanged(object sender, EventArgs e)
        {
            OsvjeziPopis();
        }

        private void btnUrediKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                string oib = dgvKorisnici.CurrentRow.Cells[0].Value.ToString();
                using (var context = new Entities())
                {
                    korisnik uredi = (from k in context.korisniks
                                      where k.oib == oib
                                      select k).First<korisnik>();
                    UredjivanjeKorisnika forma = new UredjivanjeKorisnika(uredi);
                    forma.ShowDialog();
                    OsvjeziPopis();
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEvidentirajNjegu_Click(object sender, EventArgs e)
        {
            try
            {
                string oib = dgvKorisnici.CurrentRow.Cells[0].Value.ToString();
                using (var context = new Entities())
                {
                    korisnik evidentiraj = (from k in context.korisniks
                                            where k.oib == oib
                                            select k).First<korisnik>();
                    EvidencijaNjege forma = new EvidencijaNjege(evidentiraj, _zaposlenik);
                    forma.ShowDialog();
                    OsvjeziPopis();
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEvidentiraneNjege_Click(object sender, EventArgs e)
        {
            try
            {
                string oib = dgvKorisnici.CurrentRow.Cells[0].Value.ToString();
                using (var context = new Entities())
                {
                    korisnik uredi = (from k in context.korisniks
                                      where k.oib == oib
                                      select k).First<korisnik>();
                    EvidentiraneNjege forma = new EvidentiraneNjege(uredi);
                    forma.ShowDialog();
                    OsvjeziPopis();
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EvidencijaKorisnika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, Path.GetFullPath("StarackiDomVedranaHelp.chm"));
            }
        }
    }
}
