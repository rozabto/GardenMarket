using GardenMarket.Data;
using GardenMarket.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace GardenMarket.Service
{
    public class ProductService
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
