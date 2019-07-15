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
            await _context.Comments.AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public IReadOnlyList<Comment> GetAll() =>
            _context.Comments.Where(w => !w.Deleted.HasValue).ToList();

        public async Task<IReadOnlyList<Comment>> GetAllAsync() =>
            _context.Comments.Where(w => !w.Deleted.HasValue).ToList();

        public IReadOnlyList<Comment> GetAllByUserId(string id) =>
            _context.Comments.Where(w => w.UserId == id).ToList();

        public async Task<IReadOnlyList<Comment>> GetAllByUserIdAsync(string id) =>
            _context.Comments.Where(w => w.UserId == id).ToList();

        public IReadOnlyList<Comment> GetAllIncludingRemoved() =>
            _context.Comments.ToList();

        public async Task<IReadOnlyList<Comment>> GetAllIncludingRemovedAsync() =>
            _context.Comments.ToList();

        public Comment GetById(int id) =>
            _context.Comments.Find(id);

        public async Task<Comment> GetByIdAsync(int id) =>
            await _context.Comments.FindAsync(id);

        public IReadOnlyList<Comment> GetRemoved() =>
            _context.Comments.Where(w => w.Deleted.HasValue).ToList();

        public async Task<IReadOnlyList<Comment>> GetRemovedAsync() =>
            _context.Comments.Where(w => w.Deleted.HasValue).ToList();

        public void Remove(Comment obj)
        {
            var comment = _context.Comments.Find(obj.Id);
            if (comment is null) return;
            comment.Deleted = DateTime.UtcNow;
            _context.SaveChanges();
        }

        public async Task RemoveAsync(Comment obj)
        {
            var comment = await _context.Comments.FindAsync(obj.Id);
            if (comment is null) return;
            comment.Deleted = DateTime.UtcNow;
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
