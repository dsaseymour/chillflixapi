using System;
namespace Chillflixapi.Models.Repositories
{
    public class UserRepository : EfCoreRepository<User, ChillflixapiContext>
    {

        public UserRepository(ChillflixapiContext chillflixcontext) : base(chillflixcontext)
        {
        }


    }


}
