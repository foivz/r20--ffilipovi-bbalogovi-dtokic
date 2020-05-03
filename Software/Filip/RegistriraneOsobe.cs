using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedrana.Filip
{
    class RegistriraneOsobe
    {
        public static List<RegistriraneOsobe> popisOsoba = new List<RegistriraneOsobe>();
        public string Email { get; set; }
        private string Sifra { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Uloga { get; set; }
        public bool Aktivan { get; set; }

        public RegistriraneOsobe(string email, string sifra, string ime, string prezime, string uloga, bool aktivan)
        {
            Email = email;
            Sifra = sifra;
            Ime = ime;
            Prezime = prezime;
            Uloga = uloga;
            Aktivan = aktivan;
        }

        public static void UcitajOsobe()
        {
            popisOsoba.Add(new RegistriraneOsobe("ffilipovic@foi.hr", "12345", "Filip", "Filipovic", "Administrator", true));
            popisOsoba.Add(new RegistriraneOsobe("bbalogovic@foi.hr", "12345", "Branimir", "Balogovic", "Zaposlenik", true));
            popisOsoba.Add(new RegistriraneOsobe("dtokic@foi.hr", "12345", "Danijel", "Tokic", "Kuhar", true));
        }

        public static RegistriraneOsobe Autetifikacija(string email, string sifra)
        {
            foreach (RegistriraneOsobe osoba in popisOsoba)
            {
                if (osoba.Email == email && osoba.Sifra == sifra && osoba.Aktivan)
                {
                    return osoba;
                }
            }
            return null;
        }

        public static bool NoviKorisnik(string email, string ime, string prezime, string uloga)
        {
            foreach (RegistriraneOsobe osoba in popisOsoba)
            {
                if (osoba.Email == email)
                {
                    return false;
                }
            }
            if (!email.Contains("@"))
                return false;

            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            string sifra = new String(stringChars);

            popisOsoba.Add(new RegistriraneOsobe(email, sifra, ime, prezime, uloga, true));
            return true;
        }
    }
}
