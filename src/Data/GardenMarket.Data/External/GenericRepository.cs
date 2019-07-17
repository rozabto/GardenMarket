using GardenMarket.Data.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace GardenMarket.Data.External
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly GardenMarketDbContext _context;

        public GenericRepository(GardenMarketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task Create(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public IQueryable<TEntity> GetAll() =>
            _context.Set<TEntity>().AsNoTracking();

        public async Task<TEntity> GetById(int id) =>
            await _context.Set<TEntity>().FindAsync(id);

        public async Task Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }

    }
}
