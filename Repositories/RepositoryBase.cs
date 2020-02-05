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

    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ChillflixapiContext _repositoryContext;

        public RepositoryBase( ChillflixapiContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public void Add(T entity) => _repositoryContext.Set<T>().Add(entity);

        public void Delete(T entity) => _repositoryContext.Set<T>().Remove(entity);

        public void Update(T entity) => _repositoryContext.Set<T>().Update(entity);

        public IQueryable<T> GetAll(bool trackchanges) => !trackchanges ? _repositoryContext.Set<T>().AsNoTracking() : _repositoryContext.Set<T>();
        
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool trackChanges) => !trackChanges ? _repositoryContext.Set<T>().Where(expression).AsNoTracking(): _repositoryContext.Set<T>().Where(expression);

        public async Task<int> CountAll () =>  await _repositoryContext.Set<T>().CountAsync();

        public async Task<int> CountWhere(Expression<Func<T, bool>> predicate) => await _repositoryContext.Set<T>().CountAsync<T>(predicate);

        public async Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate) => await _repositoryContext.Set<T>().FirstOrDefaultAsync(predicate);

    }



}
