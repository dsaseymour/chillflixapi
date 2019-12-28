using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chillflixapi.Models;
using Chillflixapi.Models.Repositories;
using Microsoft.Extensions.Logging;

namespace Chillflixapi.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : MyBaseController<ValuesController, User,ValueRepository >
    {
        public ValuesController(ValueRepository repository, ILogger<ValuesController> logger) : base(repository, logger)
        {
        }

    }
}
