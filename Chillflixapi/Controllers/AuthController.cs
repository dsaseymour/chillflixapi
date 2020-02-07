using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Contracts;

namespace Chillflixapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //https://www.notion.so/dannysas/Auth-Controller-6778a676b8a740888bc6cd418f47fda9
        private readonly IRepositoryManager _repository;

        public AuthController(IRepositoryManager repository)
        {
            _repository = repository;
        }
    }
}