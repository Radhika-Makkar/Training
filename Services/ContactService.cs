using App.API.Database;
using App.API.Models;
using App.API.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.API.Services
{
    public class ContactService : IContactService
    {
        private readonly UserManagementEntities _db;
        public ContactService()
        {
            _db = new UserManagementEntities();
        }

        public bool AddContact(ContactModel model)
        {
            try
            {
                Country countryTable = new Country()
                {
                    CountryCode = model.CountryCode,
                    MobileNumber = model.MobileNumber
                };
                _db.Countries.Add(countryTable);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}