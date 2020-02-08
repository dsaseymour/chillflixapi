using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Contracts;
using AutoMapper;


namespace Chillflixapi.Controllers
{
    //[Route("api/profiles/{profileId}/posts")]
    //posts are children of a particular profile 
    [Route("api/posts")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        // https://www.notion.so/dannysas/Post-Controller-e7d8b1fa24c64a22a519102cc3a04f60

        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public PostsController(IRepositoryManager repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

    }
}