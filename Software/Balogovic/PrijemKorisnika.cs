using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Balogovic
{
    public partial class PrijemKorisnika : Form
    {
        List<usluga> sveUsluge = usluga.PronadjiUsluguPoImenu();
        public PrijemKorisnika()
        {
            InitializeComponent();
        }

        private void PrijemKorisnika_Load(object sender, EventArgs e)
        {
            OsvjeziPopis();
        }
        private void OsvjeziPopis()
        {
            try
            {
                cbxUsluge.Items.Clear();
                foreach (var usluga in sveUsluge)
                {
                    cbxUsluge.Items.Add(usluga.naziv);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
