using System;
using System.Collections.Generic;
using System.Linq;

namespace Vedrana
{
    public partial class evidencijaNjege
    {
        public evidencijaNjege()
        {

        }
        public evidencijaNjege(imaUslugu usluga, korisnik korisnik, zaposlenik zaposlenik, string nnapomena)
        {
            oib = zaposlenik.oib;
            imaUsluguId = usluga.imaUsluguId;
            napomena = nnapomena;
            datum = DateTime.Now;
        }
        public static List<evidencijaNjege> PretragaEvidencijaPoKorisnicima(korisnik korisnik)
        {
            using (var context = new Entities())
            {
                var listaEvidencija = from eN in context.evidencijaNjeges
                                      where eN.imaUslugu.oib == korisnik.oib
                                      select eN;
                return listaEvidencija.ToList();
            }
        }
        public static List<evidencijaNjege> PretragaEvidencijaPoZaposlenicima(zaposlenik zaposlenik)
        {
            using (var context = new Entities())
            {
                var listaEvidencija = from eN in context.evidencijaNjeges
                                      where eN.oib == zaposlenik.oib
                                      select eN;
                return listaEvidencija.ToList();
            }
        }
    }
}
