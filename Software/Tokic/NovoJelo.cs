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
    public partial class NovoJelo : Form
    {
        DataTable dt = new DataTable();
        public NovoJelo()
        {
            InitializeComponent();
        }

        private void NovoJelo_Load(object sender, EventArgs e)
        {
            try
            {
                cbxTip.Items.Add("Dorucak");
                cbxTip.Items.Add("Rucak");
                cbxTip.Items.Add("Uzina");
                cbxTip.Items.Add("Vecera");

                foreach (var item in Skladiste.DohvatiPopisSastojaka("Sastojak"))
                {
                    cbxSastojak.Items.Add(item.GetType().GetProperty("Naziv").GetValue(item, null));
                }

                dt.Columns.Add("Naziv");
                dt.Columns.Add("Količina");
                dgvSastojci.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajSastojak_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKolicina.Text == "")
                {
                    MessageBox.Show("Unesi količinu!");
                }
                else
                {
                    DataRow row = dt.NewRow();
                    row["Naziv"] = cbxSastojak.SelectedItem.ToString();
                    row["Količina"] = double.Parse(txtKolicina.Text);
                    dt.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> sastojciId = new List<int>();
                List<double> kolicina = new List<double>();

                using (var context = new Entities())
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var id = (from p in context.proizvods.AsEnumerable()
                                  where p.naziv == dt.Rows[i][0].ToString()
                                  select p.proizvodId).First();
                        sastojciId.Add(id);
                        kolicina.Add(double.Parse(dt.Rows[i][1].ToString()));
                    }
                }


                new jelo(txtNaziv.Text, cbxTip.SelectedItem.ToString(), sastojciId, kolicina);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
