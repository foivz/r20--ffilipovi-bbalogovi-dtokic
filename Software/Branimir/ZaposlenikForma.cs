using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Branimir
{
    public partial class ZaposlenikForma : Form
    {
        public ZaposlenikForma()
        {
            InitializeComponent();
            Usluge.UcitajUsluge();
            Korisnici.UcitajKorisnike();
        }

        private void ZaposlenikForma_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            korisnici.DataSource = null;
            korisnici.DataSource = Korisnici.popisKorisnika;
        }

        private void NoviKorisnik_Click(object sender, EventArgs e)
        {
            NoviKorisnik forma = new NoviKorisnik();
            forma.ShowDialog();
            UcitajPodatke();
        }

        private void korisnici_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Korisnici odabraniKorisnik = (Korisnici)korisnici.CurrentRow.DataBoundItem;
            DetaljiKorisnika forma = new DetaljiKorisnika(odabraniKorisnik);
            forma.ShowDialog();
        }
    }
}
