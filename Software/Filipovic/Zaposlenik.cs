using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedrana
{
    public partial class zaposlenik : osoba
    {
        public static zaposlenik Autenfikacija(string email, string sifra)
        {
            using (var context = new Entities())
            {
                context.zaposleniks.Load();
                var login = from z in context.zaposleniks
                            where email == z.email && sifra == z.lozinka && z.osoba.datumZavrsetka == null
                            select z;
                if (login.Count() > 0)
                    return login.First();
                else
                    return null;
            }
        }
    }
}
