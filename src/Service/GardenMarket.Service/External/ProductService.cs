using GardenMarket.Data;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using System;
using System.Linq;
using System.Collections.Generic;
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
            _context.Products.Add(obj);
            await _context.SaveChangesAsync();
        }

        public IList<Product> GetAll() =>
            _context.Products.Where(w => !w.Deleted.HasValue).ToList();

        public async Task<IList<Product>> GetAllAsync() =>
            _context.Products.Where(w => !w.Deleted.HasValue).ToList();

        public IList<Product> GetAllIncludingRemoved() =>
            _context.Products.ToList();

        public async Task<IList<Product>> GetAllIncludingRemovedAsync() =>
            _context.Products.ToList();

        public Product GetById(string id) =>
            _context.Products.Find(id);

        public async Task<Product> GetByIdAsync(string id) =>
            await _context.Products.FindAsync(id);

        public IList<Product> GetRemoved() =>
            _context.Products.Where(w => w.Deleted.HasValue).ToList();

        public async Task<IList<Product>> GetRemovedAsync() =>
            _context.Products.Where(w => !w.Deleted.HasValue).ToList();

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
