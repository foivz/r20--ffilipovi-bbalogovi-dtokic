﻿using System;
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
    public partial class IzradaJelovnika : Form
    {
        public IzradaJelovnika()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void IzradaJelovnika_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in jelo.PopisJelaPoTipu("Dorucak"))
                {
                    cbxDorucak.Items.Add(item.naziv);
                }
                foreach (var item in jelo.PopisJelaPoTipu("Rucak"))
                {
                    cbxRucak.Items.Add(item.naziv);
                }
                foreach (var item in jelo.PopisJelaPoTipu("Uzina"))
                {
                    cbxUzina.Items.Add(item.naziv);
                }
                foreach (var item in jelo.PopisJelaPoTipu("Vecera"))
                {
                    cbxVecera.Items.Add(item.naziv);
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
                using (var context = new Entities())
                {
                    jelo d = jelo.PretraziJelaPoImenu(cbxDorucak.SelectedItem.ToString()).First();
                    jelo r = jelo.PretraziJelaPoImenu(cbxRucak.SelectedItem.ToString()).First();
                    jelo u = jelo.PretraziJelaPoImenu(cbxUzina.SelectedItem.ToString()).First();
                    jelo v = jelo.PretraziJelaPoImenu(cbxVecera.SelectedItem.ToString()).First();

                    new jelovnik(d, r, u, v, dtpDatum.Value, chbPoseban.Checked);
                    Close();
                }
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

        private void IzradaJelovnika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, Path.GetFullPath("StarackiDomVedranaHelp.chm"));
            }
        }
    }
}
