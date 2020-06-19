using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedrana.Filipovic
{
    public abstract class Osoba
    {
        public string OIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime? DatumZavrsetka { get; set; }
        public string Adresa { get; set; }
        public string Kontakt { get; set; }
        public DateTime DatumRodjenja { get; set; }
    }
}
