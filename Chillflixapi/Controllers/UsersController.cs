using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Services;
using Entities.Dtos;

namespace Chillflixapi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController :ControllerBase
    {
        //https://www.notion.so/dannysas/Users-Controller-3c8a6ef4b63043358c778e5f1b5b601c
        private readonly UserService _userservice;
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger, UserService userservice) 
        {
            _userservice = userservice;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            return  Ok(_userservice.GetAllUsers());

        }


        [HttpGet("{id}", Name = "GetUser")]
        public  ActionResult<User> GetUser( int id)
        {
            return Ok(_userservice.GetUser(id));
        }

        //our method is restriced to post requests
        //collecting data from the request body instead of the URI
        //the user comes from the client it must be validated 
        [HttpPost]
        public ActionResult CreateUser( [FromBody] UserForCreationDto user)
        {
            //get user is the function where the newly created user object can be retrieved

            return CreatedAtRoute("GetUser", new { companyId, id = employeeToReturn.Id }, _userservice.Create);
        }   

        [HttpDelete("{id}")]
        public ActionResult DeleteUser( int id)
        {
            _userservice.DeleteUser(id);
            return NoContent();
        }





[HttpPut("{id}")]
public Task<IActionResult> UpdateUser( int id, [FromBody] UserForUpdateDto employee)
{

            _userservice.UpdateUser();

            return NoContent();
}

[HttpPatch("{id}")]
public async Task<IActionResult> PartiallyUpdateUser(int id, [FromBody] JsonPatchDocument<UserForUpdateDto> patchDoc)
{


            _userservice.PartialUpdateUser();

            return NoContent();
}

    }


}
