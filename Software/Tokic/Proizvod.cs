using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedrana
{
    public partial class proizvod
    {
        public proizvod (string nnaziv, string ntip, double kolicina = 0)
        {
            using (var context = new Entities())
            {
                naziv = nnaziv;
                tip = ntip;
                naSkladistu = kolicina;
                context.proizvods.Add(this);
                context.SaveChanges();
            }
        }
    }
}
