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
    public partial class EvidencijaKorisnika : Form
    {
        zaposlenik _zaposlenik = null;
        public EvidencijaKorisnika(zaposlenik zap)
        {
            InitializeComponent();
            _zaposlenik = zap;
        }

        private void EvidencijaKorisnika_Load(object sender, EventArgs e)
        {
            OsvjeziPopis();
        }

        private void OsvjeziPopis()
        {
            try
            {
                if (cbxFilter.Checked)
                {
                    btnUkloni.Enabled = false;
                    btnUrediKorisnika.Enabled = false;
                    btnEvidentirajNjegu.Enabled = false;
                }
                else
                {
                    btnUkloni.Enabled = true;
                    btnUrediKorisnika.Enabled = true;
                    btnEvidentirajNjegu.Enabled = true;
                }
                dgvKorisnici.DataSource = null;
                dgvKorisnici.DataSource = korisnik.PretragaKorisnika(cbxFilter.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
