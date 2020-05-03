using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedrana.Danijel
{
    public class Jela
    {
        public static List<Jela> listaJela = new List<Jela>();
        public string Naziv { get; set; }
        public string TipJela { get; set; }
        public List<Proizvodi> ListaSastojaka { get; set; }
        public List<int> KolicineSastojaka { get; set; }

        public Jela(string naziv, string tip, List<Proizvodi> sastojci, List<int> kolicina)
        {
            Naziv = naziv;
            TipJela = tip;
            ListaSastojaka = sastojci;
            KolicineSastojaka = kolicina;
        }

        public static void UcitajJela()
        {
            listaJela.Add(new Jela("d", "Dorucak", null, null));
            listaJela.Add(new Jela("r", "Rucak", null, null));
            listaJela.Add(new Jela("u", "Uzina", null, null));
            listaJela.Add(new Jela("v", "Vecera", null, null));
        }

        public static Jela PretraziJelaPoImenu(string naziv)
        {
            foreach (Jela jela in listaJela)
            {
                if (jela.Naziv == naziv)
                {
                    return jela;
                }
            }
            return null;
        }

        public static List<Jela> PopisJelaPoTipu(string tip)
        {
            List<Jela> tipJela = new List<Jela>();
            foreach (Jela jela in listaJela)
            {
                if (jela.TipJela == tip)
                {
                    tipJela.Add(jela);
                }
            }
            return tipJela;
        }

        public static void NovoJelo(string naziv, string tip, List<Proizvodi> sastojci, List<int> kolicina)
        {
            foreach (Jela jela in listaJela)
            {
                if (jela.Naziv == naziv && jela.TipJela == tip)
                {
                    jela.ListaSastojaka = sastojci;
                    jela.KolicineSastojaka = kolicina;
                    return;
                }
            }
            listaJela.Add(new Jela(naziv, tip, sastojci, kolicina));
        }
    }
}
