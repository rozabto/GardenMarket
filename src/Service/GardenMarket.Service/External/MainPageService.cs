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
    public class MainPageService : IMainPageService
    {
        private readonly IRepository<Product> _product;

        public MainPageService(IRepository<Product> product)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
        }

        public async Task<MainPageViewModel> GetViewModel()
        {
            var viewModel = new MainPageViewModel
            {
                Products = await GetProducts()
            };
            return viewModel;
        }

        private async Task<IReadOnlyList<Product>> GetProducts() =>
            await _product
                .GetAll()
                .Include(i => i.Images)
                .Include(i => i.SubSubCategory)
                    .ThenInclude(i => i.SubCategory)
                .Where(w => !w.DeletedOn.HasValue && w.InStock > 0)
                .OrderByDescending(o => o.Sales)
                .Take(4)
                .ToListAsync();
    }
}