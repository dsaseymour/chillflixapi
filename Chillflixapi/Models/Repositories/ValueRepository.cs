using System;
namespace Chillflixapi.Models.Repositories
{
    public class ValueRepository : EfCoreRepository<User, ChillflixapiContext>
    {
        public ValueRepository(ChillflixapiContext chillflixcontext) : base(chillflixcontext)
        {
        }
    }
}


