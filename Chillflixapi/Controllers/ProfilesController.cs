using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chillflixapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Chillflixapi.Models.Repositories;
using Microsoft.Extensions.Logging;

namespace Chillflixapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : MyBaseController<ProfilesController,Profile, ProfileRepository>
    {
        public ProfilesController(ProfileRepository prepository, ILogger<ProfilesController> logger) : base(prepository,logger)
        {

        }
    }


}
