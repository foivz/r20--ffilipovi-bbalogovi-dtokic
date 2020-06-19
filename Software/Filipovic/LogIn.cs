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
using Vedrana.Balogovic;
using Vedrana.Tokic;

namespace Vedrana.Filipovic
{
    public partial class LogIn : Form
    {
        public static zaposlenik _zaposlenik = null;
        public LogIn()
        {
            InitializeComponent();
        }
        private void LogIn_Load(object sender, EventArgs e)
        {
            
        }
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            try
            {
                _zaposlenik = zaposlenik.Autenfikacija(txtEmail.Text, txtSifra.Text);

                if (_zaposlenik != null)
                {
                    txtSifra.Text = "";
                    if (_zaposlenik.uloga == "Administrator")
                    {
                        this.Hide();
                        GlavniMeni forma = new GlavniMeni();
                        forma.ShowDialog();
                        this.Show();
                    }
                    else if (_zaposlenik.uloga == "")
                    {

                    }
                }
                else
                {
                    txtSifra.Text = "";
                    MessageBox.Show("Krivi podaci");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnZaboravljenaLozinka_Click(object sender, EventArgs e)
        {
            try
            {
                ZaboravljenaLozinka forma = new ZaboravljenaLozinka();
                forma.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
