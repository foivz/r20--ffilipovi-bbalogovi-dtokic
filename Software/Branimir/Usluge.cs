using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedrana.Branimir
{
    public class Usluge
    {
        public static List<Usluge> popisUsluga = new List<Usluge>();
        public string NazivUsluge { get; set; }

        public Usluge(string naziv)
        {
            NazivUsluge = naziv;
        }

        public static void UcitajUsluge()
        {
            popisUsluga.Add(new Usluge("a"));
            popisUsluga.Add(new Usluge("b"));
        }

        public static Usluge PronadjiUsluguPoImenu(string naziv)
        {
            foreach (Usluge u in popisUsluga)
            {
                if (naziv == u.NazivUsluge)
                {
                    return u;
                }
            }
            return null;
        }
    }
}
