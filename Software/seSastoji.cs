//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vedrana
{
    using System;
    using System.Collections.Generic;
    
    public partial class seSastoji
    {
        public int jeloId { get; set; }
        public int proizvodId { get; set; }
        public Nullable<double> kolicina { get; set; }
        public int seSastojiID { get; set; }
    
        public virtual jelo jelo { get; set; }
        public virtual proizvod proizvod { get; set; }
    }
}
