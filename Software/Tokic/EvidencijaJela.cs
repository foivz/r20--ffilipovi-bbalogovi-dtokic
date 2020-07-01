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
    public partial class EvidencijaJela : Form
    {
        public EvidencijaJela()
        {
            InitializeComponent();
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
    }
}
