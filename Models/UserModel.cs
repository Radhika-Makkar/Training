﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.API.Models
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public bool isActive { get; set; }
        public int CountryId { get; set; }

    }
}