using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Entities.Models;

namespace Repositories
{
    public class UserRepository : RepositoryBase<User, int>, IUserRepository<int>
    {

        public UserRepository(ChillflixapiContext chillflixcontext) : base(chillflixcontext)
        {
        }

        public IQueryable<User> GetAllUsers(bool trackChanges) => GetAll(trackChanges);

        public async Task<User> GetUserAsync(int id, bool trackChanges) => await GetById(id, trackChanges);

        public IQueryable<User> GetByIdsAsync(IEnumerable<int> ids, bool trackChanges) => GetWhere(x => ids.Contains(x.Id), trackChanges);

        public void CreateUser(User user) => Add(user);

        public async Task DeleteUser(int id) => Delete(await GetUserAsync(id,true));

        public void UpdateUser(User user) => Update(user);
    }
}
