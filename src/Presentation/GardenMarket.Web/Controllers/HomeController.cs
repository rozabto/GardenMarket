using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GardenMarket.Web.Models;
using GardenMarket.ViewModels;
using GardenMarket.Service;

namespace GardenMarket.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductService _product;

        public HomeController(ProductService product)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
