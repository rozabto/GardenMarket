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
    public class ProductService : IProductService
    {
        private readonly GardenMarketDbContext _context;

        public ProductService(GardenMarketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(Product obj)
        {
            _context.Products.Add(obj);
            _context.SaveChanges();
        }

        public async Task AddAsync(Product obj)
        {
            await _context.Products.AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public IReadOnlyList<Product> GetAll() =>
            _context.Products.Where(w => !w.Deleted.HasValue).ToList();

        public async Task<IReadOnlyList<Product>> GetAllAsync() =>
            await _context.Products.Where(w => !w.Deleted.HasValue).ToListAsync();

        public IReadOnlyList<Product> GetAllById(int id) =>
            _context.Products.Where(w => w.SubSubCategoryId == id).ToList();

        public async Task<IReadOnlyList<Product>> GetAllByIdAsync(int id) =>
            await _context.Products.Where(w => w.SubSubCategoryId == id).ToListAsync();

        public IReadOnlyList<Product> GetAllIncludingRemoved() =>
            _context.Products.ToList();

        public async Task<IReadOnlyList<Product>> GetAllIncludingRemovedAsync() =>
            await _context.Products.ToListAsync();

        public Product GetById(int id) =>
            _context.Products.Find(id);

        public async Task<Product> GetByIdAsync(int id) =>
            await _context.Products.FindAsync(id);

        public IReadOnlyList<Product> GetRemoved() =>
            _context.Products.Where(w => w.Deleted.HasValue).ToList();

        public async Task<IReadOnlyList<Product>> GetRemovedAsync() =>
            await _context.Products.Where(w => !w.Deleted.HasValue).ToListAsync();

        public void Remove(Product obj)
        {
            var product = _context.Products.Find(obj.Id);
            if (product is null) return;
            product.Deleted = DateTime.UtcNow;
            _context.SaveChanges();
        }

        public async Task RemoveAsync(Product obj)
        {
            var product = await _context.Products.FindAsync(obj.Id);
            if (product is null) return;
            product.Deleted = DateTime.UtcNow;
            await _context.SaveChangesAsync();
        }

        public void RemovePermanently(Product obj)
        {
            _context.Products.Remove(obj);
            _context.SaveChanges();
        }

        public async Task RemovePermanentlyAsync(Product obj)
        {
            _context.Products.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}