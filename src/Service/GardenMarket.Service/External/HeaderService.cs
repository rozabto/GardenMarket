using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly IRepository<Product> _product;
        private readonly IRepository<Cart> _cart;

        public HeaderService(IRepository<Category> category, IRepository<Product> product, IRepository<Cart> cart)
        {
            _category = category ?? throw new ArgumentNullException(nameof(category));
            _product = product ?? throw new ArgumentNullException(nameof(product));
            _cart = cart ?? throw new ArgumentNullException(nameof(cart));
        }

        public async Task<HeaderViewModel> GetViewModel(string userId)
        {
            return new HeaderViewModel
            {
                Categories = await GetCategories(),
                Carts = await GetCarts(userId)
            };
        }

        public async Task<HeaderViewModel> GetViewModel(IReadOnlyList<CartHolder> productIds)
        {
            return new HeaderViewModel
            {
                Carts = await GetCarts(productIds),
                Categories = await GetCategories()
            };
        }

        private async Task<IReadOnlyList<Category>> GetCategories() =>
            await _category
                .GetAll()
                .Include(i => i.SubCategories)
                    .ThenInclude(t => (t as SubCategory).SubSubCategories)
                .ToListAsync();

        private async Task<IReadOnlyList<Cart>> GetCarts(string userId) =>
            await _cart
                .GetAll()
                .Include(i => i.Product)
                    .ThenInclude(i => i.Images)
                .Where(w => !w.Product.DeletedOn.HasValue && w.Product.InStock > 0 && w.UserId == userId)
                .ToListAsync();

        private async Task<IReadOnlyList<Cart>> GetCarts(IReadOnlyList<CartHolder> ids) =>
            await _product
                .GetAll()
                .Include(i => i.Images)
                .Where(w => ids.Any(a => a.Id == w.Id) && !w.DeletedOn.HasValue && w.InStock > 0)
                .Select(s => new Cart
                {
                    Id = -1,
                    Product = s,
                    UserId = null,
                    Amount = ids.First(f => f.Id == s.Id).Amount,
                    ProductId = s.Id
                })
                .ToListAsync();
    }
}