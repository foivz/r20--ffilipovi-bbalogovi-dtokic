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

namespace Vedrana.Filipovic
{
    public partial class RegistracijaZaposlenika : Form
    {
        public RegistracijaZaposlenika()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void RegistracijaZaposlenika_Load(object sender, EventArgs e)
        {
            cmbUloga.Items.Add("Administrator");
            cmbUloga.Items.Add("Kuhar");
            cmbUloga.Items.Add("Njegovatelj");
        }

        private void btnRegistriraj_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Entities())
                {
                    zaposlenik noviZaposlenik = new zaposlenik(
                        txtEmail.Text,
                        txtOIB.Text,
                        txtIme.Text,
                        txtPrezime.Text,
                        txtAdresa.Text,
                        txtKontakt.Text,
                        dtpDatumRodjenja.Value,
                        cmbUloga.SelectedItem.ToString());
                    context.zaposleniks.Add(noviZaposlenik);
                    context.SaveChanges();
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
            this.Close();
        }

        private void RegistracijaZaposlenika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, Path.GetFullPath("StarackiDomVedranaHelp.chm"));
            }
        }
    }
}
