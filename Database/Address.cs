//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.API.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public int AddressId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Landmark { get; set; }
        public string State { get; set; }
        public Nullable<int> ZipCode { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual User User { get; set; }
    }
}
