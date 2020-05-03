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
    public partial class SkladisteForma : Form
    {
        public SkladisteForma()
        {
            InitializeComponent();
        }

        private void SkladisteForma_Load(object sender, EventArgs e)
        {
            podaciSkladista.DataSource = Skladiste.listaProizvodaUSkladistu;
        }
    }
}
