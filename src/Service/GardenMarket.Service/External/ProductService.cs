using GardenMarket.Data.Interface;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace GardenMarket.Service.External
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _product;

        public ProductService(IRepository<Product> product)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
        }

        public async Task<ProductViewModel> GetViewModel(int id)
        {
            return new ProductViewModel
            {
                Product = await GetProduct(id)
            };
        }

        private async Task<Product> GetProduct(int id) =>
            await _product
                .GetAll()
                .Include(i => i.Images)
                .Include(i => i.Colors)
                .Include(i => i.Types)
                    .ThenInclude(t => (t as ProductType).CharacteristicType)
                .FirstOrDefaultAsync(f => f.Id == id);
    }
}