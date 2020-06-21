using Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Tokic
{
    public partial class EvidencijaJela : Form
    {
        public EvidencijaJela()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void EvidencijaJela_Load(object sender, EventArgs e)
        {
            cbxTipJela.Items.Add("Dorucak");
            cbxTipJela.Items.Add("Rucak");
            cbxTipJela.Items.Add("Uzina");
            cbxTipJela.Items.Add("Vecera");
            OsvjeziPodatke();
        }

        private void OsvjeziPodatke()
        {
            try
            {
                dgvJela.DataSource = null;
                dgvJela.DataSource = jelo.PretraziJelaPoImenu();
                dgvJela.Columns[0].Visible = false;
                for (int i = 3; i < dgvJela.ColumnCount; i++)
                {
                    dgvJela.Columns[i].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFiltrirajTip_Click(object sender, EventArgs e)
        {
            try
            {
                dgvJela.DataSource = null;
                dgvJela.DataSource = jelo.PopisJelaPoTipu(cbxTipJela.SelectedItem.ToString());
                dgvJela.Columns[0].Visible = false;
                for (int i = 3; i < dgvJela.ColumnCount; i++)
                {
                    dgvJela.Columns[i].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFiltrirajIme_Click(object sender, EventArgs e)
        {
            try
            {
                dgvJela.DataSource = null;
                dgvJela.DataSource = jelo.PretraziJelaPoImenu(txtImeJela.Text);
                dgvJela.Columns[0].Visible = false;
                for (int i = 3; i < dgvJela.ColumnCount; i++)
                {
                    dgvJela.Columns[i].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoJelo_Click(object sender, EventArgs e)
        {
            NovoJelo forma = new NovoJelo();
            forma.ShowDialog();
            OsvjeziPodatke();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Entities())
                {
                    string jelo = dgvJela.CurrentRow.Cells[0].Value.ToString();

                    var zaBrisat = from j in context.jeloes.AsEnumerable()
                                   where j.jeloId == int.Parse(jelo)
                                   select j;
                    context.Entry(zaBrisat.First()).State = EntityState.Deleted;
                    context.SaveChanges();
                    OsvjeziPodatke();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EvidencijaJela_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, Path.GetFullPath("StarackiDomVedranaHelp.chm"));
            }
        }
    }
}
