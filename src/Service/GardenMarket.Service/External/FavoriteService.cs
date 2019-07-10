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
            _context.Favorites.Add(obj);
            await _context.SaveChangesAsync();
        }

        public IList<Favorite> GetAll() =>
            _context.Favorites.ToList();

        public async Task<IList<Favorite>> GetAllAsync() =>
            _context.Favorites.ToList();

        public IList<Favorite> GetAllByUserId(string id) =>
            _context.Favorites.Where(w => w.User.Id == id).ToList();

        public async Task<IList<Favorite>> GetAllByUserIdAsync(string id) =>
            _context.Favorites.Where(w => w.User.Id == id).ToList();

        public Favorite GetById(string id) =>
            _context.Favorites.Find(id);

        public async Task<Favorite> GetByIdAsync(string id) =>
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
