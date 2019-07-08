using AutoMapper;
using GardenMarket.Data;
using GardenMarket.Models;
using GardenMarket.Service.Interface;
using GardenMarket.ViewModels;
using System;
using System.Linq;
using System.Collections.Generic;

namespace GardenMarket.Service.External
{
    public class ProductService : IProductService
    {
        private readonly GardenMarketDbContext _context;
        private readonly IMapper _mapper;

        public ProductService(GardenMarketDbContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public IList<ProductSampleViewModel> GetAll()
        {
            var dtos = _context.Products;
            return (from dto in dtos
                    let product = new Product(dto.Id, dto.Name, dto.Description)
                    select new ProductSampleViewModel
                    {
                        Name = product.Name
                    }).ToList();
        }
    }
}
