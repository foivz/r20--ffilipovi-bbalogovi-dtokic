using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Filipovic
{
    public partial class ZaboravljenaLozinka : Form
    {
        public ZaboravljenaLozinka()
        {
            InitializeComponent();
        }
        private void ZaboravljenaLozinka_Load(object sender, EventArgs e)
        {

        }
        private void btnNovaLozinka_Click(object sender, EventArgs e)
        {
            try
            {
                zaposlenik.ZaboravljenaLozinka(txtEmail.Text, txtOIB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
