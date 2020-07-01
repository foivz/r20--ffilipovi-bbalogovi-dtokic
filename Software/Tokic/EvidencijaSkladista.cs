using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Tokic
{
    public partial class EvidencijaSkladista : Form
    {
        public EvidencijaSkladista()
        {
            InitializeComponent();
        }

        private void EvidencijaSkladista_Load(object sender, EventArgs e)
        {
            OsvjeziPodatke();
        }

        private void OsvjeziPodatke()
        {
            dgvSkladiste.DataSource = null;
            dgvSkladiste.DataSource = Skladiste.DohvatiPopisSastojaka();
        }

        private void btnNoviProizvod_Click(object sender, EventArgs e)
        {
            NoviProizvod forma = new NoviProizvod();
            forma.ShowDialog();
            OsvjeziPodatke();
        }

        private void btnNarudzbe_Click(object sender, EventArgs e)
        {
            PopisNarudzbi forma = new PopisNarudzbi();
            forma.ShowDialog();
        }

        private void statistikaBtn_Click(object sender, EventArgs e)
        {
            Statistika.Statistika report = new Statistika.Statistika();
            report.ShowDialog();
        }
    }
}
