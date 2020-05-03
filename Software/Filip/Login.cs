using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vedrana.Filip;
using Vedrana.Branimir;
using Vedrana.Danijel;

namespace Vedrana
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistriraneOsobe.UcitajOsobe();
        }

        private void prijava_Click(object sender, EventArgs e)
        {
            RegistriraneOsobe prijava = RegistriraneOsobe.Autetifikacija(email.Text, sifra.Text);
            if (prijava != null)
            {
                if (prijava.Uloga == "Administrator")
                {
                    AdministratorForm forma = new AdministratorForm();
                    this.Hide();
                    forma.ShowDialog();
                }
                else if (prijava.Uloga == "Zaposlenik")
                {
                    ZaposlenikForma forma = new ZaposlenikForma();
                    this.Hide();
                    forma.ShowDialog();
                }
                else if (prijava.Uloga == "Kuhar")
                {
                    KuharForma forma = new KuharForma();
                    this.Hide();
                    forma.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Pogrešan email ili šifra");
            }
        }
    }
}
