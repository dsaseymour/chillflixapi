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
    public class MediaController : ControllerBase
    {
        //https://www.notion.so/dannysas/Media-Controller-960f13f4d8f846b49febd2a14a4b9fd8
        private readonly IRepositoryManager _repository;

        public MediaController(IRepositoryManager repository) {

            _repository = repository;
        }


    }


}