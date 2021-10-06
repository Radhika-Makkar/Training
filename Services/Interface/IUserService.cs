using App.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.API.Services.Interface
{
    public interface IUserService
    {
      
        
        bool AddUser(UserModel model);

        bool EditUser(UserModel model);

        bool DeleteUser(int id);

        bool MakeUserActive(int id);

    }
}
