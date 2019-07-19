using GardenMarket.Service.Interface;
using GardenMarket.ViewModel;
using Microsoft.AspNetCore.Authorization;
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
        private readonly IContactService _contact;

        public HomeController(IMainPageService mainPage, IContactService contact)
        {
            _mainPage = mainPage ?? throw new ArgumentNullException(nameof(mainPage));
            _contact = contact ?? throw new ArgumentNullException(nameof(contact));
        }

        public async Task<IActionResult> Index() =>
            View(await _mainPage.GetViewModel(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)));

        public IActionResult Privacy() =>
            View();

        public IActionResult About() =>
            View();

        [HttpGet]
        public async Task<IActionResult> Contact() =>
            View(await _contact.GetViewModel());

        [HttpPost]
        public async Task<IActionResult> Contact(string firstname, string lastname, string email, string subject) =>
            View(await _contact.GetViewModel(firstname, lastname, email, subject));

        public IActionResult Delivery() =>
            View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() =>
            View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}