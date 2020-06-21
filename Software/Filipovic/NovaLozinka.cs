using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.KeyPreview = true;
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
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Progrešno upisana stara lozinka!");
                        Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Lozinke se ne poklapaju!");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Clear()
        {
            txtNovaLozinka.Text = "";
            txtPonovljena.Text = "";
            txtStaraLozinka.Text = "";
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NovaLozinka_Load(object sender, EventArgs e)
        {

        }

        private void NovaLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, Path.GetFullPath("StarackiDomVedranaHelp.chm"));
            }
        }
    }
}
