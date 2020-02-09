using System;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Contracts;
using Services;



namespace Chillflixapi.Controllers
{
    [Route("api/photos")]
    [ApiController]
    public class PhotosController: ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        //https://www.notion.so/dannysas/PhotosController-18e716d18b6c42b3b83b2dc0015008a1
        public PhotosController(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
