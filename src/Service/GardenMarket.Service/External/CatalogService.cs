using GardenMarket.Data.Interface;
using GardenMarket.Models;
using GardenMarket.Service.Extension;
using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenMarket.Service.External
{
    public class CatalogService : ICatalogService
    {
        private readonly IRepository<SubCategory> _subCategory;
        private readonly IRepository<Characteristic> _characteristic;
        private readonly IRepository<SubSubCategory> _subSubCategory;

        public CatalogService(IRepository<SubCategory> subCategory, IRepository<Characteristic> characteristic, IRepository<SubSubCategory> subSubCategory)
        {
            _subCategory = subCategory ?? throw new ArgumentNullException(nameof(subCategory));
            _characteristic = characteristic ?? throw new ArgumentNullException(nameof(characteristic));
            _subSubCategory = subSubCategory ?? throw new ArgumentNullException(nameof(subSubCategory));
        }

        public async Task<CatalogViewModel> GetViewModel(int id)
        {
            var subSubCategory = await GetSubSubCategory(id);
            var count = subSubCategory.Products.Count;
            subSubCategory.Products = subSubCategory.Products.CustomTake(9);

            return new CatalogViewModel
            {
                ProductCount = count,
                SubSubCategory = subSubCategory,
                SubCategories = await GetSubCategories(subSubCategory.SubCategory.CategoryId),
                Characteristics = await GetCharacteristics()
            };
        }

        private async Task<SubSubCategory> GetSubSubCategory(int id) =>
            await _subSubCategory
                .GetAll()
                .Include(i => i.Products)
                    .ThenInclude(i => (i as Product).Images)
                .Include(i => i.Products)
                    .ThenInclude(i => (i as Product).Types)
                        .ThenInclude(i => (i as ProductType).CharacteristicType)
                .Include(i => i.SubCategory)
                .FirstOrDefaultAsync(f => f.Id == id);

        private async Task<IReadOnlyList<SubCategory>> GetSubCategories(int id) =>
            await _subCategory.GetAll()
                .Include(i => i.SubSubCategories)
                .Where(w => w.CategoryId == id)
                .ToListAsync();

        private async Task<IReadOnlyList<Characteristic>> GetCharacteristics() =>
            await _characteristic
                .GetAll()
                .Include(i => i.CharacteristicTypes)
                .ToListAsync();
    }
}
