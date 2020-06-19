using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Tokic
{
    public partial class EvidencijaJelovnika : Form
    {
        public EvidencijaJelovnika()
        {
            InitializeComponent();
        }

        private void EvidencijaJelovnika_Load(object sender, EventArgs e)
        {
            OsvjeziPodatke();
        }

        private void OsvjeziPodatke()
        {
            try
            {
                var danasnjiN = jelovnik.DanasnjiJelovnik().Item1;
                var danasnjiP = jelovnik.DanasnjiJelovnik().Item2;
                if (danasnjiN != null)
                {
                    foreach (var item in danasnjiN)
                    {
                        if (item.tipJela == "Dorucak")
                            txtDorucak.Text = item.naziv;
                        else if (item.tipJela == "Rucak")
                            txtRucak.Text = item.naziv;
                        else if (item.tipJela == "Uzina")
                            txtUzina.Text = item.naziv;
                        else if (item.tipJela == "Vecera")
                            txtVecera.Text = item.naziv;
                    }
                }
                if (danasnjiP != null)
                {
                    foreach (var item in danasnjiP)
                    {
                        if (item.tipJela == "Dorucak")
                            txtDorucakP.Text = item.naziv;
                        else if (item.tipJela == "Rucak")
                            txtRucakP.Text = item.naziv;
                        else if (item.tipJela == "Uzina")
                            txtUzinaP.Text = item.naziv;
                        else if (item.tipJela == "Vecera")
                            txtVeceraP.Text = item.naziv;
                    }
                }

                DataTable dt = new DataTable();
                dt.Columns.Add("Doručak", typeof(string));
                dt.Columns.Add("Ručak", typeof(string));
                dt.Columns.Add("Užina", typeof(string));
                dt.Columns.Add("Večera", typeof(string));
                dt.Columns.Add("Datum", typeof(DateTime));
                dt.Columns.Add("Poseban", typeof(string));

                var sve = jelovnik.SviJelovnici();
                foreach (var jlvnk in sve.Item1)
                {
                    DataRow row = dt.NewRow();
                    foreach (var item in jlvnk.ToList())
                    {
                        if (item.tipJela == "Dorucak")
                            row["Doručak"] = item.naziv;
                        else if (item.tipJela == "Rucak")
                            row["Ručak"] = item.naziv;
                        else if (item.tipJela == "Uzina")
                            row["Užina"] = item.naziv;
                        else if (item.tipJela == "Vecera")
                            row["Večera"] = item.naziv;
                    }
                    dt.Rows.Add(row);
                }
                for (int i = 0; i < sve.Item2.Count(); i++)
                {
                    dt.Rows[i]["Datum"] = sve.Item2[i].Date;
                    if (sve.Item3[i])
                    {
                        dt.Rows[i]["Poseban"] = "Da";
                    }
                    else
                    {
                        dt.Rows[i]["Poseban"] = "Ne";
                    }
                }

                DataView dv = dt.DefaultView;
                dv.Sort = "Datum asc";
                dt = dv.ToTable();
                dgvJelovnici.DataSource = null;
                dgvJelovnici.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNoviJelovnik_Click(object sender, EventArgs e)
        {
            IzradaJelovnika forma = new IzradaJelovnika();
            forma.ShowDialog();
            OsvjeziPodatke();
        }

        private void btnUrediJelovnik_Click(object sender, EventArgs e)
        {
            using (var context = new Entities())
            {
                var datum = DateTime.Parse(dgvJelovnici.CurrentRow.Cells[4].Value.ToString());
                var poseban = dgvJelovnici.CurrentRow.Cells[5].Value.ToString();
                bool p = false;
                if (poseban == "Da")
                    p = true;

                var jelovnik = (from j in context.jelovniks.AsEnumerable()
                                where j.datum.Value.Date == datum.Date
                                && j.posebanJelovnik == Convert.ToByte(p)
                                select j).First();
                Console.WriteLine(p);
                Console.WriteLine(datum.Date);
                UredjivanjeJelovnika forma = new UredjivanjeJelovnika(jelovnik);
                forma.ShowDialog();
                OsvjeziPodatke();
            }
        }
    }
}
