using FinanceManager.Infrastructure.Context;
using FinanceManager.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManager.Infrastructure.Repositories
{
    internal class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DataBaseContext _context;

        public BaseRepository(DataBaseContext dbContext)
        {
            _context = dbContext;
        }

        async public Task<bool> AddAsync(TEntity entity)
        {
            try
            {
                await _context.Set<TEntity>().AddAsync(entity);

                return true;
            } 
            catch (Exception ex)
            {
                return false;
            }
        }

        async public Task<bool> AddRageAsync(List<TEntity> entities)
        {
            try
            {
                await _context.Set<TEntity>().AddRangeAsync(entities);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        async public Task<TEntity> GetByIdAsync(int id)
        {
            try
            {
                return await _context.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool Remove(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Remove(entity);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RemoveRange(List<TEntity> entities)
        {
            try
            {
                _context.Set<TEntity>().RemoveRange(entities);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
