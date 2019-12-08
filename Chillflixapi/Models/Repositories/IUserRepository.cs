using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Chillflixapi.Models.Repositories
{
    public interface IUserRepository<User> 
    {
    void SaveUser(User user);
    IEnumerable<User> GetAllUsers();
    User GetUser(int id);
    void DeletedStudent(int id);
    void UpdateUser(User user);
    }


}
