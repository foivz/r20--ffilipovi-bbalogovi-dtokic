using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Vedrana
{
    public partial class korisnik : osoba
    {
        public korisnik(string nime, string nprezime, string noib, string nadresa, DateTime ndatumRodjenja, string nkontakt, int nbrojSobe,
            List<imaUslugu> npopisUsluga, string nalergije, string nnapomene)
        {
            ime = nime;
            prezime = nprezime;
            oib = noib;
            adresa = nadresa;
            datumRodjenja = ndatumRodjenja;
            kontakt = nkontakt;
            brojSobe = nbrojSobe;
            alergije = nalergije;
            napomene = nnapomene;
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
                context.korisniks.Add(this);
                foreach (var novaUsluga in npopisUsluga)
                {
                    context.imaUslugus.Add(novaUsluga);
                }
                context.SaveChanges();
            }
        }
        public static IEnumerable<object> PretragaKorisnika(bool bivsi, string ime = "", string prezime = "")
        {
            throw new NotImplementedException();
        }
        public void PromjenaUslugaKorisnika(List<imaUslugu> popisUsluga)
        {
            throw new NotImplementedException();
        }
        public void MakniKorisnika(korisnik korisnik)
        {
            throw new NotImplementedException();
        }
        public void PromjeniSobu(int brojSobe)
        {
            throw new NotImplementedException();
        }
        public void UredjivanjePodataka(string nkontakt = "", int soba = 0, string nnapomene = "", List<imaUslugu> npopisUsluga = null)
        {
            throw new NotImplementedException();
        }
    }
}
