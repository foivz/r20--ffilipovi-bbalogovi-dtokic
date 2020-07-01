using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Vedrana
{
	public partial class jelovnik
	{
		public jelovnik(jelo dorucak, jelo rucak, jelo uzina, jelo vecera, DateTime datum, bool poseban = false)
		{
            using (var context = new Entities())
            {
                var querry = from j in context.jelovniks.AsEnumerable()
                             where j.datum.Value.Date == datum.Date
                             && j.posebanJelovnik == Convert.ToByte(poseban)
                             select j;
                if (querry.Count() > 0)
                {
                    throw new Exception("Postoji jelovnik za taj dan!");
                }

                this.datum = datum;
                this.posebanJelovnik = Convert.ToByte(poseban);
                context.jelovniks.Add(this);
                context.SaveChanges();

                seNalazi d = new seNalazi
                {
                    jeloId = dorucak.jeloId,
                    jelovnikId = this.jelovnikId
                };
                context.seNalazis.Add(d);

                seNalazi r = new seNalazi
                {
                    jeloId = rucak.jeloId,
                    jelovnikId = this.jelovnikId
                };
                context.seNalazis.Add(r);

                seNalazi u = new seNalazi
                {
                    jeloId = uzina.jeloId,
                    jelovnikId = this.jelovnikId
                };
                context.seNalazis.Add(u);

                seNalazi v = new seNalazi
                {
                    jeloId = vecera.jeloId,
                    jelovnikId = this.jelovnikId
                };
                context.seNalazis.Add(v);

                context.SaveChanges();
            }
        }
		public void UrediJelovnik(jelo dorucak, jelo rucak, jelo uzina, jelo vecera)
        {
            using (var context = new Entities())
            {
                var query2 = from sn in context.seNalazis
                             where sn.jelovnikId == this.jelovnikId
                             select sn;
                foreach (var item in query2)
                {
                    context.Entry(item).State = EntityState.Deleted;
                }
                context.SaveChanges();

                seNalazi d = new seNalazi
                {
                    jeloId = dorucak.jeloId,
                    jelovnikId = this.jelovnikId
                };
                context.seNalazis.Add(d);

                seNalazi r = new seNalazi
                {
                    jeloId = rucak.jeloId,
                    jelovnikId = this.jelovnikId
                };
                context.seNalazis.Add(r);

                seNalazi u = new seNalazi
                {
                    jeloId = uzina.jeloId,
                    jelovnikId = this.jelovnikId
                };
                context.seNalazis.Add(u);

                seNalazi v = new seNalazi
                {
                    jeloId = vecera.jeloId,
                    jelovnikId = this.jelovnikId
                };
                context.seNalazis.Add(v);

                context.SaveChanges();
            }
        }
		public static Tuple<List<jelo>, List<jelo>> DanasnjiJelovnik()
        {
			throw new NotImplementedException();
        }
		public static Tuple<List<List<jelo>>, List<DateTime>, List<bool>> SviJelovnici()
        {
			throw new NotImplementedException();
        }
	}
}