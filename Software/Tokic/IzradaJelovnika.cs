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
    public partial class IzradaJelovnika : Form
    {
        public IzradaJelovnika()
        {
            InitializeComponent();
        }

        private void IzradaJelovnika_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in jelo.PopisJelaPoTipu("Dorucak"))
                {
                    cbxDorucak.Items.Add(item.naziv);
                }
                foreach (var item in jelo.PopisJelaPoTipu("Rucak"))
                {
                    cbxRucak.Items.Add(item.naziv);
                }
                foreach (var item in jelo.PopisJelaPoTipu("Uzina"))
                {
                    cbxUzina.Items.Add(item.naziv);
                }
                foreach (var item in jelo.PopisJelaPoTipu("Vecera"))
                {
                    cbxVecera.Items.Add(item.naziv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
