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
    public partial class ZaboravljenaLozinka : Form
    {
        public ZaboravljenaLozinka()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnNovaLozinka_Click(object sender, EventArgs e)
        {
            try
            {
                zaposlenik.ZaboravljenaLozinka(txtEmail.Text, txtOIB.Text);
                MessageBox.Show("Lozinka je uspješno resetirana.");
                this.Close();
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

        private void ZaboravljenaLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, Path.GetFullPath("StarackiDomVedranaHelp.chm"));
            }
        }
    }
}
