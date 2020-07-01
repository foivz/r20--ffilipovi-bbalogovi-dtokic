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
            this.KeyPreview = true;
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

        private void PopisNarudzbi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, Path.GetFullPath("StarackiDomVedranaHelp.chm"));
            }
        }
    }
}
