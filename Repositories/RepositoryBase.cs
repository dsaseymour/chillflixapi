using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Repositories
{
    //https://www.notion.so/dannysas/EfCoreRepository-ba39cc24447d44adbbf3358747a3d75e

    public abstract class RepositoryBase<TEntity,Tkey> : IRepositoryBase<TEntity, Tkey> where TEntity : class
    {
        protected ChillflixapiContext _repositoryContext;

        public RepositoryBase( ChillflixapiContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public void Add(TEntity entity) => _repositoryContext.Set<TEntity>().Add(entity);

        public void Delete(TEntity entity) => _repositoryContext.Set<TEntity>().Remove(entity);

        public void Update(TEntity entity) => _repositoryContext.Set<TEntity>().Update(entity);

        #region getting definition
        public  IQueryable<TEntity> GetAll(bool trackchanges) =>  !trackchanges ? _repositoryContext.Set<TEntity>().AsNoTracking() : _repositoryContext.Set<TEntity>();

        public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> expression, bool trackChanges) => !trackChanges ? _repositoryContext.Set<TEntity>().Where(expression).AsNoTracking<TEntity>() : _repositoryContext.Set<TEntity>().Where(expression);

        public async Task<TEntity> FirstOrDefault(Expression<Func<TEntity, bool>> predicate, bool trackChanges) => !trackChanges ? await _repositoryContext.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(predicate) : await _repositoryContext.Set<TEntity>().FirstOrDefaultAsync(predicate) ;

        public async Task<TEntity> GetById(Tkey id, bool trackChanges) =>  await _repositoryContext.Set<TEntity>().FindAsync(id);

        #endregion


        #region counting definition
        public async Task<int> CountAll () =>  await _repositoryContext.Set<TEntity>().CountAsync();

        public async Task<int> CountWhere(Expression<Func<TEntity, bool>> predicate) => await _repositoryContext.Set<TEntity>().CountAsync<TEntity>(predicate);

        #endregion
    }



}
