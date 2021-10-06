using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.API.Models
{
    public class AddressModel
    {
        public int AddressId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Landmark { get; set; }
        public string State { get; set; }
    }
}