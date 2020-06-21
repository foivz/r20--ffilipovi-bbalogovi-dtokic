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

namespace Vedrana.Filipovic
{
    public partial class EvidencijaZaposlenika : Form
    {
        public EvidencijaZaposlenika()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void EvidencijaZaposlenika_Load(object sender, EventArgs e)
        {
            OsvjeziPopis();
        }
        private void OsvjeziPopis()
        {
            try
            {
                if (cbxFilter.Checked)
                {
                    btnOtpusti.Enabled = false;
                }
                else
                {
                    btnOtpusti.Enabled = true;
                }
                dgvZaposlenici.DataSource = null;
                dgvZaposlenici.DataSource = zaposlenik.PretragaZaposlenika(cbxFilter.Checked);
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

        private void btnOtpusti_Click(object sender, EventArgs e)
        {
            try
            {
                string oib = dgvZaposlenici.CurrentRow.Cells[0].Value.ToString();
                using (var context = new Entities())
                {
                    zaposlenik otpusti = (from z in context.zaposleniks
                                          where z.oib == oib
                                          select z).First<zaposlenik>();
                    otpusti.OtpustiZaposlenika(otpusti);
                    context.SaveChanges();
                }
                OsvjeziPopis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxFilter.Checked)
                {
                    btnOtpusti.Enabled = false;
                }
                else
                {
                    btnOtpusti.Enabled = true;
                }
                dgvZaposlenici.DataSource = null;
                dgvZaposlenici.DataSource = zaposlenik.PretragaZaposlenika(cbxFilter.Checked, txtIme.Text, txtPrezime.Text);
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

        private void btnNoviZaposlenik_Click(object sender, EventArgs e)
        {
            try
            {
                RegistracijaZaposlenika forma = new RegistracijaZaposlenika();
                forma.ShowDialog();
                OsvjeziPopis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EvidencijaZaposlenika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, Path.GetFullPath("StarackiDomVedranaHelp.chm"));
            }
        }
    }
}
