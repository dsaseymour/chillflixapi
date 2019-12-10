using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chillflixapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Chillflixapi.Models.Repositories;

namespace Chillflixapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : MyBaseController<Profile, ProfileRepository>
    {
        public HomeController(ProfileRepository prepository) : base(prepository)
        {

        }
    }



}
