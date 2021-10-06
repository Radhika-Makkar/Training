using App.API.Models;
using App.API.Services;
using App.API.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace App.API.Controllers
{
    public class ContactController : ApiController
    {
        private readonly IContactService _service;
        public ContactController()
        {
            _service = new ContactService();
        }
        [HttpPost]
        public IHttpActionResult AddUser(ContactModel model)
        {
            bool isAdded = _service.AddContact(model);
            if (isAdded)
            {
                return Ok("Contact Added Successfully");
            }
            return StatusCode(HttpStatusCode.BadRequest);
        }
    }
}
