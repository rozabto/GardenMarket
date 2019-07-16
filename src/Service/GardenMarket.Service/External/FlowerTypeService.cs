﻿using GardenMarket.Data;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenMarket.Service.External
{
    public class FlowerTypeService : IFlowerTypeService
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

        public IReadOnlyList<FlowerType> GetAllById(int id) =>
            _context.FlowerTypes.Where(w => w.CharacteristicId == id).ToList();

        public async Task<IReadOnlyList<FlowerType>> GetAllByIdAsync(int id) =>
            await _context.FlowerTypes.Where(w => w.CharacteristicId == id).ToListAsync();

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