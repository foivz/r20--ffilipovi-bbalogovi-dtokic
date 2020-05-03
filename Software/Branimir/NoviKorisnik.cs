using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Branimir
{
    public partial class NoviKorisnik : Form
    {
        public NoviKorisnik()
        {
            InitializeComponent();
        }

        private void NoviKorisnik_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Naziv Usluge", typeof(string)));
            dt.Columns.Add(new DataColumn("Aktivno", typeof(bool)));

            foreach (Usluge usluge in Usluge.popisUsluga)
            {
                DataRow workRow = dt.NewRow();
                workRow[0] = usluge.NazivUsluge;
                workRow[1] = false;
                dt.Rows.Add(workRow);
            }

            usluge.DataSource = null;
            usluge.DataSource = dt;
        }

        private void DodajKorisnika_Click(object sender, EventArgs e)
        {
            List<Usluge> noveUsluge = new List<Usluge>();
            
            foreach (DataGridViewRow dgvr in usluge.Rows)
            {
                if ((bool)dgvr.Cells["Aktivno"].Value)
                {
                    noveUsluge.Add(Usluge.PronadjiUsluguPoImenu(dgvr.Cells["Naziv Usluge"].Value.ToString()));
                }
            }
            
            Korisnici.NoviKorisnik(ime.Text, prezime.Text, noveUsluge);
        }
    }
}
