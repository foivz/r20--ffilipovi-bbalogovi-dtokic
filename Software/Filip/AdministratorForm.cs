using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vedrana.Filip
{
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            zaposlenici.DataSource = null;
            zaposlenici.DataSource = RegistriraneOsobe.popisOsoba;
        }

        private void noviZaposlenik_Click(object sender, EventArgs e)
        {
            NoviZaposlenik forma = new NoviZaposlenik();
            forma.ShowDialog();
            UcitajPodatke();
        }
    }
}
