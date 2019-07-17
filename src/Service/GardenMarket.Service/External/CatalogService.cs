using GardenMarket.Data.Interface;
using GardenMarket.Models;
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
        private readonly IRepository<Product> _product;

        public CatalogService(IRepository<SubCategory> subCategory, IRepository<Characteristic> characteristic, IRepository<SubSubCategory> subSubCategory, IRepository<Product> product)
        {
            _subCategory = subCategory ?? throw new ArgumentNullException(nameof(subCategory));
            _characteristic = characteristic ?? throw new ArgumentNullException(nameof(characteristic));
            _subSubCategory = subSubCategory ?? throw new ArgumentNullException(nameof(subSubCategory));
            _product = product ?? throw new ArgumentNullException(nameof(product));
        }

        public async Task<CatalogViewModel> GetViewModel(int id)
        {
            var subSubCategory = await GetSubSubCategory(id);
            subSubCategory.Products = await GetProduct(subSubCategory.Id);

            var viewModel = new CatalogViewModel
            {
                SubSubCategory = subSubCategory,
                SubCategories = await GetSubCategories(subSubCategory.SubCategory.CategoryId),
                Characteristics = await GetCharacteristics()
            };
            return viewModel;
        }

        private async Task<SubSubCategory> GetSubSubCategory(int id) =>
            await _subSubCategory
                .GetAll()
                .Include(i => i.SubCategory)
                .FirstOrDefaultAsync(f => f.Id == id);

        private async Task<ICollection<Product>> GetProduct(int id) =>
            await _product
                .GetAll()
                .Include(i => i.Images)
                .Where(w => w.SubSubCategoryId == id)
                .ToListAsync();

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
