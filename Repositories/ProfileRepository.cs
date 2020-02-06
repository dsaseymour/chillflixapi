using System;
using Contracts;
using Entities.Models;
using Entities;

namespace Repositories
{
    public class ProfileRepository : RepositoryBase<Profile,int>,IProfileRepository
    {
        public ProfileRepository(ChillflixapiContext chillflixcontext) : base(chillflixcontext)
        {

        }
    }


}
