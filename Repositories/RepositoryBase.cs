using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Contracts;
using Entities;
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
        

        public void Delete(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public IQueryable<T> Get(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public IQueryable<T> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public void Update(T entity) => _repositoryContext.Entry(entity).State = EntityState.Modified;

    }



}
