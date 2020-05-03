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
    public partial class JelaForma : Form
    {
        public JelaForma()
        {
            InitializeComponent();
        }

        private void JelaForma_Load(object sender, EventArgs e)
        {
            UcitajJela();
        }

        private void UcitajJela()
        {
            popisJela.DataSource = null;
            popisJela.DataSource = Jela.listaJela;
        }

        private void NovoJelo_Click(object sender, EventArgs e)
        {
            NovoJelo forma = new NovoJelo();
            this.Hide();
            forma.ShowDialog();
            UcitajJela();
            this.Show();
        }
    }
}
