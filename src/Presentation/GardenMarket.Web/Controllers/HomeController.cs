using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
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

        public async Task<IActionResult> Index() =>
            View(await _mainPage.GetViewModel());

        public IActionResult PrivacyPolicy() =>
            View();

        public IActionResult AboutUs() =>
            View();

        public IActionResult Contacts() =>
            View();

        public IActionResult Delivery() =>
            View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() =>
            View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
    }
}