//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class trust
    {
        public int trust_id { get; set; }
        public Nullable<int> trust_book_id { get; set; }
        public Nullable<int> trust_mokhatabin_id { get; set; }
        public Nullable<System.DateTime> trust_timestart { get; set; }
        public Nullable<System.DateTime> trust_timeend { get; set; }
        public Nullable<int> trust_later { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual moshtarekin moshtarekin { get; set; }
    }
}
