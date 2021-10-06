using App.API.Database;
using App.API.Models;
using App.API.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.API.Services
{
    public class UserService : IUserService
    {
        private readonly UserManagementEntities _db;
        public UserService()
        {
            _db = new UserManagementEntities();
        }

        public bool AddUser(UserModel model)
        {
            try
            {
                User userTable = new User()
                {
                    Age = model.Age,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Gender = model.Gender,
                    isActive = true,
                    CountryId = model.CountryId

                };

                _db.Users.Add(userTable);
                _db.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool EditUser(UserModel model)
        {
            try
            {
                User userTable = _db.Users.Where(x => x.UserId == model.UserId && x.isActive==true).FirstOrDefault();
                if (userTable != null)
                {
                    userTable.Age = model.Age;
                    userTable.FirstName = model.FirstName;
                    userTable.LastName = model.LastName;
                    userTable.Gender = model.Gender;
                    userTable.CountryId = model.CountryId;
                }
                _db.SaveChanges();
                return true;
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                User userTable = _db.Users.Where(x => x.UserId == id).FirstOrDefault();

                if (userTable != null)
                {
                   
                    userTable.isActive = false;
                }
                _db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool MakeUserActive(int id)
        {
            try
            {
                User userTable = _db.Users.Where(x => x.UserId == id).FirstOrDefault();

                if (userTable != null)
                {

                    userTable.isActive = true;
                }
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