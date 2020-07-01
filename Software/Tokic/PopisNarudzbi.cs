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
    public partial class PopisNarudzbi : Form
    {
        public PopisNarudzbi()
        {
            InitializeComponent();
        }

        private void PopisNarudzbi_Load(object sender, EventArgs e)
        {
            try
            {
                dgvNarudzbe.DataSource = Skladiste.PopisNarucenihStvari();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
