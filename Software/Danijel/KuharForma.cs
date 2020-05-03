using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Danijel
{
    public partial class KuharForma : Form
    {
        public KuharForma()
        {
            InitializeComponent();
        }

        private void KuharForma_Load(object sender, EventArgs e)
        {
            Danijel.Skladiste.UcitajSkladiste();
            Danijel.Jela.UcitajJela();
            Jelovnik.UcitajJelovnike();
            danasnjiJelovnik.DataSource = Jelovnik.DanasnjiJelovnik();
        }

        private void Jela_Click(object sender, EventArgs e)
        {
            JelaForma forma = new JelaForma();
            forma.ShowDialog();
        }

        private void Jelovnici_Click(object sender, EventArgs e)
        {
            JelovniciForma forma = new JelovniciForma();
            forma.ShowDialog();
        }

        private void Skladiste_Click(object sender, EventArgs e)
        {
            SkladisteForma forma = new SkladisteForma();
            forma.ShowDialog();
        }
    }
}
