using System;
namespace Repositories
{
    public class ProfileRepository : EfCoreRepository<Profile, ChillflixapiContext>
    {
        public ProfileRepository(ChillflixapiContext chillflixcontext) : base(chillflixcontext)
        {

        }
    }


}
