using System;
using System.Collections.Generic;
using System.Linq;


namespace Vedrana
{

	public partial class usluga
	{
		public usluga(string nnaziv, double ncijena, string nopis, List<int> npopisProizvoda, List<double> kolicinaProizvoda)
		{
            using (var context = new Entities())
            {
                naziv = nnaziv;
                cijena = ncijena;
                opis = nopis;
                context.uslugas.Add(this);
                context.SaveChanges();

                for (int i = 0; i < npopisProizvoda.Count(); i++)
                {
                    koristiProizvod temp = new koristiProizvod();
                    temp.uslugaId = this.uslugaId;
                    temp.proizvodId = npopisProizvoda[i];
                    temp.kolicina = kolicinaProizvoda[i];
                    context.koristiProizvods.Add(temp);
                }
                context.SaveChanges();
            }
        }
		public void PromjenaCijeneUsluge(double cijena)
        {
            using (var context = new Entities())
            {
                this.cijena = cijena;
                var usluga = from u in context.uslugas
                             where u.uslugaId == this.uslugaId
                             select u;
                usluga.First().cijena = cijena;
                context.SaveChanges();
            }
        }
		public static List<usluga> PronadjiUsluguPoImenu(string naziv = "")
        {
			throw new NotImplementedException();
		}
	}

}

