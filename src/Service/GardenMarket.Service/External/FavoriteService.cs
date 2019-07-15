using GardenMarket.Data;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace GardenMarket.Service.External
{
    public class FavoriteService : IFavoriteService
    {
        private readonly GardenMarketDbContext _context;

        public FavoriteService(GardenMarketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(Favorite obj)
        {
            _context.Favorites.Add(obj);
            _context.SaveChanges();
        }

        public async Task AddAsync(Favorite obj)
        {
            await _context.Favorites.AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public IReadOnlyList<Favorite> GetAll() =>
            _context.Favorites.ToList();

        public async Task<IReadOnlyList<Favorite>> GetAllAsync() =>
            _context.Favorites.ToList();

        public IReadOnlyList<Favorite> GetAllByUserId(string id) =>
            _context.Favorites.Where(w => w.UserId == id).ToList();

        public async Task<IReadOnlyList<Favorite>> GetAllByUserIdAsync(string id) =>
            _context.Favorites.Where(w => w.UserId == id).ToList();

        public Favorite GetById(int id) =>
            _context.Favorites.Find(id);

        public async Task<Favorite> GetByIdAsync(int id) =>
            await _context.Favorites.FindAsync(id);

        public void Remove(Favorite obj)
        {
            _context.Favorites.Remove(obj);
            _context.SaveChanges();
        }

        public async Task RemoveAsync(Favorite obj)
        {
            _context.Favorites.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}
