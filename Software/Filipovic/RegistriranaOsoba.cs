using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using Lib;

namespace Vedrana
{
    public partial class zaposlenik : osoba
    {
        public zaposlenik(string nemail, string noib, string nime, string nprezime, string nadresa, string nkontakt,
            DateTime ndatumRodjenja, string nuloga)
        {
            email = nemail;
            oib = noib;
            ime = nime;
            prezime = nprezime;
            adresa = nadresa;
            kontakt = nkontakt;
            datumRodjenja = ndatumRodjenja;
            uloga = nuloga;
            datumPocetka = DateTime.Now;
            datumZavrsetka = null;

            using (var context = new Entities())
            {
                osoba novaOsoba = new osoba();
                novaOsoba.oib = noib;
                novaOsoba.ime = nime;
                novaOsoba.prezime = nprezime;
                novaOsoba.adresa = nadresa;
                novaOsoba.kontakt = nkontakt;
                novaOsoba.datumRodjenja = ndatumRodjenja;
                novaOsoba.datumPocetka = DateTime.Now;
                novaOsoba.datumZavrsetka = null;
                novaOsoba.koronaPozitivan = 0;
                context.osobas.Add(novaOsoba);
                context.SaveChanges();
            }

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            lozinka = finalString;

            SlanjeMaila.PosaljiMail(nemail, "Registracija", $"Pozdrav {ime}!\n" +
                $"Administrator vas je uspješno registrirao te od sada možete koristiti aplikaciju Dom \"Vedrana\".\n" +
                $"Vaši podaci za prijavu glase:\n" +
                $"E-mail: {nemail}\n" +
                $"Lozinka: {finalString}");
        }

        public static zaposlenik Autenfikacija (string email, string sifra)
        {
            using (var context = new Entities())
            {
                context.zaposleniks.Load();
                var login = from z in context.zaposleniks
                            where email == z.email && sifra == z.lozinka && z.osoba.datumZavrsetka == null
                            select z;
                if (login.Count() > 0)
                    return login.First();
                else
                    return null;
            }
        }
        public void PromjenaLozinke (string sifra)
        {
            using (var context = new Entities())
            {
                this.lozinka = sifra;
                var user = from z in context.zaposleniks
                           where z.oib == this.oib
                           select z;
                user.First().lozinka = sifra;
                context.SaveChanges();
            }
        }
        public static void ZaboravljenaLozinka (string email, string oib)
        {
            using (var context = new Entities())
            {
                var user = from zaposlenik in context.zaposleniks
                           where zaposlenik.email == email && zaposlenik.oib == oib
                           && zaposlenik.osoba.datumZavrsetka == null
                           select zaposlenik;

                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[8];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);

                if (user.Count() > 0)
                {
                    user.First<zaposlenik>().lozinka = finalString;
                    context.SaveChanges();
                    SlanjeMaila.PosaljiMail(email, "Zaboravljena lozinka", $"Zatražili ste resetiranje lozinke.\nVaša nova lozinka je: {finalString}");
                }
                else
                    throw new Exception("Pogrešno upisani podaci. Molimo pokušajte opet.");
            }
        }
        public static IEnumerable<object> PretragaZaposlenika (bool bivsi, string ime="", string prezime="")
        {
            using (var context = new Entities())
            {
                var lista = from z in context.zaposleniks
                            where (bivsi ? z.osoba.datumZavrsetka != null : z.osoba.datumZavrsetka == null)
                            && (ime == "" ? true : z.osoba.ime.ToLower() == ime.ToLower())
                            && (prezime == "" ? true : z.osoba.prezime.ToLower() == prezime.ToLower())
                            select new
                            {
                                z.oib,
                                z.osoba.ime,
                                z.osoba.prezime,
                                z.email,
                                z.uloga,
                                z.osoba.adresa,
                                z.osoba.kontakt,
                                z.osoba.datumRodjenja,
                                z.osoba.datumPocetka,
                                z.osoba.datumZavrsetka
                            };

                return lista.ToList();
            }
        }
        public void OtpustiZaposlenika (zaposlenik zaposlenik)
        {
            zaposlenik.osoba.datumZavrsetka = DateTime.Now;
        }
    }
}
