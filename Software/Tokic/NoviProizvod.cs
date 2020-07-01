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

namespace Vedrana.Tokic
{
    public partial class NoviProizvod : Form
    {
        public NoviProizvod()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void NoviProizvod_Load(object sender, EventArgs e)
        {
            cbxTip.Items.Add("Sastojak");
            cbxTip.Items.Add("Za njegu");
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKolicina.Text == "")
                {
                    new proizvod(txtNaziv.Text, cbxTip.SelectedItem.ToString());
                }
                else
                {
                    new proizvod(txtNaziv.Text, cbxTip.SelectedItem.ToString(), double.Parse(txtKolicina.Text));
                }
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

        private void NoviProizvod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, Path.GetFullPath("StarackiDomVedranaHelp.chm"));
            }
        }
    }
}
