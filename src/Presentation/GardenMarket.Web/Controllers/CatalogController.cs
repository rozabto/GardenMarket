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

        public CatalogController(IProductService product)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("p/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var viewModel = new ProductViewModel
            {
                Product = await _product.GetByIdAsync(id),
                Colors = 
            };
            return View();
        }
    }
}