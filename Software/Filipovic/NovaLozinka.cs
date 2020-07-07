using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Filipovic
{
    public partial class NovaLozinka : Form
    {
        zaposlenik _zaposlenik = null;

        public NovaLozinka(zaposlenik zap)
        {
            InitializeComponent();
            _zaposlenik = zap;
        }

        private void ClearInput()
        {
            txtNovaLozinka.Text = "";
            txtPonovljena.Text = "";
            txtStaraLozinka.Text = "";
        }

        private void btnPromjeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNovaLozinka.Text == txtPonovljena.Text)
                {
                    if (_zaposlenik.lozinka == txtStaraLozinka.Text)
                    {
                        _zaposlenik.PromjenaLozinke(txtNovaLozinka.Text);
                        MessageBox.Show("Uspješno promjenjena lozinka!");
                        ClearInput();
                    }
                    else
                    {
                        MessageBox.Show("Progrešno upisana stara lozinka!");
                        ClearInput();
                    }
                }
                else
                {
                    MessageBox.Show("Lozinke se ne poklapaju!");
                    ClearInput();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
