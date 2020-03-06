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
    
        #region getusers-controller definition  
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

        [HttpGet("collection/({ids})", Name = "UserCollection")] 
        public IActionResult GetUserCollection(IEnumerable<int> ids) 
        {
            if(ids == null) {
                _logger.LogError("Parameter ids is null"); 
                return BadRequest("Parameter ids is null");
            }
            IEnumerable<UserDto> usersToReturn = _userservice.GetUserCollection(ids);
            if(usersToReturn == null){
                _logger.LogError("Some ids are not valid");
                return NotFound();
            }
            return Ok(usersToReturn);
        }
        #endregion


        //our method is restriced to post requests
        //collecting data from the request body instead of the URI
        //the user comes from the client it must be validated 
        //we create our id on the server side 
        [HttpPost]
        public ActionResult CreateUser( [FromBody] UserForCreationDto user)
        {
            //get user is the function where the newly created user object can be retrieved
            if(user == null)
            {
                _logger.LogError("UserForCreationDto object sent from client is null.");
                return BadRequest("UserForCreationDto object is null");
            }

            if (!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the CompanyForCreationDto object");
                return UnprocessableEntity(ModelState);
            }
            UserDto userToReturn=_userservice.CreateUser(user);

            return CreatedAtRoute("GetUser", new { userId, id = userToReturn.Id }, );
        }   

        [HttpDelete("{id}")]
        public ActionResult DeleteUser( int id)
        {
            _userservice.DeleteUser(id);
            return NoContent();
        }




        #region updateuser-controller definition
        [HttpPut("{id}")]
        public Task<IActionResult> UpdateUser( int id, [FromBody] UserForUpdateDto employee)
        {           
            var updatedUser =_userservice.UpdateUser(id, employee);
            if(updatedUser == null)
            {
                _logger.LogInfo($"User with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            return NoContent();
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> PartiallyUpdateUser(int id, [FromBody] JsonPatchDocument<UserForUpdateDto> patchDoc)
        {
            if(company == null)
            {
                _logger.LogError("UserForUpdateDto object sent from client is null.");
                return BadRequest("UserForUpdateDto object is null");
            }

            if(!ModelState.IsValid)
            {
                _logger.LogError("Invalid model state for the UserForUpdateDto object");
                return UnprocessableEntity(ModelState);
            }

            _userservice.PartialUpdateUser();
            return NoContent();
        }
        #endregion
    }
}
