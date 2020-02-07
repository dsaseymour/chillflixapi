using System;
using Microsoft.AspNetCore.Mvc;
using Contracts;

namespace Chillflixapi.Controllers
{
    public class LikesController: ControllerBase
    {
        //https://www.notion.so/dannysas/Likes-Controller-a9a38ec1d6be447c8e9a239de6e226d9
        private readonly IRepositoryManager _repository;
        public LikesController(IRepositoryManager repository) 
        {
            _repository = repository;
        }
    }
}
