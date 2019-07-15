using GardenMarket.Data;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenMarket.Service.External
{
    public class SubSubCategoryService : ISubSubCategoryService
    {
        private readonly GardenMarketDbContext _context;

        public SubSubCategoryService(GardenMarketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(SubSubCategory obj)
        {
            _context.SubSubCategories.Add(obj);
            _context.SaveChanges();
        }

        public async Task AddAsync(SubSubCategory obj)
        {
            await _context.SubSubCategories.AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public IReadOnlyList<SubSubCategory> GetAll() =>
            _context.SubSubCategories.ToList();

        public async Task<IReadOnlyList<SubSubCategory>> GetAllAsync() =>
            _context.SubSubCategories.ToList();

        public IReadOnlyList<SubSubCategory> GetAllById(int id) =>
            _context.SubSubCategories.Where(w => w.SubCategoryId == id).ToList();

        public async Task<IReadOnlyList<SubSubCategory>> GetAllByIdAsync(int id) =>
            _context.SubSubCategories.Where(w => w.SubCategoryId == id).ToList();

        public SubSubCategory GetById(int id) =>
            _context.SubSubCategories.Find(id);

        public async Task<SubSubCategory> GetByIdAsync(int id) =>
            await _context.SubSubCategories.FindAsync(id);

        public void Remove(SubSubCategory obj)
        {
            _context.SubSubCategories.Remove(obj);
            _context.SaveChanges();
        }

        public async Task RemoveAsync(SubSubCategory obj)
        {
            _context.SubSubCategories.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}
