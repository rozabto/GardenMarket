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
    class FlowerTypeService : IFlowerTypeService
    {
        private readonly GardenMarketDbContext _context;

        public FlowerTypeService(GardenMarketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(FlowerType obj)
        {
            _context.FlowerTypes.Add(obj);
            _context.SaveChanges();
        }

        public async Task AddAsync(FlowerType obj)
        {
            await _context.FlowerTypes.AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public IReadOnlyList<FlowerType> GetAll()
        {
            return _context.FlowerTypes.ToList();
        }

        public async Task<IReadOnlyList<FlowerType>> GetAllAsync()
        {
            var flowerTypes = await _context.FlowerTypes.ToListAsync();
            return flowerTypes;
        }

        public FlowerType GetById(int id)
        {
            return _context.FlowerTypes.Find(id);
        }

        public async Task<FlowerType> GetByIdAsync(int id)
        {
            var flowerType = await _context.FlowerTypes.FindAsync(id);
            return flowerType;
        }

        public void Remove(FlowerType obj)
        {
            _context.FlowerTypes.Remove(obj);
            _context.SaveChanges();
        }

        public async Task RemoveAsync(FlowerType obj)
        {
            _context.FlowerTypes.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}
