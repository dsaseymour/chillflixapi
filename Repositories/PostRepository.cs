using System;
using Entities;
using Entities.Models;
using Contracts;

namespace Repositories
{
    public class PostRepository:RepositoryBase<Post,int>,IPostRepository
    {
        public PostRepository(ChillflixapiContext chillflixcontext) : base(chillflixcontext)
        {
        }
    }
}
