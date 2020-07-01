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
			throw new NotImplementedException();
		}
		public void UrediJelovnik(jelo dorucak, jelo rucak, jelo uzina, jelo vecera)
        {
			throw new NotImplementedException();
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