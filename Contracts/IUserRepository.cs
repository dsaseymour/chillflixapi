using System.Linq;
using Entities.Models;

namespace Contracts
{
    public interface IUserRepository
    {
        //https://www.notion.so/dannysas/IUserRepository-5cd139967c4e47f59abe460487760422
        IQueryable<User> GetAllUsers(bool trackChanges);
        User GetUser(int id);
        void DeleteUser(int id);
        void UpdateUser(User user);
    }
}
