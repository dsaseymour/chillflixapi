using System;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAuthRepository
    {
        //https://www.notion.so/dannysas/IAuthRepository-213b60c8dff04697a317f2030b2154a3
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
