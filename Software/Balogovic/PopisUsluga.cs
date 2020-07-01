using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Balogovic
{
    public partial class PopisUsluga : Form
    {
        public PopisUsluga()
        {
            InitializeComponent();
        }

        private void PopisUsluga_Load(object sender, EventArgs e)
        {
            OsvjeziPopis();
        }
        private void OsvjeziPopis()
        {
            try
            {
                dgvUsluge.DataSource = null;
                dgvUsluge.DataSource = usluga.PronadjiUsluguPoImenu();
                dgvUsluge.Columns[0].Visible = false;
                for (int i = 4; i < dgvUsluge.ColumnCount; i++)
                {
                    dgvUsluge.Columns[i].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
