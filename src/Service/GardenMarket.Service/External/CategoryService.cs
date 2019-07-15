using GardenMarket.Data;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenMarket.Service.External
{
    public class CategoryService : ICategoryService
    {
        private readonly GardenMarketDbContext _context;

        public CategoryService(GardenMarketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(Category obj)
        {
            _context.Categories.Add(obj);
            _context.SaveChanges();
        }

        public async Task AddAsync(Category obj)
        {
            await _context.Categories.AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public IReadOnlyList<Category> GetAll() =>
            _context.Categories.ToList();

        public async Task<IReadOnlyList<Category>> GetAllAsync() =>
            _context.Categories.ToList();

        public Category GetById(int id) =>
            _context.Categories.Find(id);

        public async Task<Category> GetByIdAsync(int id) =>
            await _context.Categories.FindAsync(id);

        public void Remove(Category obj)
        {
            _context.Categories.Remove(obj);
            _context.SaveChanges();
        }

        public async Task RemoveAsync(Category obj)
        {
            _context.Categories.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}
