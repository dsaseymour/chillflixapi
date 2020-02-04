using System;
using Contracts;
using Entities;
using Entities.Models;

namespace Repositories
{
    public class AuthRepository: RepositoryBase<Like>, IAuthRepository
    {
        //https://www.notion.so/dannysas/AuthRepository-82ade223ba3e42a0a4d2b2a26ca8a6db
        public AuthRepository(ChillflixapiContext repositoryContext):base(repositoryContext)
        {
        }
    }
}
