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
        //https://www.notion.so/dannysas/Profiles-Controller-44d400f68a154970b51ca7c629828b4d
        public ProfilesController(ProfileRepository prepository, ILogger<ProfilesController> logger) : base(prepository,logger)
        {

        }
    }


}
