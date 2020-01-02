using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chillflixapi.Models;
using Chillflixapi.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Chillflixapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : MyBaseController<UsersController, User, UserRepository>
    {
        //https://www.notion.so/dannysas/Users-Controller-3c8a6ef4b63043358c778e5f1b5b601c
        public UsersController(UserRepository repository, ILogger<UsersController> logger) : base(repository, logger)
        {
        }
    }


}
