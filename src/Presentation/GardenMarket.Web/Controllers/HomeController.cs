using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
using GardenMarket.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace GardenMarket.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _product;

        public HomeController(IProductService product)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
        }

        public IActionResult Index()
        {
            var viewModel = new MainPageViewModel
            {
                Products = _product.GetAll()
            };
            return View(viewModel);
        }       

        public IActionResult PrivacyPolicy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Delivery()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}