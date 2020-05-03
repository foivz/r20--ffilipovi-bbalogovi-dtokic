using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedrana.Danijel
{
    public class Skladiste : Proizvodi
    {
        public static List<Skladiste> listaProizvodaUSkladistu = new List<Skladiste>();
        public int Kolicina { get; set; }

        public Skladiste(string naziv, string tip, int kolicina=0) : base (naziv, tip)
        {
            Kolicina = kolicina;
        }

        public static void UcitajSkladiste()
        {
            listaProizvodaUSkladistu.Add(new Skladiste("Krompir","Sastojak"));
            listaProizvodaUSkladistu.Add(new Skladiste("Krompir1","Sastojak"));
            listaProizvodaUSkladistu.Add(new Skladiste("Krompir1","Sastojak"));
        }

        public static List<Skladiste> DohvatiPopisSastojaka()
        {
            List<Skladiste> sastojci = new List<Skladiste>();

            foreach (Skladiste skladiste in listaProizvodaUSkladistu)
            {
                if (skladiste.Tip=="Sastojak")
                {
                    sastojci.Add(skladiste);
                }
            }

            return sastojci;
        }
    }
}
