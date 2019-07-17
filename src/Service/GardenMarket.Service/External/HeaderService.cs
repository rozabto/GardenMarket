using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GardenMarket.Data.Interface;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace GardenMarket.Service.External
{
    public class HeaderService : IHeaderService
    {
        private readonly IRepository<Category> _category;

        public HeaderService(IRepository<Category> category)
        {
            _category = category ?? throw new ArgumentNullException(nameof(category));
        }

        public async Task<HeaderViewModel> GetViewModel(IReadOnlyList<int> productIds)
        {
            var viewModel = new HeaderViewModel
            {
                Categories = await GetCategories(),
                ProductIds = productIds
            };
            return viewModel;
        }

        private async Task<IReadOnlyList<Category>> GetCategories() =>
            await _category
                .GetAll()
                .Include(i => i.SubCategories)
                    .ThenInclude(t => (t as SubCategory).SubSubCategories)
                .ToListAsync();
    }
}