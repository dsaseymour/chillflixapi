using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Entities.Models;

namespace Repositories
{
    public class UserRepository : RepositoryBase<User, int>, IUserRepository
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


        public async Task<IQueryable<User>> GetAllUsers()
        {

        }


        public async Task<User> GetUser(int id)
        {
            return await GetById(id);
        }

        public void DeleteUser(int id)
        {

        }

        public void UpdateUser(User user)
        {

        }

    }


}
