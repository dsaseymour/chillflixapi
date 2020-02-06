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
    public interface IRepositoryBase<TEntity,Tkey>
    {
        IQueryable<TEntity> GetAll(bool trackChanges);
        IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> expression, bool trackChanges);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> predicate);
        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> GetById(Tkey id);


        /*
         * 
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        */

    }

}
