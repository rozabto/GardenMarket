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
    public class ProductImageService : IProductImageService
    {
        private readonly GardenMarketDbContext _context;

        public ProductImageService(GardenMarketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(ProductImage obj)
        {
            _context.ProductImages.Add(obj);
            _context.SaveChanges();
        }

        public async Task AddAsync(ProductImage obj)
        {
            await _context.ProductImages.AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public IReadOnlyList<ProductImage> GetAll() =>
            _context.ProductImages.ToList();

        public async Task<IReadOnlyList<ProductImage>> GetAllAsync() =>
            await _context.ProductImages.ToListAsync();

        public IReadOnlyList<ProductImage> GetAllById(int id) =>
            _context.ProductImages.Where(w => w.ProductId == id).ToList();

        public async Task<IReadOnlyList<ProductImage>> GetAllByIdAsync(int id) =>
            await _context.ProductImages.Where(w => w.ProductId == id).ToListAsync();

        public ProductImage GetById(int id) =>
            _context.ProductImages.Find(id);

        public async Task<ProductImage> GetByIdAsync(int id) =>
            await _context.ProductImages.FindAsync(id);

        public void Remove(ProductImage obj)
        {
            _context.ProductImages.Remove(obj);
            _context.SaveChanges();
        }

        public async Task RemoveAsync(ProductImage obj)
        {
            _context.ProductImages.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}