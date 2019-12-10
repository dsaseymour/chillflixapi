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
    public class ProfilesController : MyBaseController<Profile, ProfileRepository>
    {
        public ProfilesController(ProfileRepository prepository) : base(prepository)
        {

        }
    }


}
