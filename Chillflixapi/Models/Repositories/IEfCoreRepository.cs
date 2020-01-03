using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace Chillflixapi.Models.Repositories
{
    //https://www.notion.so/dannysas/IEfCoreRepository-9d6b29ff2020415089a078779a64a923
    public interface IEfCoreRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }

}
