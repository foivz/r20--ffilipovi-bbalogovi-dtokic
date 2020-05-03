using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedrana.Danijel
{
    class Jelovnik
    {
        public static List<Jelovnik> listaJelovnika = new List<Jelovnik>();
        public Jela Dorucak { get; set; }
        public Jela Rucak { get; set; }
        public Jela Uzina { get; set; }
        public Jela Vecera { get; set; }
        public DateTime Datum { get; set; }

        public Jelovnik(Jela dorucak, Jela rucak, Jela uzina, Jela vecera, DateTime datum)
        {
            Dorucak = dorucak;
            Rucak = rucak;
            Uzina = uzina;
            Vecera = vecera;
            Datum = datum.Date;
        }

        public static void UcitajJelovnike()
        {
            Jela dorucak = Jela.PretraziJelaPoImenu("d");
            Jela rucak = Jela.PretraziJelaPoImenu("r");
            Jela uzina = Jela.PretraziJelaPoImenu("u");
            Jela vecera = Jela.PretraziJelaPoImenu("v");
            listaJelovnika.Add(new Jelovnik(dorucak, rucak, uzina, vecera, DateTime.Now));
        }

        public static Jelovnik DanasnjiJelovnik()
        {
            foreach (Jelovnik jelovnik in listaJelovnika)
            {
                if (jelovnik.Datum==DateTime.Today.Date)
                {
                    return jelovnik;
                }
            }
            return null;
        }

        public static void NoviJelovnik(Jela dorucak, Jela rucak, Jela uzina, Jela vecera, DateTime datum)
        {
            foreach (Jelovnik jelovnik in listaJelovnika)
            {
                if (jelovnik.Datum.Date==datum.Date)
                {
                    jelovnik.Dorucak = dorucak;
                    jelovnik.Rucak = rucak;
                    jelovnik.Uzina = uzina;
                    jelovnik.Vecera = vecera;
                    return;
                }
            }
            listaJelovnika.Add(new Jelovnik(dorucak, rucak, uzina, vecera, datum));
        }
    }
}
