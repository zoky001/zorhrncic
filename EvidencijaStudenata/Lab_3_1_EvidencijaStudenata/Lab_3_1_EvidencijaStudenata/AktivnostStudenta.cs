//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab_3_1_EvidencijaStudenata
{
    using System;
    using System.Collections.Generic;
    
    public partial class AktivnostStudenta
    {
        public int AktivnostId { get; set; }
        public int StudentId { get; set; }
        public double Bodovi { get; set; }
        public Nullable<System.DateTime> Datum { get; set; }
    
        public virtual Aktivnost Aktivnost { get; set; }
        public virtual Student Student { get; set; }
    }
}
