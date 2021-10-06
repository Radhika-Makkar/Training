using App.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.API.Services.Interface
{
    interface IContactService
    {
        bool AddContact(ContactModel model);
    }
}
