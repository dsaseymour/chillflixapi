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
        Task<TEntity> GetById(Tkey id, bool trackChanges);
        Task<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> predicate, bool trackChanges);

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<TEntity, bool>> predicate);
       
    }

}
