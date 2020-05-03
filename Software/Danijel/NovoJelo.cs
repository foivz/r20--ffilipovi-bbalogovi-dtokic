using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Danijel
{
    public partial class NovoJelo : Form
    {
        private DataTable dt = new DataTable();
        public NovoJelo()
        {
            InitializeComponent();
        }

        private void NovoJelo_Load(object sender, EventArgs e)
        {
            tipJela.Items.Add("Dorucak");
            tipJela.Items.Add("Rucak");
            tipJela.Items.Add("Uzina");
            tipJela.Items.Add("Vecera");

            foreach (Skladiste skladiste in Skladiste.DohvatiPopisSastojaka())
            {
                sastojakNaziv.Items.Add(skladiste.Naziv);
            }

            dt.Columns.Add("Naziv", typeof(string));
            dt.Columns.Add("Količina", typeof(int));
            popisSastojaka.DataSource = dt;
        }

        private void DodavanjeSastojka(string naziv, int kolicina)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == naziv)
                {
                    row[1] = int.Parse(row[1].ToString()) + kolicina;
                    return;
                }
            }
            DataRow row1 = dt.NewRow();
            row1[0] = naziv;
            row1[1] = kolicina;
            dt.Rows.Add(row1);
        }

        private void DodajSastojak_Click(object sender, EventArgs e)
        {
            string n = sastojakNaziv.SelectedItem.ToString();
            int kol = int.Parse(sastojakKolicina.Text);
            DodavanjeSastojka(n, kol);
        }

        private void DodajJelo_Click(object sender, EventArgs e)
        {
            string n = nazivJela.Text;
            string t = tipJela.SelectedItem.ToString();
            List<Proizvodi> listap = new List<Proizvodi>();
            List<int> listak = new List<int>();

            foreach (DataRow row in dt.Rows)
            {
                listap.Add(new Proizvodi(row[0].ToString(), "Sastojak"));
                listak.Add(int.Parse(row[1].ToString()));
            }
            
            Jela.NovoJelo(n,t,listap,listak);
            nazivJela.Text = "";
            tipJela.SelectedItem = null;
            dt.Rows.Clear();
            sastojakNaziv.SelectedItem = null;
            sastojakKolicina.Text = "";
        }
    }
}
