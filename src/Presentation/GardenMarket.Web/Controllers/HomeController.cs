using GardenMarket.Service.Interface;
using GardenMarket.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GardenMarket.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMainPageService _mainPage;

        public HomeController(IMainPageService mainPage)
        {
            _mainPage = mainPage ?? throw new ArgumentNullException(nameof(mainPage));
        }

        public async Task<IActionResult> Index()
        {
            return View(await _mainPage.GetViewModel());
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