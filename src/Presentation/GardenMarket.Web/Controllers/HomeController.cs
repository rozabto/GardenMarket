﻿using GardenMarket.Models;
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
        private readonly IProductService _product;
        private readonly IReviewService _review;

        public HomeController(IProductService product, IReviewService review)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
            _review = review ?? throw new ArgumentNullException(nameof(review));
        }

        public async Task<IActionResult> Index() =>
            View(await _mainPage.GetViewModel(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)));

        public IActionResult PrivacyPolicy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacts(string firstname, string lastname, string email, string subject)
        {            
            var review = new Review
            {
                FirstName = firstname,
                LastName = lastname,
                Email = email,
                Subject = subject
            };
            _review.Add(review);
            var contactViewModel = new ContactsViewModel
            {
                FirstName = firstname,
                LastName = lastname,
                ReviewSent = true,
                ReviewsWritten = _review.GetAll().Count
            };
            return View(contactViewModel);
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            var contactViewModel = new ContactsViewModel
            {
                FirstName = "",
                LastName = "",
                ReviewSent = false,
                ReviewsWritten = _review.GetAll().Count
            };
            return View(contactViewModel);
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