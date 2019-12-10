using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chillflixapi.Models;
using Chillflixapi.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Chillflixapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : MyBaseController<User, UserRepository>
    {
        public UsersController(UserRepository urepository) : base(urepository)
        {
        }
    }


}
