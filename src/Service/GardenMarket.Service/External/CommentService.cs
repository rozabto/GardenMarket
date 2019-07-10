using GardenMarket.Data;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace GardenMarket.Service.External
{
    public class CommentService : ICommentService
    {
        private readonly GardenMarketDbContext _context;

        public CommentService(GardenMarketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(Comment obj)
        {
            _context.Comments.Add(obj);
            _context.SaveChanges();
        }

        public async Task AddAsync(Comment obj)
        {
            _context.Comments.Add(obj);
            await _context.SaveChangesAsync();
        }

        public IList<Comment> GetAll() =>
            _context.Comments.Where(w => !w.Deleted.HasValue).ToList();

        public async Task<IList<Comment>> GetAllAsync() =>
            _context.Comments.Where(w => !w.Deleted.HasValue).ToList();

        public IList<Comment> GetAllByUserId(string id) =>
            _context.Comments.Where(w => w.User.Id == id).ToList();

        public async Task<IList<Comment>> GetAllByUserIdAsync(string id) =>
            _context.Comments.Where(w => w.User.Id == id).ToList();

        public IList<Comment> GetAllIncludingRemoved() =>
            _context.Comments.ToList();

        public async Task<IList<Comment>> GetAllIncludingRemovedAsync() =>
            _context.Comments.ToList();

        public Comment GetById(string id) =>
            _context.Comments.Find(id);

        public async Task<Comment> GetByIdAsync(string id) =>
            await _context.Comments.FindAsync(id);

        public IList<Comment> GetRemoved() =>
            _context.Comments.Where(w => w.Deleted.HasValue).ToList();

        public async Task<IList<Comment>> GetRemovedAsync() =>
            _context.Comments.Where(w => w.Deleted.HasValue).ToList();

        public void Remove(Comment obj)
        {
            _context.Comments.Remove(obj);
            _context.SaveChanges();
        }

        public async Task RemoveAsync(Comment obj)
        {
            _context.Comments.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public void RemovePermanently(Comment obj)
        {
            _context.Comments.Remove(obj);
            _context.SaveChanges();
        }

        public async Task RemovePermanentlyAsync(Comment obj)
        {
            _context.Comments.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}
