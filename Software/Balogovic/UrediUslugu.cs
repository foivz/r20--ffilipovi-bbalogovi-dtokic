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

namespace Vedrana.Balogovic
{
    public partial class UrediUslugu : Form
    {
        usluga _usluga = null;
        public UrediUslugu(usluga usl)
        {
            InitializeComponent();
            _usluga = usl;
            this.KeyPreview = true;
        }

        private void UrediUslugu_Load(object sender, EventArgs e)
        {
            try
            {
                txtCijena.Text = _usluga.cijena.ToString();
                txtNaziv.Text = _usluga.naziv;
                txtOpis.Text = _usluga.opis;
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

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                _usluga.PromjenaCijeneUsluge(double.Parse(txtCijena.Text));
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UrediUslugu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, Path.GetFullPath("StarackiDomVedranaHelp.chm"));
            }
        }
    }
}
