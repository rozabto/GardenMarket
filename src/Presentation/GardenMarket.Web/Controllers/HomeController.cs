using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GardenMarket.Web.Models;
using GardenMarket.ViewModels;
using GardenMarket.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using GardenMarket.SafeCharge;

namespace GardenMarket.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _product;
        private readonly ISafeChargeService _checkOut;

        public HomeController(IProductService product, ISafeChargeService checkOut)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
            _checkOut = checkOut ?? throw new ArgumentNullException(nameof(checkOut));
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexSample()
        {
            var test = new HomePageViewModel
            {
                Name = "Sample",
                ProductSample = _product.GetAll()
            };
            return View(test);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        public IActionResult CheckOut()
        {
            var viewModel = new CheckOutViewModel
            {
                URL = _checkOut.CreateRequest()
            };
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
