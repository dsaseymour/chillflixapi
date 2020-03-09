using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface IUserRepository<Tkey>
    {
        //https://www.notion.so/dannysas/IUserRepository-5cd139967c4e47f59abe460487760422
        IQueryable<User> GetAllUsers(bool trackChanges);
        Task<User> GetUserAsync(Tkey id, bool trackChanges);
        IQueryable<User> GetByIdsAsync(IEnumerable<Tkey> ids, bool trackChanges);
        void CreateUser(User user);
        Task DeleteUser(Tkey id);
        void UpdateUser(User user);
    }
}
