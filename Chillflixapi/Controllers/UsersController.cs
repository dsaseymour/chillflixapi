using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Contracts;
using Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Services;


namespace Chillflixapi.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController :ControllerBase
    {
        //https://www.notion.so/dannysas/Users-Controller-3c8a6ef4b63043358c778e5f1b5b601c
        private readonly UserService _userservice;

        public UsersController(IRepositoryManager repository, ILogger<UsersController> logger,IMapper mapper,UserService userservice) 
        {
            _userservice = userservice;
        }

        [HttpGet]
        public IQueryable<User> GetAllUsers()
        {
            return _userservice.GetAllUsers();
        }



    }


}
