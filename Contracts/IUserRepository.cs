using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface IUserRepository<Tkey>
    {
        //https://www.notion.so/dannysas/IUserRepository-5cd139967c4e47f59abe460487760422
        Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges);
        Task<User> GetUserAsync(Tkey id);
        Task<IEnumerable<User>> GetByIdsAsync(IEnumerable<Tkey> ids, bool trackChanges);
        void CreateUser(User user);
        void DeleteUser(Tkey id);
        void UpdateUser(User user);
    }
}
