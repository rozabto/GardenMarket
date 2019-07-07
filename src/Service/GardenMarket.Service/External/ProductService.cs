using GardenMarket.Data;
using GardenMarket.Service.Interface;
using GardenMarket.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GardenMarket.Service.External
{
    public class ProductService : IProductService
    {
        private readonly GardenMarketDbContext _context;

        public ProductService(GardenMarketDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IList<ProductSampleViewModel> GetAll()
        {
            return new List<ProductSampleViewModel>();
        }
    }
}
