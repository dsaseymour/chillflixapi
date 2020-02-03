using System;
using Contracts;
using Entities;


namespace Repositories
{
    public class LikeRepository : EfCoreRepository<ChillflixapiContext> ,ILikeRepository
    {
        public LikeRepository(ChillflixapiContext chillflixcontext)
            : base(chillflixcontext)
        {
        }

    }
}
