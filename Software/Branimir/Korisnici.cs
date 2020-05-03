using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedrana.Branimir
{
    public class Korisnici
    {
        public static List<Korisnici> popisKorisnika = new List<Korisnici>();
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public List<Usluge> PopisUsluga { get; set; }
        public bool Aktivan { get; set; }

        public Korisnici(string ime, string prezime, List<Usluge> popisUsluga)
        {
            Ime = ime;
            Prezime = prezime;
            PopisUsluga = popisUsluga;
            Aktivan = true;
        }

        public static void UcitajKorisnike()
        {
            popisKorisnika.Add(new Korisnici("ime1", "prezime1", null));
            popisKorisnika.Add(new Korisnici("ime2", "prezime2", null));
        }

        public static void NoviKorisnik(string ime, string prezime, List<Usluge> popisUsluga)
        {
            popisKorisnika.Add(new Korisnici(ime, prezime, popisUsluga));
        }
    }
}
