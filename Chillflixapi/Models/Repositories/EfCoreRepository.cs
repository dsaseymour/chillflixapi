using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Chillflixapi.Models.Repositories
{
    public abstract class EfCoreRepository<TEntity, TContext> : MyBaseRepository<TEntity>
    where TContext : DbContext
    where TEntity : class
    {
        private readonly TContext _context;
        private readonly ILogger _logger;

        public EfCoreRepository(TContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
        }

        #region REPOSITORY GET(ID)
        public async Task<TEntity> Get(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }
        #endregion

        #region REPOSITORY GET ALL
        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
        #endregion

        #region REPOSITORY POST
        public async Task<TEntity> Add(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        #endregion

        #region REPOSITORY PUT (ID)
        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
        #endregion

        #region REPOSITORY DELETEID
        public async Task<TEntity> Delete(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            try
            {
                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {



            }
        }
        #endregion

    }



}
