using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.API.Models
{
    public class ContactModel
    {
        public int ContactId { get; set; }
        public int CountryCode { get; set; }
        public int MobileNumber { get; set; }
    }
}