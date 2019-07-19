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
        private readonly IRepository<Favorite> _favorite;

        public MainPageService(IRepository<Product> product, IRepository<Favorite> favorite)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
            _favorite = favorite ?? throw new ArgumentNullException(nameof(favorite));
        }

        public async Task<MainPageViewModel> GetViewModel(string userId)
        {
            var products = await GetProducts();
            return new MainPageViewModel
            {
                Favorites = userId == null ?
                    new List<Favorite>()
                    : await GetFavorites(products, userId),
                Products = products
            };
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

        private async Task<IReadOnlyList<Favorite>> GetFavorites(IReadOnlyList<Product> products, string userId) =>
            await _favorite
                .GetAll()
                .Where(w => products.Any(a => a.Id == w.ProductId) && w.UserId == userId)
                .ToListAsync();
    }
}