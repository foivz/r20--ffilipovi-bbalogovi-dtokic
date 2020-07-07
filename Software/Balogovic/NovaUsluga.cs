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
using Vedrana.Tokic;

namespace Vedrana.Balogovic
{
    public partial class NovaUsluga : Form
    {
        DataTable dt = new DataTable();
        public NovaUsluga()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void NovaUsluga_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in Skladiste.DohvatiPopisSastojaka("Njega"))
                {
                    cbxNjega.Items.Add(item.GetType().GetProperty("Naziv").GetValue(item, null));
                }

                dt.Columns.Add("Naziv");
                dt.Columns.Add("Količina");
                dgvProizvodi.DataSource = dt;
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
                    row["Naziv"] = cbxNjega.SelectedItem.ToString();
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
                List<int> proizvodiId = new List<int>();
                List<double> kolicina = new List<double>();

                using (var context = new Entities())
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        var id = (from p in context.proizvods.AsEnumerable()
                                  where p.naziv == dt.Rows[i][0].ToString()
                                  select p.proizvodId).First();
                        proizvodiId.Add(id);
                        kolicina.Add(double.Parse(dt.Rows[i][1].ToString()));
                    }
                }

                new usluga(txtNaziv.Text, double.Parse(txtCijena.Text), txtOpis.Text, proizvodiId, kolicina);
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

        private void NovaUsluga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, Path.GetFullPath("StarackiDomVedranaHelp.chm"));
            }
        }
    }
}
