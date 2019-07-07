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

        public ProductService()
        {
            _context = new GardenMarketDbContext();
        }

        public IList<ProductSampleViewModel> GetAll()
        {
            return new List<ProductSampleViewModel>();
        }
    }
}
