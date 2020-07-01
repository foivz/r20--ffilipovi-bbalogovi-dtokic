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
			throw new NotImplementedException();
        }
		public static List<jelo> PopisJelaPoTipu(string tip)
        {
			throw new NotImplementedException();
        }
	}
}