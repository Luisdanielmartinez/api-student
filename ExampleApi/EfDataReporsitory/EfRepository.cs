using ExampleApi.InterfaceReporsitory;
using ExampleApi.Interfaces.InterfaceIEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleApi.EfDataReporsitory
{
    public abstract class EfRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity:class,IEntity
        where TContext:ApplicationDbContext.ApplicationDbContext
    {
        private readonly TContext _context;
        public EfRepository(TContext context)
        {
            _context = context;
        }
        public async Task<TEntity> AddItem(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
           await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> DeleteItem(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity==null)
            {
                return entity;
            }
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<List<TEntity>> GetAll()
        {
            return  _context.Set<TEntity>().ToList();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> UpdateItem(TEntity entity)
        {
            _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
