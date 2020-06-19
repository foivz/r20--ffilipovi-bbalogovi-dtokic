using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedrana
{
    public partial class Skladiste : proizvod
    {
        public static IEnumerable<object> DohvatiPopisSastojaka(string tip="")
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
        public void NaruciSastojke (List<proizvod> popisProizvoda)
        {
            throw new NotImplementedException();
        }
        private void NaruciProizvode ()
        {
            throw new NotImplementedException();
        }
        public void IskoristenProizvod ()
        {
            throw new NotImplementedException();
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
