using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vedrana.Balogovic;
using Vedrana.Filipovic;
using Vedrana.Tokic;

namespace Vedrana
{
    public partial class GlavniMeni : Form
    {
        private Form aktivnaForma = null;

        public GlavniMeni()
        {
            InitializeComponent();
        }

        private void GlavniMeni_Load(object sender, EventArgs e)
        {
            prikaziNavigaciju();
        }

        private void prikaziNavigaciju()
        {
            if (LogIn._zaposlenik.uloga != "Administrator")
            {
                zaposleniciBtn.Visible = false;
            }
            userBtn.Text = LogIn._zaposlenik.email;

            korisniciPnl.Visible = false;
            jelovniciPnl.Visible = false;
            userPnl.Visible = false;

            otvoriFormu(new Pocetna());
        }

        private void sakrijPanel()
        {
            if (korisniciPnl.Visible == true)
                korisniciPnl.Visible = false;
            if (jelovniciPnl.Visible == true)
                jelovniciPnl.Visible = false;
            if (userPnl.Visible == true)
            {
                userPnl.Visible = false;
                userBtn.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            }
        }

        private void prikaziPanel(Panel meni)
        {
            if (meni.Visible == false)
            {
                sakrijPanel();
                meni.Visible = true;
            }
            else
                meni.Visible = false;
        }

        private void otvoriFormu(Form forma)
        {
            if (aktivnaForma != null)
                aktivnaForma.Close();
            aktivnaForma = forma;
            forma.TopLevel = false;
            forma.FormBorderStyle = FormBorderStyle.None;
            forma.Dock = DockStyle.Fill;
            formPanel.Controls.Add(forma);
            formPanel.Tag = forma;
            forma.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sakrijPanel();
            aktivniMeniIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            aktivniMeniLbl.Text = "Početna stranica";
            // otvori početnu forma
            otvoriFormu(new Pocetna());
        }

        private void zaposleniciBtn_Click(object sender, EventArgs e)
        {
            sakrijPanel();
            aktivniMeniIcon.IconChar = FontAwesome.Sharp.IconChar.UserNurse;
            aktivniMeniLbl.Text = "Zaposlenici";
            // otvori formu evidencije zaposlenika
            // otvoriFormu();
        }

        private void korisniciBtn_Click(object sender, EventArgs e)
        {
            sakrijPanel();
            prikaziPanel(korisniciPnl);
            aktivniMeniIcon.IconChar = FontAwesome.Sharp.IconChar.NotesMedical;
            aktivniMeniLbl.Text = "Korisnici";
            // otvori formu evidencije korisnika
            otvoriFormu(new EvidencijaKorisnika(LogIn._zaposlenik));
        }

        private void uslugeBtn_Click(object sender, EventArgs e)
        {
            aktivniMeniLbl.Text = "Korisnici > Usluge";
            // otvori formu popisa usluga
            otvoriFormu(new PopisUsluga());
        }

        private void skladisteBtn_Click(object sender, EventArgs e)
        {
            sakrijPanel();
            aktivniMeniIcon.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            aktivniMeniLbl.Text = "Skladište";
            // otvori formu evidencije skladišta
            otvoriFormu(new EvidencijaSkladista());
        }

        private void jelovniciBtn_Click(object sender, EventArgs e)
        {
            sakrijPanel();
            prikaziPanel(jelovniciPnl);
            aktivniMeniIcon.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            aktivniMeniLbl.Text = "Jelovnici";
            // otvori formu evidencije jelovnika
            otvoriFormu(new EvidencijaJelovnika());
        }

        private void jelaBtn_Click(object sender, EventArgs e)
        {
            aktivniMeniLbl.Text = "Jelovnici > Jela";
            // otvori formu evidencije jela
            otvoriFormu(new EvidencijaJela());
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            if (userPnl.Visible == true)
            {
                userPnl.Visible = false;
                userBtn.IconChar = FontAwesome.Sharp.IconChar.ChevronDown;
            }
            else
            {
                userPnl.Visible = true;
                userBtn.IconChar = FontAwesome.Sharp.IconChar.ChevronUp;
            }
        }

        private void promijeniPassBtn_Click(object sender, EventArgs e)
        {
            sakrijPanel();
            aktivniMeniIcon.IconChar = FontAwesome.Sharp.IconChar.Key;
            aktivniMeniLbl.Text = "Promjena zaporke";
            // otvori formu promjene zaporke
            // otvoriFormu();
        }

        private void odjavaBtn_Click(object sender, EventArgs e)
        {
            LogIn._zaposlenik = null;
            this.Close();
        }
    }
}
