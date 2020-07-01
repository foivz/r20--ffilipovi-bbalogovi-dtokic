using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Filipovic
{
    public partial class ZaboravljenaLozinka : Form
    {
        public ZaboravljenaLozinka()
        {
            InitializeComponent();
        }

        private void btnNovaLozinka_Click(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
