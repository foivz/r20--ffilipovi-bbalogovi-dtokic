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
            using (var context = new Entities())
            {
                var lista = from k in context.korisniks.AsEnumerable()
                            where (bivsi ? k.osoba.datumZavrsetka != null : k.osoba.datumZavrsetka == null)
                            && (ime == "" ? true : k.osoba.ime.ToLower() == ime.ToLower())
                            && (prezime == "" ? true : k.osoba.prezime.ToLower() == prezime.ToLower())
                            select new
                            {
                                k.oib,
                                k.osoba.ime,
                                k.osoba.prezime,
                                k.brojSobe,
                                usluge = string.Join(", ", (from u in context.uslugas
                                         join iU in context.imaUslugus on u.uslugaId equals iU.uslugaId
                                         where iU.oib == k.oib
                                         select u.naziv).ToArray()),
                                k.alergije,
                                k.napomene,
                                k.osoba.adresa,
                                k.osoba.kontakt,
                                k.osoba.datumRodjenja,
                                k.osoba.datumPocetka,
                                k.osoba.datumZavrsetka
                            };

                return lista.ToList();
            }
        }
        public void PromjenaUslugaKorisnika(List<imaUslugu> popisUsluga)
        {
            using (var context = new Entities())
            {
                var stareUsluge = from iU in context.imaUslugus
                                  where iU.oib == this.oib
                                  select iU;
                foreach (var sUsluga in stareUsluge)
                {
                    context.imaUslugus.Remove(sUsluga);
                }
                context.SaveChanges();

                foreach (var nUsluga in popisUsluga)
                {
                    context.imaUslugus.Add(nUsluga);
                }
                context.SaveChanges();
            }
        }
        public void MakniKorisnika(korisnik korisnik)
        {
            korisnik.osoba.datumZavrsetka = DateTime.Now;
        }
        public void PromjeniSobu(int brojSobe)
        {
            using (var context = new Entities())
            {
                this.brojSobe = brojSobe;
                var user = from k in context.korisniks
                           where k.oib == this.oib
                           select k;
                user.First().brojSobe = brojSobe;
                context.SaveChanges();
            }
        }
        public void UredjivanjePodataka(string nkontakt = "", int soba = 0, string nnapomene = "", List<imaUslugu> npopisUsluga = null)
        {
            throw new NotImplementedException();
        }
    }
}
