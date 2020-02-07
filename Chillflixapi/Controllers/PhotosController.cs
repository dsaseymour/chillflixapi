using System;
using Microsoft.AspNetCore.Mvc;

using Contracts;


namespace Chillflixapi.Controllers
{
    public class PhotosController: ControllerBase
    {
        private readonly IRepositoryManager _repository;
        //https://www.notion.so/dannysas/PhotosController-18e716d18b6c42b3b83b2dc0015008a1
        public PhotosController(IRepositoryManager repository)
        {
            _repository = repository;
        }
    }
}
