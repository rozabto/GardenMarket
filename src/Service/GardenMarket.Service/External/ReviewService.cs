using GardenMarket.Data;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenMarket.Service.External
{
    public class ReviewService : IReviewService
    {
        private readonly GardenMarketDbContext _context;

        public ReviewService(GardenMarketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(Review obj)
        {
            _context.Reviews.Add(obj);
            _context.SaveChanges();
        }

        public async Task AddAsync(Review obj)
        {
            await _context.Reviews.AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public IReadOnlyList<Review> GetAll()
        {
            return _context.Reviews.ToList();
        }

        public async Task<IReadOnlyList<Review>> GetAllAsync()
        {
            var reviews = await _context.Reviews.ToListAsync();
            return reviews;
        }

        public Review GetById(int id)
        {
            return _context.Reviews.Find(id);
        }

        public async Task<Review> GetByIdAsync(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            return review;
        }

        public void Remove(Review obj)
        {
            _context.Reviews.Remove(obj);
            _context.SaveChanges();
        }

        public async Task RemoveAsync(Review obj)
        {
            _context.Reviews.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}
