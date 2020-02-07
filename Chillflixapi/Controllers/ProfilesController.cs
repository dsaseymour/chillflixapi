using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Contracts;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Microsoft.Extensions.Logging;

namespace Chillflixapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController :ControllerBase
    {
        private readonly IRepositoryManager _repository;

        //https://www.notion.so/dannysas/Profiles-Controller-44d400f68a154970b51ca7c629828b4d
        public ProfilesController(IRepositoryManager repository, ILogger<ProfilesController> logger) 
        {
            _repository = repository;
        }
    }


}
