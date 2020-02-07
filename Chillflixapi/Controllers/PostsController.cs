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
    public class PostsController : ControllerBase
    {
        // https://www.notion.so/dannysas/Post-Controller-e7d8b1fa24c64a22a519102cc3a04f60

        private readonly IRepositoryManager _repository;

        public PostsController(IRepositoryManager repository)
        {
            _repository = repository;
        }

    }
}