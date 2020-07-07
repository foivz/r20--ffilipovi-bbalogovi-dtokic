using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void RegistracijaZaposlenika_Load(object sender, EventArgs e)
        {
            cmbUloga.Items.Add("Admin");
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
    }
}
