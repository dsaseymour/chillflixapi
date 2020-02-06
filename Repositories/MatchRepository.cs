using System;
using Entities.Models;
using Contracts;
using Entities;


namespace Repositories
{
    public class MatchRepository: RepositoryBase<Match, int>, IMatchRepository
    {
        public MatchRepository(ChillflixapiContext chillflixcontext) : base(chillflixcontext)                                              )
        {

        }
    }
}
