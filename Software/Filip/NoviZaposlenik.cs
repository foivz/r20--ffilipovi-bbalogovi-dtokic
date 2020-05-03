using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Filip
{
    public partial class NoviZaposlenik : Form
    {
        public NoviZaposlenik()
        {
            InitializeComponent();
        }

        private void NoviZaposlenik_Load(object sender, EventArgs e)
        {
            uloge.Items.Add("Administrator");
            uloge.Items.Add("Zaposlenik");
        }

        private void dodajZaposlenika_Click(object sender, EventArgs e)
        {
            if (RegistriraneOsobe.NoviKorisnik(email.Text,ime.Text,prezime.Text,uloge.SelectedItem.ToString()))
            {
                MessageBox.Show("Uspješna registracija");
            }
            else
            {
                MessageBox.Show("Pogrešan unos");
            }
        }
    }
}
