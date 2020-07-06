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
    public partial class UredjivanjeJelovnika : Form
    {
        jelovnik _jelovnik = null;
        public UredjivanjeJelovnika(jelovnik jel)
        {
            InitializeComponent();
            this.KeyPreview = true;
            _jelovnik = jel;
        }

        private void UredjivanjeJelovnika_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Entities())
                {
                    int di = 0, ri = 0, ui = 0, vi = 0;
                    List<jelo> d = jelo.PopisJelaPoTipu("Dorucak");
                    List<jelo> r = jelo.PopisJelaPoTipu("Rucak");
                    List<jelo> u = jelo.PopisJelaPoTipu("Uzina");
                    List<jelo> v = jelo.PopisJelaPoTipu("Vecera");
                    var dj = (from sn in context.seNalazis
                              where _jelovnik.jelovnikId == sn.jelovnikId
                              && sn.jelo.tipJela == "Dorucak"
                              select sn).First();
                    var rj = (from sn in context.seNalazis
                              where _jelovnik.jelovnikId == sn.jelovnikId
                              && sn.jelo.tipJela == "Rucak"
                              select sn).First();
                    var uj = (from sn in context.seNalazis
                              where _jelovnik.jelovnikId == sn.jelovnikId
                              && sn.jelo.tipJela == "Uzina"
                              select sn).First();
                    var vj = (from sn in context.seNalazis
                              where _jelovnik.jelovnikId == sn.jelovnikId
                              && sn.jelo.tipJela == "Vecera"
                              select sn).First();

                    for (int i = 0; i < d.Count(); i++)
                    {
                        cbxDorucak.Items.Add(d[i].naziv);
                        if (d[i].jeloId == dj.jeloId)
                        {
                            di = i;
                        }
                    }
                    for (int i = 0; i < r.Count(); i++)
                    {
                        cbxRucak.Items.Add(r[i].naziv);
                        if (r[i].jeloId == rj.jeloId)
                        {
                            ri = i;
                        }
                    }
                    for (int i = 0; i < u.Count(); i++)
                    {
                        cbxUzina.Items.Add(u[i].naziv);
                        if (u[i].jeloId == uj.jeloId)
                        {
                            ui = i;
                        }
                    }
                    for (int i = 0; i < v.Count(); i++)
                    {
                        cbxVecera.Items.Add(v[i].naziv);
                        if (v[i].jeloId == vj.jeloId)
                        {
                            vi = i;
                        }
                    }

                    cbxDorucak.SelectedIndex = di;
                    cbxRucak.SelectedIndex = ri;
                    cbxUzina.SelectedIndex = ui;
                    cbxVecera.SelectedIndex = vi;
                    dtpDatum.Value = _jelovnik.datum.Value;
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

                    _jelovnik.UrediJelovnik(d, r, u, v);
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

        private void UredjivanjeJelovnika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F1")
            {
                Help.ShowHelp(this, Path.GetFullPath("StarackiDomVedranaHelp.chm"));
            }
        }
    }
}
