using System;
using Entities;
using Entities.Models;
using Contracts;

namespace Repositories
{
    public class MediaRepository:RepositoryBase<Media>,IMediaRepository
    {
        public MediaRepository(ChillflixapiContext chillflixcontext) : base(chillflixcontext)
        {
        }
    }
}
