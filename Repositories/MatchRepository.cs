using System;
using Entities.Models;
using Contracts;

namespace Repositories
{
    public class MatchRepository: RepositoryBase<Match>, IMatchRepository
    {
        public MatchRepository(ChillflixapiContext repositoryContext):base(repositoryContext                                              )
        {
        }
    }
}
