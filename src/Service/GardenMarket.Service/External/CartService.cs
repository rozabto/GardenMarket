using GardenMarket.Data;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace GardenMarket.Service.External
{
    public class CartService : ICartService
    {
        private readonly GardenMarketDbContext _context;

        public CartService(GardenMarketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(Cart obj)
        {
            _context.Carts.Add(obj);
            _context.SaveChanges();
        }

        public async Task AddAsync(Cart obj)
        {
            await _context.Carts.AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public IReadOnlyList<Cart> GetAll() =>
            _context.Carts.ToList();

        public async Task<IReadOnlyList<Cart>> GetAllAsync() =>
            _context.Carts.ToList();

        public IReadOnlyList<Cart> GetAllByUserId(string id) =>
            _context.Carts.Where(w => w.UserId == id).ToList();

        public async Task<IReadOnlyList<Cart>> GetAllByUserIdAsync(string id) =>
            _context.Carts.Where(w => w.UserId == id).ToList();

        public Cart GetById(int id) =>
            _context.Carts.Find(id);

        public async Task<Cart> GetByIdAsync(int id) =>
            await _context.Carts.FindAsync(id);

        public void Remove(Cart obj)
        {
            _context.Carts.Remove(obj);
            _context.SaveChanges();
        }

        public async Task RemoveAsync(Cart obj)
        {
            _context.Carts.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}
