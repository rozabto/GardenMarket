using GardenMarket.Data;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenMarket.Service.External
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly GardenMarketDbContext _context;

        public SubCategoryService(GardenMarketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(SubCategory obj)
        {
            _context.SubCategories.Add(obj);
            _context.SaveChanges();
        }

        public async Task AddAsync(SubCategory obj)
        {
            await _context.SubCategories.AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public IReadOnlyList<SubCategory> GetAll() =>
            _context.SubCategories.ToList();

        public async Task<IReadOnlyList<SubCategory>> GetAllAsync() =>
            await _context.SubCategories.ToListAsync();

        public IReadOnlyList<SubCategory> GetAllById(int id) =>
            _context.SubCategories.Where(w => w.CategoryId == id).ToList();

        public async Task<IReadOnlyList<SubCategory>> GetAllByIdAsync(int id) =>
            await _context.SubCategories.Where(w => w.CategoryId == id).ToListAsync();

        public SubCategory GetById(int id) =>
            _context.SubCategories.Find(id);

        public async Task<SubCategory> GetByIdAsync(int id) =>
            await _context.SubCategories.FindAsync(id);

        public void Remove(SubCategory obj)
        {
            _context.SubCategories.Remove(obj);
            _context.SaveChanges();
        }

        public async Task RemoveAsync(SubCategory obj)
        {
            _context.SubCategories.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}