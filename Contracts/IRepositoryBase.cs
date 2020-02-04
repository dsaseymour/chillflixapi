using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;


namespace Contracts
{
    /*
     *a generic repository to provide CRUD functionality
     *any repository can call on these methods 
     *
     *
     * */
    //https://www.notion.so/dannysas/IEfCoreRepository-9d6b29ff2020415089a078779a64a923
    public interface IRepositoryBase<T> 
    {
        IQueryable<T> GetAll(bool trackChanges);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool trackChanges);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        /*
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        */

        Task<T> GetById(T entity);
        Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate);

        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<T, bool>> predicate);

    }

}
