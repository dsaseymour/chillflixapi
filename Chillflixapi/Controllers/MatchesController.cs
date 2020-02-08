using System;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;


using Contracts;


namespace Chillflixapi.Controllers
{
    [Route("api/matches")]
    [ApiController]
    public class MatchesController: ControllerBase
    {
        //https://www.notion.so/dannysas/Matches-Controller-85639d5551574cb690bf77a08518afba
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;

        public MatchesController(IRepositoryManager repository,IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }



    }
}
