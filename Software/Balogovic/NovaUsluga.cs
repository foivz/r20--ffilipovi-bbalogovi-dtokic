using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
