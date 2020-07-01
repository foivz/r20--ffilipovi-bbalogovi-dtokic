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
    public partial class EvidencijaNjege : Form
    {
        korisnik _korisnik = null;
        zaposlenik _zaposlenik = null;
        public EvidencijaNjege(korisnik kor, zaposlenik zap)
        {
            InitializeComponent();
            _korisnik = kor;
            _zaposlenik = zap;
        }

        private void EvidencijaNjege_Load(object sender, EventArgs e)
        {

        }
    }
}
