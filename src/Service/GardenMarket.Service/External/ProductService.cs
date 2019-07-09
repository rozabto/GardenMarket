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
            _context.Products.ToList();

        public async Task<IList<Product>> GetAllAsync() =>
            _context.Products.ToList();

        public Product GetById(string id) =>
            _context.Products.FirstOrDefault(f => f.Id == id);

        public async Task<Product> GetByIdAsync(string id) =>
            _context.Products.FirstOrDefault(f => f.Id == id);

        public void Remove(Product obj)
        {
            _context.Products.Remove(obj);
            _context.SaveChanges();
        }

        public async Task RemoveAsync(Product obj)
        {
            _context.Products.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}
