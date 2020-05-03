using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedrana.Danijel
{
    public class Proizvodi
    {
        public string Naziv { get; set; }
        public string Tip { get; set; }

        public Proizvodi(string naziv, string tip)
        {
            Naziv = naziv;
            Tip = tip;
        }
    }
}
