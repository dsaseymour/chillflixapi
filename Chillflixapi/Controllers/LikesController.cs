using System;
using Microsoft.AspNetCore.Mvc;
using Contracts;
using AutoMapper;

namespace Chillflixapi.Controllers
{
    [Route("api/likes")]
    [ApiController]
    public class LikesController: ControllerBase
    {
        //https://www.notion.so/dannysas/Likes-Controller-a9a38ec1d6be447c8e9a239de6e226d9
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public LikesController(IRepositoryManager repository,IMapper mapper) 
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
