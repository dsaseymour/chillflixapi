using System;
using Contracts;
using Entities.Models;
using Entities;

namespace Repositories
{
    public class ProfileRepository : RepositoryBase<Profile>,IProfileRepository
    {
        public ProfileRepository(ChillflixapiContext chillflixcontext) : base(chillflixcontext)
        {

        }
    }


}
