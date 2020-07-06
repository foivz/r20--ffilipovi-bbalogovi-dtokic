using System;
using System.Collections.Generic;
using System.Linq;

namespace Vedrana.Tokic
{
	public class Skladiste
	{
		public static IEnumerable<object> DohvatiPopisSastojaka(string tip = "")
        {
            using (var context = new Entities())
            {
                var lista = from p in context.proizvods
                            where tip == "" ? true : p.tip == tip
                            select new
                            {
                                Naziv = p.naziv,
                                Tip = p.tip,
                                Količina = p.naSkladistu
                            };
                return lista.ToList();
            }
        }
		public static IEnumerable<object> PopisNarucenihStvari()
        {
            using (var context = new Entities())
            {
                var lista = from sn in context.seNarucujes.AsEnumerable()
                            select new
                            {
                                Naziv = sn.proizvod.naziv,
                                Tip = sn.proizvod.tip,
                                Količina = sn.kolicina,
                                Datum = sn.narudzba.datum.Value.Date
                            };
                return lista.ToList();
            }
        }
	}
}