using GardenMarket.Service.Interface;
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
            return View(await _product.GetByIdAsync(id));
        }
    }
}