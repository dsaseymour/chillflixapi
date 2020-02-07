using System;
using Contracts;
using Entities;
using Entities.Models;


namespace Repositories
{
    public class LikeRepository : RepositoryBase<Like,int> ,ILikeRepository
    {
        public LikeRepository(ChillflixapiContext chillflixcontext)
            : base(chillflixcontext)
        {
        }

    }
}
