using System;
using Microsoft.AspNetCore.Mvc;

using Contracts;


namespace Chillflixapi.Controllers
{
    public class MatchesController: ControllerBase
    {
        //https://www.notion.so/dannysas/Matches-Controller-85639d5551574cb690bf77a08518afba
        private readonly IRepositoryManager _repository;

        public MatchesController(IRepositoryManager repository)
        {
            _repository = repository;

        }
    }
}
