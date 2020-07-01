using Lib;
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
        public static void ZaboravljenaLozinka(string email, string oib)
        {
            using (var context = new Entities())
            {
                var user = from zaposlenik in context.zaposleniks
                           where zaposlenik.email == email && zaposlenik.oib == oib
                           && zaposlenik.osoba.datumZavrsetka == null
                           select zaposlenik;

                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[8];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);

                if (user.Count() > 0)
                {
                    user.First<zaposlenik>().lozinka = finalString;
                    context.SaveChanges();
                    SlanjeMaila.PosaljiMail(email, "Zaboravljena lozinka", $"Zatražili ste resetiranje lozinke.\nVaša nova lozinka je: {finalString}");
                }
                else
                    throw new Exception("Pogrešno upisani podaci. Molimo pokušajte opet.");
            }
        }
    }
}
