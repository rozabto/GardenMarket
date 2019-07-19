using GardenMarket.Models;
using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GardenMarket.Web.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly IMainPageService _mainPage;

        public HomeController(IMainPageService mainPage)
        {
            _mainPage = mainPage ?? throw new ArgumentNullException(nameof(mainPage));
        }

        public async Task<IActionResult> Index() =>
            View(await _mainPage.GetViewModel(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)));

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