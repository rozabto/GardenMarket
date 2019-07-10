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
            _context.Carts.Add(obj);
            await _context.SaveChangesAsync();
        }

        public IList<Cart> GetAll() =>
            _context.Carts.ToList();

        public async Task<IList<Cart>> GetAllAsync() =>
            _context.Carts.ToList();

        public IList<Cart> GetAllByUserId(string id) =>
            _context.Carts.Where(w => w.User.Id == id).ToList();

        public async Task<IList<Cart>> GetAllByUserIdAsync(string id) =>
            _context.Carts.Where(w => w.User.Id == id).ToList();

        public Cart GetById(string id) =>
            _context.Carts.Find(id);

        public async Task<Cart> GetByIdAsync(string id) =>
            await _context.Carts.FindAsync(id);

        public void Remove(Cart obj)
        {
            var comment = _context.Comments.Find(obj.Id);
            if (comment is null) return;
            comment.Deleted = DateTime.UtcNow;
            _context.SaveChanges();
        }

        public async Task RemoveAsync(Cart obj)
        {
            var comment = await _context.Comments.FindAsync(obj.Id);
            if (comment is null) return;
            comment.Deleted = DateTime.UtcNow;
            await _context.SaveChangesAsync();
        }
    }
}
