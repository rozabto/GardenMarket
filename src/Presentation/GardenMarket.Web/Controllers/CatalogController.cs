using GardenMarket.Common;
using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GardenMarket.Web.Controllers
{
    public class CatalogController : Controller
    {
        private readonly ISafeChargeService _safeCharge;
        private readonly ICatalogService _category;
        private readonly IProductService _product;

        public CatalogController(ISafeChargeService safeCharge, ICatalogService category, IProductService product)
        {
            _safeCharge = safeCharge ?? throw new ArgumentNullException(nameof(safeCharge));
            _category = category ?? throw new ArgumentNullException(nameof(category));
            _product = product ?? throw new ArgumentNullException(nameof(product));
        }

        [Route("{controller}/{id}")]
        public async Task<IActionResult> Index(int id) =>
            View(await _category.GetViewModel(id));

        [Route("{controller}/p/{id}")]
        public async Task<IActionResult> GetById(int id) =>
            View(await _product.GetViewModel(id));

        public IActionResult Checkout() =>
            View(new CheckoutViewModel
            {
                Url = _safeCharge.CreateRequest()
            });
    }
}