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
    public class CharacteristicService : ICharacteristicService
    {
        private readonly GardenMarketDbContext _context;

        public CharacteristicService(GardenMarketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(Characteristic obj)
        {
            _context.Characteristics.Add(obj);
            _context.SaveChanges();
        }

        public async Task AddAsync(Characteristic obj)
        {
            await _context.Characteristics.AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public IReadOnlyList<Characteristic> GetAll()
        {
            return _context.Characteristics.ToList();
        }

        public async Task<IReadOnlyList<Characteristic>> GetAllAsync()
        {
            var characteristics = await _context.Characteristics.ToListAsync();
            return characteristics;
        }

        public Characteristic GetById(int id)
        {
            return _context.Characteristics.Find(id);
        }

        public async Task<Characteristic> GetByIdAsync(int id)
        {
            var characteristic = await _context.Characteristics.FindAsync(id);
            return characteristic;
        }

        public void Remove(Characteristic obj)
        {
            _context.Characteristics.Remove(obj);
        }

        public async Task RemoveAsync(Characteristic obj)
        {
            _context.Characteristics.Remove(obj);
            await _context.SaveChangesAsync();
        }
    }
}
