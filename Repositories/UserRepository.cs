using System;
using Contracts;
using Entities;

namespace Repositories
{
    public class UserRepository : EfCoreRepository<User, ChillflixapiContext>
    {

        public UserRepository(ChillflixapiContext chillflixcontext) : base(chillflixcontext)
        {
        }



        /*
         *    void SaveUser(User user);
            IEnumerable<User> GetAllUsers();
            User GetUser(int id);
            void DeletedStudent(int id);
            void UpdateUser(User user);

         * */

    }


}
