using System;
namespace Chillflixapi.Models.Repositories
{
    public class ProfileRepository : EfCoreRepository<Profile, ChillflixapiContext>
    {
        public ProfileRepository(ChillflixapiContext chillflixcontext) : base(chillflixcontext)
        {

        }
    }


}
