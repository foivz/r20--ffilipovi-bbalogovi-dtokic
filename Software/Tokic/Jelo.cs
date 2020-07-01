using System;
using System.Collections.Generic;
using System.Linq;

namespace Vedrana
{
	public partial class jelo
	{
		public jelo(string nnaziv, string ntip, List<int> sastojciId, List<double> kolicina)
		{
            using (var context = new Entities())
            {
                naziv = nnaziv;
                tipJela = ntip;
                
                context.jeloes.Add(this);
                context.SaveChanges();

                for (int i = 0; i < sastojciId.Count(); i++)
                {
                    seSastoji temp = new seSastoji();
                    temp.jeloId = this.jeloId;
                    temp.proizvodId = sastojciId[i];
                    temp.kolicina = kolicina[i];
                    context.seSastojis.Add(temp);
                }
                context.SaveChanges();
            }
        }
		public static List<jelo> PretraziJelaPoImenu(string naziv = "")
        {
            using (var context = new Entities())
            {
                var query = from j in context.jeloes
                            where naziv == "" ? true : j.naziv == naziv
                            select j;

                return query.ToList();
            }
        }
		public static List<jelo> PopisJelaPoTipu(string tip)
        {
            using (var context = new Entities())
            {
                var query = from j in context.jeloes
                            where j.tipJela == tip
                            select j;

                return query.ToList();
            }
        }
	}
}