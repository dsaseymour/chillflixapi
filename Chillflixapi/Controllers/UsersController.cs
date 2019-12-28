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
        public UsersController(UserRepository repository, ILogger<UsersController> logger) : base(repository, logger)
        {
        }
    }


}
