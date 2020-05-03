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
    public partial class JelovniciForma : Form
    {
        public JelovniciForma()
        {
            InitializeComponent();
        }

        private void JelovniciForma_Load(object sender, EventArgs e)
        {
            UcitajPodatke();

            foreach (Jela jela in Jela.PopisJelaPoTipu("Dorucak"))
            {
                dorucak.Items.Add(jela.Naziv);
            }
            foreach (Jela jela in Jela.PopisJelaPoTipu("Rucak"))
            {
                rucak.Items.Add(jela.Naziv);
            }
            foreach (Jela jela in Jela.PopisJelaPoTipu("Uzina"))
            {
                uzina.Items.Add(jela.Naziv);
            }
            foreach (Jela jela in Jela.PopisJelaPoTipu("Vecera"))
            {
                vecera.Items.Add(jela.Naziv);
            }
        }

        private void UcitajPodatke()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Datum", typeof(DateTime));
            dt.Columns.Add("Dorucak", typeof(string));
            dt.Columns.Add("Rucak", typeof(string));
            dt.Columns.Add("Uzina", typeof(string));
            dt.Columns.Add("Vecera", typeof(string));

            foreach (Jelovnik jelovnik in Jelovnik.listaJelovnika)
            {
                DataRow row = dt.NewRow();
                row[0] = jelovnik.Datum.Date;
                row[1] = jelovnik.Dorucak.Naziv;
                row[2] = jelovnik.Rucak.Naziv;
                row[3] = jelovnik.Uzina.Naziv;
                row[4] = jelovnik.Vecera.Naziv;
                dt.Rows.Add(row);
            }

            popisJelovnika.DataSource = null;
            popisJelovnika.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jela jelovnikDorucak = Jela.PretraziJelaPoImenu(dorucak.SelectedItem.ToString());
            Jela jelovnikRucak = Jela.PretraziJelaPoImenu(rucak.SelectedItem.ToString());
            Jela jelovnikUzina = Jela.PretraziJelaPoImenu(uzina.SelectedItem.ToString());
            Jela jelovnikVecera = Jela.PretraziJelaPoImenu(vecera.SelectedItem.ToString());
            DateTime jelovnikDatum = datum.Value.Date;
            Jelovnik.NoviJelovnik(jelovnikDorucak, jelovnikRucak, jelovnikUzina, jelovnikRucak, jelovnikDatum);
            UcitajPodatke();
        }
    }
}
