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
    public class CharacteristicCategoryService : ICharacteristicCategoryService
    {
        private readonly GardenMarketDbContext _context;

        public CharacteristicCategoryService(GardenMarketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(CharacteristicCategory obj)
        {
            _context.CharacteristicCategories.Add(obj);
            _context.SaveChanges();
        }

        public async Task AddAsync(CharacteristicCategory obj)
        {
            await _context.CharacteristicCategories.AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public IReadOnlyList<CharacteristicCategory> GetAll()
        {
            return _context.CharacteristicCategories.ToList();
        }

        public async Task<IReadOnlyList<CharacteristicCategory>> GetAllAsync()
        {
            var characteristicCategrories = await _context.CharacteristicCategories.ToListAsync();
            return characteristicCategrories;
        }

        public CharacteristicCategory GetById(int id)
        {
            return _context.CharacteristicCategories.Find(id);
        }

        public async Task<CharacteristicCategory> GetByIdAsync(int id)
        {
            var characteristicCategory = await _context.CharacteristicCategories.FindAsync(id);
            return characteristicCategory;
        }

        public void Remove(CharacteristicCategory obj)
        {
            _context.CharacteristicCategories.Remove(obj);
        }

        public async Task RemoveAsync(CharacteristicCategory obj)
        {
            _context.CharacteristicCategories.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}