using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GardenMarket.Web.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductService _product;
        private readonly IFlowerTypeService _flowerType;
        public CatalogController(IProductService product, IFlowerTypeService flowerType)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
            _flowerType = flowerType ?? throw new ArgumentNullException(nameof(flowerType));
        }

        public IActionResult Index()
        {
            return View();
        }       

        public async Task<IActionResult> GetById(int id)
        {
            var viewModel = new ProductViewModel
            {
                Product = await _product.GetByIdAsync(id),
                Colors = await _flowerType.GetAllAsync()
            };
            return View();
        }
    }
}