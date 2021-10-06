using App.API.Database;
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
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        private readonly IUserService _service;
        public UserController()
        {
            _service = new UserService();
        }
     

        [HttpPost]
        [Route("add")]
        public IHttpActionResult AddUser(UserModel model)
        {
            bool isAdded = _service.AddUser(model);
            if (isAdded)
            {
                return Ok("User Added Successfully");
            }
            return StatusCode(HttpStatusCode.BadRequest);
        }

        [HttpPut]
        public IHttpActionResult EditUser(UserModel model)
        {
            bool isEdited = _service.EditUser(model);
            if (isEdited)
            {
                return Ok("User Edited Successfully");
            }
            return StatusCode(HttpStatusCode.BadRequest);
        }

        [HttpPost]
        [Route("delete")]
        public IHttpActionResult DeleteUser(int id)
        {
            
            bool isDeleted = _service.DeleteUser(id);
            if (isDeleted)
            {
                return Ok("User Deleted Successfully");
            }
            return StatusCode(HttpStatusCode.BadRequest);
        }

        [HttpPost]
        [Route("statusChange")]

        public IHttpActionResult MakeUserActive(int id)
        {

            bool isActive = _service.MakeUserActive(id);
            if (isActive)
            {
                return Ok("User Now Active");
            }
            return StatusCode(HttpStatusCode.BadRequest);
        }
    }
  
}
